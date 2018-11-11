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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ServicioTURU Sweb = new ServicioTURU();
            string ci = txtUsr.Text;
            string pass = txtPass.Text;

            Empleado emp = Sweb.Logueo(ci, pass);

            if (emp == null)
            {
                lblError.Text = ("Usuario o contraseña invalidos");
            }
            else
            {
                this.Hide();
                Form f = new FrmInicio(emp);
                f.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
