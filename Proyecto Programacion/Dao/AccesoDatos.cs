using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dao
{
    public class AccesoDatos
    {
        String rutaBDSucursales = "Data Source=localhost\\sqlexpress;Initial Catalog=Cine;Integrated Security=True";

        public AccesoDatos()
        {

        }

        private SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaBDSucursales);
            try
            {
                cn.Open();
                return cn;
            }
            catch
            {
                return null;
            }
        }

        private SqlDataAdapter ObtenerAdapter(String consultaSql, SqlConnection cn)
        {
            SqlDataAdapter adapter;
            try
            {
                adapter = new SqlDataAdapter(consultaSql, cn);
                return adapter;
            }
            catch
            {
                return null;
            }
        }

        public DataTable ObtenerTabla(String nombreTabla, String consultaSql)
        {
            DataSet ds = new DataSet();
            SqlConnection cn = ObtenerConexion();
            SqlDataAdapter adapter = ObtenerAdapter(consultaSql, cn);
            adapter.Fill(ds, nombreTabla);
            cn.Close();
            return ds.Tables[nombreTabla];
        }

        public int EjecutarProcedimientoAlmacenado(SqlCommand comando, String nombreSP)
        {
            int filasCambiadas;
            SqlConnection cn = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = comando;
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            filasCambiadas = cmd.ExecuteNonQuery();
            cn.Close();
            return filasCambiadas;
        }

        public Boolean Existe(String consultaSql)
        {
            Boolean estado = false;
            SqlConnection cn = ObtenerConexion();
            SqlCommand cmd = new SqlCommand(consultaSql, cn);
            SqlDataReader datos = cmd.ExecuteReader();
            if (datos.Read())
            {
                estado = true;
            }
            return estado;
        }
        public int ObtenerMaximo(String consulta)
        {
            int max = 0;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand(consulta, Conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            if (datos.Read())
            {
                max = Convert.ToInt32(datos[0].ToString());
            }
            return max;
        }
    }
}
