﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.UDSystem.Negocios;
using System.Data;

namespace ITCR.UDSystem.Interfaz.CU_AdministrarCalendario
{
    public partial class frmSolicitud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Obtiene la informacion de la solicitud seleccionada
            int iID_SOLICITUD = int.Parse(Request.QueryString["sol"].ToString());

            cUDGDFSOLICITUDNegocios cSolicitud = new cUDGDFSOLICITUDNegocios(0, "", 0, "");
            DataTable dtSolicitud = cSolicitud.BuscarConId(iID_SOLICITUD);

            foreach (DataRow drRow in dtSolicitud.Rows)
            {
                lblInstalacion.Text = drRow[15].ToString();//
                lblfecSolicitud.Text = ((DateTime)drRow[3]).ToShortDateString();//
                lblfecini.Text = ((DateTime)drRow[1]).ToShortDateString();//
                lblfecfin.Text = ((DateTime)drRow[2]).ToShortDateString();//
                lblhraini.Text = drRow[4].ToString();//
                lblhrafin.Text = drRow[5].ToString();//
                lblinstsolicitante.Text = drRow[7].ToString();//
                lblresponsable.Text = drRow[6].ToString();//
                lblidentificacion.Text = drRow[8].ToString();//
                lblcantidadh.Text = drRow[13].ToString();
                lblcantidadm.Text = drRow[14].ToString();
                lbltipo.Text = drRow[16].ToString();
                lblrznuso.Text = drRow[10].ToString();

                String sUsuarioString = drRow[17].ToString();
                String sLabelUsuarios = "";
                String[] sUsuarios = sUsuarioString.Split(',');
                foreach (String sRow in sUsuarios)
                {
                    sLabelUsuarios += sRow + "<br>";
                }

                lblusuarios.Text = sLabelUsuarios;
            }
        }
    }//class
}//namspace