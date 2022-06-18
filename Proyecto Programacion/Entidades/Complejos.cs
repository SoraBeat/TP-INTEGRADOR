using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Complejos
    {
        private string ID_Complejo_Co;
        private string Nombre_Co;
        private string Direccion_Co;
        private string Telefono_Co;
        private string Email_Co;
        private bool Estado_Co;
        public Complejos() { }

        public string ID_Complejo { get => ID_Complejo_Co; set => ID_Complejo_Co = value; }
        public string Nombre { get => Nombre_Co; set => Nombre_Co = value; }
        public string Direccion { get => Direccion_Co; set => Direccion_Co = value; }
        public string Email { get => Email_Co; set => Email_Co = value; }
        public string Telefono { get => Telefono_Co; set => Telefono_Co = value; }
        public bool Estado_Co1 { get => Estado_Co; set => Estado_Co = value; }
    }
}
