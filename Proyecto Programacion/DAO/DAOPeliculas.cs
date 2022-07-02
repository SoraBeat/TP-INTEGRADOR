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
    public class DAOPeliculas
    {
        AccesoDatos ds = new AccesoDatos();

        public Boolean ExistePelicula(Peliculas pel)
        {
            string consulta = "SELECT ID_Pelicula_P AS [ID], Titulo_P AS [Titulo], Descripcion_P AS [Descripcion], Duracion_P AS [Duracion], Clasificacion_P AS [Clasificacion], Genero_P AS [Genero], Portada_P AS [Portada], Estado_P AS [Estado] FROM Peliculas WHERE ID_Pelicula_P = '" + pel.ID_Pelicula + "'";
            return ds.Existe(consulta);
        }
        public Peliculas getPeliculas(Peliculas pel)
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT ID_Pelicula_P AS [ID], Titulo_P AS [Titulo], Descripcion_P AS [Descripcion], Duracion_P AS [Duracion], Clasificacion_P AS [Clasificacion], Genero_P AS [Genero], Portada_P AS [Portada], Estado_P AS [Estado] FROM Peliculas WHERE ID_Pelicula_P =" + pel.ID_Pelicula);
            pel.ID_Pelicula = (tabla.Rows[0][0].ToString());
            pel.Titulo = (tabla.Rows[0][1].ToString());
            pel.Descripcion = (tabla.Rows[0][2].ToString());
            pel.Duracion = (tabla.Rows[0][3].ToString());
            pel.Clasificacion = (tabla.Rows[0][4].ToString());
            pel.Genero = (tabla.Rows[0][5].ToString());
            pel.Portada = (tabla.Rows[0][7].ToString());
            return pel;
        }
        public DataTable getListaVentas()
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT TOP(5) Titulo_P AS [PELICULAS],COUNT(ID_DetalleVenta_DV) AS [VENTAS] FROM Peliculas INNER JOIN Funciones on ID_Pelicula_F = ID_Pelicula_F INNER JOIN Detalle_Ventas on ID_Funcion_DV = ID_Funcion_F WHERE ID_Pelicula_P = ID_Pelicula_F AND ID_Funcion_F = ID_Funcion_DV GROUP BY Titulo_P ORDER BY COUNT(ID_DetalleVenta_DV) desc");
            return tabla;
        }
        public DataTable getNombrePelicula(string id)
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT LinkYoutube_P FROM Peliculas WHERE ID_Pelicula_P='" + id + "'");
            return tabla;
        }

        public DataTable getTablaPeliculas()
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT ID_Pelicula_P AS [ID], Titulo_P AS [Titulo], Descripcion_P AS [Descripcion], Duracion_P AS [Duracion], Clasificacion_P AS [Clasificacion], Genero_P AS [Genero], Portada_P AS [Portada], Estado_P AS [Estado] FROM Peliculas INNER JOIN Funciones on ID_Pelicula_P = ID_Pelicula_F GROUP BY Titulo_P");
            return tabla;
        }
        public DataTable getTablaPeliculas2()
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SET LANGUAGE Spanish SELECT DISTINCT CAST(ID_Pelicula_P AS int) AS [ID],Titulo_P AS [Titulo], Duracion_P AS [Duracion], Clasificacion_P AS [Clasificacion], Genero_P AS [Genero], Portada_P AS [Portada], Estado_P AS [Estado] FROM Peliculas inner JOIN Funciones  on Peliculas.ID_Pelicula_P = Funciones.ID_Pelicula_F WHERE Estado_P=1 AND Fecha_F >=(CONVERT (VARCHAR(11),GETDATE(),104)) AND Horario_F >= CONVERT(VARCHAR(12),GETDATE(),114)");
            return tabla;
        }
        public DataTable getTablaPeliculasComplejos(string consulta)
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT DISTINCT CAST(ID_Pelicula_P AS int) AS [ID],Titulo_P AS [Titulo], Duracion_P AS [Duracion], Clasificacion_P AS [Clasificacion], Genero_P AS [Genero], Portada_P AS [Portada], Estado_P AS [Estado] FROM Peliculas inner JOIN Funciones  on Peliculas.ID_Pelicula_P = Funciones.ID_Pelicula_F WHERE ID_Complejo_F LIKE '" + consulta + "' AND Estado_P=1 AND Fecha_F >=(CONVERT (VARCHAR(11),GETDATE(),104)) AND Horario_F >= CONVERT(VARCHAR(12),GETDATE(),114)");
            return tabla;
        }

        public DataTable getTablaPeliculas2D()
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT DISTINCT CAST(ID_Pelicula_P AS int) AS [ID],Titulo_P AS [Titulo], Duracion_P AS [Duracion], Clasificacion_P AS [Clasificacion], Genero_P AS [Genero], Portada_P AS [Portada], Estado_P AS [Estado] FROM Peliculas inner JOIN Funciones  on Peliculas.ID_Pelicula_P = Funciones.ID_Pelicula_F WHERE Formato_F LIKE '2D' AND Estado_P=1 AND Fecha_F >=(CONVERT (VARCHAR(11),GETDATE(),104)) AND Horario_F >= CONVERT(VARCHAR(12),GETDATE(),114)");
            return tabla;
        }

        public DataTable getTablaPeliculas4D()
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT DISTINCT CAST(ID_Pelicula_P AS int) AS [ID],Titulo_P AS [Titulo], Duracion_P AS [Duracion], Clasificacion_P AS [Clasificacion], Genero_P AS [Genero], Portada_P AS [Portada], Estado_P AS [Estado] FROM Peliculas inner JOIN Funciones  on Peliculas.ID_Pelicula_P = Funciones.ID_Pelicula_F WHERE Formato_F LIKE '4D' AND Estado_P=1 AND Fecha_F >=(CONVERT (VARCHAR(11),GETDATE(),104)) AND Horario_F >= CONVERT(VARCHAR(12),GETDATE(),114)");
            return tabla;
        }

        public DataTable getTablaPeliculasSubtitulada()
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT DISTINCT CAST(ID_Pelicula_P AS int) AS [ID],Titulo_P AS [Titulo], Duracion_P AS [Duracion], Clasificacion_P AS [Clasificacion], Genero_P AS [Genero], Portada_P AS [Portada], Estado_P AS [Estado] FROM Peliculas inner JOIN Funciones  on Peliculas.ID_Pelicula_P = Funciones.ID_Pelicula_F WHERE Idioma_F LIKE 'Subtitulado' AND Estado_P=1 AND Fecha_F >=(CONVERT (VARCHAR(11),GETDATE(),104)) AND Horario_F >= CONVERT(VARCHAR(12),GETDATE(),114)");
            return tabla;
        }

        public DataTable getTablaPeliculasEspanol()
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT DISTINCT CAST(ID_Pelicula_P AS int) AS [ID],Titulo_P AS [Titulo], Duracion_P AS [Duracion], Clasificacion_P AS [Clasificacion], Genero_P AS [Genero], Portada_P AS [Portada], Estado_P AS [Estado] FROM Peliculas inner JOIN Funciones  on Peliculas.ID_Pelicula_P = Funciones.ID_Pelicula_F WHERE Idioma_F LIKE 'Español' AND Estado_P=1 AND Fecha_F >=(CONVERT (VARCHAR(11),GETDATE(),104)) AND Horario_F >= CONVERT(VARCHAR(12),GETDATE(),114)");
            return tabla;
        }

        public DataTable getTablaPeliculas3D()
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT DISTINCT CAST(ID_Pelicula_P AS int) AS [ID],Titulo_P AS [Titulo], Duracion_P AS [Duracion], Clasificacion_P AS [Clasificacion], Genero_P AS [Genero], Portada_P AS [Portada], Estado_P AS [Estado] FROM Peliculas inner JOIN Funciones  on Peliculas.ID_Pelicula_P = Funciones.ID_Pelicula_F WHERE Formato_F LIKE '3D' AND Estado_P=1 AND Fecha_F >=(CONVERT (VARCHAR(11),GETDATE(),104)) AND Horario_F >= CONVERT(VARCHAR(12),GETDATE(),114)");
            return tabla;
        }

        public DataTable getListaPeliculasCompleto()
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT ID_Pelicula_P AS [ID], Titulo_P AS [Titulo], SUBSTRING(Descripcion_P,0,30) AS [Descripcion], Duracion_P AS [Duracion], Clasificacion_P AS [Clasificacion], Genero_P AS [Genero], Portada_P AS [Portada], Estado_P AS [Estado] FROM Peliculas ORDER BY ABS(ID_Pelicula_P)");
            return tabla;
        }
        public DataTable getTablaPeliculaPorID(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT ID_Pelicula_P AS [ID], Titulo_P AS [Titulo], Descripcion_P AS [Descripcion], Duracion_P AS [Duracion], Clasificacion_P AS [Clasificacion], Genero_P AS [Genero], Portada_P AS [Portada], Estado_P AS [Estado] FROM Peliculas WHERE ID_Pelicula_P LIKE '" + campo + "' ORDER BY ABS(ID_Pelicula_P)");
            return tabla;
        }

        public DataTable getTablaPeliculaPorTitulo(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT ID_Pelicula_P AS [ID], Titulo_P AS [Titulo], Descripcion_P AS [Descripcion], Duracion_P AS [Duracion], Clasificacion_P AS [Clasificacion], Genero_P AS [Genero], Portada_P AS [Portada], Estado_P AS [Estado] FROM Peliculas WHERE Titulo_P LIKE '%" + campo + "%' ORDER BY ABS(ID_Pelicula_P)");
            return tabla;
        }

        public DataTable getTablaPeliculaPorDescripcion(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT ID_Pelicula_P AS [ID], Titulo_P AS [Titulo], Descripcion_P AS [Descripcion], Duracion_P AS [Duracion], Clasificacion_P AS [Clasificacion], Genero_P AS [Genero], Portada_P AS [Portada], Estado_P AS [Estado] FROM Peliculas WHERE Descripcion_P LIKE '%" + campo + "%' ORDER BY ABS(ID_Pelicula_P)");
            return tabla;
        }

        public DataTable getTablaPeliculaPorDuracion(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT ID_Pelicula_P AS [ID], Titulo_P AS [Titulo], Descripcion_P AS [Descripcion], Duracion_P AS [Duracion], Clasificacion_P AS [Clasificacion], Genero_P AS [Genero], Portada_P AS [Portada], Estado_P AS [Estado] FROM Peliculas WHERE Duracion_P LIKE '%" + campo + "%' ORDER BY ABS(ID_Pelicula_P)");
            return tabla;
        }

        public DataTable getTablaPeliculaPorClasificacion(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT ID_Pelicula_P AS [ID], Titulo_P AS [Titulo], Descripcion_P AS [Descripcion], Duracion_P AS [Duracion], Clasificacion_P AS [Clasificacion], Genero_P AS [Genero], Portada_P AS [Portada], Estado_P AS [Estado] FROM Peliculas WHERE Clasificacion_P LIKE '%" + campo + "%' ORDER BY ABS(ID_Pelicula_P)");
            return tabla;
        }

        public DataTable getTablaPeliculaPorGenero(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT ID_Pelicula_P AS [ID], Titulo_P AS [Titulo], Descripcion_P AS [Descripcion], Duracion_P AS [Duracion], Clasificacion_P AS [Clasificacion], Genero_P AS [Genero], Portada_P AS [Portada], Estado_P AS [Estado] FROM Peliculas WHERE Genero_P LIKE '%" + campo + "%' ORDER BY ABS(ID_Pelicula_P)");
            return tabla;
        }


        public DataTable getTablaPeliculaPorPortada(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT ID_Pelicula_P AS [ID], Titulo_P AS [Titulo], Descripcion_P AS [Descripcion], Duracion_P AS [Duracion], Clasificacion_P AS [Clasificacion], Genero_P AS [Genero], Portada_P AS [Portada], Estado_P AS [Estado] FROM Peliculas WHERE Portada_P LIKE '%" + campo + "%' ORDER BY ABS(ID_Pelicula_P)");
            return tabla;
        }

        public DataTable getTablaPeliculaPorEstado(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT ID_Pelicula_P AS [ID], Titulo_P AS [Titulo], Descripcion_P AS [Descripcion], Duracion_P AS [Duracion], Clasificacion_P AS [Clasificacion], Genero_P AS [Genero], Portada_P AS [Portada], Estado_P AS [Estado] FROM Peliculas WHERE Estado_P LIKE '%" + campo + "%' ORDER BY ABS(ID_Pelicula_P)");
            return tabla;
        }
        public DataTable getPortadaPorID(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Peliculas", "SELECT Portada_P AS [Portada] FROM Peliculas WHERE ID_Pelicula_P LIKE '%" + campo + "%'");
            return tabla;
        }

        public int ModificarPeliculas(Peliculas com)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosPeliculasAgregar(ref comando, com);
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_ModificarPelicula");
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
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_AgregarPeliculas");
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
            SqlParametros = comando.Parameters.Add("@Descripcion", SqlDbType.Text);
            SqlParametros.Value = pel.Descripcion;
            SqlParametros = comando.Parameters.Add("@Duracion", SqlDbType.Char);
            SqlParametros.Value = pel.Duracion;
            SqlParametros = comando.Parameters.Add("@Clasificacion", SqlDbType.Char);
            SqlParametros.Value = pel.Clasificacion;
            SqlParametros = comando.Parameters.Add("@Genero", SqlDbType.VarChar);
            SqlParametros.Value = pel.Genero;
            SqlParametros = comando.Parameters.Add("@Portada", SqlDbType.VarChar);
            SqlParametros.Value = pel.Portada;
            SqlParametros = comando.Parameters.Add("@Estado", SqlDbType.VarChar);
            SqlParametros.Value = pel.Estado;

        }

    }
}
