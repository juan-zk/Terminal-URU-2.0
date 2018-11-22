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
    public partial class FrmInicio : Form
    {
        internal Form f = null;
        internal Empleado _Emp;
        public FrmInicio(Empleado em)
        {
            InitializeComponent();
            _Emp = em;
            Empleado empLog = em;
            menuUsr.Text = em._NombreCompleto;

            try
            {
                if (f != null)
                {
                    f.Close();
                    f = null;
                }
                f = new Estadisticas();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.Manual;
                f.Show();
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                {
                    Form f = new FormErrores(ex.Detail.InnerText.Substring(0, 40));
                    f.ShowDialog();
                }
                else
                {
                    Form f = new FormErrores(ex.Detail.InnerText);
                    f.ShowDialog();
                }
            }
        }

        private void menuUsrSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuUsrCerrarS_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                f = new Login();
                f.Show();
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                {
                    Form f = new FormErrores(ex.Detail.InnerText.Substring(0, 40));
                    f.ShowDialog();
                }
                else
                {
                    Form f = new FormErrores(ex.Detail.InnerText);
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Form f = new FormErrores(ex.Message);
                f.ShowDialog();
            }
        }

        private void menuEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (f != null)
                {
                    f.Close();
                    f = null;
                }
                f = new ABMEmpleado();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.Manual;
                f.Show();
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                {
                    Form f = new FormErrores(ex.Detail.InnerText.Substring(0, 40));
                    f.ShowDialog();
                }
                else
                {
                    Form f = new FormErrores(ex.Detail.InnerText);
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Form f = new FormErrores(ex.Message);
                f.ShowDialog();
            }
        }

        private void menuTerm_Click(object sender, EventArgs e)
        {
            try
            {
                if (f != null)
                {
                    f.Close();
                    f = null;
                }
                f = new ABMTerminal();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.Manual;
                f.Show();
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                {
                    Form f = new FormErrores(ex.Detail.InnerText.Substring(0, 40));
                    f.ShowDialog();
                }
                else
                {
                    Form f = new FormErrores(ex.Detail.InnerText);
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Form f = new FormErrores(ex.Message);
                f.ShowDialog();
            }
        }

        private void menuViajeNac_Click(object sender, EventArgs e)
        {
            try
            {
                if (f != null)
                {
                    f.Close();
                    f = null;
                }
                f = new ABMViajesNacionales(_Emp);
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.Manual;
                f.Show();
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                {
                    Form f = new FormErrores(ex.Detail.InnerText.Substring(0, 40));
                    f.ShowDialog();
                }
                else
                {
                    Form f = new FormErrores(ex.Detail.InnerText);
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Form f = new FormErrores(ex.Message);
                f.ShowDialog();
            }
        }

        private void menuEstad_Click(object sender, EventArgs e)
        {
            try
            {
                if (f != null)
                {
                    f.Close();
                    f = null;
                }
                f = new Estadisticas();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.Manual;
                f.Show();
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                {
                    Form f = new FormErrores(ex.Detail.InnerText.Substring(0, 40));
                    f.ShowDialog();
                }
                else
                {
                    Form f = new FormErrores(ex.Detail.InnerText);
                    f.ShowDialog();
                }
            }
        }

        private void menuComp_Click(object sender, EventArgs e)
        {
            try
            {
                if (f != null)
                {
                    f.Close();
                    f = null;
                }
                f = new ABMCompanias();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.Manual;
                f.Show();
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                {
                    Form f = new FormErrores(ex.Detail.InnerText.Substring(0, 40));
                    f.ShowDialog();
                }
                else
                {
                    Form f = new FormErrores(ex.Detail.InnerText);
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Form f = new FormErrores(ex.Message);
                f.ShowDialog();
            }
        }

    }
}
