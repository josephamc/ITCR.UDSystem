<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditaInstalacion.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.CU_AdministrarInstalaciones.EditaInstalacion" %>

<%@ PreviousPageType VirtualPath="~/CU_AdministrarInstalaciones/ConsultaInstalacion.aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script language="javascript" type="text/javascript">
    </script>
    <style type="text/css">
        .style1
        {
            width: 301px;
        }
        .style2
        {
            width: 144px;
            height: 160px;
        }
        #img_VISUALIZACION
        {
            height: 164px;
            width: 220px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Editar Instalacion</h2>
    <div>
    <table>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td><fieldset style="width: 800px; background-color: #587594;">
                <div>
                    <table>
                        <tr>
                            <td><img src="../../imagenes/editar.png" alt=""/></td>
                            <td><table>
                                <tr>
                                    <td>&nbsp;&nbsp;&nbsp;</td>
                                    <td>
                                        <table>
                                            <tr>
                                            <td><asp:Label ID="Label1" runat="server" Text="Identificacion*:   " 
                                                    ForeColor="White"></asp:Label></td>
                                            <td><asp:TextBox ID="txt_id" runat="server" Width="300px" ReadOnly="true"></asp:TextBox></td>
                                            </tr>

                                            <tr><td><br /></td></tr>

                                            <tr>
                                            <td><asp:Label ID="nombre2" runat="server" Text="Nombre de la Instalacion*:   " 
                                                    ForeColor="White"></asp:Label></td>
                                            <td><asp:TextBox ID="txt_nombre2" runat="server" Width="300px"></asp:TextBox></td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>                                
                            </table></td>
                        </tr>

                        <tr>
                        <td><asp:Label ID="descripcion2" runat="server" Text="Descripcion*:   " 
                                ForeColor="White"></asp:Label></td>
                        <td><textarea id="txt_descripcion2" cols="75" rows="5" runat="server"></textarea></td>
                        </tr>

                        <tr>
                        <td><asp:Label ID="medidas2" runat="server" Text="Medidas de la Instalacion*:   " 
                                ForeColor="White"></asp:Label></td>
                        <td><textarea id="txt_medidas2" cols="75" rows="3" runat="server"></textarea></td>
                        </tr>
            
                        <tr>
                        <td><asp:Label ID="reglamento2" runat="server" Text="Reglamento de Uso*:   " 
                                ForeColor="White"></asp:Label></td>
                        <td><textarea id="txt_reglamento2" cols="75" rows="8" runat="server"></textarea></td>
                        </tr>
            
                        <tr>
                        <td><asp:Label ID="costos2" runat="server" 
                                Text="Costos (por hora o por actividad)*:" ForeColor="White"></asp:Label></td>
                        <td><textarea id="txt_costos2" cols="75" rows="2" runat="server"></textarea></td>
                        </tr>
            
                        <tr>
                        <td><asp:Label ID="comentarios2" runat="server" Text="Comentarios Adicionales:   " 
                                ForeColor="White"></asp:Label></td>
                        <td><textarea id="txt_comentarios2" cols="75" rows="2" runat="server"></textarea></td>
                        </tr>
                        <tr>
                        <td>
                            <asp:Label ID="lbl_Imagen" runat="server" Text="Label" ForeColor="White"></asp:Label></td>
                        <td>
                            <asp:FileUpload ID="fu_IMAGE_UPLOAD" runat="server" /></td>
                        </tr>
                        <tr>
                        <td>
                            <asp:Label ID="lbl_Visualizacion" runat="server" Text="Visualizacion: " ForeColor="White"></asp:Label></td>
                            <td>
                                <img id="img_VISUALIZACION" alt="" src="" runat="server" width="220" height="164"/></td>
                        </tr>
                    </table>
                    </div>
                    <asp:Label ID="nota2" runat="server" 
                    Text="Los campos con * son obligatorios" ForeColor="#CCCCCC"></asp:Label>
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                    ID="Button2" runat="server" Text="Finalizar Edición" Width="150px" 
                    onclick="Button2_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="Editar Horarios" 
                        onclick="Button1_Click" Width="150px" />
            </fieldset></td>
        </tr>
    </table>
  </div>
        &nbsp;</asp:Content>
