using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Administracion.ServicioWeb;

using System.Xml;
using System.Configuration;
using System.Data;

namespace Administracion
{
    public partial class Estadisticas : Form
    {
        List<Viaje> ListarViajes;
        public Estadisticas()
        {
            InitializeComponent();
            this.CargoDatos();
        }

        private void CargoDatos()
        {
            try
            {
                ListarViajes = new List<Viaje>();
                ListarViajes = new Administracion.ServicioWeb.ServicioTURU().ListarViajes().ToList();

                XmlDocument DocumentoXML = new XmlDocument();
                DocumentoXML.Load("~/XML/Viajes.xml");
                XmlNode NodoV = DocumentoXML.CreateNode(XmlNodeType.Element, "Viaje","");
               
                foreach (Viaje V in ListarViajes)
                {
                    XmlNode NodoNum = DocumentoXML.CreateNode(XmlNodeType.Element, "Numero", "");
                    NodoNum.InnerText = V._NumViaje.ToString();
                    NodoV.AppendChild(NodoNum);

                    XmlNode NodoCiudad = DocumentoXML.CreateNode(XmlNodeType.Element, "CiudadDestino", "");
                    NodoCiudad.InnerText = V._Ter._Ciudad;
                    NodoV.AppendChild(NodoCiudad);

                    XmlNode NodoPais = DocumentoXML.CreateNode(XmlNodeType.Element, "PaisDestino", "");
                    NodoPais.InnerText = V._Ter._Pais;
                    NodoV.AppendChild(NodoPais);

                    XmlNode NodoCompañia = DocumentoXML.CreateNode(XmlNodeType.Element, "Compañia", "");
                    NodoCompañia.InnerText = V._Com._Nombre;
                    NodoV.AppendChild(NodoCompañia);

                    XmlNode NodoFecha = DocumentoXML.CreateNode(XmlNodeType.Element, "Fecha", "");
                    NodoFecha.InnerText = V._FechaPartida.ToString(); ;
                    NodoV.AppendChild(NodoFecha);

                    DocumentoXML.DocumentElement.AppendChild(NodoV);

                }

                DocumentoXML.Save("~/XML/Viajes.xml");

                DataSet Ds = new DataSet();
                Ds.ReadXml("~/XML/Viajes.xml");

                gvViajes.DataSource = Ds;
                
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
        
    }
}
