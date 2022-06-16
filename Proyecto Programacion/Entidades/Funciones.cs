using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Funciones
    {
        private int idFuncion;
        private int idPelicula;
        private int idSala;
        private int idComplejo;
        private string fechaFuncion;
        private string horarioFuncion;
        private string idiomaFuncion;
        private int precioFuncion;
        private int estadoFuncion;
        public Funciones() { }

        public int IDFuncion { get => idFuncion; set => idFuncion = value; }
        public int IDPelicula { get => idPelicula; set => idPelicula = value; }
        public int IDSala { get => idSala; set => idSala = value; }
        public int IDComplejo { get => idComplejo; set => idComplejo = value; }
        public string FechaFuncion { get => fechaFuncion; set => fechaFuncion = value; }
        public string HorarioFuncion { get => horarioFuncion; set => horarioFuncion = value; }
        public string IdiomaFuncion { get => idiomaFuncion; set => idiomaFuncion = value; }
        public int PrecioFuncion { get => precioFuncion; set => precioFuncion = value; }
        public int EstadoFuncion { get => estadoFuncion; set => estadoFuncion = value; }
    }
}
