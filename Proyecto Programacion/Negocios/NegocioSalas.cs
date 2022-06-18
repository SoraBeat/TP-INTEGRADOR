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
    public class NegocioSalas
    {
        public DataTable getTabla()
        {
             DAOSalas dao= new DAOSalas();
            return dao.getTablaSala();
        }
        public DataTable getTablaPorID(string id)
        {
            DAOSalas dao = new DAOSalas();
            return dao.getTablaSalaPorID(id);
        }
        public DataTable getTablaPorComplejo(string id)
        {
            DAOSalas dao = new DAOSalas();
            return dao.getTablaSalaPorComplejo(id);
        }
        public DataTable getTablaPorAsientos(string id)
        {
            DAOSalas dao = new DAOSalas();
            return dao.getTablaSalaPorAsientos(id);
        }
        public DataTable getTablaPorEstado(string id)
        {
            DAOSalas dao = new DAOSalas();
            return dao.getTablaSalaPorEstado(id);
        }
        public Salas get(string id)
        {
            DAOSalas dao = new DAOSalas();
            Salas Sal = new Salas();
            Sal.IDSala = id;
            return dao.getSala(Sal);
        }

        public bool EliminarSala(string id,string complejo)
        {
            DAOSalas dao = new DAOSalas();
            Salas Sal = new Salas();
            Sal.IDSala = id;
            Sal.IDComplejo = complejo;
            int op = dao.EliminarSala(Sal);
            if (op == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AgregarSala(Salas sala)
        {
            int cantFilas = 0;
            DAOSalas daoSal = new DAOSalas();


            if (daoSal.ExisteSala(sala) == false)
            {
                cantFilas = daoSal.AgregarSala(sala);
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
        public bool ModificarSala(Salas sala)
        {
            int cantFilas = 0;
            DAOSalas daoSal = new DAOSalas();

            cantFilas = daoSal.ModificarSala(sala);

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
