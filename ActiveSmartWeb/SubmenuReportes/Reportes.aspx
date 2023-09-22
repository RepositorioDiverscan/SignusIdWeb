<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/Site.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="ActiveSmartWeb.SubmenuReportes.Reportes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .container-2{
            max-width:940px !important;
        }
    </style>

    <div class="main">
      <div id="submenuReportes" class="section" v-cloak>
        <submenureporte></submenureporte>
      </div>
    </div>
    <link href="../css/signusid.webflow.css" rel="stylesheet" />
    <script src="Js/ReportesSubmenu.js"></script>
</asp:Content>