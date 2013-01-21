<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmEvento.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.CU_AdministrarCalendario.frmEvento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 92px;
        }
        .style2
        {
            width: 868px;
        }
        #btnAceptar
        {
            height: 24px;
            width: 76px;
        }
        #btnRechazar
        {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<!-- Administrador -->
<ajaxToolkit:ToolkitScriptManager ID="tksManager" runat="server"></ajaxToolkit:ToolkitScriptManager>

<!-- Informacion del evento -->
<br />
<br />
<table>
    <tr>
        <td valign="top" class="style2">
        <!-- Main Container -->
            <!-- Encabezado -->
            <div style="background-color: #336699; height: 55px;">
                <br />
                <asp:ImageButton ID="img_EDIT" ImageUrl="~/imagenes/btnedit.png" 
                    runat="server" onclick="img_EDIT_Click" />
                <asp:ImageButton ID="img_DEL" ImageUrl="~/imagenes/btndel.png"
                    runat="server" onclick="img_DEL_Click" />
            </div>
            <!-- Ficha de informacion -->
            <fieldset>
                <h1>Información del Evento</h1>
                <div>
                    <asp:Label ID="lbl_ID_RESERVACION" runat="server" Text="ID_RESERVACION" 
                        Visible="False"></asp:Label>
                    <asp:Label ID="lbl_ID_EVENTO" runat="server" Text="ID_EVENTO" Visible="False"></asp:Label>
                    <asp:Label ID="lbl_ID_INSTALACION" runat="server" Text="ID_INSTALACION" 
                        Visible="False"></asp:Label>
                    <asp:Label ID="lbl_NOM_EVENTO" runat="server" Text="NOM_EVENTO" Visible="False"></asp:Label>
                    <br />
                    <br />
                    Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txt_NOMBRE" runat="server" Width="371px" Enabled="False"></asp:TextBox>
                    <br />
                    <asp:Label ID="lbl_ErrorNombre" runat="server" ForeColor="Red" 
                        Text="El nombre que esta tratando de guardar ya se esta usando." 
                        Visible="False"></asp:Label>
                    <br />
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txt_NOMBRE" ErrorMessage="Este campo no puede ser vacio" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="ValidaSolicitante" runat="server" ControlToValidate="txt_NOMBRE"  ErrorMessage="*" ValidationExpression="^[A-Z0-9 a-z]*" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                    <br />
                    Instalacion:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:DropDownList ID="drp_INSTALACION" runat="server" 
                        Width="368px" Enabled="False">
                    </asp:DropDownList>
                    <br />
                    <br />
                    Descripción del evento:
                    <br />
                    <textarea id="txt_DESCRIPCION" cols="60" rows="10" runat="server" 
                        readonly="readonly"></textarea>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_DESCRIPCION" ErrorMessage="Este campo no puede ser vacio" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_DESCRIPCION"  ErrorMessage="*" ValidationExpression="^[A-Z0-9 a-z]*" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                      
                    <br />
                    <br />
                    <h3>Calendario</h3>
                    <br />
                    <br />
                    Fecha inicio:
                    <asp:TextBox ID="txt_FEC_INICIO" runat="server" Enabled="False"></asp:TextBox>
                    &nbsp;<asp:Image ID="img_CALENDAR_INIT" ImageUrl="~/imagenes/date.png" 
                        runat="server" Width="26px" Visible="False" />
                    <ajaxToolkit:CalendarExtender ID="cldExtender_INIT" TargetControlID="txt_FEC_INICIO" 
                            PopupButtonID="img_CALENDAR_INIT" Enabled="false" runat="server" Format="dd/MM/yyyy">
                    </ajaxToolkit:CalendarExtender>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_FEC_INICIO" ErrorMessage="*"></asp:RequiredFieldValidator>                                                                       
                      <asp:RegularExpressionValidator ID="DateValidator1" runat="server" ControlToValidate="txt_FEC_INICIO"  ErrorMessage="Fecha inválida. Ingrese la fecha en un formato adecuado, ejemplo: 31/12/2012" ValidationExpression="^(?:(?:0?[1-9]|1\d|2[0-8])(\/|-)(?:0?[1-9]|1[0-2]))(\/|-)(?:[1-9]\d\d\d|\d[1-9]\d\d|\d\d[1-9]\d|\d\d\d[1-9])$|^(?:(?:31(\/|-)(?:0?[13578]|1[02]))|(?:(?:29|30)(\/|-)(?:0?[1,3-9]|1[0-2])))(\/|-)(?:[1-9]\d\d\d|\d[1-9]\d\d|\d\d[1-9]\d|\d\d\d[1-9])$|^(29(\/|-)0?2)(\/|-)(?:(?:0[48]00|[13579][26]00|[2468][048]00)|(?:\d\d)?(?:0[48]|[2468][048]|[13579][26]))$" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                        
                    <br />
                    Fecha fin:&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txt_FEC_FIN" runat="server" Enabled="False"></asp:TextBox>
                    &nbsp;<asp:Image ID="img_CALENDAR_FIN" ImageUrl="~/imagenes/date.png" 
                        runat="server" Width="26px" Visible="False" />
                    <ajaxToolkit:CalendarExtender ID="cldExtender_FIN" TargetControlID="txt_FEC_FIN" 
                            PopupButtonID="img_CALENDAR_FIN" Enabled="false" runat="server" Format="dd/MM/yyyy">
                    </ajaxToolkit:CalendarExtender>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_FEC_FIN" ErrorMessage="*"></asp:RequiredFieldValidator>                                                                       
                     <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_FEC_FIN"  ErrorMessage="Fecha inválida. Ingrese la fecha en un formato adecuado, ejemplo: 31/12/2012" ValidationExpression="^(?:(?:0?[1-9]|1\d|2[0-8])(\/|-)(?:0?[1-9]|1[0-2]))(\/|-)(?:[1-9]\d\d\d|\d[1-9]\d\d|\d\d[1-9]\d|\d\d\d[1-9])$|^(?:(?:31(\/|-)(?:0?[13578]|1[02]))|(?:(?:29|30)(\/|-)(?:0?[1,3-9]|1[0-2])))(\/|-)(?:[1-9]\d\d\d|\d[1-9]\d\d|\d\d[1-9]\d|\d\d\d[1-9])$|^(29(\/|-)0?2)(\/|-)(?:(?:0[48]00|[13579][26]00|[2468][048]00)|(?:\d\d)?(?:0[48]|[2468][048]|[13579][26]))$" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                      
                    <br />
                    Formato de la fecha dd/MM/yyyy. Ejem: 31/12/2012
                    <br />
                    <br />
                    Hora inicio:
                    <asp:TextBox ID="txt_HRA_INICIO" runat="server" Enabled="False"></asp:TextBox>
                    <asp:DropDownList ID="drp_TIME_INIT" runat="server" Enabled="False">
                        <asp:ListItem>AM</asp:ListItem>
                        <asp:ListItem>PM</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txt_HRA_INICIO" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="TimeValidator1" runat="server" ControlToValidate="txt_HRA_INICIO"  ErrorMessage="Hora inválida. Ingrese la hora en un formato adecuado, ejemplo: 12:30 o 5:00" ValidationExpression="^(0[1-9]|1\d|2[0-3]):([0-5]\d)(:([0-5]\d))?$" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                      
                    <br />
                    Hora fin:&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txt_HRA_FIN" runat="server" Enabled="False"></asp:TextBox>
                    <asp:DropDownList ID="drp_TIME_FIN" runat="server" Enabled="False">
                        <asp:ListItem>AM</asp:ListItem>
                        <asp:ListItem>PM</asp:ListItem>
                    </asp:DropDownList>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txt_HRA_FIN" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txt_HRA_FIN"  ErrorMessage="Hora inválida. Ingrese la hora en un formato adecuado, ejemplo: 12:30 o 5:00" ValidationExpression="^(0[1-9]|1\d|2[0-3]):([0-5]\d)(:([0-5]\d))?$" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                      
                    <br />
                    Formato de la hora HH:mm. Ejem: 10:23
                    <br />
                    <asp:Label ID="lbl_ErrorCalendario" runat="server" ForeColor="Red" 
                        Text="El calendario que esta tratando de guardar choca con alguna otra actividad ya existente." 
                        Visible="False"></asp:Label>
                    <br />
                    <br />
                    Días:
                    <br />
                    <asp:CheckBox ID="chk_LUNES" Text="Lunes" runat="server" Enabled="False" />
                    <asp:CheckBox ID="chk_MARTES" Text="Martes" runat="server" Enabled="False" />
                    <asp:CheckBox ID="chk_MIERCOLES" Text="Miércoles" runat="server" 
                        Enabled="False" />
                    <asp:CheckBox ID="chk_JUEVES" Text="Jueves" runat="server" Enabled="False" />
                    <asp:CheckBox ID="chk_VIERNES" Text="Viernes" runat="server" Enabled="False" />
                    <asp:CheckBox ID="chk_SABADO" Text="Sábado" runat="server" Enabled="False" />
                    <asp:CheckBox ID="chk_DOMINGO" Text="Domingo" runat="server" Enabled="False" />
                    <br />
                    <br />
                    <asp:ImageButton ID="btn_Guardar" runat="server" 
                        ImageUrl="~/imagenes/btnSave.png" onclick="btn_Guardar_Click" 
                        Visible="False"/>
                </div>
            </fieldset>
            <!-- Fin de ficha de información -->
            <br />
            <br />
        <!-- Main Container end -->
        </td>
        <td>
            &nbsp;&nbsp;&nbsp;
            <asp:Image ID="img_BANNER" runat="server" ImageUrl="~/imagenes/GestionarSolicitudes.jpg" width="297px" height="526px" />
            &nbsp;&nbsp;&nbsp;
        </td>
    </tr>
</table>
</asp:Content>
