using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using System.Data;
using Negocios;

namespace Vistas

{
    public partial class MostrarPelicula : System.Web.UI.Page
    {
        
        NegocioPeliculas Pel = new NegocioPeliculas();
        NegocioComplejos Com = new NegocioComplejos();
        NegocioFunciones Fun = new NegocioFunciones();
        private static string IDpelicula;
        private static string IDcomplejo;
        private static string IDIOMA;
        private static string FORMATO;
        private static string FECHA;
        private static string HORARIO;

        public static string idPelicula { get => IDpelicula; set => IDpelicula = value; }
        public static string idcomplejo { get => IDcomplejo; set => IDcomplejo = value; }
        public static string idioma { get => IDIOMA; set => IDIOMA = value; }
        public static string formato { get => FORMATO; set => FORMATO = value; }
        public static string fecha { get => FECHA; set => FECHA = value; }
        public static string horario { get => HORARIO; set => HORARIO = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            nombrebtn();
            if (IsPostBack == false)
            {
                idPelicula = Request.QueryString["ID"];
                DataTable urlPelicula = new DataTable();
                urlPelicula = Pel.getNombrePelicula(idPelicula);
                if(youtube.Src=="")
                {
                    youtube.Src = "https://www.youtube.com/embed/" + urlPelicula.Rows[0]["LinkYoutube_P"] + "?autoplay=0&fs=0&iv_load_policy=3&showinfo=0&rel=0&cc_load_policy=0&start=0&end=0&origin=https://youtubeembedcode.com";
                }
                btnIrPaginaAdmin();
                CargarDatosPagina();
                CargarDDLcomplejo();
              
            }
           
        }
        private void CargarDDLcomplejo()
        {

            DataTable tabla = Fun.getTablaPorComplejos(idPelicula);
            DDLcomplejo.DataSource = tabla;
            DDLcomplejo.DataTextField = "COMPLEJO";
            DDLcomplejo.DataValueField = "ID";
            DDLcomplejo.DataBind();
            DDLcomplejo.Items.Insert(0, new ListItem("Seleccione Un Complejo", "%"));
        }
        private void CargarDDLformato()
        {
            
            DataTable tabla = Fun.getTablaPorFormatoid(idPelicula, idcomplejo);
            DDLformato.DataSource = tabla;
            DDLformato.DataTextField = "FORMATO";
            DDLformato.DataValueField = "FORMATO";
            DDLformato.DataBind();           
            DDLformato.Items.Insert(0, new ListItem("Seleccione Un Formato", "%"));
            
        }

        private void CargarDDLidioma()
        {
            
            DataTable tabla = Fun.getTablaPoridioma(idPelicula, idcomplejo, formato);
            DDLidioma.DataSource = tabla;
            DDLidioma.DataTextField = "IDIOMA";
            DDLidioma.DataValueField = "IDIOMA";
            DDLidioma.DataBind();
            DDLidioma.Items.Insert(0, new ListItem("Seleccione Un Idioma", "%"));
        }

         private void CargarDDLFecha()
         {

             DataTable tabla = Fun.getTablaPorFecha2(idPelicula, idcomplejo, formato, idioma);
            DDLfecha.DataSource = tabla;
            DDLfecha.DataTextField = "FECHA";
            DDLfecha.DataValueField = "FECHA";
            DDLfecha.DataBind();
            DDLfecha.Items.Insert(0, new ListItem("Seleccione Una Fecha", "%"));
         }

        private void CargarDDLHorario()
        {

            DataTable tabla = Fun.getTablaPorHorario2(idPelicula, idcomplejo, formato, idioma, fecha);
            DDLhorario.DataSource = tabla;
            DDLhorario.DataTextField = "HORARIO";
            DDLhorario.DataValueField = "HORARIO";
            DDLhorario.DataBind();
            DDLhorario.Items.Insert(0, new ListItem("Seleccione Un Horario", "%"));
        }

