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
    public partial class InsertaInstalacion : System.Web.UI.Page
    {
        private int idagregar = -1;
        public int IDAgregar
        {
            get
            {
                return idagregar;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cUDGDFINSTALACIONNegocios Nueva_Instalacion = new cUDGDFINSTALACIONNegocios(0, "",0, "");
            Nueva_Instalacion.NOM_INSTALACION = txt_nombre.Text.ToString();
            Nueva_Instalacion.DSC_INSTALACION = txt_descripcion.Value.ToString();
            Nueva_Instalacion.DSC_MEDIDAS = txt_medidas.Value.ToString();
            Nueva_Instalacion.TXT_REGLAMENTO = txt_reglamento.Value.ToString();
            Nueva_Instalacion.TXT_COSTOALQUILER = txt_costos.Value.ToString();
            Nueva_Instalacion.TXT_COMENTARIO = txt_comentarios.Value.ToString();

            Nueva_Instalacion.Insertar();
            idagregar = Int32.Parse(Nueva_Instalacion.ID_INSTALACION.ToString());

            cUDGDFCALENDARIONegocios Nuevo_Calendario = new cUDGDFCALENDARIONegocios(0, "", 0, "");
            Nuevo_Calendario.FKY_INSTALACION = idagregar;
            Nuevo_Calendario.Insertar();

   
            Response.Redirect("~/CU_AdministrarInstalaciones/InsertaHorario.aspx", true);
        }
    }
}