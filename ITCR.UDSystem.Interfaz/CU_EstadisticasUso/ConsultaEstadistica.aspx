<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaEstadistica.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.CU_EstadisticasUso.ConsultaEstadistica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h1>Consulta de Estadisticas</h1>
<br />
<table>
    <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;
        </td>

        <td>
            <table>
                <tr>
                    <td>                        
                        <fieldset style="width: 500px">
                            <table>
                                <tr>
                                    <td><asp:Label ID="Label4" runat="server" Text="Fecha Inicio:"></asp:Label></td>
                                    <td><asp:TextBox ID="txt_fechaIni" runat="server" Width="235px" ReadOnly="true"></asp:TextBox></td>
                                    <td><asp:Button ID="elegir01_boton" runat="server" Text="Elegir" onclick="elegir01_Click" /></td>
                                </tr>
                                <tr>                                
                                    <td><asp:Label ID="Label1" runat="server" Text="Fecha Fin:"></asp:Label></td>
                                    <td><asp:TextBox ID="txt_fechaFin" runat="server" Width="235px" ReadOnly="true"></asp:TextBox></td>                                    
                                    <td><asp:Button ID="elegir02_boton" runat="server" Text="Elegir" onclick="elegir02_Click" /></td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        <asp:Label ID="nota" runat="server" Text="Formato de Fecha= yyyy-MM-dd, ejemplo: 2013-01-27" style="font-style: italic"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                    <br />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:RadioButtonList ID="rb_tipo" runat="server">
                                        <asp:ListItem Text="Individual" Value="1" Selected="True"></asp:ListItem>
                                        <asp:ListItem Text="General" Value="2" Selected="False"></asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>
                                
                            </table>
                            <table>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label3" runat="server" Text="Si seleccciona 'Individual' debe elegir una Instalacion Deportiva. De lo contrario, si selecciona 'General', ignore dicho campo"></asp:Label>
                                    </td>
                                </tr>
                                <tr><td><br /></td></tr>                                
                                <tr>   
                                    <td> 
                                        &nbsp;&nbsp;&nbsp;           
                                        <asp:Label ID="Label2" runat="server" Text="Instalación Deportiva:"></asp:Label>
                                        &nbsp;&nbsp;
                                        <asp:DropDownList ID="ddl_instalaciones" runat="server" Width="324px">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                            </table>
                            <br />
                            <table>
                            <tr>
                                <td><asp:Calendar ID="cal01" runat="server" BackColor="White" visible="false"
                                    BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" 
                                    ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px" 
                                        onselectionchanged="cal01_SelectionChanged">
                                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" 
                                        VerticalAlign="Bottom" />
                                    <OtherMonthDayStyle ForeColor="#999999" />
                                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" 
                                        Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                                    <TodayDayStyle BackColor="#CCCCCC" />
                                </asp:Calendar></td>
                                <td>
                                <asp:Calendar ID="cal02" runat="server" BackColor="White" visible="false"
                                    BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" 
                                    ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px" 
                                        onselectionchanged="cal02_SelectionChanged">
                                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" 
                                        VerticalAlign="Bottom" />
                                    <OtherMonthDayStyle ForeColor="#999999" />
                                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" 
                                        Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                                    <TodayDayStyle BackColor="#CCCCCC" />
                                </asp:Calendar>
                                </td>
                            </tr>
                            </table>
                        </fieldset> 
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" Text="Consultar" Height="37px" 
                            Width="103px" onclick="Button1_Click" />
                    </td>
                </tr>
            </table>           
        </td>

        <td>
            <img src="../../imagenes/est03.png" alt=""/>
        </td>
    </tr>
</table>
<br />
<fieldset style="width: 800px" runat="server" id="datos_generales" visible="false">
    <img src="../../imagenes/result_est01.png" alt=""/>    
    <br />
    <br />
    <h3>Rango de Fechas:</h3>
    <asp:Label ID="Label5" runat="server" Text="Entre"></asp:Label>&nbsp;
    <asp:Label ID="rango_ini" runat="server" Text="_rango_ini"></asp:Label>&nbsp;
    <asp:Label ID="Label7" runat="server" Text="y"></asp:Label>&nbsp;
    <asp:Label ID="rango_fin" runat="server" Text="_rango_fin"></asp:Label>&nbsp;
    <br />
    <h3>Datos:</h3>
    <asp:DataList id="data01" CellPadding="4" ShowBorder="False" runat="server" ForeColor="#333333">

         <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
         <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></HeaderStyle>

         <AlternatingItemStyle BackColor="White" ForeColor="#284775"></AlternatingItemStyle>
         <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
               
         <ItemTemplate>

            Instalacion: 
            <%# DataBinder.Eval(Container.DataItem, "instalacion") %>
            <h3><%# DataBinder.Eval(Container.DataItem, "usuarios") %></h3> usuarios hicieron uso de la instalacion.
            <br>
            <br>
            <br>

         </ItemTemplate> 
         <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
 
      </asp:DataList>





</fieldset>
</asp:Content>
