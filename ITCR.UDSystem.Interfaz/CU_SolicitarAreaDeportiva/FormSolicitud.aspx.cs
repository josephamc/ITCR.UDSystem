using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.UDSystem.Negocios;
using System.Data;

namespace ITCR.UDSystem.Interfaz.CU_SolicitarAreaDeportiva
{
    public partial class FormSolicitud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void boton_enviar_solicitud_Click(object sender, EventArgs e)
        {
            cUDGDFSOLICITUDNegocios Nueva_Solicitud = new cUDGDFSOLICITUDNegocios(0, "", 0, "");
            //Nueva_Instalacion.NOM_INSTALACION = txt_nombre.Text.ToString();
           /* Nueva_Solicitud.NOM_INSTITUCION = txt_nombreInstalacion.Text.ToString();
            Nueva_Solicitud.FEC_INICIO = Convert.ToDateTime(txt_FechaInicio.Text.ToString());
            Nueva_Solicitud.FEC_FIN = Convert.ToDateTime(txt_FechaFin.Text.ToString());
            Nueva_Solicitud.HRA_INICIO = Convert.ToDateTime(txt_HoraInicio.Text.ToString());
            Nueva_Solicitud.HRA_FIN = Convert.ToDateTime(txt_HoraFin.Text.ToString());
            Nueva_Solicitud.NOM_INSTITUCION = TextBox_Solicitante.Text.ToString();
            Nueva_Solicitud.NOM_ENCARGADO = TextBox_responsable.Text.ToString();
            Nueva_Solicitud.COD_IDENTIFICACION = TextBox_identificacion.Text.ToString();*/
            //if (DropDownList1.Text.ToString() == "Estudiante") {
                //Server.Transfer("/CU_AdministrarInstalaciones/ConsultaInstalacion", true);
            //}




            //Nueva_Instalacion.Insertar();
            //idagregar = Int32.Parse(Nueva_Instalacion.ID_INSTALACION.ToString());

            //Server.Transfer("~/Exito.aspx", true);
                Server.Transfer("~/Exito.aspx", true);
        }

    }
}