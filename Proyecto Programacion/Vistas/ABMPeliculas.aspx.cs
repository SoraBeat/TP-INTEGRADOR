using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios;
using Entidades;
using System.Data;

namespace Vistas
{
    public partial class ABMPeliculas : System.Web.UI.Page
    {
        NegocioPeliculas negPel = new NegocioPeliculas();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTablaSinFiltro();
            }

        }

        private void CargarTablaSinFiltro()
        {
            DataTable tablaPeliculas = negPel.getListaPeliculas();
            gvPeliculas.DataSource = tablaPeliculas;
            gvPeliculas.DataBind();
          
        }

        private void CargarTablaConFiltro()
        {
            DataTable tablaPelicula = new DataTable();
            switch (ddlFiltro.Text)
            {
                case "ID":
                    tablaPelicula = negPel.getListaComplejosPorID(tbFiltro.Text);
                    break;
                case "TITULO":
                    tablaPelicula = negPel.getListaComplejosPorNombre(tbFiltro.Text);
                    break;
                case "DESCRIPCION":
                    tablaPelicula = negPel.getListaComplejosPorDireccion(tbFiltro.Text);
                    break;
                case "DURACION":
                    tablaPelicula = negPel.getListaComplejosPorTelefono(tbFiltro.Text);
                    break;
                case "CLASIFICACION":
                    tablaPelicula = negPel.getListaComplejosPorEmail(tbFiltro.Text);
                    break;
                case "GENERO":
                    tablaPelicula = negPel.getListaComplejosPorEmail(tbFiltro.Text);
                    break;
                case "FORMATO":
                    tablaPelicula = negPel.getListaComplejosPorEmail(tbFiltro.Text);
                    break;
                case "PORTADA":
                    tablaPelicula = negPel.getListaComplejosPorEmail(tbFiltro.Text);
                    break;
                case "ESTADO":
                    tablaPelicula = negPel.getListaComplejosPorEmail(tbFiltro.Text);
                    break;
            }
            gvComplejos.DataSource = tablaComplejo;
            gvComplejos.DataBind();
            lblResultado.Text = "";
            lblResultadoGuardar.Text = "";
        }

        protected void gvPeliculas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String ID_Pelicula = ((Label)gvPeliculas.Rows[e.RowIndex].FindControl("lblIDPelicula")).Text;
            bool res = negPel.EliminarPelicula(ID_Pelicula);
            if (res)
            {   

                lblResultado.ForeColor = System.Drawing.Color.Green;
                lblResultado.Text = "Se ha borrado correctamente";
            }
            else
            {
                lblResultado.ForeColor = System.Drawing.Color.Red;
                lblResultado.Text = "ERROR al borrar";
            }
            ///CargarTablaConFiltro();

        }

        protected void gvPeliculas_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gvPeliculas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void gvPeliculas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void gvPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}