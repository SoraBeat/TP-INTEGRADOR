using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using Entidades;

namespace Negocios
{
    public class NegocioComplejos
    {
        public DataTable getListaComplejos()
        {
            DAOComplejos dao = new DAOComplejos();
            return dao.getTablaComplejo();
        }

        public bool EliminarComplejo(string id)
        {
            DAOComplejos dao = new DAOComplejos();
            Complejos com = new Complejos();
            com.ID_Complejo = id;
            int op = dao.EliminarComplejo(com);
            if (op == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    //    public bool AgregarComplejo(string ID_Complejo, string Nombre, string Direccion, string Telefono, string Email)
    //    {
    //        int cantFilas = 0;
    //        DaoComplejos daoCom = new DaoComplejos();
    //        Complejos com = new Complejos();
    //        com.ID_Complejo = ID_Complejo;
    //        com.Nombre = Nombre;
    //        com.Direccion = Direccion;
    //        com.Telefono = Telefono;
    //        com.Email = Email;
    //        if (daoCom.ExisteComplejo(com) == false)
    //        {
    //            cantFilas = daoCom.AgregarComplejo(com);
    //        }
    //        if (cantFilas == 1)
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    }
}
