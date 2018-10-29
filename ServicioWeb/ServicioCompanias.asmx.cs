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
    /// Descripción breve de ServicioCompanias
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioCompanias : System.Web.Services.WebService
    {
        [WebMethod]
        public Compania Buscar(string nombre)
        {
            try
            {
                ILogicaCompania Lcompania = FabricaLogica.GetLogicaCompania();
                return (Lcompania.Buscar(nombre));
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
        public void Agregar(Compania c)
        {
            try
            {
                ILogicaCompania Lcompania = FabricaLogica.GetLogicaCompania();
                Lcompania.Agregar(c);
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
        public void Modificar(Compania c)
        {
            try
            {
                ILogicaCompania Lcompania = FabricaLogica.GetLogicaCompania();
                Lcompania.Modificar(c);
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
        public void Eliminar(Compania c)
        {
            try
            {
                ILogicaCompania Lcompania = FabricaLogica.GetLogicaCompania();
                Lcompania.Eliminar(c);
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
        public List<Compania> Listar()
        {
            try
            {
                ILogicaCompania Lcompania = FabricaLogica.GetLogicaCompania();
                return (Lcompania.Listar());
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
        public Compania BuscarParaViaje(string nombre)
        {
            try
            {
                ILogicaCompania Lcompania = FabricaLogica.GetLogicaCompania();
                return (Lcompania.BuscarParaViaje(nombre));
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
