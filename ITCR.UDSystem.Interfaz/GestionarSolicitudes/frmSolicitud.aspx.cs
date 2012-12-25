using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITCR.UDSystem.Interfaz.GestionarSolicitudes
{
    public partial class frmSolicitud1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblInstalacion.Text = Request.QueryString["sol"]; // Obtiene el nombre de la solicitud seleccionada
            lblusuarios.Text = "Example 1"+"<br>"+"Example2"+"<br>"+"Example3";
        }
    }
}