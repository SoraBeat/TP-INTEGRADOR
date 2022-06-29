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
    public partial class Ventas : System.Web.UI.Page
    {
        NegocioVentas negVen = new NegocioVentas();
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
            DataTable tablaVentas = negVen.getListaVentas();
            gvVentas.DataSource = tablaVentas;
            gvVentas.DataBind();
        }
		private void CargarTablaConFiltro()
		{
			DataTable tablaVentas = new DataTable();
			switch (ddlFiltro.Text)
			{
				case "ID Venta":
					tablaVentas = negVen.getListaPorIDVenta(txtFiltro.Text);
					break;
				case "ID Usuario":
					tablaVentas = negVen.getListaPorIDUsuario(txtFiltro.Text);
					break;
				case "Fecha":
					tablaVentas = negVen.getListaPorFechaVenta(txtFiltro.Text);
					break;
				case "Metodo Pago":
					tablaVentas = negVen.getListaPorMetodoDePago(txtFiltro.Text);
					break;
				case "Monto Final Mayor A":
					tablaVentas = negVen.getListaPorMontoFinalMayorA(txtFiltro.Text);
					break;
				case "Monto Final Menor A":
					tablaVentas = negVen.getListaPorMontoFinalMenorA(txtFiltro.Text);
					break;
			}
			txtFiltro.Text = "";
			gvVentas.DataSource = tablaVentas;
			gvVentas.DataBind();
		}


		private void CargarDDL()
		{
			ListItem item;
			item = new ListItem("ID Venta");
			ddlFiltro.Items.Add(item);
			item = new ListItem("ID Usuario");
			ddlFiltro.Items.Add(item);
			item = new ListItem("Fecha");
			ddlFiltro.Items.Add(item);
			item = new ListItem("Metodo Pago");
			ddlFiltro.Items.Add(item);
			item = new ListItem("Monto Final Mayor A");
			ddlFiltro.Items.Add(item);
			item = new ListItem("Monto Final Menor A");
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