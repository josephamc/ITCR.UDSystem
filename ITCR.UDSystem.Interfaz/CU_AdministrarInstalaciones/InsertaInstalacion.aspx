<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertaInstalacion.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.CU_AdministrarInstalaciones.InsertaInstalacion" %>
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
            <td class="style2"> <strong>>>>Paso1: Incluir Informacion General</strong></td>
            <td class="style3"> >>>Paso2: Incluir horario de la instalación</td>
        </tr>
    </table>
    <br />    
    <div id="imglogo">
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <img src="../../imagenes/ImgND2.png" alt=""/>
    </div>
    <table>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td><fieldset style="width: 800px; background-color: #587594;">
                <div>
                    <table>
                        <tr>
                        <td><asp:Label ID="nombre" runat="server" Text="Nombre Instalacion*:   " 
                                style="font-weight: 700; color: #FFFFFF;"></asp:Label></td>
                        <td><asp:TextBox ID="txt_nombre" runat="server" Width="300px"></asp:TextBox></td>
                        </tr>

                        <tr>
                        <td><asp:Label ID="descripcion" runat="server" Text="Descripcion*:   " 
                                style="font-weight: 700; color: #FFFFFF;"></asp:Label></td>
                        <td><textarea id="txt_descripcion" cols="75" rows="5" runat="server"></textarea></td>
                        </tr>

                        <tr>
                        <td><asp:Label ID="medidas" runat="server" Text="Medidas Instalacion*:   " 
                                style="font-weight: 700; color: #FFFFFF;"></asp:Label></td>
                        <td><textarea id="txt_medidas" cols="75" rows="3" runat="server"></textarea></td>
                        </tr>
            
                        <tr>
                        <td><asp:Label ID="reglamento" runat="server" Text="Reglamento de Uso*:   " 
                                style="font-weight: 700; color: #FFFFFF;"></asp:Label></td>
                        <td><textarea id="txt_reglamento" cols="75" rows="8" runat="server"></textarea></td>
                        </tr>
            
                        <tr>
                        <td><asp:Label ID="costos" runat="server" 
                                Text="Costos* (en caso de alquiler):" 
                                style="font-weight: 700; color: #FFFFFF;"></asp:Label></td>
                        <td><textarea id="txt_costos" cols="75" rows="2" runat="server"></textarea></td>
                        </tr>
            
                        <tr>
                        <td><asp:Label ID="comentarios" runat="server" Text="Comentarios Adicionales:   " 
                                style="font-weight: 700; color: #FFFFFF;"></asp:Label></td>
                        <td><textarea id="txt_comentarios" cols="75" rows="2" runat="server"></textarea></td>
                        </tr>
                    </table>
                    <asp:Label ID="nota" runat="server" Text="Los campos con * son obligatorios" 
                        style="font-style: italic; color: #CCCCCC;"></asp:Label>
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="ButtonInsInstalacion" runat="server" onclick="Button1_Click" 
                        Text="Guardar y Continuar" Height="32px" Width="243px" />
                </div>
            </fieldset></td>
        </tr>
    </table>
</asp:Content>
