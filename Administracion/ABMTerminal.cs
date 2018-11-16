using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Administracion
{
    public partial class ABMTerminal : Form
    {
        public ABMTerminal()
        {
            InitializeComponent();
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

    }
}
