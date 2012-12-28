<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MostrarInstalacion.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.CU_SolicitarAreaDeportiva.MostrarInstalacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 299px;
        }
        .style2
        {
            width: 330px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<table>
    <tr>
        <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
        <td class="style2">
            <div id="imglogo">
                	<img src="../../imagenes/SolicitarAreaDeportiva.jpg" width="297px" height="526px" alt=""/>
            </div>
        </td>
        <td>
        <div style="height: 584px">
            <h2>Instalaciones Deportivas</h2>
           
            Seleccione la instalación deportiva que desea solicitar:
            <br />
            <br />
            <div>

                <asp:GridView ID="Grid_Instalaciones2" runat="server" AutoGenerateEditButton="True" 
                    DataKeyNames="identificacion"
                    onrowediting="GridView1_RowEditing" 
                    CellPadding="7" ForeColor="#333333" 
                    horizontalalign="Justify" 
                    autogeneratecolumns="true"
                    GridLines="None" >
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
                </asp:GridView>

            </div>
        </div>
        </td>
    </tr>
</table>

</asp:Content>
