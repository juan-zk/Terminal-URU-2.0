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
    public partial class ABMEmpleado : Form
    {

        private Empleado _Emp = null;
        
        public ABMEmpleado()
        {
            InitializeComponent();
            this.DesactivoBotones();
            
        }

        private void DesactivoBotones()
        {
            btnAgregar1.Enabled = false;
            btnEliminar1.Enabled = false;
            btnModificar1.Enabled = false;
            lblError.Text = "";
        }
        
        private void ActivoAgregar()
        {
            btnAgregar1.Enabled = true;
            btnEliminar1.Enabled = false;
            btnModificar1.Enabled = false;

            txtContraseña.Text = "";
            txtNombreCompleto.Text = "";
        }
       
        private void ActivoActualizacion()
        {
            btnAgregar1.Enabled = false;
            btnEliminar1.Enabled = true;
            btnModificar1.Enabled = true;

            txtCedula.Text = _Emp._Cedula;
            txtContraseña.Text = _Emp._Contraseña;
            txtNombreCompleto.Text = _Emp._NombreCompleto;
        }

        private void LimpioCajaTexto()
        {
            txtCedula.Text = "";
            txtContraseña.Text = "";
            txtNombreCompleto.Text = "";
            lblError.Text = "";
        }

        private void txtCedula_Validating(object sender, CancelEventArgs e)
        {


            try
            {
                Convert.ToInt32(txtCedula.Text);
                EPNCedula.Clear();
            }
            catch (Exception ex)
            {
                EPNCedula.SetError(txtCedula, "Solo se puede Ingresar Numeros");
                e.Cancel = true;
            }
            
            
            try
            {
               
                _Emp = new Administracion.ServicioWeb.ServicioTURU().BuscarEmpleado(txtCedula.Text);
                if (_Emp == null)
                {
                    this.ActivoAgregar();
                    lblError.Text = "Usuario no encontrado, Complete los campos para Agregar.";
                }
                else
                {
                    this.ActivoActualizacion();
                    lblError.Text = "";
                }
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            { }
            catch (Exception ex)
            { }
        }



     

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            try
            {
                new Administracion.ServicioWeb.ServicioTURU().EliminarEmpleado(_Emp);
                this.DesactivoBotones();
                this.LimpioCajaTexto();
                lblError.Text = "Baja con exito";
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            { }
            catch (Exception ex)
            { }
        }

        private void btnModificar1_Click(object sender, EventArgs e)
        {
            try
            {
                _Emp._Cedula = txtCedula.Text.Trim();
                _Emp._Contraseña = txtContraseña.Text.Trim();
                _Emp._NombreCompleto = txtNombreCompleto.Text.Trim();
                new Administracion.ServicioWeb.ServicioTURU().ModificarEmpleado(_Emp);

                this.DesactivoBotones();
                this.LimpioCajaTexto();
                lblError.Text = " Modificado con Exito";
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            { }
            catch (Exception ex)
            { }
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            _Emp = null;
            this.DesactivoBotones();
            this.LimpioCajaTexto();

        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado _Emp = new Empleado();
                _Emp._Cedula = txtCedula.Text.Trim();
                _Emp._Contraseña = txtContraseña.Text.Trim();
                _Emp._NombreCompleto = txtNombreCompleto.Text.Trim();

                new Administracion.ServicioWeb.ServicioTURU().AgregarEmpleado(_Emp);
                this.DesactivoBotones();
                this.LimpioCajaTexto();

                lblError.Text = "Alta con Exito";
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            { }
            catch (Exception ex)
            { }
        }



        
    }
}
