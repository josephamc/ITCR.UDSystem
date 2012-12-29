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
        private int iIDInstalacion = -1;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                    iIDInstalacion = int.Parse(Request.QueryString["id"].ToString());
                    cUDGDFINSTALACIONNegocios instalacionBase = new cUDGDFINSTALACIONNegocios(0, "", 0, "");
                    instalacionBase.ID_INSTALACION = iIDInstalacion;
                    DataTable tabla = instalacionBase.SeleccionarUno();
                    txt_nombreInstalacion.Text = instalacionBase.NOM_INSTALACION.ToString();
                    
                 
            }
            catch (Exception) { }
        }

        

        protected void boton_enviar_solicitud_Click(object sender, EventArgs e)
        {
            cUDGDFRESERVACIONNegocios Nueva_Consulta = new cUDGDFRESERVACIONNegocios(0, "", 0, "");
            int iResultado = -1000;
            string tiHRA_HORAINICIO = ddlAmPm1.Text.ToString() + ":"+DropDownList3.Text.ToString() + ":00";
            string tiHRA_HORAFIN = ddlAmPm2.Text.ToString() + ":" + DropDownList4.Text.ToString() + ":00";
            //iResultado = Nueva_Consulta.ConsultarDisponibilidad(Convert.ToDateTime(txt_FechaInicio.Text.ToString()), Convert.ToDateTime(txt_FechaFin.Text.ToString()), DateTime.Parse(tiHRA_HORAINICIO), DateTime.Parse(tiHRA_HORAFIN), iIDInstalacion);
            iResultado = Nueva_Consulta.ConsultarDisponibilidad(Convert.ToDateTime("2012-11-15"), Convert.ToDateTime("2012-11-15"), DateTime.Parse("14:00:00"), DateTime.Parse("15:00:00"), 1);
            if (iResultado == 1) { 
            
            }


            //prueba=Nueva_Consulta.ConsultarDisponibilidad(
            //Nueva_Instalacion.NOM_INSTALACION = txt_nombre.Text.ToString();
           /* Nueva_Solicitud.NOM_INSTITUCION = txt_nombreInstalacion.Text.ToString();
            Nueva_Solicitud.FEC_INICIO = Convert.ToDateTime(txt_FechaInicio.Text.ToString());
            Nueva_Solicitud.FEC_FIN = Convert.ToDateTime(txt_FechaFin.Text.ToString());
            Nueva_Solicitud.HRA_INICIO = Convert.ToDateTime(txt_HoraInicio.Text.ToString());
            Nueva_Solicitud.HRA_FIN = Convert.ToDateTime(txt_HoraFin.Text.ToString());
            Nueva_Solicitud.NOM_INSTITUCION = TextBox_Solicitante.Text.ToString();
            Nueva_Solicitud.NOM_ENCARGADO = TextBox_responsable.Text.ToString();
            Nueva_Solicitud.COD_IDENTIFICACION = TextBox_identificacion.Text.ToString();*/
            
            /* lo de joseph ------------------------------------------------------------
             cReservacion.FEC_FECHAINICIO = (DateTime)drSolicitud[1];
             cReservacion.HRA_HORAINICIO = DateTime.Parse(drSolicitud[4].ToString());
             */
            //Nueva_Instalacion.Insertar();
            //idagregar = Int32.Parse(Nueva_Instalacion.ID_INSTALACION.ToString());

            //Server.Transfer("~/Exito.aspx", true);
                Server.Transfer("~/Exito.aspx", true);
        }

      

    }
}