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
        //public DataTable getTabla()
        //{
        //    DaoAsientosComprados dao = new DaoAsientosComprados();
        //    return dao.getTablaAsientosComprados();
        //}
        //public DataTable getTablaPorID(int id)
        //{
        //    DaoAsientosComprados dao = new DaoAsientosComprados();
        //    return dao.getTablaAsientosCompradosPorID(id);
        //}
        //public DataTable getListaAsientosComprados()
        //{
        //    DaoAsientosComprados dao = new DaoAsientosComprados();
        //    return dao.getListaAsientosComprados();
        //}

        //public AsientosComprados get(int id)
        //{
        //    DaoAsientosComprados dao = new DaoAsientosComprados();
        //    AsientosComprados Asi = new AsientosComprados();
        //    Asi.IdAsientosComprados = id;
        //    return dao.getAsientosComprados(Asi);
        //}
        //public DataTable CrearTablaSession()
        //{
        //    DataTable tabla = new DataTable();
        //    tabla.Columns.Add("ID_Asiento_AC", typeof(string));
        //    tabla.Columns.Add("ID_Venta_AC", typeof(int));
        //    tabla.Columns.Add("ID_DetalleVenta_AC", typeof(int));
        //    tabla.Columns.Add("ID_Funcion_AC", typeof(string));
        //    tabla.Columns.Add("ID_Sala_AC", typeof(string));
        //    tabla.Columns.Add("ID_Complejo_AC", typeof(string));

        //    return tabla;
        //}
        //public bool EliminarAsientosComprados(int id)
        //{
        //    DaoAsientosComprados dao = new DaoAsientosComprados();
        //    AsientosComprados Asi= new AsientosComprados();
        //    Asi.IdAsientosComprados = id;
        //    int op = dao.EliminarAsientosComprados(Asi);
        //    if (op == 1)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public bool AgregarAsientosComprados(string ID_Asiento_AC, int ID_Venta_AC, int ID_DetalleVenta_AC, string ID_Funcion_AC, string ID_Sala_AC, string ID_Complejo_AC)
        //{
        //    int cantFilas = 0;
        //    DaoAsientosComprados daoAsi = new DaoAsientosComprados();
        //    AsientosComprados Asi= new AsientosComprados();
        //    Asi.ID_Asiento = ID_Asiento_AC;
        //    Asi.ID_Venta = ID_Venta_AC;
        //    Asi.ID_DetalleVenta = ID_DetalleVenta_AC;
        //    Asi.ID_Funcion = ID_Funcion_AC;
        //    Asi.ID_Sala = ID_Sala_AC;
        //    Asi.ID_Complejo = ID_Complejo_AC;

        //    if (daoAsi.ExisteAsientosComprado(Asi) == false)
        //    {
        //        cantFilas = daoAsi.AgregarAsientosComprados(Asi);
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
