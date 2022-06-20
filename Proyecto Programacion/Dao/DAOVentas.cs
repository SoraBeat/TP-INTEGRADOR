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
            DataTable tabla = ds.ObtenerTabla("Ventas", "SELECT ID_Venta_V AS [IDVenta], ID_Usuario_V AS [IDUsuario], Fecha_V AS [Fecha], Metodo_Pago_V AS [MetodoPago], Monto_Final_V AS [MontoFinal] FROM Ventas WHERE ID_Venta_V LIKE '%" + campo + "%' ORDER BY ABS(ID_Venta_V)");
            return tabla;
        }
        public DataTable getTablaVentasPorIDUsuario(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Ventas", "SELECT ID_Venta_V AS [IDVenta], ID_Usuario_V AS [IDUsuario], Fecha_V AS [Fecha], Metodo_Pago_V AS [MetodoPago], Monto_Final_V AS [MontoFinal] FROM Ventas WHERE ID_Usuario_V LIKE '%" + campo + "%' ORDER BY ABS(ID_Venta_V)");
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
            DataTable tabla = ds.ObtenerTabla("Ventas", "SELECT ID_Venta_V AS [IDVenta], ID_Usuario_V AS [IDUsuario], Fecha_V AS [Fecha], Metodo_Pago_V AS [MetodoPago], Monto_Final_V AS [MontoFinal] FROM Ventas WHERE Monto_Final_V >=" + campo);
            return tabla;
        }
        public DataTable getTablaVentasPorMontoFinalMenorA(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Ventas", "SELECT ID_Venta_V AS [IDVenta], ID_Usuario_V AS [IDUsuario], Fecha_V AS [Fecha], Metodo_Pago_V AS [MetodoPago], Monto_Final_V AS [MontoFinal] FROM Ventas WHERE Monto_Final_V <=" + campo);
            return tabla;
        }
        public DataTable getTablaVentas()
        {
            DataTable tabla = ds.ObtenerTabla("Ventas", "SELECT ID_Venta_V AS [IDVenta], ID_Usuario_V AS [IDUsuario], Fecha_V AS [Fecha], Metodo_Pago_V AS [MetodoPago], Monto_Final_V AS [MontoFinal] FROM Ventas");
            return tabla;
        }
        public int buscarProximaVenta()
        {

          return  ds.ObtenerMaximo("select max(id_venta_v)  from ventas");
        }
    }
}
