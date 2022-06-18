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

        protected void gvPeliculas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

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
    }
}