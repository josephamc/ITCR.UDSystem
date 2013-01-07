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
            cUDGDFINSTALACIONNegocios instalacion = new cUDGDFINSTALACIONNegocios(0, "", 0, "");
            DataTable datos_instalaciones = instalacion.SeleccionarTodos();
            DataTable tablaInstalaciones = new DataTable();
            tablaInstalaciones.Columns.Add("nombre");

            for (int i = 0; i < datos_instalaciones.Rows.Count; i++)
            {
                DataRow row = tablaInstalaciones.NewRow();
                row["nombre"] = datos_instalaciones.Rows[i][1];

                tablaInstalaciones.Rows.Add(row);
            }

            ddl_instalaciones.DataSource = tablaInstalaciones;
            ddl_instalaciones.DataBind();
        }
    }
}