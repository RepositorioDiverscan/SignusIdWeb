<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="ActiveSmartWeb.Usuarios.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="main" id="context">
      <div class="wf-section" id="alertas">
        <div class="container-2 w-container">
          <div class="w-layout-grid grid-main">
            <div id="w-node-_439eb1c6-517d-27c1-8c31-c0a7cce5ffa4-5cd4b2a9" class="div-banner-extremo"></div>
            <div id="w-node-_41952bd1-1a4c-8af0-97fe-66407a5bb629-5cd4b2a9" class="div-title-a">


              <div class="w-layout-grid grid-container-title" style="padding-top:7px; padding-bottom:6px">
                  <a href="../Menu/MenuPrincipal.aspx" class="link-block-back w-inline-block">
                      <img src="../images/Back-arrow.svg" loading="lazy" height="26" width="26" alt="" class="  ">
                  </a>
                  <h1 id="w-node-_9be28721-5dbb-5f12-6325-d0dcd6cba1e6-ffdc8228" class="titulo-principal" v-cloak>{{listaIdiomas.Titulo}}</h1>
                  <div data-hover="false" data-delay="0" id="w-node-_01c345db-44dd-5950-8797-fc0e77f5b71f-731f63ba" class="dropdown-detalles-ai w-dropdown">
                      <div class="toggle-detalles-ai w-dropdown-toggle" style="padding:0px">
                          <img src="../images/info2.svg" loading="lazy" alt="" class="img-detalles-ai">
                      </div>
                      <nav class="detalles-descrp-ai w-dropdown-list">
                          <p class="p-desc-detalles-ai" v-cloak>{{listaIdiomas.Msj1}}<strong><br>{{listaIdiomas.Msj2}}</strong></p>
                      </nav>
                  </div>
              </div>


            </div>
            <div id="w-node-_1816487a-ac19-734c-509e-d0ddf61fbb31-5cd4b2a9" class="div-banner-extremo"></div>
            <div id="w-node-_8d68a1a8-aad7-8ed9-6372-c8d6e75c9ec5-5cd4b2a9" class="div-users-container-ai">
              <div class="div-tarjeta tarjeta-responsive">
                <div class="form-block w-form">
                  <div id="email-form" name="email-form" data-name="Email Form" method="get" class="form">
                    <div class="w-layout-grid grid-busqueda">
                      <div id="w-node-_909697a1-2c72-b726-7706-4be429d958e3-5cd4b2a9" class="contenedor-buscar buscador-usuarios-ai">
                          <input type="text" class="text-field w-input" maxlength="80" name="name-4" data-name="Name 4" placeholder="" id="name-4" v-model="buscador" @keyup="FiltrarDatos()">
                        <a class="contenedor-icono div-icon w-inline-block"><img src="../images/icono_buscar_acces-o-01.svg" loading="lazy" alt=""></a>
                      </div>
                      <div id="w-node-f2af9157-1699-e64b-da3e-14c291eadec1-5cd4b2a9" class="contenedor-botones carga-descarga cont-btn-agregar">
                        <a href="../Empleados/Empleados.aspx" class="link-block-boton dere url-btn-add w-inline-block"><img src="../images/icono_mas_activeID.svg" loading="lazy" alt=""></a>
                      </div>
                    </div>
                  </div>
                
                </div>
              </div>


              <div class="div-tarjeta div-usuarios-ai tarjeta-responsive">
                <div class="form-block-usuarios w-form">
                  <div id="email-form-4" name="email-form-4" data-name="Email Form 4" method="get" class="form-rol-usuarios-ai">


                    <div class="contenedor-grid tabla-usuarios-ai">
                        <table style="width:100%">
                                <thead>
                                    <tr  class="w-layout-grid grid _4 grid-tabla-ai"
                                        style="grid-template-rows: auto; grid-template-columns: 1fr 1fr 1.5fr 1fr 1fr 1fr 0px;">
                                        <td class="texto-blanco" v-cloak>{{listaIdiomas.Titulo1TablaUsuarios}}</td>
                                        <td class="texto-blanco" v-cloak>{{listaIdiomas.Titulo2TablaUsuarios}}</td>
                                        <td class="texto-blanco" v-cloak>{{listaIdiomas.Titulo3TablaUsuarios}}</td>
                                        <td class="texto-blanco" v-cloak>{{listaIdiomas.Titulo4TablaUsuarios}}</td>
                                        <td class="texto-blanco" v-cloak>{{listaIdiomas.Titulo5TablaUsuarios}}</td>
                                        <td class="texto-blanco" v-cloak>{{listaIdiomas.Titulo6TablaUsuarios}}</td>
                                    </tr>
                                </thead>
                                <tbody  style="display: flex; flex-direction: column" >
                                    <tr v-for="(Usuario,index) in datosPaginados"
                                        :key="index" 
                                        class="w-layout-grid grid _4 grid-tabla-ai" 
                                        style="grid-template-rows: 30px; grid-template-columns: 1fr 1fr 1.5fr 1fr 1fr 1fr 0px;">
                                        
                                        <td class="celda-vacia td-celda-ai" v-cloak>
                                            <div class="p-tabla-user-info"> {{Usuario.Nombre}}</div></td>

                                        <td class="celda-vacia td-celda-ai" v-cloak>
                                            <div class="p-tabla-user-info"> {{Usuario.Apellidos}}</div></td>

                                        <td class="celda-vacia td-celda-ai" v-cloak>
                                            <div class="p-tabla-user-info">{{Usuario.Correo}}</div></td>

                                        <td class="celda-vacia td-celda-ai" v-cloak>
                                            <div class="p-tabla-user-info">{{Usuario.Telefono}}</div></td>

                                        <td class="celda-vacia td-celda-ai" v-cloak>
                                            <div class="p-tabla-user-info">{{Usuario.Posicion}}</div></td>

                                        <td class="celda-vacia td-celda-ai" v-if="Usuario.IdRol == 1">
                                            <div class="p-tabla-user-info">Administrador</div>
                                        </td>

                                        <td class="celda-vacia td-celda-ai" v-else>
                                            <select id="field-4" name="field-4" data-name="Field 4"
                                                class="select-field select-tabla-ai w-select" :value ="Usuario.IdRol" @change="ActualizarRol($event, Usuario)">
                                                <option value="2">Operario</option>
                                                <option value="3">Sin Asignar</option>
                                            </select>
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
                                                      <label for="name-2" class="cant-paginas" v-cloak>{{paginaActual}}</label>
                                                      <label for="name-2" class="cant-paginas" v-cloak>de {{paginas}}</label>
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

              <div class="div-tarjeta cinta-tienda-ai">
                <div class="div-block-170">
                  <div class="text-block-17" v-cloak>{{listaIdiomas.TextoLeyenda}}</div>
                  <a href="../Tienda/Tienda.aspx" class="boton call2action w-button" v-cloak><strong>{{listaIdiomas.BotonIrTienda}}</strong></a>
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
    <script src="js/Usuarios.js?v=1.2.4"></script>

</asp:Content>
