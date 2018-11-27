using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Administracion.ServicioWeb;

namespace Administracion
{
    public partial class ABMTerminal : Form
    {
        private Terminal term;
        public ABMTerminal()
        {
            InitializeComponent();
            LimpiarCampos();
        }

        bool ControlVacio()
        {
            var vacio = false;
            if (String.IsNullOrEmpty(txtCodigo.Text) || String.IsNullOrEmpty(txtCiudad.Text) || String.IsNullOrEmpty(cmbPais.Text) || (lstFacilidad.Items.Count==0))
                vacio = true;
            return vacio;
        }

        void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtCodigo.Enabled = true;
            cmbPais.Enabled = false;
            txtCiudad.Text = "";
            txtCiudad.Enabled = false;
            lstFacilidad.Items.Clear();
            lstFacilidad.Enabled = false;
            txtFacilidad.Text = "";
            txtFacilidad.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnAgregar.Enabled = false;
        }
        void CamposAgregar()
        {
            txtCodigo.Enabled = false;
            cmbPais.Enabled = true;
            lstFacilidad.Items.Clear();
            txtCiudad.Enabled = true;
            lstFacilidad.Enabled = true;
            txtFacilidad.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnAgregar.Enabled = true;
        }
        void CamposBajaModi()
        {
            txtCodigo.Enabled = false;
            cmbPais.Enabled = true;
            lstFacilidad.Items.Clear();
            txtCiudad.Enabled = true;
            lstFacilidad.Enabled = true;
            txtFacilidad.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnAgregar.Enabled = false;
        }

        private void btnFacilidadAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFacilidad.Text != "")
                    lstFacilidad.Items.Add(txtFacilidad.Text);
                txtFacilidad.Text = "";
            }
            catch (Exception ex) { lblMensaje.Text = ex.Message; }
        }

        private void btnFacilidadBorrar_Click(object sender, EventArgs e)
        {
            lstFacilidad.Items.Remove(lstFacilidad.SelectedItem);
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                lblMensaje.Text = "";
                ServicioTURU Sweb = new ServicioTURU();
                term = Sweb.BuscarTerminal(txtCodigo.Text);
                if (term == null)
                    CamposAgregar();
                else
                {
                    CamposBajaModi();
                    txtCiudad.Text = term._Ciudad;
                    cmbPais.Text = term._Pais;
                    for (int i = 0; i < (term._Facilidades.Length); i++)
                    {
                        lstFacilidad.Items.Add(term._Facilidades[i]);
                    }

                }
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 100)
                    lblMensaje.Text = ex.Detail.InnerText.Substring(0, 100);
                else
                    lblMensaje.Text = ex.Detail.InnerText;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ControlVacio())
                    throw new Exception("Todos los campos deben contener datos");
                Terminal t = new Terminal();
                t._Codigo = txtCodigo.Text;
                t._Pais = cmbPais.Text;
                t._Ciudad = txtCiudad.Text;
                string[] listaT = new string[lstFacilidad.Items.Count];
                for (int i = 0; i < lstFacilidad.Items.Count; i++)
                {
                    listaT[i] = (lstFacilidad.Items[i].ToString());
                }
                t._Facilidades = listaT;

                ServicioTURU Sweb = new ServicioTURU();
                Sweb.AgregarTerminal(t);
                lblMensaje.Text = "Terminal agregada correctamente";
                LimpiarCampos();
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 100)
                    lblMensaje.Text = ex.Detail.InnerText.Substring(0, 100);
                else
                    lblMensaje.Text = ex.Detail.InnerText;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioTURU Sweb = new ServicioTURU();

                Sweb.EliminarTerminal(term);
                lblMensaje.Text = "Terminal eliminada correctamente";
                LimpiarCampos();
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 100)
                    lblMensaje.Text = ex.Detail.InnerText.Substring(0, 100);
                else
                    lblMensaje.Text = ex.Detail.InnerText;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControlVacio())
                    throw new Exception("Todos los campos deben contener datos");
                term._Pais = cmbPais.Text;
                term._Ciudad = txtCiudad.Text;
                string[] listaT = new string[lstFacilidad.Items.Count];
                for (int i = 0; i < lstFacilidad.Items.Count; i++)
                {
                    listaT[i] = (lstFacilidad.Items[i].ToString());
                }
                term._Facilidades = listaT;

                ServicioTURU Sweb = new ServicioTURU();
                Sweb.ModificarTerminal(term);
                lblMensaje.Text = "Terminal modificada correctamente";
                LimpiarCampos();
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 100)
                    lblMensaje.Text = ex.Detail.InnerText.Substring(0, 100);
                else
                    lblMensaje.Text = ex.Detail.InnerText;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

    }
}
