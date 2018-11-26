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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            ctrlLogin.AutenticarUsuario += new EventHandler(VerificarIngreso);
        }

        private void VerificarIngreso(object sender, EventArgs e)
        {
            try
            {
                ServicioTURU Sweb = new ServicioTURU();
                Empleado emp = Sweb.Logueo(ctrlLogin.usuario, ctrlLogin.pass);
                if (emp == null)
                    throw new Exception("Usuario o contraseña invalidos");
                else
                {
                    this.Hide();
                    Form f = new FrmInicio(emp);
                    f.Show();
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
    }
}
