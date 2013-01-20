<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmSolicitud.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.CU_AdministrarCalendario.frmSolicitud" %>
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
            <!-- Encabezado -->
            <div style="background-color: #336699; height: 55px;">
            </div>
            <!-- Ficha de informacion -->
            <fieldset>
                <h1>Información de Solicitud</h1>
                <p>
                    <br />
                    <br />
                    Instalación Solicitada:
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;               
                    <asp:Label ID="lblInstalacion" runat="server" Text="Instalacion X"></asp:Label>
                    <br />
                    <br />
                    Fecha de la solicitud:
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblfecSolicitud" runat="server" Text="Fecha Solicitud"></asp:Label>
                    <br />
                    <br />
                    Fecha a solicitar:
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:Label ID="lblfecini" runat="server" Text="Fecha Inicio"></asp:Label> &nbsp;- 
                    <asp:Label ID="lblfecfin" runat="server" Text="Fecha fin"></asp:Label>
                    <br />
                    <br />
                    Hora a solicitar:
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblhraini" runat="server" Text="Hora inicio"></asp:Label>  &nbsp;a 
                    <asp:Label ID="lblhrafin" runat="server" Text="Hora fin"></asp:Label>
                    <br />
                    <br />
                    Institución Solicitante/Grupo:
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblinstsolicitante" runat="server" Text="Institución Solicitante"></asp:Label>
                    <br />
                    <br />
                    Persona Responsable: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:Label ID="lblresponsable" runat="server" Text="Responsable X"></asp:Label>
                    <br />
                    <br />
                    Número de cédula/Carné:
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblidentificacion" runat="server" Text="231-31231-312"></asp:Label>
                    <br />
                    <br />
                    Cantidad de usuarios solicitantes (Hombres):&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:Label ID="lblcantidadh" runat="server" Text="11111"></asp:Label>
                    <br />
                    <br />
                    Cantidad de usuarios solicitantes (Mujeres):&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:Label ID="lblcantidadm" runat="server" Text="11111"></asp:Label>
                    <br />
                    <br />
                    Tipo de usuario solicitante:
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lbltipo" runat="server" Text="Estudiante"></asp:Label>
                    <br />
                    <br />
                    Solicitantes:
                </p>
                    <fieldset>
                        <asp:Label ID="lblusuarios" runat="server" Text="Usuarios"></asp:Label>
                    </fieldset>
                <p>
                    <br />
                    Razón de uso:
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
            <asp:Image ID="img_BANNER" runat="server" ImageUrl="~/imagenes/GestionarSolicitudes.jpg" width="297px" height="526px" />
            &nbsp;&nbsp;&nbsp;
        </td>
    </tr>
</table>
</asp:Content>
