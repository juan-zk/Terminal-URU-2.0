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
            txtNumero.Enabled = true;
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
            chkServicioaBordo.Checked = false;
        }
        void HabilitarAgregar()
        {
            txtNumero.Enabled = false;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            cbCompanias.Enabled = true;
            cbTerminales.Enabled = true;
        }
        void HabilitarBajaModificar()
        {
            txtNumero.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
            cbCompanias.Enabled = true;
            cbTerminales.Enabled = true;
        }
        bool ControlVacio()
        {
            var vacio = false;
            if (String.IsNullOrEmpty(txtDocumentacion.Text) || String.IsNullOrEmpty(txtNumero.Text) || String.IsNullOrEmpty(txtHoraArribo.Text) || String.IsNullOrEmpty(txtHoraPartida.Text) || String.IsNullOrEmpty(txtDocumentacion.Text) || String.IsNullOrEmpty(txtAsientos.Text) || String.IsNullOrEmpty(txtAsientos.Text))
                vacio = true;
            return vacio;
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
                    txtHoraArribo.Text = Vinter._FechaArribo.ToShortTimeString();
                    txtHoraPartida.Text = Vinter._FechaPartida.ToShortTimeString();
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
                if (ControlVacio())
                    throw new Exception("Debe completar todos los campos");
                ServicioTURU Sweb = new ServicioTURU();
                Compania _Comp = Sweb.BuscarCompania(cbCompanias.SelectedItem.ToString());
                Terminal _Term = Sweb.BuscarTerminal(cbTerminales.SelectedItem.ToString());
                DateTime fechaPartida = Convert.ToDateTime(dtFechaPartida.Value.ToShortDateString() + " " + txtHoraPartida.Text);
                DateTime fechaArribo = Convert.ToDateTime(dtFechaArribo.Value.ToShortDateString() + " " + txtHoraArribo.Text);

                Vinter = new ViajesInternacionales();
                Vinter._NumViaje = Convert.ToInt32(txtNumero.Text);
                Vinter._Documentacion = txtDocumentacion.Text;
                Vinter._Emp = _Emp;
                Vinter._CantidadAsientos = Convert.ToInt32(txtAsientos.Text);
                Vinter._FechaArribo = fechaArribo;
                Vinter._FechaPartida = fechaPartida;
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
                if (ControlVacio())
                    throw new Exception("Debe completar todos los campos");
                ServicioTURU Sweb = new ServicioTURU();
                Compania _Comp = Sweb.BuscarCompania(cbCompanias.SelectedItem.ToString());
                Terminal _Term = Sweb.BuscarTerminal(cbTerminales.SelectedItem.ToString());
                var test = dtFechaPartida.Value.ToShortDateString() + txtHoraPartida.Text;
                DateTime fechaPartida = Convert.ToDateTime(dtFechaPartida.Value.ToShortDateString() + " " + txtHoraPartida.Text);
                DateTime fechaArribo = Convert.ToDateTime(dtFechaArribo.Value.ToShortDateString() + " " + txtHoraArribo.Text);

                Vinter._NumViaje = Convert.ToInt32(txtNumero.Text);
                Vinter._Documentacion = txtDocumentacion.Text;
                Vinter._Emp = _Emp;
                Vinter._CantidadAsientos = Convert.ToInt32(txtAsientos.Text);
                Vinter._FechaArribo = fechaArribo;
                Vinter._FechaPartida = fechaPartida;

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
