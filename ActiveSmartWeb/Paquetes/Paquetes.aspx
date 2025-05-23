﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/Site.Master" AutoEventWireup="true" CodeBehind="Paquetes.aspx.cs" Inherits="ActiveSmartWeb.Paquetes.Paquetes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="main" id="PaquetesVUE">
      <div class="wf-section">
        <div class="container-2 w-container">
          <div class="w-layout-grid grid-main">
            <div id="w-node-_9cf1d33f-1f83-9189-54c6-06f92eacb0e1-ee1567c5" class="div-banner-extremo"></div>
            <div id="w-node-_9cf1d33f-1f83-9189-54c6-06f92eacb0e2-ee1567c5" class="div-title-a">
              <div>
                <div class="w-layout-grid grid-container-title">
                  <a href="menu.html" class="link-block-back w-inline-block"><img src="../images/Back-arrow.svg" loading="lazy" height="26" width="26" alt="" class="back"></a>
                  <h1 class="titulo-principal"> {{listaIdiomas.Titulo}}</h1>
                </div>
              </div>
            </div>
            <div id="w-node-_9cf1d33f-1f83-9189-54c6-06f92eacb0e7-ee1567c5" class="div-banner-extremo"></div>
            <div id="w-node-_9cf1d33f-1f83-9189-54c6-06f92eacb0e8-ee1567c5" class="div-users-container-ai empleados-content-ai">
              <div class="div-tarjeta">
                <div class="form-block w-form">
                </div>
              </div>
              <div class="div-tarjeta">
                <div class="block-form-aid w-form">
                  <div id="email-form" name="email-form" data-name="Email Form" method="get">
                    <div class="w-layout-grid grid-form"><label for="email" id="w-node-_35e72e90-026b-9e5d-9026-0dd1a2c36b9d-ee1567c5" class="field-label">{{listaIdiomas.Tituloagregar}}</label>
                      <div id="w-node-_35e72e90-026b-9e5d-9026-0dd1a2c36b9f-ee1567c5" class="form-line"><label for="name-5" class="field-label">{{listaIdiomas.Nombre}}</label>
                          <input type="text" class="text-field w-input" maxlength="256" name="name-4" data-name="Name 4" placeholder="" id="name-4" v-model="nombre"></div>
                      <div id="w-node-_35e72e90-026b-9e5d-9026-0dd1a2c36ba3-ee1567c5" class="form-line"><label for="name-5" class="field-label">{{listaIdiomas.Descripcion}}</label>
                          <input type="text" class="text-field w-input" maxlength="256" name="name-4" data-name="Name 4" placeholder="" id="name-4" v-model="descripcion"></div>
                      <div id="w-node-_35e72e90-026b-9e5d-9026-0dd1a2c36ba7-ee1567c5" class="form-line"><label for="name-4" class="field-label">{{listaIdiomas.Cantidad}}</label>
                          <input type="text" class="text-field w-input" maxlength="256" name="name-4" data-name="Name 4" placeholder="" id="name-4" v-model="cantidad"></div>
                      <div id="w-node-_35e72e90-026b-9e5d-9026-0dd1a2c36bab-ee1567c5" class="form-line"><label for="name-4" class="field-label">{{listaIdiomas.Costo}}</label>
                          <input type="email" class="text-field w-input" maxlength="256" name="name-4" data-name="Name 4" placeholder="" id="name-4" v-model="costo"></div>
                         <div id="w-node-_35e72e90-026b-9e5d-9026-0dd1a2c36bb7-ee1567c5" class="contenedor-botones" >
                        <a href="#" class="link-block-boton dere w-inline-block"  v-on:click="InsertarPaquete">
                           <img src="../images/save_blanco.svg" loading="lazy" alt=""></a>
                        <a href="#" class="link-block-boton dere w-inline-block"  v-on:click="LimpiarCampos">
                           <img src="../../images/eraser.svg" loading="lazy" alt=""></a>
                        
                       </div>
                    </div>
                  </div>
                </div>
              </div>
              <div class="div-tarjeta div-usuarios-ai">
                <div class="form-block-usuarios w-form">
                  <div id="email-form-4" name="email-form-4" data-name="Email Form 4" method="get" class="form-rol-usuarios-ai">
                        <div class="contenedor-grid">
                           <table class="" style="width:100%">
                            <thead >
                             <tr class="w-layout-grid grid _4 grid-tabla-ai grid-empleados"style="grid-template-rows: auto;grid-template-columns: 34% 30% 15% 15% 5%;">
                                <td class="texto-blanco">{{listaIdiomas.Nombre}}</td>
                                <td class="texto-blanco">{{listaIdiomas.Descripcion}}</td>
                                <td class="texto-blanco">{{listaIdiomas.Cantidad}}</td>
                                <td class="texto-blanco">{{listaIdiomas.Costo}}</td>
                                <td class="texto-blanco"></td>
                             </tr>                                                                                
                            </thead>
                            <tbody  style="display: flex; flex-direction: column" >
                                <tr  v-for="(paquete, index) in datosPaginados" :key="paquete.IdPaqueteContratado"
                                    class="w-layout-grid grid _4 grid-tabla-ai grid-empleados" style="grid-template-rows: 30px;grid-template-columns: 34% 30% 15% 15% 5%;"> 
                                    <td id="w-node-_15005c8e-5141-aa28-c762-dc7b437ea3d1-ee1567c5" class="td-celda-activos-ai">
                                          <div class="text-block-23">
                                            {{paquete.Nombre}}
                                         </div>
                                    </td>
                                    <td id="w-node-_15005c8e-5141-aa28-c762-dc7b437ea3d1-ee1567c5" class="td-celda-activos-ai">
                                          <div class="text-block-23">
                                            {{paquete.Descripcion}}
                                         </div>
                                    </td>
                                    <td id="w-node-_15005c8e-5141-aa28-c762-dc7b437ea3d1-ee1567c5" class="td-celda-activos-ai" style="overflow-y: hidden; overflow-x:clip">
                                          <div class="text-block-23">
                                            {{paquete.Cantidad}}
                                        </div>
                                    </td>
                                    <td id="w-node-_15005c8e-5141-aa28-c762-dc7b437ea3d1-ee1567c5" class="td-celda-activos-ai">
                                          <div class="text-block-23">
                                            {{paquete.Costo}}
                                           </div>
                                    </td>
                                    <td id="w-node-_15005c8e-5141-aa28-c762-dc7b437ea3d1-ee1567c5" class="td-celda-activos-ai">
                                           <div class="text-block-23 link-block-2 amarillo w-inline-block">
                                                <a :id="paquete.IdPaqueteContratado" 
                                                     @click="CargarPaquetes(paquete.IdPaqueteContratado)"
                                                :name="paquete.Nombre":value="paquete.idPaqueteContratado">
                                                <img src="../images/editar.svg" loading="lazy"  alt=""  class="image-29">    
                                                </a>    
                                            </div>
                                     </td>
                                </tr>      
                            </tbody>
                           <tfoot>
                                                <tr>
                                                    <td>
                                                        <div class="pagination-content">
                                                            <div class="form-block-19 block-pag w-form">
                                                                <div id="email-form-3" name="email-form-3" data-name="Email Form 3" method="get" class="form-11">
                                                                    <img v-on:click="PaginaAnterior()" src="../images/simbolo-de-doble-flecha-izquierda-hacia-atras-rapido.png"
                                                                        loading="lazy" width="15" height="15" alt="" class="image-9">
                                                                    <label for="name-2" class="cant-paginas">{{paginaActual}}</label>
                                                                    <label for="name-2" class="cant-paginas">de {{paginas}}</label>
                                                                    <img  v-on:click="PaginaSiguiente()" src="../images/angulos-de-flechas-dobles-a-la-derecha.png" loading="lazy" width="15" height="15" alt="" class="image-9">
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </td>
                                                </tr>
                                            </tfoot>
                        </table>
                        </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <script src="../Recursos/JQuery/jquery-3.5.1.min.dc5e7f18c8.js"></script>
    <link href="../css/signusid.webflow.css" rel="stylesheet" />
    <script src="Js/Paquetes.js"></script>
</asp:Content>
