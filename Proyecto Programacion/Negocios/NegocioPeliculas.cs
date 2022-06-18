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
    public class NegocioPeliculas
    {

        public DataTable getListaPeliculas()
        {
            DAOPeliculas dao = new DAOPeliculas();
            return dao.getTablaPeliculas();
        }



        public DataTable CrearTablaSession()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("ID_Pelicula_P", typeof(string));
            tabla.Columns.Add("Titulo_P", typeof(string));
            tabla.Columns.Add("Descripcion_P", typeof(string));
            tabla.Columns.Add("Duracion_P", typeof(string));
            tabla.Columns.Add("Clasificacion_P", typeof(string));
            tabla.Columns.Add("Genero_P", typeof(string));
            tabla.Columns.Add("Formato_P ", typeof(string));
            tabla.Columns.Add("Estado_P", typeof(bool));
            return tabla;
        }
        public bool EliminarPelicula(string id)
        {
            DAOPeliculas dao = new DAOPeliculas();
            Peliculas pel= new Peliculas();
            pel.ID_Pelicula = id;
            int op = dao.EliminarPeliculas(pel);
            if (op == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AgregarPelicula(string ID_Pelicula, string Titulo, string Descripcion, string Duracion, string Clasificacion, string Genero, string Formato, int Estado)
        {
            int cantFilas = 0;
            DAOPeliculas daopel = new DAOPeliculas();
            Peliculas pel = new Peliculas();
            pel.ID_Pelicula = ID_Pelicula;
            pel.Titulo = Titulo;
            pel.Descripcion = Descripcion;
            pel.Duracion = Duracion;
            pel.Clasificacion = Clasificacion;
            pel.Genero = Genero;
            pel.Formato = Formato;
            pel.Estado = Estado;
            if (daopel.ExistePelicula(pel) == false)
            {
                cantFilas = daopel.AgregarPeliculas(pel);
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
