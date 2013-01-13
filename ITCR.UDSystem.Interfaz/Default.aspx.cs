using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITCR.UDSystem.Interfaz
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "TEC - " + Global.gSubTituloPagina;
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://www.estudiantec.cr", true);
        }

        protected void lnkError_Click(object sender, EventArgs e)
        {
            Session.Add("ObjetoError", new Exception("Mensaje de error"));
            cUtilInterfaz.AgregarCodError(this);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CU_AdministrarInstalaciones/ConsultaInstalacion.aspx", true);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("CU_AdministrarCalendario/IndiceCalendario.aspx", true);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("GestionarSolicitudes/frmAdminSolicitud.aspx", true);

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("CU_SolicitarAreaDeportiva/MostrarInstalacion.aspx", true);

        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            Response.Redirect("CU_EstadisticasUso/IndiceEstadisticas.aspx", true);
        }
    
    }

}
