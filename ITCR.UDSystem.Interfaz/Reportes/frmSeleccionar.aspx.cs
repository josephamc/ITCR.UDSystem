using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.UDSystem.Negocios.ClasesNegocios;
using System.IO;

namespace ITCR.UDSystem.Interfaz.Reportes
{
    public partial class frmSeleccionar : System.Web.UI.Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{

        //}

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            cReporte rptReservaciones = new cReporte(true, txtInicio.Text, txtFin.Text);
            Root.Reports.Report rptFile = rptReservaciones.Generar();
            if (rblOpciones.SelectedItem.Text.CompareTo("Documento Web") == 0)
                // Muestra el archivo en formato Web
                Root.Reports.RT.ResponsePDF(rptFile, this);
            else
            {
                // Inicia la descarga del archivo
                MemoryStream stream = new MemoryStream();
                rptFile.formatter.Create(rptFile, stream);
                Response.Clear();
                Response.ContentType = "application/pdf";
                Response.AddHeader("content-Disposition: attachment; filename=" + txtInicio.Text.Replace("/", "") + " - " + txtFin.Text.Replace("/", ""), "Reporte.pdf");
                Response.BinaryWrite(stream.ToArray());
                Response.Flush();
                stream.Close();
                Response.End();
            }
        }
    }//class
}//namespace