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
	public partial class ABMComplejo : System.Web.UI.Page
	{
		NegocioComplejos negcom = new NegocioComplejos();
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				CargarTablaSinFiltro();
				CargarGrid();
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
			DataTable tablaComplejo = negcom.getListaComplejos();
			gvComplejos.DataSource = tablaComplejo;
			gvComplejos.DataBind();
			lblResultado.Text = "";
			lblResultadoGuardar.Text = "";
		}
		private void CargarTablaConFiltro()
		{
			DataTable tablaComplejo = new DataTable();
			switch (ddlFiltro.Text)
			{
				case "ID": tablaComplejo = negcom.getListaComplejosPorID(tbFiltro.Text);
					break;
				case "NOMBRE": tablaComplejo = negcom.getListaComplejosPorNombre(tbFiltro.Text);
					break;
				case "DIRECCION": tablaComplejo = negcom.getListaComplejosPorDireccion(tbFiltro.Text);
					break;
				case "TELEFONO": tablaComplejo = negcom.getListaComplejosPorTelefono(tbFiltro.Text);
					break;
				case "EMAIL": tablaComplejo = negcom.getListaComplejosPorEmail(tbFiltro.Text);
					break;
				case "ESTADO": tablaComplejo = negcom.getListaComplejosPorEstado(tbFiltro.Text);
					break;
			}
			gvComplejos.DataSource = tablaComplejo;
			gvComplejos.DataBind();
			lblResultado.Text = "";
			lblResultadoGuardar.Text = "";
		}
		private void CargarGrid()
		{
			ListItem item;
			item = new ListItem("ID");
			ddlFiltro.Items.Add(item);
			item = new ListItem("NOMBRE");
			ddlFiltro.Items.Add(item);
			item = new ListItem("DIRECCION");
			ddlFiltro.Items.Add(item);
			item = new ListItem("TELEFONO");
			ddlFiltro.Items.Add(item);
			item = new ListItem("EMAIL");
			ddlFiltro.Items.Add(item);
			item = new ListItem("ESTADO");
			ddlFiltro.Items.Add(item);
			ddlFiltro.DataBind();
		}

		protected void gvComplejos_RowDeleting(object sender, GridViewDeleteEventArgs e)
		{
			//Busco ID del Complejo
			String ID_Complejo = ((Label)gvComplejos.Rows[e.RowIndex].FindControl("LBL_IT_ID")).Text;
			bool res = negcom.EliminarComplejo(ID_Complejo);
			if (tbFiltro.Text != "")
			{
				CargarTablaConFiltro();
			}
			else
			{
				CargarTablaSinFiltro();
			}
			lblResultado.ForeColor = System.Drawing.Color.Green;
			lblResultado.Text = "Se ha borrado correctamente";
		}

		protected void gvComplejos_RowEditing(object sender, GridViewEditEventArgs e)
		{
			gvComplejos.EditIndex = e.NewEditIndex;
			if (tbFiltro.Text != "")
			{
				CargarTablaConFiltro();
			}
			else
			{
				CargarTablaSinFiltro();
			}
		}

		protected void gvComplejos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
		{
			gvComplejos.EditIndex = -1;
			if (tbFiltro.Text != "")
			{
				CargarTablaConFiltro();
			}
			else
			{
				CargarTablaSinFiltro();
			}
		}

		protected void gvComplejos_RowUpdating(object sender, GridViewUpdateEventArgs e)
		{
			String ID = ((Label)gvComplejos.Rows[e.RowIndex].FindControl("LBL_EDT_ID")).Text;
			String Nombre = ((TextBox)gvComplejos.Rows[e.RowIndex].FindControl("TXT_EDT_NOMBRE")).Text;
			String Direccion = ((TextBox)gvComplejos.Rows[e.RowIndex].FindControl("TXT_EDT_DIRECCION")).Text;
			String Telefono = ((TextBox)gvComplejos.Rows[e.RowIndex].FindControl("TXT_EDT_TELEFONO")).Text;
			String Email = ((TextBox)gvComplejos.Rows[e.RowIndex].FindControl("TXT_EDT_EMAIL")).Text;
			bool Estado = ((CheckBox)gvComplejos.Rows[e.RowIndex].FindControl("TXT_EDT_ESTADO")).Checked;

			Complejos com = new Complejos();
			com.ID_Complejo = ID;
			com.Nombre = Nombre;
			com.Direccion = Direccion;
			com.Telefono = Telefono;
			com.Email = Email;
			com.Estado_Co1 = Estado;

			bool res = negcom.ModificarComplejo(com);
			gvComplejos.EditIndex = -1;
			if (tbFiltro.Text != "")
			{
				CargarTablaConFiltro();
			}
			else
			{
				CargarTablaSinFiltro();
			}
			if (res)
            {
				lblResultado.ForeColor = System.Drawing.Color.Green;
				lblResultado.Text = "Se ha editado correctamente";
			}
            else
            {
				lblResultado.ForeColor = System.Drawing.Color.Red;
				lblResultado.Text = "ERROR al editar";
			}
		}

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
			if (IsValid)
			{
				String ID = txtID.Text;
				String Nombre = txtNombre.Text;
				String Direccion = txtDireccion.Text;
				String Telefono = txtTelefono.Text;
				String Email = txtEmail.Text;

				Complejos com = new Complejos();
				com.ID_Complejo = ID;
				com.Nombre = Nombre;
				com.Direccion = Direccion;
				com.Telefono = Telefono;
				com.Email = Email;

				DataTable res2 = negcom.ExisteComplejo2(com);
				foreach (DataRow columna in res2.Rows)
				{
					if (columna["ID_Complejo_Co"] != null || columna["Nombre_Co"] != null || columna["Direccion_Co"] !=null)
					{
						lblResultadoGuardar.ForeColor = System.Drawing.Color.Red;
						lblResultadoGuardar.Text = "Ese Complejo ya existe";
						return;
					}
				}

				bool res = negcom.AgregarComplejo(com);
				gvComplejos.EditIndex = -1;
				txtID.Text = "";
				txtNombre.Text = "";
				txtDireccion.Text = "";
				txtTelefono.Text = "";
				txtEmail.Text = "";
				CargarTablaSinFiltro();
				if (res)
				{
					lblResultadoGuardar.ForeColor = System.Drawing.Color.Green;
					lblResultadoGuardar.Text = "Se ha guardado con exito";
				}
				else
				{
					lblResultadoGuardar.ForeColor = System.Drawing.Color.Red;
					lblResultadoGuardar.Text = "Error El Complejo Ya Existe";
				}
			}
		}

        protected void gvComplejos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
			gvComplejos.PageIndex = e.NewPageIndex;
			if (tbFiltro.Text != "")
			{
				CargarTablaConFiltro();
			}
			else
			{
				CargarTablaSinFiltro();
			}
		}

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
			if(tbFiltro.Text!="".Trim())
            {
				CargarTablaConFiltro();
			}
        }

        protected void btnFiltrarTodo_Click(object sender, EventArgs e)
        {
			CargarTablaSinFiltro();
			tbFiltro.Text = "";
        }
    }
}