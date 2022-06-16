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
        public DataTable getTabla()
        {
            DaoDetalleVentas dao = new DaoDetalleVentas();
            return dao.getTablaDetalleVentas();
        }
        public DataTable getTablaPorID(int id)
        {
            DaoDetalleVentas dao = new DaoDetalleVentas();
            return dao.getTablaDetalleVentasPorID(id);
        }
        public DataTable getListaDetalleVentas()
        {
            DaoDetalleVentas dao = new DaoDetalleVentas();
            return dao.getListaDetalleVentas();
        }

        public DetalleVentas get(int id)
        {
            DaoDetalleVentas dao = new DaoDetalleVentas();
            DetalleVentas Det = new DetalleVentas();
            Det.IdDetalleVentas = id;
            return dao.getDetalleVentas(Det);
        }
        public DataTable CrearTablaSession()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("ID_DetalleVenta_DV", typeof(int));
            tabla.Columns.Add("ID_Venta_DV", typeof(int));
            tabla.Columns.Add("ID_Funcion_DV", typeof(string));
            tabla.Columns.Add("ID_Sala_DV", typeof(string));
            tabla.Columns.Add("ID_Complejo_DV", typeof(string));
            tabla.Columns.Add("Cantidad_DV", typeof(int));
            tabla.Columns.Add("Precio_DV", typeof(decimal));

            return tabla;
        }
        public bool EliminarDetalleVentas(int id)
        {
            DaoDetalleVentas dao = new DaoDetalleVentas();
            DetalleVentas Det = new DetalleVentas();
            Det.IdDetalleVentas = id;
            int op = dao.EliminarDetalleVentas(Det);
            if (op == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AgregarDetalleVentas(int ID_DetalleVenta_DV, int ID_Venta_DV, string ID_Funcion_DV, string ID_Sala_DV, string ID_Complejo_DV, int Cantidad_DV, decimal Precio_DV)
        {
            int cantFilas = 0;
            DaoDetalleVentas daoDet = new DaoDetalleVentas();
            DetalleVentas Det = new DetalleVentas();
            Det.ID_Pelicula = ID_DetalleVenta_DV;
            Det.Titulo = ID_Venta_DV;
            Det.Descripcion = ID_Funcion_DV;
            Det.Duracion = ID_Sala_DV;
            Det.Clasificacion = ID_Complejo_DV;
            Det.Genero = Cantidad_DV;
            Det.Formato = Precio_DV;
            
            if (daoDet.ExisteDetalleVentas(Det) == false)
            {
                cantFilas = daoDet.AgregarDetalleVentas(Det);
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
