using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DayPilot.Web.Ui.Events;
using System.Drawing;
using ITCR.UDSystem.Negocios.ClasesNegocios;

namespace ITCR.UDSystem.Interfaz.CU_AdministrarCalendario
{
    public partial class ConsultaCalendario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //cUDGDFRESERVACIONNegocios cReservacion = new cUDGDFRESERVACIONNegocios(0, "", 0, "");

            if (!IsPostBack)
            {
                cCalendario calendario = new cCalendario();
                cldSeleccion.SelectedDate = DateTime.Today;
                EstablecerSemana();

                dpCalendar.DataSource = calendario.ObtenerReservaciones();
                dpCalendar.DataBind();
            }
        }

        protected void dpCalendar_EventClick(Object sender, EventClickEventArgs e)
        {
            
        }
        
        protected void cldSeleccion_SelectionChanged(Object sender, EventArgs e)
        {
            EstablecerSemana();
        }

        private DataTable getData()
        {
            DataTable dt;
            dt = new DataTable();
            dt.Columns.Add("start", typeof(DateTime));
            dt.Columns.Add("end", typeof(DateTime));
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("id", typeof(string));

            DataRow dr;

            dr = dt.NewRow();
            dr["id"] = 0;
            dr["start"] = DateTime.Parse("17-01-2013 12:00");
            dr["end"] = DateTime.Parse("17-01-2013 13:00");
            dr["name"] = "Event 1";
            dt.Rows.Add(dr);

            return dt;
        }

        /// <summary>
        /// Establece la semana en el Componente DayPilotCalendar
        /// </summary>
        private void EstablecerSemana()
        {
            DateTime dtfirstDay = ObtenerInicioSemana(cldSeleccion.SelectedDate, DayOfWeek.Sunday);
            cldSeleccion.VisibleDate = dtfirstDay;
            for (int i = 0; i < 7; i++)
                cldSeleccion.SelectedDates.Add(dtfirstDay.AddDays(i));

            dpCalendar.StartDate = dtfirstDay;
        }

        /// <summary>
        /// Obtiene el primer de la semana dado los parametros
        /// </summary>
        /// <param name="p_day">Dia actual</param>
        /// <param name="p_weekStarts">Dia seleccionado como inicio de semana. Ejem: Sunday, Monday...</param>
        /// <returns>DateTime Object</returns>
        private DateTime ObtenerInicioSemana(DateTime p_day, DayOfWeek p_weekStarts)
        {
            DateTime dtActual = p_day;
            while (dtActual.DayOfWeek != p_weekStarts)
                dtActual = dtActual.AddDays(-1);
            return dtActual;
        }
    }//class
}//namespace