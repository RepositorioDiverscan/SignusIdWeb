<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/Site.Master"
    AutoEventWireup="true" CodeBehind="PerfilEmpresa.aspx.cs" 
    Inherits="ActiveSmartWeb.PerfilEmpresa.PerfilEmpresa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="main-ai" id="PerfilEmpresaVUE" >
      <div class="section-ai wf-section" id="alertas">
        <div class="warpper-form-ai">
          <h3 class="txt-perf-title-ai">Perfil de la empresa</h3>
          <div class="w-layout-grid grid-block-perfil-ai">
            <div id="w-node-de62ed00-d6d7-fe7b-4823-87cb91e1d104-23d805d4" class="div-banner-left-ai"></div>
            <div id="w-node-_67a3bd70-026a-7b1d-000b-138fd4cba48b-23d805d4" class="block-pers-info-ai">
                <!--Informa -->
                <div class="w-layout-grid grid-container-title" style="padding-top:10px; padding-bottom:10px">
                <a href="#" onclick="window.history.back()" class="link-block-back w-inline-block"><img src="../images/Back-arrow.svg" loading="lazy" height="26" width="26" alt="" class="back"></a>
                <h1 id="w-node-_9be28721-5dbb-5f12-6325-d0dcd6cba1e6-ffdc8228" class="titulo-principal" v-cloak>{{listaIdiomas.Titulo}}</h1>
                  <div data-hover="false" data-delay="0" id="w-node-_01c345db-44dd-5950-8797-fc0e77f5b71f-731f63ba" class="dropdown-detalles-ai w-dropdown">
                  <div class="toggle-detalles-ai w-dropdown-toggle" style="padding:0px"><img src="../images/info2.svg" loading="lazy" alt="" class="img-detalles-ai"></div>
                  <nav class="detalles-descrp-ai w-dropdown-list">
                    <p class="p-desc-detalles-ai" v-cloak>{{listaIdiomas.MsjInfo1}}<strong><br>{{listaIdiomas.MsjInfo2}}</strong></p>
                  </nav>
                </div>
              </div>
                <!-- -->
              <div class="w-layout-grid grid-info-form-ai">
                <div id="w-node-a88bae60-6eb1-acad-3153-92a1bf2ea257-23d805d4" class="block-public-info-ai">
                  <div id="w-node-_412352ef-52dd-965f-34f2-6c8cf7ff1828-23d805d4" class="block-info-user-ai div-block-info-left-ai">
                    <div class="div-img-prof-left-ai"><img v-bind:src="[[Imagen]]" loading="lazy" alt="" class="img-prof-left-ai"></div>
                    <h4 class="txt-user-ai" v-cloak>{{listaIdiomas.Bienvenida}} {{Nombre}}</h4>
                    <p class="txt-email-info-ai" v-cloak><span class="text-span">{{listaIdiomas.Email}}: </span>{{Correo}}</p>
                    <p class="p-tiype-user-title-ai" v-cloak>{{listaIdiomas.TipoUsuario}}:</p>
                    <p class="paragraph-4" v-cloak><strong class="p-user-type-ai">{{rol}}</strong></p>
                    <p class="paragraph-5" v-cloak><strong class="bold-text-2">{{listaIdiomas.NumCuenta}}:<br></strong><span>‍</span> <span class="text-span-8">{{IdPerfilUsuario}}</span></p> 
                  </div>
                  <div id="w-node-_5415cd3d-dda3-0487-a350-0659f74a096a-23d805d4" class="block-tasks-user-ai">
                    <h4 class="text-sec-title-perf-ai" v-cloak>{{listaIdiomas.Permisos}}</h4>
                    <a href="../Perfil/PerfilUsuario.aspx"  class="btn-permisos-user-ai w-button" v-cloak>{{listaIdiomas.AdministrarPerfil}}</a>
                    <a href="../Usuarios/Usuarios.aspx"  class="btn-permisos-user-ai w-button" v-cloak>{{listaIdiomas.AdministrarUser}}</a>
                    <div class="div-notf-ai">
                      <%--<div id="notif" class="div-circle-notf-ai" style="display:none">
                        <p class="p-notf-ai">{{TotalNotificacionesEmp}}</p>
                      </div>--%>
                      <a href="../NotificacionesPerfil/Notificaciones.aspx" class="btn-permisos-user-ai w-button" v-cloak>{{listaIdiomas.Notificaciones}}</a>
                    </div>
                  </div>
                  <div id="w-node-b7a56998-669c-0561-db3b-db961f4cd51b-23d805d4" class="block-other-options-ai">
                    <h4 class="heading-3" v-cloak>{{listaIdiomas.Opciones}}</h4> 
                    <a href="../MisCompras/MisCompras.aspx" class="btn-options-perf-ai w-button" v-cloak>{{listaIdiomas.MisCompras}}</a>
                    <a href="../Incidentes/Incidente.aspx" class="btn-options-perf-ai w-button" v-cloak>{{listaIdiomas.Incidentes}}</a>
                    <a href="#" class="btn-options-perf-ai blocked w-button" v-cloak>{{listaIdiomas.MetodosPago}}</a>
                    <a href="#" class="btn-options-perf-ai blocked w-button" v-cloak>{{listaIdiomas.Seguridad}}</a>
                  </div>
                </div>
                <div id="w-node-_1a2028bf-d58c-f222-2b8b-6fbc4a704b7f-23d805d4" class="div-cont-emp-ai">
                  <div class="block-perf-emp-perfil w-clearfix">
                    <h4 class="txt-emp-name-ai" v-cloak>{{NombreEmpresaTitulo}}</h4>
                    <div class="img-config-ai">
                      <div class="block-add-emp-img-ai"><img v-bind:src="[[ImagenEmpresa]]" alt="" class="added-img-ai"></div>
                     <div class="div-load-img-ai">
                          <label class="text-edit-photo-ai" v-cloak>
                           {{listaIdiomas.EditarImagen}}   
                          <input  style="display: none;" id="files" type="file" @change="handleFileSelect" v-model="SelectorImagen" />
                          </label>
                      </div>
                    </div>
                    <div class="form-block-perf-emp-ai w-form">
                      <div id="email-form" name="email-form" data-name="Email Form" method="get" class="form-perf-emp-ai w-clearfix">
                          <label for="name" class="txt-lbl-n">
                              <span class="txt-labl-info-emp-ai" v-cloak>{{listaIdiomas.Nombre}}</span>

                          </label>
                          <input type="text" class="txt-name-perf-emp-ai w-input" autofocus="true" maxlength="80" v-model="NombreEmpresa" name="name" data-name="Name" placeholder="" id="name" required="">
                          <label for="name-2" class="txt-lbl-n">
                              <span class="txt-labl-info-emp-ai" v-cloak>{{listaIdiomas.IdEmpresa}}</span>

                          </label><input type="text" class="txt-id-emp-ai w-input" autofocus="true" maxlength="80" v-model="IdEmpresa" name="name-2" data-name="Name 2" placeholder="" id="name-2" required="">
                          <label for="name-2" class="txt-lbl-n"><span class="txt-labl-info-emp-ai" v-cloak>{{listaIdiomas.ContactoPrincipal}}</span></label>
                          <input type="text" class="txt-contacto-emp-ai w-input" autofocus="true" maxlength="80" v-model="ContactoPrincipal" name="name-2" data-name="Name 2" placeholder="" id="name-2" required="">
                          <label for="email" class="txt-lbl-n"><span class="txt-labl-info-emp-ai" v-cloak>{{listaIdiomas.CorreoEmpresa}}</span>

                          </label><input type="email" class="txt-email-emp-ai w-input" autofocus="true" maxlength="80" v-model="CorreoTxt" name="email" data-name="email" placeholder="" id="email" required=""><label for="field-2" class="txt-lbl-n">
                              <span class="txt-labl-info-emp-ai" v-cloak>{{listaIdiomas.Pais}}</span></label>
                          <div>
                              <input type="text" id="country1" autofocus="true" maxlength="80" name="email-2" data-name="Email 2"
                                  class="txt-registro-aii w-input"/> 
                        </div>
                          <label for="field-2" class="txt-lbl-n"><span class="txt-labl-info-emp-ai" v-cloak>{{listaIdiomas.Direccion}}</span>

                                 </label><textarea :placeholder="[[listaIdiomas.PlaceHDireccion]]" maxlength="200" id="field" name="field" required="" v-model="Direccion" autofocus="true" data-name="field" class="txt-direccion-emp-ai w-input" style="resize: none !important"></textarea>
                          <label for="name-2" class="txt-lbl-n"><span class="txt-labl-info-emp-ai" v-cloak>{{listaIdiomas.Telefono}}</span>

                          </label>
                          <input v-on:keypress="ValidarSoloNumeros()" id="telNational" type="tel" name="telNational" maxlength="80"
                                class="txt-tel-emp-ai w-input" data-name="Name 2">

                          <label for="field-5" class="txt-lbl-n"><span class="txt-labl-info-emp-ai" v-cloak>{{listaIdiomas.Industria}}</span></label>
                          <select v-cloak id="field-3" name="field-3" data-name="Field 3" v-model="selectIndustria" class="select-industria-ai w-select">
                          <option value="0">{{listaIdiomas.SelectIndustria}}</option>         
                            <option v-for="industria in ListaIndustrias" :key="industria.IdIndustria" :value="industria.IdIndustria"  >{{industria.Nombre}}</option >                                           
                        </select>

                          <label for="field-5" class="txt-lbl-n"><span class="txt-labl-info-emp-ai" v-cloak>{{listaIdiomas.Moneda}}</span></label>
                          <select v-cloak v-cloak id="field-3" name="field-3" data-name="Field 3" v-model="monedaSel" class="select-industria-ai w-select">  
                              <option value="a">{{listaIdiomas.SelMoneda}}</option>  
                            <option v-for="moneda in monedas" :key="moneda.Codigo" :value="moneda.Codigo">{{moneda.Codigo}}</option>
                        </select>

                      </div>
                    
                    </div>
                       <div class="div-save-info-perf-ai">
                        <a href="#"  v-on:click="ModificarPerfilEmpresa">
                          <img src="../images/save_blanco.svg" loading="lazy" alt="" class="icon-save-info-perf-ai">
                        </a>
                       </div>
                    </div>
                  <div id="div-block-plan-AI" class="div-blck-plan-ai">
                    <h6 class="plan-type-pe-ai">Plan:</h6><img src="../images/Icono_ActiveID_Smart-Basic.svg" loading="lazy" width="108" alt="Imagen de Icono Active-ID-Smart_basico" class="img-plan-perf-emp-ai">
                      <a href="../Tienda/Tienda.aspx" class="p-update-plan-pe-ai btn-options-perf-ai" style="text-decoration: none;" v-cloak>{{listaIdiomas.Actualiza}}<strong></strong></a>
                  </div>

                </div>
              </div>
              <div class="div-tarjeta cinta-tienda-ai cinta-perfil">
                <div class="div-block-170">
                  <div class="text-block-17" v-cloak>{{listaIdiomas.Tienda}}</div>
                  <a href="*" class="boton call2action w-button" v-cloak>{{listaIdiomas.MsjTienda}}<strong></strong></a>
                </div>
              </div>
            </div>
            <div id="w-node-_33fccb2a-3bf8-a960-9a30-b295a4ebbe75-23d805d4" class="div-banner-right-ai">
              <div class="w-embed"></div>
            </div>
          </div>
        </div>
      </div>
    </div>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>   
    <script src="https://cdnjs.cloudflare.com/ajax/libs/country-select-js/2.1.1/js/countrySelect.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/17.0.18/js/intlTelInput.min.js"></script>
     <%--<script src="../Recursos/JQuery/jquery-3.5.1.min.dc5e7f18c8.js"></script>--%>
    <link href="../css/signusid.webflow.css" rel="stylesheet" />

   <script src="js/JsPerfilEmpresa.js"></script>

</asp:Content>
