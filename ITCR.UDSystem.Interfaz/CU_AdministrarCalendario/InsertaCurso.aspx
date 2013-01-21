<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertaCurso.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.CU_AdministrarCalendario.InsertaCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 231px;
        }
        .style2
        {
            width: 289px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Administrador -->
    <ajaxToolkit:ToolkitScriptManager ID="tkManager" runat="server"></ajaxToolkit:ToolkitScriptManager>

    <h2>Insertar Cursos de Docencia</h2>
    <br />
    <div id="imglogo">
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <img src="../../imagenes/cursos01.JPG" alt=""/>
    </div>
    <br />
    <div>
        <table>
            <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_nombre" runat="server" Text="Nombre del Curso:" 
                        style="font-weight: 700"></asp:Label></td>
                <td><asp:TextBox ID="txt_nombreCurso" runat="server" Width="227px"></asp:TextBox> 
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txt_nombreCurso" ErrorMessage="Este campo no puede ser vacio" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="ValidaSolicitante" runat="server" ControlToValidate="txt_nombreCurso"  ErrorMessage="*" ValidationExpression="^[A-Z0-9 a-z]*" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                       
                    <asp:Label ID="lbl_ErrorNombre" runat="server" 
                        Text="El nombre que desea seleccionar esta ocupado" Visible="False" 
                        ForeColor="Red"></asp:Label>
                </td>
            </tr>

            <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_instalacion" runat="server" 
                        Text="Instalacion donde será el curso:" style="font-weight: 700"></asp:Label></td>
                <td><asp:DropDownList ID="ddl_instalacionCurso" runat="server" Height="18px" 
                        Width="227px">
                </asp:DropDownList></td>
            </tr>
            
            <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_prof" runat="server" Text="Profesor que lo imparte:" 
                        style="font-weight: 700"></asp:Label></td>
                <td><asp:TextBox ID="txt_profesor" runat="server" Width="227px"></asp:TextBox> </td>
                <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txt_profesor" ErrorMessage="Este campo no puede ser vacio" ForeColor="Red"></asp:RequiredFieldValidator>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_profesor"  ErrorMessage="*" ValidationExpression="^[A-Z0-9 a-z]*" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                       
                </td>
            </tr>

            <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <table>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td>
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/time2.jpg" 
                        Width="368px" />
                </td>

                <td><table>
                    <tr>
                        <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                        <td><asp:Label ID="lb_Fecha1" runat="server" Text="Fecha Inicio:" 
                                style="font-weight: 700"></asp:Label></td>
                        <td class="style2">
                           <asp:TextBox ID="txt_FechaInicio" runat="server" Width="227px"></asp:TextBox> 
                            <ajaxToolkit:CalendarExtender
                                   ID="cldExtender" TargetControlID="txt_FechaInicio" PopupButtonID="imgCalendar" 
                                   runat="server" Format="dd/MM/yyyy">
                            </ajaxToolkit:CalendarExtender>
                            <img id="imgCalendar" align="middle" alt="" src="../imagenes/date.png" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txt_FechaInicio" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_FechaInicio"  ErrorMessage="Fecha inválida. Ingrese la fecha en un formato adecuado, ejemplo: 31/12/2012" ValidationExpression="^(?:(?:0?[1-9]|1\d|2[0-8])(\/|-)(?:0?[1-9]|1[0-2]))(\/|-)(?:[1-9]\d\d\d|\d[1-9]\d\d|\d\d[1-9]\d|\d\d\d[1-9])$|^(?:(?:31(\/|-)(?:0?[13578]|1[02]))|(?:(?:29|30)(\/|-)(?:0?[1,3-9]|1[0-2])))(\/|-)(?:[1-9]\d\d\d|\d[1-9]\d\d|\d\d[1-9]\d|\d\d\d[1-9])$|^(29(\/|-)0?2)(\/|-)(?:(?:0[48]00|[13579][26]00|[2468][048]00)|(?:\d\d)?(?:0[48]|[2468][048]|[13579][26]))$" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
            
                    <tr>
                        <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                        <td><asp:Label ID="lb_Fecha2" runat="server" Text="Fecha Fin:" 
                                style="font-weight: 700"></asp:Label></td>
                        <td class="style2"><asp:TextBox ID="txt_FechaFin" runat="server" Width="227px"></asp:TextBox> 
                            <ajaxToolkit:CalendarExtender
                                   ID="CalendarExtender1" TargetControlID="txt_FechaFin" PopupButtonID="imgCalendarFin" 
                                   runat="server" Format="dd/MM/yyyy">
                            </ajaxToolkit:CalendarExtender>
                            <img id="imgCalendarFin" align="middle" alt="" src="../imagenes/date.png" />
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_FechaFin" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                             <asp:RegularExpressionValidator ID="DateValidator1" runat="server" ControlToValidate="txt_FechaFin"  ErrorMessage="Fecha inválida. Ingrese la fecha en un formato adecuado, ejemplo: 31/12/2012" ValidationExpression="^(?:(?:0?[1-9]|1\d|2[0-8])(\/|-)(?:0?[1-9]|1[0-2]))(\/|-)(?:[1-9]\d\d\d|\d[1-9]\d\d|\d\d[1-9]\d|\d\d\d[1-9])$|^(?:(?:31(\/|-)(?:0?[13578]|1[02]))|(?:(?:29|30)(\/|-)(?:0?[1,3-9]|1[0-2])))(\/|-)(?:[1-9]\d\d\d|\d[1-9]\d\d|\d\d[1-9]\d|\d\d\d[1-9])$|^(29(\/|-)0?2)(\/|-)(?:(?:0[48]00|[13579][26]00|[2468][048]00)|(?:\d\d)?(?:0[48]|[2468][048]|[13579][26]))$" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                </table>

                <div>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label3" runat="server" 
                        Text="Formato de Fecha dd/MM/yyyy , ejemplo: 31/12/2012" 
                        style="font-style: italic"></asp:Label>
                </div>

                &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="lblErrorFecha" runat="server" 
                        ForeColor="Red" Text="El rango de tiempo seleccionado se encuentra ocupado." 
                        Visible="False"></asp:Label>
&nbsp;<table>
                    <tr>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                        <td><asp:Label ID="hra_inicio" runat="server" Text="Hora Inicio:" 
                                style="font-weight: 700"></asp:Label></td>
                        <td><asp:TextBox ID="txt_HoraInicio" runat="server" Width="90px">12:00</asp:TextBox></td>
                        <td><asp:DropDownList ID="ddlAmPm1" runat="server">
                           <asp:ListItem Selected="True">AM</asp:ListItem>
                           <asp:ListItem Selected="False">PM</asp:ListItem>
                        </asp:DropDownList></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_HoraInicio" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                        <td><asp:RegularExpressionValidator ID="TimeValidator2" runat="server" ControlToValidate="txt_HoraInicio" Display="Dynamic" ErrorMessage="Hora Invalida. Ingrese la hora en un formato adecuado, ejemplo: 12:30 o 5:00" ValidationExpression="^(0[1-9]|1\d|2[0-3]):([0-5]\d)(:([0-5]\d))?$" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator></td>
                    </tr>
        
                    <tr>            
                        <td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                        <td><asp:Label ID="hra_fin" runat="server" Text="Hora Fin:" 
                                style="font-weight: 700"></asp:Label></td>
                        <td><asp:TextBox ID="txt_HoraFin" runat="server" Width="90px">12:00</asp:TextBox></td>
                        <td><asp:DropDownList ID="ddlAmPm2" runat="server">
                           <asp:ListItem Selected="True">AM</asp:ListItem>
                           <asp:ListItem Selected="False">PM</asp:ListItem>
                        </asp:DropDownList></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_HoraFin" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                        <td><asp:RegularExpressionValidator ID="TimeValidator1" runat="server" ControlToValidate="txt_HoraFin" Display="Dynamic" ErrorMessage="Hora Invalida. Ingrese la hora en un formato adecuado, ejemplo: 12:30 o 5:00" ValidationExpression="^(0[1-9]|1\d|2[0-3]):([0-5]\d)(:([0-5]\d))?$" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
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
        <asp:Button ID="btn_Agregar" runat="server" Text="Añadir Curso" 
            Width="223px" Height="29px" onclick="btn_Agregar_Click" />
    </div>
</asp:Content>
