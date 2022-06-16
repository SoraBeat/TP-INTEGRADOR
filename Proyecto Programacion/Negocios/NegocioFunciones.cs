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
    public class NegocioFunciones
    {
        public DataTable getTabla()
        {
            DaoFunciones dao = new DaoFunciones();
            return dao.getTablaFunciones();
        }
        public DataTable getTablaPorID(int id)
        {
            DaoFunciones dao = new DaoFunciones();
            return dao.getTablaFuncionesPorID(id);
        }
        public DataTable getListaFunciones()
        {
            DaoFunciones dao = new DaoFunciones();
            return dao.getListaFunciones();
        }

        public Funciones get(int id)
        {
            DaoFunciones dao = new DaoFunciones();
            Funciones Fun = new Funciones();
            Fun.IdFunciones = id;
            return dao.getFunciones(Fun);
        }
        public DataTable CrearTablaSession()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("ID_Funcion_F", typeof(string));
            tabla.Columns.Add("ID_Pelicula_F", typeof(string));
            tabla.Columns.Add("ID_Sala_F", typeof(string));
            tabla.Columns.Add("ID_Complejo_F", typeof(string));
            tabla.Columns.Add("Fecha_F", typeof(string));
            tabla.Columns.Add("Horario_F", typeof(string));
            tabla.Columns.Add("Idioma_F", typeof(string));
            tabla.Columns.Add("Precio_F", typeof(decimal));
            tabla.Columns.Add("Estado_F", typeof(bool));
            return tabla;
        }
        public bool EliminarFunciones(int id)
        {
            DaoFunciones dao = new DaoFunciones();
            Funciones Fun = new Funciones();
            Fun.IdFunciones = id;
            int op = dao.EliminarFunciones(Fun);
            if (op == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AgregarFunciones(string ID_Funcion_F, string ID_Pelicula_F, string ID_Sala_F, string ID_Complejo_F, string Fecha_F, string Horario_F, string Idioma_F, decimal Precio_F, bool Estado_F)
        {
            int cantFilas = 0;
            DaoFunciones daoFun= new DaoFunciones();
            Funciones Fun = new Funciones();
            Fun.ID_Funcion = ID_Funcion_F;
            Fun.ID_Pelicula = ID_Pelicula_F;
            Fun.ID_Sala = ID_Sala_F;
            Fun.ID_Complejo = ID_Complejo_F;
            Fun.Fecha = Fecha_F;
            Fun.Horario = Horario_F;
            Fun.Idioma = Idioma_F;
            Fun.Precio = Precio_F;
            Fun.Estado = Estado_F;

            if (daoFun.ExisteFuncione(Fun) == false)
            {
                cantFilas = daoFun.AgregarFuncion(Fun);
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
