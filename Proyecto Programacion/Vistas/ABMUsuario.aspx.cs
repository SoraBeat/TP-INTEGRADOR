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
				CargarDDL();
			}
			string datosUsuario = (string)Session["DATOSUSUARIO"];
			string[] separador = new string[] { " ", "$" };
			string[] datos = datosUsuario.Split(separador, StringSplitOptions.RemoveEmptyEntries);
			LBL_NOMBREUSUARIO.Text = datos[1];
			LBL_APELLIDOUSUARIO.Text = datos[2];
		}
		public void desloguear(object sender, EventArgs e)
		{
			Session["DATOSUSUARIO"] = null;
			Response.Redirect("PantallaInicial.aspx");
		}
		private void CargarTablaSinFiltro()
		{
			DataTable tablaUsuarios = negUsu.getListaUsuarios();
			gvUsuarios.DataSource = tablaUsuarios;
			gvUsuarios.DataBind();
		}
		private void CargarTablaConFiltro()
		{
			DataTable tablaUsu = new DataTable();
			switch (ddlFiltro.Text)
			{
				case "ID":
					tablaUsu = negUsu.getListaPorIDUsuario(txtFiltro.Text);
					break;
				case "NOMBRE":
					tablaUsu = negUsu.getListaPorNombreUsuario(txtFiltro.Text);
					break;
				case "APELLIDO":
					tablaUsu = negUsu.getListaPorApellidoUsuario(txtFiltro.Text);
					break;
				case "DNI":
					tablaUsu = negUsu.getListaPorDNIUsuario(txtFiltro.Text);
					break;
				case "TELEFONO":
					tablaUsu = negUsu.getListaPorTelefonoUsuario(txtFiltro.Text);
					break;
				case "EMAIL":
					tablaUsu = negUsu.getListaPorEmailUsuario(txtFiltro.Text);
					break;
				case "CONTRASEÑA":
					tablaUsu = negUsu.getListaPorContraseñaUsuario(txtFiltro.Text);
					break;
				case "TIPO USUARIO":
					tablaUsu = negUsu.getListaPorTipoDeUsuario(txtFiltro.Text);
					break;
				case "ESTADO":
					tablaUsu = negUsu.getListaPorEstadoDeUsuario(txtFiltro.Text);
					break;
			}
			gvUsuarios.DataSource = tablaUsu;
			gvUsuarios.DataBind();
			lblResultado.Text = "";
			lblResultadoGuardar.Text = "";
		}
		private void CargarDDL()
		{
			ListItem item;
			item = new ListItem("ID");
			ddlFiltro.Items.Add(item);
			item = new ListItem("NOMBRE");
			ddlFiltro.Items.Add(item);
			item = new ListItem("APELLIDO");
			ddlFiltro.Items.Add(item);
			item = new ListItem("DNI");
			ddlFiltro.Items.Add(item);
			item = new ListItem("TELEFONO");
			ddlFiltro.Items.Add(item);
			item = new ListItem("EMAIL");
			ddlFiltro.Items.Add(item);
			item = new ListItem("CONTRASEÑA");
			ddlFiltro.Items.Add(item);
			item = new ListItem("TIPO USUARIO");
			ddlFiltro.Items.Add(item);
			item = new ListItem("ESTADO");
			ddlFiltro.Items.Add(item);
			ddlFiltro.DataBind();
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
			CargarTablaConFiltro();
		}

        protected void gvUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
			gvUsuarios.EditIndex = e.NewEditIndex;
			CargarTablaConFiltro();
		}

        protected void gvUsuarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
			gvUsuarios.EditIndex = -1;
			CargarTablaSinFiltro();
		}

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
			if (IsValid)
			{
				String Nombre = txtNombre.Text;
				String Apellido = txtApellido.Text;
				String Dni = txtDni.Text;
				String Telefono = txtTelefono.Text;
				String Email = txtEmail.Text;
				String Contraseña = txtContraseña.Text;
				bool Tipo_Usuario = chkSuperUsu.Checked;

				Usuarios usu = new Usuarios();
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
				txtNombre.Text = "";
				txtApellido.Text = "";
				txtDni.Text = "";
				txtTelefono.Text = "";
				txtEmail.Text = "";
				txtContraseña.Text = "";
				chkSuperUsu.Text = "";
				CargarTablaSinFiltro();
			}
		}

        protected void gvUsuarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
			gvUsuarios.PageIndex = e.NewPageIndex;
			CargarTablaConFiltro();
		}

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
			if (txtFiltro.Text != "".Trim())
			{
				CargarTablaConFiltro();
			}
		}

        protected void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
				CargarTablaSinFiltro();
			txtFiltro.Text = "";
		}

        protected void gvUsuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
			int ID = Convert.ToInt32(((Label)gvUsuarios.Rows[e.RowIndex].FindControl("LBL_EDIT_ID")).Text);
			String Nombre = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("TXT_EDIT_NOMBRE")).Text;
			String Apellido = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("TXT_EDIT_APELLIDO")).Text;
			String DNI = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("TXT_EDIT_DNI")).Text;
			String Telefono = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("TXT_EDIT_TELEFONO")).Text;
			String Email = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("TXT_EDIT_EMAIL")).Text;
			String Contraseña = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("TXT_EDIT_CONTRASEÑA")).Text;
			bool TipoUsuario = ((CheckBox)gvUsuarios.Rows[e.RowIndex].FindControl("CHK_EDIT_TIPOUSUARIO")).Checked;
			bool Estado = ((CheckBox)gvUsuarios.Rows[e.RowIndex].FindControl("CHK_EDIT_ESTADO")).Checked;

			Usuarios usu = new Usuarios();
			usu.IDUsuario = ID;
			usu.NombreUsuario = Nombre;
			usu.ApellidoUsuario = Apellido;
			usu.DNIUsuario = DNI;
			usu.TelefonoUsuario = Telefono;
			usu.EmailUsuario = Email;
			usu.ContraseñaUsuario = Contraseña;
			usu.TipoUsuario = TipoUsuario;
			usu.Estado= Estado;

			if (negUsu.ModificarUsuario(usu))
			{
				lblResultado.Text = "Se modifico correctamente";
				lblResultado.ForeColor = System.Drawing.Color.Green;
			}
            else
            {
				lblResultado.Text = "Error al modificar";
				lblResultado.ForeColor = System.Drawing.Color.Red;
			}
			gvUsuarios.EditIndex = -1;
			CargarTablaConFiltro();
		}

        protected void gvUsuarios_RowCancelingEdit1(object sender, GridViewCancelEditEventArgs e)
        {
			gvUsuarios.EditIndex = -1;
			CargarTablaConFiltro();
		}
    }
}