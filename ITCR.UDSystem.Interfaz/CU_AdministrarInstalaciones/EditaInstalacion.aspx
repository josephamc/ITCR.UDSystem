<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditaInstalacion.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.CU_AdministrarInstalaciones.EditaInstalacion" %>

<%@ PreviousPageType VirtualPath="~/CU_AdministrarInstalaciones/ConsultaInstalacion.aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script language="javascript" type="text/javascript">
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Editar Instalacion</h2>
    <br />
    <br />
    <div>
        <table>
            <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Identificacion*:   "></asp:Label></td>
            <td><asp:TextBox ID="txt_id" runat="server" Width="300px" ReadOnly="true"></asp:TextBox></td>
            </tr>

            <tr>
            <td><asp:Label ID="nombre2" runat="server" Text="Nombre de la Instalacion*:   "></asp:Label></td>
            <td><asp:TextBox ID="txt_nombre2" runat="server" Width="300px"></asp:TextBox></td>
            </tr>

            <tr>
            <td><asp:Label ID="descripcion2" runat="server" Text="Descripcion*:   "></asp:Label></td>
            <td><textarea id="txt_descripcion2" cols="75" rows="5" runat="server"></textarea></td>
            </tr>

            <tr>
            <td><asp:Label ID="medidas2" runat="server" Text="Medidas de la Instalacion*:   "></asp:Label></td>
            <td><textarea id="txt_medidas2" cols="75" rows="3" runat="server"></textarea></td>
            </tr>
            
            <tr>
            <td><asp:Label ID="reglamento2" runat="server" Text="Reglamento de Uso*:   "></asp:Label></td>
            <td><textarea id="txt_reglamento2" cols="75" rows="8" runat="server"></textarea></td>
            </tr>
            
            <tr>
            <td><asp:Label ID="costos2" runat="server" Text="Costos (por hora o por actividad)*:"></asp:Label></td>
            <td><textarea id="txt_costos2" cols="75" rows="2" runat="server"></textarea></td>
            </tr>
            
            <tr>
            <td><asp:Label ID="comentarios2" runat="server" Text="Comentarios Adicionales:   "></asp:Label></td>
            <td><textarea id="txt_comentarios2" cols="75" rows="2" runat="server"></textarea></td>
            </tr>
        </table>
        </div>
        <br />
        <br />
        &nbsp;<asp:Label ID="nota2" runat="server" Text="Los campos con * son obligatorios"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Editar Instalacion" 
            onclick="Button1_Click" />
        &nbsp;</asp:Content>
