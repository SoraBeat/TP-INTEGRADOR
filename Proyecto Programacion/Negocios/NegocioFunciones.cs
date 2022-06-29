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
            DAOFunciones dao = new DAOFunciones();
            return dao.getTablaFuncion();
        }
        public DataTable getTablaPorID(string id)
        {
            DAOFunciones dao = new DAOFunciones();
            return dao.getTablaFuncionPorID(id);
        }

        public DataTable getTablaPorID2(string idPelicula, string idComplejo, string Formato, string Idioma, string Fecha, string Horario)
        {
            DAOFunciones dao = new DAOFunciones();
            return dao.getTablaFuncionPorID2(idPelicula, idComplejo, Formato, Idioma, Fecha, Horario);
        }

        public DataTable getTablaPorFormato(string id)
        {
            DAOFunciones dao = new DAOFunciones();
            return dao.getTablaFuncionPorFormato(id);
        }

        public DataTable getTablaPorPelicula(string id)
        {
            DAOFunciones dao = new DAOFunciones();
            return dao.getTablaFuncionPorPelicula(id);
        }
        public DataTable getTablaPorSala(string id)
        {
            DAOFunciones dao = new DAOFunciones();
            return dao.getTablaFuncionPorSala(id);
        }
        public DataTable getTablaPorComplejo(string id)
        {
            DAOFunciones dao = new DAOFunciones();
            return dao.getTablaFuncionPorComplejo(id);
        }
        public DataTable getTablaPorFecha(string id)
        {
            DAOFunciones dao = new DAOFunciones();
            return dao.getTablaFuncionPorFecha(id);
        }

        public DataTable getTablaPorFecha2(string idPelicula, string idcomplejo, string formato, string idioma)
        {
            DAOFunciones dao = new DAOFunciones();
            return dao.getTablaFuncionPorFecha2(idPelicula, idcomplejo, formato, idioma);
        }
        public DataTable getTablaPorHorario(string id)
        {
            DAOFunciones dao = new DAOFunciones();
            return dao.getTablaFuncionPorHorario(id);
        }

        public DataTable getTablaPorHorario2(string idPelicula, string idcomplejo, string formato, string idioma, string fecha)
        {
            DAOFunciones dao = new DAOFunciones();
            return dao.getTablaFuncionPorHorario2(idPelicula, idcomplejo, formato, idioma, fecha);
        }
        public DataTable getTablaPorIdioma(string id)
        {
            DAOFunciones dao = new DAOFunciones();
            return dao.getTablaFuncionPorIdioma(id);
        }
        public DataTable getTablaPorPrecio(string id)
        {
            DAOFunciones dao = new DAOFunciones();
            return dao.getTablaFuncionPorPrecio(id);
        }
        public DataTable getTablaPorFormatoid(string idPelicula, string idComplejo)
        {
            DAOFunciones dao = new DAOFunciones();
            return dao.getTablaFuncionPorIDformatos(idPelicula, idComplejo);
        }
        public DataTable getTablaPorFuncionid(string idFuncion)
        {
            DAOFunciones dao = new DAOFunciones();
            return dao.getTablaFuncionPorIDfuncion(idFuncion);
        }

        public DataTable getTablaPoridioma(string IDpelicula, string IDcomplejo, string formato)
        {
            DAOFunciones dao = new DAOFunciones();
            
            return dao.getTablaFuncionPorIDidioma(IDpelicula,IDcomplejo,formato);
        }

        public DataTable getTablaPorComplejos(string id)
        {
            DAOFunciones dao = new DAOFunciones();
            return dao.getTablaFuncionPorIDcomplejo(id);
        }
        public DataTable getTablaPorEstado(string id)
        {
            DAOFunciones dao = new DAOFunciones();
            return dao.getTablaFuncionPorEstado(id);
        }
        public DataTable getTablaPrecioPorID(string id)
        {
            DAOFunciones dao = new DAOFunciones();
            return dao.getTablaPrecioPorID(id);
        }

        public bool EliminarFuncion(string id)
        {
            DAOFunciones dao = new DAOFunciones();
            Funciones funcion = new Funciones();
            funcion.IdFuncion = id;
            int op = dao.EliminarFuncion(funcion);
            if (op == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AgregarFuncion(Funciones funcion)
        {
            int cantFilas = 0;
            DAOFunciones dao = new DAOFunciones();


            if (dao.ExisteFuncion(funcion) == false)
            {
                cantFilas = dao.AgregarFuncion(funcion);
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
        public bool ModificarFuncion(Funciones funcion)
        {
            int cantFilas = 0;
            DAOFunciones dao = new DAOFunciones();

            cantFilas = dao.ModificarFuncion(funcion);

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
