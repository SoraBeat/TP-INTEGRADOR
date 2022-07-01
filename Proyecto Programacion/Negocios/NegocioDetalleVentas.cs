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
    public class NegocioDetalleVentas
    {
        public DataTable getListaDetalleVentas()
        {
            DAODetalleVentas dao = new DAODetalleVentas();
            return dao.getTablaDetalleVentas();
        }
        public DataTable getListaPorIDDetalleVenta(string campo)
        {
            DAODetalleVentas dao = new DAODetalleVentas();
            return dao.getTablaDetalleVentasPorIDDetalleVenta(campo);
        }
        public DataTable getListaPorIDVenta(string campo)
        {
            DAODetalleVentas dao = new DAODetalleVentas();
            return dao.getTablaDetalleVentasPorIDVenta(campo);
        }
        public DataTable getListaPorIDFuncion(string campo)
        {
            DAODetalleVentas dao = new DAODetalleVentas();
            return dao.getTablaDetalleVentasPorIDFuncion(campo);
        }
        public DataTable getListaPorIDSala(string campo)
        {
            DAODetalleVentas dao = new DAODetalleVentas();
            return dao.getTablaDetalleVentasPorIDSala(campo);
        }
        public DataTable getListaPorIDComplejo(string campo)
        {
            DAODetalleVentas dao = new DAODetalleVentas();
            return dao.getTablaVentasPorIDComplejo(campo);
        }
        public DataTable getListaPorCantidad(string campo)
        {
            DAODetalleVentas dao = new DAODetalleVentas();
            return dao.getTablaDetalleVentasPorCantidad(campo);
        }
        public DataTable getListaPorPrecio(string campo)
        {
            DAODetalleVentas dao = new DAODetalleVentas();
            return dao.getTablaDetalleVentasPorPrecio(campo);
        }
        public int buscarUltimoIDDetalleVenta()
        {
            DAODetalleVentas dao = new DAODetalleVentas();
            return dao.buscarUltimoIDDetalleVentas();
        }

        public bool AgregarDetalleDeVentas(DetalleVentas dv)
        {
            int cantFilas = 0;
            DAODetalleVentas DaoDVentas = new DAODetalleVentas();

            cantFilas = DaoDVentas.AgregarDetalleVentas(dv);

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
