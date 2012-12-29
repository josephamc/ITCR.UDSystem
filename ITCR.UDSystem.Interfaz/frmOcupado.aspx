<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmOcupado.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.frmOcupado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<table>
    <tr>
        <td>
            <div id="imglogo">
                	<img src="../../imagenes/nodisponible.jpg" width="150px" height="166px" alt=""/>
            </div>
        </td>
        <td>
            <div>
                <h1> ¡ La instalación no se encuentra disponible ! </h1>
                <h2> Intente crear la solicitud con un horario distinto</h2>
                <h3>
                    <asp:Label ID="lblMessage" runat="server" Text="Message"></asp:Label>
                </h3>
                <br />
                <asp:HyperLink ID="lnkHome" runat="server" NavigateUrl="~/CU_SolicitarAreaDeportiva/FormSolicitud.aspx">Volver al formulario</asp:HyperLink>
            </div>
        </td>
    </tr>
</table>
</asp:Content>
