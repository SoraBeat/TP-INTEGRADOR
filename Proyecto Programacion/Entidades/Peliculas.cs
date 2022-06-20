using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Peliculas
    {
        private string idPelicula;
        private string tituloPelicula;
        private string descripcionPelicula;
        private string duracionPelicula;
        private string clasificacionPelicula;
        private string generoPelicula;
        private string formatoPelicula;
        private string portadaPelicula;
        private bool estadoPelicula;

        public Peliculas() { }

        public string ID_Pelicula { get => idPelicula; set => idPelicula = value; }
        public string Titulo { get => tituloPelicula; set => tituloPelicula = value; }
        public string Descripcion { get => descripcionPelicula; set => descripcionPelicula = value; }
        public string Duracion { get => duracionPelicula; set => duracionPelicula = value; }
        public string Clasificacion { get => clasificacionPelicula; set => clasificacionPelicula = value; }
        public string Genero { get => generoPelicula; set => generoPelicula = value; }
        public string Formato { get => formatoPelicula; set => formatoPelicula = value; }
        public string Portada { get => portadaPelicula; set => portadaPelicula = value; }
        public bool Estado { get => estadoPelicula; set => estadoPelicula = value; }
    }
}
