<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmSolicitud.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.GestionarSolicitudes.frmSolicitud1" %>
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
<br />
<br />
<table>
    <tr>
        <td valign="top" class="style2">
        <!-- Main Container -->
            <!-- Botones -->
            <br />
            <br />
            <!--<asp:Button ID="btnAceptar" runat="server" Text="Aceptar" /> &nbsp;-->
            <!--<asp:Button ID="btnRechazar" runat="server" Text="Rechazar" Width="71px" />-->

            <!-- Ficha de informacion -->
            <div style="background-color: #336699; height: 55px;">
            <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" ForeColor="White" 
                    BackColor="#336699" DynamicHorizontalOffset="2" Font-Names="Verdana" 
                    Font-Size="Small" StaticSubMenuIndent="10px">
                <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
                <DynamicMenuStyle BackColor="#3366CC" HorizontalPadding="5px" 
                    VerticalPadding="2px" />
                <DynamicSelectedStyle BackColor="#507CD1" />
                <Items>
                    <asp:MenuItem Text="Responder">
                        <asp:MenuItem NavigateUrl="~/frmNotificacion.aspx?status=true" 
                            Text="                           Aceptar" ToolTip="Acepta una Solicitud" />
                        <asp:MenuItem NavigateUrl="~/frmNotificacion.aspx?status=false" 
                            Text="                           Rechazar" ToolTip="Rechaza una solicitud" />
                    </asp:MenuItem>
                </Items>
                <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#507CD1" />
            </asp:Menu>
            </div>
            <fieldset>
                <h1>Información de Solicitud</h1>
                <p>
                    <br />
                    <br />
                    Instalación Solicitada:  
                    <asp:Label ID="lblInstalacion" runat="server" Text="Instalacion X"></asp:Label>
                    <br />
                    Fecha a solicitar: 
                    <asp:Label ID="lblfecini" runat="server" Text="Fecha Inicio"></asp:Label> &nbsp;- 
                    <asp:Label ID="lblfecfin" runat="server" Text="Fecha fin"></asp:Label>
                    <br />
                    Hora a solicitar:
                    <asp:Label ID="lblhraini" runat="server" Text="Hora inicio"></asp:Label>  &nbsp;a 
                    <asp:Label ID="lblhrafin" runat="server" Text="Hora fin"></asp:Label>
                    <br />
                    Institución Solicitante/Grupo:
                    <asp:Label ID="lblinstsolicitante" runat="server" Text="Institución Solicitante"></asp:Label>
                    <br />
                    Persona Responsable:
                    <asp:Label ID="lblresponsable" runat="server" Text="Responsable X"></asp:Label>
                    <br />
                    Número de cédula/Carné:
                    <asp:Label ID="lblidentificacion" runat="server" Text="231-31231-312"></asp:Label>
                    <br />
                    Cantidad de usuarios solicitantes: 
                    <asp:Label ID="lblcantidad" runat="server" Text="11111"></asp:Label>
                    <br />
                    Tipo de usuario solicitante:
                    <asp:Label ID="lbltipo" runat="server" Text="Estudiante"></asp:Label>
                    <br />
                    Solicitantes:
                </p>
                    <fieldset>
                        <asp:Label ID="lblusuarios" runat="server" Text="Usuarios"></asp:Label>
                    </fieldset>
                <p>
                    <br />
                    Razón de uso:
                    <asp:Label ID="lblrznuso" runat="server" Text="Razón de uso"></asp:Label>
                </p>
            </fieldset>
            <!-- Fin de ficha de información -->
            <br />
            <br />
        <!-- Main Container end -->
        </td>
        <td>
            &nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/AdmInst2.jpg" />
            &nbsp;&nbsp;&nbsp;
        </td>
    </tr>
</table>
</asp:Content>
