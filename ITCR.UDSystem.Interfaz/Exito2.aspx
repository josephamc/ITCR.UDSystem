<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exito2.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.Exito" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head2" runat="server">
	<title></title>
    <script src="~/js/jquery.js" type="text/javascript"></script>
    <script src="~/js/jquery-ui.js" type="text/javascript"></script>
	<script src="~/scripts/Interfaz.js" type="text/javascript"></script>
	<link href="~/css/itcr.css" rel="stylesheet" type="text/css" />
    </head>
<body style="text-align:center">
	<form id="Form2" runat="server">
	    <div class="page" style="text-align:center; height:180px" >
		    <div class="main" style="text-align:center;margin:0 auto 0 auto; width:390px; ">             
                    <table>
                        <tr>
                            <td>
                                <div id="imglogo">
                	                    <img src="../../imagenes/correcto02.jpg" alt=""/>
                                </div>
                            </td>
                            <td>
                                <div>
                                    <h1> ¡ Realizacion Exitosa ! </h1>
                                    <h3>La operacion ha sido realizada de manera correcta en el sistema.</h3>
                                    <asp:HyperLink ID="link01" runat="server" NavigateUrl="~/CU_AdministrarInstalaciones/ConsultaInstalacion.aspx">Volver a Lista Instalaciones</asp:HyperLink>
                                    <br />
                                </div>
                            </td>
                        </tr>
                    </table>
		    </div>
	    </div>
	    <div class="footer">
		    <div>
			   © CopyRight 2012 - Tecnologico de Costa Rica
		    </div>
	    </div>
	</form>
</body>
</html>
