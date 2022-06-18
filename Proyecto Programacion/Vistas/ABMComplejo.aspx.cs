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
		}

        protected void gvComplejos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
			//Busco ID del Complejo
			String ID_Complejo = ((Label)gvComplejos.Rows[e.RowIndex].FindControl("LBL_IT_ID")).Text;
			bool res = negcom.EliminarComplejo(ID_Complejo);
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
			CargarTablaSinFiltro();
        }

        protected void gvComplejos_RowEditing(object sender, GridViewEditEventArgs e)
        {
			gvComplejos.EditIndex = e.NewEditIndex;
			CargarTablaSinFiltro();
        }

        protected void gvComplejos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
			gvComplejos.EditIndex = -1;
			CargarTablaSinFiltro();
        }

        protected void gvComplejos_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
			String ID = ((TextBox)gvComplejos.Rows[e.AffectedRows].FindControl("TXT_EDT_ID")).Text;
			String Nombre = ((TextBox)gvComplejos.Rows[e.AffectedRows].FindControl("TXT_EDT_NOMBRE")).Text;
			String Direccion = ((TextBox)gvComplejos.Rows[e.AffectedRows].FindControl("TXT_EDT_DIRECCION")).Text;
			String Telefono = ((TextBox)gvComplejos.Rows[e.AffectedRows].FindControl("TXT_EDT_TELEFONO")).Text;
			String Email = ((TextBox)gvComplejos.Rows[e.AffectedRows].FindControl("TXT_EDT_EMAIL")).Text;


			Complejos com = new Complejos();
			com.ID_Complejo = ID;
			com.Nombre = Nombre;
			com.Direccion = Direccion;
			com.Telefono = Telefono;
			com.Email = Email;

			negcom.AgregarComplejo(com);
		}
    }
}