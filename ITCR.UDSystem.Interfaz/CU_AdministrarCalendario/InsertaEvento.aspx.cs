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
                error_reservacion.Visible = false;
                exito_reservacion.Visible = false;
                cal01.Visible = false;
                cal02.Visible = false;

                //rellena el dropdown list de las instalaciones
                cUDGDFINSTALACIONNegocios instalacion = new cUDGDFINSTALACIONNegocios(0, "", 0, "");
                DataTable datos_instalaciones = instalacion.SeleccionarTodos();

                for (int i = 0; i < datos_instalaciones.Rows.Count; i++)
                {
                    ListItem li = new ListItem(datos_instalaciones.Rows[i][1].ToString(), datos_instalaciones.Rows[i][0].ToString());
                    ddl_instalaciones.Items.Add(li);
                }
            }
        }
        

        protected void cal01_SelectionChanged(object sender, EventArgs e)
        {
            //selecciona la fecha del calendario y la pone en el text box
            DateTime fechaElegida = cal01.SelectedDate;
            txt_FechaInicio.Text = "" + fechaElegida.Year + "-" + fechaElegida.Month + "-" + fechaElegida.Day;
            cal01.Visible = false;
            cal02.Visible = false;
        }

        protected void cal02_SelectionChanged(object sender, EventArgs e)
        {
            //selecciona la fecha del calendario y la pone en el text box
            DateTime fechaElegida = cal02.SelectedDate;
            txt_FechaFin.Text = "" + fechaElegida.Year + "-" + fechaElegida.Month + "-" + fechaElegida.Day;
            cal01.Visible = false;
            cal02.Visible = false;
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            cal02.Visible = false;
            cal01.Enabled = true;
            cal01.Visible = true;
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            cal01.Visible = false;
            cal02.Enabled = true;
            cal02.Visible = true;
        }

        protected void boton_añadir_evento_Click(object sender, EventArgs e)
        {
            cUDGDFRESERVACIONNegocios reserva = new cUDGDFRESERVACIONNegocios(0, "", 0, "");
            //string Inicio = txt_HoraInicio.Text + ":00 " + ddlAmPm1.SelectedItem.Value.ToString();
            //string Fin = txt_HoraFin.Text + ":00 " + ddlAmPm2.SelectedItem.Value.ToString();
            string Inicio = ddlAmPm1.Text.ToString() + ":" + DropDownList3.Text.ToString() + ":00";
            string Fin = ddlAmPm2.Text.ToString() + ":" + DropDownList4.Text.ToString() + ":00";
            string fecha_actual = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
            int resultado = reserva.ConsultarDisponibilidad(Convert.ToDateTime(txt_FechaInicio.Text.ToString()), Convert.ToDateTime(txt_FechaFin.Text.ToString()), DateTime.Parse(Inicio), DateTime.Parse(Fin), Int32.Parse(ddl_instalaciones.SelectedValue.ToString()));

            if (resultado == 1)
            {
                //obtiene el id del calendario
                cUDGDFCALENDARIONegocios calendario = new cUDGDFCALENDARIONegocios(0, "", 0, "");
                calendario.FKY_INSTALACION = Int32.Parse(ddl_instalaciones.SelectedValue.ToString());
                DataTable cal = calendario.SeleccionarTodos_Con_FKY_INSTALACION_FK();
                int id_cal = Int32.Parse(cal.Rows[0][0].ToString());

                //ingresa los datos de la reserva
                reserva.HRA_HORAINICIO = Convert.ToDateTime(Inicio);
                reserva.HRA_HORAFIN = Convert.ToDateTime(Fin);
                reserva.FEC_FECHAINICIO = DateTime.Parse(txt_FechaInicio.Text.ToString());
                reserva.FEC_FECHAFIN = DateTime.Parse(txt_FechaFin.Text.ToString());
                reserva.Insertar();

                //inserta el evento
                cUDGDFEVENTONegocios evento = new cUDGDFEVENTONegocios(0, "", 0, "");
                evento.NOM_EVENTO = txt_nombreEvento.Text.ToString();
                evento.DSC_EVENTO = txt_descripcionEvento.Value.ToString();
                evento.FKY_CALENDARIO = id_cal;
                evento.FKY_RESERVACION = reserva.ID_RESERVACION;
                evento.Insertar();

                //limpia campos
                txt_nombreEvento.Text = "";
                txt_descripcionEvento.Value = "";
                txt_FechaInicio.Text = "";
                txt_FechaFin.Text = "";
                
                //introduce mensaje de exito
                _inst2.Text = ddl_instalaciones.SelectedItem.ToString();

                error_reservacion.Visible = false;
                exito_reservacion.Visible = true;      
            }
            else
            {
                _inst.Text = ddl_instalaciones.SelectedItem.ToString();
                exito_reservacion.Visible = false;
                error_reservacion.Visible = true;
            }
        }


    }
}