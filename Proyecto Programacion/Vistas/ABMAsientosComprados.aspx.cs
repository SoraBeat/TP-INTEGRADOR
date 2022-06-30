using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entidades;
using Negocios;

namespace Vistas
{
    public partial class ABMAsientosComprados : System.Web.UI.Page
    {
		NegocioAsientosComprados negasico = new NegocioAsientosComprados();
		protected void Page_Load(object sender, EventArgs e)
		{
			CabezeraUsuario();
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
		public void CabezeraUsuario()
		{
			if (Session["DATOSUSUARIO"] != null)
			{
				ContenedorUsuario.Visible = true;
				string datosUsuario = (string)Session["DATOSUSUARIO"];
				string[] separador = new string[] { " ", "$" };
				string[] datos = datosUsuario.Split(separador, StringSplitOptions.RemoveEmptyEntries);
				ContenedorNombre.Text = datos[1];
			}
			else
			{
				ContenedorUsuario.Visible = false;
			}
		}
		public void desloguear(object sender, EventArgs e)
		{
			Session["DATOSUSUARIO"] = null;
			Response.Redirect("PantallaInicial.aspx");
		}
		private void CargarTablaSinFiltro()
		{
			DataTable tablaSala = negasico.getTabla();
			GV_ASIENTOSCOMPRADOS.DataSource = tablaSala;
			GV_ASIENTOSCOMPRADOS.DataBind();
		}
		private void CargarTablaConFiltro()
		{
			DataTable tablaSala = new DataTable();
			switch (DDL_FILTRO.Text)
			{
				case "ID":
					tablaSala = negasico.getTablaPorID(TXT_FILTRO.Text);
					break;
				case "ID Detalle Venta":
					tablaSala = negasico.getTablaPorDetalleVenta(TXT_FILTRO.Text);
					break;
				case "ID Venta":
					tablaSala = negasico.getTablaPorVenta(TXT_FILTRO.Text);
					break;
				case "ID Funcion":
					tablaSala = negasico.getTablaPorFuncion(TXT_FILTRO.Text);
					break;
				case "ID Sala":
					tablaSala = negasico.getTablaPorSala(TXT_FILTRO.Text);
					break;
				case "ID Complejo":
					tablaSala = negasico.getTablaPorComplejo(TXT_FILTRO.Text);
					break;
				case "Estado":
					tablaSala = negasico.getTablaPorEstado(TXT_FILTRO.Text);
					break;
			}
			GV_ASIENTOSCOMPRADOS.DataSource = tablaSala;
			GV_ASIENTOSCOMPRADOS.DataBind();
		}
		private void CargarGrid()
		{
			ListItem item;
			item = new ListItem("ID");
			DDL_FILTRO.Items.Add(item);
			item = new ListItem("ID Detalle Venta");
			DDL_FILTRO.Items.Add(item);
			item = new ListItem("ID Venta");
			DDL_FILTRO.Items.Add(item);
			item = new ListItem("ID Funcion");
			DDL_FILTRO.Items.Add(item);
			item = new ListItem("ID Sala");
			DDL_FILTRO.Items.Add(item);
			item = new ListItem("ID Complejo");
			DDL_FILTRO.Items.Add(item);
			item = new ListItem("Estado");
			DDL_FILTRO.Items.Add(item);
			DDL_FILTRO.DataBind();
		}

		protected void gvSalas_PageIndexChanging(object sender, GridViewPageEventArgs e)
		{
			GV_ASIENTOSCOMPRADOS.PageIndex = e.NewPageIndex;
			if (TXT_FILTRO.Text != "")
			{
				CargarTablaConFiltro();
			}
			else
			{
				CargarTablaSinFiltro();
			}
		}

        protected void BTN_FILTRAR_Click(object sender, EventArgs e)
        {
			if (TXT_FILTRO.Text != "".Trim())
			{
				CargarTablaConFiltro();
			}
		}

        protected void BTN_QUITARFILTRO_Click(object sender, EventArgs e)
        {
			CargarTablaSinFiltro();
			TXT_FILTRO.Text = "";
		}
    }
}