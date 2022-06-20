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
	public partial class Register : System.Web.UI.Page
	{
		NegocioUsuario negUsu = new NegocioUsuario();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void Button1_Click(object sender, EventArgs e)
        {
			if (IsValid)
			{
				String Nombre = txtNombre.Text;
				String Apellido = txtApellido.Text;
				String Dni = txtDNI.Text;
				String Telefono = txtTelefono.Text;
				String Email = txtEmail.Text;
				String Contraseña = txtPassword.Text;
				String Contraseña2 = txtPassword2.Text;

				Usuarios usu = new Usuarios();
				usu.NombreUsuario = Nombre;
				usu.ApellidoUsuario = Apellido;
				usu.DNIUsuario = Dni;
				usu.TelefonoUsuario = Telefono;
				usu.EmailUsuario = Email;
				usu.ContraseñaUsuario = Contraseña;

				bool res = negUsu.AgregarUsuario(usu);
				if (res)
				{
					Session["Usuario"] = Nombre;
					Response.Redirect("PantallaInicial.aspx");
					//Session.RemoveAll();
				}
			}
		}
    }
}