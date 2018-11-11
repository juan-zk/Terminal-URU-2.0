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
            
        }

        private void DesactivoBotones()
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
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
                EPNCedula.SetError(txtCedula, "Solo se pueden ingresar numeros");
                e.Cancel = true;
            }

            try
            {
                _Emp = new Administracion.ServicioWeb.ServicioTURU().BuscarEmpleado(txtCedula.Text);
                this.LimpioCajaTexto();

                if (_Emp == null)
                {
                    btnAgregar.Enabled = true;
                }
                else
                {
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    txtCedula.Text = _Emp._Cedula;
                    txtContraseña.Text = _Emp._Contraseña;
                    txtNombreCompleto.Text = _Emp._NombreCompleto;
                }
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
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

        private void btnEliminar_Click(object sender, EventArgs e)
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try 
            {
                _Emp._Cedula = txtCedula.Text.Trim();
                _Emp._Contraseña = txtContraseña.Text.Trim();
                _Emp._NombreCompleto = txtNombreCompleto.Text.Trim();
                new Administracion.ServicioWeb.ServicioTURU().ModificarEmpleado(_Emp);

                this.DesactivoBotones();
                this.LimpioCajaTexto();
                lblError.Text = " Modificar con Exito";
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            { }
            catch (Exception ex)
            { }
        }



        
    }
}
