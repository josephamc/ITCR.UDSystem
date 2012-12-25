using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITCR.UDSystem.Interfaz
{
    public partial class frmNotificacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String sStatus = Request.QueryString["status"]; // Obtiene el nombre de la solicitud seleccionada
            switch (sStatus)
            {
                case "true":
                    // Aceptar Solicitud
                    lblMessage.Text = "El usuario será notificado de que su solicitud ha sido aceptada";
                    break;
                case "false":
                    // Rechazar Solicitud
                    lblMessage.Text = "El usuario será notificado de que su solicitud ha sido rechazada";
                    break;
            }
        }
    }
}