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
    public class NegocioComplejos
    {
        public DataTable getTabla()
        {
            DaoComplejos dao = new DaoComplejos();
            return dao.getTablaComplejos();
        }
        public DataTable getTablaPorID(int id)
        {
            DaoComplejos dao = new DaoComplejos();
            return dao.getTablaComplejosPorID(id);
        }
        public DataTable getListaComplejos()
        {
            DaoComplejos dao = new DaoComplejos();
            return dao.getListaComplejos();
        }

        public Complejos get(int id)
        {
            DaoComplejos dao = new DaoComplejos();
            Complejos com = new Complejos();
            com.IdComplejos = id;
            return dao.getComplejos(com);
        }
        public DataTable CrearTablaSession()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("ID_Complejo_Co", typeof(string));
            tabla.Columns.Add("Nombre_Co", typeof(string));
            tabla.Columns.Add("Direccion_Co", typeof(string));
            tabla.Columns.Add("Telefono_Co", typeof(string));
            tabla.Columns.Add("Email_Co", typeof(string));
            return tabla;
        }
        public bool EliminarPelicula(int id)
        {
            DaoComplejo dao = new DaoComplejo();
            Complejo com = new Complejo();
            com.IdComplejo = id;
            int op = dao.EliminarComplejo(com);
            if (op == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AgregarComplejo(string ID_Complejo_Co, string Nombre_Co, string Direccion_Co, string Telefono_Co, string Email_Co)
        {
            int cantFilas = 0;
            DaoComplejo daoCom = new DaoComplejo();
            Complejo com = new Complejo();
            com.ID_Complejo = ID_Complejo_Co;
            com.Nombre = Nombre_Co;
            com.Direccion = Direccion_Co;
            com.Telefono = Telefono_Co;
            com.Email = Email_Co;
            if (daoCom.ExisteComplejo(com) == false)
            {
                cantFilas = daoCom.AgregarComplejo(com);
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
