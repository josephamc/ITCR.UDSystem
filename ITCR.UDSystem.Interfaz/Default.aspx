<%@ Page Title="" Language="C#" MasterPageFile="Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="ITCR.UDSystem.Interfaz._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">

</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
<br />
    <div id="imglogo">
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <img src="../../imagenes/bienvenido.JPG" alt=""/>
    </div>
    <br />
    <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Menu Temporal</h2>
    <br />
    <table>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>

            <td>
            <p>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Administrar Instalaciones Deportivas" Width="313px"/>
            </p>
            <p>
                <asp:Button ID="Button3" runat="server" Text="Gestionar Solicitudes" 
                Width="313px" onclick="Button3_Click" />
            </p>
            <p>
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click"  Text="Administrar Calendario" Width="313px" />
            </p>
                <asp:Button ID="Button4" runat="server" onclick="Button4_Click1" 
                    Text="Registro de uso de las Instalaciones" Width="313px" />
                <br />
                <br />
                <asp:Button ID="Button5" runat="server" onclick="Button5_Click" Text="Reportes" 
                    Width="312px" />
            </td>
        </tr>
    </table>
</asp:Content>

