using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.UDSystem.Negocios;
using System.Data;
using System.IO;

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
            cUDGDFIMAGENNegocios cImagen = new cUDGDFIMAGENNegocios(0, "", 0, "");

            // Inserta la instalacion
            Nueva_Instalacion.NOM_INSTALACION = txt_nombre.Text.ToString();
            Nueva_Instalacion.DSC_INSTALACION = txt_descripcion.Value.ToString();
            Nueva_Instalacion.DSC_MEDIDAS = txt_medidas.Value.ToString();
            Nueva_Instalacion.TXT_REGLAMENTO = txt_reglamento.Value.ToString();
            Nueva_Instalacion.TXT_COSTOALQUILER = txt_costos.Value.ToString();
            Nueva_Instalacion.TXT_COMENTARIO = txt_comentarios.Value.ToString();

            Nueva_Instalacion.Insertar();
            idagregar = Int32.Parse(Nueva_Instalacion.ID_INSTALACION.ToString());

            // Insertar el calendario
            cUDGDFCALENDARIONegocios Nuevo_Calendario = new cUDGDFCALENDARIONegocios(0, "", 0, "");
            Nuevo_Calendario.FKY_INSTALACION = idagregar;
            Nuevo_Calendario.Insertar();

            // Inserta la imagen
            if (fu_IMAGE_UPLOAD.HasFile)
            {
                cImagen.IMG_INSTALACION = fu_IMAGE_UPLOAD.FileName;
                cImagen.FKY_INSTALACION = Nueva_Instalacion.ID_INSTALACION;
                cImagen.Insertar();
                if (!Directory.Exists("E:\\Imagenes"))
                    Directory.CreateDirectory("E:\\Imagenes");

                fu_IMAGE_UPLOAD.SaveAs("E:\\Imagenes\\" + fu_IMAGE_UPLOAD.FileName);
            }

            Server.Transfer("/CU_AdministrarInstalaciones/InsertaHorario.aspx", true);
        }
    }
}