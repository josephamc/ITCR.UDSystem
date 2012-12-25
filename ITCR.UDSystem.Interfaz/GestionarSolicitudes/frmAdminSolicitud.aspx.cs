using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ITCR.UDSystem.Interfaz.GestionarSolicitudes
{
    public partial class frmSolicitud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dgSolicitudes.RowEditing += this.GridViewEditing;
        }

        protected void btnActualizar_Click(object sender, ImageClickEventArgs e)
        {
            DataTable dtSolicitudes = new DataTable();
            dtSolicitudes.Columns.Add("Solicitudes");
            dtSolicitudes.Rows.Add("Example");

            dgSolicitudes.DataSource = dtSolicitudes;
            dgSolicitudes.DataBind();
        }

        /// <summary>
        /// Evento que se ejecuta cuando se selecciona un elemento del gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridViewEditing(object sender, GridViewEditEventArgs e)
        {
            String sSolicitud = dgSolicitudes.Rows[e.NewEditIndex].Cells[1].Text;
            Response.Redirect("~/GestionarSolicitudes/frmSolicitud.aspx?sol=" + sSolicitud, true);
        }
    }
}