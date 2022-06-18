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
        public DataTable getTabla()
        {
            DAOUsuarios dao = new DAOUsuarios();
            return dao.getTablaUsuarios();
        }
        public DataTable getTablaPorID(int id)
        {
            DAOUsuarios dao = new DAOUsuarios();
            return dao.getTablaUsuariosPorID(id);
        }
        public DataTable getListaUsuarios()
        {
            DAOUsuarios dao = new DAOUsuarios();
            return dao.getTablaUsuarios();
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

    }
}
