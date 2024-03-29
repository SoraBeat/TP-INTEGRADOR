﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DAOComplejos
    {
        AccesoDatos ds = new AccesoDatos();
        public Boolean ExisteComplejo(Complejos com) 
        {
            string consulta = "SELECT * FROM Complejos WHERE ID_Complejo_Co = '" + com.ID_Complejo + "'";
            return ds.Existe(consulta);

        }

        public DataTable ExisteComplejo2(Complejos com)
        {
            DataTable tabla = ds.ObtenerTabla("Complejos","SELECT * FROM Complejos WHERE ID_Complejo_Co = '" + com.ID_Complejo + "' OR Nombre_Co = '" + com.Nombre + "' OR Direccion_Co = '"+com.Direccion+"'");
            return tabla;
        }
        public Complejos getComplejo(Complejos com)
        {
            DataTable tabla = ds.ObtenerTabla("Complejos", "SELECT * FROM Complejos WHERE ID_Complejo_Co=" + com.ID_Complejo);
            com.ID_Complejo = (tabla.Rows[0][0].ToString());
            com.Nombre = (tabla.Rows[0][1].ToString());
            com.Direccion = (tabla.Rows[0][2].ToString());
            com.Telefono = (tabla.Rows[0][3].ToString());
            com.Email = (tabla.Rows[0][4].ToString());
            return com;
        }
        public DataTable getTablaComplejo()
        {
            DataTable tabla = ds.ObtenerTabla("Complejos", "SELECT ID_Complejo_Co AS [ID], Nombre_Co AS [NOMBRE], Direccion_Co AS [DIRECCION], Telefono_Co AS [TELEFONO], Email_Co AS [EMAIL], Estado_Co AS [ESTADO] FROM Complejos ORDER BY ABS(ID_Complejo_Co)");
            return tabla;
        }
        public DataTable getTablaComplejoPorID(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Complejos", "SELECT ID_Complejo_Co AS [ID], Nombre_Co AS [NOMBRE], Direccion_Co AS [DIRECCION], Telefono_Co AS [TELEFONO], Email_Co AS [EMAIL], Estado_Co AS [ESTADO] FROM Complejos WHERE ID_Complejo_Co LIKE '" + campo+ "' ORDER BY ABS(ID_Complejo_Co)");
            return tabla;
        }
        public DataTable getTablaComplejoPorNombre(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Complejos", "SELECT ID_Complejo_Co AS [ID], Nombre_Co AS [NOMBRE], Direccion_Co AS [DIRECCION], Telefono_Co AS [TELEFONO], Email_Co AS [EMAIL], Estado_Co AS [ESTADO] FROM Complejos WHERE Nombre_Co LIKE '%" + campo+ "%' ORDER BY ABS(ID_Complejo_Co)");
            return tabla;
        }
        public DataTable getTablaComplejoPorDireccion(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Complejos", "SELECT ID_Complejo_Co AS [ID], Nombre_Co AS [NOMBRE], Direccion_Co AS [DIRECCION], Telefono_Co AS [TELEFONO], Email_Co AS [EMAIL], Estado_Co AS [ESTADO] FROM Complejos WHERE Direccion_Co LIKE '%" + campo+ "%' ORDER BY ABS(ID_Complejo_Co)");
            return tabla;
        }
        public DataTable getTablaComplejoPorTelefono(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Complejos", "SELECT ID_Complejo_Co AS [ID], Nombre_Co AS [NOMBRE], Direccion_Co AS [DIRECCION], Telefono_Co AS [TELEFONO], Email_Co AS [EMAIL], Estado_Co AS [ESTADO] FROM Complejos WHERE Telefono_Co LIKE '%" + campo + "%' ORDER BY ABS(ID_Complejo_Co)");
            return tabla;
        }
        public DataTable getTablaComplejoPorEmail(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Complejos", "SELECT ID_Complejo_Co AS [ID], Nombre_Co AS [NOMBRE], Direccion_Co AS [DIRECCION], Telefono_Co AS [TELEFONO], Email_Co AS [EMAIL], Estado_Co AS [ESTADO] FROM Complejos WHERE Email_Co LIKE '%" + campo + "%' ORDER BY ABS(ID_Complejo_Co)");
            return tabla;
        }
        public DataTable getTablaComplejoPorEstado(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Complejos", "SELECT ID_Complejo_Co AS [ID], Nombre_Co AS [NOMBRE], Direccion_Co AS [DIRECCION], Telefono_Co AS [TELEFONO], Email_Co AS [EMAIL], Estado_Co AS [ESTADO] FROM Complejos WHERE Estado_Co LIKE '" + campo + "' ORDER BY ABS(Estado_Co)");
            return tabla;
        }
        public int EliminarComplejo(Complejos com)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosComplejoEliminar(ref comando, com);
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_EliminarComplejo");
        }
        public int AgregarComplejo(Complejos com)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosComplejoAgregar(ref comando, com);
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_AgregarComplejo");
        }
        public int ModificarComplejo(Complejos com)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosComplejoModificar(ref comando, com);
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_ModificarComplejo");
        }
        private void ArmarParametrosComplejoEliminar(ref SqlCommand comando, Complejos com)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDCOMPLEJO", SqlDbType.Char);
            SqlParametros.Value = com.ID_Complejo;
        }
        private void ArmarParametrosComplejoAgregar(ref SqlCommand comando, Complejos com)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDCOMPLEJO", SqlDbType.VarChar);
            SqlParametros.Value = com.ID_Complejo;
            SqlParametros = comando.Parameters.Add("@NOMBRECOMPLEJO", SqlDbType.VarChar);
            SqlParametros.Value = com.Nombre;
            SqlParametros = comando.Parameters.Add("@DIRECCIONCOMPLEJO", SqlDbType.VarChar);
            SqlParametros.Value = com.Direccion;
            SqlParametros = comando.Parameters.Add("@TELEFONOCOMPLEJO", SqlDbType.VarChar);
            SqlParametros.Value = com.Telefono;
            SqlParametros = comando.Parameters.Add("@EMAILCOMPLEJO", SqlDbType.VarChar);
            SqlParametros.Value = com.Email;
        }
        private void ArmarParametrosComplejoModificar(ref SqlCommand comando, Complejos com)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDCOMPLEJO", SqlDbType.VarChar);
            SqlParametros.Value = com.ID_Complejo;
            SqlParametros = comando.Parameters.Add("@NOMBRECOMPLEJO", SqlDbType.VarChar);
            SqlParametros.Value = com.Nombre;
            SqlParametros = comando.Parameters.Add("@DIRECCIONCOMPLEJO", SqlDbType.VarChar);
            SqlParametros.Value = com.Direccion;
            SqlParametros = comando.Parameters.Add("@TELEFONOCOMPLEJO", SqlDbType.VarChar);
            SqlParametros.Value = com.Telefono;
            SqlParametros = comando.Parameters.Add("@EMAILCOMPLEJO", SqlDbType.VarChar);
            SqlParametros.Value = com.Email;
            SqlParametros = comando.Parameters.Add("@ESTADOCOMPLEJO", SqlDbType.Bit);
            SqlParametros.Value = com.Estado_Co1;
        }
    }
}
