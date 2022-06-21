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
    public partial class PaginaAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string datosUsuario = (string)Session["DATOSUSUARIO"];
            string[] separador = new string[] {" ","$"};
            string[] datos = datosUsuario.Split(separador, StringSplitOptions.RemoveEmptyEntries);
            LBL_NOMBREUSUARIO.Text = datos[1];
            LBL_APELLIDOUSUARIO.Text = datos[2];
            LBL_ID.Text = datos[0];
            LBL_NOMBRE.Text = datos[1];
            LBL_APELLIDO.Text = datos[2];
            LBL_DNI.Text = datos[3];
            LBL_TELEFONO.Text = datos[4];
            LBL_EMAIL.Text = datos[5];

            NegocioUsuario negusu = new NegocioUsuario();
            NegocioVentas negven = new NegocioVentas();
            DataTable usuarios = negusu.cantidadUsuarios();
            DataTable ventas = negven.cantidadVentas();
            DataTable dinero = negven.dineroGanado();
            LBL_USUARIOS.Text = usuarios.Rows[0]["CANTIDAD"].ToString();
            LBL_VENTAS.Text = ventas.Rows[0]["CANTIDAD"].ToString();
            LBL_DINERO.Text = "$"+dinero.Rows[0]["CANTIDAD"].ToString();
        }
        public void desloguear(object sender, EventArgs e)
        {
            Session["DATOSUSUARIO"] = null;
            Response.Redirect("PantallaInicial.aspx");
        }
    }
}