using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ventas
    {
        private int idVenta;
        private int idUsuario;
        private string fechaVenta;
        private string metodoPagoVenta;
        private float montoFinalVenta;
        private string codigoAlfanumerico;
        public Ventas() { }

        public int IDVenta { get => idVenta; set => idVenta = value; }
        public int IDUsuario { get => idUsuario; set => idUsuario = value; }
        public string FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public string MetodoPagoVenta { get => metodoPagoVenta; set => metodoPagoVenta = value; }
        public float MontoFinalVenta { get => montoFinalVenta; set => montoFinalVenta = value; }
        public string CodigoAlfanumerico { get => codigoAlfanumerico; set => codigoAlfanumerico = value; }
    }
}
