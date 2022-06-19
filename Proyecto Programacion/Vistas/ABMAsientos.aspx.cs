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
    public partial class ABMAsientos : System.Web.UI.Page
    {
        NegocioAsientos negasi = new NegocioAsientos();
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
            DataTable tablaAsientos = negasi.getListaAsientos();
            gvAsientos.DataSource = tablaAsientos;
            gvAsientos.DataBind();
            lblResultado.Text = "";
            lblResultadoGuardar.Text = "";
        }
        private void CargarTablaConFiltro()
        {
            DataTable tablaAsientos = new DataTable();
            switch (ddlFiltro.Text)
            {
                case "ID ASIENTO":
                    tablaAsientos = negasi.getListaPorID(txtFiltro.Text);
                    break;
                case "ID SALA":
                    tablaAsientos = negasi.getListaPorIDSala(txtFiltro.Text);
                    break;
                case "ID COMPLEJO":
                    tablaAsientos = negasi.getListaPorIDComplejo(txtFiltro.Text);
                    break;
                case "ESTADO":
                    tablaAsientos = negasi.getListaAsientosPorEstado(txtFiltro.Text);
                    break;
            }
            gvAsientos.DataSource = tablaAsientos;
            gvAsientos.DataBind();
            lblResultado.Text = "";
            lblResultadoGuardar.Text = "";
        }
        private void CargarGrid()
        {
            ListItem item;
            item = new ListItem("ID ASIENTO");
            ddlFiltro.Items.Add(item);
            item = new ListItem("ID SALA");
            ddlFiltro.Items.Add(item);
            item = new ListItem("ID COMPLEJO");
            ddlFiltro.Items.Add(item);
            item = new ListItem("ESTADO");
            ddlFiltro.Items.Add(item);
            ddlFiltro.DataBind();
        }

        protected void gvAsientos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Busco ID del Asiento
            String IDAsiento = ((Label)gvAsientos.Rows[e.RowIndex].FindControl("LBL_IT_IDASIENTO")).Text;
            String IDSala = ((Label)gvAsientos.Rows[e.RowIndex].FindControl("LBL_IT_IDSALA")).Text;
            String IDComplejo = ((Label)gvAsientos.Rows[e.RowIndex].FindControl("LBL_IT_IDCOMPLEJO")).Text;
            bool res = negasi.EliminarAsiento(IDAsiento,IDSala,IDComplejo);

            CargarTablaConFiltro();

            if (cbEstado.Checked)
            {
                lblResultado.ForeColor = System.Drawing.Color.Green;
                lblResultado.Text = "Se ha borrado correctamente";
            }
            

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                string IDAsiento = txtIDAsiento.Text;
                string IDSala = txtIDSala.Text;
                string IDComplejo = txtIDComplejo.Text;
                bool estado = cbEstado.Checked;

                Asientos asi = new Asientos();
                asi.IDAsiento = IDAsiento;
                asi.IDSala = IDSala;
                asi.IDComplejo = IDComplejo;
                
                bool res = negasi.AgregarAsiento(asi.IDAsiento,asi.IDSala,asi.IDComplejo);
          
                gvAsientos.EditIndex = -1;
                txtIDAsiento.Text = "";
                txtIDSala.Text = "";
                txtIDComplejo.Text = "";
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

        protected void gvAsientos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvAsientos.PageIndex = e.NewPageIndex;
            CargarTablaConFiltro();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtFiltro.Text != "".Trim())
            {
                CargarTablaConFiltro();
            }
        }

        protected void btnFiltrarTodo_Click(object sender, EventArgs e)
        {
            CargarTablaSinFiltro();
            txtFiltro.Text = "";
        }

        protected void gvAsientos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String IDAsiento = ((Label)gvAsientos.Rows[e.RowIndex].FindControl("LBL_EDT_IDASIENTO")).Text;
            String IDSala = ((Label)gvAsientos.Rows[e.RowIndex].FindControl("LBL_EDT_IDSALA")).Text;
            String IDComplejo = ((Label)gvAsientos.Rows[e.RowIndex].FindControl("LBL_EDT_IDCOMPLEJO")).Text;
            bool Estado = ((CheckBox)gvAsientos.Rows[e.RowIndex].FindControl("TXT_EDT_ESTADO")).Checked;

            Asientos asi = new Asientos();
            asi.IDAsiento = IDAsiento;
            asi.IDSala = IDSala;
            asi.IDComplejo = IDComplejo;
            asi.Estado = Estado;

            negasi.ModificarAsiento(asi);
            gvAsientos.EditIndex = -1;
            CargarTablaConFiltro();
        }

        protected void gvAsientos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvAsientos.EditIndex = e.NewEditIndex;
            CargarTablaConFiltro();
        }

        protected void gvAsientos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvAsientos.EditIndex = -1;
            CargarTablaSinFiltro();
        }
    }
}