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

				bool add = negUsu.AgregarUsuario(usu);
				DataTable res = negUsu.ExisteUsuario(usu); //una vez ya agregado el usuario agarramos toda la data con esta función
				foreach(DataRow columna in res.Rows)
                {
					Session["DATOSUSUARIO"] = columna["ID_Usuario_U"] + "$" + columna["Nombre_U"] + "$" + columna["Apellido_U"] + "$" + columna["DNI_U"] + "$" + columna["Telefono_U"] + "$" + columna["Email_U"] + "$" + columna["Contraseña_U"] + "$" + columna["Tipo_Usuario_U"] + "$" + columna["Estado_U"];
					Response.Redirect("PantallaInicial.aspx");
				}
			}
		}
    }
}