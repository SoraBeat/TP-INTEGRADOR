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
    public class DAOPeliculas
    {
        AccesoDatos ds = new AccesoDatos();
        public Boolean ExistePelicula(Peliculas pel)
        {
            string consulta = "SELECT * FROM Peliculas WHERE ID_Pelicula_P = '" + pel.ID_Pelicula + "'";
            return ds.Existe(consulta);
        }
        public Peliculas getPeliculas(Peliculas pel)
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT * FROM Peliculas WHERE ID_Pelicula_P =" + pel.ID_Pelicula);
            pel.ID_Pelicula = (tabla.Rows[0][0].ToString());
            pel.Titulo = (tabla.Rows[0][1].ToString());
            pel.Descripcion = (tabla.Rows[0][2].ToString());
            pel.Duracion = (tabla.Rows[0][3].ToString());
            pel.Clasificacion = (tabla.Rows[0][4].ToString());
            pel.Genero = (tabla.Rows[0][5].ToString());
            pel.Formato = (tabla.Rows[0][6].ToString());
            pel.Portada = (tabla.Rows[0][7].ToString());
            pel.Estado = (tabla.Rows[0][8].ToString());
            return pel;
        }
        public DataTable getTablaPeliculas()
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT ID_Pelicula_P AS [ID], Titulo_P AS [Titulo], Descripcion_P AS [Descripcion], Duracion_P AS [Duracion], Clasificacion_P AS [Clasificacion], Genero_P AS [Genero],Formato_P [Formato],Portada_P [Portada],Estado_P [Estado] FROM Peliculas");
            return tabla;
        }
        public int EliminarPeliculas(Peliculas pel)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosPeliculasEliminar(ref comando, pel);
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_EliminarPelicula");
        }
        public int AgregarPeliculas(Peliculas pel)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosPeliculasAgregar(ref comando, pel);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAgregarPeliculas");
        }
        private void ArmarParametrosPeliculasEliminar(ref SqlCommand comando, Peliculas pel)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@ID_Pelicula", SqlDbType.Char);
            SqlParametros.Value = pel.ID_Pelicula;
        }
        private void ArmarParametrosPeliculasAgregar(ref SqlCommand comando, Peliculas pel)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@ID_Pelicula", SqlDbType.Char);
            SqlParametros.Value = pel.ID_Pelicula;
            SqlParametros = comando.Parameters.Add("@Titulo", SqlDbType.VarChar);
            SqlParametros.Value = pel.Titulo;
            SqlParametros = comando.Parameters.Add("@Descripcion", SqlDbType.text);
            SqlParametros.Value = pel.Descripcion;
            SqlParametros = comando.Parameters.Add("@Duracion", SqlDbType.Char);
            SqlParametros.Value = pel.Duracion;
            SqlParametros = comando.Parameters.Add("@Clasificacion", SqlDbType.Char);
            SqlParametros.Value = pel.Clasificacion;
            SqlParametros = comando.Parameters.Add("@Genero", SqlDbType.VarChar);
            SqlParametros.Value = pel.Genero;
            SqlParametros = comando.Parameters.Add("@Formato", SqlDbType.Char);
            SqlParametros.Value = pel.Formato;
            SqlParametros = comando.Parameters.Add("@Portada", SqlDbType.VarChar);
            SqlParametros.Value = pel.Portada;
            SqlParametros = comando.Parameters.Add("@Estado", SqlDbType.bit);
            SqlParametros.Value = pel.Estado;
        }

    }
}
