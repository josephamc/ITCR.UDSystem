<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmAdminSolicitud.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.GestionarSolicitudes.frmSolicitud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <table>
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Image ID="imgAdminSolicitudes" runat="server" 
                      ImageUrl="~/imagenes/GestionarSolicitudes.jpg" width="297px" height="526px" />
                   
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td valign="top">
                <div>
                <h1>Solicitudes de Instalaciones Deportivas</h1>
                <br />
                    <div>
                        <asp:ImageButton ID="btnActualizar" runat="server" 
                            ImageUrl="~/imagenes/update.png" onclick="btnActualizar_Click" />
                    </div>
                <br />
                    <div>
                        <asp:GridView ID="dgSolicitudes" runat="server" CellPadding="4" 
                            ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:CommandField ButtonType="Image" CancelText="" DeleteText="" 
                                    EditImageUrl="~/imagenes/eye_inv.png" EditText="Ver" InsertText="" NewText="" 
                                    SelectText="" ShowCancelButton="False" ShowEditButton="True" UpdateText="" />
                            </Columns>
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
