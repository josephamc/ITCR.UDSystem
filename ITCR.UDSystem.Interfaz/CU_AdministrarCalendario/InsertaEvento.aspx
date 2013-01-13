<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertaEvento.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.CU_AdministrarCalendario.InsertaEvento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        #txt_descripcionevento
        {
            width: 559px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Insertar Evento</h2>
    <br />    
    <div id="imglogo">
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <img src="../../imagenes/ImgND2.png" alt=""/>
    </div>
    <br />
    <div>
        <table>
            <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_nombre" runat="server" Text="Nombre del Evento:" 
                        style="font-weight: 700"></asp:Label></td>
                <td><asp:TextBox ID="txt_nombreEvento" runat="server" Width="227px"></asp:TextBox> </td>
            </tr>

            <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_instalacion" runat="server" 
                        Text="Instalacion donde será el evento:" style="font-weight: 700"></asp:Label></td>
                <td><asp:DropDownList ID="ddl_instalaciones" runat="server" Height="18px" 
                        Width="227px">
                </asp:DropDownList></td>
            </tr>

            <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_descripcion" runat="server" Text="Descripción del evento:" 
                        style="font-weight: 700"></asp:Label></td>
                <td><textarea id="txt_descripcionEvento" cols= "75" rows="7" runat="server"></textarea></td>
            </tr>
        </table>
        <br />
        <table>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><img src="../../imagenes/barra02.jpg" alt=""/></td>
                <td><asp:Calendar ID="cal01" runat="server" BackColor="White" visible="true"
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
                    </asp:Calendar>                    
                </td>

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

                <td><table>
                    <tr>
                        <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                        <td><asp:Label ID="lb_Fecha1" runat="server" Text="Fecha Inicio:" 
                                style="font-weight: 700"></asp:Label></td>
                        <td><asp:TextBox ID="txt_FechaInicio" runat="server" Width="227px" ReadOnly="true"></asp:TextBox> </td>
                        <td><asp:Button ID="Button1" runat="server" Text="Elegir" 
                                onclick="Button1_Click1" /></td>
                    </tr>
            
                    <tr>
                        <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                        <td><asp:Label ID="Label1" runat="server" Text="Fecha Fin:" 
                                style="font-weight: 700"></asp:Label></td>
                        <td><asp:TextBox ID="txt_FechaFin" runat="server" Width="227px" ReadOnly="true"></asp:TextBox> </td>
                        <td><asp:Button ID="Button2" runat="server" Text="Elegir" 
                                onclick="Button2_Click1" /></td>
                    </tr>
                </table>

                <div>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label3" runat="server" 
                        Text="Formato de Fecha yyyy-MM-dd , ejemplo: 2013-01-27" 
                        style="font-style: italic"></asp:Label>
                </div>


                &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;

                <table>
                    <tr>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                        <td><asp:Label ID="hra_inicio" runat="server" Text="Hora Inicio:" 
                                style="font-weight: 700"></asp:Label></td>
                       <!-- <td><asp:TextBox ID="txt_HoraInicio" runat="server" Width="90px"></asp:TextBox></td>-->
                        <td><asp:DropDownList ID="ddlAmPm1" runat="server">
                           <asp:ListItem Selected="True">1</asp:ListItem>
                           <asp:ListItem Selected="False">2</asp:ListItem>
                            <asp:ListItem Selected="false">3</asp:ListItem>
                           <asp:ListItem Selected="False">4</asp:ListItem>
                            <asp:ListItem Selected="false">5</asp:ListItem>
                           <asp:ListItem Selected="False">6</asp:ListItem>
                            <asp:ListItem Selected="false">7</asp:ListItem>
                           <asp:ListItem Selected="False">8</asp:ListItem>
                           <asp:ListItem Selected="false">9</asp:ListItem>
                           <asp:ListItem Selected="False">10</asp:ListItem>
                            <asp:ListItem Selected="false">11</asp:ListItem>
                           <asp:ListItem Selected="False">12</asp:ListItem>
                            <asp:ListItem Selected="false">13</asp:ListItem>
                           <asp:ListItem Selected="False">14</asp:ListItem>
                            <asp:ListItem Selected="false">15</asp:ListItem>
                           <asp:ListItem Selected="False">16</asp:ListItem>
                           <asp:ListItem Selected="False">17</asp:ListItem>
                            <asp:ListItem Selected="false">18</asp:ListItem>
                           <asp:ListItem Selected="False">19</asp:ListItem>
                            <asp:ListItem Selected="false">20</asp:ListItem>
                           <asp:ListItem Selected="False">21</asp:ListItem>
                            <asp:ListItem Selected="false">22</asp:ListItem>
                           <asp:ListItem Selected="False">23</asp:ListItem>
                        </asp:DropDownList></td>
                        <td><asp:DropDownList ID="DropDownList3" runat="server">
                           <asp:ListItem Selected="True">00</asp:ListItem>
                           <asp:ListItem Selected="False">30</asp:ListItem>
            
                        </asp:DropDownList></td>
                      

                    </tr>
        
                    <tr>            
                        <td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                        <td><asp:Label ID="hra_fin" runat="server" Text="Hora Fin:" 
                                style="font-weight: 700"></asp:Label></td>
                        
                        <td><asp:DropDownList ID="ddlAmPm2" runat="server">
                          <asp:ListItem Selected="True">1</asp:ListItem>
                           <asp:ListItem Selected="False">2</asp:ListItem>
                            <asp:ListItem Selected="false">3</asp:ListItem>
                           <asp:ListItem Selected="False">4</asp:ListItem>
                            <asp:ListItem Selected="false">5</asp:ListItem>
                           <asp:ListItem Selected="False">6</asp:ListItem>
                            <asp:ListItem Selected="false">7</asp:ListItem>
                           <asp:ListItem Selected="False">8</asp:ListItem>
                           <asp:ListItem Selected="false">9</asp:ListItem>
                           <asp:ListItem Selected="False">10</asp:ListItem>
                            <asp:ListItem Selected="false">11</asp:ListItem>
                           <asp:ListItem Selected="False">12</asp:ListItem>
                            <asp:ListItem Selected="false">13</asp:ListItem>
                           <asp:ListItem Selected="False">14</asp:ListItem>
                            <asp:ListItem Selected="false">15</asp:ListItem>
                           <asp:ListItem Selected="False">16</asp:ListItem>
                           <asp:ListItem Selected="False">17</asp:ListItem>
                            <asp:ListItem Selected="false">18</asp:ListItem>
                           <asp:ListItem Selected="False">19</asp:ListItem>
                            <asp:ListItem Selected="false">20</asp:ListItem>
                           <asp:ListItem Selected="False">21</asp:ListItem>
                            <asp:ListItem Selected="false">22</asp:ListItem>
                           <asp:ListItem Selected="False">23</asp:ListItem>
                        </asp:DropDownList></td>
                        <td><asp:DropDownList ID="DropDownList4" runat="server">
                           <asp:ListItem Selected="True">00</asp:ListItem>
                           <asp:ListItem Selected="False">30</asp:ListItem>
            
                        </asp:DropDownList></td>
                       
                    </tr>
                </table>
                
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Formato de Hora hh:mm , ejemplo: 12:45" 
                        style="font-style: italic"></asp:Label></td>
            </tr>        
        </table>
    </div>

    <div>
    <table>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td>
                <fieldset style="width: 700px" runat="server" id="error_reservacion" visible="false">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="m00" runat="server" 
                        Text="¡ERROR! " ForeColor="Red" 
                        style="font-weight: 700; font-size: medium"></asp:Label>&nbsp;
                        <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="m01" runat="server" 
                        Text="Ya existe una reservacion en la instalación:" ForeColor="Red" 
                        style="font-size: small"></asp:Label>&nbsp;
                    <asp:Label ID="_inst" runat="server" Text="_instalacion" ForeColor="Red" 
                        style="font-size: small; font-weight: 700"></asp:Label>&nbsp;
                    <asp:Label ID="m02" runat="server" 
                        Text="en el rango de fechas u horas indicado" ForeColor="Red" 
                        style="font-size: small; "></asp:Label>
                        <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="m03" runat="server" 
                        Text="O el horario de la instalacion no lo permite" ForeColor="Red" 
                        style="font-size: small; "></asp:Label>
                &nbsp;( <asp:HyperLink ID="HyperLink1" runat="server" 
                        NavigateUrl="~/CU_AdministrarInstalaciones/ConsultaInstalacion.aspx">Ver detalle de las instalaciones</asp:HyperLink>&nbsp;)
            </fieldset>
            </td>
        </tr>
    </table>    
    </div>

    <div>
    <table>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td>
                <fieldset style="width: 700px" runat="server" id="exito_reservacion" visible="false">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label4" runat="server" 
                        Text="¡EXITO! " ForeColor="#009933" 
                        style="font-weight: 700; font-size: medium"></asp:Label>&nbsp;
                        <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label5" runat="server" 
                        Text="La reservacion para la instalación: " ForeColor="#009933" 
                        style="font-size: small"></asp:Label>&nbsp;
                    <asp:Label ID="_inst2" runat="server" Text="_instalacion" ForeColor="#009933" 
                        style="font-size: small; font-weight: 700"></asp:Label>&nbsp;
                    <asp:Label ID="Label7" runat="server" 
                        Text="fue hecho correctamente." ForeColor="#009933" 
                        style="font-size: small; "></asp:Label>
                        <br />
                     
                </fieldset>
            </td>
        </tr>
    </table>    
    </div>

    <div>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="boton_añadir_evento" runat="server" Text="Añadir Evento" 
            Width="230px" Height="39px" onclick="boton_añadir_evento_Click" />
    </div>
    <br />

</asp:Content>
