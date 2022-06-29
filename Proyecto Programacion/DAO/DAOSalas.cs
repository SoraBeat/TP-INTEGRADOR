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
    public class DAOSalas
    {
        AccesoDatos ds = new AccesoDatos();
        public Boolean ExisteSala(Salas sala)
        {
            string consulta = "SELECT * FROM Salas WHERE ID_Sala_S = '" + sala.IDSala + "' AND ID_Complejo_S = '"+sala.IDComplejo+"'";
            return ds.Existe(consulta);
        }
        public Salas getSala(Salas sala)
        {
            DataTable tabla = ds.ObtenerTabla("Salas", "SELECT * FROM Salas WHERE ID_Sala_S=" + sala.IDSala);
            sala.IDSala = (tabla.Rows[0][0].ToString());
            sala.IDComplejo = (tabla.Rows[0][0].ToString());
            sala.TotalAsientos = Convert.ToInt32((tabla.Rows[0][0].ToString()));
            sala.TotalAsientos = Convert.ToInt32((tabla.Rows[0][0].ToString()));
            return sala;
        }
        public DataTable getTablaSala()
        {
            DataTable tabla = ds.ObtenerTabla("Salas", "SELECT ID_Sala_S AS [ID], ID_Complejo_S AS [COMPLEJO], Total_Asientos_S AS [ASIENTOS], Estado_S AS [ESTADO] FROM Salas ORDER BY ABS(ID_Sala_S)");
            return tabla;
        }

        public DataTable getTablaSala2(Salas sal)
        {
            DataTable tabla = ds.ObtenerTabla("Salas", "SELECT ID_Sala_S AS [ID], ID_Complejo_S AS [COMPLEJO], Total_Asientos_S AS [ASIENTOS], Estado_S AS [ESTADO] FROM Salas WHERE ID_Sala_S = '"+sal.IDSala+ "' OR ID_Complejo_S = '"+sal.IDComplejo+"' ORDER BY ABS(ID_Sala_S)");
            return tabla;
        }

        public DataTable getTablaSalaPorID(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Salas", "SELECT ID_Sala_S AS [ID], ID_Complejo_S AS [COMPLEJO], Total_Asientos_S AS [ASIENTOS], Estado_S AS [ESTADO] FROM Salas WHERE ID_Sala_S = '" + campo + "' ORDER BY ABS(ID_Sala_S)");
            return tabla;
        }
        public DataTable getTablaSalaPorComplejo(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Salas", "SELECT ID_Sala_S AS [ID], ID_Complejo_S AS [COMPLEJO], Total_Asientos_S AS [ASIENTOS], Estado_S AS [ESTADO] FROM Salas WHERE ID_Complejo_S = '" + campo + "' ORDER BY ABS(ID_Complejo_S)");
            return tabla;
        }
        public DataTable getTablaSalaPorAsientos(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Salas", "SELECT ID_Sala_S AS [ID], ID_Complejo_S AS [COMPLEJO], Total_Asientos_S AS [ASIENTOS], Estado_S AS [ESTADO] FROM Salas WHERE Total_Asientos_S = '" + campo + "' ORDER BY ABS(Total_Asientos_S)");
            return tabla;
        }
        public DataTable getTablaSalaPorEstado(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Salas", "SELECT ID_Sala_S AS [ID], ID_Complejo_S AS [COMPLEJO], Total_Asientos_S AS [ASIENTOS], Estado_S AS [ESTADO] FROM Salas WHERE Estado_S = '" + campo + "' ORDER BY ABS(Estado_S)");
            return tabla;
        }

        public int EliminarSala(Salas sala)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSalaEliminar(ref comando, sala);
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_EliminarSala");
        }
        public int AgregarSala(Salas sala)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSalaAgregar(ref comando, sala);
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_AgregarSala");
        }
        public int ModificarSala(Salas sala)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSalaEditar(ref comando, sala);
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_ModificarSala");
        }
        private void ArmarParametrosSalaEliminar(ref SqlCommand comando, Salas sala)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@ID", SqlDbType.Char);
            SqlParametros.Value = sala.IDSala;
            SqlParametros = comando.Parameters.Add("@IDCOMPLEJO", SqlDbType.Char);
            SqlParametros.Value = sala.IDComplejo;
        }
        private void ArmarParametrosSalaAgregar(ref SqlCommand comando, Salas sala)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@ID", SqlDbType.VarChar);
            SqlParametros.Value = sala.IDSala;
            SqlParametros = comando.Parameters.Add("@IDCOMPLEJO", SqlDbType.VarChar);
            SqlParametros.Value = sala.IDComplejo;
            SqlParametros = comando.Parameters.Add("@TOTALASIENTOS", SqlDbType.Int);
            SqlParametros.Value = sala.TotalAsientos;

        }
        private void ArmarParametrosSalaEditar(ref SqlCommand comando, Salas sala)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@ID", SqlDbType.VarChar);
            SqlParametros.Value = sala.IDSala;
            SqlParametros = comando.Parameters.Add("@IDCOMPLEJO", SqlDbType.VarChar);
            SqlParametros.Value = sala.IDComplejo;
            SqlParametros = comando.Parameters.Add("@TOTALASIENTOS", SqlDbType.Int);
            SqlParametros.Value = sala.TotalAsientos;
            SqlParametros = comando.Parameters.Add("@ESTADO", SqlDbType.Bit);
            SqlParametros.Value = sala.Estado;
        }
    }
}
