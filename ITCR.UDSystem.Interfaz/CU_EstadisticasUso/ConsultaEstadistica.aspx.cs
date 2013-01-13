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
    public partial class ConsultaEstadistica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cal01.Visible = false;
                cal02.Visible = false;
                datos_generales.Visible = false;

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

        protected void Button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (rb_tipo.SelectedValue.Equals("1"))
                {
                    //consulta informacion
                    cUDGDFINSTALACIONNegocios instalacion = new cUDGDFINSTALACIONNegocios(0, "", 0, "");
                    instalacion.ID_INSTALACION = Int32.Parse(ddl_instalaciones.SelectedValue.ToString());
                    DataTable datos_instalaciones = instalacion.SeleccionarUno();

                    data01.DataSource = CreateDataSource(datos_instalaciones);
                    data01.DataBind();
                    datos_generales.Visible = true;
                }
                else
                {
                    //consulta informacion
                    cUDGDFINSTALACIONNegocios instalacion = new cUDGDFINSTALACIONNegocios(0, "", 0, "");
                    DataTable datos_instalaciones = instalacion.SeleccionarTodos();

                    data01.DataSource = CreateDataSource(datos_instalaciones);
                    data01.DataBind();
                    datos_generales.Visible = true;
                }
            //}
            //catch (Exception o)
            //{
            //    String msj = o.Message;

            //}
        }


        protected DataView CreateDataSource(DataTable datos_instalaciones)
        {

            //incluye el rango de fechas
            rango_ini.Text = txt_fechaIni.Text;
            rango_fin.Text = txt_fechaFin.Text;

            // crea lista de datos
            DataTable dt = new DataTable();
            DataRow dr;

            // define las columnas de la tabla
            dt.Columns.Add(new DataColumn("instalacion", typeof(String)));
            dt.Columns.Add(new DataColumn("usuarios", typeof(Int32)));
            
            for (int i = 0; i < datos_instalaciones.Rows.Count; i++)
            {
                cUDGDFRZNUSONegocios estadistica = new cUDGDFRZNUSONegocios(0, "", 0, "");
                estadistica.FKY_INSTALACION = Int32.Parse(datos_instalaciones.Rows[i][0].ToString());
                DataTable datos_estadistica = estadistica.SeleccionarTodos_Con_FKY_INSTALACION_FK();

                String nombre_instalacion = datos_instalaciones.Rows[i][1].ToString();
                int cant_usuarios = 0;
                
                DateTime fecha_ini = DateTime.Parse(txt_fechaIni.Text);
                DateTime fecha_fin = DateTime.Parse(txt_fechaFin.Text);
                for (int n = 0; n < datos_estadistica.Rows.Count; n++)
                {
                    DateTime fecha = DateTime.Parse(datos_estadistica.Rows[n][2].ToString());
                    int result1 = DateTime.Compare(fecha,fecha_ini);
                    int result2 = DateTime.Compare(fecha,fecha_fin);

                    if (result1 >= 0 && result2 <= 0)
                    {
                        cant_usuarios += Int32.Parse(datos_estadistica.Rows[n][1].ToString());
                    }
                }
                dr = dt.NewRow();

                dr[0] = nombre_instalacion;
                dr[1] = cant_usuarios;
                dt.Rows.Add(dr);
            }

            DataView dv = new DataView(dt);
            return dv;            
        }

        protected void cal01_SelectionChanged(object sender, EventArgs e)
        {
            //selecciona la fecha del calendario y la pone en el text box
            DateTime fechaElegida = cal01.SelectedDate;
            txt_fechaIni.Text = "" + fechaElegida.Year + "-" + fechaElegida.Month + "-" + fechaElegida.Day;
            cal01.Visible = false;
            cal02.Visible = false;
        }

        protected void cal02_SelectionChanged(object sender, EventArgs e)
        {
            //selecciona la fecha del calendario y la pone en el text box
            DateTime fechaElegida = cal02.SelectedDate;
            txt_fechaFin.Text = "" + fechaElegida.Year + "-" + fechaElegida.Month + "-" + fechaElegida.Day;
            cal01.Visible = false;
            cal02.Visible = false;
        }

        protected void elegir01_Click(object sender, EventArgs e)
        {
            cal02.Visible = false;
            cal01.Enabled = true;
            cal01.Visible = true;
        }

        protected void elegir02_Click(object sender, EventArgs e)
        {
            cal01.Visible = false;
            cal02.Enabled = true;
            cal02.Visible = true;
        }

    }
}