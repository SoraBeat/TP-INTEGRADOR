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
    public class NegocioAsientos
    {
        public DataTable getListaAsientos()
        {
            DAOAsientos dao = new DAOAsientos();
            return dao.getTablaAsientos();
        }
        public DataTable getListaPorID(string id)
        {
            DAOAsientos dao = new DAOAsientos();
            return dao.getTablaAsientosPorID(id);
        }
        public DataTable getListaPorIDSala(string id)
        {
            DAOAsientos dao = new DAOAsientos();
            return dao.getTablaAsientosPorIDSala(id);
        }
        public DataTable getListaPorIDComplejo(string id)
        {
            DAOAsientos dao = new DAOAsientos();
            return dao.getTablaAsientosPorIDComplejo(id);
        }
        public DataTable getListaAsientosPorEstado(string estado)
        {
            DAOAsientos dao = new DAOAsientos();
            return dao.getTablaAsientosPorEstado(estado);
        }

        public Asientos get(string id)
        {
            DAOAsientos dao = new DAOAsientos();
            Asientos Asi = new Asientos();
            Asi.IDAsiento = id;
            return dao.getAsiento(Asi);
        }
        public DataTable CrearTablaSession()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("ID_Asiento_A", typeof(string));
            tabla.Columns.Add("ID_Sala_A", typeof(string));
            tabla.Columns.Add("ID_Complejo_A", typeof(string));

            return tabla;
        }
        public bool EliminarAsiento(string idAsiento, string idSala, string idComplejo)
        {
            DAOAsientos dao = new DAOAsientos();
            Asientos Asi = new Asientos();
            Asi.IDAsiento = idAsiento;
            Asi.IDSala = idSala;
            Asi.IDComplejo = idComplejo;
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
        public bool AgregarAsiento(string idAsiento, string idSala, string idComplejo)
        {
            int cantFilas = 0;
            DAOAsientos daoAsi = new DAOAsientos();
            Asientos Asi = new Asientos();
            Asi.IDAsiento = idAsiento;
            Asi.IDSala = idSala;
            Asi.IDComplejo = idComplejo;

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
        public bool ModificarAsiento(Asientos asi)
        {
            int cantFilas = 0;
            DAOAsientos daoAsi = new DAOAsientos();

            cantFilas = daoAsi.ModificarAsiento(asi);

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
