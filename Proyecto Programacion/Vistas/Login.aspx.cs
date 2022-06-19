using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios;
using Entidades;
using System.Data;

namespace Vistas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        NegocioUsuario negUsu = new NegocioUsuario();

        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }

        protected void cbContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (cbContraseña.Checked == true)
            {
                txtPassword.TextMode = TextBoxMode.SingleLine;
            }
            else
                txtPassword.TextMode = TextBoxMode.Password;
        }
    }
}