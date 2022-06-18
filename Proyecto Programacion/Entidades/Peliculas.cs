using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Peliculas
    {
        private int ID_Pelicula;
        private string Titulo;
        private string Descripcion;
        private string Duracion;
        private string Clasificacion;
        private string Genero;
        private string Formato;
        private string Portada;
        private int Estado;

        public Peliculas() { }

        public int IDPelicula { get => ID_Pelicula; set => ID_Pelicula = value; }
        public string TituloPelicula { get => Titulo; set => Titulo = value; }
        public string DescripcionPelicula { get => Descripcion; set => Descripcion = value; }
        public string DuracionPelicula { get => Duracion; set => Duracion = value; }
        public string ClasificacionPelicula { get => Clasificacion; set => Clasificacion = value; }
        public string GeneroPelicula { get => Genero; set => Genero = value; }
        public string FormatoPelicula { get => Formato; set => Formato = value; }
        public string PortadaPelicula { get => Portada; set => Portada = value; }
        public int EstadoPelicula { get => Estado; set => Estado = value; }
    }
}
