using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Negocios;
using Entidades;

namespace Vistas
{
    public partial class PantallaInicial : System.Web.UI.Page
    {
        NegocioPeliculas Pel = new NegocioPeliculas();
        NegocioComplejos Com = new NegocioComplejos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                CargarLv();
                CargarDDL();
            }
        }

        protected void btnSeleccionarPelicula_Command(object sender, CommandEventArgs e)
        {
            if (IsPostBack == false)
            {
                
                
            }
        }

        private void CargarLv ()
        {
                DataTable tablaSucursales = Pel.getListaPeliculas2();
                lvPeliculas.DataSource = tablaSucursales;
                lvPeliculas.DataBind();

        }

        protected void btn2D_Click(object sender, EventArgs e)
        {
            DataTable tablaSucursales = Pel.getListaPeliculas2D();
            lvPeliculas.DataSource = tablaSucursales;
            lvPeliculas.DataBind();
        }

        protected void btn3D_Click(object sender, EventArgs e)
        {
            DataTable tablaSucursales = Pel.getListaPeliculas3D();
            lvPeliculas.DataSource = tablaSucursales;
            lvPeliculas.DataBind();
        }

        protected void btn4D_Click(object sender, EventArgs e)
        {
            DataTable tablaSucursales = Pel.getListaPeliculas4D();
            lvPeliculas.DataSource = tablaSucursales;
            lvPeliculas.DataBind();
        }

        protected void btnSubtitulada_Click(object sender, EventArgs e)
        {
            DataTable tablaSucursales = Pel.getListaPeliculasSubtitulada();
            lvPeliculas.DataSource = tablaSucursales;
            lvPeliculas.DataBind();
        }


        protected void btnEspanol_Click(object sender, EventArgs e)
        {
            DataTable tablaSucursales = Pel.getListaPeliculasEspanol();
            lvPeliculas.DataSource = tablaSucursales;
            lvPeliculas.DataBind();
        }

        protected void btnVerTodo_Click(object sender, EventArgs e)
        {
            CargarLv();
        }


        private void CargarDDL()
        {
            DataTable tablaComplejos = Com.getListaComplejos();
            DDLsucursales.DataSource = tablaComplejos;
            DDLsucursales.DataTextField = "Nombre";
            DDLsucursales.DataValueField = "ID";
            DDLsucursales.DataBind();
            DDLsucursales.Items.Insert(0, new ListItem ("Seleccione Una Sucursal","0"));
        }


        protected void DDLsucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta;

            consulta = DDLsucursales.SelectedValue;
            DataTable tablaSucursales = Pel.getListaPeliculasComplejos(consulta);
            lvPeliculas.DataSource = tablaSucursales;
            lvPeliculas.DataBind();
        }
        public void guardarPeliculaEvento(object sender,EventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            Response.Redirect("MostrarPelicula.aspx?id=" + btn.CommandName);
        }
    }
}