<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/Site.Master" AutoEventWireup="true" CodeBehind="TomaFisica.aspx.cs" Inherits="ActiveSmartWeb.TomaFisica.TomaFisica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="main" id="TomaFisicaVue">
      <div class="section wf-section" id="alertas">
        <div class="container-2 w-container">
          <div class="w-layout-grid grid-main main-mobil">
            <div id="w-node-_1881bb3d-bb04-a65f-0013-ab2c81d3403c-731f63ba" class="div-banner-extremo"></div>
            <div id="w-node-_1881bb3d-bb04-a65f-0013-ab2c81d3403d-731f63ba" class="div-banner-extremo"></div>
            <div id="w-node-_680aac24-239c-4b95-2e31-486e071a336c-731f63ba" class="div-block-223">
              <div class="w-layout-grid grid-container-title" style="padding-top:10px; padding-bottom:10px">
                <a href="#" onclick="window.history.back()" class="link-block-back w-inline-block"><img src="../images/Back-arrow.svg" loading="lazy" height="26" width="26" alt="" class="back"></a>
                <h1 id="w-node-_680aac24-239c-4b95-2e31-486e071a3370-731f63ba" class="titulo-principal-2" v-cloak>{{listaIdiomaToma.Titulo}}</h1> 
                <div data-hover="false" data-delay="0" id="w-node-_01c345db-44dd-5950-8797-fc0e77f5b71f-731f63ba" class="dropdown-detalles-ai w-dropdown">
                  <div class="toggle-detalles-ai w-dropdown-toggle" style="padding:0px"><img src="../images/info2.svg" loading="lazy" alt="" class="img-detalles-ai"></div>
                  <nav class="detalles-descrp-ai w-dropdown-list">
                    <p class="p-desc-detalles-ai" v-cloak>{{listaIdiomaToma.Info}}<strong><br>{{listaIdiomaToma.TFinfo}}</strong></p> 
                  </nav>
                </div>
              </div>
            </div>
              <div id="w-node-_1881bb3d-bb04-a65f-0013-ab2c81d34099-731f63ba" class="div-tarjeta tarjeta-responsive tarjeta-top">
              <div class="form-block w-form">
                  <div class="w-layout-grid grid-busqueda">
                    <div id="w-node-df034803-1e3e-ca71-07ba-195924f41dce-731f63ba" class="form-line">
                        <label for="name-2" class="field-label" v-cloak>{{listaIdiomaToma.Desde}}</label>
                        <div class="div-fecha">
                          <input type="date" v-on:keyup.enter="ObtenerDatos()" v-model="fechaInicio" class="text-field w-input" maxlength="80" name="FECHA-3" data-name="FECHA 3" id="desde">
                        <a href="#" class="contenedor-icono w-inline-block">
                            <img src="../images/calendar.svg" loading="lazy" v-on:click="AbrirDatePicker('desde')" alt="">
                        </a>
                      </div>
                    </div>
                    <div id="w-node-df034803-1e3e-ca71-07ba-195924f41dd5-731f63ba" class="form-line">
                        <label for="name-2" class="field-label" v-cloak>{{listaIdiomaToma.Hasta}}</label>
                        <div class="div-fecha">
                          <input type="date" v-on:keyup.enter="ObtenerDatos()"  v-model="fechaFinal" class="text-field w-input" maxlength="80" name="FECHA-3" data-name="FECHA 3" id="hasta">
                        <a href="#" class="contenedor-icono w-inline-block">
                            <img src="../images/calendar.svg" loading="lazy" v-on:click="AbrirDatePicker('hasta')" alt="">
                        </a>
                      </div>
                    </div>
                      <a id="w-node-df034803-1e3e-ca71-07ba-195924f41ddc-731f63ba" href="#" class="contenedor-icono icon-search-ai w-inline-block" v-on:click="ObtenerDatos()">
                        <img src="../../images/icono_buscar_acces-o-01.svg" loading="lazy" alt="">
                    </a>
                    <div id="w-node-df034803-1e3e-ca71-07ba-195924f41dde-731f63ba" class="contenedor-botones carga-descarga"></div>
                      <a id="w-node-df034803-1e3e-ca71-07ba-195924f41ddf-731f63ba" href="TomaFisicaEncabezado.aspx" class="link-block-boton dere w-inline-block">
                          <img src="../images/icono_mas_activeID.svg" loading="lazy" alt="">
                      </a>
                      <a id="w-node-df034803-1e3e-ca71-07ba-195924f41de1-731f63ba" href="#" class="link-block-boton bell-link w-inline-block">
                          <img src="../images/notificacion.svg" loading="lazy" width="75" alt="">
                      </a>
                  </div>
              </div>
            </div>
            <div id="w-node-_1881bb3d-bb04-a65f-0013-ab2c81d34079-731f63ba" class="div-tarjeta tarjeta-responsive">
             <div id="w-node-_1881bb3d-bb04-a65f-0013-ab2c81d34079-731f63ba" class="div-tarjeta">
                  <div class="contenedor-grid">
                <table style="width:100%">
                    <thead >
                        <tr v-cloak class="w-layout-grid grid _4 grid-tabla-ai grid-toma-f-sica" style="grid-template-rows: auto;grid-template-columns: 15% 21.5% 10% 10% 10% 7% 15% 5% 5%;">
                            <th class="texto-blanco">{{listaIdiomaToma.NombreTomaF}}</th> 
                        
                            <th class="texto-blanco">{{listaIdiomaToma.DescripcionTomaF}}</th> 
                        
                            <th class="texto-blanco" >{{listaIdiomaToma.FechaInicial}}</th> 
                        
                            <th class="texto-blanco">{{listaIdiomaToma.FechaFinal}}</th> 
                       
                            <th class="texto-blanco">{{listaIdiomaToma.Categoria}}</th> 
                      
                            <th class="texto-blanco">{{listaIdiomaToma.Activos}}</th> 
                        
                            <th class="texto-blanco">{{listaIdiomaToma.Ubicacion}}</th> 
                        
                            <th class="texto-blanco"></th>
                        
                            <th class="texto-blanco"></th>
                        </tr>
                    </thead>
                    <tbody  style="display: flex; flex-direction: column" >

                        <tr v-for="(tomaFisica, index) in datosPaginados" :key="tomaFisica.IdTomaFisica" 
                            class="w-layout-grid grid _4  grid-tabla-ai grid-toma-f-sica" style="grid-template-rows: 30px;grid-template-columns: 15% 21.5% 10% 10% 10% 7% 15% 5% 5%;">

                            <td v-cloak id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid">
                                     {{tomaFisica.Nombre}}
                                </div>
                            </td>
                        
                            <td v-cloak id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid">
                                     {{tomaFisica.Descripcion}}
                                </div>
                            </td>
                         
                            <td v-cloak id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid">
                                     {{FormatearFecha(tomaFisica.FechaInicial)}}
                                </div>
                            </td>
                        
                            <td v-cloak id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid">
                                     {{FormatearFecha(tomaFisica.FechaFinal)}}
                                </div>
                            </td>

                            <td v-cloak id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid">
                                     {{tomaFisica.NombreCategoria}}
                                </div>
                            </td>
                       
                        
                            <td v-cloak id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid">
                                     {{tomaFisica.CantidadActivos}}
                                </div>
                            </td>
                        
                            <td v-cloak id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid">
                                     {{tomaFisica.Ubicacion}}
                                </div>
                            </td>

                            <td v-cloak id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid link-block-2 amarillo w-inline-block">
                                    <a href="#" class="link-block-2 amarillo w-inline-block" v-on:click="EditarToma(tomaFisica.IdTomaFisica)"><img src="../images/editar.svg" 
                                    loading="lazy" width="20" height="20" alt="" class="image-29"></a>
                                </div>
                            </td>
                        
                             <td v-cloak id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid link-block-2 amarillo w-inline-block">
                                    <a href="#" class="link-block-2 amarillo w-inline-block"  v-on:click="ObtenerActivosTomaFisica(tomaFisica.IdTomaFisica, tomaFisica.Categoria, tomaFisica.IdUbicacion)"><img src="../images/ver.svg" 
                                    loading="lazy" width="20" height="20" alt="" class="image-29"></a>
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
                                            <label for="name-2" class="cant-paginas" v-cloak>{{paginaActual}}</label>
                                            <label for="name-2" class="cant-paginas" v-cloak>de {{paginas}}</label>
                                            <img v-on:click="PaginaSiguiente()" src="../images/angulos-de-flechas-dobles-a-la-derecha.png" loading="lazy" width="15" height="15" alt="" class="image-9">
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
            <div id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f84-731f63ba" class="div-tarjeta tarjeta-responsive">
              <div class="w-form">
                <div id="email-form-4" name="email-form-4" data-name="Email Form 4" method="get">
                    <select v-cloak v-model="selectActivos" v-on:change="ObtenerActivosTomaFisica()" id="field-4" name="field-4" data-name="Field 4" class="select-field select-filtro-ai w-select">
                   <option value="1">{{listaIdiomaToma.Todos}}</option>
                    <option value="2">{{listaIdiomaToma.Encontrados}}</option> 
                    <option value="3">{{listaIdiomaToma.NoEncontrados}}</option> 
                  </select></div>
              </div>
              <div class="contenedor-grid">
                 <table style="width:100%">
                     <thead>
                         <tr v-cloak class="w-layout-grid grid _4 tabla-toma-fisica-2" style="grid-template-rows: auto; grid-template-columns: 25% 24% 15% 15% 15% 5%;">
                             <th class="texto-blanco _3">{{listaIdiomaToma.NumActivo}}</th> 
                             <th class="texto-blanco _3">{{listaIdiomaToma.PlacaActivo}}</th> 
                             <th class="texto-blanco _3">{{listaIdiomaToma.DescripActivo}}</th> 
                             <th class="texto-blanco _3">{{listaIdiomaToma.Estado}}</th> 
                             <th class="texto-blanco _3">{{listaIdiomaToma.ObservActivo}}</th> 
                             <th class="texto-blanco _3"></th>
                         </tr>
                     </thead>
                    <tbody>
                        <tr v-cloak v-for="(activoTomaFisica, index) in datosPaginadosActivos" :key="activoTomaFisica.idActivo" 
                            class="w-layout-grid grid _4 tabla-toma-fisica-2" style="grid-template-rows: auto; grid-template-columns: 25% 24% 15% 15% 15% 5%;" >

                            <td id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid">
                                     {{activoTomaFisica.NumeroActivo}}
                                </div>
                            </td>

                            <td id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid">
                                     {{activoTomaFisica.PlacaActivo}}
                                </div>
                            </td>

                            <td id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid">
                                     {{activoTomaFisica.DescripcionActivo}}
                                </div>
                            </td>

                            <td id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid">
                                     <p v-if="activoTomaFisica.Estado==1">
                                         <a href="#" class="link-block-2 amarillo w-inline-block">
                                             <img src="../images/check-dark.svg" loading="lazy" width="20" height="20" alt="" class="image-29">
                                         </a>
                                     </p>
                                     <p v-else>
                                         <a href="#" class="link-block-2 amarillo w-inline-block">
                                             <img src="../images/x-dark.svg" loading="lazy" width="20" height="20" alt="" class="image-29">
                                         </a>
                                     </p>
                                </div>
                            </td>

                            <td id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid">
                                       <p v-if="activoTomaFisica.ObservacionActivo==ValDescripcion">
                                         {{listaIdiomaToma.Vobserv}} 
                                     </p>
                                     <p v-else>
                                        {{activoTomaFisica.ObservacionActivo}}
                                     </p>
                                </div>
                            </td>
                            <td id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid">
                                     <p v-if="activoTomaFisica.Estado==1">
                                        <a href="#" v-on:click="AbrirPopPup(activoTomaFisica.IdActivo, activoTomaFisica.ObservacionActivo)"  
                                        class="link-block-2 amarillo w-inline-block" >
                                        <img src="../images/aceptar-gris.svg" 
                                    loading="lazy" width="20" height="20" alt="" class="image-29" ></a>
                                     </p>
                                     <p v-else>
                                        <a href="#" v-on:click="AbrirPopPup(activoTomaFisica.IdActivo, activoTomaFisica.ObservacionActivo)"  
                                        class="link-block-2 amarillo w-inline-block">
                                        <img src="../images/aceptar-gris.svg" 
                                    loading="lazy" width="20" height="20" alt="" class="image-29"></a>
                                     </p>
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
                                             <img v-on:click="PaginaAnteriorActivos()" src="../images/simbolo-de-doble-flecha-izquierda-hacia-atras-rapido.png"
                                                 loading="lazy" width="15" height="15" alt="" class="image-9">
                                             <label for="name-2" class="cant-paginas" v-cloak>{{paginaActualActivos}}</label>
                                             <label for="name-2" class="cant-paginas" v-cloak>de {{paginasActivos}}</label>
                                             <img v-on:click="PaginaSiguienteActivos()" src="../images/angulos-de-flechas-dobles-a-la-derecha.png" loading="lazy" width="15" height="15" alt="" class="image-9">
                                         </div>
                                     </div>
                                 </div>
                             </td>
                         </tr>
                     </tfoot>
                </table>
              </div>
            </div>
            <div id="w-node-c8689383-f869-af00-8fed-b75b3bbc331a-731f63ba" class="div-tarjeta div-cinta">
              <div class="div-block-170">
                <div class="text-block-17" v-cloak>{{listaIdiomaToma.MsjTienda}}</div> 
                <a href="*" class="boton call2action w-button" v-cloak>{{listaIdiomaToma.MsjbtnTienda}}<strong></strong></a>
              </div>
            </div>
          </div>
        </div>
      </div>
        <div class="background-pop-up" id="PObservaciones" style="display:none; text-align:center">
            
      <div class="popup-comercial"  style="display:flex; place-content:center;">
        <div class="header-modal-ai">
          <h4 class="texto-h-ai" v-cloak> {{listaIdiomaToma.Tituloobserv}}</h4> 
          <div class="div-icon-exit-ai">
            <a href="#">
                <img src="../images/icono_eliminar_acces-o-01" loading="lazy" alt="" class="img-salir-ai" v-on:click="CerrarPopPup()">
                 </a>
          </div>
        </div>
        <div class="form-block-pp w-form" >
          <div id="email-form-6" name="email-form-6" data-name="Email Form 6" method="get"  >
            <label for="texbox" class="label-form-pp" v-cloak> {{listaIdiomaToma.SubTituloobserv}} </label>  
            <textarea v-model="NuevaObservacion" placeholder="Por favor escriba una observación"
            maxlength="5000" id="textbox" name="textbox" 
            required="" data-name="field" 
            class="texbox-observaciones-pp w-input">
          </textarea> <!-- [[listaIdiomaToma.MsjObserv]] -->
          </div>
        </div>
        <div class="div-botones-pp">
          <a href="#" v-on:click="EditarPopUp()" class="btn-aceptar-pp w-button" v-cloak>{{listaIdiomaToma.Btnobserv}}</a> 
        </div>
      </div>
    </div>
    </div>
    <style>
        /*ocultar controles de input date*/
        input[type="date"]::-webkit-inner-spin-button,
        ::-webkit-calendar-picker-indicator {
            display: none;
        }
    </style>
    <script src="../Recursos/JQuery/jquery-3.5.1.min.dc5e7f18c8.js"></script>
    <script src="../js/webflow.js"></script>
    <script src="js/TomaFisica.js"></script>
    <script src="../js/Table.js"></script>
</asp:Content>
