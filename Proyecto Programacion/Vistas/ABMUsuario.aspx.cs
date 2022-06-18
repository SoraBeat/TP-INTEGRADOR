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
    public partial class ABMUsuario : System.Web.UI.Page
    {
		
		NegocioUsuario negUsu = new NegocioUsuario();
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				CargarTablaSinFiltro();
			}
		}
		private void CargarTablaSinFiltro()
		{
			DataTable tablaUsuarios = negUsu.getListaUsuarios();
			gvUsuarios.DataSource = tablaUsuarios;
			gvUsuarios.DataBind();
		}

        protected void gvUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
			String ID_Usuario = ((Label)gvUsuarios.Rows[e.RowIndex].FindControl("LBL_IT_ID")).Text;
			bool res = negUsu.EliminarUsuario(Convert.ToInt32(ID_Usuario));
			if (res)
			{
				lblResultado.ForeColor = System.Drawing.Color.Green;
				lblResultado.Text = "Se ha borrado correctamente";
			}
			else
			{
				lblResultado.ForeColor = System.Drawing.Color.Red;
				lblResultado.Text = "ERROR al borrar";
			}
			CargarTablaSinFiltro();
		}

        protected void gvUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
			gvUsuarios.EditIndex = e.NewEditIndex;
			CargarTablaSinFiltro();
		}

        protected void gvUsuarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
			gvUsuarios.EditIndex = -1;
			CargarTablaSinFiltro();
		}

        protected void gvUsuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
			String ID = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("TXT_EDIT_ID")).Text;
			String Nombre = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("TXT_EDIT_NOM")).Text;
			String Apellido = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("TXT_EDIT_APE")).Text;
			String Dni = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("TXT_EDIT_DNI")).Text;
			String Telefono = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("TXT_EDT_TELEFONO")).Text;
			String Email = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("TXT_EDIT_EMAIL")).Text;
			String Contraseña = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("TXT_EDIT_CON")).Text;
			String Tipo_Usuario = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("TXT_EDT_USU")).Text;


			Usuarios usu = new Usuarios();
			usu.IDUsuario = Convert.ToInt32(ID);
			usu.NombreUsuario = Nombre;
			usu.ApellidoUsuario = Apellido;
			usu.DNIUsuario = Dni;
			usu.TelefonoUsuario = Telefono;
			usu.EmailUsuario = Email;
			usu.ContraseñaUsuario = Contraseña;
			usu.TipoUsuario = Convert.ToBoolean(Tipo_Usuario);

			negUsu.AgregarUsuario(usu);
			gvUsuarios.EditIndex = -1;
			CargarTablaSinFiltro();

		}

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
			if (IsValid)
			{
				int ID = Convert.ToInt32(txtID.Text);
				String Nombre = txtNombre.Text;
				String Apellido = txtApellido.Text;
				String Dni = txtDni.Text;
				String Telefono = txtTelefono.Text;
				String Email = txtEmail.Text;
				String Contraseña = txtContraseña.Text;
				bool Tipo_Usuario = chkSuperUsu.Checked;

				Usuarios usu = new Usuarios();
				usu.IDUsuario = ID;
				usu.NombreUsuario = Nombre;
				usu.ApellidoUsuario = Apellido;
				usu.DNIUsuario = Dni;
				usu.TelefonoUsuario = Telefono;
				usu.EmailUsuario = Email;
				usu.ContraseñaUsuario = Contraseña;
				usu.TipoUsuario = Tipo_Usuario;


				bool res = negUsu.AgregarUsuario(usu);
				if (res)
				{
					lblResultadoGuardar.ForeColor = System.Drawing.Color.Green;
					lblResultadoGuardar.Text = "Se ha guardado con exito";
				}
				else
				{
					lblResultadoGuardar.ForeColor = System.Drawing.Color.Red;
					lblResultadoGuardar.Text = "ERROR al guardar";
				}
				gvUsuarios.EditIndex = -1;
				CargarTablaSinFiltro();
			}
		}
    }
}