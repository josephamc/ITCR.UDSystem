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
    public partial class InsertaHorario : System.Web.UI.Page
    {
        private int idAgregar = -1;
        cUDGDFHORARIONegocios Horario = new cUDGDFHORARIONegocios(0, "", 0, ""); 
        DataTable tablaHorarios;
        DataTable tablaHorariosFinal;

        protected void Page_Load(object sender, EventArgs e)
        {
            //TimeValidator2.Visible = false;
            try
            {
                idAgregar = PreviousPage.IDAgregar;
                lb_id.Text = idAgregar.ToString();
            }
            catch (Exception) { }

            ActualiceGrid();
        }

        protected void ButtonGuardarHoarario_Click(object sender, EventArgs e)
        {
            TimeValidator2.Visible = false;
            try
            {
                //Dim strDateTime As String = txtDate.Text & " " & txtTime.Text & " " & ddlAmPm.SelectedItem.Value
                string Inicio = txt_Inicio.Text + ":00 " + ddlAmPm1.SelectedItem.Value.ToString();
                string Fin = txt_Fin.Text + ":00 " + ddlAmPm2.SelectedItem.Value.ToString();

                DateTime Hoy = DateTime.Today;
                string fecha_actual = Hoy.ToString("dd-MM-yyyy");
                int IDInstalacion = Int32.Parse(lb_id.Text);

                if (ck_lunes.Checked == true)
                {
                    cUDGDFHORARIONegocios Nuevo_Horario_lunes = new cUDGDFHORARIONegocios(0, "", 0, "");
                    Nuevo_Horario_lunes.COD_DIA = 1;
                    Nuevo_Horario_lunes.FKY_INSTALACION = IDInstalacion;
                    Nuevo_Horario_lunes.HRA_INICIO = Convert.ToDateTime(/*fecha_actual + " "+ */ Inicio);
                    Nuevo_Horario_lunes.HRA_FIN = Convert.ToDateTime(/*fecha_actual + " " + */Fin);

                    Nuevo_Horario_lunes.Insertar();
                }
                if (ck_martes.Checked == true)
                {
                    cUDGDFHORARIONegocios Nuevo_Horario_martes = new cUDGDFHORARIONegocios(0, "", 0, "");
                    Nuevo_Horario_martes.COD_DIA = 2;
                    Nuevo_Horario_martes.FKY_INSTALACION = IDInstalacion;
                    Nuevo_Horario_martes.HRA_INICIO = Convert.ToDateTime(/*fecha_actual + " "+ */ Inicio);
                    Nuevo_Horario_martes.HRA_FIN = Convert.ToDateTime(/*fecha_actual + " " + */Fin);

                    Nuevo_Horario_martes.Insertar();
                }
                if (ck_miercoles.Checked == true)
                {
                    cUDGDFHORARIONegocios Nuevo_Horario_miercoles = new cUDGDFHORARIONegocios(0, "", 0, "");
                    Nuevo_Horario_miercoles.COD_DIA = 3;
                    Nuevo_Horario_miercoles.FKY_INSTALACION = IDInstalacion;
                    Nuevo_Horario_miercoles.HRA_INICIO = Convert.ToDateTime(/*fecha_actual + " "+ */ Inicio);
                    Nuevo_Horario_miercoles.HRA_FIN = Convert.ToDateTime(/*fecha_actual + " " + */Fin);

                    Nuevo_Horario_miercoles.Insertar();
                }
                if (ck_jueves.Checked == true)
                {
                    cUDGDFHORARIONegocios Nuevo_Horario_jueves = new cUDGDFHORARIONegocios(0, "", 0, "");
                    Nuevo_Horario_jueves.COD_DIA = 4;
                    Nuevo_Horario_jueves.FKY_INSTALACION = IDInstalacion;
                    Nuevo_Horario_jueves.HRA_INICIO = Convert.ToDateTime(/*fecha_actual + " "+ */ Inicio);
                    Nuevo_Horario_jueves.HRA_FIN = Convert.ToDateTime(/*fecha_actual + " " + */Fin);

                    Nuevo_Horario_jueves.Insertar();
                }
                if (ck_viernes.Checked == true)
                {
                    cUDGDFHORARIONegocios Nuevo_Horario_viernes = new cUDGDFHORARIONegocios(0, "", 0, "");
                    Nuevo_Horario_viernes.COD_DIA = 5;
                    Nuevo_Horario_viernes.FKY_INSTALACION = IDInstalacion;
                    Nuevo_Horario_viernes.HRA_INICIO = Convert.ToDateTime(/*fecha_actual + " "+ */ Inicio);
                    Nuevo_Horario_viernes.HRA_FIN = Convert.ToDateTime(/*fecha_actual + " " + */Fin);

                    Nuevo_Horario_viernes.Insertar();
                }
                if (ck_sabado.Checked == true)
                {
                    cUDGDFHORARIONegocios Nuevo_Horario_sabado = new cUDGDFHORARIONegocios(0, "", 0, "");
                    Nuevo_Horario_sabado.COD_DIA = 6;
                    Nuevo_Horario_sabado.FKY_INSTALACION = IDInstalacion;
                    Nuevo_Horario_sabado.HRA_INICIO = Convert.ToDateTime(/*fecha_actual + " "+ */ Inicio);
                    Nuevo_Horario_sabado.HRA_FIN = Convert.ToDateTime(/*fecha_actual + " " + */Fin);

                    Nuevo_Horario_sabado.Insertar();
                }
                if (ck_domingo.Checked == true)
                {
                    cUDGDFHORARIONegocios Nuevo_Horario_domingo = new cUDGDFHORARIONegocios(0, "", 0, "");
                    Nuevo_Horario_domingo.COD_DIA = 7;
                    Nuevo_Horario_domingo.FKY_INSTALACION = IDInstalacion;
                    Nuevo_Horario_domingo.HRA_INICIO = Convert.ToDateTime(/*fecha_actual + " "+ */ Inicio);
                    Nuevo_Horario_domingo.HRA_FIN = Convert.ToDateTime(/*fecha_actual + " " + */Fin);

                    Nuevo_Horario_domingo.Insertar();
                }

                ActualiceGrid();
            }
            catch (Exception)
            {                
                TimeValidator2.Visible = true;
            }
        }
        private void ActualiceGrid()
        {
            //TimeValidator2.Visible = false;
            Horario.FKY_INSTALACION = Int32.Parse(lb_id.Text);
            Horario.FKY_INSTALACIONOld = Int32.Parse(lb_id.Text);
            tablaHorarios = Horario.SeleccionarTodos_Con_FKY_INSTALACION_FK();

            tablaHorariosFinal = new DataTable();
            tablaHorariosFinal.Columns.Add("ident");
            tablaHorariosFinal.Columns.Add("Dia de la Semana");
            tablaHorariosFinal.Columns.Add("Hora Inicio");
            tablaHorariosFinal.Columns.Add("Hora Fin");

            for (int i = 0; i < tablaHorarios.Rows.Count; i++)
            {
                string dia;
                switch (Int32.Parse(tablaHorarios.Rows[i][4].ToString()))
                {
                    case 1:
                        dia = "Lunes";
                        break;
                    case 2:
                        dia = "Martes";
                        break;
                    case 3:
                        dia = "Miércoles";
                        break;
                    case 4:
                        dia = "Jueves";
                        break;
                    case 5:
                        dia = "Viernes";
                        break;
                    case 6:
                        dia = "Sabado";
                        break;
                    case 7:
                        dia = "Domingo";
                        break;
                    default:
                        dia = "";
                        break;
                }

                DataRow row = tablaHorariosFinal.NewRow();
                row["ident"] = tablaHorarios.Rows[i][0];
                row["Dia de la Semana"] = dia;
                row["Hora Inicio"] = tablaHorarios.Rows[i][1];
                row["Hora Fin"] = tablaHorarios.Rows[i][2];

                tablaHorariosFinal.Rows.Add(row);
            }

            Grid_Horarios.DataSource = tablaHorariosFinal;
            Grid_Horarios.DataBind();
        }

        protected void ButtonCont2_Click(object sender, EventArgs e)
        {
            TimeValidator2.Visible = false;
            //Response.Redirect("~/CU_AdministrarInstalaciones/InsertaImagenes.aspx", true);
            Server.Transfer("~/Exito.aspx", true);
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(Grid_Horarios.DataKeys[e.RowIndex].Value.ToString());

            cUDGDFHORARIONegocios horario = new cUDGDFHORARIONegocios(0, "", 0, "");
            horario.ID_HORARIO = id;
            horario.Eliminar();

            ActualiceGrid();
        }
    }
}