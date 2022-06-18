using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Salas
    {
        private string idSala;
        private string idComplejo;
        private int totalAsientos;
        private bool estadoSala;

        public Salas() { }

        public string IDSala { get => idSala; set => idSala = value; }
        public string IDComplejo { get => idComplejo; set => idComplejo = value; }
        public int TotalAsientos { get => totalAsientos; set => totalAsientos = value; }
        public bool Estado { get => estadoSala; set => estadoSala = value; }
    }
}
