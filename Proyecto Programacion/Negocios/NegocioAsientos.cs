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
    class NegocioAsientos
    {
        public DataTable getTabla()
        {
            DaoAsientos dao = new DaoAsientos();
            return dao.getTablaAsientos();
        }
        public DataTable getTablaPorID(int id)
        {
            DaoAsientos dao = new DaoAsientos();
            return dao.getTablaAsientosPorID(id);
        }
        public DataTable getListaPeliculas()
        {
            DaoAsientos dao = new DaoAsientos();
            return dao.getListaAsientos();
        }

        public Asientos get(int id)
        {
            DaoAsientos dao = new DaoAsientos();
            Asientos Asi = new Asientos();
            Asi.IdAsiento = id;
            return dao.getAsientos(Asi);
        }
        public DataTable CrearTablaSession()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("ID_Asiento_A", typeof(string));
            tabla.Columns.Add("ID_Sala_A", typeof(string));
            tabla.Columns.Add("ID_Complejo_A", typeof(string));

            return tabla;
        }
        public bool EliminarPelicula(int id)
        {
            DaoAsientos dao = new DaoAsientos();
            Asientos Asi = new Asientos();
            Asi.IdAsientos= id;
            int op = dao.EliminarAsiento(Asi);
            if (op == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AgregarPelicula(string ID_Asiento_A, string ID_Sala_A, string ID_Complejo_A)
        {
            int cantFilas = 0;
            DaoAsientos daoAsi = new DaoAsientos();
            Asientos Asi = new Asientos();
            Asi.ID_Asiento = ID_Asiento_A;
            Asi.ID_Sala = ID_Sala_A;
            Asi.ID_Complejo = ID_Complejo_A;

            if (daoAsi.ExisteAsiento(Asi) == false)
            {
                cantFilas = daoAsi.AgregarAsiento(Asi);
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
