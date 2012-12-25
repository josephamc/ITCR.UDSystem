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
    public partial class EditaInstalacion : System.Web.UI.Page
    {
        private int IDinstalacionPrevia = -1;
        private int enEdicion = -1;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                IDinstalacionPrevia = PreviousPage.IDeditar;
                if (IDinstalacionPrevia != -1)
                {
                    enEdicion = IDinstalacionPrevia;
                    cUDGDFINSTALACIONNegocios instalacionBase = new cUDGDFINSTALACIONNegocios(0, "", 0, "");
                    instalacionBase.ID_INSTALACION = IDinstalacionPrevia;
                    DataTable tabla = instalacionBase.SeleccionarUno();

                    txt_id.Text = instalacionBase.ID_INSTALACION.ToString();
                    txt_nombre2.Text = instalacionBase.NOM_INSTALACION.ToString();
                    txt_descripcion2.Value = instalacionBase.DSC_INSTALACION.ToString();
                    txt_medidas2.Value = instalacionBase.DSC_MEDIDAS.ToString();
                    txt_reglamento2.Value = instalacionBase.TXT_REGLAMENTO.ToString();
                    txt_costos2.Value = instalacionBase.TXT_COSTOALQUILER.ToString();
                    string comentarios = instalacionBase.TXT_COMENTARIO.ToString();
                    if (comentarios != null)
                    {
                        txt_comentarios2.Value = comentarios;
                    }
                    else
                    {
                        txt_comentarios2.Value = "";
                    }
                }
                IDinstalacionPrevia = -1;
            }
            catch (Exception o) { }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            enEdicion = Int32.Parse(txt_id.Text.ToString());
            if (enEdicion != -1)
            {
                cUDGDFINSTALACIONNegocios Nueva_Instalacion = new cUDGDFINSTALACIONNegocios(0, "", 0, "");
                Nueva_Instalacion.ID_INSTALACION = enEdicion;
                Nueva_Instalacion.NOM_INSTALACION = txt_nombre2.Text.ToString();
                Nueva_Instalacion.DSC_INSTALACION = txt_descripcion2.Value.ToString();
                Nueva_Instalacion.DSC_MEDIDAS = txt_medidas2.Value.ToString();
                Nueva_Instalacion.TXT_REGLAMENTO = txt_reglamento2.Value.ToString();
                Nueva_Instalacion.TXT_COSTOALQUILER = txt_costos2.Value.ToString();
                Nueva_Instalacion.TXT_COMENTARIO = txt_comentarios2.Value.ToString();

                Nueva_Instalacion.Actualizar();
                Server.Transfer("~/Exito2.aspx", true);
            }
        }

    }
}