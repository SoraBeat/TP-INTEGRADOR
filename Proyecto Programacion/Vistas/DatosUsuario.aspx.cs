using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class DatosUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CabezeraUsuario();
                btnIrPaginaAdmin();
                nombrebtn();
                CargarDatosUsuario();
            }
        }
        public void CargarDatosUsuario()
        {
            string datosUsuario = (string)Session["DATOSUSUARIO"];
            string[] separador = new string[] { " ", "$" };
            string[] datos = datosUsuario.Split(separador, StringSplitOptions.RemoveEmptyEntries);
            TXT_NOMBRE.Text = datos[1];
            TXT_APELLIDO.Text = datos[2];
            TXT_DNI.Text = datos[3];
            TXT_TELEFONO.Text = datos[4];
            TXT_EMAIL.Text = datos[5];
        }
        public void CabezeraUsuario()
        {
            if (Session["DATOSUSUARIO"] != null)
            {
                ContenedorUsuario.Visible = true;
                string datosUsuario = (string)Session["DATOSUSUARIO"];
                string[] separador = new string[] { " ", "$" };
                string[] datos = datosUsuario.Split(separador, StringSplitOptions.RemoveEmptyEntries);
                ContenedorNombre.Text = datos[1];
            }
            else
            {
                ContenedorUsuario.Visible = false;
            }
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
        protected void txtPaginaAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaAdmin.aspx");
        }
        public void CargarTarget(object sender,EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Attributes.Add("data-bs-target","#venta"+btn.Text);
        }
    }
}