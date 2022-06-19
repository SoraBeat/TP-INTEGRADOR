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
	public partial class ABMSalas : System.Web.UI.Page
	{
		NegocioSalas negsa = new NegocioSalas();
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				CargarTablaSinFiltro();
				CargarGrid();
			}
		}
		private void CargarTablaSinFiltro()
		{
			DataTable tablaSala = negsa.getTabla();
			gvSalas.DataSource = tablaSala;
			gvSalas.DataBind();
			lblResultado.Text = "";
			lblResultadoGuardar.Text = "";
		}
		private void CargarTablaConFiltro()
		{
			DataTable tablaSala = new DataTable();
			switch (ddlFiltro.Text)
			{
				case "ID":
					tablaSala = negsa.getTablaPorID(tbFiltro.Text);
					break;
				case "ID Complejo":
					tablaSala = negsa.getTablaPorComplejo(tbFiltro.Text);
					break;
				case "Cantidad Asientos":
					tablaSala = negsa.getTablaPorAsientos(tbFiltro.Text);
					break;
				case "Estado":
					tablaSala = negsa.getTablaPorEstado(tbFiltro.Text);
					break;
			}
			gvSalas.DataSource = tablaSala;
			gvSalas.DataBind();
			lblResultado.Text = "";
			lblResultadoGuardar.Text = "";
		}
		private void CargarGrid()
		{
			ListItem item;
			item = new ListItem("ID");
			ddlFiltro.Items.Add(item);
			item = new ListItem("ID Complejo");
			ddlFiltro.Items.Add(item);
			item = new ListItem("Cantidad Asientos");
			ddlFiltro.Items.Add(item);
			item = new ListItem("Estado");
			ddlFiltro.Items.Add(item);
			ddlFiltro.DataBind();
		}

		protected void gvSals_RowDeleting(object sender, GridViewDeleteEventArgs e)
		{
			//Busco ID del Complejo
			string ID_Sala = ((Label)gvSalas.Rows[e.RowIndex].FindControl("LBL_IT_ID")).Text;
			string ID_Complejo = ((Label)gvSalas.Rows[e.RowIndex].FindControl("LBL_IT_COMPLEJO")).Text;
			bool res = negsa.EliminarSala(ID_Sala,ID_Complejo);
			CargarTablaConFiltro();
			lblResultado.ForeColor = System.Drawing.Color.Green;
			lblResultado.Text = "Se ha borrado correctamente";
		}

		protected void gvSalas_RowEditing(object sender, GridViewEditEventArgs e)
		{
			gvSalas.EditIndex = e.NewEditIndex;
			CargarTablaConFiltro();
		}

		protected void gvSalas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
		{
			gvSalas.EditIndex = -1;
			CargarTablaSinFiltro();
		}

		protected void gvSalas_RowUpdating(object sender, GridViewUpdateEventArgs e)
		{
			string ID = ((Label)gvSalas.Rows[e.RowIndex].FindControl("LBL_EDT_ID")).Text;
			string ID_Complejo = ((Label)gvSalas.Rows[e.RowIndex].FindControl("LBL_EDT_COMPLEJO")).Text;
			int Asientos = Convert.ToInt32(((TextBox)gvSalas.Rows[e.RowIndex].FindControl("TXT_EDT_ASIENTOS")).Text);
			bool Estados = Convert.ToBoolean(((CheckBox)gvSalas.Rows[e.RowIndex].FindControl("TXT_EDT_ESTADO")).Checked);


			Salas sala = new Salas();
			sala.IDSala = ID;
			sala.IDComplejo = ID_Complejo;
			sala.TotalAsientos = Asientos;
			sala.Estado = Estados;


			bool res =negsa.ModificarSala(sala);
			gvSalas.EditIndex = -1;
			CargarTablaConFiltro();
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
				string ID = txtID.Text;
				string ID_Complejo = txtIDComplejo.Text;
				string Asientos = txtCantidadAsientos.Text;

				Salas sala = new Salas();
				sala.IDSala = ID;
				sala.IDComplejo = ID_Complejo;
				sala.TotalAsientos = Convert.ToInt32(Asientos);

				bool res = negsa.AgregarSala(sala);
				gvSalas.EditIndex = -1;
				txtID.Text = "";
				txtIDComplejo.Text = "";
				txtCantidadAsientos.Text = "";
				CargarTablaSinFiltro();
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
			}
		}

		protected void gvSalas_PageIndexChanging(object sender, GridViewPageEventArgs e)
		{
			gvSalas.PageIndex = e.NewPageIndex;
			CargarTablaConFiltro();
		}

        protected void Button1_Click(object sender, EventArgs e)
        {
			if (tbFiltro.Text != "".Trim())
			{
				CargarTablaConFiltro();
			}
		}

        protected void Button2_Click(object sender, EventArgs e)
        {
			CargarTablaSinFiltro();
			tbFiltro.Text = "";
		}
    }
}