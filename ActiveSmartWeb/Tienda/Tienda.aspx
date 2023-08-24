<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/Site.Master" AutoEventWireup="true" CodeBehind="Tienda.aspx.cs" Inherits="ActiveSmartWeb.Tienda.Tienda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="section" id="tiendaVue">
        <div class="container-2 w-container">
            <div class="w-layout-grid grid-main">
                <div id="w-node-_9ca94d29-d29b-e959-26a7-2120087ff165-d0b7a149" class="div-banner-extremo"></div>
                <div id="w-node-_9ca94d29-d29b-e959-26a7-2120087ff166-d0b7a149" class="div-banner-extremo"></div>
                <div id="w-node-_9ca94d29-d29b-e959-26a7-2120087ff169-d0b7a149" class="div-block-167 div-resumen">
                    <div class="div-block-169"></div>
                    <div class="div-title-a">
                        <h1 class="heading-perf-emp-ai">Mi Tienda</h1>
                        <div data-hover="false" data-delay="0" class="dropdown-detalles-ai w-dropdown">
                            <div class="toggle-detalles-ai tienda w-dropdown-toggle">
                                <img src="../images/info2.svg" loading="lazy" alt="" class="img-detalles-ai"></div>
                            <nav class="detalles-descrp-ai w-dropdown-list">
                                <p class="p-desc-detalles-ai">En esta página se puede: crear, ver, gestionar y aprobar <strong>
                                    <br>
                                    Tomas Físicas.</strong></p>
                            </nav>
                        </div>
                    </div>
                    <div class="w-layout-grid grid-perfil grid-center grid-tienda">
                        <div id="w-node-_9ca94d29-d29b-e959-26a7-2120087ff16f-d0b7a149" class="div-info-left-ai left-tienda">
                            <div class="div-checkout-paln-ai">

                                <%--Configuracion del plan, agregar adicionales--%>
                                <div v-for="(adicional,index) in adicionales" :key="index" class="div-type-compra-ai tarjeta-tienda">
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
                                                                            <img src="../images/signus_id_basic.svg" loading="lazy" width="212" alt="" class="img-tienda"></div>
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
                                                            <h2 class="titulo-02-zebra heading-art-tinda">{{adicional.Nombre}}<br>
                                                            </h2>
                                                            
                                                        </div>

                                                        <div class="form-block-15 form-price form-tienda w-form">
                                                            <div id="email-form" name="email-form" data-name="Email Form" class="form-12 form-p-tienda w-clearfix" data-wf-page-id="62e04453b83e1b10d0b7a149" data-wf-element-id="4c0508b9-af5d-6b19-5450-58730451304f">
                                                                <div class="div-block-precio-gd tienda precio-tienda">
                                                                    <div style="margin-bottom:5px;" class="div-block-228">
                                                                        <p class="precio-zebra precio-ai">US${{adicional.Costo}}<strong class="iva">+iva</strong></p>
                                                                        <p class="precio-zebra precio-anterior">$19.99<strong class="iva">+iva</strong></p>
                                                                    </div>
                                                                    <div class="div-block-226 div-stock w-clearfix">
                                                                        <a href="#" class="btn-less-ai w-button" @click="Restaadicional(adicional)">-</a>

                                                                        <input v-if="adicional.IdPaqueteContratado == 1" type="text" class="txt-cantidad-ai w-input"maxlength="2" value=1 :id="adicional.IdPaqueteContratado" :v-model="adicional.IdPaqueteContratado"  name="name-3" data-name="Name 3" placeholder="" required="" onkeypress="return event.charCode>=48 && event.charCode<=57" @change="agregaradicionalActivos(adicional)">
                                                                        <input v-if="adicional.IdPaqueteContratado != 1" type="text" class="txt-cantidad-ai w-input"maxlength="2" value=2 :id="adicional.IdPaqueteContratado" :v-model="adicional.IdPaqueteContratado"  name="name-3" data-name="Name 3" placeholder="" required="" onkeypress="return event.charCode>=48 && event.charCode<=57" @change="agregaradicional(adicional)">
                                                                        
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

                        <%--Resumen de la compra --%>
                        <div id="w-node-_9ca94d29-d29b-e959-26a7-2120087ff211-d0b7a149" class="div-colum-fixed">
                            <div class="div-checkout-orden-ai div-check-tienda">
                                <div class="div-total-pago-ai resumen-tienda">
                                    <h5 class="p-pago-adicio-ai">Resumen de la orden</h5>
                                    <div class="colums-order-ai cols-price-paln-ai cols-tienda-ai w-row">
                                        <div class="col-order-ai col-border-r-ai w-col w-col-7 w-col-small-6 w-col-tiny-6">
                                            <div class="p-type-plan-ai p-tienda-ai">Plan Active ID Smart Basic</div>
                                        </div>
                                        <div class="col-order-ai col-precio-ai w-col w-col-5 w-col-small-6 w-col-tiny-6">
                                            <div class="p-duration-plan-ai p-precio-ai p-precio-t">Precio</div>
                                            <div class="p-price-plan-ai p-precio-t">US$14.99</div>
                                        </div>
                                    </div>
                                    <div class="p-pago-adicio-ai">adicionales</div>

                                    <%--Adicionales--%>
                                    <div v-for="(adicionalseleccionado,index) in adicionalesseleccionados" :key="index" class="coulms-plan-ai colums-adic-pago-ai col-tienda-ai w-row">
                                        <div class="col-plan-ai col-ad-ai w-col w-col-6 w-col-small-4 w-col-tiny-4">
                                            <div class="div-cant-compra-ai"></div>
                                            <div class="p-adic-pag-ai">{{adicionalseleccionado.Nombre}}</div>
                                        </div>
                                        <div class="col-paln-ai col-ad-ai xx w-clearfix w-col w-col-2 w-col-small-4 w-col-tiny-4">
                                            <div class="cant-act-ai">{{adicionalseleccionado.Cantidad}}</div>
                                        </div>
                                        <div class="col-paln-ai col-ad-ai w-col w-col-4 w-col-small-4 w-col-tiny-4">
                                            <div v-if="frecuenciaPago=='1'" class="p-price-plan-calc-ai">US${{adicionalseleccionado.Costo}}/mes</div>
                                            <div v-if="frecuenciaPago=='2'" class="p-price-plan-calc-ai">US${{adicionalseleccionado.CostoMensual}}/mes</div>
                                        </div>
                                    </div>

                                    
                                    <div class="colums-order-ai total-price-cols-ai w-row">
                                        <div class="col-order-ai w-col w-col-6 w-col-small-6 w-col-tiny-6">
                                            <div class="p-total-pay-ai">Total a pagar:</div>
                                        </div>
                                        <div class="col-order-ai w-col w-col-6 w-col-small-6 w-col-tiny-6">
                                            <div class="p-total-pay-ai">US${{totalpago}}</div>
                                        </div>
                                    </div>
                                    <a @click="realizarPago()" href="#" class="btn-pagar-orden-ai w-button">Pagar US${{totalpago}}</a>
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
