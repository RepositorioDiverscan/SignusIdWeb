<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/Site.Master" AutoEventWireup="true" CodeBehind="Tienda.aspx.cs" Inherits="ActiveSmartWeb.Tienda.Tienda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>


    </style>
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
                                   <div class="div-block-375">
                      <div class="div-block-376" >
                        <h5 class="heading-75">CONFIGURE SUS ADICIONALES</h5>
                          <div v-for="(adicional,index) in adicionales" :key="index">
                              <h5 class="heading-77">{{adicional.Nombre}}</h5>
                              <div class="div-block-374 newmasmenos" class="div-type-compra-ai tarjeta-tienda">

                                  <div id="w-node-_639e6cee-85b6-2c3d-41bb-9098c6443f9d-d0b7a149" class="fb-cant-ai newmasmenos w-form" >
                                      <div id="email-form-3" name="email-form-3" data-name="Email Form 3" method="get" class="form-cant-ai w-clearfix" data-wf-page-id="62e04453b83e1b10d0b7a149" data-wf-element-id="639e6cee-85b6-2c3d-41bb-9098c6443f9e">
                                          <button href="#" class="btn-less-ai w-button" @click="Restaadicional(adicional)">-</button>

                               <input v-if="adicional.IdPaqueteContratado == 1" type="text" class="txt-cantidad-ai w-input"maxlength="2" value=0 :id="adicional.IdPaqueteContratado"  name="name-3" data-name="Name 3" placeholder="" required="" onkeypress="return event.charCode>=48 && event.charCode<=57" @change="agregaradicionalActivos(adicional)">
                               <input v-if="adicional.IdPaqueteContratado != 1" type="text" class="txt-cantidad-ai w-input"maxlength="2" value=0 :id="adicional.IdPaqueteContratado"  name="name-3" data-name="Name 3" placeholder="" required="" onkeypress="return event.charCode>=48 && event.charCode<=57" @change="agregaradicional(adicional)">
                                                                        
                                   <button href="#" class="btn-add-ai w-button" @click="sumaradicional(adicional)">+</button>
                                      </div>
                                      <div class="w-form-done">
                                          <div>Thank you! Your submission has been received!</div>
                                      </div>
                                      <div class="w-form-fail">
                                          <div>Oops! Something went wrong while submitting the form.</div>
                                      </div>
                                  </div>
                                 
                                  <h5 style="margin-right: 20px;"   id="w-node-_1de677f9-6f79-db86-ba75-aa2467ef45ff-d0b7a149" class="heading-76"><del>US$19.99/mes</del> </h5>
                                  <h5  id="w-node-_5fa76777-814e-5390-4844-ef716bd67458-d0b7a149" class="heading-76 boldtienda">US ${{adicional.Costo}}/mes</h5>

                              </div>
                              
                          </div>
             
                        
     

                      </div>
                    </div>


                            </div>
                        </div>

                        <%--Resumen de la compra --%>
                        <div id="w-node-_9ca94d29-d29b-e959-26a7-2120087ff211-d0b7a149" class="div-colum-fixed">
                            <div class="div-checkout-orden-ai div-check-tienda">
                                <div class="div-total-pago-ai resumen-tienda"  style="margin-left: 110px;">
                                    <h5 class="p-pago-adicio-ai">Resumen de la orden</h5>
                                    <div class="colums-order-ai cols-price-paln-ai cols-tienda-ai w-row">
                                        <div class="col-order-ai col-border-r-ai w-col w-col-7 w-col-small-6 w-col-tiny-6">
                                            <div class="p-type-plan-ai p-tienda-ai">Plan Active ID Smart Basic</div>
                                        </div>
                                        <div class="col-order-ai col-precio-ai w-col w-col-5 w-col-small-6 w-col-tiny-6">
                                            <div class="p-duration-plan-ai p-precio-ai p-precio-t">Precio</div>
                                            <div class="p-price-plan-ai p-precio-t">US${{precioAct}}</div>
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
                                            <div v-if="frecuenciaPago=='2'" class="p-price-plan-calc-ai">US${{adicionalseleccionado.CostoMensual}}/mes</div>
                                            <div v-if="frecuenciaPago=='1'" class="p-price-plan-calc-ai">US${{adicionalseleccionado.Costo*12}}/Año</div>
                                        </div>
                                    </div>

                                    
                                    <div class="colums-order-ai total-price-cols-ai w-row">
                                        <div class="col-order-ai w-col w-col-6 w-col-small-6 w-col-tiny-6">
                                            <div style="font-size:15px" class="p-total-pay-ai">Nueva suscripcion:</div>
                                        </div>
                                        <div class="col-order-ai w-col w-col-6 w-col-small-6 w-col-tiny-6">
                                            <div class="p-total-pay-ai">US${{totalpago}}</div>
                                        </div>
                                    </div>
                                    <a @click="realizarPago()" href="#" class="btn-pagar-orden-ai w-button">Pagar diferencia US${{pagoParcial}}</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

     <div class="background-pop-up background-pago" id="PopUpPago">
      <div class="popup-comercial add-pago-pp pago2-pp">
        <div class="header-modal-ai">
          <h4 class="texto-h-ai">Método de pago predeterminado</h4>
          <div class="div-icon-exit-ai" @click="CerrarPopUp()" ><img src="../images/icono_eliminar_acces-o-01.svg" loading="lazy" alt="" class="img-salir-ai"></div>
        </div>
        <p class="texto-modal-ai"><strong class="bold-text-3">Se realizará el cobro a la </strong><strong>tarjeta predeterminada.</strong></p>
        <div class="div-tarjeta-prederteminada w-clearfix"><img src="../images/visa.svg" loading="lazy" alt="" class="tarjeta-img tarjeta-prederteminada">
          <div class="div-tarjetas-img">
            <div class="t-data-tarjeta">{{CardholderName}}</div>
            <div class="t-data-tarjeta">{{NumTarjeta}}</div>
          </div>
        </div>
        <div class="div-btns-pp pp-tienda">
          <a href="#" class="btn-cerrar btn-left-pp w-button">Guardar</a>
        </div>
      </div>
    </div>
    </div>
    <script src="js/Tienda.js"></script>

</asp:Content>
