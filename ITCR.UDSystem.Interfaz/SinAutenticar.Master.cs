﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITCR.UDSystem.Interfaz
{
    public partial class SinAutenticarMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                lblTitulo.Text = Global.gSubTituloPagina;
                Page.Title = "TEC - " + Global.gSubTituloPagina;
                lblPiePagina.Text = Global.gPiePagina;
            }
        }
    }
}
