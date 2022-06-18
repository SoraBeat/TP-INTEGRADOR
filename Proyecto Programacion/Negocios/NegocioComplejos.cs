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
        public DataTable getListaComplejos()
        {
            DAOComplejos dao = new DAOComplejos();
            return dao.getTablaComplejo();
        }
        public DataTable getListaComplejosPorID(string campo)
        {
            DAOComplejos dao = new DAOComplejos();
            return dao.getTablaComplejoPorID(campo);
        }
        public DataTable getListaComplejosPorNombre(string campo)
        {
            DAOComplejos dao = new DAOComplejos();
            return dao.getTablaComplejoPorNombre(campo);
        }
        public DataTable getListaComplejosPorDireccion(string campo)
        {
            DAOComplejos dao = new DAOComplejos();
            return dao.getTablaComplejoPorDireccion(campo);
        }
        public DataTable getListaComplejosPorTelefono(string campo)
        {
            DAOComplejos dao = new DAOComplejos();
            return dao.getTablaComplejoPorTelefono(campo);
        }
        public DataTable getListaComplejosPorEmail(string campo)
        {
            DAOComplejos dao = new DAOComplejos();
            return dao.getTablaComplejoPorEmail(campo);
        }
        public bool EliminarComplejo(string id)
        {
            DAOComplejos dao = new DAOComplejos();
            Complejos com = new Complejos();
            com.ID_Complejo = id;
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
        public bool AgregarComplejo(Complejos com)
        {
            int cantFilas = 0;
            DAOComplejos daoCom = new DAOComplejos();

            cantFilas = daoCom.AgregarComplejo(com);

            if (cantFilas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ModificarComplejo(Complejos com)
        {
            int cantFilas = 0;
            DAOComplejos daoCom = new DAOComplejos();

            cantFilas = daoCom.ModificarComplejo(com);

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
