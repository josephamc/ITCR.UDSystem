﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.UDSystem.Negocios.ClasesNegocios;
using ITCR.UDSystem.Negocios;
using System.IO;
using System.Data;

namespace ITCR.UDSystem.Interfaz.Reportes
{
    public partial class Seleccionar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                datos_generales.Visible = false;

                //rellena el dropdown list de las instalaciones
                cUDGDFINSTALACIONNegocios instalacion = new cUDGDFINSTALACIONNegocios(0, "", 0, "");
                DataTable datos_instalaciones = instalacion.SeleccionarTodos();

                for (int i = 0; i < datos_instalaciones.Rows.Count; i++)
                {
                    ListItem li = new ListItem(datos_instalaciones.Rows[i][1].ToString(), datos_instalaciones.Rows[i][0].ToString());
                    ddl_instalaciones.Items.Add(li);

                }
            }
        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            if (rb_tipoReporte.SelectedValue.Equals("1"))
            {
                //CREA REPORTE DE RESERVACIONES
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
            else
            {
                //CREAR REPORTE DE ESTADISTICAS
                if (rblOpciones.SelectedItem.Text.CompareTo("Documento Web") == 0)
                {
                    if (rb_tipo.SelectedValue.Equals("1"))
                    {
                        //consulta informacion
                        cUDGDFINSTALACIONNegocios instalacion = new cUDGDFINSTALACIONNegocios(0, "", 0, "");
                        instalacion.ID_INSTALACION = Int32.Parse(ddl_instalaciones.SelectedValue.ToString());
                        DataTable datos_instalaciones = instalacion.SeleccionarUno();

                        data01.DataSource = CreateDataSource(datos_instalaciones);
                        data01.DataBind();
                        datos_generales.Visible = true;
                    }
                    else
                    {
                        //consulta informacion
                        cUDGDFINSTALACIONNegocios instalacion = new cUDGDFINSTALACIONNegocios(0, "", 0, "");
                        DataTable datos_instalaciones = instalacion.SeleccionarTodos();

                        data01.DataSource = CreateDataSource(datos_instalaciones);
                        data01.DataBind();
                        datos_generales.Visible = true;
                    }
                }
                else
                {

                }
            }
        }

        protected DataView CreateDataSource(DataTable datos_instalaciones)
        {

            //incluye el rango de fechas
            rango_ini.Text = txtInicio.Text;
            rango_fin.Text = txtFin.Text;

            // crea lista de datos
            DataTable dt = new DataTable();
            DataRow dr;

            // define las columnas de la tabla
            dt.Columns.Add(new DataColumn("instalacion", typeof(String)));
            dt.Columns.Add(new DataColumn("usuarios", typeof(Int32)));

            for (int i = 0; i < datos_instalaciones.Rows.Count; i++)
            {
                cUDGDFRZNUSONegocios estadistica = new cUDGDFRZNUSONegocios(0, "", 0, "");
                estadistica.FKY_INSTALACION = Int32.Parse(datos_instalaciones.Rows[i][0].ToString());
                DataTable datos_estadistica = estadistica.SeleccionarTodos_Con_FKY_INSTALACION_FK();

                String nombre_instalacion = datos_instalaciones.Rows[i][1].ToString();
                int cant_usuarios = 0;

                DateTime fecha_ini = DateTime.Parse(txtInicio.Text);
                DateTime fecha_fin = DateTime.Parse(txtFin.Text);
                for (int n = 0; n < datos_estadistica.Rows.Count; n++)
                {
                    DateTime fecha = DateTime.Parse(datos_estadistica.Rows[n][2].ToString());
                    int result1 = DateTime.Compare(fecha, fecha_ini);
                    int result2 = DateTime.Compare(fecha, fecha_fin);

                    if (result1 >= 0 && result2 <= 0)
                    {
                        cant_usuarios += Int32.Parse(datos_estadistica.Rows[n][1].ToString());
                    }
                }
                dr = dt.NewRow();

                dr[0] = nombre_instalacion;
                dr[1] = cant_usuarios;
                dt.Rows.Add(dr);
            }

            DataView dv = new DataView(dt);
            return dv;
        }

        protected void rb_tipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb_tipoReporte.SelectedValue.Equals("1"))
            {
                txtfield_formatoEstadisticas.Visible = false;
                datos_generales.Visible = false;
            }
            else
            {
                txtfield_formatoEstadisticas.Visible = true;
            }
        }


    }
}