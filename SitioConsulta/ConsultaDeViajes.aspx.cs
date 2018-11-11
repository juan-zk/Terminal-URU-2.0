using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ServicioWeb;
using System.Web.Services.Protocols;

public partial class ConsultaDeViajes : System.Web.UI.Page
{
    ServicioTURU ServicioTerminal = new ServicioTURU();
    void LlenarDDL()    
    {      

        List<Terminal> terminales = ServicioTerminal.ListarTerminales().ToList();
        ddlDestino.Items.Clear();
        foreach (Terminal ter in terminales)
        {
            ListItem l = new ListItem(string.Format(ter._Codigo + " " + ter._Ciudad), ter._Codigo);
            ddlDestino.Items.Add(l);
        }

        List<Compania> companias = ServicioTerminal.ListarCompanias().ToList();
        ddlCompania.Items.Clear();
        ddlCompania.Items.Add("Todas");
        foreach (Compania c in companias)
        {
            ListItem l = new ListItem(c._Nombre, c._Nombre);
            ddlCompania.Items.Add(l);
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        lblMsj.Text = "";
        if (!IsPostBack)
        {
            try
            {
                List<Viaje> viajes = ServicioTerminal.ListarViajes().ToList();
                Session["ListaDeViajes"] = viajes;
                
                rptrViajes.DataSource = viajes;
                rptrViajes.DataBind();
                LlenarDDL();

            }
            catch (Exception ex) { lblMsj.Text = ex.Message; }
        }


    }
    protected void rptrViajes_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

        if (e.CommandName == "VerViaje")
        {
            try
            {
                int codViaje = Convert.ToInt32(((TextBox)e.Item.Controls[1]).Text);

                Viaje v = ServicioTerminal.BuscarViaje(codViaje);                

                Session["ConsultaViaje"] = v;
                Response.Redirect("~/DetalleDeViaje.aspx");
            }
            catch (Exception ex) { lblMsj.Text = ex.Message; }
        }
    }
    protected void btnAplicar_Click(object sender, EventArgs e)
    {
        List<Viaje> Filtrada = (List<Viaje>)Session["ListaDeViajes"];
        
        try
        {
            Filtrada = (from unViaje in Filtrada
                        where unViaje._Ter._Codigo == ddlDestino.SelectedValue
                        select unViaje).ToList<Viaje>();
            
            //filtro por compañia
            if (ddlCompania.SelectedValue != "Todas")
            {
                Filtrada = (from unViaje in Filtrada
                              where ((unViaje._Com._Nombre == ddlCompania.SelectedValue))
                              select unViaje).ToList<Viaje>();
                
            }
            //filtro por rango de fechas
            
            if (chkPorFecha.Checked)
            {
                DateTime partida = calPartida.SelectedDate;
                DateTime llegada = calLLegada.SelectedDate;
                
                Filtrada = (from unViaje in Filtrada
                            where (unViaje._FechaPartida.Date >= partida.Date) && (unViaje._FechaArribo.Date <= llegada.Date)
                            select unViaje).ToList<Viaje>();
            }
             
            
            rptrViajes.DataSource = Filtrada;
            rptrViajes.DataBind();

        }
        catch (Exception ex) { lblMsj.Text = ex.Message; }

    }
    protected void btnQuitar_Click(object sender, EventArgs e)
    {
        try
        {
            List<Viaje> viajes = ServicioTerminal.ListarViajes().ToList();

            Session["ListaDeViajes"] = viajes;

            rptrViajes.DataSource = viajes;
            rptrViajes.DataBind();

            ddlCompania.SelectedValue = "Todas";
            chkPorFecha.Checked = false;
        }
        catch (Exception ex) { lblMsj.Text = ex.Message;   }
        
    }
    protected void chkPorFecha_CheckedChanged(object sender, EventArgs e)
    {
        if (chkPorFecha.Checked)
        {
            calLLegada.Enabled = true;
            calPartida.Enabled = true;
        }
        else
        {
            calPartida.Enabled = false;
            calPartida.Enabled = false;
        }
    }
}
