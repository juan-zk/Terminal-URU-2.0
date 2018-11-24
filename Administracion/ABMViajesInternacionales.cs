using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Administracion.ServicioWeb;

namespace Administracion
{
    public partial class ABMViajesInternacionales : Form
    {
        internal Empleado _Emp = new Empleado();
        internal Viaje Viaje = new Viaje();
        internal ViajesInternacionales Vinter = new ViajesInternacionales();

        public ABMViajesInternacionales(Empleado pEmp)
        {
            InitializeComponent();
            LimpiarForm();
            _Emp = pEmp;
            //Lista de terminales
            List<Terminal> Terminales = new List<Terminal>();
            Terminales = new Administracion.ServicioWeb.ServicioTURU().ListarTerminales().ToList();
            foreach (Terminal ter in Terminales)
            {
                cbTerminales.Items.Add(ter._Codigo);
            }

            //lista de Compañias 
            List<Compania> Compania = new List<Compania>();
            Compania = new Administracion.ServicioWeb.ServicioTURU().ListarCompanias().ToList();
            foreach (Compania com in Compania)
            {
                cbCompanias.Items.Add(com._Nombre);
            }
        }
        void LimpiarForm()
        {
            txtAsientos.Text = "";
            txtDocumentacion.Text = "";
            txtHoraArribo.Text = "";
            txtHoraPartida.Text = "";
            txtNumero.Text = "";
            cbCompanias.Enabled = false;
            cbTerminales.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            cbCompanias.Text="";
            cbTerminales.Text = "";
            dtFechaPartida.Text = "";
            dtFechaArribo.Text = "";
        }
        void HabilitarAgregar()
        {
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            cbCompanias.Enabled = true;
            cbTerminales.Enabled = true;
        }
        void HabilitarBajaModificar()
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
            cbCompanias.Enabled = true;
            cbTerminales.Enabled = true;
        }

        private void txtHoraPartida_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaArribo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                lblError.Text = "";
                ServicioTURU Sweb = new ServicioTURU();
                Viaje = Sweb.BuscarViaje(Convert.ToInt32(txtNumero.Text));
                if (Viaje is ViajesNacionales)
                    throw new Exception("Ese numero corresponde a un Viaje Nacional.");
                Vinter = (ViajesInternacionales)Viaje;
                if (Vinter == null)
                {
                    HabilitarAgregar();
                }
                else
                {                   
                    HabilitarBajaModificar();
                    txtAsientos.Text = Vinter._CantidadAsientos.ToString();
                    txtDocumentacion.Text = Vinter._Documentacion;
                    txtHoraArribo.Text = Vinter._FechaArribo.Hour.ToString();
                    txtHoraPartida.Text = Vinter._FechaPartida.Hour.ToString();
                    dtFechaArribo.Text = Vinter._FechaArribo.ToShortDateString();
                    dtFechaPartida.Text = Vinter._FechaPartida.ToShortDateString();
                    cbTerminales.Text = Vinter._Ter._Codigo;
                    cbCompanias.Text = Vinter._Com._Nombre;
                    chkServicioaBordo.Checked = Vinter._ServicioBordo;
                }

            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                    lblError.Text = ex.Detail.InnerText.Substring(0, 40);
                else
                    lblError.Text = ex.Detail.InnerText;
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioTURU Sweb = new ServicioTURU();
                Compania _Comp = Sweb.BuscarCompania(cbCompanias.SelectedItem.ToString());
                Terminal _Term = Sweb.BuscarTerminal(cbTerminales.SelectedItem.ToString());
                Vinter = new ViajesInternacionales();
                Vinter._NumViaje = Convert.ToInt32(txtNumero.Text);
                Vinter._Documentacion = txtDocumentacion.Text;
                Vinter._Emp = _Emp;
                Vinter._CantidadAsientos = Convert.ToInt32(txtAsientos.Text);
                Vinter._FechaArribo = Convert.ToDateTime(dtFechaArribo.Value);
                Vinter._FechaPartida = Convert.ToDateTime(dtFechaPartida.Value);
                //Vinter._FechaPartida.AddHours = Convert.ToInt32(txtHoraPartida.Text);
                //buscar solucion para horas
                Vinter._ServicioBordo = chkServicioaBordo.Checked;
                Vinter._Ter = _Term;
                Vinter._Com = _Comp;
                Sweb.AgregarViaje(Vinter);
                lblError.Text = "Viaje agregado correctamente";
                LimpiarForm();

            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                    lblError.Text = ex.Detail.InnerText.Substring(0, 40);
                else
                    lblError.Text = ex.Detail.InnerText;
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioTURU Sweb = new ServicioTURU();
                Compania _Comp = Sweb.BuscarCompania(cbCompanias.SelectedItem.ToString());
                Terminal _Term = Sweb.BuscarTerminal(cbTerminales.SelectedItem.ToString());
                //Vinter = new ViajesInternacionales();
                Vinter._NumViaje = Convert.ToInt32(txtNumero.Text);
                Vinter._Documentacion = txtDocumentacion.Text;
                Vinter._Emp = _Emp;
                Vinter._CantidadAsientos = Convert.ToInt32(txtAsientos.Text);
                Vinter._FechaArribo = Convert.ToDateTime(dtFechaArribo.Value);
                Vinter._FechaPartida = Convert.ToDateTime(dtFechaPartida.Value);
                //Vinter._FechaPartida.AddHours = Convert.ToInt32(txtHoraPartida.Text);
                //buscar solucion para horas
                Vinter._ServicioBordo = chkServicioaBordo.Checked;
                Vinter._Ter = _Term;
                Vinter._Com = _Comp;
                Sweb.ModificarViaje(Vinter);
                lblError.Text = "Viaje modificado correctamente";
                LimpiarForm();

            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                    lblError.Text = ex.Detail.InnerText.Substring(0, 40);
                else
                    lblError.Text = ex.Detail.InnerText;
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioTURU Sweb = new ServicioTURU();
                Sweb.EliminarViaje(Vinter);
                lblError.Text = "Viaje eliminado correctamente";
                LimpiarForm();
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                    lblError.Text = ex.Detail.InnerText.Substring(0, 40);
                else
                    lblError.Text = ex.Detail.InnerText;
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}
