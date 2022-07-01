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
    public class DAODetalleVentas
    {
        AccesoDatos ds = new AccesoDatos();
        public DataTable getTablaDetalleVentasPorIDDetalleVenta(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Detalle_Ventas", "SELECT ID_DetalleVenta_DV AS [IDDetalleVenta], ID_Venta_DV AS [IDVenta], ID_Funcion_DV AS [IDFuncion], ID_SALA_DV AS [IDSala], ID_Complejo_DV AS [IDComplejo], Cantidad_DV AS [Cantidad], Precio_DV AS [Precio] FROM Detalle_Ventas WHERE ID_DetalleVenta_DV LIKE '" + campo + "' ORDER BY ABS(ID_DetalleVenta_DV)");
            return tabla;
        }
        public DataTable getTablaDetalleVentasPorIDVenta(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Detalle_Ventas", "SELECT ID_DetalleVenta_DV AS [IDDetalleVenta], ID_Venta_DV AS [IDVenta], ID_Funcion_DV AS [IDFuncion], ID_SALA_DV AS [IDSala], ID_Complejo_DV AS [IDComplejo], Cantidad_DV AS [Cantidad], Precio_DV AS [Precio] FROM Detalle_Ventas WHERE ID_Venta_DV LIKE '" + campo + "' ORDER BY ABS(ID_DetalleVenta_DV)");
            return tabla;
        }
        public DataTable getTablaDetalleVentasPorIDFuncion(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Detalle_Ventas", "SELECT ID_DetalleVenta_DV AS [IDDetalleVenta], ID_Venta_DV AS [IDVenta], ID_Funcion_DV AS [IDFuncion], ID_SALA_DV AS [IDSala], ID_Complejo_DV AS [IDComplejo], Cantidad_DV AS [Cantidad], Precio_DV AS [Precio] FROM Detalle_Ventas WHERE ID_Funcion_DV LIKE '" + campo + "' ORDER BY ABS(ID_DetalleVenta_DV)");
            return tabla;
        }
        public DataTable getTablaDetalleVentasPorIDSala(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Detalle_Ventas", "SELECT ID_DetalleVenta_DV AS [IDDetalleVenta], ID_Venta_DV AS [IDVenta], ID_Funcion_DV AS [IDFuncion], ID_SALA_DV AS [IDSala], ID_Complejo_DV AS [IDComplejo], Cantidad_DV AS [Cantidad], Precio_DV AS [Precio] FROM Detalle_Ventas WHERE ID_Sala_DV LIKE '" + campo + "' ORDER BY ABS(ID_DetalleVenta_DV)");
            return tabla;
        }
        public DataTable getTablaVentasPorIDComplejo(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Detalle_Ventas", "SELECT ID_DetalleVenta_DV AS [IDDetalleVenta], ID_Venta_DV AS [IDVenta], ID_Funcion_DV AS [IDFuncion], ID_SALA_DV AS [IDSala], ID_Complejo_DV AS [IDComplejo], Cantidad_DV AS [Cantidad], Precio_DV AS [Precio] FROM Detalle_Ventas WHERE ID_Complejo_DV LIKE '" + campo + "' ORDER BY ABS(ID_DetalleVenta_DV)");
            return tabla;
        }
        public DataTable getTablaDetalleVentasPorCantidad(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Detalle_Ventas", "SELECT ID_DetalleVenta_DV AS [IDDetalleVenta], ID_Venta_DV AS [IDVenta], ID_Funcion_DV AS [IDFuncion], ID_SALA_DV AS [IDSala], ID_Complejo_DV AS [IDComplejo], Cantidad_DV AS [Cantidad], Precio_DV AS [Precio] FROM Detalle_Ventas WHERE Cantidad_DV LIKE '" + campo + "' ORDER BY ABS(ID_DetalleVenta_DV)");
            return tabla;
        }
        public DataTable getTablaDetalleVentasPorPrecio(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Detalle_Ventas", "SELECT ID_DetalleVenta_DV AS [IDDetalleVenta], ID_Venta_DV AS [IDVenta], ID_Funcion_DV AS [IDFuncion], ID_SALA_DV AS [IDSala], ID_Complejo_DV AS [IDComplejo], Cantidad_DV AS [Cantidad], Precio_DV AS [Precio] FROM Detalle_Ventas WHERE Precio_DV LIKE '%" + campo + "%' ORDER BY ABS(ID_DetalleVenta_DV)");
            return tabla;
        }
        public DataTable getTablaDetalleVentas()
        {
            DataTable tabla = ds.ObtenerTabla("Detalle_Ventas", "SELECT ID_DetalleVenta_DV AS [IDDetalleVenta], ID_Venta_DV AS [IDVenta], ID_Funcion_DV AS [IDFuncion], ID_SALA_DV AS [IDSala], ID_Complejo_DV AS [IDComplejo], Cantidad_DV AS [Cantidad], Precio_DV AS [Precio] FROM Detalle_Ventas");
            return tabla;
        }
        public int buscarUltimoIDDetalleVentas()
        {
            return ds.ObtenerMaximo("SELECT MAX(ID_DetalleVenta_DV) FROM Detalle_Ventas");
        }
        public int AgregarDetalleVentas(DetalleVentas ven)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosDetalleventaAgregar(ref comando, ven);
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_AgrergarDetalleVentas");

        }

        private void ArmarParametrosDetalleventaAgregar(ref SqlCommand comando, DetalleVentas ven)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDVENTA", SqlDbType.VarChar);
            SqlParametros.Value = ven.IDVenta;
            SqlParametros = comando.Parameters.Add("@IDFUNCION", SqlDbType.VarChar);
            SqlParametros.Value = ven.IDFuncion;
            SqlParametros = comando.Parameters.Add("@IDSALA", SqlDbType.VarChar);
            SqlParametros.Value = ven.IDSala;
            SqlParametros = comando.Parameters.Add("@IDCOMPLEJO", SqlDbType.VarChar);
            SqlParametros.Value = ven.IDComplejo;
            SqlParametros = comando.Parameters.Add("@CANTIDAD", SqlDbType.Char);
            SqlParametros.Value = ven.Cantidad;
            SqlParametros = comando.Parameters.Add("@PRECIO", SqlDbType.Char);
            SqlParametros.Value = ven.Precio;

        }
    }
}
