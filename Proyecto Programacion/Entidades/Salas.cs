using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Salas
    {
        private int idSala;
        private int idComplejo;
        private int totalAsientos;
        private bool estadoSala;

        public Salas() { }

        public int IDSala { get => idSala; set => idSala = value; }
        public int IDComplejo { get => idComplejo; set => idComplejo = value; }
        public int TotalAsientos { get => totalAsientos; set => totalAsientos = value; }
        public bool Estado { get => estadoSala; set => estadoSala = value; }
    }
}
