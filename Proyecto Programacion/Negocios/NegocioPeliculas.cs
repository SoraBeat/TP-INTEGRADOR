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
        //public DataTable getTabla()
        //{
        //    DaoPeliculas dao = new DaoPeliculas();
        //    return dao.getTablaPeliculas();
        //}
        //public DataTable getTablaPorID(int id)
        //{
        //    DaoPeliculas dao = new DaoPeliculas();
        //    return dao.getTablaPeliculasPorID(id);
        //}
        //public DataTable getListaPeliculas()
        //{
        //    DaoPeliculas dao = new DaoPeliculas();
        //    return dao.getListaPeliculas();
        //}

        //public Peliculas get(int id)
        //{
        //    DaoPeliculas dao = new DaoPeliculas();
        //    Peliculas pel = new Peliculas();
        //    pel.IdPeliculas = id;
        //    return dao.getPeliculas(pel);
        //}
        //public DataTable CrearTablaSession()
        //{
        //    DataTable tabla = new DataTable();
        //    tabla.Columns.Add("ID_Pelicula_P", typeof(string));
        //    tabla.Columns.Add("Titulo_P", typeof(string));
        //    tabla.Columns.Add("Descripcion_P", typeof(string));
        //    tabla.Columns.Add("Duracion_P", typeof(string));
        //    tabla.Columns.Add("Clasificacion_P", typeof(string));
        //    tabla.Columns.Add("Genero_P", typeof(string));
        //    tabla.Columns.Add("Formato_P ", typeof(string));
        //    tabla.Columns.Add("Estado_P", typeof(bool));
        //    return tabla;
        //}
        //public bool EliminarPelicula(int id)
        //{
        //    DaoPeliculas dao = new DaoPeliculas();
        //    Peliculas pel = new Peliculas();
        //    pel.IdPelicula = id;
        //    int op = dao.EliminarPelicula(pel);
        //    if (op == 1)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public bool AgregarPelicula(string ID_Pelicula, string Titulo, string Descripcion, string Duracion, string Clasificacion, string Genero, string Formato, bool Estado)
        //{
        //    int cantFilas = 0;
        //    DaoPeliculas daopel = new DaoPeliculas();
        //    Peliculas pel = new Peliculas();
        //    pel.ID_Pelicula = ID_Pelicula;
        //    pel.Titulo = Titulo;
        //    pel.Descripcion = Descripcion;
        //    pel.Duracion = Duracion;
        //    pel.Clasificacion = Clasificacion;
        //    pel.Genero = Genero;
        //    pel.Formato = Formato;
        //    pel.Estado = Estado;
        //    if (daopel.ExistePelicula(pel) == false)
        //    {
        //        cantFilas = daopel.AgregarSucursal(pel);
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
