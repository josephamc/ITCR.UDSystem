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
    public partial class InsertaCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cUDGDFINSTALACIONNegocios cInstalacion = new cUDGDFINSTALACIONNegocios(0, "", 0, "");
                DataTable _dtInstalaciones = cInstalacion.SeleccionarTodos();
                foreach (DataRow dtLocalRow in _dtInstalaciones.Rows)
                    ddl_instalacionCurso.Items.Add(dtLocalRow[1].ToString());
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
            cUDGDFCURSONegocios cCurso = new cUDGDFCURSONegocios(0, "", 0, "");
            cUDGDFRESERVACIONNegocios cReservacion = new cUDGDFRESERVACIONNegocios(0, "", 0, "");
            int iDisponibilidad = -1, iID_INSTALACION;
            DataTable dtCalendario = cCalendario.SeleccionarTodos_Con_FKY_INSTALACION_FK();
            DateTime dFechaInicio, dFechafin, dhorainicio, dhorafin;

            // Obtiene todas las instalaciones
            DataTable dtInstalaciones = cInstalacion.SeleccionarTodos();

            // Obtengo el ID del Calendario
            iID_INSTALACION = ObtenerID(ddl_instalacionCurso.Text, dtInstalaciones);
            cCalendario.FKY_INSTALACION = iID_INSTALACION;
            
            dFechaInicio = DateTime.Parse(txt_FechaInicio.Text);
            dFechafin = DateTime.Parse(txt_FechaFin.Text);
            dhorainicio = DateTime.Parse(txt_HoraInicio.Text + ":00" + ddlAmPm1.SelectedItem.Value.ToString());
            dhorafin = DateTime.Parse(txt_HoraFin.Text + ":00" + ddlAmPm2.SelectedItem.Value.ToString());

            iDisponibilidad = cReservacion.ConsultarDisponibilidadCalendario(dFechaInicio, dFechafin, dhorainicio, dhorafin, iID_INSTALACION);

            if (!cCurso.Comprobar_Nombre(txt_nombreCurso.Text))
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

                    // Crea el curso
                    cCurso.NOM_PROFESOR = txt_profesor.Text;
                    cCurso.NOM_CURSO = txt_nombreCurso.Text;
                    cCurso.COD_LUNES = ck_lunes.Checked;
                    cCurso.COD_MARTES = ck_martes.Checked;
                    cCurso.COD_MIERCOLES = ck_miercoles.Checked;
                    cCurso.COD_JUEVES = ck_jueves.Checked;
                    cCurso.COD_VIERNES = ck_viernes.Checked;
                    cCurso.COD_SABADO = ck_sabado.Checked;
                    cCurso.COD_DOMINGO = ck_domingo.Checked;
                    cCurso.FKY_CALENDARIO = int.Parse(dtCalendario.Rows[0][0].ToString());
                    cCurso.FKY_RESERVACION = cReservacion.ID_RESERVACION;
                    cCurso.Insertar();

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