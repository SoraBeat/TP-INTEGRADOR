using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Complejos
    {
        private int idComplejo;
        private string nombreComplejo;
        private string direccionComplejo;
        private int telefonoComplejo;
        private string emailComplejo;

        public Complejos() { }
        public int IDComplejo { get => idComplejo; set => idComplejo = value; }
        public string NombreComplejo { get => nombreComplejo; set => nombreComplejo = value; }
        public string DireccionComplejo { get => direccionComplejo; set => direccionComplejo = value; }
        public int TelefonoComplejo { get => telefonoComplejo; set => telefonoComplejo = value; }
        public string EmailComplejo { get => emailComplejo; set => emailComplejo = value; }
    }
}
