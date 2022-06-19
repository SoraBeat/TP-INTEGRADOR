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
        private string idFuncion;
        private string idSala;
        private string idComplejo;
        private int cantidad;
        private float precio;
        public DetalleVentas() { }

        public int IDDetalleVenta { get => idDetalleVenta; set => idDetalleVenta = value; }
        public int IDVenta { get => idVenta; set => idVenta = value; }
        public string IDFuncion { get => idFuncion; set => idFuncion = value; }
        public string IDSala { get => idSala; set => idSala = value; }
        public string IDComplejo { get => idComplejo; set => idComplejo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Precio { get => precio; set => precio = value; }
    }
}
