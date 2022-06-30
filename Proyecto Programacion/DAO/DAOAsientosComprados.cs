using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace DAO
{
    public class DAOAsientosComprados
    {
        AccesoDatos ds = new AccesoDatos();
        public DataTable getTablaAsientosComprados()
        {
            DataTable tabla = ds.ObtenerTabla("AsientosComprados", "SELECT ID_Asiento_AC AS[ID], ID_DetalleVenta_AC AS [IDDETALLEVENTA], ID_Venta_AC AS [IDVENTA], ID_Funcion_AC AS [IDFUNCION], ID_Sala_AC AS [IDSALA], ID_Complejo_AC AS [IDCOMPLEJO], Estado_AC AS [ESTADO] FROM AsientosComprados ORDER BY ABS(ID_Asiento_AC)");
            return tabla;
        }
        public DataTable getTablaAsientosCompradosPorID(string com)
        {
            DataTable tabla = ds.ObtenerTabla("AsientosComprados", "SELECT ID_Asiento_AC AS[ID], ID_DetalleVenta_AC AS [IDDETALLEVENTA], ID_Venta_AC AS [IDVENTA], ID_Funcion_AC AS [IDFUNCION], ID_Sala_AC AS [IDSALA], ID_Complejo_AC AS [IDCOMPLEJO], Estado_AC AS [ESTADO] FROM AsientosComprados WHERE ID_Asiento_AC LIKE '"+com+"' ORDER BY ABS(ID_Asiento_AC)");
            return tabla;
        }
        public DataTable getTablaAsientosCompradosPorDetalleVenta(string com)
        {
            DataTable tabla = ds.ObtenerTabla("AsientosComprados", "SELECT ID_Asiento_AC AS[ID], ID_DetalleVenta_AC AS [IDDETALLEVENTA], ID_Venta_AC AS [IDVENTA], ID_Funcion_AC AS [IDFUNCION], ID_Sala_AC AS [IDSALA], ID_Complejo_AC AS [IDCOMPLEJO], Estado_AC AS [ESTADO] FROM AsientosComprados WHERE ID_DetalleVenta_AC LIKE '" + com + "' ORDER BY ABS(ID_DetalleVenta_AC)");
            return tabla;
        }
        public DataTable getTablaAsientosCompradosPorVenta(string com)
        {
            DataTable tabla = ds.ObtenerTabla("AsientosComprados", "SELECT ID_Asiento_AC AS[ID], ID_DetalleVenta_AC AS [IDDETALLEVENTA], ID_Venta_AC AS [IDVENTA], ID_Funcion_AC AS [IDFUNCION], ID_Sala_AC AS [IDSALA], ID_Complejo_AC AS [IDCOMPLEJO], Estado_AC AS [ESTADO] FROM AsientosComprados WHERE ID_Venta_AC LIKE '" + com + "' ORDER BY ABS(ID_Venta_AC)");
            return tabla;
        }
        public DataTable getTablaAsientosCompradosPorFuncion(string com)
        {
            DataTable tabla = ds.ObtenerTabla("AsientosComprados", "SELECT ID_Asiento_AC AS[ID], ID_DetalleVenta_AC AS [IDDETALLEVENTA], ID_Venta_AC AS [IDVENTA], ID_Funcion_AC AS [IDFUNCION], ID_Sala_AC AS [IDSALA], ID_Complejo_AC AS [IDCOMPLEJO], Estado_AC AS [ESTADO] FROM AsientosComprados WHERE ID_Funcion_AC LIKE '" + com + "' ORDER BY ABS(ID_Funcion_AC)");
            return tabla;
        }
        public DataTable getTablaAsientosCompradosPorSala(string com)
        {
            DataTable tabla = ds.ObtenerTabla("AsientosComprados", "SELECT ID_Asiento_AC AS[ID], ID_DetalleVenta_AC AS [IDDETALLEVENTA], ID_Venta_AC AS [IDVENTA], ID_Funcion_AC AS [IDFUNCION], ID_Sala_AC AS [IDSALA], ID_Complejo_AC AS [IDCOMPLEJO], Estado_AC AS [ESTADO] FROM AsientosComprados WHERE ID_Sala_AC LIKE '" + com + "' ORDER BY ABS(ID_Sala_AC)");
            return tabla;
        }
        public DataTable getTablaAsientosCompradosPorComplejo(string com)
        {
            DataTable tabla = ds.ObtenerTabla("AsientosComprados", "SELECT ID_Asiento_AC AS[ID], ID_DetalleVenta_AC AS [IDDETALLEVENTA], ID_Venta_AC AS [IDVENTA], ID_Funcion_AC AS [IDFUNCION], ID_Sala_AC AS [IDSALA], ID_Complejo_AC AS [IDCOMPLEJO], Estado_AC AS [ESTADO] FROM AsientosComprados WHERE ID_Complejo_AC LIKE '" + com + "' ORDER BY ABS(ID_Complejo_AC)");
            return tabla;
        }
        public DataTable getTablaAsientosCompradosPorEstado(string com)
        {
            DataTable tabla = ds.ObtenerTabla("AsientosComprados", "SELECT ID_Asiento_AC AS[ID], ID_DetalleVenta_AC AS [IDDETALLEVENTA], ID_Venta_AC AS [IDVENTA], ID_Funcion_AC AS [IDFUNCION], ID_Sala_AC AS [IDSALA], ID_Complejo_AC AS [IDCOMPLEJO], Estado_AC AS [ESTADO] FROM AsientosComprados WHERE Estado_AC LIKE '" + com + "' ORDER BY ABS(Estado_AC)");
            return tabla;
        }
        public DataTable getTablaExisteAsiento(string idAsiento, string idFuncion)
        {
            DataTable tabla = ds.ObtenerTabla("AsientosComprados", "IF EXISTS (SELECT Estado_AC FROM AsientosComprados WHERE ID_Asiento_AC='"+ idAsiento + "' AND ID_Funcion_AC='" + idFuncion + "') BEGIN SELECT 1 AS EXISTE; END ELSE BEGIN SELECT 0 AS EXISTE; END");
            return tabla;
        }
    }
}
