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
            error_usuarios.Visible = false;
            fieldset_exito.Visible = false;
            if (!IsPostBack)
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
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            //selecciona la fecha del calendario y la pone en el text box
            DateTime fechaElegida = calendarioEstadisticas.SelectedDate;
            txt_fecha.Text = ""+fechaElegida.Year+"-"+fechaElegida.Month+"-"+fechaElegida.Day;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                error_usuarios.Visible = false;
                cUDGDFRZNUSONegocios estadistica = new cUDGDFRZNUSONegocios(0, "", 0, "");
                estadistica.NUM_CANTUSUARIOS = Int32.Parse(txt_cantU.Text);
                estadistica.FEC_FECHA = DateTime.Parse(txt_fecha.Text);
                estadistica.FKY_INSTALACION = Int32.Parse(ddl_instalaciones.SelectedValue);

                estadistica.Insertar();
                inst.Text = ddl_instalaciones.SelectedItem.Text;
                usu.Text = txt_cantU.Text;
                fecha.Text = txt_fecha.Text;
                fieldset_exito.Visible = true;

                txt_cantU.Text ="";
            }
            catch (Exception o)
            {
                String msj = o.Message;
                error_usuarios.Visible = true;
            }
        }

        protected void txt_cantU_TextChanged(object sender, EventArgs e)
        {
        }

        protected void ddl_instalaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}