using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Peliculas
    {
        private int idPelicula;
        private string tituloPelicula;
        private string descripcionPelicula;
        private string duracionPelicula;
        private string clasificacionPelicula;
        private string generoPelicula;
        private string formatoPelicula;
        private string portadaPelicula;
        private int estadoPelicula;

        public Peliculas() { }

        public int IDPelicula { get => idPelicula; set => idPelicula = value; }
        public string TituloPelicula { get => tituloPelicula; set => tituloPelicula = value; }
        public string DescripcionPelicula { get => descripcionPelicula; set => descripcionPelicula = value; }
        public string DuracionPelicula { get => duracionPelicula; set => duracionPelicula = value; }
        public string ClasificacionPelicula { get => clasificacionPelicula; set => clasificacionPelicula = value; }
        public string GeneroPelicula { get => generoPelicula; set => generoPelicula = value; }
        public string FormatoPelicula { get => formatoPelicula; set => formatoPelicula = value; }
        public string PortadaPelicula { get => portadaPelicula; set => portadaPelicula = value; }
        public int EstadoPelicula { get => estadoPelicula; set => estadoPelicula = value; }
    }
}
