<%@ Page Title="" Language="C#" MasterPageFile="Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="ITCR.UDSystem.Interfaz._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">

</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
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

            <td><p>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Administrar Instalaciones Deportivas" Width="313px"/>
            </p>

            <p>
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click"  Text="Administrar Calendario" Width="313px" />
            </p>
                <p>
                    <asp:Button ID="Button3" runat="server" Text="Gestionar Solicitudes" 
                        Width="313px" onclick="Button3_Click" />
                 </p>
                    
                    <p>
                    <asp:Button ID="Button4" runat="server" Text="Solicitar Area Deportiva" 
                        Width="313px" onclick="Button4_Click" />
                        </p>
            </td>
        </tr>
    </table>
</asp:Content>

