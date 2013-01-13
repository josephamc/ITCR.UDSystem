using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ITCR.UDSystem.Negocios;

namespace ITCR.UDSystem.Interfaz.GestionarSolicitudes
{
    public partial class frmSolicitud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dgSolicitudes.RowEditing += this.GridViewEditing;
            
            // Carga las solicitudes no atendidas
            cUDGDFSOLICITUDNegocios cSolicitud = new cUDGDFSOLICITUDNegocios(0, "", 0, "");
            DataTable dtSolicitudes = cSolicitud.ConsultarSolicitudes(false);
            DataTable dtBindingSource = new DataTable("SOLICITUDES");

            dtBindingSource.Columns.Add("Id Solicitud");
            dtBindingSource.Columns.Add("Solicitante");
            dtBindingSource.Columns.Add("Fecha Solicitud");
            dtBindingSource.Columns.Add("Instalacion");
            dtBindingSource.Columns.Add("Fecha Inicio");
            dtBindingSource.Columns.Add("Fecha fin");
            dtBindingSource.Columns.Add("Hora inicio");
            dtBindingSource.Columns.Add("Hora fin");

            foreach (DataRow drRow in dtSolicitudes.Rows)
            {
                dtBindingSource.Rows.Add(drRow[0].ToString(), drRow[6].ToString(), ((DateTime)drRow[3]).ToShortDateString(), drRow[15].ToString(),
                    ((DateTime)drRow[1]).ToShortDateString(), ((DateTime)drRow[2]).ToShortDateString(), drRow[4].ToString(), drRow[5].ToString());
            }

            dgSolicitudes.DataSource = dtBindingSource;
            dgSolicitudes.DataBind();
        }

        protected void btnActualizar_Click(object sender, ImageClickEventArgs e)
        {
            // Carga las solicitudes no atendidas
            cUDGDFSOLICITUDNegocios cSolicitud = new cUDGDFSOLICITUDNegocios(0, "", 0, "");
            DataTable dtSolicitudes = cSolicitud.ConsultarSolicitudes(false);
            DataTable dtBindingSource = new DataTable("SOLICITUDES");

            dtBindingSource.Columns.Add("Id Solicitud");
            dtBindingSource.Columns.Add("Solicitante");
            dtBindingSource.Columns.Add("Fecha Solicitud");
            dtBindingSource.Columns.Add("Instalacion");
            dtBindingSource.Columns.Add("Fecha Inicio");
            dtBindingSource.Columns.Add("Fecha fin");
            dtBindingSource.Columns.Add("Hora inicio");
            dtBindingSource.Columns.Add("Hora fin");

            foreach (DataRow drRow in dtSolicitudes.Rows)
            {
                dtBindingSource.Rows.Add(drRow[0].ToString(), drRow[6].ToString(), ((DateTime)drRow[3]).ToShortDateString(), drRow[15].ToString(),
                    ((DateTime)drRow[1]).ToShortDateString(), ((DateTime)drRow[2]).ToShortDateString(), drRow[4].ToString(), drRow[5].ToString());
            }

            dgSolicitudes.DataSource = dtBindingSource;
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