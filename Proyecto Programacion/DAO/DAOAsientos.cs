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
    public class DAOAsientos
    {
        AccesoDatos ds = new AccesoDatos();
        public Boolean ExisteAsiento(Asientos asi)
        {
            string consulta = "SELECT * FROM Asientos WHERE ID_Asiento_A = '" + asi.IDAsiento + "'";
            return ds.Existe(consulta);
        }
        public Asientos getAsiento(Asientos asi)
        {
            DataTable tabla = ds.ObtenerTabla("Asientos", "SELECT * FROM Asientos WHERE ID_Asiento_A=" + asi.IDAsiento);
            asi.IDAsiento = (tabla.Rows[0][0].ToString());
            asi.IDSala = (tabla.Rows[0][1].ToString());
            asi.IDComplejo = (tabla.Rows[0][2].ToString());
            return asi;
        }
        public DataTable getTablaAsientos()
        {
            DataTable tabla = ds.ObtenerTabla("Asientos", "SELECT ID_Asiento_A AS [IDASIENTO], ID_Sala_A AS [IDSALA], ID_Complejo_A AS [IDCOMPLEJO], Estado_A AS [ESTADO] FROM Asientos ORDER BY ABS(ID_Asiento_A)");
            return tabla;
        }
        public DataTable getTablaAsientosPorID(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Asientos", "SELECT ID_Asiento_A AS [IDASIENTO], ID_Sala_A AS [IDSALA], ID_Complejo_A AS [IDCOMPLEJO], Estado_A AS [ESTADO] FROM Asientos WHERE ID_Asiento_A LIKE '%" + campo + "%' ORDER BY ABS(ID_Asiento_A)");
            return tabla;
        }
        public DataTable getTablaAsientosPorIDSala(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Asientos", "SELECT ID_Asiento_A AS [IDASIENTO], ID_Sala_A AS [IDSALA], ID_Complejo_A AS [IDCOMPLEJO], Estado_A AS [ESTADO] FROM Asientos WHERE ID_Sala_A LIKE '%" + campo + "%' ORDER BY ABS(ID_Asiento_A)");
            return tabla;
        }
        public DataTable getTablaAsientosPorIDComplejo(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Asientos", "SELECT ID_Asiento_A AS [IDASIENTO], ID_Sala_A AS [IDSALA], ID_Complejo_A AS [IDCOMPLEJO], Estado_A AS [ESTADO] FROM Asientos WHERE ID_Complejo_A LIKE '%" + campo + "%' ORDER BY ABS(ID_Asiento_A)");
            return tabla;
        }
        public DataTable getTablaAsientosPorEstado(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Asientos", "SELECT ID_Asiento_A AS [IDASIENTO], ID_Sala_A AS [IDSALA], ID_Complejo_A AS [IDCOMPLEJO], Estado_A AS [ESTADO] FROM Asientos WHERE Estado_A LIKE '%" + campo + "%' ORDER BY ABS(ID_Asiento_A)");
            return tabla;
        }
        public DataTable getTablaAsientosPorFuncion(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Asientos", "SELECT id_Asiento_A FROM Asientos INNER JOIN salas ON Asientos.ID_Sala_A = Salas.ID_Sala_S AND Asientos.ID_Complejo_A = Salas.ID_Complejo_S INNER JOIN Funciones ON salas.ID_Sala_S = Funciones.ID_Sala_F AND Salas.ID_Complejo_S = Funciones.ID_Complejo_F WHERE ID_Funcion_F ='" + campo + "' AND Estado_A = '1'");
            return tabla;
        }
        public DataTable getTablaAsientosDisponibles(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Asientos", "Declare @asientosComprados INT = (SELECT count (ID_Asiento_AC) FROM AsientosComprados WHERE ID_Funcion_AC ='" + campo + "') Declare @AsientosTotales INT = (SELECT  Total_Asientos_S FROM Salas INNER JOIN Funciones ON Salas.ID_Sala_S = Funciones.ID_Sala_F AND Salas.ID_Complejo_S = Funciones.ID_Complejo_F WHERE ID_Funcion_F = '" + campo + "') Select SUM(@AsientosTotales - @asientosComprados) AS [AsientosDisponibles]"
);
            return tabla;
        }
        public int EliminarAsiento(Asientos asi)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosAsientoEliminar(ref comando, asi);
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_EliminarAsiento");
        }
        public int AgregarAsiento(Asientos asi)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosAsientoAgregar(ref comando, asi);
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_AgregarAsiento");
        }
        public int ModificarAsiento(Asientos asi)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosAsientoAgregar(ref comando, asi);
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_ModificarAsiento");
        }
        private void ArmarParametrosAsientoEliminar(ref SqlCommand comando, Asientos asi)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDASIENTO", SqlDbType.Char);
            SqlParametros.Value = asi.IDAsiento;
            SqlParametros = comando.Parameters.Add("@IDSALA", SqlDbType.Char);
            SqlParametros.Value = asi.IDSala;
            SqlParametros = comando.Parameters.Add("@IDCOMPLEJO", SqlDbType.Char);
            SqlParametros.Value = asi.IDComplejo;
        }
        private void ArmarParametrosAsientoAgregar(ref SqlCommand comando, Asientos asi)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDASIENTO", SqlDbType.VarChar);
            SqlParametros.Value = asi.IDAsiento;
            SqlParametros = comando.Parameters.Add("@IDSALA", SqlDbType.VarChar);
            SqlParametros.Value = asi.IDSala;
            SqlParametros = comando.Parameters.Add("@IDCOMPLEJO", SqlDbType.VarChar);
            SqlParametros.Value = asi.IDComplejo;
            SqlParametros = comando.Parameters.Add("@ESTADOASIENTO", SqlDbType.Char);
            SqlParametros.Value = asi.Estado;
        }
    }
}
