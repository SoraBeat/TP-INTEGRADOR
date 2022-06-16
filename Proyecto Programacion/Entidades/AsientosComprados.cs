using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class AsientosComprados
    {
        private int idAsiento;
        private int idVenta;
        private int idDetalleVenta;
        private int idFuncion;
        private int idSala;
        private int idComplejo;

        public AsientosComprados() { }

        public int IDAsiento { get => idAsiento; set => idAsiento = value; }
        public int IDVenta { get => idVenta; set => idVenta = value; }
        public int IDDetalleVenta { get => idDetalleVenta; set => idDetalleVenta = value; }
        public int IDFuncion { get => idFuncion; set => idFuncion = value; }
        public int IDSala { get => idSala; set => idSala = value; }
        public int IDComplejo { get => idComplejo; set => idComplejo = value; }
    }
}
