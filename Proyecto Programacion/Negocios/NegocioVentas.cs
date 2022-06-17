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
    class NegocioVentas
    {
        //public DataTable getTabla()
        //{
        //    DaoVentas dao = new DaoVentas();
        //    return dao.getTablaVentas();
        //}
        //public DataTable getTablaPorID(int id)
        //{
        //    DaoVentas dao = new DaoVentas();
        //    return dao.getTablaVentasPorID(id);
        //}
        //public DataTable getListaVentas()
        //{
        //    DaoVentas dao = new DaoVentas();
        //    return dao.getListaVentas();
        //}

        //public Ventas get(int id)
        //{
        //    DaoVentas dao = new DaoVentas();
        //    Ventas Ven = new Ventas();
        //    Ven.IdPeliculas = id;
        //    return dao.getVentas(Ven);
        //}
        //public DataTable CrearTablaSession()
        //{
        //    DataTable tabla = new DataTable();
        //    tabla.Columns.Add("ID_Venta_V", typeof(int));
        //    tabla.Columns.Add("ID_Usuario_V", typeof(string));
        //    tabla.Columns.Add("Fecha_V", typeof(string));
        //    tabla.Columns.Add("Metodo_Pago_V", typeof(string));
        //    tabla.Columns.Add("Monto_Final_V", typeof(decimal));

        //    return tabla;
        //}
        //public bool EliminarVentas(int id)
        //{
        //    DaoVentas dao = new DaoVentas();
        //    Ventas Ven = new Ventas();
        //    Ven.IdVentas = id;
        //    int op = dao.EliminarVenta(Ven);
        //    if (op == 1)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public bool AgregarVenta(string ID_Venta_V, string ID_Usuario_V, string Fecha_V, string Metodo_Pago_V, decimal Monto_Final_V)
        //{
        //    int cantFilas = 0;
        //    DaoVentas daoVen = new DaoVentas();
        //    Ventas Ven = new Ventas();
        //    Ven.ID_Venta = ID_Venta_V;
        //    Ven.ID_Usuario = ID_Usuario_V;
        //    Ven.Fecha = Fecha_V;
        //    Ven.Metodo_Pago = Metodo_Pago_V;
        //    Ven.Monto_Final = Monto_Final_V;

        //    if (daoVen.ExisteVenta(Ven) == false)
        //    {
        //        cantFilas = daoVen.AgregarVenta(Ven);
        //    }
        //    if (cantFilas == 1)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
