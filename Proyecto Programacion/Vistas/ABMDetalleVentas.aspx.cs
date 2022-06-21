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
    public partial class ABMDetalleVentas : System.Web.UI.Page
    {
		NegocioDetalleVentas negDV = new NegocioDetalleVentas();
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
        private void CargarTablaSinFiltro()
        {
            DataTable tablaDetalleVentas = negDV.getListaDetalleVentas();
            gvDetalleVentas.DataSource = tablaDetalleVentas;
            gvDetalleVentas.DataBind();
        }

		public void desloguear(object sender, EventArgs e)
		{
			Session["DATOSUSUARIO"] = null;
			Response.Redirect("PantallaInicial.aspx");
		}
		private void CargarTablaConFiltro()
		{
			DataTable tablaDetalleVentas = new DataTable();
			switch (ddlFiltro.Text)
			{
				case "ID Detalle Venta":
					tablaDetalleVentas = negDV.getListaPorIDDetalleVenta(txtFiltro.Text);
					break;
				case "ID Venta":
					tablaDetalleVentas = negDV.getListaPorIDVenta(txtFiltro.Text);
					break;
				case "ID Funcion":
					tablaDetalleVentas = negDV.getListaPorIDFuncion(txtFiltro.Text);
					break;
				case "ID Sala":
					tablaDetalleVentas = negDV.getListaPorIDSala(txtFiltro.Text);
					break;
				case "ID Complejo":
					tablaDetalleVentas = negDV.getListaPorIDComplejo(txtFiltro.Text);
					break;
				case "Cantidad":
					tablaDetalleVentas = negDV.getListaPorCantidad(txtFiltro.Text);
					break;
				case "Precio":
					tablaDetalleVentas = negDV.getListaPorPrecio(txtFiltro.Text);
					break;
			}
			gvDetalleVentas.DataSource = tablaDetalleVentas;
			gvDetalleVentas.DataBind();
		}
		private void CargarDDL()
		{
			ListItem item;
			item = new ListItem("ID Detalle Venta");
			ddlFiltro.Items.Add(item);
			item = new ListItem("ID Venta");
			ddlFiltro.Items.Add(item);
			item = new ListItem("ID Funcion");
			ddlFiltro.Items.Add(item);
			item = new ListItem("ID Sala");
			ddlFiltro.Items.Add(item);
			item = new ListItem("ID Complejo");
			ddlFiltro.Items.Add(item);
			item = new ListItem("Cantidad");
			ddlFiltro.Items.Add(item);
			item = new ListItem("Precio");
			ddlFiltro.Items.Add(item);
			ddlFiltro.DataBind();
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
    }
}