using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Dao
{
    public class DaoVentas
    {
        AccesoDatos ad = new AccesoDatos();

        public DataTable getVenta(int id)
        {
            String consultaSql = "SELECT * FROM Ventas WHERE ID_Venta_V = " + id;
            DataTable tabla = ad.ObtenerTabla("Ventas", consultaSql);
            return tabla;
        }
        public Boolean ExisteVenta(Ventas ven)
        {
            String consultaSql = "SELECT * FROM Ventas WHERE ID_Venta_V='" + ven.getIdVenta() + "'";
            return ad.Existe(consultaSql);
        }
        public DataTable getTablaVentas()
        {
            String consultaSql = "SELECT * FROM Ventas";

            DataTable tabla = ad.ObtenerTabla("Ventas", consultaSql);
            return tabla;
        }
        public int agregarVenta(Ventas ven)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosVentasAgregar(ref comando, ven);
            return ad.EjecutarProcedimientoAlmacenado(comando, "spAgregarVenta");
        }
        public int eliminarVenta(Ventas ven)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosVentasEliminar(ref comando, ven);
            return ad.EjecutarProcedimientoAlmacenado(comando, "spEliminarVenta");
        }
        private void ArmarParametrosVentasAgregar(ref SqlCommand Comando, Ventas ven)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDUSUARIO_V", SqlDbType.Int);
            SqlParametros.Value = ven.getIdUsuario();
            SqlParametros = Comando.Parameters.Add("@FECHAVENTA", SqlDbType.SmallDateTime);
            SqlParametros.Value = ven.getFechaVenta();
            SqlParametros = Comando.Parameters.Add("@METODOPAGO", SqlDbType.VarChar);
            SqlParametros.Value = ven.getMetodoPago();
            SqlParametros = Comando.Parameters.Add("@METODOFINAL", SqlDbType.Decimal);
            SqlParametros.Value = ven.getMetodoFinal();
        }
        private void ArmarParametrosSucursalEliminar(ref SqlCommand Comando, Ventas ven)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDVenta", SqlDbType.Int);
            SqlParametros.Value = ven.getIdVenta();
        }
    }
}
