using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Dao
{
    public class DaoUsuario
    {
        AccesoDatos ad = new AccesoDatos();

        public DataTable getUsuario(int id)
        {
            String consultaSql = "SELECT * FROM Usuarios WHERE ID_Usuario_U = " + id;
            DataTable tabla = ad.ObtenerTabla("Usuarios", consultaSql);
            return tabla;
        }
        public Boolean ExisteSucursal(Usuarios usu)
        {
            String consultaSql = "SELECT * FROM Usuarios WHERE ID_Usuario_U='" + usu.getIdUsuario() + "'";
            return ad.Existe(consultaSql);
        }
        public DataTable getTablaUsuarios()
        {
            String consultaSql = "SELECT * FROM Usuarios";
                                   
            DataTable tabla = ad.ObtenerTabla("Usuarios", consultaSql);
            return tabla;
        }
        public int agregarUsuario(Usuarios usu)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosUsuariosAgregar(ref comando, usu);
            return ad.EjecutarProcedimientoAlmacenado(comando, "spAgregarUsuario");
        }
        public int eliminarUsuario(Usuarios usu)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosUsuariosEliminar(ref comando, usu);
            return ad.EjecutarProcedimientoAlmacenado(comando, "spEliminarUsuario");
        }
        private void ArmarParametrosUsuariosAgregar(ref SqlCommand Comando, Usuarios usu)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@NOMBREUSUARIO", SqlDbType.VarChar);
            SqlParametros.Value = usu.getNombreUsuario();
            SqlParametros = Comando.Parameters.Add("@APELLIDOUSUARIO", SqlDbType.VarChar);
            SqlParametros.Value = usu.getApellidoUsuario();
            SqlParametros = Comando.Parameters.Add("@DNIUSUARIO", SqlDbType.VarChar);
            SqlParametros.Value = usu.getDniUsuario();
            SqlParametros = Comando.Parameters.Add("@TELEFONOUSUARIO", SqlDbType.VarChar);
            SqlParametros.Value = usu.getTelefonoUsuario();
            SqlParametros = Comando.Parameters.Add("@EMAILUSUARIO", SqlDbType.VarChar);
            SqlParametros.Value = usu.getEmailUsuario();
            SqlParametros = Comando.Parameters.Add("@CONTRASEÑAUSUARIO", SqlDbType.VarChar);
            SqlParametros.Value = usu.getContraseñaUsuario();
            SqlParametros = Comando.Parameters.Add("@TIPOUSUARIO", SqlDbType.Bit);
            SqlParametros.Value = usu.getDireccionSucursal();
        }
        private void ArmarParametrosSucursalEliminar(ref SqlCommand Comando, Usuarios usu)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDUSUARIO", SqlDbType.Int);
            SqlParametros.Value = usu.getIdUsuario();
        }
    }
}

