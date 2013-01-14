<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmSeleccionar.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.Reportes.frmSeleccionar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <table border="true" style="height: 372px">
        <tr>
            <td valign="top">
                <asp:Image ID="imgInstalaciones" ImageUrl="~/imagenes/est01.jpg" runat="server" 
                    ImageAlign="Top" />
            </td>
            <td valign="top">
                <div style="width: 639px; height: 364px">
                    <h1>
                        <img align="bottom" alt="" src="../imagenes/forward.png" />Generación de reporte de reservaciones</h1>
                    <br />
                    <table>
                        <tr>
                            <td>Fecha inicio:</td>
                            <td>
                                <ajaxToolkit:ToolkitScriptManager ID="tkManager" runat="server">
                                </ajaxToolkit:ToolkitScriptManager>
                                <asp:TextBox ID="txtInicio" runat="server"></asp:TextBox>
                                <ajaxToolkit:CalendarExtender
                                    ID="cldExtender" TargetControlID="txtInicio" PopupButtonID="imgCalendar" 
                                    runat="server" Format="dd-MM-yyyy">
                                </ajaxToolkit:CalendarExtender>
                                <img id="imgCalendar" align="middle" alt="" src="../imagenes/date.png" /></td>
                        </tr>
                        <tr>
                            <td>Fecha Fin:</td>
                            <td>
                                <asp:TextBox ID="txtFin" runat="server"></asp:TextBox>
                                <ajaxToolkit:CalendarExtender
                                    ID="cldExtenderFin" TargetControlID="txtFin" PopupButtonID="imgCalendarFin" Format="dd-MM-yyyy" runat="server">
                                </ajaxToolkit:CalendarExtender>
                                <img id="imgCalendarFin" align="middle" alt="" src="../imagenes/date.png" /></td>
                        </tr>
                        <tr>
                            <td>Tipo de información:</td>
                            <td style="margin-left: 40px">
                                <asp:RadioButtonList ID="rblOpciones" runat="server">
                                    <asp:ListItem Selected="True">Documento Web</asp:ListItem>
                                    <asp:ListItem>Descargar documento PDF</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                    </table>

                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnGenerar" runat="server" Text="Generar Reporte" 
                        onclick="btnGenerar_Click" />
                </div>
            </td>
        </tr>
    </table>
</asp:Content>
