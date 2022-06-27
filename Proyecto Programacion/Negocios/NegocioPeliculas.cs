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
        public DataTable getListaVentas()
        {
            DAOPeliculas dao = new DAOPeliculas();
            return dao.getListaVentas();
        }
        public DataTable getNombrePelicula(string id)
        {
            DAOPeliculas dao = new DAOPeliculas();
            return dao.getNombrePelicula(id);
        }
        
        public DataTable getListaPeliculas2()
        {
            DAOPeliculas dao = new DAOPeliculas();
            return dao.getTablaPeliculas2();
        }
        public DataTable getListaPeliculas()
        {
            DAOPeliculas dao = new DAOPeliculas();
            return dao.getTablaPeliculas();
        }
        public DataTable getListaPeliculasCompleto()
        {
            DAOPeliculas dao = new DAOPeliculas();
            return dao.getListaPeliculasCompleto();
        }
        
        public DataTable getListaPeliculasComplejos(string consulta)
        {
            DAOPeliculas dao = new DAOPeliculas();
            return dao.getTablaPeliculasComplejos(consulta);
        }

        public DataTable getListaPeliculas2D()
        {
            DAOPeliculas dao = new DAOPeliculas();
            return dao.getTablaPeliculas2D();
        }

        public DataTable getListaPeliculas3D()
        {
            DAOPeliculas dao = new DAOPeliculas();
            return dao.getTablaPeliculas3D();
        }

        public DataTable getListaPeliculas4D()
        {
            DAOPeliculas dao = new DAOPeliculas();
            return dao.getTablaPeliculas4D();
        }

        public DataTable getListaPeliculasSubtitulada()
        {
            DAOPeliculas dao = new DAOPeliculas();
            return dao.getTablaPeliculasSubtitulada();
        }

        public DataTable getListaPeliculasEspanol()
        {
            DAOPeliculas dao = new DAOPeliculas();
            return dao.getTablaPeliculasEspanol();
        }

        public DataTable getListaPeliculasPorID(string campo)
        {
            DAOPeliculas dao = new DAOPeliculas();
            return dao.getTablaPeliculaPorID(campo);
        }

        public DataTable getListaPeliculasPorTitulo(string campo)
        {
            DAOPeliculas dao = new DAOPeliculas();
            return dao.getTablaPeliculaPorTitulo(campo);
        }

        public DataTable getListaPeliculasPorDescripcion(string campo)
        {
            DAOPeliculas dao = new DAOPeliculas();
            return dao.getTablaPeliculaPorDescripcion(campo);
        }

        public DataTable getListaPeliculasPorDuracion(string campo)
        {
            DAOPeliculas dao = new DAOPeliculas();
            return dao.getTablaPeliculaPorDuracion(campo);
        }

        public DataTable getListaPeliculasPorClasificacion(string campo)
        {
            DAOPeliculas dao = new DAOPeliculas();
            return dao.getTablaPeliculaPorClasificacion(campo);
        }

        public DataTable getListaPeliculasPorGenero(string campo)
        {
            DAOPeliculas dao = new DAOPeliculas();
            return dao.getTablaPeliculaPorGenero(campo);
        }


        public DataTable getListaPeliculasPorPortada(string campo)
        {
            DAOPeliculas dao = new DAOPeliculas();
            return dao.getTablaPeliculaPorPortada(campo);
        }

        public DataTable getListaPeliculasPorEstado(string campo)
        {
            DAOPeliculas dao = new DAOPeliculas();
            return dao.getTablaPeliculaPorEstado(campo);
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

        public bool AgregarPelicula(Peliculas Pel)
        {
            int cantFilas = 0;
            DAOPeliculas daoPel = new DAOPeliculas();

            cantFilas = daoPel.AgregarPeliculas(Pel);

            if (cantFilas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ModificarPelicula(Peliculas com)
        {
            int cantFilas = 0;
            DAOPeliculas daoCom = new DAOPeliculas();

            cantFilas = daoCom.ModificarPeliculas(com);

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
