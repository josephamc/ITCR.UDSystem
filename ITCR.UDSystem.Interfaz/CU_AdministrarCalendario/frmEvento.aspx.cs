using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.UDSystem.Negocios;
using System.Data;

namespace ITCR.UDSystem.Interfaz.CU_AdministrarCalendario
{
    public partial class frmEvento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int iID_EVENTO = int.Parse(Request.QueryString["id"].ToString());
            
            // Carga la informacion
            if (!IsPostBack)
            {
                cUDGDFEVENTONegocios cEvento = new cUDGDFEVENTONegocios(0, "", 0, "");
                cUDGDFINSTALACIONNegocios cInstalacion = new cUDGDFINSTALACIONNegocios(0, "", 0, "");

                DataRow drInformacion = cEvento.Seleccionar_Con_ID(iID_EVENTO).Rows[0];
                DataTable _dtInstalaciones = cInstalacion.SeleccionarTodos();

                // Carga las instalaciones
                foreach (DataRow dtLocalRow in _dtInstalaciones.Rows)
                {
                    drp_INSTALACION.Items.Add(dtLocalRow[1].ToString());
                    if (dtLocalRow[1].ToString().CompareTo(drInformacion[16].ToString()) == 0)
                        drp_INSTALACION.SelectedIndex = drp_INSTALACION.Items.Count - 1;
                }

                // Establece los ID de la informacion mostrada para los edit
                lbl_ID_EVENTO.Text = drInformacion[0].ToString();
                lbl_ID_INSTALACION.Text = drInformacion[2].ToString();
                lbl_ID_RESERVACION.Text = drInformacion[1].ToString();
                lbl_NOM_EVENTO.Text = drInformacion[3].ToString();

                // Establece los campos textbox
                txt_NOMBRE.Text = drInformacion[3].ToString();
                txt_DESCRIPCION.Value = drInformacion[4].ToString();
                txt_FEC_INICIO.Text = ((DateTime)drInformacion[12]).ToShortDateString();
                txt_FEC_FIN.Text = ((DateTime)drInformacion[13]).ToShortDateString();

                String[] sHRA_INICIO = drInformacion[14].ToString().Split(':');
                String[] sHRA_FIN = drInformacion[15].ToString().Split(':');

                if (int.Parse(sHRA_INICIO[0]) >= 12)
                {
                    txt_HRA_INICIO.Text = (int.Parse(sHRA_INICIO[0]) - 12) + ":00:00";
                    drp_TIME_INIT.SelectedIndex = 1;
                }
                else
                    txt_HRA_INICIO.Text = drInformacion[14].ToString();

                if (int.Parse(sHRA_FIN[0]) >= 12)
                {
                    txt_HRA_FIN.Text = (int.Parse(sHRA_FIN[0]) - 12) + ":00:00";
                    drp_TIME_FIN.SelectedIndex = 1;
                }
                else
                    txt_HRA_FIN.Text = drInformacion[15].ToString();
                
                // Establece los campos checkbox
                chk_LUNES.Checked = (Boolean)drInformacion[5];
                chk_MARTES.Checked = (Boolean)drInformacion[6];
                chk_MIERCOLES.Checked = (Boolean)drInformacion[7];
                chk_JUEVES.Checked = (Boolean)drInformacion[8];
                chk_VIERNES.Checked = (Boolean)drInformacion[9];
                chk_SABADO.Checked = (Boolean)drInformacion[10];
                chk_DOMINGO.Checked = (Boolean)drInformacion[11];
            }
        }

        protected void img_EDIT_Click(object sender, ImageClickEventArgs e)
        {
            img_CALENDAR_INIT.Visible = true;
            img_CALENDAR_FIN.Visible = true;
            drp_INSTALACION.Enabled = true;

            txt_NOMBRE.Enabled = true;
            txt_DESCRIPCION.Attributes.Remove("readonly");
            
            txt_FEC_FIN.Enabled = true;
            txt_FEC_INICIO.Enabled = true;

            txt_HRA_INICIO.Enabled = true;
            txt_HRA_FIN.Enabled = true;
            cldExtender_INIT.Enabled = true;
            cldExtender_FIN.Enabled = true;
            drp_TIME_FIN.Enabled = true;
            drp_TIME_INIT.Enabled = true;

            chk_LUNES.Enabled = true;
            chk_MARTES.Enabled = true;
            chk_MIERCOLES.Enabled = true;
            chk_JUEVES.Enabled = true;
            chk_VIERNES.Enabled = true;
            chk_SABADO.Enabled = true;
            chk_DOMINGO.Enabled = true;

            btn_Guardar.Visible = true;
        }

        protected void img_DEL_Click(object sender, ImageClickEventArgs e)
        {
            cUDGDFRESERVACIONNegocios cReservacion = new cUDGDFRESERVACIONNegocios(0, "", 0, "");
            cUDGDFEVENTONegocios cEvento = new cUDGDFEVENTONegocios(0, "", 0, "");
            try
            {
                // Elimina la reservacion
                cReservacion.ID_RESERVACION = int.Parse(lbl_ID_RESERVACION.Text);
                cReservacion.Eliminar();

                // Elimina el evento
                cEvento.ID_EVENTO = int.Parse(lbl_ID_EVENTO.Text);
                cEvento.Eliminar();

                Response.Redirect("~/Confirmacion.aspx", true);
            }
            catch (Exception)
            {
                Response.Redirect("~/frmNotificacion.aspx?sol=0&op=notInc", true);
            }
        }

        protected void btn_Guardar_Click(object sender, ImageClickEventArgs e)
        {
            lbl_ErrorCalendario.Visible = false;
            lbl_ErrorNombre.Visible = false;

            cUDGDFCALENDARIONegocios cCalendario = new cUDGDFCALENDARIONegocios(0, "", 0, "");
            cUDGDFRESERVACIONNegocios cReservacion = new cUDGDFRESERVACIONNegocios(0, "", 0, "");
            cUDGDFEVENTONegocios cEvento = new cUDGDFEVENTONegocios(0, "", 0, "");
            DateTime dFechaInicio, dFechafin, dhorainicio, dhorafin;

            dFechaInicio = DateTime.Parse(txt_FEC_INICIO.Text);
            dFechafin = DateTime.Parse(txt_FEC_FIN.Text);
            dhorainicio = DateTime.Parse(txt_HRA_INICIO.Text + drp_TIME_INIT.Text);
            dhorafin = DateTime.Parse(txt_HRA_FIN.Text + drp_TIME_FIN.Text);

            // Obtiene el id del calendario
            cCalendario.FKY_INSTALACION = int.Parse(lbl_ID_INSTALACION.Text);
            int iID_CALENDARIO = (int)cCalendario.SeleccionarTodos_Con_FKY_INSTALACION_FK().Rows[0][0];

            //int iDisponibilidad = cReservacion.ConsultarDisponibilidadCalendario(dFechaInicio, dFechafin, dhorainicio, dhorafin, int.Parse(lbl_ID_INSTALACION.Text));

            if (lbl_NOM_EVENTO.Text.CompareTo(txt_NOMBRE.Text) == 0 || !cEvento.Comprobar_Nombre(txt_NOMBRE.Text))
            {
                //if (iDisponibilidad == 1)
                //{
                    // Actualiza la reservacion
                try
                {
                    cReservacion.FEC_FECHAINICIO = dFechaInicio;
                    cReservacion.FEC_FECHAFIN = dFechafin;
                    cReservacion.HRA_HORAINICIO = dhorainicio;
                    cReservacion.HRA_HORAFIN = dhorafin;
                    cReservacion.ID_RESERVACION = int.Parse(lbl_ID_RESERVACION.Text);
                    cReservacion.Actualizar();

                    // Actualiza el evento
                    cEvento.DSC_EVENTO = txt_DESCRIPCION.Value.ToString();
                    cEvento.NOM_EVENTO = txt_NOMBRE.Text;
                    cEvento.COD_LUNES = chk_LUNES.Checked;
                    cEvento.COD_MARTES = chk_MARTES.Checked;
                    cEvento.COD_MIERCOLES = chk_MIERCOLES.Checked;
                    cEvento.COD_JUEVES = chk_JUEVES.Checked;
                    cEvento.COD_VIERNES = chk_VIERNES.Checked;
                    cEvento.COD_SABADO = chk_SABADO.Checked;
                    cEvento.COD_DOMINGO = chk_DOMINGO.Checked;
                    cEvento.FKY_CALENDARIO = iID_CALENDARIO;
                    cEvento.FKY_RESERVACION = int.Parse(lbl_ID_RESERVACION.Text);
                    cEvento.ID_EVENTO = int.Parse(lbl_ID_EVENTO.Text);
                    cEvento.Actualizar();

                    // Redirecciona hacia confirmacion
                    Response.Redirect("~/Confirmacion.aspx", true);
                }
                catch (Exception)
                {
                    Response.Redirect("~/frmNotificacion.aspx?sol=0&op=notInc", true);
                }
                //}
                //else
                //    lbl_ErrorCalendario.Visible = true;
            }
            else
                lbl_ErrorNombre.Visible = true;
        }
    }//class
}//namespace