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
        public DataTable getListaVentas2()
        {
            DAOVentas dao = new DAOVentas();
            return dao.getTablaVentas2();
        }

        public DataTable getListaFechas(string Inicio, string Final)
        {
            DAOVentas dao = new DAOVentas();
            return dao.getTablaFecha(Inicio,Final);
        }

        public DataTable cantidadVentas()
        {
            DAOVentas dao = new DAOVentas();
            return dao.cantidadVentas();
        }
        public DataTable dineroGanado()
        {
            DAOVentas dao = new DAOVentas();
            return dao.dineroGanado();
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

        public int buscarUltimaVenta()
        {
            DAOVentas dao = new DAOVentas();
            return dao.buscarUltimaVenta();

        }


        public bool AgregarVenta(Ventas ven)
        {
            int cantFilas = 0;
            DAOVentas DaoVentas = new DAOVentas();

            cantFilas = DaoVentas.AgregarVentas(ven);

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

