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

        public static string idPelicula { get => IDpelicula; set => IDpelicula = value; }
        public static string idcomplejo { get => IDcomplejo; set => IDcomplejo = value; }
        public static string idioma { get => IDIOMA; set => IDIOMA = value; }

        public static string formato { get => FORMATO; set => FORMATO = value; }
        public static string fecha { get => FECHA; set => FECHA = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                idPelicula = Request.QueryString["ID"];
                Label2.Text = ID;

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
            ll.Text = formato;
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

            idcomplejo = DDLcomplejo.SelectedValue;
            CargarDDLformato();
         
        }

        protected void DDLformato_SelectedIndexChanged(object sender, EventArgs e)
        {
            formato = DDLformato.SelectedValue;
            CargarDDLidioma();
        }

        protected void DDLidioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            idioma = DDLidioma.SelectedValue;
            CargarDDLFecha();
        }

        protected void DDLhorario_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        protected void DDLfecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            ll.Text = DateTime.Now.Year.ToString();
            fecha = DDLfecha.SelectedValue + "/"+DateTime.Now.Year.ToString();
            CargarDDLHorario();
        }
    }
}