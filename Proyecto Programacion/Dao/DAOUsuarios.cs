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
        public Boolean ExisteUsuario(Usuarios usu)
        {
            string consulta = "SELECT * FROM Usuarios WHERE ID_Usuario_U = '" + usu.IDUsuario + "'";
            return ds.Existe(consulta);
        }
        public DataTable getTablaUsuariosPorIDUsuario(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT ID_Usuario_U AS [ID], Nombre_U AS [NOMBRE], Apellido_U AS [APELLIDO], DNI_U AS [DNI], TELEFONO_U AS [TELEFONO], EMAIL_U AS [EMAIL], CONTRASEÑA_U AS [CONTRASEÑA], TIPO_USUARIO_U AS [SUPERUSUARIO] FROM Usuarios WHERE ID_Usuario_U LIKE '%" + campo + "%' ORDER BY ABS(ID_Usuario_U)");
            return tabla;
        }
        public DataTable getTablaUsuariosPorNombreUsuario(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT ID_Usuario_U AS [ID], Nombre_U AS [NOMBRE], Apellido_U AS [APELLIDO], DNI_U AS [DNI], TELEFONO_U AS [TELEFONO], EMAIL_U AS [EMAIL], CONTRASEÑA_U AS [CONTRASEÑA], TIPO_USUARIO_U AS [SUPERUSUARIO] FROM USUARIOS WHERE Nombre_U LIKE '%" + campo + "%' ORDER BY ABS(ID_Usuario_U)");
            return tabla;
        }
        public DataTable getTablaUsuariosPorApellidoUsuario(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT ID_Usuario_U AS [ID], Nombre_U AS [NOMBRE], Apellido_U AS [APELLIDO], DNI_U AS [DNI], TELEFONO_U AS [TELEFONO], EMAIL_U AS [EMAIL], CONTRASEÑA_U AS [CONTRASEÑA], TIPO_USUARIO_U AS [SUPERUSUARIO] FROM USUARIOS WHERE Apellido_U LIKE '%" + campo + "%' ORDER BY ABS(ID_Usuario_U)");
            return tabla;
        }
        public DataTable getTablaUsuariosPorDNIUsuario(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT ID_Usuario_U AS [ID], Nombre_U AS [NOMBRE], Apellido_U AS [APELLIDO], DNI_U AS [DNI], TELEFONO_U AS [TELEFONO], EMAIL_U AS [EMAIL], CONTRASEÑA_U AS [CONTRASEÑA], TIPO_USUARIO_U AS [SUPERUSUARIO] FROM USUARIOS WHERE DNI_U LIKE '%" + campo + "%' ORDER BY ABS(ID_Usuario_U)");
            return tabla;
        }
        public DataTable getTablaUsuariosPorTelefonoUsuario(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT ID_Usuario_U AS [ID], Nombre_U AS [NOMBRE], Apellido_U AS [APELLIDO], DNI_U AS [DNI], TELEFONO_U AS [TELEFONO], EMAIL_U AS [EMAIL], CONTRASEÑA_U AS [CONTRASEÑA], TIPO_USUARIO_U AS [SUPERUSUARIO] FROM USUARIOS WHERE Telefono_U LIKE '%" + campo + "%' ORDER BY ABS(ID_Usuario_U)");
            return tabla;
        }
        public DataTable getTablaUsuariosPorEmailUsuario(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT ID_Usuario_U AS [ID], Nombre_U AS [NOMBRE], Apellido_U AS [APELLIDO], DNI_U AS [DNI], TELEFONO_U AS [TELEFONO], EMAIL_U AS [EMAIL], CONTRASEÑA_U AS [CONTRASEÑA], TIPO_USUARIO_U AS [SUPERUSUARIO] FROM USUARIOS WHERE Email_U LIKE '%" + campo + "%' ORDER BY ABS(ID_Usuario_U)");
            return tabla;
        }
        public DataTable getTablaUsuariosPorContraseñaUsuario(string campo)
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT ID_Usuario_U AS [ID], Nombre_U AS [NOMBRE], Apellido_U AS [APELLIDO], DNI_U AS [DNI], TELEFONO_U AS [TELEFONO], EMAIL_U AS [EMAIL], CONTRASEÑA_U AS [CONTRASEÑA], TIPO_USUARIO_U AS [SUPERUSUARIO] FROM USUARIOS WHERE Contraseña_U LIKE '%" + campo + "%' ORDER BY ABS(ID_Usuario_U)");
            return tabla;
        }
        public Usuarios getUsuario(Usuarios usu)
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT ID_Usuario_U AS [ID], Nombre_U AS [NOMBRE], Apellido_U AS [APELLIDO], DNI_U AS [DNI], TELEFONO_U AS [TELEFONO], EMAIL_U AS [EMAIL], CONTRASEÑA_U AS [CONTRASEÑA], TIPO_USUARIO_U AS [SUPERUSUARIO] FROM Usuarios WHERE ID_Usuario_U=" + usu.IDUsuario);
            usu.IDUsuario = (Convert.ToInt32(tabla.Rows[0][0].ToString()));
            usu.NombreUsuario = (tabla.Rows[0][1].ToString());
            usu.ApellidoUsuario = (tabla.Rows[0][2].ToString());
            usu.DNIUsuario = (tabla.Rows[0][3].ToString());
            usu.TelefonoUsuario = (tabla.Rows[0][4].ToString());
            usu.EmailUsuario = (tabla.Rows[0][5].ToString());
            usu.ContraseñaUsuario = (tabla.Rows[0][6].ToString());
            usu.TipoUsuario = (Convert.ToBoolean(tabla.Rows[0][5].ToString()));
            return usu;
        }
        public DataTable getTablaUsuarios()
        {
            DataTable tabla = ds.ObtenerTabla("Usuarios", "SELECT ID_Usuario_U AS [ID], Nombre_U AS [NOMBRE], Apellido_U AS [APELLIDO], DNI_U AS [DNI], TELEFONO_U AS [TELEFONO], EMAIL_U AS [EMAIL], CONTRASEÑA_U AS [CONTRASEÑA], TIPO_USUARIO_U AS [SUPERUSUARIO] FROM Usuarios");
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

        private void ArmarParametrosUsuarioEliminar(ref SqlCommand comando, Usuarios usu)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDUSUARIO", SqlDbType.Int);
            SqlParametros.Value = usu.IDUsuario;
        }
        private void ArmarParametrosUsuarioModificar(ref SqlCommand comando, Usuarios usu)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDUSUARIO", SqlDbType.Int);
            SqlParametros.Value = usu.NombreUsuario;
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
    }
}
