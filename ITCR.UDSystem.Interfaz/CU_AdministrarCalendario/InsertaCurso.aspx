﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertaCurso.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.CU_AdministrarCalendario.InsertaCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Insertar Cursos de Docencia</h2>
    <br />
    <div id="imglogo">
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <img src="../../imagenes/ImgND2.png" alt=""/>
    </div>
    <br />
    <div>
        <table>
            <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_nombre" runat="server" Text="Nombre del Curso:" 
                        style="font-weight: 700"></asp:Label></td>
                <td><asp:TextBox ID="txt_nombreCurso" runat="server" Width="227px"></asp:TextBox> </td>
            </tr>

            <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_instalacion" runat="server" 
                        Text="Instalacion donde será el curso:" style="font-weight: 700"></asp:Label></td>
                <td><asp:DropDownList ID="dp_instalacionCurso" runat="server" Height="18px" 
                        Width="227px">
                </asp:DropDownList></td>
            </tr>
            
            <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_prof" runat="server" Text="Profesor que lo imparte:" 
                        style="font-weight: 700"></asp:Label></td>
                <td><asp:TextBox ID="txt_profesor" runat="server" Width="227px"></asp:TextBox> </td>
            </tr>

            <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_descripcion" runat="server" Text="Descripción del Curso:" 
                        style="font-weight: 700"></asp:Label></td>
                <td><textarea id="txt_descripcionCurso" cols= "75" rows="7" runat="server"></textarea></td>
            </tr>
        </table>
        <br />
        <table>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
                        BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" 
                        ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" 
                        VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" 
                        Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                    </asp:Calendar>
                </td>

                <td><table>
                    <tr>
                        <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                        <td><asp:Label ID="lb_Fecha1" runat="server" Text="Fecha Inicio:" 
                                style="font-weight: 700"></asp:Label></td>
                        <td><asp:TextBox ID="txt_FechaInicio" runat="server" Width="227px"></asp:TextBox> </td>
                    </tr>
            
                    <tr>
                        <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                        <td><asp:Label ID="lb_Fecha2" runat="server" Text="Fecha Fin:" 
                                style="font-weight: 700"></asp:Label></td>
                        <td><asp:TextBox ID="txt_FechaFin" runat="server" Width="227px"></asp:TextBox> </td>
                    </tr>
                </table>

                <div>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label3" runat="server" 
                        Text="Formato de Fecha dd/MM/yyyy , ejemplo: 23/12/2012" 
                        style="font-style: italic"></asp:Label>
                </div>

                &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;

                <table>
                    <tr>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                        <td><asp:Label ID="hra_inicio" runat="server" Text="Hora Inicio:" 
                                style="font-weight: 700"></asp:Label></td>
                        <td><asp:TextBox ID="txt_HoraInicio" runat="server" Width="90px"></asp:TextBox></td>
                        <td><asp:DropDownList ID="ddlAmPm1" runat="server">
                           <asp:ListItem Selected="True">AM</asp:ListItem>
                           <asp:ListItem Selected="False">PM</asp:ListItem>
                        </asp:DropDownList></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_HoraInicio" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                        <td><asp:RegularExpressionValidator ID="TimeValidator2" runat="server" ControlToValidate="txt_HoraInicio" Display="Dynamic" ErrorMessage="Hora Invalida. Ingrese la hora en un formato adecuado, ejemplo: 12:30 o 5:00" ValidationExpression="^(1[0-2]|[1-9]):[0-5][0-9]$" EnableClientScript="False"></asp:RegularExpressionValidator></td>
                    </tr>
        
                    <tr>            
                        <td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                        <td><asp:Label ID="hra_fin" runat="server" Text="Hora Fin:" 
                                style="font-weight: 700"></asp:Label></td>
                        <td><asp:TextBox ID="txt_HoraFin" runat="server" Width="90px"></asp:TextBox></td>
                        <td><asp:DropDownList ID="ddlAmPm2" runat="server">
                           <asp:ListItem Selected="True">AM</asp:ListItem>
                           <asp:ListItem Selected="False">PM</asp:ListItem>
                        </asp:DropDownList></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_HoraFin" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                        <td><asp:RegularExpressionValidator ID="TimeValidator1" runat="server" ControlToValidate="txt_HoraFin" Display="Dynamic" ErrorMessage="Hora Invalida. Ingrese la hora en un formato adecuado, ejemplo: 12:30 o 5:00" ValidationExpression="^(1[0-2]|[1-9]):[0-5][0-9]$" EnableClientScript="False"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                </table>
                
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Formato de Hora hh:mm , ejemplo: 12:45" 
                        style="font-style: italic"></asp:Label>
                        
                &nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
                &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:CheckBox Text="Lunes" ID="ck_lunes"  runat="server" />
                <asp:CheckBox Text="Martes" ID="ck_martes"   runat="server" />
                <asp:CheckBox Text="Miercoles" ID="ck_miercoles"   runat="server" />
                <asp:CheckBox Text="Jueves" ID="ck_jueves"   runat="server" />
                <asp:CheckBox Text="Viernes" ID="ck_viernes"   runat="server" />
                <asp:CheckBox Text="Sabado" ID="ck_sabado"   runat="server" />
                <asp:CheckBox Text="Domingo" ID="ck_domingo"   runat="server" /></td>   
            </tr>    
        </table>
    </div>
    <div>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="boton_añadir_evento" runat="server" Text="Añadir Curso" 
            Width="223px" Height="29px" />
    </div>
</asp:Content>
