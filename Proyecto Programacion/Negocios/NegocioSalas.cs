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
        //public DataTable getTabla()
        //{
        //    DaoSalas dao = new DaoSalas();
        //    return dao.getTablaSalas();
        //}
        //public DataTable getTablaPorID(int id)
        //{
        //    DaoSalas dao = new DaoSalas();
        //    return dao.getTablaSalasPorID(id);
        //}
        //public DataTable getListaNegocios()
        //{
        //    DaoSalas dao = new DaoSalas();
        //    return dao.getListaSalas();
        //}

        //public Salas get(int id)
        //{
        //    DaoSalas dao = new DaoSalas();
        //    Salas Sal = new Salas();
        //    Sal.IdSalas = id;
        //    return dao.getSalas(Sal);
        //}
        //public DataTable CrearTablaSession()
        //{
        //    DataTable tabla = new DataTable();
        //    tabla.Columns.Add("ID_Sala_S", typeof(string));
        //    tabla.Columns.Add("ID_Complejo_S", typeof(string));
        //    tabla.Columns.Add("Total_Asientos_S", typeof(int));
        //    tabla.Columns.Add("Estado_S", typeof(bool));

        //    return tabla;
        //}
        //public bool EliminarPelicula(int id)
        //{
        //    DaoSalas dao = new DaoSalas();
        //    Salas Sal = new Salas();
        //    Sal.IdSala = id;
        //    int op = dao.EliminarSala(Sal);
        //    if (op == 1)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public bool AgregarPelicula(string ID_Sala_S, string ID_Complejo_S, int Total_Asientos_S, bool Estado_S)
        //{
        //    int cantFilas = 0;
        //    DaoSalas daoSal = new DaoSalas();
        //    Salas Sal = new Salas();
        //    Sal.ID_Sala = ID_Sala_S;
        //    Sal.ID_Complejo = ID_Complejo_S;
        //    Sal.Total_Asientos = Total_Asientos_S;
        //    Sal.Estado = Estado_S;

        //    if (daoSal.ExisteSala(Sal) == false)
        //    {
        //        cantFilas = daoSal.AgregarSala(Sal);
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
