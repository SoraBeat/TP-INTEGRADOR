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
    public class NegocioAsientosComprados
    {
        public DataTable getTabla()
        {
            DAOAsientosComprados dao = new DAOAsientosComprados();
            return dao.getTablaAsientosComprados();
        }
        public DataTable getTablaPorID(string id)
        {
            DAOAsientosComprados dao = new DAOAsientosComprados();
            return dao.getTablaAsientosCompradosPorID(id);
        }
        public DataTable getTablaPorDetalleVenta(string id)
        {
            DAOAsientosComprados dao = new DAOAsientosComprados();
            return dao.getTablaAsientosCompradosPorDetalleVenta(id);
        }
        public DataTable getTablaPorVenta(string id)
        {
            DAOAsientosComprados dao = new DAOAsientosComprados();
            return dao.getTablaAsientosCompradosPorVenta(id);
        }
        public DataTable getTablaPorFuncion(string id)
        {
            DAOAsientosComprados dao = new DAOAsientosComprados();
            return dao.getTablaAsientosCompradosPorFuncion(id);
        }
        public DataTable getTablaPorSala(string id)
        {
            DAOAsientosComprados dao = new DAOAsientosComprados();
            return dao.getTablaAsientosCompradosPorSala(id);
        }
        public DataTable getTablaPorComplejo(string id)
        {
            DAOAsientosComprados dao = new DAOAsientosComprados();
            return dao.getTablaAsientosCompradosPorComplejo(id);
        }
        public DataTable getTablaPorEstado(string id)
        {
            DAOAsientosComprados dao = new DAOAsientosComprados();
            return dao.getTablaAsientosCompradosPorEstado(id);
        }
        public DataTable getTablaExisteAsiento(string idAsiento, string idFuncion)
        {
            DAOAsientosComprados dao = new DAOAsientosComprados();
            return dao.getTablaExisteAsiento(idAsiento, idFuncion);
        }
        public bool AgregarAsientosComprados(AsientosComprados asiCom)
        {
            int cantFilas = 0;
            DAOAsientosComprados DaoAsiCom = new DAOAsientosComprados();

            cantFilas = DaoAsiCom.AgregarAsientosComprados(asiCom);

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
