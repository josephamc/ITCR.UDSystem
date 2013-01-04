using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.UDSystem.Negocios;
using System.Data;

namespace ITCR.UDSystem.Interfaz.CU_AdministrarInstalaciones
{
    public partial class ConsultaInstalacion : System.Web.UI.Page
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
            Grid_Instalaciones.DataSource = tablaInstalaciones;
            Grid_Instalaciones.DataBind();
            errorEliminar01.Visible = false;
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            errorEliminar01.Visible = false;
            Grid_Instalaciones.EditIndex = e.NewEditIndex;

            int id = Convert.ToInt32(Grid_Instalaciones.DataKeys[e.NewEditIndex].Value.ToString());

            InsertaInstalacion insInst = new InsertaInstalacion();
            ideditar = id;

            Server.Transfer("/CU_AdministrarInstalaciones/EditaInstalacion.aspx", true);
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(Grid_Instalaciones.DataKeys[e.RowIndex].Value.ToString());

            try
            {
                cUDGDFCALENDARIONegocios calendario = new cUDGDFCALENDARIONegocios(0, "", 0, "");
                calendario.FKY_INSTALACION = id;
                calendario.FKY_INSTALACIONOld = id;
                calendario.EliminarTodo_Con_FKY_INSTALACION_FK();

                cUDGDFHORARIONegocios horarios = new cUDGDFHORARIONegocios(0, "", 0, "");
                horarios.FKY_INSTALACION = id;
                horarios.FKY_INSTALACIONOld = id;
                horarios.EliminarTodo_Con_FKY_INSTALACION_FK();

                cUDGDFIMAGENNegocios imagenes = new cUDGDFIMAGENNegocios(0, "", 0, "");
                imagenes.FKY_INSTALACION = id;
                imagenes.FKY_INSTALACIONOld = id;
                imagenes.EliminarTodo_Con_FKY_INSTALACION_FK();

                cUDGDFRZNUSONegocios estadisticas = new cUDGDFRZNUSONegocios(0, "", 0, "");
                estadisticas.FKY_INSTALACION = id;
                estadisticas.FKY_INSTALACIONOld = id;
                estadisticas.EliminarTodo_Con_FKY_INSTALACION_FK();

                cUDGDFINSTALACIONNegocios inst = new cUDGDFINSTALACIONNegocios(0, "", 0, "");
                inst.ID_INSTALACION = id;
                inst.Eliminar();

                Server.Transfer(Request.RawUrl);
            }
            catch (Exception)
            {
                errorEliminar01.Visible = true;
            }
        }
                
    }
}