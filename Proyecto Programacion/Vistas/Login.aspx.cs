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

				DataTable res = negUsu.ExisteUsuario(usu);
				foreach (DataRow columna in res.Rows)
				{
					if (columna["Email_U"] != null && columna["Contraseña_U"] != null && (bool)columna["Estado_U"]==true &&(bool)columna["Tipo_Usuario_U"]==true)
					{
						Session["DATOSUSUARIO"] = columna["ID_Usuario_U"] + "$" + columna["Nombre_U"] + "$" + columna["Apellido_U"] + "$" + columna["DNI_U"] + "$" + columna["Telefono_U"] + "$" + columna["Email_U"] + "$" + columna["Contraseña_U"] + "$" + columna["Tipo_Usuario_U"] + "$" + columna["Estado_U"];
						Response.Redirect("PaginaAdmin.aspx");
						return;
					}
					else if (columna["Email_U"] != null && columna["Contraseña_U"] != null && (bool)columna["Estado_U"] == true && (bool)columna["Tipo_Usuario_U"] == false)
					{
						Session["DATOSUSUARIO"] = columna["ID_Usuario_U"] + "$" + columna["Nombre_U"] + "$" + columna["Apellido_U"] + "$" + columna["DNI_U"] + "$" + columna["Telefono_U"] + "$" + columna["Email_U"] + "$" + columna["Contraseña_U"] + "$" + columna["Tipo_Usuario_U"] + "$" + columna["Estado_U"];
						Response.Redirect("PantallaInicial.aspx");
						return;
					}
				}
				lblMensaje.ForeColor = System.Drawing.Color.Red;
				lblMensaje.Text = "Los datos del usuario ingresado no existe";
				txtUsuario.Text = "";
				txtPassword.Text = "";
				return;
			}
		}
    }
}