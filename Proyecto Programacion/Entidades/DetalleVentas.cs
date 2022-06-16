using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class DetalleVentas
    {
        private int idDetalleVenta;
        private int idVenta;
        private int idFuncion;
        private int idSala;
        private int idComplejo;
        private int cantidad;
        private int precio;
        public DetalleVentas() { }

        public int IDDetalleVenta { get => idDetalleVenta; set => idDetalleVenta = value; }
        public int IDVenta { get => idVenta; set => idVenta = value; }
        public int IDFuncion { get => idFuncion; set => idFuncion = value; }
        public int IDSala { get => idSala; set => idSala = value; }
        public int IDComplejo { get => idComplejo; set => idComplejo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Precio { get => precio; set => precio = value; }
    }
}
