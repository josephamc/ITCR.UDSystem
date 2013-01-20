<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmCalendario.aspx.cs" Inherits="ITCR.UDSystem.Interfaz.CU_AdministrarCalendario.ConsultaCalendario" %>
<%@ Register Assembly="DayPilot" Namespace="DayPilot.Web.Ui" TagPrefix="DayPilot" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Administradores -->
    <asp:ScriptManager ID="scrManager" runat="server">
    </asp:ScriptManager>
    
    <!-- Encabezado -->
    <br />
    <asp:Image ID="imgBanner" runat="server" ImageUrl="~/imagenes/rptReservacion.JPG" />

    <!-- Calendario -->
    <h1>Consultar Calendario</h1>
    <br />
    <div id="Calendario">
    <asp:UpdatePanel ID="updPanel" runat="server">
        <ContentTemplate>
            <p>Selecciona alguna semana para desplegar en el calendario el conjunto de actividades presentes en dicha semana.</p>
            <!-- Calendar Seleccion -->
            <asp:Calendar ID="cldSeleccion" runat="server" CssClass="calendar" 
                OnSelectionChanged="cldSeleccion_SelectionChanged" BackColor="White" 
                BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" 
                ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                  <TodayDayStyle BorderColor="red" BorderStyle="Solid" BorderWidth="1px"></TodayDayStyle>
                  <SelectedDayStyle BackColor="#9EBEF5" ForeColor="White"></SelectedDayStyle>
                  <TitleStyle BackColor="White" BorderColor="#4c4c4c" BorderWidth="2px" 
                      Font-Bold="True" Font-Size="12pt" ForeColor="#06266F"></TitleStyle>
                  <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                  <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" 
                      VerticalAlign="Bottom" />
                  <OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
             </asp:Calendar>
           
            <!-- Calendario de eventos-->
             <h2>Eventos, Reservaciones y Cursos</h2>
             <DayPilot:DayPilotCalendar ID="dpCalendar" runat="server" DataEndField="end"
                       DataStartField="start" DataTextField="name" DataValueField="id" 
                       Days="7" OnEventClick="dpCalendar_EventClick" EventClickHandling="PostBack" 
                       HeightSpec="Full" 
                       BackColor="#FDFDFD" BusinessBeginsHour="0" BusinessEndsHour="24" 
                       HourBorderColor="#AAAAAA" HourHalfBorderColor="#D0D0D0" HoverColor="#F6F6F6" 
                       NonBusinessBackColor="#FDFDFD" DurationBarColor="#2A4480"></DayPilot:DayPilotCalendar>
             <br />
         </ContentTemplate>
     </asp:UpdatePanel>
     </div>
</asp:Content>
