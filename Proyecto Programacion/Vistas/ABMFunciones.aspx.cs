using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using Negocios;

namespace Vistas
{
	public partial class ABMFunciones : System.Web.UI.Page
	{
		NegocioFunciones negfu = new NegocioFunciones();
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
		private void CargarTablaSinFiltro()
		{
			DataTable tablaSala = negfu.getTabla();
			gvFunciones.DataSource = tablaSala;
			gvFunciones.DataBind();
			lblResultado.Text = "";
			lblResultadoEnviar.Text = "";
		}
		public void desloguear(object sender, EventArgs e)
		{
			Session["DATOSUSUARIO"] = null;
			Response.Redirect("PantallaInicial.aspx");
		}
		private void CargarTablaConFiltro()
		{
			DataTable tablaSala = new DataTable();
			switch (ddlFiltro.Text)
			{
				case "ID":
					tablaSala = negfu.getTablaPorID(txtFiltro.Text);
					break;
				case "ID Pelicula":
					tablaSala = negfu.getTablaPorPelicula(txtFiltro.Text);
					break;
				case "ID Sala":
					tablaSala = negfu.getTablaPorSala(txtFiltro.Text);
					break;
				case "ID Complejo":
					tablaSala = negfu.getTablaPorComplejo(txtFiltro.Text);
					break;
				case "Fecha":
					tablaSala = negfu.getTablaPorFecha(txtFiltro.Text);
					break;
				case "Horario":
					tablaSala = negfu.getTablaPorHorario(txtFiltro.Text);
					break;
				case "Idioma":
					tablaSala = negfu.getTablaPorIdioma(txtFiltro.Text);
					break;
				case "Formato":
					tablaSala = negfu.getTablaPorFormato(txtFiltro.Text);
					break;
				case "Precio":
					tablaSala = negfu.getTablaPorPrecio(txtFiltro.Text);
					break;
				case "Estado":
					tablaSala = negfu.getTablaPorEstado(txtFiltro.Text);
					break;
			}
			gvFunciones.DataSource = tablaSala;
			gvFunciones.DataBind();
			lblResultado.Text = "";
			lblResultadoEnviar.Text = "";
		}
		private void CargarGrid()
		{
			ListItem item;
			item = new ListItem("ID");
			ddlFiltro.Items.Add(item);
			item = new ListItem("ID Pelicula");
			ddlFiltro.Items.Add(item);
			item = new ListItem("ID Sala");
			ddlFiltro.Items.Add(item);
			item = new ListItem("ID Complejo");
			ddlFiltro.Items.Add(item);
			item = new ListItem("Fecha");
			ddlFiltro.Items.Add(item);
			item = new ListItem("Horario");
			ddlFiltro.Items.Add(item);
			item = new ListItem("Idioma");
			ddlFiltro.Items.Add(item);
			item = new ListItem("Formato");
			ddlFiltro.Items.Add(item);
			item = new ListItem("Precio");
			ddlFiltro.Items.Add(item);
			item = new ListItem("Estado");
			ddlFiltro.Items.Add(item);
			ddlFiltro.DataBind();
		}

		protected void gvFunciones_RowDeleting(object sender, GridViewDeleteEventArgs e)
		{
			//Busco ID del Complejo
			string ID_Funcion = ((Label)gvFunciones.Rows[e.RowIndex].FindControl("LBL_IT_ID")).Text;
			bool res = negfu.EliminarFuncion(ID_Funcion);
			lblResultado.ForeColor = System.Drawing.Color.Green;
			lblResultado.Text = "Se ha borrado correctamente";

			if (txtFiltro.Text != "")
			{
				CargarTablaConFiltro();
			}
			else
			{
				CargarTablaSinFiltro();
			}
		}

		protected void gvFunciones_RowEditing(object sender, GridViewEditEventArgs e)
		{
			gvFunciones.EditIndex = e.NewEditIndex;
			if (txtFiltro.Text != "")
			{
				CargarTablaConFiltro();
			}
			else
			{
				CargarTablaSinFiltro();
			}
		}

		protected void gvFunciones_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
		{
			gvFunciones.EditIndex = -1;
			if (txtFiltro.Text != "")
			{
				CargarTablaConFiltro();
			}
			else
			{
				CargarTablaSinFiltro();
			}
		}

