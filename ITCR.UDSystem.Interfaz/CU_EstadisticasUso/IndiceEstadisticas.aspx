﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IndiceEstadisticas.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.CU_EstadisticasUso.IndiceEstadisticas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h1><asp:Label ID="Label1" runat="server" Text="Estadisticas de las Instalaciones"></asp:Label></h1>
    <br />
    <hr />    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <a href="/CU_EstadisticasUso/ConsultaEstadistica.aspx" >
        <img src="../../imagenes/consulta03.png" alt=""/>
    </a>
    <hr />
    <br />
    <table>
        <tr>
            <td><div id="Div1">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <img src="../../imagenes/est01.jpg" alt=""/>
            </div></td>
            <td><table>
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
                        <asp:TextBox ID="txt_cantU" runat="server"></asp:TextBox>
                    </td>
               </tr>    
                <tr>
                    <td>            
                        &nbsp;&nbsp;&nbsp; 
                        <asp:Label ID="Label4" runat="server" Text="Fecha:"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txt_fecha" runat="server" Width="321px" ReadOnly="true"></asp:TextBox>
                        <br />
                    </td>        
                </tr>
                <tr>
                <td>&nbsp;&nbsp;&nbsp;
                <asp:Calendar ID="calendarioEstadisticas" runat="server" BackColor="White" 
                        BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" 
                        ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px" 
                        onselectionchanged="Calendar2_SelectionChanged">
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
            </table></td>
        </tr>
    </table>
    <br />
    <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Button ID="Button2" runat="server" Text="Insertar Datos" Height="36px" 
            Width="152px" onclick="Button2_Click" />
    </div>

</asp:Content>
