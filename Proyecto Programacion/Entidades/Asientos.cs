using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Asientos
    {
        private int idAsiento;
        private int idSala;
        private int idComplejo;

        public Asientos() { }

        public int IDAsiento { get => idAsiento; set => idAsiento = value; }
        public int IDSala { get => idSala; set => idSala = value; }
        public int IDComplejo { get => idComplejo; set => idComplejo = value; }

    }
}
