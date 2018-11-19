using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using Administracion.ServicioWeb;

using System.Xml;
using System.Configuration;


namespace Administracion
{
    public partial class Estadisticas : Form
    {
        
        public Estadisticas()
        {
            InitializeComponent();
            this.CargoDatos();
        }

        private void CargoDatos()
        {
            try
            {
                ServicioTURU Sweb = new ServicioTURU();
                
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
        
    }
}
