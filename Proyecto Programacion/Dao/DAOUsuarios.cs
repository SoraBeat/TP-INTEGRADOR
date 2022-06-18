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
    public class DAOUsuarios
    {
        AccesoDatos ds = new AccesoDatos();
        public Boolean ExisteUsuario(Usuarios usu)
        {
            string consulta = "SELECT * FROM Usuarios WHERE ID_Usuario_U = '" + usu.IDUsuario + "'";
            return ds.Existe(consulta);
        }
        public DataTable getTablaUsuariosPorID(int id)
        {
            String consultaSql = "SELECT * FROM Usuarios WHERE ID_Usuario_U " + id;
            DataTable tabla = ds.ObtenerTabla("Usuarios", consultaSql);
            return tabla;
        }
        public Usuarios getUsuario(Usuarios usu)
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT * FROM Usuarios WHERE ID_Usuario_U=" + usu.IDUsuario);
            usu.IDUsuario = (Convert.ToInt32(tabla.Rows[0][0].ToString()));
            usu.NombreUsuario = (tabla.Rows[0][1].ToString());
            usu.ApellidoUsuario = (tabla.Rows[0][2].ToString());
            usu.DNIUsuario = (Convert.ToInt32(tabla.Rows[0][3].ToString()));
            usu.TelefonoUsuario = (Convert.ToInt32(tabla.Rows[0][4].ToString()));
            usu.EmailUsuario = (tabla.Rows[0][5].ToString());
            usu.ContraseñaUsuario = (tabla.Rows[0][6].ToString());
            usu.TipoUsuario = (Convert.ToInt32(tabla.Rows[0][5].ToString()));
            return usu;
        }
        public DataTable getTablaUsuarios()
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT * FROM Usuarios");
            return tabla;
        }
        //public int EliminarUsuario(Usuarios usu)
        //{
        //    SqlCommand comando = new SqlCommand();
        //    ArmarParametrosUsuarioEliminar(ref comando, usu);
        //    return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarUsuario");
        //}
        //public int AgregarUsuario(Usuarios usu)
        //{
        //    usu.IDUsuario = ds.ObtenerMaximo("SELECT MAX(ID_Usuario_U) FROM Usuarios") + 1;
        //    SqlCommand comando = new SqlCommand();
        //    ArmarParametrosUsuarioAgregar(ref comando, usu);
        //    return ds.EjecutarProcedimientoAlmacenado(comando, "spAgregarUsuario");
        //}
        private void ArmarParametrosUsuarioEliminar(ref SqlCommand comando, Usuarios usu)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDUSUARIO", SqlDbType.Int);
            SqlParametros.Value = usu.IDUsuario;
        }
        private void ArmarParametrosUsuarioAgregar(ref SqlCommand comando, Usuarios usu)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDUSUARIO", SqlDbType.Int);
            SqlParametros.Value = usu.IDUsuario;
            SqlParametros = comando.Parameters.Add("@NOMBREUSUARIO", SqlDbType.VarChar);
            SqlParametros.Value = usu.NombreUsuario;
            SqlParametros = comando.Parameters.Add("@APELLIDOUSUARIO", SqlDbType.VarChar);
            SqlParametros.Value = usu.ApellidoUsuario;
            SqlParametros = comando.Parameters.Add("@DNIUSUARIO", SqlDbType.VarChar);
            SqlParametros.Value = usu.DNIUsuario;
            SqlParametros = comando.Parameters.Add("@TELEFONOUSUARIO", SqlDbType.VarChar);
            SqlParametros.Value = usu.TelefonoUsuario;
            SqlParametros = comando.Parameters.Add("@EMAILUSUARIO", SqlDbType.VarChar);
            SqlParametros.Value = usu.EmailUsuario;
            SqlParametros = comando.Parameters.Add("@CONTRASEÑAUSUARIO", SqlDbType.VarChar);
            SqlParametros.Value = usu.ContraseñaUsuario;
            SqlParametros = comando.Parameters.Add("@TIPOUSUARIO", SqlDbType.Bit);
            SqlParametros.Value = usu.TipoUsuario;
        }
    }
}