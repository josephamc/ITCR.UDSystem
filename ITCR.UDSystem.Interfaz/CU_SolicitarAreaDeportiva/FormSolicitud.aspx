<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormSolicitud.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.CU_SolicitarAreaDeportiva.FormSolicitud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        #txt_descripcionevento
        {
            width: 559px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Formulario de Solicitud de Instalación Deportiva</h2>
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
                <td><asp:Label ID="lb_nombre" runat="server" Text="Nombre de la Instalación:" 
                        style="font-weight: 700"></asp:Label></td>
                         <td><asp:TextBox ID="txt_nombreInstalacion" runat="server"  readonly="true" Width="227px"></asp:TextBox> </td>
                        
            </tr>

         
        </table>
        <br />
        <table>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
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
                    </asp:Calendar>
                </td>

                <td><table>
                    <tr>
                        <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                        <td><asp:Label ID="lb_Fecha1" runat="server" Text="Fecha Inicio:" 
                                style="font-weight: 700"></asp:Label></td>
                        <td><asp:TextBox ID="txt_FechaInicio" runat="server" Width="227px"></asp:TextBox> </td>
                    </tr>
            
                    <tr>
                        <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                        <td><asp:Label ID="Label1" runat="server" Text="Fecha Fin:" 
                                style="font-weight: 700"></asp:Label></td>
                        <td><asp:TextBox ID="txt_FechaFin" runat="server" Width="227px"></asp:TextBox> </td>
                    </tr>
                </table>

                <div>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label3" runat="server" 
                        Text="Formato de Fecha dd/MM/yyyy , ejemplo: 23/12/2012" 
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
                
                </td>
            </tr>        
        </table>
    </div>

    <table>
            <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_solicitante" runat="server" Text="Institución o grupo Solicitante*:" 
                        style="font-weight: 700"></asp:Label></td>
                  <td><asp:TextBox ID="TextBox_Solicitante" runat="server" Width="227px"></asp:TextBox> </td>
            </tr>

             <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_responsable" runat="server" Text="Persona Responsable:" 
                        style="font-weight: 700"></asp:Label></td>
                  <td><asp:TextBox ID="TextBox_responsable" runat="server" Width="227px"></asp:TextBox> </td>
            </tr>

             <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_identificacion" runat="server" Text="Carné o Cédula:" 
                        style="font-weight: 700"></asp:Label></td>
                  <td><asp:TextBox ID="TextBox_identificacion" runat="server" Width="227px"></asp:TextBox> </td>
            </tr>

            <tr>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                        <td><asp:Label ID="lb_tipoUsuario" runat="server" Text="Tipo Usuario:" 
                                style="font-weight: 700"></asp:Label></td>
                        <td><asp:DropDownList ID="DropDownList1" runat="server">
                           <asp:ListItem Selected="True">Estudiante</asp:ListItem>
                           <asp:ListItem Selected="False">Egresado</asp:ListItem>
                           <asp:ListItem Selected="False">Funcionario</asp:ListItem>
                           <asp:ListItem Selected="False">Particular</asp:ListItem>
                        </asp:DropDownList></td>
                       
           </tr>
            
             <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_cantidad" runat="server" Text="Cantidad de Usuarios:" 
                        style="font-weight: 700"></asp:Label></td>
                  <td><asp:TextBox ID="TextBox_cantidad" runat="server" Width="227px"></asp:TextBox> </td>
            </tr>

             <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_uso" runat="server" Text="Razón de uso:" 
                        style="font-weight: 700"></asp:Label></td>
                <td><textarea id="txt_razonUso" cols= "75" rows="7" runat="server"></textarea></td>
            </tr>

              <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_involucradas" runat="server" Text="Personas Involucradas:" 
                        style="font-weight: 700"></asp:Label></td>
                <td><textarea id="Textarea_involucradas" cols= "75" rows="7" runat="server"></textarea></td>
            </tr>

            <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_correo" runat="server" Text="Correo Electrónico:" 
                        style="font-weight: 700"></asp:Label></td>
                  <td><asp:TextBox ID="TextBox_correo" runat="server" Width="227px"></asp:TextBox> </td>
            </tr>

             <tr>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                        <td><asp:Label ID="lb_tipoSolicitud" runat="server" Text="Tipo Solicitud:" 
                                style="font-weight: 700"></asp:Label></td>
                        <td><asp:DropDownList ID="DropDownList2" runat="server">
                           <asp:ListItem Selected="True">Prestamo</asp:ListItem>
                           <asp:ListItem Selected="False">Alquiler</asp:ListItem>
                        </asp:DropDownList></td>
                       
             </tr>

    </table>
        <p>Nota: Los campos con * son opccionales <br />
        Las personas involucradas deben ser ingresadas de la forma Nombre completo persona1, nombre completo persona2, ......
        </p>

    <div>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        
    </div>

    <asp:Button ID="boton_enviar_solicitud" runat="server" Text="Enviar Solicitud" 
            onclick="boton_enviar_solicitud_Click" />

</asp:Content>
