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
    public partial class ABMCompanias : Form
    {
        private Compania _Comp = null;
        public ABMCompanias()
        {
            InitializeComponent();
            LimpiarForm();
        }

        void LimpiarForm()
        {
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }
        void HabilitarAgregar()
        {
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }
        void HabilitarBajaModificar()
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                lblError.Text = "";
                ServicioTURU Sweb = new ServicioTURU();
                _Comp = Sweb.BuscarCompania(txtNombre.Text);
                if (_Comp == null)
                {
                    HabilitarAgregar();
                }
                else
                {
                    HabilitarBajaModificar();
                    txtDireccion.Text = _Comp._Direccion;
                    txtTelefono.Text = _Comp._Telefono;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioTURU Sweb = new ServicioTURU();
                Sweb.EliminarCompania(_Comp);
                lblError.Text = "Compañia eliminada correctamente";
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioTURU Sweb = new ServicioTURU();
                _Comp = new Compania();
                _Comp._Nombre = txtNombre.Text;
                _Comp._Direccion = txtDireccion.Text;
                _Comp._Telefono = txtTelefono.Text;
                Sweb.AgregarCompania(_Comp);
                lblError.Text = "Compañia agregada correctamente";
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
                _Comp._Nombre = txtNombre.Text;
                _Comp._Direccion = txtDireccion.Text;
                _Comp._Telefono = txtTelefono.Text;
                Sweb.ModificarCompania(_Comp);
                lblError.Text = "Compañia modificada correctamente";
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }
    }
}
