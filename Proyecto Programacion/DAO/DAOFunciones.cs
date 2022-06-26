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
    public class DAOFunciones
    {
        AccesoDatos ds = new AccesoDatos();
        public Boolean ExisteFuncion(Funciones funcion)
        {
            string consulta = "SELECT * FROM Funciones WHERE ID_Funcion_F = '" + funcion.IdFuncion + "'";
            return ds.Existe(consulta);
        }
        public Funciones getFuncion(Funciones funcion)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT * FROM Funciones WHERE ID_Funcion_F=" + funcion.IdFuncion);
            funcion.IdFuncion = (tabla.Rows[0][0].ToString());
            funcion.IdPelicula = (tabla.Rows[0][1].ToString());
            funcion.IdSala = (tabla.Rows[0][2].ToString());
            funcion.IdComplejo = (tabla.Rows[0][3].ToString());
            funcion.FechaFuncion = (tabla.Rows[0][4].ToString());
            funcion.HorarioFuncion = (tabla.Rows[0][5].ToString());
            funcion.IdiomaFuncion = (tabla.Rows[0][6].ToString());
            funcion.PrecioFuncion = Convert.ToDecimal(tabla.Rows[0][7].ToString());
            funcion.EstadoFuncion = Convert.ToBoolean(tabla.Rows[0][1].ToString());
            return funcion;
        }
        public DataTable getTablaFuncion()
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID], ID_Pelicula_F AS [IDPELICULA], ID_Sala_F AS [IDSALA], ID_Complejo_F AS [IDCOMPLEJO], Fecha_F AS [FECHA], Horario_F AS [HORARIO], Idioma_F AS [IDIOMA], Precio_F AS [PRECIO], Estado_F AS [ESTADO], Formato_F AS [FORMATO] FROM Funciones ORDER BY ABS(ID_Funcion_F)");
            return tabla;
        }
        public DataTable getTablaFuncionPorID(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID], ID_Pelicula_F AS [IDPELICULA], ID_Sala_F AS [IDSALA], ID_Complejo_F AS [IDCOMPLEJO], Fecha_F AS [FECHA], Horario_F AS [HORARIO], Idioma_F AS [IDIOMA], Precio_F AS [PRECIO], Estado_F AS [ESTADO], Formato_F AS [FORMATO] FROM Funciones WHERE ID_Funcion_F LIKE '%" + campo + "%' ORDER BY ABS(ID_Funcion_F)");
            return tabla;
        }
        public DataTable getTablaFuncionPorID2(string idPelicula,string idComplejo, string Formato, string Idioma, string Fecha,string Horario)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID] FROM Funciones WHERE Estado_F = 1 AND ID_Pelicula_F = '" + idPelicula + "' AND ID_Complejo_F ='" + idComplejo + "'AND Formato_F = '" + Formato + "' AND Idioma_F = '" + Idioma + "' AND Fecha_F = '" + Fecha + "' AND Horario_F = '" + Horario + "'");
            return tabla;
        }


        public DataTable getTablaFuncionPorIDformatos(string idPelicula, string idComplejo)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT distinct Formato_F AS [FORMATO], ID_Pelicula_F AS [ID] FROM Funciones WHERE Estado_F = '1' AND ID_Pelicula_F = '" + idPelicula + "' AND ID_Complejo_F = '" + idComplejo + "' ");
            return tabla;
        }

        public DataTable getTablaFuncionPorIDidioma(string IDpelicula, string IDcomplejo, string formato)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "Select distinct  Idioma_F AS [IDIOMA] from Funciones where Estado_F = 1 AND  ID_Pelicula_F = '"+IDpelicula+"' AND ID_Complejo_F = '"+IDcomplejo+ "' AND Formato_F = '"+formato+"'");
            return tabla;
        }

        public DataTable getTablaFuncionPorIDcomplejo(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "Select Nombre_Co AS [COMPLEJO], ID_Complejo_Co AS [ID] FROM Funciones INNER JOIN Complejos ON ID_Complejo_F = ID_Complejo_Co WHERE ID_Pelicula_F = '" + campo + "' GROUP BY Nombre_Co, ID_Complejo_Co");
            return tabla;
        }

        public DataTable getTablaFuncionPorPelicula(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID], ID_Pelicula_F AS [IDPELICULA], ID_Sala_F AS [IDSALA], ID_Complejo_F AS [IDCOMPLEJO], Fecha_F AS [FECHA], Horario_F AS [HORARIO], Idioma_F AS [IDIOMA], Precio_F AS [PRECIO], Estado_F AS [ESTADO], Formato_F AS [FORMATO] FROM Funciones WHERE ID_Pelicula_F LIKE '%" + campo + "%' ORDER BY ABS(ID_Pelicula_F)");
            return tabla;
        }
        public DataTable getTablaFuncionPorSala(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID], ID_Pelicula_F AS [IDPELICULA], ID_Sala_F AS [IDSALA], ID_Complejo_F AS [IDCOMPLEJO], Fecha_F AS [FECHA], Horario_F AS [HORARIO], Idioma_F AS [IDIOMA], Precio_F AS [PRECIO], Estado_F AS [ESTADO], Formato_F AS [FORMATO] FROM Funciones WHERE ID_Sala_F LIKE '%" + campo + "%' ORDER BY ABS(ID_Sala_F)");
            return tabla;
        }
        public DataTable getTablaFuncionPorComplejo(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID], ID_Pelicula_F AS [IDPELICULA], ID_Sala_F AS [IDSALA], ID_Complejo_F AS [IDCOMPLEJO], Fecha_F AS [FECHA], Horario_F AS [HORARIO], Idioma_F AS [IDIOMA], Precio_F AS [PRECIO], Estado_F AS [ESTADO], Formato_F AS [FORMATO] FROM Funciones WHERE ID_Complejo_F LIKE '%" + campo + "%' ORDER BY ABS(ID_Complejo_F)");
            return tabla;
        }
        public DataTable getTablaFuncionPorFecha(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID], ID_Pelicula_F AS [IDPELICULA], ID_Sala_F AS [IDSALA], ID_Complejo_F AS [IDCOMPLEJO], Fecha_F AS [FECHA], Horario_F AS [HORARIO], Idioma_F AS [IDIOMA], Precio_F AS [PRECIO], Estado_F AS [ESTADO], Formato_F AS [FORMATO] FROM Funciones WHERE Fecha_F LIKE '%" + campo + "%' ORDER BY ABS(Fecha_F)");
            return tabla;
        }
        public DataTable getTablaFuncionPorFecha2(string idPelicula, string idcomplejo, string formato, string idioma)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT distinct format (Fecha_F,'dd/MM') AS [FECHA] FROM Funciones WHERE Estado_F = 1 AND  ID_Pelicula_F = '" + idPelicula + "' AND ID_Complejo_F = '" + idcomplejo + "' AND Formato_F = '" + formato + "' AND Idioma_F = '" + idioma + "'");
            return tabla;
        }
        public DataTable getTablaFuncionPorHorario(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID], ID_Pelicula_F AS [IDPELICULA], ID_Sala_F AS [IDSALA], ID_Complejo_F AS [IDCOMPLEJO], Fecha_F AS [FECHA], Horario_F AS [HORARIO], Idioma_F AS [IDIOMA], Precio_F AS [PRECIO], Estado_F AS [ESTADO], Formato_F AS [FORMATO] FROM Funciones WHERE Horario_F LIKE '%" + campo + "%' ORDER BY ABS(Horario_F)");
            return tabla;
        }
        public DataTable getTablaFuncionPorHorario2(string idPelicula, string idcomplejo, string formato, string idioma, string fecha)
        {
            
            DataTable tabla = ds.ObtenerTabla("Funciones", "SET LANGUAGE Spanish SELECT convert (varchar(5),Horario_F,108) AS [HORARIO] FROM Funciones WHERE Estado_F = 1 AND  ID_Pelicula_F = '" + idPelicula + "' AND ID_Complejo_F = '" + idcomplejo + "' AND Formato_F = '" + formato + "' AND Idioma_F = '" + idioma + "' AND Fecha_F = '"+fecha+"'");
            return tabla;
        }
        public DataTable getTablaFuncionPorIdioma(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID], ID_Pelicula_F AS [IDPELICULA], ID_Sala_F AS [IDSALA], ID_Complejo_F AS [IDCOMPLEJO], Fecha_F AS [FECHA], Horario_F AS [HORARIO], Idioma_F AS [IDIOMA], Precio_F AS [PRECIO], Estado_F AS [ESTADO], Formato_F AS [FORMATO] FROM Funciones WHERE Idioma_F LIKE '%" + campo + "%' ORDER BY ABS(Idioma_F)");
            return tabla;
        }
        public DataTable getTablaFuncionPorPrecio(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID], ID_Pelicula_F AS [IDPELICULA], ID_Sala_F AS [IDSALA], ID_Complejo_F AS [IDCOMPLEJO], Fecha_F AS [FECHA], Horario_F AS [HORARIO], Idioma_F AS [IDIOMA], Precio_F AS [PRECIO], Estado_F AS [ESTADO], Formato_F AS [FORMATO] FROM Funciones WHERE Precio_F LIKE '%" + campo + "%' ORDER BY ABS(Precio_F)");
            return tabla;
        }
        public DataTable getTablaFuncionPorFormato(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID], ID_Pelicula_F AS [IDPELICULA], ID_Sala_F AS [IDSALA], ID_Complejo_F AS [IDCOMPLEJO], Fecha_F AS [FECHA], Horario_F AS [HORARIO], Idioma_F AS [IDIOMA], Precio_F AS [PRECIO], Estado_F AS [ESTADO], Formato_F AS [FORMATO] FROM Funciones WHERE Formato_F LIKE '%" + campo + "%' ORDER BY ABS(Formato_F)");
            return tabla;
        }
        public DataTable getTablaFuncionPorEstado(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID], ID_Pelicula_F AS [IDPELICULA], ID_Sala_F AS [IDSALA], ID_Complejo_F AS [IDCOMPLEJO], Fecha_F AS [FECHA], Horario_F AS [HORARIO], Idioma_F AS [IDIOMA], Precio_F AS [PRECIO], Estado_F AS [ESTADO], Formato_F AS [FORMATO] FROM Funciones WHERE Estado_F LIKE '%" + campo + "%' ORDER BY ABS(Estado_F)");
            return tabla;
        }

        public int EliminarFuncion(Funciones funcion)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosFuncionEliminar(ref comando, funcion);
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_EliminarFuncion");
        }
        public int AgregarFuncion(Funciones funcion)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosFuncionAgregar(ref comando, funcion);
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_AgregarFuncion");
        }
        public int ModificarFuncion(Funciones funcion)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosFuncionAgregar(ref comando, funcion);
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_ModificarFuncion");
        }
        private void ArmarParametrosFuncionEliminar(ref SqlCommand comando, Funciones funcion)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDFUNCION", SqlDbType.Char);
            SqlParametros.Value = funcion.IdFuncion;
        }
        private void ArmarParametrosFuncionAgregar(ref SqlCommand comando, Funciones funcion)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDFUNCION", SqlDbType.Char);
            SqlParametros.Value = funcion.IdFuncion;
            SqlParametros = comando.Parameters.Add("@IDPELICULA", SqlDbType.Char);
            SqlParametros.Value = funcion.IdPelicula;
            SqlParametros = comando.Parameters.Add("@IDSALA", SqlDbType.Char);
            SqlParametros.Value = funcion.IdSala;
            SqlParametros = comando.Parameters.Add("@IDCOMPLEJO", SqlDbType.Char);
            SqlParametros.Value = funcion.IdComplejo;
            SqlParametros = comando.Parameters.Add("@FECHA", SqlDbType.Date);
            SqlParametros.Value = funcion.FechaFuncion;
            SqlParametros = comando.Parameters.Add("@HORARIO", SqlDbType.Time);
            SqlParametros.Value = funcion.HorarioFuncion;
            SqlParametros = comando.Parameters.Add("@IDIOMA", SqlDbType.VarChar);
            SqlParametros.Value = funcion.IdiomaFuncion;
            SqlParametros = comando.Parameters.Add("@PRECIO", SqlDbType.Decimal);
            SqlParametros.Value = funcion.PrecioFuncion;
            SqlParametros = comando.Parameters.Add("@FORMATO", SqlDbType.Char);
            SqlParametros.Value = funcion.FormatoFuncion;
            SqlParametros = comando.Parameters.Add("@ESTADO", SqlDbType.Decimal);
            SqlParametros.Value = funcion.EstadoFuncion;
        }

    }
}