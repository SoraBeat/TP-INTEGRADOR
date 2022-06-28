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
        NegocioPeliculas Pel = new NegocioPeliculas();
        NegocioComplejos Com = new NegocioComplejos();
        NegocioFunciones Fun = new NegocioFunciones();
        NegocioAsientos Asi = new NegocioAsientos();
        NegocioAsientosComprados AsiC = new NegocioAsientosComprados();
        private static string IDfuncion;
        private static string IDpelicula;
        private static string IDcomplejo;
        private static string IDIOMA;
        private static string FORMATO;
        private static string FECHA;
        private static string HORARIO;
        private static string Costo;
        private static int AsientosDisponibles;
        private static bool[] seleccionarAsientos;
        private static int cantidadDeAsientosSeleccionados;
        private static bool recargarPagina = false;
        private static string seleccionAnterior;


        public static string idPelicula { get => IDpelicula; set => IDpelicula = value; }
        public static string idcomplejo { get => IDcomplejo; set => IDcomplejo = value; }
        public static string idioma { get => IDIOMA; set => IDIOMA = value; }
        public static string formato { get => FORMATO; set => FORMATO = value; }
        public static string fecha { get => FECHA; set => FECHA = value; }
        public static string horario { get => HORARIO; set => HORARIO = value; }
        public static string IDfuncion1 { get => IDfuncion; set => IDfuncion = value; }
        public static string Costo1 { get => Costo; set => Costo = value; }
        public static int AsientosDisponibles1 { get => AsientosDisponibles; set => AsientosDisponibles = value; }
        public static bool[] SeleccionarAsientos { get => seleccionarAsientos; set => seleccionarAsientos = value; }
        public static int CantidadDeAsientosSeleccionados { get => cantidadDeAsientosSeleccionados; set => cantidadDeAsientosSeleccionados = value; }
        public static bool RecargarPagina { get => recargarPagina; set => recargarPagina = value; }
        public static string SeleccionAnterior { get => seleccionAnterior; set => seleccionAnterior = value; }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack == false)
            {
                
                seleccionAnterior = "1";
                lvAsientos.Visible = false;
                IDfuncion1 = Request.QueryString["ID"];
                if (Request.QueryString["cant"] != null && Request.QueryString["cant"] != "")
                {
                    seleccionAnterior = Request.QueryString["cant"];
                }

                DataTable tabla = Fun.getTablaPorFuncionid(IDfuncion1);
                CargarDatosPagina();
                cargarListView();
                CargarAsientosDisponibles();
                seleccionarAsientos = new bool[lvAsientos.Items.Count];
                cantidadDeAsientosSeleccionados = 0;






                /*lblNombrePelicula.Text = "Doctor Strange en el multiverso de la locura";
                lblFechayhora.Text = "2022-06-22";
                lblDireccion.Text = "Hipolito Yrigoyen 213";
                ImageButton1.ImageUrl = "~/Imagenes/Portadas/Doctor Strange.jpg";
                */
                //ll.Text = Request.QueryString["ID"];
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
        public void secargaLosBotones(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            chequearBoton2(boton, boton.CommandName, boton.CommandArgument);
        }
        private void CargarAsientosDisponibles()
        {
            DataTable tabla = Asi.getListaAsientosDisponibles(IDfuncion);
            DataRow fila = tabla.Rows[0];
            AsientosDisponibles1 = (int)fila["AsientosDisponibles"];
            RV_CANTIDAD.MaximumValue = AsientosDisponibles1.ToString();
        }
        public void chequearBoton(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "chequear")
            {
                DataTable existeAsiento = AsiC.getTablaExisteAsiento(e.CommandArgument.ToString(), IDfuncion1);
                DataRow asientos = existeAsiento.Rows[0];
                bool existe = Convert.ToBoolean(asientos["EXISTE"]);
                Button button = (Button)sender;
                if (existe == true)
                {
                    button.Enabled = false;
                    button.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    if (seleccionarAsientos[Convert.ToInt32(e.CommandArgument) - 1] == true)
                    {
                        seleccionarAsientos[Convert.ToInt32(e.CommandArgument) - 1] = false;
                        button.ForeColor = System.Drawing.Color.Black;
                    }
                    else
                    {
                        int asientosSeleccionados = 0;
                        for (int i = 0; i < seleccionarAsientos.Length - 1; i++)
                        {
                            if (seleccionarAsientos[i] == true)
                            {
                                asientosSeleccionados++;
                            }
                        }
                        if (asientosSeleccionados < Convert.ToInt32(txtCantidad.Text))
                        {
                            seleccionarAsientos[Convert.ToInt32(e.CommandArgument) - 1] = true;
                            button.ForeColor = System.Drawing.Color.Green;
                        }
                    }
                }
            }
        }
        public void chequearBoton2(Button sender, string CommandName, string CommandArgument)
        {
            if (CommandName == "chequear")
            {
                DataTable existeAsiento = AsiC.getTablaExisteAsiento(CommandArgument, IDfuncion1);
                DataRow asientos = existeAsiento.Rows[0];
                bool existe = Convert.ToBoolean(asientos["EXISTE"]);
                Button button = (Button)sender;
                if (existe == true)
                {
                    button.Enabled = false;
                    button.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
        public void desloguear(object sender, EventArgs e)
        {
            Session["DATOSUSUARIO"] = null;
            Response.Redirect("PantallaInicial.aspx");
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        protected void txtPaginaAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaAdmin.aspx");
        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (Session["DATOSUSUARIO"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                Session["DATOSUSUARIO"] = null;
                Response.Redirect("PantallaInicial.aspx");

            }
        }

        private void nombrebtn()
        {
            if (Session["DATOSUSUARIO"] == null)
            {
                btnIniciarSesion.Text = "Iniciar Sesion";
                btnIniciarSesion.CssClass = "btn btn-primary";
            }
            else
            {
                btnIniciarSesion.CssClass = "btn btn-danger";
                btnIniciarSesion.Text = "Cerrar Sesion";
            }
        }

        public void CargarDatosPagina()
        {
            DataTable tabla = Fun.getTablaPorFuncionid(IDfuncion);
            DataRow row = tabla.Rows[0];
            idPelicula = Convert.ToString(row["IDPELICULA"]);
            CargarDatosPelicula();

            idcomplejo = Convert.ToString(row["IDCOMPLEJO"]);
            CargarDDLcomplejo();

            lblFechayhora.Text = "FECHA : " + Convert.ToString(row["FECHA"]) + " Horario " + Convert.ToString(row["HORARIO"]);

            lblIdioma.Text = Convert.ToString(row["IDIOMA"]);
            lblCosto.Text = Convert.ToString(row["PRECIO"]);
            if (seleccionAnterior != null && seleccionAnterior != "")
            {
                txtCantidad.Text = seleccionAnterior;
                lvAsientos.Visible = true;
                lblTotal.Text = (Convert.ToInt32(txtCantidad.Text) * Convert.ToInt32(row["PRECIO"])).ToString();
            }
            else
            {
                lvAsientos.Visible = false;
            }
        }

        public void CargarDatosPelicula()
        {
            DataTable tabla = Pel.getListaPeliculasPorID(idPelicula);
            DataRow row = tabla.Rows[0];
            lblNombrePelicula.Text = Convert.ToString(row["Titulo"]).ToUpper();

            ImageButton1.ImageUrl = Convert.ToString(row["Portada"]);
        }

        private void CargarDDLcomplejo()
        {
            DataTable tabla = Com.getListaComplejosPorID(idcomplejo);
            DataRow row = tabla.Rows[0];

            lblComplejo.Text = "Complejo  :" + Convert.ToString(row["NOMBRE"]);
            lblDireccion.Text = "Direccion :" + Convert.ToString(row["DIRECCION"]);
        }

        protected void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (recargarPagina == false)
            {
                if (IsValid)
                {
                    recargarPagina = true;
                    DataTable tabla = Fun.getTablaPorFuncionid(IDfuncion);
                    DataRow row = tabla.Rows[0];
                    lblTotal.Text = (Convert.ToInt32(txtCantidad.Text) * Convert.ToInt32(row["PRECIO"])).ToString();
                    seleccionarAsientos = new bool[lvAsientos.Items.Count];
                    cantidadDeAsientosSeleccionados = 0;
                    Response.Redirect("ConfirmarCompra.aspx?id=" + IDfuncion1 + "&cant=" + txtCantidad.Text);
                }
            }
            else
            {
                recargarPagina = false;
                seleccionarAsientos = new bool[lvAsientos.Items.Count];
                cantidadDeAsientosSeleccionados = 0;
                Response.Redirect("ConfirmarCompra.aspx?id=" + IDfuncion1 + "&cant=" + txtCantidad.Text);
            }
        }

        public void validarAlIniciar(object sender, EventArgs e)
        {
            this.Validate();
        }
        private void cargarListView()
        {
            DataTable tabla = Asi.getListaAsientosPorFuncion(IDfuncion);
            lvAsientos.DataSource = tabla;
            lvAsientos.DataBind();
        }

        protected void CVCantidad_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                if (Convert.ToInt32(txtCantidad.Text)>0 && Convert.ToInt32(txtCantidad.Text) <= AsientosDisponibles1)
                {
                    lvAsientos.Visible = true;
                    args.IsValid = true;
                }
                else
                {
                    lvAsientos.Visible = false;
                    lblTotal.Text = "";
                    args.IsValid = false;
                }
            }
            catch(Exception ex)
            {
                lvAsientos.Visible = false;
                lblTotal.Text = "";
                args.IsValid = false;
            }
        }
    }

}