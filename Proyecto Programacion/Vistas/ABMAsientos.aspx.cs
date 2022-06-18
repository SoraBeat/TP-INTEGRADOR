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
            }
            gvAsientos.DataSource = tablaAsientos;
            gvAsientos.DataBind();
            lblResultado.Text = "";
            lblResultadoGuardar.Text = "";
        }
        private void CargarGrid()
        {
            ListItem item;
            item = new ListItem("IDASIENTO");
            ddlFiltro.Items.Add(item);
            item = new ListItem("IDSALA");
            ddlFiltro.Items.Add(item);
            item = new ListItem("IDCOMPLEJO");
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
            CargarTablaConFiltro();
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                string IDAsiento = txtIDAsiento.Text;
                string IDSala = txtIDSala.Text;
                string IDComplejo = txtIDComplejo.Text;

                Asientos asi = new Asientos();
                asi.IDAsiento = IDAsiento;
                asi.IDSala = IDSala;
                asi.IDComplejo = IDComplejo;

                bool res = negasi.AgregarAsiento(asi);
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
                gvAsientos.EditIndex = -1;
                txtIDAsiento.Text = "";
                txtIDSala.Text = "";
                txtIDComplejo.Text = "";
                CargarTablaSinFiltro();
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
    }
}