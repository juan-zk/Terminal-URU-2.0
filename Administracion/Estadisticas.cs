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
            foreach (Terminal ter in Terminales)
            {
                cbPais.Items.Add(ter._Pais);
            }
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
                              where (Convert.ToDateTime(viaje.Element("FechaPartida").Value) >= dateFecha1.Value) && (Convert.ToDateTime(viaje.Element("FechaPartida").Value) <= dateFecha2.Value)
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
        
    }
}
