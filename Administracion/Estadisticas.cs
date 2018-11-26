using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using Administracion.ServicioWeb;

using System.Xml.Linq;
using System.Configuration;


namespace Administracion
{
    public partial class Estadisticas : Form
    {
        private string Carga;
        public Estadisticas()
        {
            InitializeComponent();
            this.CargoDatos();
            lblError.Text = "";

            List<Terminal> Terminales = new List<Terminal>();
            Terminales = new Administracion.ServicioWeb.ServicioTURU().ListarTerminales().ToList();

        }

        private void CargoDatos()
        {
            try
            {
                ServicioTURU Sewb = new ServicioTURU();
                this.Carga = Sewb.ViajesXML();
                XElement XML = XElement.Parse(Carga);
                var datos = (from viaje in XML.Elements("Viaje")
                             select new
                             {
                                 NumeroViaje = viaje.Element("Numero").Value,
                                 CiudadDestino = viaje.Element("CiudadDestino").Value,
                                 PaisDestino = viaje.Element("PaisDestino").Value,
                                 Compañia = viaje.Element("Compañia").Value,
                                 FechaPartida = viaje.Element("FechaPartida").Value
                             });
                gvViajes.DataSource = datos.ToList();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnFechas_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioTURU Sewb = new ServicioTURU();
                this.Carga = Sewb.ViajesXML();
                XElement XML = XElement.Parse(Carga);
                var Filtro = (from viaje in XML.Elements("Viaje")
                              where (Convert.ToDateTime(viaje.Element("FechaPartida").Value).Date >= dateFecha1.Value.Date) && (Convert.ToDateTime(viaje.Element("FechaPartida").Value).Date <= dateFecha2.Value.Date)
                              select new
                              {
                                  NumeroViaje = viaje.Element("Numero").Value,
                                  CiudadDestino = viaje.Element("CiudadDestino").Value,
                                  PaisDestino = viaje.Element("PaisDestino").Value,
                                  Compañia = viaje.Element("Compañia").Value,
                                  FechaPartida = viaje.Element("FechaPartida").Value
                              });
                gvViajes.DataSource = Filtro.ToList();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnFiltroPais_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioTURU Sewb = new ServicioTURU();
                this.Carga = Sewb.ViajesXML();
                XElement XML = XElement.Parse(Carga);
                var Filtro = (from viaje in XML.Elements("Viaje")
                              where (string)viaje.Element("PaisDestino") == cbPais.Text.Trim()
                              select new
                              {
                                  NumeroViaje = viaje.Element("Numero").Value,
                                  CiudadDestino = viaje.Element("CiudadDestino").Value,
                                  PaisDestino = viaje.Element("PaisDestino").Value,
                                  Compañia = viaje.Element("Compañia").Value,
                                  FechaPartida = viaje.Element("FechaPartida").Value
                              });
                gvViajes.DataSource = Filtro.ToList();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnViajesAnuales_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioTURU Sewb = new ServicioTURU();
                this.Carga = Sewb.ViajesXML();
                XElement XML = XElement.Parse(Carga);
                var Filtro = (from viaje in XML.Elements("Viaje")
                              group viaje by new
                              {
                                  anio = Convert.ToDateTime(viaje.Element("FechaPartida").Value).Year,
                                  comp = viaje.Element("Compañia").Value
                              } into tabla
                              select new
                              {
                                  Compañia = tabla.Key.comp,
                                  Año = tabla.Key.anio,
                                  Viajes = tabla.Count()
                              });
                gvViajes.DataSource = Filtro.ToList();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ServicioTURU Sewb = new ServicioTURU();
                this.Carga = Sewb.ViajesXML();
                XElement XML = XElement.Parse(Carga);
                var Filtro = (from viaje in XML.Elements("Viaje")
                              where (string)viaje.Element("PaisDestino") == cbPais.Text.Trim()
                              select new
                              {
                                  NumeroViaje = viaje.Element("Numero").Value,
                                  CiudadDestino = viaje.Element("CiudadDestino").Value,
                                  PaisDestino = viaje.Element("PaisDestino").Value,
                                  Compañia = viaje.Element("Compañia").Value,
                                  FechaPartida = viaje.Element("FechaPartida").Value
                              });
                gvViajes.DataSource = Filtro.ToList();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            try
            {
                dateFecha1.Value = DateTime.Today;
                dateFecha2.Value = DateTime.Today;
                this.CargoDatos();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

    }
}
