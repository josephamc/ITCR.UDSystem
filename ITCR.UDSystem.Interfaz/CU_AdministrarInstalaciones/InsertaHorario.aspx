<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertaHorario.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.CU_AdministrarInstalaciones.InsertaHorario" %>

<%@ PreviousPageType VirtualPath="~/CU_AdministrarInstalaciones/InsertaInstalacion.aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 186px;
        }
        .style2
        {
            width: 244px;
        }
        .style3
        {
            width: 284px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Insertar Instalacion</h2>
    <table>
        <tr>
            <td class="style2"> >>>Paso1: Incluir Informacion General</td>
            <td class="style3"> <strong>>>>Paso2: Incluir horario de la instalación</strong></td>
            <td> >>>Paso3: Incluir imagenes</td>
        </tr>
    </table>
    <br />
    <br />
    <fieldset style="width: 800px">
    <table>
        <tr>
            <td><div id="imglogo">
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <img src="../../imagenes/hora01.jpg" alt=""/>
            </div></td>
            <td><table>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    <td><asp:Label ID="label01" runat="server" 
                            Text="Identificacion de la Instalación:   " style="font-weight: 700"></asp:Label></td>
                    <td><asp:Label ID="lb_id" runat="server" ></asp:Label></td>
                </tr>
            </table>
            <table>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    <td><asp:Label ID="hra_inicio" runat="server" Text="Hora Inicio:" 
                            style="font-weight: 700"></asp:Label></td>
                    <td><asp:TextBox ID="txt_Inicio" runat="server" Width="90px"></asp:TextBox></td>
                    <td><asp:DropDownList ID="ddlAmPm1" runat="server">
                       <asp:ListItem Selected="True">AM</asp:ListItem>
                       <asp:ListItem Selected="False">PM</asp:ListItem>
                    </asp:DropDownList></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_Inicio" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                    <td>&nbsp;</td>
                </tr>
        
                <tr>            
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    <td><asp:Label ID="hra_fin" runat="server" Text="Hora Fin:" 
                            style="font-weight: 700"></asp:Label></td>
                    <td><asp:TextBox ID="txt_Fin" runat="server" Width="90px"></asp:TextBox></td>
                    <td><asp:DropDownList ID="ddlAmPm2" runat="server">
                       <asp:ListItem Selected="True">AM</asp:ListItem>
                       <asp:ListItem Selected="False">PM</asp:ListItem>
                    </asp:DropDownList></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_Fin" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                </tr>
            </table>
            <div>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label 
                    ID="nota" runat="server" Text="Formato de Hora= hh:mm, ejemplo: 6:45" 
                    style="font-style: italic"></asp:Label>
                    <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RegularExpressionValidator ID="TimeValidator2" runat="server" 
                    ControlToValidate="txt_Inicio" Display="Dynamic" 
                    ErrorMessage="Hora Invalida. Ingrese la hora en un formato adecuado." 
                    ValidationExpression="^(1[0-2]|[1-9]):[0-5][0-9]$" EnableClientScript="False" 
                    ForeColor="Red"></asp:RegularExpressionValidator>
            </div>
                
            <br />
            <br />
            <table>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    <td><asp:CheckBox Text="Lunes" ID="ck_lunes"  runat="server" 
                            style="font-weight: 700" /></td>
                    <td><asp:CheckBox Text="Martes" ID="ck_martes"   runat="server" 
                            style="font-weight: 700" /></td>
                    <td><asp:CheckBox Text="Miercoles" ID="ck_miercoles"   runat="server" 
                            style="font-weight: 700" /></td>
                    <td><asp:CheckBox Text="Jueves" ID="ck_jueves"   runat="server" 
                            style="font-weight: 700" /></td>
                    <td><asp:CheckBox Text="Viernes" ID="ck_viernes"   runat="server" 
                            style="font-weight: 700" /></td>
                    <td><asp:CheckBox Text="Sabado" ID="ck_sabado"   runat="server" 
                            style="font-weight: 700" /></td>
                    <td><asp:CheckBox Text="Domingo" ID="ck_domingo"   runat="server" 
                            style="font-weight: 700" /></td>
                </tr>
            </table>
            
            &nbsp;&nbsp;&nbsp; &nbsp;
            <br />
            &nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="Button1" runat="server" Text="Agregar Horario" onclick="ButtonGuardarHoarario_Click" /></td> 
        </tr>
    </table>
    </fieldset>


    <br />
    <div>
        <table>
            <tr>
                <td>&nbsp;&nbsp;&nbsp; &nbsp;</td>
                <td>En la siguiente tabla de muestran los horarios existentes para la instalación:</td>
            </tr>

            <tr>
                <td>&nbsp;&nbsp;&nbsp; &nbsp;</td>
            </tr>

            <tr>
                <td>&nbsp;&nbsp;&nbsp; &nbsp;</td>
                <td><asp:GridView ID="Grid_Horarios" runat="server" CellPadding="4" AutoGenerateDeleteButton="True"                   
                        DataKeyNames="ident"             
                        onrowdeleting="GridView1_RowDeleting"
                        ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView></td>
                <td>
                    <div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="ButtonCont2" runat="server" Text="Continuar" Width="229px" 
                            onclick="ButtonCont2_Click" Height="28px" />
                    </div>
                </td>
            </tr>
        </table>
    </div>
    <br />
    
</asp:Content>
