using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AsientosComprados
    {
        private string idAsiento;
        private int idVenta;
        private int idDetalleVenta;
        private string idFuncion;
        private string idSala;
        private string idComplejo;
        private bool estadoComplejo;

        public AsientosComprados() { }

        public string IdAsiento { get => idAsiento; set => idAsiento = value; }
        public int IdVenta { get => idVenta; set => idVenta = value; }
        public int IdDetalleVenta { get => idDetalleVenta; set => idDetalleVenta = value; }
        public string IdFuncion { get => idFuncion; set => idFuncion = value; }
        public string IdSala { get => idSala; set => idSala = value; }
        public string IdComplejo { get => idComplejo; set => idComplejo = value; }
        public bool EstadoComplejo { get => estadoComplejo; set => estadoComplejo = value; }
    }
}
