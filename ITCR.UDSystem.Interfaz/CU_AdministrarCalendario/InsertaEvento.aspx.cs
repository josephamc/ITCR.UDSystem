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
    public partial class InsertaEvento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cUDGDFINSTALACIONNegocios cInstalacion = new cUDGDFINSTALACIONNegocios(0, "", 0, "");
                DataTable _dtInstalaciones = cInstalacion.SeleccionarTodos();
                foreach (DataRow dtLocalRow in _dtInstalaciones.Rows)
                    ddl_instalacionEvento.Items.Add(dtLocalRow[1].ToString());
                txt_FechaInicio.Text = DateTime.Today.ToShortDateString();
                txt_FechaFin.Text = DateTime.Today.ToShortDateString();
            }
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            lbl_ErrorNombre.Visible = false;
            lblErrorFecha.Visible = false;

            cUDGDFINSTALACIONNegocios cInstalacion = new cUDGDFINSTALACIONNegocios(0, "", 0, "");
            cUDGDFCALENDARIONegocios cCalendario = new cUDGDFCALENDARIONegocios(0, "", 0, "");
            cUDGDFEVENTONegocios cEvento = new cUDGDFEVENTONegocios(0, "", 0, "");
            cUDGDFRESERVACIONNegocios cReservacion = new cUDGDFRESERVACIONNegocios(0, "", 0, "");
            int iDisponibilidad = -1, iID_INSTALACION;
            DataTable dtCalendario = cCalendario.SeleccionarTodos_Con_FKY_INSTALACION_FK();
            DateTime dFechaInicio, dFechafin, dhorainicio, dhorafin;

            // Obtiene todas las instalaciones
            DataTable dtInstalaciones = cInstalacion.SeleccionarTodos();

            // Obtengo el ID del Calendario
            iID_INSTALACION = ObtenerID(ddl_instalacionEvento.Text, dtInstalaciones);
            cCalendario.FKY_INSTALACION = iID_INSTALACION;

            dFechaInicio = DateTime.Parse(txt_FechaInicio.Text);
            dFechafin = DateTime.Parse(txt_FechaFin.Text);
            dhorainicio = DateTime.Parse(txt_HoraInicio.Text + ":00" + ddlAmPm1.SelectedItem.Value.ToString());
            dhorafin = DateTime.Parse(txt_HoraFin.Text + ":00" + ddlAmPm2.SelectedItem.Value.ToString());

            iDisponibilidad = cReservacion.ConsultarDisponibilidadCalendario(dFechaInicio, dFechafin, dhorainicio, dhorafin, iID_INSTALACION);

            // Comrpobar nombre hacerlo para eventos
            if (!cEvento.Comprobar_Nombre(txt_nombreEvento.Text))
            {
                if (iDisponibilidad == 1)
                {
                    // Obtengo el ID del Calendario
                    dtCalendario = cCalendario.SeleccionarTodos_Con_FKY_INSTALACION_FK();

                    // Creo una reservacion para el curso
                    cReservacion.FEC_FECHAINICIO = dFechaInicio;
                    cReservacion.FEC_FECHAFIN = dFechafin;
                    cReservacion.HRA_HORAINICIO = dhorainicio;
                    cReservacion.HRA_HORAFIN = dhorafin;
                    cReservacion.Insertar();

                    // Crea el evento
                    cEvento.DSC_EVENTO = txa_descripcion.Value.ToString();
                    cEvento.NOM_EVENTO = txt_nombreEvento.Text;
                    cEvento.COD_LUNES = ck_lunes.Checked;
                    cEvento.COD_MARTES = ck_martes.Checked;
                    cEvento.COD_MIERCOLES = ck_miercoles.Checked;
                    cEvento.COD_JUEVES = ck_jueves.Checked;
                    cEvento.COD_VIERNES = ck_viernes.Checked;
                    cEvento.COD_SABADO = ck_sabado.Checked;
                    cEvento.COD_DOMINGO = ck_domingo.Checked;
                    cEvento.FKY_CALENDARIO = int.Parse(dtCalendario.Rows[0][0].ToString());
                    cEvento.FKY_RESERVACION = cReservacion.ID_RESERVACION;
                    cEvento.Insertar();

                    // Redirecciona hacia un mensaje de confirmacion
                    Response.Redirect("~/Confirmacion.aspx", true);
                }
                else
                    lblErrorFecha.Visible = true;
            }
            else
                lbl_ErrorNombre.Visible = true;
        }

        private int ObtenerID(String p_NOM_INSTALACION, DataTable p_Instalaciones)
        {
            foreach (DataRow drRowLocal in p_Instalaciones.Rows)
                if (drRowLocal[1].ToString().CompareTo(p_NOM_INSTALACION) == 0)
                    return int.Parse(drRowLocal[0].ToString());

            return -1;
        }
    }//class
}//namespace