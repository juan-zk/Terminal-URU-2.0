using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Administracion
{
    public partial class ControlLogin : UserControl
    {
        public ControlLogin()
        {
            InitializeComponent();
        }
        public string usuario
        { get { return txtUsr.Text; } }

        public string pass
        { get { return txtPass.Text; } }

        public event EventHandler AutenticarUsuario;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AutenticarUsuario(this, new EventArgs());
        }
    }
}
