<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IndiceCalendario.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.CU_AdministrarCalendario.IndiceCalendario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Administrador de Calendario</h2>
    <br />
    <br />
    &nbsp;
    <a href="../../CU_AdministrarCalendario/InsertaEvento.aspx" >
        <img src="../../imagenes/event01.jpg" alt=""/>
    </a>
    
    &nbsp;
    <a href="../../CU_AdministrarCalendario/InsertaCurso.aspx" >
        <img src="../../imagenes/docencia01.jpg" alt=""/>
    </a>

    &nbsp;
    <a href="../../CU_AdministrarCalendario/ConsultaCalendario.aspx" >
        <img src="../../imagenes/calendario01.jpg" alt=""/>
    </a>
</asp:Content>
