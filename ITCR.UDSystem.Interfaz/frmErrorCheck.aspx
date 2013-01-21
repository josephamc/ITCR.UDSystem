<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmErrorCheck.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.frmErrorCheck" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<table>
    <tr>
        <td>
            <div id="imglogo">
                	<img src="../../imagenes/denegado.png" alt=""/>
            </div>
        </td>
        <td>
            <div>
                <h1> ¡ Su solicitud no puede ser procesada ! </h1>
                <h3>
                    Debe seleccionar al menos un día en el horario.
                </h3>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_redirect" runat="server" Text="Volver a la página anterior" />
            </div>
        </td>
    </tr>
</table>s
</asp:Content>
