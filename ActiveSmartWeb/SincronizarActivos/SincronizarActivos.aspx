<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/Site.Master" AutoEventWireup="true" CodeBehind="SincronizarActivos.aspx.cs" Inherits="ActiveSmartWeb.SincronizarActivos.SincronizarActivos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<style>
  .loading-spinner {
  display: none; /* Oculta inicialmente el div de carga */
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background-color: rgba(255, 255, 255, 0.8); /* Fondo semi-transparente */
  z-index: 9999; /* Coloca el div por encima de todo */
  text-align: center;
}

.loading-spinner img {
  margin-top: 20%; /* Alinea verticalmente el GIF de carga */
}
</style>

      
      

<div class="main">

    <div id="context" class="section">

      <div class="section wf-section" id="alertas">
        <div class="container-2 w-container">
            <div id="loading-spinner" class="loading-spinner" >
           <img src="../images/gif de carga2.gif" loading="lazy" class="back"style ="width: 25%; height: 44%;margin-left: 36%;margin-top: 14%;">


            </div>
          <div class="w-layout-grid grid-main grid-sinc-act">
            <div id="w-node-_28f3db33-b16a-6f10-aeaa-110c3af3f04f-fb048ddf" class="div-banner-extremo"></div>
            <div id="w-node-_28f3db33-b16a-6f10-aeaa-110c3af3f050-fb048ddf" class="div-banner-extremo"></div>
            <div id="w-node-_28f3db33-b16a-6f10-aeaa-110c3af3f051-fb048ddf" class="div-block-230">
              <div class="w-layout-grid grid-container-title" style="padding-top:10px; padding-bottom:10px">
                <a href="#" onclick="window.history.back()" class="link-block-back w-inline-block">
                    <img src="../images/Back-arrow.svg" loading="lazy" height="26" width="26" alt="" class="back">
                </a>
                <h1 id="w-node-_28f3db33-b16a-6f10-aeaa-110c3af3f055-fb048ddf" class="titulo-principal" v-cloak>{{listaidiomaSincronizActivo.Titulo}}</h1> 
                  <div data-hover="false" data-delay="0" id="w-node-_01c345db-44dd-5950-8797-fc0e77f5b71f-731f63ba" class="dropdown-detalles-ai w-dropdown">
                  <div style="padding: 0px;" class="toggle-detalles-ai w-dropdown-toggle"><img src="../images/info2.svg" loading="lazy" alt="" class="img-detalles-ai"></div>
                  <nav class="detalles-descrp-ai w-dropdown-list">
                    <p class="p-desc-detalles-ai" v-cloak>{{listaidiomaSincronizActivo.Msj1}}<strong><br>{{listaidiomaSincronizActivo.Msj2}}</strong></p> 
                  </nav>
                </div>
              </div>
            </div>
            <div id="w-node-_85f34e9c-c2ff-b66a-5d22-dd251014c3e1-fb048ddf" class="contenedor-botones carga-descarga alt">
              <a href="#" class="link-block-boton dere gris w-inline-block" @click="ExportarExcel()">
                  <img src="../images/descargar.svg" loading="lazy" alt="">
              </a>
               
           
              <label class ="link-block-boton gris w-inline-block" >
                 
                  <img src="../images/cargar.svg"  alt="">
                  <input style="display: none;"  type="file" accept=".xlsx, .xls" id="files" @change="Importar"/>
                   
              </label>
                
                   
            </div>
            <div id="w-node-_28f3db33-b16a-6f10-aeaa-110c3af3f057-fb048ddf" class="div-tarjeta sinc tarjeta-responsive resp">
              <div class="contenedor-grid grid-first-table">
                <div class="w-layout-grid grid tabla-activos">
                  <div class="texto-blanco" v-cloak>{{listaidiomaSincronizActivo.NombreArch}}</div> 
                  <div class="texto-blanco" v-cloak>{{listaidiomaSincronizActivo.TotalAct}}</div>
                  <div class="texto-blanco" v-cloak>{{listaidiomaSincronizActivo.ActivosCorr}}</div> 
                  <div class="texto-blanco" v-cloak>{{listaidiomaSincronizActivo.ActivosIncorr}}</div> 
                  <div class="texto-blanco" v-cloak>{{listaidiomaSincronizActivo.ActivPend}}</div> 
                  <div class="texto-blanco" v-cloak>{{listaidiomaSincronizActivo.Tienda}}</div> 
                  <div id="w-node-_7ea528e2-8ea0-1a29-4f38-40d8e7067693-fb048ddf" class="celda-vacia celda-activos">
                    <div class="parrafo-grid">{{NombreArchivo}}</div>
                  </div>
                  <div class="celda-vacia celda-activos">
                    <div class="parrafo-grid">{{TotalActivos}}</div>
                  </div>
                  <div class="celda-vacia celda-activos">
                    <div class="parrafo-grid">{{ActivosCorrectos}}</div>
                  </div>
                  <div class="celda-vacia celda-activos">
                    <div class="parrafo-grid">{{ActivosIncorrectos}}</div>
                  </div>
                  <div class="celda-vacia celda-activos">
                    <div class="parrafo-grid">{{ActivosPendientes}}</div>
                  </div>
                  <div class="celda-vacia celda-activos">
                    <a href="../Tienda/Tienda.aspx" class="link-block-2 rojo w-inline-block">
                        <img src="../images/tienda2.svg" loading="lazy" width="30" height="30" alt="" class="image-29">
                    </a>
                  </div>
                </div>
              </div>
              
                <div class="contenedor-grid grid-secnd-table">
                        <table style="margin-top: 15px; width: 100%;">
                                <thead style="text-align:center">
                                    <tr v-cloak>
                                          <td class="encabezado-tabla-empleados" style="width: 115px;">{{listaidiomaSincronizActivo.TblNEtiqueta}}</td>
                                          <td class="encabezado-tabla-empleados" style="width: 115px;">{{listaidiomaSincronizActivo.TblDescLar}}</td>
                                          <td class="encabezado-tabla-empleados" style="width: 115px;">{{listaidiomaSincronizActivo.TblCategoria}}</td>
                                          <td class="encabezado-tabla-empleados" style="width: 115px;">{{listaidiomaSincronizActivo.TblEstado}}</td>
                                          <td class="encabezado-tabla-empleados" style="width: 115px;">{{listaidiomaSincronizActivo.TblUbicacion}}</td>
                                          <td class="encabezado-tabla-empleados" style="width: 115px;">{{listaidiomaSincronizActivo.TblMarca}}</td>
                                          <td class="encabezado-tabla-empleados" style="width: 115px;">{{listaidiomaSincronizActivo.TblModelo}}</td>
                                          <td class="encabezado-tabla-empleados" style="width: 115px;">{{listaidiomaSincronizActivo.TblnSerie}}</td>
                                          <td class="encabezado-tabla-empleados" style="width: 115px;">{{listaidiomaSincronizActivo.TblCosto}}</td>
                                          <td class="encabezado-tabla-empleados" style="width: 115px;">{{listaidiomaSincronizActivo.TblNFactura}}</td>
                                          <td class="encabezado-tabla-empleados" style="width: 115px;">{{listaidiomaSincronizActivo.TblFechaComp}}</td>
                                          <td class="encabezado-tabla-empleados" style="width: 115px;">{{listaidiomaSincronizActivo.TblEstadosSinc}}</td>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr v-for="(activo,index) in tabla1datosPaginados"
                                        :key="index" 
                                        >
                                        
                                        <td class="detalle-tabla-empleado">
                                            <div class="parrafo-grid">
                                                {{activo.NumEtiqueta}}
                                            </div>
                                        </td>

                                        <td class="detalle-tabla-empleado">
                                            <div class="parrafo-grid">
                                                {{activo.Descripcion}}
                                            </div>
                                        </td>

                                        <td class="detalle-tabla-empleado">
                                            <div class="parrafo-grid">
                                                {{activo.Categoria}}
                                            </div>
                                        </td>

                                        <td class="detalle-tabla-empleado">
                                            <div class="parrafo-grid">
                                                {{activo.Estado}}
                                            </div>
                                        </td>

                                        <td class="detalle-tabla-empleado">
                                            <div class="parrafo-grid">
                                                {{activo.Ubicacion}}
                                            </div>
                                        </td>

                                        <td class="detalle-tabla-empleado">
                                            <div class="parrafo-grid">
                                                {{activo.Marca}}
                                            </div>
                                        </td>

                                        <td class="detalle-tabla-empleado">
                                            <div class="parrafo-grid">
                                                {{activo.Modelo}}
                                            </div>
                                        </td>
                                        <td class="detalle-tabla-empleado">
                                            <div class="parrafo-grid">
                                                {{activo.Serie}}
                                            </div>
                                        </td>
                                        <td class="detalle-tabla-empleado">
                                            <div class="parrafo-grid">
                                                {{activo.Costo}}
                                            </div>
                                        </td>
                                        <td class="detalle-tabla-empleado">
                                            <div class="parrafo-grid">
                                                {{activo.Factura}}
                                            </div>
                                        </td>
                                        <td class="detalle-tabla-empleado">
                                            <div class="parrafo-grid">
                                                {{FormatearFecha(activo.FechaCompra)}}
                                            </div>
                                        </td>
                                        <td class="detalle-tabla-empleado">
                                            <a href="#" class="link-block-2 rojo w-inline-block">
                                                <img :src="activo.EstadoActivo" loading="lazy" width="20" height="30" alt="" class="image-29">
                                            </a>
                                        </td>
                                    </tr>  
                                </tbody>
                                <tfoot>
                                    <tr>
                                       <td>
                                         
                                      </td>
                                  </tr>
                               </tfoot>
                            </table>

                       <div class="pagination-content">
                                                <div class="form-block-19 block-pag w-form">
                                                <div id="email-form-3" name="email-form-3" data-name="Email Form 3" method="get" class="form-11">
                                            <img v-on:click="PaginaAnteriortabla1()" src="../images/simbolo-de-doble-flecha-izquierda-hacia-atras-rapido.png"
                                                loading="lazy" width="15" height="15" alt="" class="image-9">
                                            <label for="name-2" class="cant-paginas">{{tabla1paginaActual}}</label>
                                            <label for="name-2" class="cant-paginas">de {{tabla1paginas}}</label>
                                            <img v-on:click="PaginaSiguientetabla1()" src="../images/angulos-de-flechas-dobles-a-la-derecha.png" loading="lazy" width="15" height="15" alt="" class="image-9">
                                        </div>
                                    </div>
                                </div>
                    </div>



              <div class="pagination-content sinc-act-pag w-clearfix">

                <div class="contenedor-botones cont-btns-left"></div>
                <div class="contenedor-botones cont-btns-left">
                  <a href="#" class="boton up btn-sic-actvs w-button" @click="InsertarActivos()">{{listaidiomaSincronizActivo.BtnSinc}}</a> 
                    
                </div>
              </div>
            </div>

            <div id="w-node-a5ddfd93-6478-1c5c-3584-0439e4003df7-fb048ddf" class="div-tarjeta div-cinta">
              <div class="div-block-170">
                <div class="text-block-17" v-cloak>{{listaidiomaSincronizActivo.ActDisp}}</div> 
                <a href="../Tienda/Tienda.aspx" class="boton call2action w-button" v-cloak>{{listaidiomaSincronizActivo.IrTienda}}<strong></strong></a> 
              </div>
            </div>
          </div>
        </div>
      </div>


</div>

</div>



<script src="../Recursos/JQuery/jquery-3.5.1.min.dc5e7f18c8.js"></script>
<script src="Js/Prueba.js"></script>
<script src="../js/Table.js"></script>
<script src="../js/Tabla2.js"></script>
</asp:Content>

