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
            iResultado = Nueva_Consulta.ConsultarDisponibilidad(Convert.ToDateTime(txt_FechaInicio.Text.ToString()), Convert.ToDateTime(txt_FechaFin.Text.ToString()), DateTime.Parse(tiHRA_HORAINICIO), DateTime.Parse(tiHRA_HORAFIN), iIDInstalacion);
            
            if (iResultado == 1) {
                cUDGDFSOLICITUDNegocios Nueva_Solicitud = new cUDGDFSOLICITUDNegocios(0, "", 0, "");
                Nueva_Solicitud.FKY_INSTALACION = iIDInstalacion;
                Nueva_Solicitud.FEC_INICIO=Convert.ToDateTime(txt_FechaInicio.Text.ToString());
                Nueva_Solicitud.FEC_FIN=Convert.ToDateTime(txt_FechaFin.Text.ToString());
                Nueva_Solicitud.FEC_SOLICITUD=DateTime.Now;
                Nueva_Solicitud.HRA_INICIO=DateTime.Parse(tiHRA_HORAINICIO);
                Nueva_Solicitud.HRA_FIN=DateTime.Parse(tiHRA_HORAFIN);
                Nueva_Solicitud.NOM_ENCARGADO = TextBox_responsable.Text.ToString();
                Nueva_Solicitud.NOM_INSTITUCION = TextBox_Solicitante.Text.ToString();
                Nueva_Solicitud.COD_IDENTIFICACION=TextBox_identificacion.Text.ToString();
                Nueva_Solicitud.CAN_USUARIOS=Int32.Parse(TextBox_cantidad.Text.ToString());
                cUDGDFTPSOLTNTENegocios Solicitante = new cUDGDFTPSOLTNTENegocios(0, "", 0, "");
                Nueva_Solicitud.FKY_TIPOSOLICITANTE=Solicitante.BuscarID(DropDownList1.Text.ToString());
                Nueva_Solicitud.TXT_OBSERVACIONES=null;
                Nueva_Solicitud.DSC_RAZONUSO=txt_razonUso.Value.ToString();
                Nueva_Solicitud.COD_TIPOSOLICITUD= DropDownList2.Text.ToString();
                Nueva_Solicitud.TXT_CORREO=TextBox_correo.Text.ToString();
                Nueva_Solicitud.COD_ATENDIDO=false;
                Nueva_Solicitud.TXT_USUARIOS=Textarea_involucradas.Value.ToString();
                Nueva_Solicitud.Insertar(); 

                Response.Redirect("~/frmOcupado.aspx", true); //true
              
            }

            else
                Response.Redirect("~/frmError.aspx", true); //true


           
        }

      

    }
}