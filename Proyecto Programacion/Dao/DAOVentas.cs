using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DAOVentas
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaVentasPorIDVenta(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Ventas", "SELECT ID_Venta_V AS [IDVenta], ID_Usuario_V AS [IDUsuario], Fecha_V AS [Fecha], Metodo_Pago_V AS [MetodoPago], Monto_Final_V AS [MontoFinal] FROM Ventas WHERE ID_Venta_V LIKE '" + campo + "' ORDER BY ABS(ID_Venta_V)");
            return tabla;
        }
        public DataTable cantidadVentas()
        {
            DataTable tabla = ds.ObtenerTabla("Ventas", "SELECT COUNT(ID_Venta_V) AS [CANTIDAD] FROM Ventas");
            return tabla;
        }
        public DataTable dineroGanado()
        {
            DataTable tabla = ds.ObtenerTabla("Ventas", "SELECT SUM (Monto_Final_V) AS [TOTAL] FROM Ventas");
            return tabla;
        }


        public DataTable getTablaVentasPorIDUsuario(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Ventas", "SELECT ID_Venta_V AS [IDVenta], ID_Usuario_V AS [IDUsuario], Fecha_V AS [Fecha], Metodo_Pago_V AS [MetodoPago], Monto_Final_V AS [MontoFinal] FROM Ventas WHERE ID_Usuario_V LIKE '" + campo + "' ORDER BY ABS(ID_Venta_V)");
            return tabla;
        }
        public DataTable getTablaVentasPorFecha(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Ventas", "SELECT ID_Venta_V AS [IDVenta], ID_Usuario_V AS [IDUsuario], Fecha_V AS [Fecha], Metodo_Pago_V AS [MetodoPago], Monto_Final_V AS [MontoFinal] FROM Ventas WHERE Fecha_V LIKE '%" + campo + "%' ORDER BY ABS(ID_Venta_V)");
            return tabla;
        }
        public DataTable getTablaVentasPorMetodoDePago(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Ventas", "SELECT ID_Venta_V AS [IDVenta], ID_Usuario_V AS [IDUsuario], Fecha_V AS [Fecha], Metodo_Pago_V AS [MetodoPago], Monto_Final_V AS [MontoFinal] FROM Ventas WHERE Metodo_Pago_V LIKE '%" + campo + "%' ORDER BY ABS(ID_Venta_V)");
            return tabla;
        }
        public DataTable getTablaVentasPorMontoFinalMayorA(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Ventas", "SELECT ID_Venta_V AS [IDVenta], ID_Usuario_V AS [IDUsuario], Fecha_V AS [Fecha], Metodo_Pago_V AS [MetodoPago], Monto_Final_V AS [MontoFinal] FROM Ventas WHERE Monto_Final_V >" + campo);
            return tabla;
        }
        public DataTable getTablaVentasPorMontoFinalMenorA(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Ventas", "SELECT ID_Venta_V AS [IDVenta], ID_Usuario_V AS [IDUsuario], Fecha_V AS [Fecha], Metodo_Pago_V AS [MetodoPago], Monto_Final_V AS [MontoFinal] FROM Ventas WHERE Monto_Final_V <" + campo);
            return tabla;
        }
        public DataTable getTablaVentas()
        {
            DataTable tabla = ds.ObtenerTabla("Ventas", "SELECT ID_Venta_V AS [IDVenta], ID_Usuario_V AS [IDUsuario], Fecha_V AS [Fecha], Metodo_Pago_V AS [MetodoPago], Monto_Final_V AS [MontoFinal] FROM Ventas");
            return tabla;
        }
        public DataTable getTablaVentas2()
        {
            DataTable tabla = ds.ObtenerTabla("Ventas", "SELECT format (Fecha_V,'dd/MM/yyyy') AS [FECHA] FROM Ventas");
            return tabla;
        }
        public DataTable getTablaFecha(string Inicio, string Final)
        {
            DataTable tabla = ds.ObtenerTabla("Ventas", "SET LANGUAGE SPANISH DECLARE @INICIO Date = CAST('" + Inicio + "' as date) DECLARE @FINAL Date = CAST('" + Final + "' as date) SELECT SUM (Monto_Final_V) AS [TOTAL], COUNT (ID_Venta_V) AS [CANTIDAD_VENTA] FROM Ventas WHERE CAST(Fecha_V as date) >= @INICIO AND CAST(Fecha_V as date) <= @FINAL");
            return tabla;
        }

        public int buscarUltimaVenta()
        {
            return ds.ObtenerMaximo("select max(id_venta_v)  from ventas");
        }

        public int AgregarQR(int ID, string codigoQR)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosQRVenta(ref comando, ID, codigoQR);
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_CodigoQR");
        }
        public int AgregarVentas(Ventas ven)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosVentasAgregar(ref comando, ven);
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_AgregarVenta");
        }

        private void ArmarParametrosVentasAgregar(ref SqlCommand comando, Ventas ven)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDUSUARIO", SqlDbType.Int);
            SqlParametros.Value = ven.IDUsuario;
            SqlParametros = comando.Parameters.Add("@METODOPAGO", SqlDbType.VarChar);
            SqlParametros.Value = ven.MetodoPagoVenta;
            SqlParametros = comando.Parameters.Add("@MONTOFINAL", SqlDbType.Decimal);
            SqlParametros.Value = ven.MontoFinalVenta;
        }
        public DataTable getSuperHiperMegaConsulta(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Ventas", "SELECT DISTINCT SUBSTRING(CAST(Horario_F AS VARCHAR(5)),1,5) AS [HoraFuncion], SUBSTRING(CAST(Fecha_F AS VARCHAR(10)),1,10) AS [FechaFuncion], CodigoAlfaNumerico_V AS [AlfaNumerico] , CodigoQR_V as [QR], Formato_F AS [Formato] , ID_Venta_V AS [IDVenta],Fecha_V AS [Fecha], Metodo_Pago_V AS [MetodoPago], Monto_Final_V AS [MontoFinal], Titulo_P AS[Titulo], ID_Sala_DV AS[Sala], Cantidad_DV AS[Cantidad], dbo.GetLocacionAsientos(ID_Venta_V, ID_Usuario_V) AS[AsientosSeleccionados] FROM Ventas INNER JOIN Detalle_Ventas ON ID_Venta_V = ID_Venta_DV INNER JOIN Funciones ON ID_Funcion_F = ID_Funcion_DV INNER JOIN Peliculas ON ID_Pelicula_F = ID_Pelicula_P INNER JOIN AsientosComprados ON ID_Venta_AC = ID_Venta_DV AND ID_DetalleVenta_DV = ID_DetalleVenta_AC AND ID_Funcion_DV = ID_Funcion_AC AND ID_Sala_DV = ID_Sala_AC WHERE ID_Usuario_V = "+campo+"");
            return tabla;
        }
        private void ArmarParametrosQRVenta(ref SqlCommand comando, int id, string codigo)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDVENTA", SqlDbType.Int);
            SqlParametros.Value = id;
            SqlParametros = comando.Parameters.Add("@CODIGOALFANUMERICO", SqlDbType.VarChar);
            SqlParametros.Value = codigo;

        }
    }
}
