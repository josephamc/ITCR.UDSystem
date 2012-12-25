using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITCR.UDSystem.Interfaz.CU_AdministrarInstalaciones
{
    public partial class InsertaImagenes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonFinalizarInstalacion_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Exito.aspx", true);
        }
    }
}