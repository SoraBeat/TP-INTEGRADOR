using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

            
        }
        public void desloguear(object sender, EventArgs e)
        {
            Session["DATOSUSUARIO"] = null;
            Response.Redirect("PantallaInicial.aspx");
        }
    }
}