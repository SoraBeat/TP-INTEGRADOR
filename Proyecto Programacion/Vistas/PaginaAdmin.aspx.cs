using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Negocios;
using Entidades;


namespace Vistas
{
    public partial class PaginaAdmin : System.Web.UI.Page
    {
        NegocioVentas Ven = new NegocioVentas();

        private string NombreDePeliculas;
        private string VecesVista;
        private static string FechaG;
        private static string Total = "";
        public string NOMBREDEPELICULAS { get { return NombreDePeliculas; } }
        public string VECESVISTA { get { return VecesVista; } }


        public static string Total1 { get => Total; set => Total = value; }
        public static string FechaG2 { get => FechaG; set => FechaG = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            LBL_VENTAS.ForeColor = System.Drawing.Color.White;
            LBL_DINERO.ForeColor = System.Drawing.Color.White;
            string datosUsuario = (string)Session["DATOSUSUARIO"];
            string[] separador = new string[] { " ", "$" };
            string[] datos = datosUsuario.Split(separador, StringSplitOptions.RemoveEmptyEntries);
            LBL_NOMBREUSUARIO.Text = datos[1];
            LBL_APELLIDOUSUARIO.Text = datos[2];
            LBL_ID.Text = datos[0];
            LBL_NOMBRE.Text = datos[1];
            LBL_APELLIDO.Text = datos[2];
            LBL_DNI.Text = datos[3];
            LBL_TELEFONO.Text = datos[4];
            LBL_EMAIL.Text = datos[5];

            NegocioUsuario negusu = new NegocioUsuario();
            NegocioVentas negven = new NegocioVentas();
            NegocioPeliculas negpe = new NegocioPeliculas();
            DataTable usuarios = negusu.cantidadUsuarios();
            DataTable ventas = negven.cantidadVentas();
            DataTable dinero = negven.dineroGanado();
            LBL_USUARIOS.Text = usuarios.Rows[0]["CANTIDAD"].ToString();
            LBL_VENTAS.Text = ventas.Rows[0]["CANTIDAD"].ToString();
            LBL_DINERO.Text = "$" + dinero.Rows[0]["TOTAL"].ToString();


            DataTable datospeliculas = negpe.getListaVentas();
            foreach (DataRow columna in datospeliculas.Rows)
            {
                NombreDePeliculas += "$" + columna["PELICULAS"];
                VecesVista += "$" + columna["VENTAS"];
            }
        }
        public void desloguear(object sender, EventArgs e)
        {
            Session["DATOSUSUARIO"] = null;
            Response.Redirect("PantallaInicial.aspx");
        }



        public void FiltroFecha()
        {
            LBL_VENTAS.ForeColor = System.Drawing.Color.White;
            LBL_DINERO.ForeColor = System.Drawing.Color.White;
            DataTable resultado = Ven.getListaFechas(CLD1.SelectedDate.ToString(), CLD2.SelectedDate.ToString());
            if (resultado.Rows[0]["TOTAL"].ToString() != "0" && resultado.Rows[0]["CANTIDAD_VENTA"].ToString() != "0")
            {
                LBL_DINERO.Text = resultado.Rows[0]["TOTAL"].ToString();
                LBL_VENTAS.Text = resultado.Rows[0]["CANTIDAD_VENTA"].ToString();
            }
            else
            {
                LBL_DINERO.Text = "$0";
                LBL_VENTAS.Text = "0";
            }

        }

        protected void CLD1_SelectionChanged(object sender, EventArgs e)
        {

            if (CLD1.SelectedDate.ToString() != "01/01/0001 0:00:00" && CLD2.SelectedDate.ToString() != "01/01/0001 0:00:00")
            {
                FiltroFecha();

            }
            else
            {
                LBL_VENTAS.ForeColor = System.Drawing.Color.Red;
                LBL_DINERO.ForeColor = System.Drawing.Color.Red;
                LBL_VENTAS.Text = "FALTA FECHA";
                LBL_DINERO.Text = "FALTA FECHA";

            }

        }

        protected void CLD2_SelectionChanged(object sender, EventArgs e)
        {
            if (CLD1.SelectedDate.ToString() != "01/01/0001 0:00:00" && CLD2.SelectedDate.ToString() != "01/01/0001 0:00:00")
            {
                FiltroFecha();
            }
            else
            {
                LBL_VENTAS.ForeColor = System.Drawing.Color.Red;
                LBL_DINERO.ForeColor = System.Drawing.Color.Red;
                LBL_VENTAS.Text = "FALTA FECHA";
                LBL_DINERO.Text = "FALTA FECHA";

            }
        }

        protected void BTNBorrarFiltro_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaAdmin.aspx");
        }
    }
}