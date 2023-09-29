<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/Site.Master" AutoEventWireup="true" CodeBehind="ReporteInventario.aspx.cs" Inherits="ActiveSmartWeb.InventariosReporte.ReporteInventario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="main otrodiv"id="ReporteInventariosVue">
       <div class="section otrodiv" id="alertas" >
        <div class="container-2 divotro w-container">
         <div class="w-layout-grid grid-main grid-main-gestion">
            <div id="w-node-_28f83586-84e1-3ab8-9a07-61041cff8530-b415ea5e" class="div-banner-extremo"></div>
            <div id="w-node-_28f83586-84e1-3ab8-9a07-61041cff8531-b415ea5e" class="div-banner-extremo"></div>
            <div id="w-node-_28f83586-84e1-3ab8-9a07-61041cff8532-b415ea5e">
                <div class="w-layout-grid grid-container-title" style="padding-top:7px; padding-bottom:6px">
               <a href="#" onclick="window.history.back()" id="w-node-_28f83586-84e1-3ab8-9a07-61041cff8534-b415ea5e" class="link-block-back-3 w-inline-block"><img src="../images/Back-arrow.svg" loading="lazy" height="26" width="96" alt="" class="back"></a>
                <h1 id="w-node-_28f83586-84e1-3ab8-9a07-61041cff8536-b415ea5e" class="titulo-principal" v-cloak>{{listaIdiomaToma.Titulo}}</h1> 
                  <div data-hover="false" data-delay="0" id="w-node-_01c345db-44dd-5950-8797-fc0e77f5b71f-731f63ba" class="dropdown-detalles-ai w-dropdown">
                  <div class="toggle-detalles-ai w-dropdown-toggle" style="padding:0px"><img src="../images/info2.svg" loading="lazy" alt="" class="img-detalles-ai"></div>
                  <nav class="detalles-descrp-ai w-dropdown-list">
                    <p class="p-desc-detalles-ai" v-cloak>{{listaIdiomaToma.Info}}</p>  
                    <p class="p-desc-detalles-ai" v-cloak>{{listaIdiomaToma.Subinfo}} <strong>{{listaIdiomaToma.TFinfo}}</strong></p>  
                  </nav>
                </div>
              </div>
            </div>

            
              <div id="w-node-_1881bb3d-bb04-a65f-0013-ab2c81d34099-731f63ba" class="div-tarjeta tarjeta-responsive tarjeta-top">
                  <div class="form-block w-form">
                      <div class="w-layout-grid grid-busqueda">
                          <div id="w-node-df034803-1e3e-ca71-07ba-195924f41dce-731f63ba" class="form-line">
                              <label for="name-5" class="field-label" v-cloak>{{listaIdiomaToma.Desde}}</label> 
                              <div class="div-fecha">
                                  <input v-on:keyup.enter="ObtenerDatos()" type="date"  v-model="fechaInicio" class="text-field w-input" maxlength="80" name="FECHA-3" data-name="FECHA 3" id="fechaI" :max="fechaHoy" @mouseout="ValidarFechaInicial()">
                                  <a href="#" class="contenedor-icono w-inline-block">
                                      <img v-on:click="AbrirDatePicker('fechaI')" src="../images/calendar.svg" loading="lazy" alt="">
                                  </a>
                              </div>
                          </div>
                          <div id="w-node-df034803-1e3e-ca71-07ba-195924f41dd5-731f63ba" class="form-line">
                              <label for="name-5" class="field-label" v-cloak>{{listaIdiomaToma.Hasta}}</label>
                              <div class="div-fecha">
                                  <input v-on:keyup.enter="ObtenerDatos()" type="date" v-model="fechaFinal" class="text-field w-input" maxlength="80" name="FECHA-3" data-name="FECHA 3" id="fechaF" :max="fechaHoy" @mouseout="ValidarFechaFinal()">
                                  <a href="#" class="contenedor-icono w-inline-block">
                                      <img v-on:click="AbrirDatePicker('fechaF')" src="../images/calendar.svg" loading="lazy" alt="">
                                  </a>
                              </div>
                          </div>
                          <a id="w-node-df034803-1e3e-ca71-07ba-195924f41ddc-731f63ba" href="#" class="contenedor-icono icon-search-ai w-inline-block" v-on:click="ObtenerDatos()">
                                  <img src="../../images/icono_buscar_acces-o-01.svg" loading="lazy" alt="">
                          </a>
                      </div>
                  </div>
              </div>

            <div id="w-node-_1881bb3d-bb04-a65f-0013-ab2c81d34079-731f63ba" class="div-tarjeta tarjeta-responsive">
               <div class="contenedor-grid">
                <table style="width:100%">
                    <thead >
                        <tr v-cloak class="w-layout-grid grid _4 grid-tabla-ai grid-toma-f-sica" style="grid-template-rows: auto;grid-template-columns: 15% 21.5% 10% 11% 11% 10% 15% 5%;">
                            <th class="texto-blanco">{{listaIdiomaToma.NombreTomaF}}</th>
                        
                            <th class="texto-blanco">{{listaIdiomaToma.DescripcionTomaF}}</th>
                        
                            <th class="texto-blanco">{{listaIdiomaToma.FechaInicial}}</th>
                        
                            <th class="texto-blanco">{{listaIdiomaToma.FechaFinal}}</th>
                       
                            <th class="texto-blanco">{{listaIdiomaToma.Categoria}}</th>
                      
                            <th class="texto-blanco">{{listaIdiomaToma.Activos}}</th>
                        
                            <th class="texto-blanco">{{listaIdiomaToma.Ubicacion}}</th>
                       
                            <th class="texto-blanco"></th>
                        </tr>
                    </thead>
                    <tbody  style="display: flex; flex-direction: column" >

                        <tr v-cloak v-for="(tomaFisica, index) in datosPaginados" :key="tomaFisica.IdTomaFisica" 
                            class="w-layout-grid grid _4  grid-tabla-ai grid-toma-f-sica" style="grid-template-rows: 30px;grid-template-columns: 15% 21.5% 10% 11% 11% 10% 15% 5%;">

                            <td id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid">
                                     {{tomaFisica.Nombre}}
                                </div>
                            </td>
                        
                            <td id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid">
                                     {{tomaFisica.Descripcion}}
                                </div>
                            </td>
                         
                            <td id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid">
                                     {{FormatearFecha(tomaFisica.FechaInicial)}}
                                </div>
                            </td>
                        
                            <td id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid">
                                     {{FormatearFecha(tomaFisica.FechaFinal)}}
                                </div>
                            </td>

                            <td id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid">
                                     {{tomaFisica.NombreCategoria}}
                                </div>
                            </td>
                       
                        
                            <td id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid">
                                     {{tomaFisica.CantidadActivos}}
                                </div>
                            </td>
                        
                            <td id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid">
                                     {{tomaFisica.Ubicacion}}
                                </div>
                            </td>

                             <td id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f9f-731f63ba" class="celda-toma-f-sica celda-vacia">
                                <div class="parrafo-grid link-block-2 amarillo w-inline-block">
                                    <a href="#"  v-on:click="ObtenerActivosTomaFisica(tomaFisica.IdTomaFisica, tomaFisica.Categoria, tomaFisica.IdUbicacion)"><img src="../images/ver.svg" 
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
            <div id="w-node-_82b11ea7-fc60-c7b7-548e-895286726f84-731f63ba" class="div-tarjeta tarjeta-responsive">
              <div class="contenedor-grid">
                 <table style="width:100%">
                     <thead>
                         <tr v-cloak class="w-layout-grid grid _4 tabla-toma-fisica-2" style="grid-template-rows: auto; grid-template-columns: 25% 24% 15% 20% 15%;">
                             <th class="texto-blanco _3">{{listaIdiomaToma.NumActivo}}</th>
                             <th class="texto-blanco _3">{{listaIdiomaToma.PlacaActivo}}</th>
                             <th class="texto-blanco _3">{{listaIdiomaToma.DescripActivo}}</th>
                             <th class="texto-blanco _3">{{listaIdiomaToma.ObservActivo}}</th>
                             <th class="texto-blanco _3">{{listaIdiomaToma.Estado}}</th>
                             

                         </tr>
                     </thead>
                    <tbody>
                        <tr v-cloak v-for="(activoTomaFisica, index) in datosPaginadosActivos" :key="activoTomaFisica.idActivo" 
                            class="w-layout-grid grid _4 tabla-toma-fisica-2" style="grid-template-rows: auto; grid-template-columns: 25% 24% 15% 20% 15% ;" >

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
                                             Encontrado
                                        
                                     </p>
                                     <p v-else>
                                         Faltante

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
              <div class="contenedor-grid">
                 <table style="width:100%" hidden="true" id="TablaActivos">
                     <thead>
                         <tr v-cloak class="w-layout-grid grid _4 tabla-toma-fisica-2" style="grid-template-rows: auto; grid-template-columns: 25% 24% 15% 20% 15%;">
                             <th class="texto-blanco _3">{{listaIdiomaToma.NumActivo}}</th>
                             <th class="texto-blanco _3">{{listaIdiomaToma.PlacaActivo}}</th>
                             <th class="texto-blanco _3">{{listaIdiomaToma.DescripActivo}}</th>
                             <th class="texto-blanco _3">{{listaIdiomaToma.ObservActivo}}</th>
                             <th class="texto-blanco _3">{{listaIdiomaToma.Estado}}</th>
                             

                         </tr>
                     </thead>
                    <tbody>
                        <tr v-cloak v-for="(activoTomaFisica, index) in listaActivos" :key="activoTomaFisica.idActivo" 
                            class="w-layout-grid grid _4 tabla-toma-fisica-2" style="grid-template-rows: auto; grid-template-columns: 25% 24% 15% 20% 15% ;" >

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
                                             Encontrado
                                        
                                     </p>
                                     <p v-else>
                                         Faltante

                                     </p>
                                </div>
                            </td>
                        </tr>
                    </tbody>
                </table>
              </div>
                              <div class="pagination-content w-clearfix">
                <div class="contenedor-botones cont-btns-left">
                  <a href="#" v-on:click="ExportarExcel()" class="boton gris w-button">EXCEL</a>
                  <a href="#" v-on:click="GenerarReportePDF()" class="boton gris w-button">PDF</a>
                </div>
              </div>
            </div>
            <div id="w-node-c8689383-f869-af00-8fed-b75b3bbc331a-731f63ba" class="div-tarjeta div-cinta">
              <div class="div-block-170">
                <div class="text-block-17" v-cloak>{{listaIdiomaToma.MsjTienda}}</div>
                <a href="../Tienda/Tienda.aspx" class="boton call2action w-button" v-cloak>{{listaIdiomaToma.MsjbtnTienda}}<strong></strong></a>
              </div>
            </div>
        
          </div>
        </div>
      </div>
    </div>
    <style>
         /*ocultar controles de input date*/  
     input[type="date"]::-webkit-inner-spin-button,
                  ::-webkit-calendar-picker-indicator{
        display: none;
    }

    </style>
     <script src="../Recursos/JQuery/jquery-3.5.1.min.dc5e7f18c8.js"></script>
    <script src="../js/webflow.js"></script>
    <script src="js/ReporteInventarios.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jspdf/1.5.3/jspdf.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jspdf-autotable/3.2.3/jspdf.plugin.autotable.min.js"></script>
</asp:Content>
