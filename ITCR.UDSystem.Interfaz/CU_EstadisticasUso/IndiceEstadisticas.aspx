<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IndiceEstadisticas.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.CU_EstadisticasUso.IndiceEstadisticas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h1><asp:Label ID="Label1" runat="server" Text="Estadisticas de las Instalaciones"></asp:Label></h1>
    <br />
    <hr />    
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Consultar Estadisticas" />
    <hr />
    <br />
    <table>
        <tr>
            <td> 
                &nbsp;&nbsp;&nbsp;           
                <asp:Label ID="Label2" runat="server" Text="Instalación Deportiva:"></asp:Label>
                &nbsp;&nbsp;
                <asp:DropDownList ID="ddl_instalaciones" runat="server" Width="324px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
        <td>&nbsp;&nbsp;&nbsp;   </td>
        </tr>
        <tr>
            <td>            
                &nbsp;&nbsp;&nbsp; 
                <asp:Label ID="Label3" runat="server" Text="Cantidad de Usuarios"></asp:Label>
                &nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
       </tr>    
        <tr>
            <td>            
                &nbsp;&nbsp;&nbsp; 
                <asp:Label ID="Label4" runat="server" Text="Fecha:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server" Width="321px"></asp:TextBox>
                <br />
            </td>        
        </tr>
    </table>
    <br />
    <div>
        <table>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
                        BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" 
                        ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" 
                        VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" 
                        Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                    </asp:Calendar></td>
            </tr>
        </table>
        
    </div>
    <br />
    <div>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Insertar Datos" />
    </div>

</asp:Content>
