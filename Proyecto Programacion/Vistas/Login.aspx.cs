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
    public partial class WebForm1 : System.Web.UI.Page
    {
        NegocioUsuario negUsu = new NegocioUsuario();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
			if (IsValid)
			{
				String Email = txtUsuario.Text;
				String Contraseña = txtPassword.Text;

				Usuarios usu = new Usuarios();
				usu.EmailUsuario = Email;
				usu.ContraseñaUsuario = Contraseña;

				bool res = negUsu.ExisteUsuario(usu);
				if (res)
				{
					bool admin = negUsu.EsAdmin(usu);
                    if (admin)
                    {
						Session["Usuario"] = Email;
						Response.Redirect("PaginaAdmin.aspx");
					}
                    else
                    {
						Session["Usuario"] = Email;
						Response.Redirect("PantallaInicial.aspx");
					}
				}
				else
				{
					lblMensaje.ForeColor = System.Drawing.Color.Red;
					lblMensaje.Text = "Los datos del usuario ingresado no existe";
				}
				txtUsuario.Text = "";
				txtPassword.Text = "";
			}
		}
    }
}