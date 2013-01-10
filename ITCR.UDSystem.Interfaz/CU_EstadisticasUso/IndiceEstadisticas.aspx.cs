using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.UDSystem.Negocios;
using System.Data;

namespace ITCR.UDSystem.Interfaz.CU_EstadisticasUso
{
    public partial class IndiceEstadisticas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //rellena el dropdown list de las instalaciones
            cUDGDFINSTALACIONNegocios instalacion = new cUDGDFINSTALACIONNegocios(0, "", 0, "");
            DataTable datos_instalaciones = instalacion.SeleccionarTodos();

            for (int i = 0; i < datos_instalaciones.Rows.Count; i++)
            {
                ListItem li = new ListItem(datos_instalaciones.Rows[i][1].ToString(), datos_instalaciones.Rows[i][0].ToString());
                ddl_instalaciones.Items.Add(li);

            }
            
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            //selecciona la fecha del calendario y la pone en el text box
            DateTime fechaElegida = calendarioEstadisticas.SelectedDate;
            txt_fecha.Text = ""+fechaElegida.Year+"-"+fechaElegida.Month+"-"+fechaElegida.Day;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            cUDGDFRZNUSONegocios estadistica = new cUDGDFRZNUSONegocios(0, "", 0, "");
            estadistica.NUM_CANTUSUARIOS = Int32.Parse( txt_cantU.Text);
            estadistica.FEC_FECHA = DateTime.Parse( txt_fecha.Text);
            estadistica.FKY_INSTALACION = Int32.Parse( ddl_instalaciones.SelectedValue);

            estadistica.Insertar();
        }
    }
}