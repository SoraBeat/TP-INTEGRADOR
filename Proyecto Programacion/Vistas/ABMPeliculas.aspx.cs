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
                CargarGrid(); 
            }
            if (Session["DATOSUSUARIO"]!=null)
            {
                string datosUsuario = (string)Session["DATOSUSUARIO"];
                string[] separador = new string[] { " ", "$" };
                string[] datos = datosUsuario.Split(separador, StringSplitOptions.RemoveEmptyEntries);
                LBL_NOMBREUSUARIO.Text = datos[1];
                LBL_APELLIDOUSUARIO.Text = datos[2];
            }


        }
        public void desloguear(object sender, EventArgs e)
        {
            Session["DATOSUSUARIO"] = null;
            Response.Redirect("PantallaInicial.aspx");
        }
        private void CargarTablaSinFiltro()
        {
            DataTable tablaPeliculas = negPel.getListaPeliculasCompleto();
            gvPeliculas.DataSource = tablaPeliculas;
            gvPeliculas.DataBind();
            lblResultado.Text = "";
            lblResultadoGuardar.Text = "";
        }

        private void CargarTablaConFiltro()
        {
            DataTable tablaPelicula = new DataTable();
            switch (ddlFiltro.Text)
            {
                case "ID":
                    tablaPelicula = negPel.getListaPeliculasPorID(tbFiltro.Text);
                    break;
                case "TITULO":
                    tablaPelicula = negPel.getListaPeliculasPorTitulo(tbFiltro.Text);
                    break;
                case "DESCRIPCION":
                    tablaPelicula = negPel.getListaPeliculasPorDescripcion(tbFiltro.Text);
                    break;
                case "DURACION":
                    tablaPelicula = negPel.getListaPeliculasPorDuracion(tbFiltro.Text);
                    break;
                case "CLASIFICACION":
                    tablaPelicula = negPel.getListaPeliculasPorClasificacion(tbFiltro.Text);
                    break;
                case "GENERO":
                    tablaPelicula = negPel.getListaPeliculasPorGenero(tbFiltro.Text);
                    break;
                case "PORTADA":
                    tablaPelicula = negPel.getListaPeliculasPorPortada(tbFiltro.Text);
                    break;
                case "ESTADO":
                    tablaPelicula = negPel.getListaPeliculasPorEstado(tbFiltro.Text);
                    break;
            }
            gvPeliculas.DataSource = tablaPelicula;
            gvPeliculas.DataBind();
            lblResultado.Text = "";
            lblResultadoGuardar.Text = "";
        }

        private void CargarGrid()
        {
            ListItem item;
            item = new ListItem("ID");
            ddlFiltro.Items.Add(item);
            item = new ListItem("TITULO");
            ddlFiltro.Items.Add(item);
            item = new ListItem("DESCRIPCION");
            ddlFiltro.Items.Add(item);
            item = new ListItem("DURACION");
            ddlFiltro.Items.Add(item);
            item = new ListItem("CLACIFICACION");
            ddlFiltro.Items.Add(item);
            item = new ListItem("GENERO");
            ddlFiltro.Items.Add(item);
            item = new ListItem("PORTADA");
            ddlFiltro.Items.Add(item);
            item = new ListItem("ESTADO");
            ddlFiltro.Items.Add(item);
            ddlFiltro.DataBind();
        }

        protected void gvPeliculas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String ID_Pelicula = ((Label)gvPeliculas.Rows[e.RowIndex].FindControl("lblIDPelicula")).Text;
            bool res = negPel.EliminarPelicula(ID_Pelicula);
            CargarTablaConFiltro();
            lblResultado.ForeColor = System.Drawing.Color.Green;
            lblResultado.Text = "Se ha borrado correctamente";
        }

        protected void gvPeliculas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvPeliculas.EditIndex = e.NewEditIndex;
            CargarTablaConFiltro();
        }

        protected void gvPeliculas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String ID = ((Label)gvPeliculas.Rows[e.RowIndex].FindControl("LBL_EDT_ID")).Text;
            String Titulo = ((TextBox)gvPeliculas.Rows[e.RowIndex].FindControl("TXT_EDT_TITULO")).Text;
            String Descripcion = ((TextBox)gvPeliculas.Rows[e.RowIndex].FindControl("TXT_EDT_DESCRIPCION")).Text;
            String Duracion = ((TextBox)gvPeliculas.Rows[e.RowIndex].FindControl("TXT_EDT_DURACION")).Text;
            String Clasificacion = ((TextBox)gvPeliculas.Rows[e.RowIndex].FindControl("TXT_EDT_CLASIFICACION")).Text;
            String Genero = ((TextBox)gvPeliculas.Rows[e.RowIndex].FindControl("TXT_EDT_GENERO")).Text;
            String Portada = ((TextBox)gvPeliculas.Rows[e.RowIndex].FindControl("TXT_EDT_PORTADA")).Text;
            bool Estado = Convert.ToBoolean(((CheckBox)gvPeliculas.Rows[e.RowIndex].FindControl("TXT_EDT_ESTADO")).Checked);
           


            Peliculas Pel = new Peliculas();
            Pel.ID_Pelicula = ID;
            Pel.Titulo = Titulo;
            Pel.Descripcion = Descripcion;
            Pel.Duracion = Duracion;
            Pel.Clasificacion = Clasificacion;
            Pel.Genero = Genero;
            Pel.Portada = Portada;
            Pel.Estado = Estado;

            bool res = negPel.ModificarPelicula(Pel);
            gvPeliculas.EditIndex = -1;
            CargarTablaConFiltro();
            
            if (res)
            {
                lblResultado.ForeColor = System.Drawing.Color.Green;
                lblResultado.Text = "Se ha editado correctamente";
            }
            else
            {
                lblResultado.ForeColor = System.Drawing.Color.Red;
                lblResultado.Text = "ERROR al editar";
            }
        }

        protected void gvPeliculas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvPeliculas.EditIndex = -1;
            CargarTablaSinFiltro();

        }

        protected void gvPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                String ID = txtID.Text;
                String Titulo = txtTitulo.Text;
                String Descripcion = txtDescripcion.Text;
                String Duracion = txtDuracion.Text;
                String Clasificacion = txtClasificacion.Text;
                String Genero = txtGenero.Text;
                String Portada = txtPortada.Text;
                

                Peliculas Pel = new Peliculas();
                Pel.ID_Pelicula = ID;
                Pel.Titulo = Titulo;
                Pel.Descripcion = Descripcion;
                Pel.Duracion = Duracion;
                Pel.Clasificacion = Clasificacion;
                Pel.Genero = Genero;
                Pel.Portada = Portada;


                bool res = negPel.AgregarPelicula(Pel);
                if (res)
                {
                    lblResultadoGuardar.ForeColor = System.Drawing.Color.Green;
                    lblResultadoGuardar.Text = "Se ha guardado con exito";
                }
                else
                {
                    lblResultadoGuardar.ForeColor = System.Drawing.Color.Red;
                    lblResultadoGuardar.Text = "ERROR al guardar";
                }
                gvPeliculas.EditIndex = -1;
                txtID.Text = "";
                txtTitulo.Text = "";
                txtDescripcion.Text = "";
                txtDuracion.Text = "";
                txtClasificacion.Text = "";
                txtGenero.Text = "";
                txtPortada.Text = "";
                CargarTablaSinFiltro();
            }
        }

        protected void gvComplejos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvPeliculas.PageIndex = e.NewPageIndex;
            CargarTablaConFiltro();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (tbFiltro.Text != "".Trim())
            {
                CargarTablaConFiltro();
            }
            lblResultado.Text = "";
            lblResultadoGuardar.Text = "";
        }

        protected void btnFiltrarTodo_Click(object sender, EventArgs e)
        {
            CargarTablaSinFiltro();
            tbFiltro.Text = "";
            lblResultado.Text = "";
            lblResultadoGuardar.Text = "";
        }
    }
}
    
