<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Seleccionar.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.Reportes.Seleccionar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h1><img align="bottom" alt="" src="../imagenes/forward.png" />Generación de reportes</h1>

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
                                    <td>Fecha inicio:</td>
                                    <td>
                                        <ajaxToolkit:ToolkitScriptManager ID="tkManager" runat="server">
                                        </ajaxToolkit:ToolkitScriptManager>
                                        <asp:TextBox ID="txtInicio" runat="server" Width="235px"></asp:TextBox>
                                        <ajaxToolkit:CalendarExtender
                                            ID="cldExtender" TargetControlID="txtInicio" PopupButtonID="imgCalendar" 
                                            runat="server" Format="dd/MM/yyyy">
                                        </ajaxToolkit:CalendarExtender>
                                        <img id="imgCalendar" align="middle" alt="" src="../imagenes/date.png" /></td>
                                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtInicio" ErrorMessage="*"></asp:RequiredFieldValidator></td>                                                                         
                                        <td><asp:RegularExpressionValidator ID="DateValidator2" runat="server" ControlToValidate="txtInicio"  ErrorMessage="Fecha inválida. Ingrese la fecha en un formato adecuado, ejemplo: 31/12/2012" ValidationExpression="^(?:(?:0?[1-9]|1\d|2[0-8])(\/|-)(?:0?[1-9]|1[0-2]))(\/|-)(?:[1-9]\d\d\d|\d[1-9]\d\d|\d\d[1-9]\d|\d\d\d[1-9])$|^(?:(?:31(\/|-)(?:0?[13578]|1[02]))|(?:(?:29|30)(\/|-)(?:0?[1,3-9]|1[0-2])))(\/|-)(?:[1-9]\d\d\d|\d[1-9]\d\d|\d\d[1-9]\d|\d\d\d[1-9])$|^(29(\/|-)0?2)(\/|-)(?:(?:0[48]00|[13579][26]00|[2468][048]00)|(?:\d\d)?(?:0[48]|[2468][048]|[13579][26]))$" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator></td>
                                </tr>
                                <tr>
                                    <td>Fecha Fin:</td>
                                    <td>
                                        <asp:TextBox ID="txtFin" runat="server" Width="235px"></asp:TextBox>
                                        <ajaxToolkit:CalendarExtender
                                            ID="cldExtenderFin" TargetControlID="txtFin" PopupButtonID="imgCalendarFin" Format="dd/MM/yyyy" runat="server">
                                        </ajaxToolkit:CalendarExtender>
                                        <img id="imgCalendarFin" align="middle" alt="" src="../imagenes/date.png" /></td>
                                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFin" ErrorMessage="*"></asp:RequiredFieldValidator></td>                                                                         
                                        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtFin"  ErrorMessage="Fecha inválida. Ingrese la fecha en un formato adecuado, ejemplo: 31/12/2012" ValidationExpression="^(?:(?:0?[1-9]|1\d|2[0-8])(\/|-)(?:0?[1-9]|1[0-2]))(\/|-)(?:[1-9]\d\d\d|\d[1-9]\d\d|\d\d[1-9]\d|\d\d\d[1-9])$|^(?:(?:31(\/|-)(?:0?[13578]|1[02]))|(?:(?:29|30)(\/|-)(?:0?[1,3-9]|1[0-2])))(\/|-)(?:[1-9]\d\d\d|\d[1-9]\d\d|\d\d[1-9]\d|\d\d\d[1-9])$|^(29(\/|-)0?2)(\/|-)(?:(?:0[48]00|[13579][26]00|[2468][048]00)|(?:\d\d)?(?:0[48]|[2468][048]|[13579][26]))$" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator></td>
                                </tr>
                                
                                <tr>
                                    <td></td>
                                    <td>
                                        <asp:Label ID="nota" runat="server" Text="Formato de Fecha= dd/MM/yyyy, eje: 31/12/2012" style="font-style: italic"></asp:Label>
                                    </td>
                                </tr>

                                <tr>
                                <td></td>
                                </tr>

                                <tr>
                                    <td>Desea crear reporte de:</td>
                                    <td style="margin-left: 40px">
                                        <asp:RadioButtonList ID="rb_tipoReporte" runat="server" 
                                            AutoPostBack="False">
                                        <asp:ListItem Text="Reservaciones" Value="1" Selected="True"></asp:ListItem>
                                        <asp:ListItem Text="Estadisticas de Uso" Value="2" Selected="False"></asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>

                                <tr>
                                <td><hr /></td>
                                <td><hr /></td>
                                </tr>
                                
                                
                                <tr>
                                    <td>Tipo de información:</td>
                                    <td style="margin-left: 40px">
                                        <asp:RadioButtonList ID="rblOpciones" runat="server">
                                            <asp:ListItem Selected="True">Documento Web</asp:ListItem>
                                            <asp:ListItem>Descargar documento PDF</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>

                                
                                <tr>
                                    <td>
                                    <br />
                                    </td>
                                </tr>
                                
                                
                            </table>

                            <table runat="server" id="txtfield_formatoEstadisticas" visible="true">
                                <tr>
                                    <td>
                                        <asp:RadioButtonList ID="rb_tipo" runat="server">
                                        <asp:ListItem Text="Individual" Value="1" Selected="True"></asp:ListItem>
                                        <asp:ListItem Text="General" Value="2" Selected="False"></asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>

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
                                <td>&nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            </table>
                        </fieldset> 
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnGenerar" runat="server" Text="Generar Reporte" 
                        onclick="btnGenerar_Click" />
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
