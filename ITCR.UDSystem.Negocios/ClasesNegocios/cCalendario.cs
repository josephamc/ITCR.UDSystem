using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ITCR.UDSystem.Negocios.ClasesNegocios
{
    public class cCalendario
    {
        /// <summary>
        /// Obtiene todas las reservaciones hechas en el sistema
        /// </summary>
        /// <returns>DataTable Object (start,end,name,id)</returns>
        public DataTable ObtenerReservaciones()
        {
            DataTable toReturn = new DataTable();
            toReturn.Columns.Add("start", typeof(DateTime));
            toReturn.Columns.Add("end", typeof(DateTime));
            toReturn.Columns.Add("name", typeof(string));
            toReturn.Columns.Add("id", typeof(string));
            toReturn.Merge(ObtenerEventos());
            toReturn.Merge(ObtenerCursos());
            toReturn.Merge(ObtenerAprobaciones());
            return toReturn;
        }

        /// <summary>
        /// Obtiene todas las reservaciones hechas por la aprobacion de una solicitud
        /// </summary>
        /// <returns>DataTable Object (start,end,name,id)</returns>
        private DataTable ObtenerAprobaciones()
        {
            cUDGDFAPROBACIONNegocios cAprobaciones = new cUDGDFAPROBACIONNegocios(0, "", 0, "");
            DataTable dtAprobaciones = cAprobaciones.Seleccionar_Todo_Detallado();
            DataTable toReturn = new DataTable();
            toReturn.Columns.Add("start", typeof(DateTime));
            toReturn.Columns.Add("end", typeof(DateTime));
            toReturn.Columns.Add("name", typeof(string));
            toReturn.Columns.Add("id", typeof(string));
            String sFechainicio, sFechafin, sHorainicio, sHorafin, sDescripcion;
            String sID;
            Boolean blunes, bmartes, bmiercoles, bjueves, bviernes, bsabado, bdomingo;

            foreach (DataRow drLocalRow in dtAprobaciones.Rows)
            {
                sFechainicio = drLocalRow[1].ToString();
                sFechafin = drLocalRow[2].ToString();
                sHorainicio = drLocalRow[3].ToString();
                sHorafin = drLocalRow[4].ToString();
                sDescripcion = "Reservacion de " + drLocalRow[5].ToString();
                sID = "Reservacion:" + int.Parse(drLocalRow[0].ToString());
                blunes = true;
                bmartes = true;
                bmiercoles = true;
                bjueves = true;
                bviernes = true;
                bsabado = true;
                bdomingo = true;
                toReturn.Merge(ObtenerFechas(sFechainicio, sFechafin, sHorainicio, sHorafin, sDescripcion, sID, blunes, bmartes, bmiercoles, bjueves, bviernes, bsabado, bdomingo));
            }

            return toReturn;
        }

        /// <summary>
        /// Obtiene todas las reservaciones hechas para los cursos
        /// </summary>
        /// <returns>DataTable Object (start,end,name,id)</returns>
        private DataTable ObtenerCursos()
        {
            cUDGDFCURSONegocios cCursos = new cUDGDFCURSONegocios(0, "", 0, "");
            DataTable dtCursos = cCursos.Seleccionar_Todo_Detallado();
            DataTable toReturn = new DataTable();
            toReturn.Columns.Add("start", typeof(DateTime));
            toReturn.Columns.Add("end", typeof(DateTime));
            toReturn.Columns.Add("name", typeof(string));
            toReturn.Columns.Add("id", typeof(string));
            String sFechainicio, sFechafin, sHorainicio, sHorafin, sDescripcion;
            String sID;
            Boolean blunes, bmartes, bmiercoles, bjueves, bviernes, bsabado, bdomingo;

            foreach (DataRow drLocalRow in dtCursos.Rows)
            {
                sFechainicio = drLocalRow[9].ToString();
                sFechafin = drLocalRow[10].ToString();
                sHorainicio = drLocalRow[11].ToString();
                sHorafin = drLocalRow[12].ToString();
                sDescripcion = drLocalRow[1].ToString();
                sID = "Curso:" + int.Parse(drLocalRow[0].ToString());
                blunes = (Boolean)drLocalRow[2];
                bmartes = (Boolean)drLocalRow[3];
                bmiercoles = (Boolean)drLocalRow[4];
                bjueves = (Boolean)drLocalRow[5];
                bviernes = (Boolean)drLocalRow[6];
                bsabado = (Boolean)drLocalRow[7];
                bdomingo = (Boolean)drLocalRow[8];
                toReturn.Merge(ObtenerFechas(sFechainicio, sFechafin, sHorainicio, sHorafin, sDescripcion, sID, blunes, bmartes, bmiercoles, bjueves, bviernes, bsabado, bdomingo));
            }

            return toReturn;
        }

        /// <summary>
        /// Obtiene todas las reservaciones hechas para los eventos
        /// </summary>
        /// <returns>DataTable Object (start,end,name,id)</returns>
        private DataTable ObtenerEventos()
        {
            cUDGDFEVENTONegocios cEventos = new cUDGDFEVENTONegocios(0, "", 0, "");
            DataTable dtEventos = cEventos.Seleccionar_Todo_Detallado();
            DataTable toReturn = new DataTable();
            toReturn.Columns.Add("start", typeof(DateTime));
            toReturn.Columns.Add("end", typeof(DateTime));
            toReturn.Columns.Add("name", typeof(string));
            toReturn.Columns.Add("id", typeof(string));
            String sFechainicio, sFechafin, sHorainicio, sHorafin, sDescripcion;
            String sID;
            Boolean blunes, bmartes, bmiercoles, bjueves, bviernes, bsabado, bdomingo;
            
            foreach (DataRow drLocalRow in dtEventos.Rows)
            {
                sFechainicio = drLocalRow[9].ToString();
                sFechafin = drLocalRow[10].ToString();
                sHorainicio = drLocalRow[11].ToString();
                sHorafin = drLocalRow[12].ToString();
                sDescripcion = drLocalRow[1].ToString();
                sID = "Evento:" + int.Parse(drLocalRow[0].ToString());
                blunes = (Boolean)drLocalRow[2];
                bmartes = (Boolean)drLocalRow[3];
                bmiercoles = (Boolean)drLocalRow[4];
                bjueves = (Boolean)drLocalRow[5];
                bviernes = (Boolean)drLocalRow[6];
                bsabado = (Boolean)drLocalRow[7];
                bdomingo = (Boolean)drLocalRow[8];
                toReturn.Merge(ObtenerFechas(sFechainicio, sFechafin, sHorainicio, sHorafin, sDescripcion, sID, blunes, bmartes, bmiercoles, bjueves, bviernes, bsabado, bdomingo));
            }

            return toReturn;
        }

        /// <summary>
        /// Obtiene los días especificados dentro de un rango de fechas
        /// </summary>
        /// <param name="p_fechainicio">Fecha inicio</param>
        /// <param name="p_fechafin">Fecha Fin</param>
        /// <param name="p_horainicio">Hora inicio</param>
        /// <param name="p_horafin">Hora fin</param>
        /// <param name="p_descripcion">Descripcion de la actividad</param>
        /// <param name="p_id">Id de la actividad</param>
        /// <param name="p_lunes">Dia Lunes</param>
        /// <param name="p_martes">Dia Martes</param>
        /// <param name="p_miercoles">Dia Miercoles</param>
        /// <param name="p_jueves">Dia Jueves</param>
        /// <param name="p_viernes">Dia Viernes</param>
        /// <param name="p_sabado">Dia Sabado</param>
        /// <param name="p_domingo">Dia Domingo</param>
        /// <returns>DataTable Object (start, end, name, id)</returns>
        private DataTable ObtenerFechas(String p_fechainicio, String p_fechafin, String p_horainicio,
            String p_horafin, String p_descripcion, String p_id, Boolean p_lunes, Boolean p_martes, Boolean p_miercoles,
            Boolean p_jueves, Boolean p_viernes, Boolean p_sabado, Boolean p_domingo)
        {
            DataTable dtFechas = new DataTable();
            dtFechas.Columns.Add("start", typeof(DateTime));
            dtFechas.Columns.Add("end", typeof(DateTime));
            dtFechas.Columns.Add("name", typeof(string));
            dtFechas.Columns.Add("id", typeof(string));
            DateTime dtFinal = DateTime.Parse(p_fechafin);

            for (DateTime dtLocal = DateTime.Parse(p_fechainicio); dtFinal.CompareTo(dtLocal) >= 0; dtLocal = dtLocal.AddDays(1))
            {
                if (((dtLocal.DayOfWeek == DayOfWeek.Monday) && (p_lunes == true)) ||
                    ((dtLocal.DayOfWeek == DayOfWeek.Tuesday) && (p_martes == true)) ||
                    ((dtLocal.DayOfWeek == DayOfWeek.Wednesday) && (p_miercoles == true)) ||
                    ((dtLocal.DayOfWeek == DayOfWeek.Thursday) && (p_jueves == true)) ||
                    ((dtLocal.DayOfWeek == DayOfWeek.Friday) && (p_viernes == true)) ||
                    ((dtLocal.DayOfWeek == DayOfWeek.Saturday) && (p_sabado == true)) ||
                    ((dtLocal.DayOfWeek == DayOfWeek.Sunday) && (p_domingo == true))
                  )
                {
                    DataRow drRow = dtFechas.NewRow();
                    DateTime dtInicio = new DateTime(dtLocal.Year, dtLocal.Month, dtLocal.Day);
                    dtInicio = dtInicio.Date + TimeSpan.Parse(p_horainicio);
                    DateTime dtFin = new DateTime(dtLocal.Year, dtLocal.Month, dtLocal.Day);
                    dtFin = dtFin.Date + TimeSpan.Parse(p_horafin);
                    drRow["id"] = p_id;
                    drRow["start"] = dtInicio;
                    drRow["end"] = dtFin;
                    drRow["name"] = p_descripcion;
                    dtFechas.Rows.Add(drRow);
                }
            }

            return dtFechas;
        }
    }//class
}//namespace
