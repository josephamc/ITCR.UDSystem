using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITCR.UDSystem.Interfaz
{
    public partial class frmErrorCheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btn_redirect.Attributes.Add("onclick", "javascript:history.go(-1);return false");
        }
    }
}