        protected void DDLcomplejo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DDLcomplejo.SelectedIndex == 0)
            {
                DDLformato.Visible = false;
                DDLidioma.Visible = false;
                DDLfecha.Visible = false;
                DDLhorario.Visible = false;
                DDLformato.Visible = false;
                LBL_FORMATO.Visible = false;
                LBL_IDIOMA.Visible = false;
                LBL_FECHA.Visible = false;
                LBL_HORARIO.Visible = false;
                BTN_COMPRAR.Visible = false;

            }
            else
            {
                DDLformato.Visible = false;
                DDLidioma.Visible = false;
                DDLfecha.Visible = false;
                DDLhorario.Visible = false;
                LBL_IDIOMA.Visible = false;
                LBL_FECHA.Visible = false;
                LBL_HORARIO.Visible = false;
                BTN_COMPRAR.Visible = false;
                idcomplejo = DDLcomplejo.SelectedValue;
                CargarDDLformato();
                DDLformato.Visible = true;
                LBL_FORMATO.Visible = true;
            }

        }

        protected void DDLformato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DDLformato.SelectedIndex == 0)
            {
                DDLfecha.Visible = false;
                DDLhorario.Visible = false;
                DDLidioma.Visible = false;
                LBL_IDIOMA.Visible = false;
                LBL_FECHA.Visible = false;
                LBL_HORARIO.Visible = false;
                BTN_COMPRAR.Visible = false;

            }
            else
            {

                DDLfecha.Visible = false;
                DDLhorario.Visible = false;
                DDLidioma.Visible = true;
                LBL_IDIOMA.Visible = true;
                LBL_FECHA.Visible = false;
                LBL_HORARIO.Visible = false;
                BTN_COMPRAR.Visible = false;
                formato = DDLformato.SelectedValue;
                CargarDDLidioma();
            }
        }

        protected void DDLidioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DDLidioma.SelectedIndex == 0)
            {
                DDLhorario.Visible = false;
                DDLfecha.Visible = false;
                LBL_FECHA.Visible = false;
                LBL_HORARIO.Visible = false;
                BTN_COMPRAR.Visible = false;
            }
            else
            {
                DDLhorario.Visible = false;
                DDLfecha.Visible = true;
                LBL_FECHA.Visible = true;
                LBL_HORARIO.Visible = false;
                BTN_COMPRAR.Visible = false;
                idioma = DDLidioma.SelectedValue;
                CargarDDLFecha();
            }
        }

        protected void DDLfecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            DDLhorario.Visible = true;
            LBL_HORARIO.Visible = true;
            BTN_COMPRAR.Visible = false;
            fecha = DDLfecha.SelectedValue + "/"+DateTime.Now.Year.ToString();
            CargarDDLHorario();
        }

        protected void DDLhorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            BTN_COMPRAR.Visible = true;
            if (Session["DATOSUSUARIO"] != null)
            {
                BTN_COMPRAR.BackColor =System.Drawing.Color.DarkGreen;
            }
            else
            {
                BTN_COMPRAR.BackColor = System.Drawing.Color.Tomato;
            }
        }
        protected void btnComprar_Click(object sender, EventArgs e)
        {
            if (Session["DATOSUSUARIO"]!=null)
            {
                horario = DDLhorario.SelectedValue;
                string IDfuncion;
                DataTable tabla = Fun.getTablaPorID2(idPelicula, idcomplejo, formato, idioma, fecha, horario);
                DataRow row = tabla.Rows[0];
                IDfuncion = Convert.ToString(row["ID"]);
                Response.Redirect("ConfirmarCompra.aspx?ID=" + IDfuncion);
            }
        }
        
        public void CargarDatosPagina()
        {
            DDLformato.Visible = false;
            DDLidioma.Visible = false;
            DDLfecha.Visible = false;
            DDLhorario.Visible = false;
            LBL_FORMATO.Visible = false;
            LBL_IDIOMA.Visible = false;
            LBL_FECHA.Visible = false;
            LBL_HORARIO.Visible = false;
            BTN_COMPRAR.Visible = false;

            DataTable tabla = Pel.getListaPeliculasPorID(idPelicula);
            DataRow row = tabla.Rows[0];
            LBLtitulo.Text = Convert.ToString(row["Titulo"]).ToUpper();
            LBL_Titulo_Tecnico.Text = Convert.ToString(row["Titulo"]);
            LBLSinopsis.Text = Convert.ToString(row["Descripcion"]);
            LBL_Genero.Text = Convert.ToString(row["Genero"]);
            LBL_Clasificacion_Tecnico.Text = Convert.ToString(row["Clasificacion"]);
            LBLclasificacion.Text = Convert.ToString(row["Clasificacion"]);
            LBL_Duracion_Tecnico.Text = Convert.ToString(row["Duracion"]);
            LBLduracion.Text = Convert.ToString(row["Duracion"]);
            IMG_PORTADA.ImageUrl = Convert.ToString(row["Portada"]);
        }
        protected void txtPaginaAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaAdmin.aspx");
        }
        private void btnIrPaginaAdmin()
        {
            if (Session["DATOSUSUARIO"] != null)
            {
                string datosUsuario = (string)Session["DATOSUSUARIO"];
                string[] separador = new string[] { " ", "$" };
                string[] datos = datosUsuario.Split(separador, StringSplitOptions.RemoveEmptyEntries);
                bool TipoUsuario = Convert.ToBoolean(datos[7]);
                if (TipoUsuario == true)
                {
                    txtPaginaAdmin.Visible = true;
                }
            }

        }

        private void nombrebtn()
        {
            if (Session["DATOSUSUARIO"] == null)
            {
                btnIniciarSesion.Text = "Iniciar Sesion";
                btnIniciarSesion.CssClass = "btn btn-primary";
            }
            else
            {
                btnIniciarSesion.CssClass = "btn btn-danger";
                btnIniciarSesion.Text = "Cerrar Sesion";
            }
        }
        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (Session["DATOSUSUARIO"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                Session["DATOSUSUARIO"] = null;
                Response.Redirect("PantallaInicial.aspx");

            }
        }

    }
}