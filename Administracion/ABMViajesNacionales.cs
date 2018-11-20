﻿using System;
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

        private Empleado _Emp;
        private Viaje Viaje;
         
        private ViajesNacionales Vnacional = new ViajesNacionales();

        public ABMViajesNacionales(Empleado pEmp)
        {

            InitializeComponent();
            _Emp = pEmp;
            this.DesactivoBotones();

            //Lista de terminales
            List<Terminal> Terminales = null;
            Terminales = new Administracion.ServicioWeb.ServicioTURU().ListarTerminales().ToList();
            foreach (Terminal ter in Terminales)
            {
                cbTerminal.Items.Add(ter._Codigo);
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
            cbTerminal.Enabled = true;
            cbCompañia.Enabled = true;
            cbParadas.Enabled = true;
            
            cbCompañia.Text = Viaje._Com._Nombre;
            cbTerminal.Text = Viaje._Ter._Codigo;
            cbParadas.Text = ((ViajesNacionales)Viaje)._ParadasIntermedias.ToString();
            txtAsientos.Text = Viaje._CantidadAsientos.ToString();
            
            
                 
            dateArribo.Text = Viaje._FechaArribo.ToString();
            
            datePartida.Text = Viaje._FechaPartida.ToString();
            
            


        }
        private void btnDesahcer_Click(object sender, EventArgs e)
        {
           // _Emp = null;
            this.DesactivoBotones();
            this.LimpioCajaTexto();
        }
        
        private void LimpioCajaTexto()
        {


            this.cbCompañia.SelectedItem = null;
            this.cbParadas.SelectedItem = null;
            this.cbTerminal.SelectedItem = null;
            txtNumViaje.Text = "";
            txtAsientos.Text = "";
            dateArribo.Value = DateTime.Now;
            datePartida.Value = DateTime.Now;
            lblError.Text = "";
        }


        private void txtNumViajes_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Convert.ToInt32(txtNumViaje.Text);
                EPNNumViaje.Clear();
            }
            catch (Exception ex)
            {
                EPNNumViaje.SetError(txtNumViaje, "Solo se puede ingresar numeros");
                e.Cancel = true;
            }

            try
            {

                Viaje = new Administracion.ServicioWeb.ServicioTURU().BuscarViaje(Convert.ToInt32(txtNumViaje.Text));
                Vnacional = (ViajesNacionales)Viaje;
                if (Vnacional == null)
                {
                    this.ActivoAgregar();
                    lblError.Text = "No hay viajes asociados al numero seleccionado. Si lo desea puede agregar un viaje.";
                }
                else
                {
                    if (Viaje is ViajesInternacionales)
                        throw new Exception("Ese numero corresponde a un viaje internacional!");
                        this.ActivoActualizacion();
                        lblError.Text = "";
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

     

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                Compania Com = new Administracion.ServicioWeb.ServicioTURU().BuscarCompania(cbCompañia.SelectedItem.ToString());
                Terminal Ter = new Administracion.ServicioWeb.ServicioTURU().BuscarTerminal(cbTerminal.SelectedItem.ToString());

                Vnacional = new ViajesNacionales();
                Vnacional._NumViaje = Convert.ToInt32(txtNumViaje.Text.Trim());
                Vnacional._Com = Com;
                Vnacional._Ter = Ter;
                Vnacional._FechaPartida = Convert.ToDateTime(datePartida.Value);
                Vnacional._FechaArribo = Convert.ToDateTime(dateArribo.Value);
                Vnacional._CantidadAsientos = Convert.ToInt32(txtAsientos.Text.Trim());
                Vnacional._ParadasIntermedias = Convert.ToInt32(cbParadas.Text.Trim());
                Vnacional._Emp = _Emp;



                new Administracion.ServicioWeb.ServicioTURU().AgregarViaje(Vnacional);
                this.DesactivoBotones();
                this.LimpioCajaTexto();

                lblError.Text = "Alta con Exito";
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Compania Com = new Administracion.ServicioWeb.ServicioTURU().BuscarCompania(cbCompañia.Text);
                Terminal Ter = new Administracion.ServicioWeb.ServicioTURU().BuscarTerminal(cbTerminal.Text);

                Vnacional._NumViaje = Convert.ToInt32(txtNumViaje.Text.Trim());
                Vnacional._Com = Com;
                Vnacional._Ter = Ter;
                Vnacional._FechaPartida = Convert.ToDateTime(datePartida.Value);
                Vnacional._FechaArribo = Convert.ToDateTime(dateArribo.Value);
                Vnacional._CantidadAsientos = Convert.ToInt32(txtAsientos.Text.Trim());
                Vnacional._ParadasIntermedias = Convert.ToInt32(cbParadas.Text.Trim());
                Vnacional._Emp = _Emp;

                new Administracion.ServicioWeb.ServicioTURU().ModificarViaje(Vnacional);
                this.DesactivoBotones();
                this.LimpioCajaTexto();

                lblError.Text = " Modificado con Exito";
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
             
                new Administracion.ServicioWeb.ServicioTURU().EliminarViaje(Vnacional);
                this.DesactivoBotones();
                this.LimpioCajaTexto();
                lblError.Text = "Baja con exito";
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
