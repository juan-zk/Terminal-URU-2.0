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
        
    }
}
