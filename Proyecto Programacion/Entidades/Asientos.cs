using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asientos
    {
        private string idAsiento;
        private string idSala;
        private string idComplejo;

        public Asientos() { }

        public string IDAsiento { get => idAsiento; set => idAsiento = value; }
        public string IDSala { get => idSala; set => idSala = value; }
        public string IDComplejo { get => idComplejo; set => idComplejo = value; }

    }
}
