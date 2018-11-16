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
    public partial class ABMViajesNacionales : Form
    {

        Empleado emp = new Empleado();
        private ViajesNacionales Viaje = null;
        public ABMViajesNacionales()
        {
           
            InitializeComponent();
            this.DesactivoBotones();
           

        
            //Lista de terminales
            List<Terminal> Terminales = null;
           Terminales = new Administracion.ServicioWeb.ServicioTURU().ListarTerminales().ToList();
           foreach (Terminal ter in Terminales)
           {
               cbTerminal.Items.Add(ter._Ciudad);
           }

            //lista de Compañias 
           List<Compania> Compania = null;
           Compania = new Administracion.ServicioWeb.ServicioTURU().ListarCompanias().ToList();
           foreach (Compania com in Compania)
           {
               cbCompañia.Items.Add(com._Nombre);
           }
        }

       

        private void DesactivoBotones()
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            lblError.Text = "";
        }

        private void ActivoAgregar()
        {
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
           
        }

        private void ActivoActualizacion()
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;

            cbCompañia.SelectedValue = Viaje._Com;
            cbTerminal.SelectedValue = Viaje._Ter;
            DateTime FechaArribo = dateArribo.Value;
            FechaArribo = Viaje._FechaArribo;
            DateTime FechaPartida = datePartida.Value;
            FechaPartida = Viaje._FechaPartida;
            int Asientos = Convert.ToInt32(txtAsientos);
            Asientos = Viaje._CantidadAsientos;
            cbParadas.SelectedValue = Viaje._ParadasIntermedias;
            emp = Viaje._Emp;
          

            
        }

        private void LimpioCajaTexto()
        {
            txtNumViaje.Text = "";
            txtAsientos.Text = "";
            cbCompañia = null;
            cbTerminal = null;
            cbParadas = null;
            dateArribo = null;
            datePartida = null;
            lblError.Text = "";
        }
    }
}
