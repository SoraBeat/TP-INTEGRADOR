using System;
using System.Collections.Generic;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTicket.Text = nv.buscarProximaVenta().ToString();
        }
    }
}