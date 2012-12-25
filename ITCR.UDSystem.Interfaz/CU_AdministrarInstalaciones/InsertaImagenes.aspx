<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertaImagenes.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.CU_AdministrarInstalaciones.InsertaImagenes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<style type="text/css">
        .style1
        {
            width: 186px;
        }
        .style2
        {
            width: 244px;
        }
        .style3
        {
            width: 284px;
        }
    .style4
    {
        width: 184px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>Insertar Instalacion</h2>
    <table>
        <tr>
            <td class="style2"> >>>Paso1: Incluir Informacion General</td>
            <td class="style3"> >>>Paso2: Incluir horario de la instalación</td>
            <td class="style4"> <strong>>>>Paso3: Incluir imagenes</strong></td>
        </tr>
    </table>
    <br />

    <div>
    
    </div>
    
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonFinalizarInstalacion" runat="server" 
            Text="Finalizar instalación" onclick="ButtonFinalizarInstalacion_Click" />
    </div>
</asp:Content>
