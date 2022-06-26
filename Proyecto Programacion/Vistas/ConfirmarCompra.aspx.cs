using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocios;

namespace Vistas
{
    public partial class ConfirmarCompra : System.Web.UI.Page
    {
        NegocioVentas nv = new NegocioVentas();
        NegocioAsientos na = new NegocioAsientos();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTicket.Text = nv.buscarProximaVenta().ToString();
            if (IsPostBack == false)
            {
               ll.Text = Request.QueryString["ID"];
               // CargarDDL();
            }
        }
        /*private void CargarDDL()
        {
            DataTable tablaComplejos = na.getListaAsientos();
            ddlUbicacion.DataSource = tablaComplejos;
            ddlUbicacion.DataTextField = "ID_Asiento_A";
            ddlUbicacion.DataValueField = "ID_Asiento_A";
            ddlUbicacion.DataBind();
            ddlUbicacion.Items.Insert(0, new ListItem("Seleccione Un Asiento", "0"));
        }*/

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}