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

        private Empleado _Emp = new Empleado();
        private Empleado emp2 = new Empleado();
        public ABMEmpleado(Empleado pEmp)
        {
            InitializeComponent();
            this.DesactivoBotones();
            emp2 = pEmp;
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
                EPNCedula.SetError(txtCedula, "Solo se puede ingresar numeros");
                e.Cancel = true;
                lblError.Text = ex.Message;
            }
            
            
            
            try
            {
                _Emp = new Administracion.ServicioWeb.ServicioTURU().BuscarEmpleado(txtCedula.Text);
                if (_Emp == null)
                    this.ActivoAgregar();
                else
                {
                    this.ActivoActualizacion();
                    txtCedula.Enabled = false;
                }
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 100)
                    lblError.Text = ex.Detail.InnerText.Substring(0, 100);
                else
                    lblError.Text = ex.Detail.InnerText;
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }



     

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            try
            {


                if (_Emp._Cedula == emp2._Cedula)
                {
                    throw new Exception("El empleado logueado no se puede eliminar.");
                }
                else

                { new Administracion.ServicioWeb.ServicioTURU().EliminarEmpleado(_Emp); }
                this.DesactivoBotones();
                this.LimpioCajaTexto();
                txtCedula.Enabled = false;
                lblError.Text = "Baja con exito";
                
                
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 100)
                    lblError.Text = ex.Detail.InnerText.Substring(0, 100);
                else
                    lblError.Text = ex.Detail.InnerText;
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnModificar1_Click(object sender, EventArgs e)
        {
            try
            {
                _Emp = new Empleado();
              
                _Emp._Cedula = txtCedula.Text.Trim();
               
           

                if (txtContraseña.Text.Length != 6)
                { throw new Exception("La cotraseña debe de tener 6 caracteres"); }
                else
                { _Emp._Contraseña = txtContraseña.Text.Trim(); }

                if (txtNombreCompleto.Text.Length == 0)
                { throw new Exception("Debe ingresar su nombre completo "); }
                else
                { _Emp._NombreCompleto = txtNombreCompleto.Text.Trim(); }

                new Administracion.ServicioWeb.ServicioTURU().ModificarEmpleado(_Emp);

                this.DesactivoBotones();
                this.LimpioCajaTexto();
                txtCedula.Enabled = false;
                lblError.Text = " Modificar con Exito";
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 100)
                    lblError.Text = ex.Detail.InnerText.Substring(0, 100);
                else
                    lblError.Text = ex.Detail.InnerText;
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
          
            this.DesactivoBotones();
            txtCedula.Enabled = true;
            this.LimpioCajaTexto();

        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            try
            {
                _Emp = new Empleado();


                if (txtCedula.Text.Length != 8)
                { throw new Exception("La cedula debe de tener 8 caracteres"); }
                else
                {
                    _Emp._Cedula = txtCedula.Text.Trim();
                }
               
                
                if (txtContraseña.Text.Length != 6)
                { throw new Exception("La cotraseña debe de tener 6 caracteres"); }
                else
                { _Emp._Contraseña = txtContraseña.Text.Trim(); }

                if (txtNombreCompleto.Text.Length == 0)
                { throw new Exception("Debe ingresar su nombre completo "); }
                else
                { _Emp._NombreCompleto = txtNombreCompleto.Text.Trim(); }

                new Administracion.ServicioWeb.ServicioTURU().AgregarEmpleado(_Emp);
                this.DesactivoBotones();
                this.LimpioCajaTexto();
                txtCedula.Enabled = false;
                lblError.Text = "Alta con Exito";
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 100)
                    lblError.Text = ex.Detail.InnerText.Substring(0, 100);
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
