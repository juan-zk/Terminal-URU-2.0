﻿using System;
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
    public partial class ABMTerminal : Form
    {
        private Terminal term;
        public ABMTerminal()
        {
            InitializeComponent();
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
                ServicioTURU Sweb = new ServicioTURU();
                term = Sweb.BuscarTerminal(txtCodigo.Text);
                if (term == null)
                    CamposAgregar();
                else
                {
                    CamposBajaModi();
                    txtCiudad.Text = term._Ciudad;
                    cmbPais.Text = term._Pais;
                    for (int i = 0; i < (term._Facilidades.Count()); i++)
                    {
                        lstFacilidad.Items.Add(term._Facilidades[i]);
                    }

                }
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                    lblMensaje.Text = ex.Detail.InnerText.Substring(0, 40);
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
