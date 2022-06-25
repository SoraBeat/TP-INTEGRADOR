using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class Precompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            lblNombrePelicula.Text = "Doctor Strange en el multiverso de la locura";
            lblFechayhora.Text = "2022-06-22";
            lblDireccion.Text = "Hipolito Yrigoyen 213";
            ImageButton1.ImageUrl = "~/Imagenes/Portadas/Doctor Strange.jpg";

        }

        public void desloguear(object sender, EventArgs e)
        {
            Session["DATOSUSUARIO"] = null;
            Response.Redirect("PantallaInicial.aspx");
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}