using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using Entidades;

namespace Negocios
{
    public class NegocioUsuario
    {
        public DataTable getListaUsuarios()
        {
            DAOUsuarios dao = new DAOUsuarios();
            return dao.getTablaUsuarios();
        }

        public DataTable getListaPorIDUsuario(string id)
        {
            DAOUsuarios dao = new DAOUsuarios();
            return dao.getTablaUsuariosPorIDUsuario(id);
        }
        public DataTable getListaPorNombreUsuario(string nombre)
        {
            DAOUsuarios dao = new DAOUsuarios();
            return dao.getTablaUsuariosPorNombreUsuario(nombre);
        }
        public DataTable getListaPorApellidoUsuario(string apellido)
        {
            DAOUsuarios dao = new DAOUsuarios();
            return dao.getTablaUsuariosPorApellidoUsuario(apellido);
        }
        public DataTable getListaPorDNIUsuario(string DNI)
        {
            DAOUsuarios dao = new DAOUsuarios();
            return dao.getTablaUsuariosPorDNIUsuario(DNI);
        }
        public DataTable getListaPorTelefonoUsuario(string telefono)
        {
            DAOUsuarios dao = new DAOUsuarios();
            return dao.getTablaUsuariosPorDNIUsuario(telefono);
        }
        public DataTable getListaPorEmailUsuario(string email)
        {
            DAOUsuarios dao = new DAOUsuarios();
            return dao.getTablaUsuariosPorEmailUsuario(email);
        }
        public DataTable getListaPorContraseñaUsuario(string contraseña)
        {
            DAOUsuarios dao = new DAOUsuarios();
            return dao.getTablaUsuariosPorContraseñaUsuario(contraseña);
        }
        public DataTable getListaPorTipoDeUsuario(string tipoUsuario)
        {
            DAOUsuarios dao = new DAOUsuarios();
            return dao.getTablaUsuariosPorTipoDeUsuario(tipoUsuario);
        }
        public DataTable getListaPorEstadoDeUsuario(string estado)
        {
            DAOUsuarios dao = new DAOUsuarios();
            return dao.getTablaUsuariosPorEstadoDeUsuario(estado);
        }

        public Usuarios get(int id)
        {
            DAOUsuarios dao = new DAOUsuarios();
            Usuarios Usu = new Usuarios();
            Usu.IDUsuario = id;
            return dao.getUsuario(Usu);
        }
        public bool EliminarUsuario(int id)
        {
            DAOUsuarios dao = new DAOUsuarios();
            Usuarios Usu = new Usuarios();
            Usu.IDUsuario = id;
            int op = dao.EliminarUsuario(Usu);
            if (op == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AgregarUsuario(Usuarios usu)
        {
            int cantFilas = 0;
            DAOUsuarios daoUsu = new DAOUsuarios();

            cantFilas = daoUsu.AgregarUsuario(usu);

            if (cantFilas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ModificarUsuario(Usuarios usu)
        {
            int cantFilas = 0;
            DAOUsuarios daoUsu = new DAOUsuarios();

            cantFilas = daoUsu.ModificarUsuario(usu);

            if (cantFilas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ExisteUsuario(Usuarios usu)
        {
            int estado = 0;
            DAOUsuarios daoUsu = new DAOUsuarios();

            estado = daoUsu.BuscarUsuario(usu);

            if (estado == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool EsAdmin(Usuarios usu)
        {
            int estado = 0;
            DAOUsuarios daoUsu = new DAOUsuarios();

            estado = daoUsu.VerTipoUsuario(usu);

            if (estado == 1)
            {
                // es admin.
                return true;
            }
            else
            {
                //es usuario comun.
                return false;
            }

        }
    }
}