		protected void gvFunciones_RowUpdating(object sender, GridViewUpdateEventArgs e)
		{
			string ID = ((Label)gvFunciones.Rows[e.RowIndex].FindControl("LBL_EDT_ID")).Text;
			string ID_Pelicula = ((TextBox)gvFunciones.Rows[e.RowIndex].FindControl("TXT_EDT_IDPELICULA")).Text;
			string ID_Sala = ((TextBox)gvFunciones.Rows[e.RowIndex].FindControl("TXT_EDT_IDSALA")).Text;
			string ID_Complejo = ((TextBox)gvFunciones.Rows[e.RowIndex].FindControl("TXT_EDT_IDCOMPLEJO")).Text;
			string Fecha = ((TextBox)gvFunciones.Rows[e.RowIndex].FindControl("TXT_EDT_FECHA")).Text;
			string Horario = ((TextBox)gvFunciones.Rows[e.RowIndex].FindControl("TXT_EDT_HORARIO")).Text;
			string Idioma = ((TextBox)gvFunciones.Rows[e.RowIndex].FindControl("TXT_EDT_IDIOMA")).Text;
			string Formato = ((TextBox)gvFunciones.Rows[e.RowIndex].FindControl("TXT_EDT_FORMATO")).Text;
			decimal Precio = Convert.ToDecimal(((TextBox)gvFunciones.Rows[e.RowIndex].FindControl("TXT_EDT_PRECIO")).Text);
			bool Estado = Convert.ToBoolean(((CheckBox)gvFunciones.Rows[e.RowIndex].FindControl("CB_EDT_ESTADO")).Checked);


			Funciones funcion = new Funciones();
			funcion.IdFuncion = ID;
			funcion.IdPelicula = ID_Pelicula;
			funcion.IdSala = ID_Sala;
			funcion.IdComplejo = ID_Complejo;
			funcion.FechaFuncion = Fecha;
			funcion.HorarioFuncion = Horario;
			funcion.IdiomaFuncion = Idioma;
			funcion.FormatoFuncion = Formato;
			funcion.PrecioFuncion = Precio;
			funcion.EstadoFuncion = Estado;

			bool res = negfu.ModificarFuncion(funcion);
			gvFunciones.EditIndex = -1;
			if (txtFiltro.Text != "")
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


		protected void gvFunciones_PageIndexChanging(object sender, GridViewPageEventArgs e)
		{
			gvFunciones.PageIndex = e.NewPageIndex;
			if (txtFiltro.Text != "")
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
			if (txtFiltro.Text != "".Trim())
			{
				CargarTablaConFiltro();
			}
			lblResultado.Text = "";
			lblResultadoEnviar.Text = "";
		}

        protected void btnFiltrarTodo_Click(object sender, EventArgs e)
        {
			CargarTablaSinFiltro();
			txtFiltro.Text = "";
			lblResultado.Text = "";
			lblResultadoEnviar.Text = "";
		}

        protected void btnENVIAR_Click1(object sender, EventArgs e)
        {
			if (IsValid)
			{
				string ID = txtID.Text;
				string ID_Pelicula = txtIDPELICULA.Text;
				string ID_Sala = txtIDSALA.Text;
				string ID_Complejo = txtIDCOMPLEJO.Text;
				string Fecha = txtFECHA.Text;
				string Horario = txtHORARIO.Text;
				string Idioma = txtIDIOMA.Text;
				string Formato = txtFORMATO.Text;
				decimal Precio = Convert.ToDecimal(txtPRECIO.Text);

				Funciones funcion = new Funciones();
				funcion.IdFuncion = ID;
				funcion.IdPelicula = ID_Pelicula;
				funcion.IdSala = ID_Sala;
				funcion.IdComplejo = ID_Complejo;
				funcion.FechaFuncion = Fecha;
				funcion.HorarioFuncion = Horario;
				funcion.IdiomaFuncion = Idioma;
				funcion.FormatoFuncion = Formato;
				funcion.PrecioFuncion = Precio;

				bool res = negfu.AgregarFuncion(funcion);

				gvFunciones.EditIndex = -1;
				txtID.Text = "";
				txtIDPELICULA.Text = "";
				txtIDSALA.Text = "";
				txtIDCOMPLEJO.Text = "";
				txtFECHA.Text = "";
				txtHORARIO.Text = "";
				txtIDIOMA.Text = "";
				txtFORMATO.Text = "";
				txtPRECIO.Text = "";
				if (txtFiltro.Text != "")
				{
					CargarTablaConFiltro();
				}
				else
				{
					CargarTablaSinFiltro();
				}
				if (res)
				{
					lblResultadoEnviar.ForeColor = System.Drawing.Color.Green;
					lblResultadoEnviar.Text = "Se ha guardado con exito";
				}
				else
				{
					lblResultadoEnviar.ForeColor = System.Drawing.Color.Red;
					lblResultadoEnviar.Text = "ERROR al guardar";
				}
			}
		}
    }
}