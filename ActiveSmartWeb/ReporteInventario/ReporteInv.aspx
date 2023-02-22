<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/Site.Master" AutoEventWireup="true" CodeBehind="ReporteInv.aspx.cs" Inherits="ActiveSmartWeb.ReporteInventario.ReporteInv" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="main">
    
      <div id="reporteinventarios" class="section">
        <reporte></reporte>
      </div>
    </div>
    <script src="../js/html2pdf.bundle.min.js"></script> 
    <script src="Js/ReporteInventario.js"></script>
    <script src="../js/Table.js"></script>
</asp:Content>