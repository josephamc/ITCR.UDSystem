using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.UDSystem.Negocios.ClasesNegocios;

namespace ITCR.UDSystem.Interfaz
{
    public partial class frmNotificacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String sStatus = Request.QueryString["status"]; // Obtiene el nombre de la solicitud seleccionada
            String sOperacion = Request.QueryString["op"]; // Obtiene la accion por la que se realiza la notificacion

            switch (sOperacion)
            {
                case "sendemail":
                    int iID_SOLICITUD = int.Parse(Session["p_idSolicitud"].ToString());
                    cSolicitud csSolicitud = new cSolicitud();
                    csSolicitud.ID_SOLICITUD = iID_SOLICITUD;
                    
                    switch (sStatus)
                    {
                        case "true":
                            csSolicitud.AceptarSolicitud();
                            lblMessage.Text = "El usuario será notificado de que su solicitud ha sido aceptada";
                            break;
                        case "false":
                            csSolicitud.RechazarSolicitud();
                            lblMessage.Text = "El usuario será notificado de que su solicitud ha sido rechazada";
                            break;
                    }//switch sStatus
                    // Envia el correo al usuario
                    break;
                case "notCor":
                    lblMessage.Text = "La operación ha sido realizada con éxito";
                    break;
                case "notInc":
                    lblMessage.Text = "La operacion no ha podido ser realizada con éxito, por favor vuelva a intentarlo mas tarde";
                    break;
            }//switch sOperacion
        }
    }//class
}//namespace