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
    public class NegocioVentas
    {
        public DataTable getListaVentas()
        {
            DAOVentas dao = new DAOVentas();
            return dao.getTablaVentas();
        }
        public DataTable getListaPorIDVenta(string campo)
        {
            DAOVentas dao = new DAOVentas();
            return dao.getTablaVentasPorIDVenta(campo);
        }
        public DataTable getListaPorIDUsuario(string campo)
        {
            DAOVentas dao = new DAOVentas();
            return dao.getTablaVentasPorIDUsuario(campo);
        }
        public DataTable getListaPorFechaVenta(string campo)
        {
            DAOVentas dao = new DAOVentas();
            return dao.getTablaVentasPorFecha(campo);
        }
        public DataTable getListaPorMetodoDePago(string campo)
        {
            DAOVentas dao = new DAOVentas();
            return dao.getTablaVentasPorMetodoDePago(campo);
        }
        public DataTable getListaPorMontoFinalMayorA(string campo)
        {
            DAOVentas dao = new DAOVentas();
            return dao.getTablaVentasPorMontoFinalMayorA(campo);
        }
        public DataTable getListaPorMontoFinalMenorA(string campo)
        {
            DAOVentas dao = new DAOVentas();
            return dao.getTablaVentasPorMontoFinalMenorA(campo);
        }
    }
}
