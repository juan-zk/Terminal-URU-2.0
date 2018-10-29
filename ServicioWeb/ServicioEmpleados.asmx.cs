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
    /// Descripción breve de ServicioEmpleados
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioEmpleados : System.Web.Services.WebService
    {
        [WebMethod]
        public Empleado Buscar(string cedula)
        {
            try
            {
                ILogicaEmpleado Lempleado = FabricaLogica.GetLogicaEmpleado();
                return (Lempleado.Buscar(cedula));
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
        public void Agregar(Empleado e)
        {
            try
            {
                ILogicaEmpleado Lempleado = FabricaLogica.GetLogicaEmpleado();
                Lempleado.Agregar(e);
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
        public void Modificar(Empleado e)
        {
            try
            {
                ILogicaEmpleado Lempleado = FabricaLogica.GetLogicaEmpleado();
                Lempleado.Modificar(e);
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
        public void Eliminar(Empleado e)
        {
            try
            {
                ILogicaEmpleado Lempleado = FabricaLogica.GetLogicaEmpleado();
                Lempleado.Borrar(e);
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
        public Empleado BuscarParaViaje(string cedula)
        {
            try
            {
                ILogicaEmpleado Lempleado = FabricaLogica.GetLogicaEmpleado();
                return (Lempleado.BuscarParaViaje(cedula));
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
