<%@ page title="" language="C#" masterpagefile="~/SiteMaster/Site.Master" autoeventwireup="true" codebehind="Tienda.aspx.cs" inherits="ActiveSmartWeb.Tienda.Tienda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="main" id="tiendaVue">
        <div class="section wf-section">
            <div class="container-2 w-container">
                <div class="w-layout-grid grid-main">
                    <div id="w-node-_9ca94d29-d29b-e959-26a7-2120087ff165-d0b7a149" class="div-banner-extremo"></div>
                    <div id="w-node-_9ca94d29-d29b-e959-26a7-2120087ff166-d0b7a149" class="div-banner-extremo"></div>
                    <div id="w-node-_9ca94d29-d29b-e959-26a7-2120087ff169-d0b7a149" class="div-block-167 div-resumen">
                        <div class="div-block-169"></div>

                        <div class="w-layout-grid grid-container-title" style="padding-top:7px; padding-bottom:6px">
                  <a href="#" onclick="window.history.back()" class="link-block-back w-inline-block">
                      <img src="../images/Back-arrow.svg" loading="lazy" height="26" width="26" alt="" class="  ">
                  </a>
                  <h1 id="w-node-_9be28721-5dbb-5f12-6325-d0dcd6cba1e6-ffdc8228" class="titulo-principal" v-cloak>{{listaIdiomas.Titulo}}</h1>
                  <div data-hover="false" data-delay="0" id="w-node-_01c345db-44dd-5950-8797-fc0e77f5b71f-731f63ba" class="dropdown-detalles-ai w-dropdown" style="z-index: 10">
                      <div class="toggle-detalles-ai w-dropdown-toggle" style="padding:0px">
                          <img src="../images/info2.svg" loading="lazy" alt="" class="img-detalles-ai">
                      </div>
                      <nav class="detalles-descrp-ai w-dropdown-list">
                          <p class="p-desc-detalles-ai" v-cloak>{{listaIdiomas.Msj1}}<strong><br>{{listaIdiomas.Msj2}}</strong></p>
                      </nav>
                  </div>
              </div>
                        <div class="w-layout-grid grid-perfil grid-center grid-tienda">
                            <div id="w-node-_9ca94d29-d29b-e959-26a7-2120087ff16f-d0b7a149" class="div-info-left-ai left-tienda">
                                <div class="div-checkout-paln-ai">
                                    <div class="div-type-compra-ai tarjeta-tienda" v-for="(adicional,index) in adicionales" :key="index">
                                        <div class="div-producto-gd tienda">
                                            <div class="info-producto-gd info-prod-ai">
                                                <div class="divdescripcion">
                                                    <div class="contenedorprodcutosuperior">
                                                        <div class="divinfoproducto producto-tienda w-clearfix">
                                                            <div class="div-articulo-data w-clearfix">
                                                                <div class="div-imagen-gd div-img-tienda">
                                                                    <div data-delay="4000" data-animation="slide" class="slider-3 slider-tienda w-slider" data-autoplay="false" data-easing="ease" data-hide-arrows="false" data-disable-swipe="false" data-autoplay-limit="0" data-nav-spacing="3" data-duration="500" data-infinite="true">
                                                                        <div class="mask-tienda w-slider-mask">
                                                                            <div class="slide-tienda w-slide">
                                                                                <img src="images/signus_id_basic.svg" loading="lazy" width="212" alt="" class="img-tienda">
                                                                            </div>
                                                                        </div>
                                                                        <div class="left-tienda-arrow w-slider-arrow-left">
                                                                            <div class="icon-5 icon-arrow-tienda w-icon-slider-left"></div>
                                                                        </div>
                                                                        <div class="right-tienda-arrow w-slider-arrow-right">
                                                                            <div class="icon-4 icon-arrow-tienda w-icon-slider-right"></div>
                                                                        </div>
                                                                        <div class="slide-nav-2 sliode-nav-tienda w-slider-nav w-round"></div>
                                                                    </div>
                                                                </div>
                                                                <h2 class="titulo-02-zebra heading-art-tinda" v-cloak>{{adicional.Nombre}}<br>
                                                                </h2>
                                                            </div>
                                                            <div class="form-block-15 form-price form-tienda w-form">

                                                                <div class="div-block-precio-gd tienda precio-tienda">
                                                                    <div class="div-block-228">
                                                                        <p class="precio-zebra precio-ai" v-cloak>${{adicional.Costo}}<strong class="iva">+iva</strong></p>
                                                                        <p class="precio-zebra precio-anterior" v-cloak>${{adicional.Costo}}<strong class="iva">+iva</strong></p>
                                                                    </div>
                                                                    <div class="div-block-226 div-stock w-clearfix">
                                                                        <a href="#" class="btn-less-ai w-button" @click="Restaadicional(adicional)">-</a>
                                                                        <input type="text" class="txt-cantidad-ai w-input" maxlength="256" name="name-3" data-name="Name 3" placeholder="" required="" value="0" :id="adicional.IdPaqueteContratado" style="text-align:center" :v-model="adicional.IdPaqueteContratado" onkeypress="return event.charCode>=48 && event.charCode<=57" @change="agregaradicional(adicional)">
                                                                        <a href="#" class="btn-add-ai w-button" @click="sumaradicional(adicional)">+</a>
                                                                    </div>
                                                                </div>
                                                                <div data-hover="false" data-delay="0" class="dropdown-detall-zc drop-tienda-ai w-dropdown">
                                                                    <div class="dropdwn-detall-zc drp-ai-detalles w-clearfix w-dropdown-toggle">
                                                                        <div class="text-mas-detalles-zc mas-detall-ai">Más Detalles</div>
                                                                        <div class="icon-detalles-zc w-icon-dropdown-toggle"></div>
                                                                    </div>
                                                                    <nav class="lista-dropdown-zc w-dropdown-list">
                                                                        <a href="#" class="drop-link2-zc w-dropdown-link"></a>
                                                                        <p class="p-descr-zc">Lorem ipsum dolor sit amet, convfdg es fs fdsfds fsf sfds fdsf sfs fs dfs fs s gs g gs gs s sectetur adipiscing elit. Lorem ipsum dolor sit amet, convfdg es fs fdsfds fsf sfds fdsf sfs fs dfs fs s gs g gs gs s sectetur dolor.</p>
                                                                        <h4 class="heading-espcf-zc">Especificaciones:</h4>
                                                                        <ul role="list" class="especificaciones-lista-zc">
                                                                            <li class="list-item-zc">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspen Lorem ipsum do</li>
                                                                            <li class="list-item2-zc">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspen Lorem ipsum do</li>
                                                                            <li class="list-item3-zc">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspen Lorem ipsum do</li>
                                                                            <li class="list-item4-zc">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspen Lorem ipsum do</li>
                                                                        </ul>
                                                                        <ul role="list" class="list-4"></ul>
                                                                    </nav>
                                                                </div>

                                                            </div>
                                                            <ul role="list" class="especificaciones-lista-zc"></ul>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div id="w-node-_9ca94d29-d29b-e959-26a7-2120087ff211-d0b7a149" class="div-colum-fixed">
                                <div class="div-checkout-orden-ai div-check-tienda">
                                    <div class="div-total-pago-ai resumen-tienda">
                                        <h5 class="p-pago-adicio-ai" v-cloak>{{listaIdiomas.ResumenDeOrden}}</h5>
                                        <div class="colums-order-ai cols-price-paln-ai cols-tienda-ai w-row">
                                            <div class="col-order-ai col-border-r-ai w-col w-col-7 w-col-small-6 w-col-tiny-6">
                                                <div class="p-type-plan-ai p-tienda-ai">Plan Active ID Smart Basic</div>
                                            </div>
                                            <div class="col-order-ai col-precio-ai w-col w-col-5 w-col-small-6 w-col-tiny-6">
                                                <div class="p-duration-plan-ai p-precio-ai p-precio-t" v-cloak>{{listaIdiomas.Precio}}</div>
                                                <div class="p-price-plan-ai p-precio-t" v-cloak>US${{totalpago}}</div>
                                            </div>
                                        </div>
                                        <div class="p-pago-adicio-ai">adicionales</div>
                                        <div class="coulms-plan-ai colums-adic-pago-ai col-tienda-ai w-row" v-for="(adicionalseleccionado,index) in adicionalesseleccionados" :key="index">
                                            <div class="col-plan-ai col-ad-ai w-col w-col-6 w-col-small-4 w-col-tiny-4">
                                                <div class="div-cant-compra-ai"></div>
                                                <div class="p-adic-pag-ai" v-cloak>{{adicionalseleccionado.Nombre}}</div>
                                            </div>
                                            <div class="col-paln-ai col-ad-ai xx w-clearfix w-col w-col-2 w-col-small-4 w-col-tiny-4">
                                                <div class="cant-act-ai" v-cloak>{{adicionalseleccionado.Cantidad}}</div>
                                            </div>
                                            <div class="col-paln-ai col-ad-ai w-col w-col-4 w-col-small-4 w-col-tiny-4">
                                                <div class="p-price-plan-calc-ai" v-cloak>US${{adicionalseleccionado.Costo}}/mes</div>
                                            </div>
                                        </div>
                                        <div class="colums-order-ai total-price-cols-ai w-row">
                                            <div class="col-order-ai w-col w-col-6 w-col-small-6 w-col-tiny-6">
                                                <div class="p-total-pay-ai" v-cloak>{{listaIdiomas.TotalPagar}}</div>
                                            </div>
                                            <div class="col-order-ai w-col w-col-6 w-col-small-6 w-col-tiny-6">
                                                <div class="p-total-pay-ai" v-cloak>US${{totalpago}}</div>
                                            </div>
                                        </div>
                                        <a href="#" class="btn-pagar-orden-ai w-button" v-cloak>{{listaIdiomas.Pagar}} US${{totalpago}}</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src="js/Tienda.js"></script>

</asp:Content>
