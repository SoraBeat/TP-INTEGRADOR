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
        private static string numeroAsientos;


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
        public static string NumeroAsientos { get => numeroAsientos; set => numeroAsientos = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            CabezeraUsuario();
            if (IsPostBack == false)
            {
                Label1.Text = fecha;
                nombrebtn();
                btnIrPaginaAdmin();
                btnConfirmar.CssClass = "btn btn-warning";
                seleccionAnterior = "1";
                lvAsientos.Visible = false;
                IDfuncion1 = Request.QueryString["ID"];
                if (Request.QueryString["cant"] != null && Request.QueryString["cant"] != "")
                {
                    seleccionAnterior = Request.QueryString["cant"];
                }

                CargarDatosPagina();
                cargarListView();
                CargarAsientosDisponibles();
                seleccionarAsientos = new bool[lvAsientos.Items.Count];
                cantidadDeAsientosSeleccionados = 0;
            }
        }
        public void CabezeraUsuario()
        {
            if (Session["DATOSUSUARIO"] != null)
            {
                ContenedorUsuario.Visible = true;
                string datosUsuario = (string)Session["DATOSUSUARIO"];
                string[] separador = new string[] { " ", "$" };
                string[] datos = datosUsuario.Split(separador, StringSplitOptions.RemoveEmptyEntries);
                ContenedorNombre.Text = datos[1];
            }
            else
            {
                ContenedorUsuario.Visible = false;
            }
        }
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
                    button.CssClass = "asiento-ocupado";
                }
                else
                {
                    if (seleccionarAsientos[Convert.ToInt32(e.CommandArgument) - 1] == true)
                    {
                        button.Enabled = true;
                        button.CssClass = "asiento-libre";
                        btnConfirmar.CssClass = "btn btn-warning";
                        seleccionarAsientos[Convert.ToInt32(e.CommandArgument) - 1] = false;
                    }
                    else
                    {
                        int asientosSeleccionados = 0;
                        for (int i = 0; i < seleccionarAsientos.Length ; i++)
                        {
                            if (seleccionarAsientos[i] == true)
                            {
                                asientosSeleccionados++;
                            }
                        }
                        if (asientosSeleccionados < Convert.ToInt32(txtCantidad.Text))
                        {
                            seleccionarAsientos[Convert.ToInt32(e.CommandArgument) - 1] = true;
                            button.Enabled = true;
                            button.CssClass = "asiento-seleccionado";
                            if (asientosSeleccionados + 1 == Convert.ToInt32(txtCantidad.Text))
                            {
                                btnConfirmar.CssClass = "btn btn-success";
                            }
                        }
                        else
                        {
                            btnConfirmar.CssClass = "btn btn-success";
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
                    button.CssClass = "asiento-ocupado";
                }
            }
        }
        public void desloguear(object sender, EventArgs e)
        {
            Session["DATOSUSUARIO"] = null;
            Response.Redirect("PantallaInicial.aspx");
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MostrarPelicula.aspx?ID="+idPelicula);
        }
        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (btnConfirmar.CssClass == "btn btn-success")
            {
                
                NegocioVentas negVen = new NegocioVentas();
                NegocioDetalleVentas negDV = new NegocioDetalleVentas();
                DataTable tabla = Fun.getTablaPorFuncionid(IDfuncion);
                DataRow row = tabla.Rows[0];
                DataTable sala = Fun.getTablaSalaPorID(IDfuncion);
                DataRow sala2 = sala.Rows[0];
                string idSala = Convert.ToInt32(sala2["IDSALA"]).ToString();
                string subtotal = (Convert.ToInt32(txtCantidad.Text) * Convert.ToInt32(row["PRECIO"])).ToString();
                string precio = Convert.ToInt32(row["PRECIO"]).ToString();
                string fecha = Convert.ToString(row["FECHA"]).Substring(0, 10);
                string hora = Convert.ToString(row["HORARIO"]).Substring(0, 5);
                string IDfun = Convert.ToInt32(row["ID"]).ToString();
                string IDComplejo = Convert.ToInt32(row["IDCOMPLEJO"]).ToString();
                asientosSeleccionados();
                string asientos = txtCantidad.Text + " x TICKETS ($"+ precio +" Asientos:" + numeroAsientos + ")";

                bool res = AgregarVenta(traerIDUsuario(), fecha + " " + hora, ddlMetodoPago.SelectedValue, Convert.ToInt32(subtotal));
                if (res == true)
                {
                    int IDVenta = negVen.buscarUltimaVenta();
                    bool res2 = AgregarDetalleDeVentas(IDVenta, IDfun, idSala, IDComplejo, Convert.ToInt32(txtCantidad.Text), float.Parse(precio));
                }
                Session["DATOSTICKET"] = IDfuncion1 + "$" + idPelicula + "$" + idcomplejo + "$" + idioma + "$" + formato + "$" + fecha + "$" + horario + "$" + subtotal + "$" + idSala;
                Response.Redirect("Precompra.aspx?subtotal=" + subtotal + "&idSala=" + idSala + "&asientos=" + asientos + "&cantidadAsientos=" + numeroAsientos);
            }
        }

        public void asientosSeleccionados()
        {
            bool bandera=false;
            numeroAsientos = "";
            for (int i = 0; i < seleccionarAsientos.Length; i++)
            {
                if (seleccionarAsientos[i] == true)
                {
                    if (bandera == true)
                    {
                        numeroAsientos += "-";
                        bandera = false;
                    }
                    numeroAsientos += Convert.ToString(i+1);
                    bandera = true;
                }
            }
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
        private void btnIrPaginaAdmin()
        {
            if (Session["DATOSUSUARIO"] != null)
            {
                string datosUsuario = (string)Session["DATOSUSUARIO"];
                string[] separador = new string[] { " ", "$" };
                string[] datos = datosUsuario.Split(separador, StringSplitOptions.RemoveEmptyEntries);
                bool TipoUsuario = Convert.ToBoolean(datos[7]);
                if (TipoUsuario == true)
                {
                    txtPaginaAdmin.Visible = true;
                }
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
            string fecha = Convert.ToString(row["FECHA"]).Substring(0,10);
            string hora = Convert.ToString(row["HORARIO"]).Substring(0,5);
            lblFechayhora.Text = fecha + " " +hora ;

            lblIdioma.Text = Convert.ToString(row["IDIOMA"]);
            lblCosto.Text = "$"+Convert.ToString(row["PRECIO"]);
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
            lblNombrePelicula.Text = Convert.ToString(row["Titulo"]);
            LBLtitulo.Text = Convert.ToString(row["Titulo"]).ToUpper();
            ImagenPortada.ImageUrl = Convert.ToString(row["Portada"]);
        }

        private void CargarDDLcomplejo()
        {
            DataTable tabla = Com.getListaComplejosPorID(idcomplejo);
            DataRow row = tabla.Rows[0];

            lblComplejo.Text =  Convert.ToString(row["NOMBRE"]);
            lblDireccion.Text = Convert.ToString(row["DIRECCION"]);
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
                    if (txtCantidad.Text != "")
                    {
                        lblTotal.Text = (Convert.ToInt32(txtCantidad.Text) * Convert.ToInt32(row["PRECIO"])).ToString();
                    }
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

        private bool AgregarVenta( int idUsuario, String Fecha, String MetodoPago, int MontoFinal)
        {

            Entidades.Ventas ven = new Entidades.Ventas();
            NegocioVentas negVen = new NegocioVentas();
            ven.IDUsuario = idUsuario;
            ven.FechaVenta = Fecha;
            ven.MetodoPagoVenta = MetodoPago;
            ven.MontoFinalVenta = MontoFinal;
            bool res = negVen.AgregarVenta(ven);
            return res;   
        }

        private bool AgregarDetalleDeVentas(int idVenta, String idFuncion, String idSala, String idComplejo, int cantidad, float precio)
        {

            DetalleVentas dv = new DetalleVentas();
            NegocioDetalleVentas negDV = new NegocioDetalleVentas();
            dv.IDVenta = idVenta;
            dv.IDFuncion = idFuncion;
            dv.IDSala = idSala;
            dv.IDComplejo = idComplejo;
            dv.Cantidad = cantidad;
            dv.Precio = precio;
            bool res = negDV.AgregarDetalleDeVentas(dv);
            return res;
        }

        private int traerIDUsuario()
        {
            string datosUsuario = (string)Session["DATOSUSUARIO"];
            string[] separador = new string[] { " ", "$" };
            string[] datos = datosUsuario.Split(separador, StringSplitOptions.RemoveEmptyEntries);
            return Convert.ToInt32(datos[0]);  
        }
    }

}