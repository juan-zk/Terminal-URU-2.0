using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using EntidadesCompartidas;
using Logica;
using System.Collections.Generic;
using System.Xml;
using System.Web.Services.Protocols;

namespace ServicioWeb
{
    /// <summary>
    /// Descripción breve de ServicioTerminales
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioTerminales : System.Web.Services.WebService
    {

        [WebMethod]
        public Terminal Buscar(string codigo)
        {
            try
            {
                ILogicaTerminal LTerminal = FabricaLogica.GetLogicaTerminales();
                return (LTerminal.Buscar(codigo));
            }
            catch (Exception ex)
            {
                XmlDocument _undoc = new System.Xml.XmlDocument();
                XmlNode _NodoError = _undoc.CreateNode(XmlNodeType.Element, SoapException.DetailElementName.Name, SoapException.DetailElementName.Namespace);
                XmlNode _NodoDetalle = _undoc.CreateNode(XmlNodeType.Element, "Error", "");

                _NodoDetalle.InnerText = ex.Message;
                _NodoError.AppendChild(_NodoDetalle);
                SoapException _MiEx = new SoapException("Error WS", SoapException.ClientFaultCode, Context.Request.Url.AbsoluteUri, _NodoError);
                throw _MiEx;
            }
        }

        [WebMethod]
        public void Agregar(Terminal t)
        {
            try
            {
                ILogicaTerminal LTerminal = FabricaLogica.GetLogicaTerminales();
                LTerminal.Agregar(t);
            }
            catch (Exception ex)
            {
                XmlDocument _undoc = new System.Xml.XmlDocument();
                XmlNode _NodoError = _undoc.CreateNode(XmlNodeType.Element, SoapException.DetailElementName.Name, SoapException.DetailElementName.Namespace);
                XmlNode _NodoDetalle = _undoc.CreateNode(XmlNodeType.Element, "Error", "");

                _NodoDetalle.InnerText = ex.Message;
                _NodoError.AppendChild(_NodoDetalle);
                SoapException _MiEx = new SoapException("Error WS", SoapException.ClientFaultCode, Context.Request.Url.AbsoluteUri, _NodoError);
                throw _MiEx;
            }
        }

        [WebMethod]
        public void Modificar(Terminal t)
        {
            try
            {
                ILogicaTerminal LTerminal = FabricaLogica.GetLogicaTerminales();
                LTerminal.Modificar(t);
            }
            catch (Exception ex)
            {
                XmlDocument _undoc = new System.Xml.XmlDocument();
                XmlNode _NodoError = _undoc.CreateNode(XmlNodeType.Element, SoapException.DetailElementName.Name, SoapException.DetailElementName.Namespace);
                XmlNode _NodoDetalle = _undoc.CreateNode(XmlNodeType.Element, "Error", "");

                _NodoDetalle.InnerText = ex.Message;
                _NodoError.AppendChild(_NodoDetalle);
                SoapException _MiEx = new SoapException("Error WS", SoapException.ClientFaultCode, Context.Request.Url.AbsoluteUri, _NodoError);
                throw _MiEx;
            }
        }

        [WebMethod]
        public void Eliminar(Terminal t)
        {
            try
            {
                ILogicaTerminal LTerminal = FabricaLogica.GetLogicaTerminales();
                LTerminal.Eliminar(t);
            }
            catch (Exception ex)
            {
                XmlDocument _undoc = new System.Xml.XmlDocument();
                XmlNode _NodoError = _undoc.CreateNode(XmlNodeType.Element, SoapException.DetailElementName.Name, SoapException.DetailElementName.Namespace);
                XmlNode _NodoDetalle = _undoc.CreateNode(XmlNodeType.Element, "Error", "");

                _NodoDetalle.InnerText = ex.Message;
                _NodoError.AppendChild(_NodoDetalle);
                SoapException _MiEx = new SoapException("Error WS", SoapException.ClientFaultCode, Context.Request.Url.AbsoluteUri, _NodoError);
                throw _MiEx;
            }
        }

        [WebMethod]
        public List<Terminal> Listar()
        {
            try
            {
                ILogicaTerminal LTerminal = FabricaLogica.GetLogicaTerminales();
                return (LTerminal.Listar());
            }
            catch (Exception ex)
            {
                XmlDocument _undoc = new System.Xml.XmlDocument();
                XmlNode _NodoError = _undoc.CreateNode(XmlNodeType.Element, SoapException.DetailElementName.Name, SoapException.DetailElementName.Namespace);
                XmlNode _NodoDetalle = _undoc.CreateNode(XmlNodeType.Element, "Error", "");

                _NodoDetalle.InnerText = ex.Message;
                _NodoError.AppendChild(_NodoDetalle);
                SoapException _MiEx = new SoapException("Error WS", SoapException.ClientFaultCode, Context.Request.Url.AbsoluteUri, _NodoError);
                throw _MiEx;
            }
        }

        [WebMethod]
        public Terminal BuscarParaViaje(string codigo)
        {
            try
            {
                ILogicaTerminal LTerminal = FabricaLogica.GetLogicaTerminales();
                return (LTerminal.BuscarParaViaje(codigo));
            }
            catch (Exception ex)
            {
                XmlDocument _undoc = new System.Xml.XmlDocument();
                XmlNode _NodoError = _undoc.CreateNode(XmlNodeType.Element, SoapException.DetailElementName.Name, SoapException.DetailElementName.Namespace);
                XmlNode _NodoDetalle = _undoc.CreateNode(XmlNodeType.Element, "Error", "");

                _NodoDetalle.InnerText = ex.Message;
                _NodoError.AppendChild(_NodoDetalle);
                SoapException _MiEx = new SoapException("Error WS", SoapException.ClientFaultCode, Context.Request.Url.AbsoluteUri, _NodoError);
                throw _MiEx;
            }
        }
    }
}
