<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IndiceEstadisticas.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.CU_EstadisticasUso.IndiceEstadisticas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h1><asp:Label ID="Label1" runat="server" Text="Ingresar Estadisticas de Uso"></asp:Label></h1>
    <br />
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
                        <asp:DropDownList ID="ddl_instalaciones" runat="server" Width="324px" 
                            onselectedindexchanged="ddl_instalaciones_SelectedIndexChanged">
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
                        <asp:TextBox ID="txt_cantU" runat="server" 
                            ontextchanged="txt_cantU_TextChanged"></asp:TextBox>
                    </td>
               </tr>    
                <tr>
                    <td>            
                        &nbsp;&nbsp;&nbsp; 
                        <asp:Label ID="Label4" runat="server" Text="Fecha:"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txt_fecha" runat="server" Width="116px"
                            Height="17px"></asp:TextBox>  <img id="imgCalendar" alt="" src="../imagenes/date.png" />
                         <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager11" runat="server">
                        </ajaxToolkit:ToolkitScriptManager>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator31" runat="server" ControlToValidate="txt_fecha" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <ajaxToolkit:CalendarExtender ID="CalendarExtender1" TargetControlID="txt_fecha" PopupButtonID="imgCalendar" 
                        runat="server" Format="yyyy-MM-dd"> 
                        </ajaxToolkit:CalendarExtender>
                       <asp:RegularExpressionValidator ID="DateValidator13" runat="server" ControlToValidate="txt_fecha"  ErrorMessage="Fecha inválida. Ingrese la fecha en un formato adecuado, ejemplo: 2012-12-31" ValidationExpression="((19|20)\d\d)[-](0[1-9]|1[012])[-](0[1-9]|[12][0-9]|3[01])" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                        
                    </td>        
                </tr>
                <tr>
                    <td>                        
                        <asp:Label ID="error_usuarios" runat="server" 
                            Text="La cantidad de usuarios debe ser un número" ForeColor="Red"></asp:Label>&nbsp;
                    </td>
                </tr>
                <tr>
                <td>&nbsp;&nbsp;&nbsp;
                </td>
                </tr>
                <tr>
                    <td>
                    <fieldset style="width: 475px" visible="false" runat="server" id="fieldset_exito">
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Msj_exito" runat="server" 
                            Text="¡Los Datos Fueron Insertados Correctamente!" ForeColor="#009933" 
                            Font-Bold="True"></asp:Label>
                        <br />
                        <asp:Label ID="usu" runat="server" Text="_usuarios" ForeColor="#009933"></asp:Label>&nbsp;
                        <asp:Label ID="m01" runat="server" Text=" usuarios hicieron uso de la instalacion deportiva: "></asp:Label>&nbsp;
                        <asp:Label ID="inst" runat="server" Text="_instalacion" ForeColor="#009933"></asp:Label>&nbsp;
                        <asp:Label ID="m02" runat="server" Text=" en la fecha: "></asp:Label>&nbsp;
                        <asp:Label ID="fecha" runat="server" Text="_fecha" ForeColor="#009933"></asp:Label>&nbsp;
                        </fieldset>
                    </td>
                </tr>
            </table></td>
        </tr>
    </table>
    <br />
    <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Insertar Datos" Height="36px" 
            Width="152px" onclick="Button2_Click" />
    </div>

</asp:Content>
