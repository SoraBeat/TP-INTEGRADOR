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
            DataTable tabla = ds.ObtenerTabla("Asientos", "SELECT ID_Asiento_A AS [ID ASIENTO], ID_Sala_A AS [ID SALA], ID_Complejo_A AS [ID COMPLEJO] FROM Asientos ORDER BY ABS(ID_Asiento_A)");
            return tabla;
        }
        public DataTable getTablaAsientosPorID(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Asientos", "SELECT ID_Asiento_A AS [ID ASIENTO], ID_Sala_A AS [ID SALA], ID_Complejo_A AS [ID COMPLEJO] FROM Asientos WHERE ID_Asiento_A LIKE '%" + campo + "%' ORDER BY ABS(ID_Asiento_A)");
            return tabla;
        }
        public DataTable getTablaAsientosPorIDSala(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Asientos", "SELECT ID_Asiento_A AS [ID ASIENTO], ID_Sala_A AS [ID SALA], ID_Complejo_A AS [ID COMPLEJO] FROM Asientos WHERE ID_Sala_A LIKE '%" + campo + "%' ORDER BY ABS(ID_Asiento_A)");
            return tabla;
        }
        public DataTable getTablaAsientosPorIDComplejo(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Asientos", "SELECT ID_Asiento_A AS [ID ASIENTO], ID_Sala_A AS [ID SALA], ID_Complejo_A AS [ID COMPLEJO] FROM Asientos WHERE ID_Complejo_A LIKE '%" + campo + "%' ORDER BY ABS(ID_Asiento_A)");
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
        private void ArmarParametrosAsientoEliminar(ref SqlCommand comando, Asientos asi)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDASIENTO", SqlDbType.Char);
            SqlParametros.Value = asi.IDAsiento;
            SqlParametros = comando.Parameters.Add("@IDSALA", SqlDbType.Char);
            SqlParametros.Value = asi.IDAsiento;
            SqlParametros = comando.Parameters.Add("@IDCOMPLEJO", SqlDbType.Char);
            SqlParametros.Value = asi.IDAsiento;
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
        }
    }
}
