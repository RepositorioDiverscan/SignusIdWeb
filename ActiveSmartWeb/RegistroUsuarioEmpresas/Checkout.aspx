<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="ActiveSmartWeb.RegistroUsuarioEmpresas.Checkout" %>


<!DOCTYPE html><!--  This site was created in Webflow. https://www.webflow.com  -->
<!--  Last Published: Mon Jul 04 2022 14:50:41 GMT+0000 (Coordinated Universal Time)  -->
<html data-wf-page="62a75c9546a08225ea206ea8" data-wf-site="606dfb37871f33efa37244d4">
<head>
  <meta charset="utf-8">
  <title>Checkout version2 test</title>
  <meta content="Checkout version2 test" property="og:title">
  <meta content="Checkout version2 test" property="twitter:title">
  <meta content="width=device-width, initial-scale=1" name="viewport">
  <meta content="Webflow" name="generator">
  <link href="../css/normalize.css" rel="stylesheet" type="text/css">
  <link href="../css/webflow.css" rel="stylesheet" type="text/css">
  <link href="../css/signusid.webflow.css" rel="stylesheet" type="text/css">
    <%--Paises--%>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/country-select-js/2.1.1/css/countrySelect.min.css" />
    <%--Alertas--%>
    <script src="/Alertas/alertas.js"></script>
  <script src="https://ajax.googleapis.com/ajax/libs/webfont/1.6.26/webfont.js" type="text/javascript"></script>
  <script type="text/javascript">WebFont.load({ google: { families: ["Lato:100,100italic,300,300italic,400,400italic,700,700italic,900,900italic", "Montserrat:100,100italic,200,200italic,300,300italic,400,400italic,500,500italic,600,600italic,700,700italic,800,800italic,900,900italic"] } });</script>
  <!-- [if lt IE 9]><script src="https://cdnjs.cloudflare.com/ajax/libs/html5shiv/3.7.3/html5shiv.min.js" type="text/javascript"></script><![endif] -->
  <script type="text/javascript">!function (o, c) { var n = c.documentElement, t = " w-mod-"; n.className += t + "js", ("ontouchstart" in o || o.DocumentTouch && c instanceof DocumentTouch) && (n.className += t + "touch") }(window, document);</script>
  <link href="../images/logo-02.png" rel="shortcut icon" type="image/x-icon">
  <link href="../images/logo-02.png" rel="apple-touch-icon">

    <%--Sweet Alert--%>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
    <script src="sweetalert2.min.js"></script>
    <link rel="stylesheet" href="sweetalert2.min.css">

    <style>
        .iti, .country-select {
            min-width: 100%;
        }

    </style>

