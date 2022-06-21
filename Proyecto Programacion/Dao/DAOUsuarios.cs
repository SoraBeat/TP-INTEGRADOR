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
    public class DAOUsuarios
    {
        AccesoDatos ds = new AccesoDatos();
        //public Boolean ExisteUsuario(Usuarios usu)
        //{
        //    string consulta = "SELECT * FROM Usuarios WHERE ID_Usuario_U = '" + usu.IDUsuario + "'";
        //    return ds.Existe(consulta);
        //}
        public DataTable getTablaUsuariosPorIDUsuario(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT ID_Usuario_U AS [ID], Nombre_U AS [NOMBRE], Apellido_U AS [APELLIDO], DNI_U AS [DNI], TELEFONO_U AS [TELEFONO], EMAIL_U AS [EMAIL], CONTRASEÑA_U AS [CONTRASEÑA], TIPO_USUARIO_U AS [SUPERUSUARIO], Estado_U AS [ESTADO] FROM Usuarios WHERE ID_Usuario_U LIKE '%" + campo + "%' ORDER BY ABS(ID_Usuario_U)");
            return tabla;
        }
        public DataTable getTablaUsuariosPorNombreUsuario(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT ID_Usuario_U AS [ID], Nombre_U AS [NOMBRE], Apellido_U AS [APELLIDO], DNI_U AS [DNI], TELEFONO_U AS [TELEFONO], EMAIL_U AS [EMAIL], CONTRASEÑA_U AS [CONTRASEÑA], TIPO_USUARIO_U AS [SUPERUSUARIO], Estado_U AS [ESTADO] FROM USUARIOS WHERE Nombre_U LIKE '%" + campo + "%' ORDER BY ABS(ID_Usuario_U)");
            return tabla;
        }
        public DataTable getTablaUsuariosPorApellidoUsuario(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT ID_Usuario_U AS [ID], Nombre_U AS [NOMBRE], Apellido_U AS [APELLIDO], DNI_U AS [DNI], TELEFONO_U AS [TELEFONO], EMAIL_U AS [EMAIL], CONTRASEÑA_U AS [CONTRASEÑA], TIPO_USUARIO_U AS [SUPERUSUARIO], Estado_U AS [ESTADO] FROM USUARIOS WHERE Apellido_U LIKE '%" + campo + "%' ORDER BY ABS(ID_Usuario_U)");
            return tabla;
        }
        public DataTable getTablaUsuariosPorDNIUsuario(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT ID_Usuario_U AS [ID], Nombre_U AS [NOMBRE], Apellido_U AS [APELLIDO], DNI_U AS [DNI], TELEFONO_U AS [TELEFONO], EMAIL_U AS [EMAIL], CONTRASEÑA_U AS [CONTRASEÑA], TIPO_USUARIO_U AS [SUPERUSUARIO], Estado_U AS [ESTADO] FROM USUARIOS WHERE DNI_U LIKE '%" + campo + "%' ORDER BY ABS(ID_Usuario_U)");
            return tabla;
        }
        public DataTable getTablaUsuariosPorTelefonoUsuario(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT ID_Usuario_U AS [ID], Nombre_U AS [NOMBRE], Apellido_U AS [APELLIDO], DNI_U AS [DNI], TELEFONO_U AS [TELEFONO], EMAIL_U AS [EMAIL], CONTRASEÑA_U AS [CONTRASEÑA], TIPO_USUARIO_U AS [SUPERUSUARIO], Estado_U AS [ESTADO] FROM USUARIOS WHERE Telefono_U LIKE '%" + campo + "%' ORDER BY ABS(ID_Usuario_U)");
            return tabla;
        }
        public DataTable getTablaUsuariosPorEmailUsuario(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT ID_Usuario_U AS [ID], Nombre_U AS [NOMBRE], Apellido_U AS [APELLIDO], DNI_U AS [DNI], TELEFONO_U AS [TELEFONO], EMAIL_U AS [EMAIL], CONTRASEÑA_U AS [CONTRASEÑA], TIPO_USUARIO_U AS [SUPERUSUARIO], Estado_U AS [ESTADO] FROM USUARIOS WHERE Email_U LIKE '%" + campo + "%' ORDER BY ABS(ID_Usuario_U)");
            return tabla;
        }
        public DataTable getTablaUsuariosPorContraseñaUsuario(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT ID_Usuario_U AS [ID], Nombre_U AS [NOMBRE], Apellido_U AS [APELLIDO], DNI_U AS [DNI], TELEFONO_U AS [TELEFONO], EMAIL_U AS [EMAIL], CONTRASEÑA_U AS [CONTRASEÑA], TIPO_USUARIO_U AS [SUPERUSUARIO], Estado_U AS [ESTADO] FROM USUARIOS WHERE Contraseña_U LIKE '%" + campo + "%' ORDER BY ABS(ID_Usuario_U)");
            return tabla;
        }
        public DataTable getTablaUsuariosPorTipoDeUsuario(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT ID_Usuario_U AS [ID], Nombre_U AS [NOMBRE], Apellido_U AS [APELLIDO], DNI_U AS [DNI], TELEFONO_U AS [TELEFONO], EMAIL_U AS [EMAIL], CONTRASEÑA_U AS [CONTRASEÑA], TIPO_USUARIO_U AS [SUPERUSUARIO], Estado_U AS [ESTADO] FROM USUARIOS WHERE Tipo_Usuario_U LIKE '%" + campo + "%' ORDER BY ABS(Tipo_Usuario_U)");
            return tabla;
        }
        public DataTable getTablaUsuariosPorEstadoDeUsuario(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT ID_Usuario_U AS [ID], Nombre_U AS [NOMBRE], Apellido_U AS [APELLIDO], DNI_U AS [DNI], TELEFONO_U AS [TELEFONO], EMAIL_U AS [EMAIL], CONTRASEÑA_U AS [CONTRASEÑA], TIPO_USUARIO_U AS [SUPERUSUARIO], Estado_U AS [ESTADO] FROM USUARIOS WHERE Estado_U LIKE '%" + campo + "%' ORDER BY ABS(Estado_U)");
            return tabla;
        }
        public Usuarios getUsuario(Usuarios usu)
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT ID_Usuario_U AS [ID], Nombre_U AS [NOMBRE], Apellido_U AS [APELLIDO], DNI_U AS [DNI], TELEFONO_U AS [TELEFONO], EMAIL_U AS [EMAIL], CONTRASEÑA_U AS [CONTRASEÑA], TIPO_USUARIO_U AS [SUPERUSUARIO], Estado_U AS [ESTADO] FROM Usuarios WHERE ID_Usuario_U=" + usu.IDUsuario);
            usu.IDUsuario = (Convert.ToInt32(tabla.Rows[0][0].ToString()));
            usu.NombreUsuario = (tabla.Rows[0][1].ToString());
            usu.ApellidoUsuario = (tabla.Rows[0][2].ToString());
            usu.DNIUsuario = (tabla.Rows[0][3].ToString());
            usu.TelefonoUsuario = (tabla.Rows[0][4].ToString());
            usu.EmailUsuario = (tabla.Rows[0][5].ToString());
            usu.ContraseñaUsuario = (tabla.Rows[0][6].ToString());
            usu.TipoUsuario = (Convert.ToBoolean(tabla.Rows[0][5].ToString()));
            usu.Estado = (Convert.ToBoolean(tabla.Rows[0][6].ToString()));
            return usu;
        }
        public DataTable getTablaUsuarios()
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT ID_Usuario_U AS [ID], Nombre_U AS [NOMBRE], Apellido_U AS [APELLIDO], DNI_U AS [DNI], TELEFONO_U AS [TELEFONO], EMAIL_U AS [EMAIL], CONTRASEÑA_U AS [CONTRASEÑA], TIPO_USUARIO_U AS [SUPERUSUARIO], Estado_U AS [ESTADO] FROM Usuarios");
            return tabla;
        }
        public int EliminarUsuario(Usuarios usu)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosUsuarioEliminar(ref comando, usu);
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_EliminarUsuario");
        }
        public int AgregarUsuario(Usuarios usu)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosUsuarioAgregar(ref comando, usu);
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_AgregarUsuario");
        }
        public int ModificarUsuario(Usuarios usu)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosUsuarioModificar(ref comando, usu);
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_ModificarUsuario");
        }
        //public int BuscarUsuario(Usuarios usu)
        //{
        //    SqlCommand comando = new SqlCommand();
        //    ArmarParametrosUsuarioExiste(ref comando, usu);
        //    return ds.EjecutarProcedimientoAlmacenado(comando, "sp_ExisteUsuario");
        //}
        public DataTable BuscarUsuario(Usuarios usu)
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT ID_Usuario_U, Nombre_U, Apellido_U, DNI_U , Telefono_U , Email_U , Contraseña_U, Estado_U, Tipo_Usuario_U FROM Usuarios WHERE Email_U='"+usu.EmailUsuario+"' AND Contraseña_U='"+usu.ContraseñaUsuario+"' AND Estado_U=1");
            return tabla;
        }

        private void ArmarParametrosUsuarioEliminar(ref SqlCommand comando, Usuarios usu)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDUSUARIO", SqlDbType.Int);
            SqlParametros.Value = usu.IDUsuario;
        }
        private void ArmarParametrosUsuarioAgregar(ref SqlCommand comando, Usuarios usu)
        {
            SqlParameter SqlParametros = new SqlParameter();
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
        private void ArmarParametrosUsuarioModificar(ref SqlCommand comando, Usuarios usu)
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
            SqlParametros = comando.Parameters.Add("@ESTADOUSUARIO", SqlDbType.Bit);
            SqlParametros.Value = usu.Estado;
        }
        private void ArmarParametrosUsuarioExiste(ref SqlCommand comando, Usuarios usu)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@EMAILUSUARIO", SqlDbType.VarChar);
            SqlParametros.Value = usu.EmailUsuario;
            SqlParametros = comando.Parameters.Add("@CONTRASEÑAUSUARIO", SqlDbType.VarChar);
            SqlParametros.Value = usu.ContraseñaUsuario;

        }
        private void ArmarParametrosTipoUsuario(ref SqlCommand comando, Usuarios usu)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@EMAIL", SqlDbType.VarChar);
            SqlParametros.Value = usu.IDUsuario;
        }

    }
}
