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
            DaoUsuario dao = new DaoUsuario();
            return dao.getTablaUsuario();
        }
        public DataTable getTablaPorID(int id)
        {
            DaoUsuario dao = new DaoUsuario();
            return dao.getTablaUsuariosPorID(id);
        }
        public DataTable getListaPeliculas()
        {
            DaoUsuario dao = new DaoUsuario();
            return dao.getListaUsuarios();
        }

        public Usuarios get(int id)
        {
            DaoUsuario dao = new DaoUsuario();
            Usuarios Usu = new Usuarios();
            Usu.IdUsuario = id;
            return dao.getUsuario(Usu);
        }
        public DataTable CrearTablaSession()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("ID_Usuario_U", typeof(int));
            tabla.Columns.Add("Nombre_U", typeof(string));
            tabla.Columns.Add("Apellido_U", typeof(string));
            tabla.Columns.Add("DNI_U", typeof(string));
            tabla.Columns.Add("Telefono_U", typeof(string));
            tabla.Columns.Add("Email_U", typeof(string));
            tabla.Columns.Add("Contraseña_U", typeof(string));
            tabla.Columns.Add("Tipo_Usuario_U", typeof(bool));
            return tabla;
        }
        public bool EliminarUsuario(int id)
        {
            DaoUsuario dao = new DaoUsuario();
            Usuarios Usu = new Usuarios();
            Usu.IdUsuario = id;
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
        public bool AgregarPelicula(int ID_Usuario_U, string Nombre_U, string Apellido_U, string DNI_U, string Telefono_U, string Email_U, string Contraseña_U, bool Tipo_Usuario_U)
        {
            int cantFilas = 0;
            DaoUsuarios daoUsu = new DaoUsuarios();
            Usuarios Usu = new Usuarios();
            Usu.ID_Usuario = ID_Usuario_U;
            Usu.Nombre = Nombre_U;
            Usu.Apellido = Apellido_U;
            Usu.DNI = DNI_U;
            Usu.Telefono = Telefono_U;
            Usu.Email = Email_U;
            Usu.Contraseña = Contraseña_U;
            Usu.Tipo_Usuario = Tipo_Usuario_U;
            if (daoUsu.ExisteUsuario(Usu) == false)
            {
                cantFilas = daoUsu.AgregarUsuario(Usu);
            }
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
