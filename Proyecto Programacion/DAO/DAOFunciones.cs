﻿using System;
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
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID], ID_Pelicula_F AS [IDPELICULA], ID_Sala_F AS [IDSALA], ID_Complejo_F AS [IDCOMPLEJO], Fecha_F AS [FECHA], Horario_F AS [HORARIO], Idioma_F AS [IDIOMA], Precio_F AS [PRECIO], Estado_F AS [ESTADO] FROM Funciones ORDER BY ABS(ID_Funcion_F)");
            return tabla;
        }
        public DataTable getTablaFuncionPorID(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID], ID_Pelicula_F AS [IDPELICULA], ID_Sala_F AS [IDSALA], ID_Complejo_F AS [IDCOMPLEJO], Fecha_F AS [FECHA], Horario_F AS [HORARIO], Idioma_F AS [IDIOMA], Precio_F AS [PRECIO], Estado_F AS [ESTADO] FROM Funciones WHERE ID_Funcion_F LIKE '%" + campo + "%' ORDER BY ABS(ID_Funcion_F)");
            return tabla;
        }
        public DataTable getTablaFuncionPorPelicula(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID], ID_Pelicula_F AS [IDPELICULA], ID_Sala_F AS [IDSALA], ID_Complejo_F AS [IDCOMPLEJO], Fecha_F AS [FECHA], Horario_F AS [HORARIO], Idioma_F AS [IDIOMA], Precio_F AS [PRECIO], Estado_F AS [ESTADO] FROM Funciones WHERE ID_Pelicula_F LIKE '%" + campo + "%' ORDER BY ABS(ID_Pelicula_F)");
            return tabla;
        }
        public DataTable getTablaFuncionPorSala(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID], ID_Pelicula_F AS [IDPELICULA], ID_Sala_F AS [IDSALA], ID_Complejo_F AS [IDCOMPLEJO], Fecha_F AS [FECHA], Horario_F AS [HORARIO], Idioma_F AS [IDIOMA], Precio_F AS [PRECIO], Estado_F AS [ESTADO] FROM Funciones WHERE ID_Sala_F LIKE '%" + campo + "%' ORDER BY ABS(ID_Sala_F)");
            return tabla;
        }
        public DataTable getTablaFuncionPorComplejo(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID], ID_Pelicula_F AS [IDPELICULA], ID_Sala_F AS [IDSALA], ID_Complejo_F AS [IDCOMPLEJO], Fecha_F AS [FECHA], Horario_F AS [HORARIO], Idioma_F AS [IDIOMA], Precio_F AS [PRECIO], Estado_F AS [ESTADO] FROM Funciones WHERE ID_Complejo_F LIKE '%" + campo + "%' ORDER BY ABS(ID_Complejo_F)");
            return tabla;
        }
        public DataTable getTablaFuncionPorFecha(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID], ID_Pelicula_F AS [IDPELICULA], ID_Sala_F AS [IDSALA], ID_Complejo_F AS [IDCOMPLEJO], Fecha_F AS [FECHA], Horario_F AS [HORARIO], Idioma_F AS [IDIOMA], Precio_F AS [PRECIO], Estado_F AS [ESTADO] FROM Funciones WHERE Fecha_F LIKE '%" + campo + "%' ORDER BY ABS(Fecha_F)");
            return tabla;
        }
        public DataTable getTablaFuncionPorHorario(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID], ID_Pelicula_F AS [IDPELICULA], ID_Sala_F AS [IDSALA], ID_Complejo_F AS [IDCOMPLEJO], Fecha_F AS [FECHA], Horario_F AS [HORARIO], Idioma_F AS [IDIOMA], Precio_F AS [PRECIO], Estado_F AS [ESTADO] FROM Funciones WHERE Horario_F LIKE '%" + campo + "%' ORDER BY ABS(Horario_F)");
            return tabla;
        }
        public DataTable getTablaFuncionPorIdioma(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID], ID_Pelicula_F AS [IDPELICULA], ID_Sala_F AS [IDSALA], ID_Complejo_F AS [IDCOMPLEJO], Fecha_F AS [FECHA], Horario_F AS [HORARIO], Idioma_F AS [IDIOMA], Precio_F AS [PRECIO], Estado_F AS [ESTADO] FROM Funciones WHERE Idioma_F LIKE '%" + campo + "%' ORDER BY ABS(Idioma_F)");
            return tabla;
        }
        public DataTable getTablaFuncionPorPrecio(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID], ID_Pelicula_F AS [IDPELICULA], ID_Sala_F AS [IDSALA], ID_Complejo_F AS [IDCOMPLEJO], Fecha_F AS [FECHA], Horario_F AS [HORARIO], Idioma_F AS [IDIOMA], Precio_F AS [PRECIO], Estado_F AS [ESTADO] FROM Funciones WHERE Precio_F LIKE '%" + campo + "%' ORDER BY ABS(Precio_F)");
            return tabla;
        }
        public DataTable getTablaFuncionPorEstado(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Funciones", "SELECT ID_Funcion_F AS [ID], ID_Pelicula_F AS [IDPELICULA], ID_Sala_F AS [IDSALA], ID_Complejo_F AS [IDCOMPLEJO], Fecha_F AS [FECHA], Horario_F AS [HORARIO], Idioma_F AS [IDIOMA], Precio_F AS [PRECIO], Estado_F AS [ESTADO] FROM Funciones WHERE Estado_F LIKE '%" + campo + "%' ORDER BY ABS(Estado_F)");
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
            SqlParametros = comando.Parameters.Add("@ESTADO", SqlDbType.Decimal);
            SqlParametros.Value = funcion.EstadoFuncion;
        }

    }
}