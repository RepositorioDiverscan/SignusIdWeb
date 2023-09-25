<%@ Page Language="C#" MasterPageFile="~/SiteMaster/Site.Master" AutoEventWireup="true" CodeBehind="MisCompras.aspx.cs" Inherits="ActiveSmartWeb.MisCompras.MisCompras" %>

 

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" style="width:100%">

 

    <link href="../css/transicion.css" rel="stylesheet" />
<div class="main" id="context" style="width:100%" >
<div class="section wf-section" style="width:100%">
<div class="container-2 w-container">
<div class="w-layout-grid grid-main">
<div id="w-node-b3e6ab24-c2e2-12bc-4cfe-327d5390147e-5696b687" class="div-banner-extremo"></div>
<div id="w-node-b3e6ab24-c2e2-12bc-4cfe-327d5390147f-5696b687" class="div-title-a">
<div class="w-layout-grid grid-container-title" style="padding-top:10px; padding-bottom:10px">
<a href="#" onclick="window.history.back()" class="link-block-back w-inline-block"><img src="../images/Back-arrow.svg" loading="lazy" height="26" width="26" alt="" class="back"></a>
<h1 id="w-node-_9be28721-5dbb-5f12-6325-d0dcd6cba1e6-ffdc8228" class="titulo-principal">{{listaIdiomas.Titulo}}</h1>
<div data-hover="false" data-delay="0" id="w-node-_01c345db-44dd-5950-8797-fc0e77f5b71f-731f63ba" class="dropdown-detalles-ai w-dropdown">
<div class="toggle-detalles-ai w-dropdown-toggle" style="padding:0px"><img src="../images/info2.svg" loading="lazy" alt="" class="img-detalles-ai"></div>
<nav class="detalles-descrp-ai w-dropdown-list">
<p class="p-desc-detalles-ai">{{listaIdiomas.Msj1}}<strong><br>{{listaIdiomas.Msj2}}</strong></p>
</nav>
</div>
</div>
</div>
<div id="w-node-b3e6ab24-c2e2-12bc-4cfe-327d539014cd-5696b687" class="div-banner-extremo"></div>
<div id="w-node-b3e6ab24-c2e2-12bc-4cfe-327d53901484-5696b687" class="div-notf-container">
<div class="div-tarjeta tarjeta-compra">
<div class="div-renv-plan w-clearfix" v-for="(informacion,index) in Informaciones" :key="index">
<div class="left-info box-plan">
<div class="header-box">
<div class="p-type-plan-ai p-titulo-compra bor-bottom">{{listaIdiomas.Titulo1TablaInfo}}</div>
</div>
<div class="info-box">
<div class="p-type-plan-ai p-titulo-compra">Active ID Smart {{informacion.Nombre}}</div>
</div>
</div>
<div class="box-vencimiento">
<div class="header-box">
<div class="p-type-plan-ai p-titulo-compra bor-bottom">{{listaIdiomas.Titulo2TablaInfo}}</div>
</div>
<div class="info-box">
<div class="p-type-plan-ai p-titulo-compra">{{informacion.FechaVencimiento}}</div>
</div>
</div>
<div class="div-btn-ren-plan">
<a href="#" class="btn-renovar-plan w-button" style="background-color: #ccc;">{{listaIdiomas.BotonRenovar}}</a>
</div>
</div>

 

                <div class="text-block-24">{{listaIdiomas.TituloAdicionales}}</div>

<div class="contenedor-grid grid-compras">
<table style="width:100%">
<thead>
<tr  class="w-layout-grid grid-rs-compras" 
                                        style="grid-template-rows: auto;">
<td class="texto-blanco th-tabla-ai">{{listaIdiomas.Titulo1TablaAdicionales}}</td>
<td class="texto-blanco th-tabla-ai">{{listaIdiomas.Titulo2TablaAdicionales}}</td>
<td class="texto-blanco th-tabla-ai">{{listaIdiomas.Titulo3TablaAdicionales}}</td>
<td class="texto-blanco th-tabla-ai"></td>
</tr>
</thead>
<tbody  style="display: flex; flex-direction: column" >
<tr v-for="(adicional,index) in AdicionalesMisCompras"
                                        :key="index" 
                                        class="w-layout-grid grid-rs-compras" 
                                        style="grid-template-rows: 40px;">

<td class="celda-vacia td-celda-ai celda-compra celda-align">
<div class="p-tabla-user-info"> {{adicional.Nombre}}</div></td>

 

                                        <td class="celda-vacia td-celda-ai celda-compra w-clearfix">
<div class="cant-act-ai"> {{adicional.Total}}</div></td>

 

                                        <td class="celda-vacia td-celda-ai celda-compra w-clearfix">
<div class="cant-act-ai">{{adicional.Consumido}}</div></td>

 

                                        <td class="celda-vacia td-celda-ai celda-compra w-clearfix">
<a href="#" class="btn-add-ai w-button" @click="AdicionalTienda(adicional)">+</a></td>
</tr>  
</tbody>

 

                            </table>

 

                        </div>

 

              
</div>
<div class="div-tarjeta div-cinta">
<div class="div-block-170">
<div class="text-block-17">{{listaIdiomas.TextoLeyenda}}</div><!---->
<a href="../Tienda/Tienda.aspx" class="boton call2action w-button">{{listaIdiomas.BotonIrTienda}}<strong></strong></a>
</div>
</div>
</div>
</div>
</div>
</div>
</div>

 

 


<script src="../js/webflow.js" type="text/javascript"></script>
<!-- [if lte IE 9]><script src="https://cdnjs.cloudflare.com/ajax/libs/placeholders/3.0.2/placeholders.min.js"></script><![endif] -->
<script src="../Recursos/JQuery/jquery-3.5.1.min.dc5e7f18c8.js"></script>
<script src="../VisorActivos/Vue/vue.min.js"></script>
<script src="js/MisCompras.js?v=1.2.4"></script>
</asp:Content>