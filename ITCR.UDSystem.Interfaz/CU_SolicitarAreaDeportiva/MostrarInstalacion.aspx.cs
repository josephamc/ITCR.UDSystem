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
    public partial class MostrarInstalacion : System.Web.UI.Page
    {
        private int ideditar = -1;
        public int IDeditar
        {
            get
            {
                return ideditar;
            }
        }
        cUDGDFINSTALACIONNegocios instalacion = new cUDGDFINSTALACIONNegocios(0, "", 0, "");
        protected void Page_Load(object sender, EventArgs e)
        {
            ideditar = -1;
            Grid_Instalaciones2.RowEditing += GridView1_RowEditing;
            DataTable tablaInstalacionesBase = instalacion.SeleccionarTodos();
            DataTable tablaInstalaciones = new DataTable();
            tablaInstalaciones.Columns.Add("identificacion");
            tablaInstalaciones.Columns.Add("  Nombre Instalacion          ");
            tablaInstalaciones.Columns.Add("  Descripcion Detallada de la Instalacion          ");


            for (int i = 0; i < tablaInstalacionesBase.Rows.Count; i++)
            {
                DataRow row = tablaInstalaciones.NewRow();
                row["identificacion"] = tablaInstalacionesBase.Rows[i][0];
                row["  Nombre Instalacion          "] = tablaInstalacionesBase.Rows[i][1];
                row["  Descripcion Detallada de la Instalacion          "] = tablaInstalacionesBase.Rows[i][2];

                tablaInstalaciones.Rows.Add(row);
            }
            Grid_Instalaciones2.DataSource = tablaInstalaciones;
            Grid_Instalaciones2.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Grid_Instalaciones2.EditIndex = e.NewEditIndex;
            int id = Convert.ToInt32(Grid_Instalaciones2.Rows[e.NewEditIndex].Cells[1].Text);

            //InsertaInstalacion insInst = new InsertaInstalacion();
            ideditar = id;

            Server.Transfer("/CU_SolicitarAreaDeportiva/FichaInstalacion.aspx", true);
        }

    }
}