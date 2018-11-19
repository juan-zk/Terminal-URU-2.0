using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using EntidadesCompartidas;
using Logica;
using System.Xml;
using System.Web.Services.Protocols;

namespace ServicioWeb
{
    /// <summary>
    /// Descripción breve de ServicioTURU
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioTURU : System.Web.Services.WebService
    {
        // COMPANIAS--------------------------------------------------------------------
        [WebMethod]
        public Compania BuscarCompania(string nombre)
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
        public void AgregarCompania(Compania c)
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
        public void ModificarCompania(Compania c)
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
        public void EliminarCompania(Compania c)
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
        public List<Compania> ListarCompanias()
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


        //EMPLEADOS-----------------------------------------------------------------------
        [WebMethod]
        public Empleado BuscarEmpleado(string cedula)
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
        public void AgregarEmpleado(Empleado e)
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
        public void ModificarEmpleado(Empleado e)
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
        public void EliminarEmpleado(Empleado e)
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
        public Empleado Logueo(string cedula, string pass)
        {
            try
            {
                ILogicaEmpleado Lempleado = FabricaLogica.GetLogicaEmpleado();
                return (Lempleado.Logueo(cedula,pass));
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

        //TERMINALES ----------------------------------------------------------------------
        [WebMethod]
        public Terminal BuscarTerminal(string codigo)
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
        public void AgregarTerminal(Terminal t)
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
        public void ModificarTerminal(Terminal t)
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
        public void EliminarTerminal(Terminal t)
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
        public List<Terminal> ListarTerminales()
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


        //VIAJES---------------------------------------------------------------------------
        [WebMethod]
        public ViajesInternacionales HerenciaInternacionales(ViajesInternacionales pViaje)
        {
            return pViaje;            
        }
        [WebMethod]
        public ViajesNacionales HerenciaNacionales(ViajesNacionales pViaje)
        {
            return pViaje;
        }
        [WebMethod]
        public Viaje BuscarViaje(int numero)
        {
            try
            {
                ILogicaViaje LViaje = FabricaLogica.GetLogicaViajes();
                return (LViaje.Buscar(numero));
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
        public void AgregarViaje(Viaje v)
        {
            try
            {
                ILogicaViaje LViaje = FabricaLogica.GetLogicaViajes();
                LViaje.Agregar(v);
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
        public void ModificarViaje(Viaje v)
        {
            try
            {
                ILogicaViaje LViaje = FabricaLogica.GetLogicaViajes();
                LViaje.Modificar(v);
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
        public void EliminarViaje(Viaje v)
        {
            try
            {
                ILogicaViaje LViaje = FabricaLogica.GetLogicaViajes();
                LViaje.Eliminar(v);
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
        public List<Viaje> ListarViajes()
        {
            try
            {
                ILogicaViaje LViaje = FabricaLogica.GetLogicaViajes();
                return (LViaje.Listar());
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
        public string ViajesXML() {
            string a;
            ILogicaViaje LViaje = FabricaLogica.GetLogicaViajes();
            List<Viaje> ListarViajes = LViaje.Listar();            

            XmlDocument DocumentoXML = new XmlDocument();
            XmlNode NodoV = DocumentoXML.CreateNode(XmlNodeType.Element, "Viaje", "");

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
            a = DocumentoXML.InnerXml;
            return a;
        }

    }
}