</head>
<body>
  <div class="header-steps-payout-ai"><img src="../images/signus_id.png" loading="lazy" width="158" srcset="../images/signus_id-p-500.png 500w, ../images/signus_id-p-800.png 800w, ../images/signus_id-p-1080.png 1080w, ../images/signus_id.png 1730w" sizes="150px" alt="" class="logo-payout-ai"></div>
  <div class="contenedor-general" id="context">
    <div class="main">
      <div id="alertas" class="section wf-section">
        <div class="container-2 w-container">
          <div class="w-layout-grid grid-main">
            <div id="w-node-_4d22b9b3-6a6e-3c88-9312-63f8170851b1-ea206ea8" class="div-banner-extremo"></div>
            <div id="w-node-_4d22b9b3-6a6e-3c88-9312-63f8170851b2-ea206ea8" class="div-banner-extremo"></div>
            <div id="w-node-c92b904f-2d9c-5e55-9bd2-2474aba90c46-ea206ea8" class="div-block-211 div-steps-ai"><img src="../images/Procesos-de-Compra-03.svg" loading="lazy" height="20" alt=""></div>
            <div id="w-node-_4d22b9b3-6a6e-3c88-9312-63f8170851b9-ea206ea8" class="div-block-167 div-resumen">
              <div class="div-block-169"></div>
              <div class="div-title-a">
                <h1 class="heading-perf-emp-ai" v-cloak>{{listaIdiomas.Titulo}}</h1>
              </div>
              <div class="w-layout-grid grid-perfil grid-center">
                <div id="w-node-_256a800c-031d-90d5-c17c-571e8b235b4a-ea206ea8" class="div-info-left-ai">
                  <div class="div-checkout-paln-ai">
                    <div class="div-detalle-compra-ai">
                      <div class="p-type-compra-ai">Mensual</div>
                      <div class="p-type-modulo-ai">Básico</div>
                      <h4 id="w-node-_65fda26d-acd7-5eba-e34e-528dd88c0571-ea206ea8" class="p-pago-adicio-ai" v-cloak>{{listaIdiomas.TituloPlan}}</h4>
                      <img :src="rutaImagen" loading="lazy" width="217" id="w-node-_65fda26d-acd7-5eba-e34e-528dd88c0573-ea206ea8"
                       sizes="(max-width: 479px) 34vw, (max-width: 767px) 138.875px, (max-width: 991px) 18vw, 15vw" alt="" class="img-plan-selec-ai">
                    </div>
                    <div class="div-cant-compra-ai"></div>
                    <div class="div-type-compra-ai">
                      <h4 class="p-pago-adicio-ai" v-cloak>{{listaIdiomas.TituloConfigure}}</h4>


                        <%--Configure Adicionales--%>
                      <div v-for="(adicional,index) in adicionales" :key="index">

                          <div class="p-adicionales-ai" v-cloak>{{adicional.Nombre}}</div>
                          <div class="coulms-plan-ai colums-pack-ai w-row">
                            <div class="col-plan-ai w-col w-col-3 w-col-small-3 w-col-tiny-6">
                              <div class="div-cant-compra-ai">
                                <div class="fb-cant-ai w-form">
                                  <div id="email-form-3" name="email-form-3" data-name="Email Form 3" method="get" class="form-cant-ai w-clearfix">
                                    <a v-if="codigoPlan==2" href="#" class="btn-less-ai w-button" @click="Restaadicional(adicional)">-</a>
                                    
                                     <input v-if="codigoPlan==1" disabled type="text" class="txt-cantidad-ai w-input" maxlength="2" value=1 :id="adicional.IdPaqueteContratado" style="text-align:center" :v-model="adicional.IdPaqueteContratado"  name="name-3" data-name="Name 3" onkeypress="return event.charCode>=48 && event.charCode<=57" @change="agregaradicionalActivos(adicional)">
                                     
                                      <%--Inputs del plan basic--%>
                                    <input v-if="adicional.IdPaqueteContratado == 1 && codigoPlan==2" type="text" class="txt-cantidad-ai w-input" maxlength="2" value=1 :id="adicional.IdPaqueteContratado" style="text-align:center" :v-model="adicional.IdPaqueteContratado"  name="name-3" data-name="Name 3" onkeypress="return event.charCode>=48 && event.charCode<=57" @change="agregaradicionalActivos(adicional)">
                                    <input v-if="adicional.IdPaqueteContratado != 1 && codigoPlan==2" type="text" class="txt-cantidad-ai w-input" maxlength="2" value=2 :id="adicional.IdPaqueteContratado" style="text-align:center" :v-model="adicional.IdPaqueteContratado"  name="name-3" data-name="Name 3" onkeypress="return event.charCode>=48 && event.charCode<=57" @change="agregaradicional(adicional)">

                                    <a v-if="codigoPlan==2" href="#" class="btn-add-ai w-button" @click="sumaradicional(adicional)">+</a>
                                  </div>
                                </div>
                              </div>
                            </div>
                            <div class="col-paln-ai w-clearfix w-col w-col-3 w-col-small-3 w-col-tiny-6">
                              <div v-if="codigoPlan==1" class="cant-act-ai"v-cloak>{{adicional.CantidadFree}}</div>
                              <div v-if="codigoPlan==2" class="cant-act-ai"v-cloak>{{adicional.Cantidad}}</div>
                            </div>
                            <div class="col-paln-ai w-col w-col-3 w-col-small-3 w-col-tiny-6">
                              <div class="p-price-plan-calc-ai texto-tachado-plan-ai">US$19.99/mes</div>
                            </div>
                            <div class="col-paln-ai w-col w-col-3 w-col-small-3 w-col-tiny-6">
                              <div v-if="frecuenciaPago=='1'" class="p-price-plan-calc-ai" v-cloak>US${{adicional.Costo}}/mes</div>
                              <div v-if="frecuenciaPago=='2'" class="p-price-plan-calc-ai" v-cloak>US${{adicional.CostoMensual}}/mes</div>
                            </div>
                          </div>

                      </div>

                    </div>


                    <div class="div-info-pago-checko-ai new">
                      <h4 class="p-pago-adicio-ai" v-cloak>{{listaIdiomas.TituloInformacion}}</h4>
                      <div class="form-block-payment-ai w-form">
                        <div id="email-form" name="email-form" data-name="Email Form" method="get" class="form-pay-ai w-clearfix">
                            <label for="n-mero-de-tarjeta-3" class="lbl-pago-info-ai" v-cloak>{{listaIdiomas.NumeroTarjeta}}</label>
                            <img src="../images/tarjeta.svg" loading="lazy" width="28" alt="" class="icon-tarjeta-pago-ai">
                            <input type="text" class="input-info-pago-ai w-input" maxlength="256" name="num-tarjeta" data-name="num tarjeta" :placeholder="listaIdiomas.NumeroTarjetaPH" id="num-tarjeta" required="" v-model="numerotarjeta" onkeypress="return event.charCode>=48 && event.charCode<=57" @keyup="validardigitosnumerotarjeta()">
                          <div class="data-payment-ai month-ai w-clearfix">
                            <label for="fecha" class="lbl-pago-info-ai" v-cloak>{{listaIdiomas.FechaVencimiento}}</label>
                            <input type="text" class="input-info-pago-ai w-input" maxlength="5" name="fecha" data-name="fecha" placeholder="MM / AA" id="fecha" required="" v-model="fechaVencimiento" onkeypress="return event.charCode>=48 && event.charCode<=57" @keyup="validardigitosfechavencimiento()">
                          </div>
                          <div class="data-payment-ai w-clearfix">
                            <label for="Cvv-3" class="lbl-pago-info-ai">CVV</label>
                            <input type="text" class="input-info-pago-ai w-input" maxlength="4" name="Cvv" data-name="Cvv" placeholder="CVV" id="Cvv-3" required="" v-model="codigo" onkeypress="return event.charCode>=48 && event.charCode<=57">
                        </div>


                            <div class="data-payment-ai month-ai w-clearfix">
                            <label for="fecha" class="lbl-pago-info-ai" v-cloak>{{listaIdiomas.NombreTitular}}</label>
                            <input type="text" class="input-info-pago-ai w-input" maxlength="256" name="nombre" data-name="nombre" :placeholder="listaIdiomas.NombreTitularPH" id="nombre" required="" v-model="nombretitular">
                          </div>
                          <div class="data-payment-ai w-clearfix">
                            <label for="Cvv-3" class="lbl-pago-info-ai">Apellido del titular</label>
                            <input type="text" class="input-info-pago-ai w-input" maxlength="256" name="apellido" data-name="apellido" placeholder="Ingrese el apellido" id="apellido" required="" v-model="apellidotitular">
                        </div>


                        <%--<label for="nombre" class="lbl-pago-info-ai" v-cloak>{{listaIdiomas.NombreTitular}}</label>
                        <input type="text" class="input-info-pago-ai txt-titular w-input" maxlength="256" name="nombre" data-name="nombre" :placeholder="listaIdiomas.NombreTitularPH" id="nombre" required="" v-model="nombretitular">--%>
                        <label for="Paises-5" class="lbl-pago-info-ai" v-cloak>{{listaIdiomas.Pais}}</label>
                        
                            <input type="text" id="country5" autofocus="true" maxlength="80" name="email-2" data-name="Email 2" class="txt-registro-aii w-input"/>
                          <div class="data-payment-ai state-box-ai w-clearfix">
                            <label for="Estado-3" class="lbl-pago-info-ai" v-cloak>{{listaIdiomas.Estado}}</label>
                            <input type="text" class="input-info-pago-ai w-input" maxlength="256" name="Estado" data-name="Estado" :placeholder="listaIdiomas.EstadoPH" id="Estado-3" required="" v-model="estado">
                        </div>
                          <div class="data-payment-ai w-clearfix"><label for="Ciudad-3" class="lbl-pago-info-ai" v-cloak>{{listaIdiomas.Ciudad}}</label>
                            <input type="text" class="input-info-pago-ai w-input" maxlength="256" name="Ciudad" data-name="Ciudad" :placeholder="listaIdiomas.CiudadPH" id="Ciudad-3" required="" v-model="ciudad">
                        </div>
                        <label for="direcci-n-3" class="lbl-pago-info-ai lbl-direcc-ai" v-cloak>{{listaIdiomas.Direccion}}</label>
                        <textarea :placeholder="listaIdiomas.DireccionPH" maxlength="5000" id="direcci-n-3" name="direcci-n" data-name="dirección" required="" class="text-area-direcci-n-ai w-input" v-model="direccion">

                        </textarea>
                        </div>
                        <div class="w-form-done">
                          <div>Thank you! Your submission has been received!</div>
                        </div>
                        <div class="w-form-fail">
                          <div>Oops! Something went wrong while submitting the form.</div>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>

                <div id="w-node-a588be2f-9dbf-6828-1229-fdd6e88d7e0c-ea206ea8" class="div-colum-fixed">
                  <div class="div-checkout-orden-ai">
                    <div class="div-total-pago-ai">
                      <h5 class="p-pago-adicio-ai" v-cloak>{{listaIdiomas.TituloResumen}}</h5>
                      <div class="colums-order-ai cols-price-paln-ai w-row">
                        <div class="col-order-ai col-border-r-ai w-col w-col-6 w-col-small-6 w-col-tiny-6">
                          <div class="p-type-plan-ai" v-cloak>Plan Active ID Smart {{textoPlan}}</div>
                        </div>
                        <div class="col-order-ai col-precio-ai w-col w-col-6 w-col-small-6 w-col-tiny-6">
                          <div class="p-duration-plan-ai p-precio-ai" v-cloak>{{listaIdiomas.Precio}}</div>
                          <div class="p-price-plan-ai" v-cloak>US${{precio}}</div>
                        </div>
                      </div>

                      <div class="p-pago-adicio-ai" v-cloak>{{listaIdiomas.TituloAdicionales}}</div>
                      <div v-for="(adicionalseleccionado,index) in adicionalesseleccionados" :key="index">
                        <div class="coulms-plan-ai colums-adic-pago-ai w-row">
                            <div class="col-plan-ai col-ad-ai w-col w-col-4 w-col-small-3 w-col-tiny-6">
                            <div class="div-cant-compra-ai"></div>
                            <div class="p-adic-pag-ai" v-cloak>{{adicionalseleccionado.Nombre}}</div>
                            </div>
                            <div class="col-paln-ai col-ad-ai xx w-clearfix w-col w-col-2 w-col-small-3 w-col-tiny-6">
                            <div v-if="codigoPlan==1" class="cant-act-ai" v-cloak>{{adicionalseleccionado.CantidadFree}}</div>
                            <div v-if="codigoPlan==2" class="cant-act-ai" v-cloak>{{adicionalseleccionado.Cantidad}}</div>
                            </div>
                            <div class="col-paln-ai col-ad-ai w-col w-col-3 w-col-small-3 w-col-tiny-6">
                            <div class="p-price-plan-calc-ai texto-tachado-plan-ai">US$19.99/mes</div>
                            </div>
                            <div class="col-paln-ai col-ad-ai xx w-col w-col-3 w-col-small-3 w-col-tiny-6">
                            <div v-if="frecuenciaPago=='1'" class="p-price-plan-calc-ai" v-cloak>US${{adicionalseleccionado.Costo}}/mes</div>
                            <div v-if="frecuenciaPago=='2'" class="p-price-plan-calc-ai" v-cloak>US${{adicionalseleccionado.CostoMensual}}/mes</div>
                            </div>
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
                      <a href="#" v-bind:disabled="btnPagar" class="btn-pagar-orden-ai w-button" @click="ObtenerDatosRegistro" v-cloak>{{listaIdiomas.BtnPagar}} US${{totalpago}}</a>
                    </div>
                    <div class="div-type-compra-ai frec-pago-div-ai">
                      <h4 class="p-pago-adicio-ai" v-cloak>{{listaIdiomas.TituloFrecuenciaPago}}</h4>
                      <div class="coulms-plan-ai colums-frec-pago w-row">
                        <div class="col-plan-ai col-frec-ai w-col w-col-6 w-col-tiny-6">
                          <div class="formblock-plan-ai w-form">
                            <div id="email-form-2" name="email-form-2" data-name="Email Form 2" method="get" class="form-choose-plan-ai">
                                <label class="radio-wrap-plan-ai w-radio">
                                    <input type="radio" data-name="Radio 7" id="one" name="rbpago" value="1" class="w-form-formradioinput radio-plan-ai w-radio-input" v-model="frecuenciaPago" checked />
                                    <span class="label-plan-chosen-ai w-form-label" for="radio-7" v-cloak>{{listaIdiomas.MetodoAnual}}</span>
                                </label>
                            </div>
                            <div class="w-form-done">
                              <div>Thank you! Your submission has been received!</div>
                            </div>
                            <div class="w-form-fail">
                              <div>Oops! Something went wrong while submitting the form.</div>s
                            </div>
                          </div>
                        </div>
                        <div class="col-paln-ai col-cant-ai w-col w-col-6 w-col-tiny-6">
                          <div class="div-cant-compra-ai"></div>
                          <div class="formblock-plan-ai w-form">
                            <div id="email-form-2" name="email-form-2" data-name="Email Form 2" method="get" class="form-choose-plan-ai">
                                <label class="radio-wrap-plan-ai w-radio">
                                    <input type="radio" data-name="Radio 7" id="two" name="rbpago" value="2" class="w-form-formradioinput radio-plan-ai w-radio-input" v-model="frecuenciaPago" />
                                    <span class="label-plan-chosen-ai w-form-label" for="radio-7" v-cloak>{{listaIdiomas.MetodoMensual}}</span>
                                </label>
                            </div>
                            <div class="w-form-done">
                              <div>Thank you! Your submission has been received!</div>
                            </div>
                            <div class="w-form-fail">
                              <div>Oops! Something went wrong while submitting the form.</div>
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="footer-steps-ai">
      <div class="container-f-steps-ai w-container">
        <div class="footer-flex-container-2 f-flex-container-ai w-clearfix">
          <div class="f-block-ai w-clearfix w-form">
            <div id="email-form-4" name="email-form-4" data-name="Email Form 4" method="get" class="form-t-c-ai">
                <label class="w-checkbox checkbx-t-c-ai">
                    <input type="checkbox" id="checkbox-2" name="checkbox-2" data-name="Checkbox 2" checked="" required="" class="w-checkbox-input box-tyc-ai" v-model="terminoscondiciones">
                    <span class="lbl-t-c-ai w-form-label" for="checkbox-2">{{listaIdiomas.TerminosCondiciones}}</span></label></div>
            <div class="w-form-done">
              <div>Thank you! Your submission has been received!</div>
            </div>
            <div class="w-form-fail">
              <div>Oops! Something went wrong while submitting the form.</div>
            </div>
          </div>
          <div class="copy-f-ai">Copyright © 2022 Smart Costa, LLC. All rights reserved.</div>
        </div>
      </div>
    </div>
  </div>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script> 
    <script src="https://cdnjs.cloudflare.com/ajax/libs/country-select-js/2.1.1/js/countrySelect.min.js"></script>
  <script src="../js/webflow.js" type="text/javascript"></script>
  <!-- [if lte IE 9]><script src="https://cdnjs.cloudflare.com/ajax/libs/placeholders/3.0.2/placeholders.min.js"></script><![endif] -->
    <script src="../VisorActivos/Vue/vue.min.js"></script>
    <script src="../Recursos/SweetAlert/sweetalert2@11.js"></script>
  <script src="js/Contrato.js?v=1.2.4"></script>

</body>
</html>