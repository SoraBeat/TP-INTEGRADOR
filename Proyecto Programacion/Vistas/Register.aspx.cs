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

				
				DataTable res = negUsu.ExisteUsuarioEmail(usu); 
				foreach(DataRow columna in res.Rows)
                {
                    if (columna["Email_U"] != null || columna ["DNI_U"] != null)
                    {
						lblMensaje.ForeColor = System.Drawing.Color.Red;
						lblMensaje.Text = "Ese usuario ya existe";
						return;
                    }
				}
				negUsu.AgregarUsuario(usu);
				Session["DATOSUSUARIO"] = usu.IDUsuario + "$" + usu.NombreUsuario + "$" + usu.ApellidoUsuario + "$" + usu.DNIUsuario + "$" + usu.TelefonoUsuario + "$" + usu.EmailUsuario + "$" + usu.ContraseñaUsuario + "$" + usu.TipoUsuario + "$" + usu.Estado;
				Response.Redirect("PantallaInicial.aspx");
			}
		}
    }
}