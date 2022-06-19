using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        private int idUsuario;
        private string nombreUsuario;
        private string apellidoUsuario;
        private string dniUsuario;
        private string telefonoUsuario;
        private string emailUsuario;
        private string contraseñaUsuario;
        private bool tipoUsuario;
        private bool estado;
        public Usuarios() { }

        public int IDUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string ApellidoUsuario { get => apellidoUsuario; set => apellidoUsuario = value; }
        public string DNIUsuario { get => dniUsuario; set => dniUsuario = value; }
        public string TelefonoUsuario { get => telefonoUsuario; set => telefonoUsuario = value; }
        public string EmailUsuario { get => emailUsuario; set => emailUsuario = value; }
        public string ContraseñaUsuario { get => contraseñaUsuario; set => contraseñaUsuario = value; }
        public bool TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
        public bool Estado { get => estado; set => estado= value; }
    }
}
