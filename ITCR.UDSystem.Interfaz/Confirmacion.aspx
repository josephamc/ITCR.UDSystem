<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Confirmacion.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.Confirmacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<table>
    <tr>
        <td>
            <div id="imglogo">
                	<img src="../../imagenes/correcto02.jpg" alt=""/>
            </div>
        </td>
        <td>
            <div>
                <h1> ¡ Realizacion Exitosa ! </h1>
                <h3>La operacion ha sido realizada de manera correcta en el sistema.</h3>
                <br />
                <asp:HyperLink ID="link01" runat="server" NavigateUrl="~/Default.aspx">Volver al inicio</asp:HyperLink>
            </div>
        </td>
    </tr>
</table>
</asp:Content>
