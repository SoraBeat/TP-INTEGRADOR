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
			}
		}
		private void CargarTablaSinFiltro()
		{
			DataTable tablaComplejo = negcom.getListaComplejos();
			gvComplejos.DataSource = tablaComplejo;
			gvComplejos.DataBind();
			tbFiltro.Text = "";
		}
	}
}