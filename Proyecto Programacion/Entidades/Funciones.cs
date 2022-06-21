using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Funciones
    {
        private string idFuncion;
        private string idPelicula;
        private string idSala;
        private string idComplejo;
        private string fechaFuncion;
        private string horarioFuncion;
        private string idiomaFuncion;
        private decimal precioFuncion;
        private string formatoFuncion;
        private bool estadoFuncion;
        public Funciones() { }

        public string IdFuncion { get => idFuncion; set => idFuncion = value; }
        public string IdPelicula { get => idPelicula; set => idPelicula = value; }
        public string IdSala { get => idSala; set => idSala = value; }
        public string IdComplejo { get => idComplejo; set => idComplejo = value; }
        public string FechaFuncion { get => fechaFuncion; set => fechaFuncion = value; }
        public string HorarioFuncion { get => horarioFuncion; set => horarioFuncion = value; }
        public string IdiomaFuncion { get => idiomaFuncion; set => idiomaFuncion = value; }
        public decimal PrecioFuncion { get => precioFuncion; set => precioFuncion = value; }
        public string FormatoFuncion { get => formatoFuncion; set => formatoFuncion = value; }
        public bool EstadoFuncion { get => estadoFuncion; set => estadoFuncion = value; }
    }
}
