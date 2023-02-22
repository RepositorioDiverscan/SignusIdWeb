<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionPlan.aspx.cs" Inherits="ActiveSmartWeb.RegistroUsuarioEmpresas.SeleccionPlan1" %>

<!DOCTYPE html><!--  This site was created in Webflow. https://www.webflow.com  -->
<!--  Last Published: Wed Feb 08 2023 17:16:11 GMT+0000 (Coordinated Universal Time)  -->
<html data-wf-page="6285344e3bd84536290239ef" data-wf-site="606dfb37871f33efa37244d4">
<head>
  <meta charset="utf-8">
  <title>planes</title>
  <meta content="planes" property="og:title">
  <meta content="planes" property="twitter:title">
  <meta content="width=device-width, initial-scale=1" name="viewport">
  <meta content="Webflow" name="generator">
  <link href="../css/normalize.css" rel="stylesheet" type="text/css">
  <link href="../css/webflow.css" rel="stylesheet" type="text/css">
  <link href="../css/signusid.webflow.css" rel="stylesheet" type="text/css">
  <link href="https://fonts.googleapis.com" rel="preconnect">
  <link href="https://fonts.gstatic.com" rel="preconnect" crossorigin="anonymous">
  <script src="https://ajax.googleapis.com/ajax/libs/webfont/1.6.26/webfont.js" type="text/javascript"></script>
  <script type="text/javascript">WebFont.load({  google: {    families: ["Lato:100,100italic,300,300italic,400,400italic,700,700italic,900,900italic","Montserrat:100,100italic,200,200italic,300,300italic,400,400italic,500,500italic,600,600italic,700,700italic,800,800italic,900,900italic"]  }});</script>
  <!-- [if lt IE 9]><script src="https://cdnjs.cloudflare.com/ajax/libs/html5shiv/3.7.3/html5shiv.min.js" type="text/javascript"></script><![endif] -->
  <script type="text/javascript">!function(o,c){var n=c.documentElement,t=" w-mod-";n.className+=t+"js",("ontouchstart"in o||o.DocumentTouch&&c instanceof DocumentTouch)&&(n.className+=t+"touch")}(window,document);</script>
  <link href="../images/favicon.ico" rel="shortcut icon" type="image/x-icon">
  <link href="../images/webclip.png" rel="apple-touch-icon">
</head>
<body>
  <div class="header-steps-payout-ai">
      <img src="../images/signus_id.png" loading="lazy" width="158" sizes="150px" srcset="../images/signus_id-p-500.png 500w, ../images/signus_id-p-800.png 800w, ../images/signus_id-p-1080.png 1080w, ../images/signus_id.png 1730w" alt="" class="logo-payout-ai"></div>
  <div class="contenedor-general">
    <div class="main" id="Planesidioma">
      <div class="section the-section-ai">
        <div class="container-2 contenedor-ai">
          <div class="w-layout-grid grid-8 grid-main grid-responsive-ai grid-lanscape">
            <div id="w-node-befa8641-e15e-9f5f-d2a9-3a27b1d91d91-290239ef" class="div-banner-extremo"></div>
            <div id="w-node-_8bcb824a-280b-2f87-1fcd-27d8923a468e-290239ef" class="div-center-ai">
              <div class="div-block-211 div-steps-ai"><img src="../images/Procesos-de-Compra-02.svg" loading="lazy" height="20" alt="" class="step2-ai"></div>
              <div class="div-top-title-ai w-clearfix">
                <a href="menu.html" class="link-block-back go-back-ai w-inline-block"></a>
                <h1 class="titulo-principal main-title-ai" v-cloak>{{listaIdiomas.Titulo}}</h1>
              </div>
              <div class="div-plans-cont-ai">
                <div class="w-layout-grid grid-planes-ai">
                  <div id="w-node-b20190d1-5103-5567-8fef-7c7cad418b30-290239ef" class="div-plan-ai">
                    <h3 class="titulo-plan-type-ai">free</h3>
                    <div class="div-descrip-ai">
                      <p class="p-desc-plan-ai" v-cloak>{{listaIdiomas.DescripcionFree}}</p>
                      <div class="text-type-price-ai">$0</div>
                      <div class="text-facturacion-ai" v-cloak>{{listaIdiomas.MontoUsuarioFree}}</div>
                      <div class="alance-plan-ai" v-cloak>{{listaIdiomas.FacturaFree}}</div>
                      <a href="#" class="btn-sus-plan-ai w-button" v-cloak v-on:click="FREE()">{{listaIdiomas.BtnFree}}</a>
                    </div>
                  </div>
                  <div id="w-node-_24092db5-e6d6-da26-3de5-73eec4e2e55d-290239ef" class="div-plan-ai">
                    <h3 class="titulo-plan-type-ai">basic</h3>
                    <div class="div-descrip-ai">
                      <p class="p-desc-plan-ai" v-cloak>{{listaIdiomas.DescripcionBasic}}</p>
                      <div class="text-type-price-ai">$75</div>
                      <div class="text-facturacion-ai" v-cloak>{{listaIdiomas.MontoUsuarioBasic}}</div>
                      <div class="alance-plan-ai" v-cloak>{{listaIdiomas.FacturaBasic}}</div>
                      <a href="#" class="btn-sus-plan-ai w-button" v-cloak v-on:click="BASIC()">{{listaIdiomas.BtnBasic}}</a>
                    </div>
                  </div>
                  <div id="w-node-_5b8fe47d-7c2f-89fb-e9f4-d931958a25dc-290239ef" class="div-plan-ai">
                    <h3 class="titulo-plan-type-ai">pro</h3>
                    <div class="div-descrip-ai">
                      <p class="p-desc-plan-ai" v-cloak>{{listaIdiomas.DescripcionPro}}</p>
                      <div class="text-type-price-ai">$150</div>
                      <div class="text-facturacion-ai" v-cloak>{{listaIdiomas.MontoUsuarioPro}}</div>
                      <div class="alance-plan-ai" v-cloak>{{listaIdiomas.FacturaPro}}</div>
                      <a href="#" class="btn-sus-plan-ai w-button" v-cloak v-on:click="PRO()">{{listaIdiomas.BtnPro}}</a>
                    </div>
                  </div>
                  <div id="w-node-_01c0ae54-b714-1851-f0c8-620771593690-290239ef" class="div-plan-ai">
                    <h3 class="titulo-plan-type-ai">business</h3>
                    <div class="div-descrip-ai">
                      <p class="p-desc-plan-ai" v-cloak>{{listaIdiomas.DescripcionBusiness}}</p>
                      <div class="text-type-price-ai">$300</div>
                      <div class="text-facturacion-ai" v-cloak>{{listaIdiomas.MontoUsuarioBusiness}}</div>
                      <div class="alance-plan-ai" v-cloak>{{listaIdiomas.FacturaBusiness}}</div>
                      <a href="#" class="btn-sus-plan-ai w-button" v-cloak v-on:click="BUSINESS()">{{listaIdiomas.BtnBusiness}}</a>
                    </div>
                  </div>
                </div>
              </div>
              <div class="div-monetizacion-ai">
                <div class="div-tabla-monetizacion-ai">
                  <div class="w-layout-grid grid-monetizacion-ai grid-mon-lands-ai">
                    <div id="w-node-_5598b4ff-6132-2aae-a5ab-e4bffb9807cb-290239ef" class="div-fila-monetizacion-ai header-main-top-fila-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai grid-head-top-ai">
                        <div id="w-node-_5598b4ff-6132-2aae-a5ab-e4bffb9807cd-290239ef" class="div-celda-mon-large-ai celda-fila-top-ai">
                          <div class="top-title-mon-ai heading-left-mon-ai">rubro</div>
                        </div>
                        <div id="w-node-_5598b4ff-6132-2aae-a5ab-e4bffb9807d0-290239ef" class="celda-mon-small-ai celda-fila-top-ai">
                          <div class="top-title-mon-ai">free</div>
                          <div class="currency-mon-ai">$0</div>
                          <div class="text-mon-ai">$0/ al mes</div>
                        </div>
                        <div id="w-node-_5598b4ff-6132-2aae-a5ab-e4bffb9807d7-290239ef" class="celda-mon-small-ai celda-fila-top-ai">
                          <div class="top-title-mon-ai">basic</div>
                          <div class="currency-mon-ai">$75</div>
                          <div class="text-mon-ai">$75/ al mes</div>
                        </div>
                        <div id="w-node-_5598b4ff-6132-2aae-a5ab-e4bffb9807de-290239ef" class="celda-mon-small-ai celda-fila-top-ai">
                          <div class="top-title-mon-ai">pro</div>
                          <div class="currency-mon-ai">$150</div>
                          <div class="text-mon-ai">$150 / al mes</div>
                        </div>
                      </div>
                    </div>
                    <div id="w-node-de5869d7-9741-1ecf-fa84-c13ce54d5e5e-290239ef" class="div-fila-monetizacion-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai">
                        <div id="w-node-_80e8b240-ef82-4814-b16b-fa420e070ddf-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">Registro de activos Básico</div>
                        </div>
                        <div id="w-node-b24ae6fb-7a14-002c-9104-d25e1cbef309-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-b93fe604-3e27-c232-c5c5-183a27b397ca-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-d4929bf6-abc5-e56b-b61e-e7d334d7885f-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-ca441577-5121-b200-768b-425f59eab751-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                      </div>
                    </div>
                    <div id="w-node-_9589514b-d5ec-49df-fcca-6efcd55f858f-290239ef" class="div-fila-monetizacion-ai color-fondo-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai">
                        <div id="w-node-_9589514b-d5ec-49df-fcca-6efcd55f8591-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">Registro  de activos Extendido</div>
                        </div>
                        <div id="w-node-_9589514b-d5ec-49df-fcca-6efcd55f8594-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_9589514b-d5ec-49df-fcca-6efcd55f8595-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_9589514b-d5ec-49df-fcca-6efcd55f8598-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_9589514b-d5ec-49df-fcca-6efcd55f859b-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                      </div>
                    </div>
                    <div id="w-node-_82a46883-0623-3a4c-eb14-eeaa88811b95-290239ef" class="div-fila-monetizacion-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai grid-3filas-mon-ai">
                        <div id="w-node-_82a46883-0623-3a4c-eb14-eeaa88811b97-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">Cantidad  de activos registrables</div>
                        </div>
                        <div id="w-node-_82a46883-0623-3a4c-eb14-eeaa88811b9a-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Hasta 50</div>
                        </div>
                        <div id="w-node-_82a46883-0623-3a4c-eb14-eeaa88811b9b-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-_82a46883-0623-3a4c-eb14-eeaa88811b9e-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_82a46883-0623-3a4c-eb14-eeaa88811ba1-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-b763d22a-539c-8510-067d-174efdb08c3b-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Hasta 500</div>
                        </div>
                        <div id="w-node-_8cf97407-baf1-4766-8c12-918e976965e2-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_61de5a97-b676-b303-ff49-f9652ba67c50-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-_458936f3-f6f5-6bb7-de2c-323c3deb5227-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_5e9fe9ea-7dde-4d47-1ec1-04454a4db6e5-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Hasta 1000</div>
                        </div>
                        <div id="w-node-c6020fbd-6016-e77b-2ae4-0255c5cceba5-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_814f6358-0236-3933-1284-24308090401e-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_277d5462-c1de-bfd3-9fac-f82f9329a7c7-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                      </div>
                    </div>
                    <div id="w-node-_5b786876-6ce7-a29a-7882-c7edc6a8538f-290239ef" class="div-fila-monetizacion-ai color-fondo-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai">
                        <div id="w-node-_5b786876-6ce7-a29a-7882-c7edc6a85391-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">Compra  de activos adicionales</div>
                        </div>
                        <div id="w-node-_5b786876-6ce7-a29a-7882-c7edc6a85394-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Ilimitado</div>
                        </div>
                        <div id="w-node-_5b786876-6ce7-a29a-7882-c7edc6a85395-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-_5b786876-6ce7-a29a-7882-c7edc6a85396-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-_5b786876-6ce7-a29a-7882-c7edc6a85397-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                      </div>
                    </div>
                    <div id="w-node-_415ba620-4569-88f2-abf7-ac1ad1e84774-290239ef" class="div-fila-monetizacion-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai grid-2filas-mon-ai">
                        <div id="w-node-_415ba620-4569-88f2-abf7-ac1ad1e84776-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">Ubicaciones  de 1 Nivel (A).</div>
                        </div>
                        <div id="w-node-_415ba620-4569-88f2-abf7-ac1ad1e84779-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Hasta 1</div>
                        </div>
                        <div id="w-node-_415ba620-4569-88f2-abf7-ac1ad1e8477c-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-_415ba620-4569-88f2-abf7-ac1ad1e8477f-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_415ba620-4569-88f2-abf7-ac1ad1e84782-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_00976a83-2249-a14c-5250-a095f2461cff-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Hasta 5</div>
                        </div>
                        <div id="w-node-_22485a11-c038-d7d7-7343-1d4122ddf488-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-b8fdce7e-4d84-e777-fb27-080d8c5d3b33-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-fc3cb1c8-92aa-f905-1d15-b5d1d2a8187c-290239ef" class="celda-mon-small-ai"></div>
                      </div>
                    </div>
                    <div id="w-node-a4eac8e8-6287-6776-854e-7cce97dc6093-290239ef" class="div-fila-monetizacion-ai color-fondo-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai">
                        <div id="w-node-a4eac8e8-6287-6776-854e-7cce97dc6095-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">Compra  de ubicaciones adicionales</div>
                        </div>
                        <div id="w-node-a4eac8e8-6287-6776-854e-7cce97dc6098-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Ilimitado</div>
                        </div>
                        <div id="w-node-a4eac8e8-6287-6776-854e-7cce97dc609b-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-a4eac8e8-6287-6776-854e-7cce97dc609e-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-a4eac8e8-6287-6776-854e-7cce97dc60a1-290239ef" class="celda-mon-small-ai"></div>
                      </div>
                    </div>
                    <div id="w-node-c8bbca91-bc19-68f8-c41f-0dc7032c5909-290239ef" class="div-fila-monetizacion-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai">
                        <div id="w-node-c8bbca91-bc19-68f8-c41f-0dc7032c590b-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">Ubicaciones  de 4 Niveles (A, B, C, y D)</div>
                        </div>
                        <div id="w-node-c8bbca91-bc19-68f8-c41f-0dc7032c590e-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Ilimitado</div>
                        </div>
                        <div id="w-node-c8bbca91-bc19-68f8-c41f-0dc7032c5911-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-c8bbca91-bc19-68f8-c41f-0dc7032c5914-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-c8bbca91-bc19-68f8-c41f-0dc7032c5917-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                      </div>
                    </div>
                    <div id="w-node-d35cbd9a-e305-3386-99a3-99692b8e05e6-290239ef" class="div-fila-monetizacion-ai color-fondo-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai grid-2filas-mon-ai">
                        <div id="w-node-d35cbd9a-e305-3386-99a3-99692b8e05e8-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">Carga  de activos</div>
                        </div>
                        <div id="w-node-d35cbd9a-e305-3386-99a3-99692b8e05eb-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Manual</div>
                        </div>
                        <div id="w-node-d35cbd9a-e305-3386-99a3-99692b8e05ee-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-d35cbd9a-e305-3386-99a3-99692b8e05f1-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-d35cbd9a-e305-3386-99a3-99692b8e05f2-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-d35cbd9a-e305-3386-99a3-99692b8e05f3-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Masiva</div>
                        </div>
                        <div id="w-node-d35cbd9a-e305-3386-99a3-99692b8e05f6-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-d35cbd9a-e305-3386-99a3-99692b8e05f7-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-d35cbd9a-e305-3386-99a3-99692b8e05fa-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                      </div>
                    </div>
                    <div id="w-node-daf8112f-824b-e80f-6d46-05c8271a6bab-290239ef" class="div-fila-monetizacion-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai">
                        <div id="w-node-daf8112f-824b-e80f-6d46-05c8271a6bad-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">Modificación  de activos</div>
                        </div>
                        <div id="w-node-daf8112f-824b-e80f-6d46-05c8271a6bb0-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-daf8112f-824b-e80f-6d46-05c8271a6bb3-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-daf8112f-824b-e80f-6d46-05c8271a6bb4-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-daf8112f-824b-e80f-6d46-05c8271a6bb5-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                      </div>
                    </div>
                    <div id="w-node-_2073ed75-f3e8-555b-901f-39f5bd7d73b6-290239ef" class="div-fila-monetizacion-ai color-fondo-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai grid-2filas-mon-ai">
                        <div id="w-node-_2073ed75-f3e8-555b-901f-39f5bd7d73b8-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">Tomas  físicas por mes, no acumulativas</div>
                        </div>
                        <div id="w-node-_2073ed75-f3e8-555b-901f-39f5bd7d73bb-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">1</div>
                        </div>
                        <div id="w-node-_2073ed75-f3e8-555b-901f-39f5bd7d73be-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-_2073ed75-f3e8-555b-901f-39f5bd7d73c1-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_2073ed75-f3e8-555b-901f-39f5bd7d73c4-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_2073ed75-f3e8-555b-901f-39f5bd7d73c7-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Ilimitado</div>
                        </div>
                        <div id="w-node-_2073ed75-f3e8-555b-901f-39f5bd7d73ca-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_2073ed75-f3e8-555b-901f-39f5bd7d73cb-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-_2073ed75-f3e8-555b-901f-39f5bd7d73ce-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                      </div>
                    </div>
                    <div id="w-node-_19592f08-f6c9-f5ea-14e2-1fe6c7b840df-290239ef" class="div-fila-monetizacion-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai grid-3filas-mon-ai">
                        <div id="w-node-_19592f08-f6c9-f5ea-14e2-1fe6c7b840e1-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">Reportes</div>
                        </div>
                        <div id="w-node-_19592f08-f6c9-f5ea-14e2-1fe6c7b840e4-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">1</div>
                        </div>
                        <div id="w-node-_19592f08-f6c9-f5ea-14e2-1fe6c7b840e7-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-_19592f08-f6c9-f5ea-14e2-1fe6c7b840ea-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_19592f08-f6c9-f5ea-14e2-1fe6c7b840eb-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_19592f08-f6c9-f5ea-14e2-1fe6c7b840ec-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">3</div>
                        </div>
                        <div id="w-node-_19592f08-f6c9-f5ea-14e2-1fe6c7b840ef-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_19592f08-f6c9-f5ea-14e2-1fe6c7b840f0-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-_19592f08-f6c9-f5ea-14e2-1fe6c7b840f3-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_19592f08-f6c9-f5ea-14e2-1fe6c7b840f4-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">5</div>
                        </div>
                        <div id="w-node-_19592f08-f6c9-f5ea-14e2-1fe6c7b840f7-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_19592f08-f6c9-f5ea-14e2-1fe6c7b840f8-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_19592f08-f6c9-f5ea-14e2-1fe6c7b840f9-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                      </div>
                    </div>
                    <div id="w-node-_5921f69a-0b8d-818f-c5b3-e9d81f47c19b-290239ef" class="div-fila-monetizacion-ai color-fondo-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai grid-2filas-mon-ai">
                        <div id="w-node-_5921f69a-0b8d-818f-c5b3-e9d81f47c19d-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">Dashboard</div>
                        </div>
                        <div id="w-node-_5921f69a-0b8d-818f-c5b3-e9d81f47c1a0-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Básico</div>
                        </div>
                        <div id="w-node-_5921f69a-0b8d-818f-c5b3-e9d81f47c1a3-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_5921f69a-0b8d-818f-c5b3-e9d81f47c1a6-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-_5921f69a-0b8d-818f-c5b3-e9d81f47c1a9-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-_5921f69a-0b8d-818f-c5b3-e9d81f47c1ac-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Profesional</div>
                        </div>
                        <div id="w-node-_5921f69a-0b8d-818f-c5b3-e9d81f47c1af-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_5921f69a-0b8d-818f-c5b3-e9d81f47c1b0-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_5921f69a-0b8d-818f-c5b3-e9d81f47c1b3-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                      </div>
                    </div>
                    <div id="w-node-_0254431c-fe90-4fc8-3ca8-ee7429679cf5-290239ef" class="div-fila-monetizacion-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai grid-2filas-mon-ai">
                        <div id="w-node-_0254431c-fe90-4fc8-3ca8-ee7429679cf7-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">Personal  para asignar activos</div>
                        </div>
                        <div id="w-node-_0254431c-fe90-4fc8-3ca8-ee7429679cfa-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Hasta 2</div>
                        </div>
                        <div id="w-node-_0254431c-fe90-4fc8-3ca8-ee7429679cfd-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_0254431c-fe90-4fc8-3ca8-ee7429679d00-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-_0254431c-fe90-4fc8-3ca8-ee7429679d03-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_0254431c-fe90-4fc8-3ca8-ee7429679d06-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Hasta 10</div>
                        </div>
                        <div id="w-node-_0254431c-fe90-4fc8-3ca8-ee7429679d09-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_0254431c-fe90-4fc8-3ca8-ee7429679d0a-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_0254431c-fe90-4fc8-3ca8-ee7429679d0d-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                      </div>
                    </div>
                    <div id="w-node-_9572c57b-dbc3-1cd4-47b5-4fa8918bc0d2-290239ef" class="div-fila-monetizacion-ai color-fondo-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai">
                        <div id="w-node-_9572c57b-dbc3-1cd4-47b5-4fa8918bc0d4-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">Compra  de personal adicional</div>
                        </div>
                        <div id="w-node-_9572c57b-dbc3-1cd4-47b5-4fa8918bc0d7-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Ilimitado</div>
                        </div>
                        <div id="w-node-_9572c57b-dbc3-1cd4-47b5-4fa8918bc0d8-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_9572c57b-dbc3-1cd4-47b5-4fa8918bc0d9-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-_9572c57b-dbc3-1cd4-47b5-4fa8918bc0dc-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                      </div>
                    </div>
                    <div id="w-node-_19dc14d2-9136-0f73-0403-8d344d34c666-290239ef" class="div-fila-monetizacion-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai grid-2filas-mon-ai">
                        <div id="w-node-_19dc14d2-9136-0f73-0403-8d344d34c668-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">Roles  y permisos</div>
                        </div>
                        <div id="w-node-_19dc14d2-9136-0f73-0403-8d344d34c66b-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Básico</div>
                        </div>
                        <div id="w-node-_19dc14d2-9136-0f73-0403-8d344d34c66e-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_19dc14d2-9136-0f73-0403-8d344d34c66f-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-_19dc14d2-9136-0f73-0403-8d344d34c672-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-_19dc14d2-9136-0f73-0403-8d344d34c673-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Profesional</div>
                        </div>
                        <div id="w-node-_19dc14d2-9136-0f73-0403-8d344d34c676-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_19dc14d2-9136-0f73-0403-8d344d34c677-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_19dc14d2-9136-0f73-0403-8d344d34c678-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                      </div>
                    </div>
                    <div id="w-node-da96086f-3bea-cf40-b8a3-b705a0919b91-290239ef" class="div-fila-monetizacion-ai color-fondo-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai grid-2filas-mon-ai">
                        <div id="w-node-da96086f-3bea-cf40-b8a3-b705a0919b93-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">Gestión  de servicio</div>
                        </div>
                        <div id="w-node-da96086f-3bea-cf40-b8a3-b705a0919b96-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Básico</div>
                        </div>
                        <div id="w-node-da96086f-3bea-cf40-b8a3-b705a0919b99-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-da96086f-3bea-cf40-b8a3-b705a0919b9a-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-da96086f-3bea-cf40-b8a3-b705a0919b9d-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-da96086f-3bea-cf40-b8a3-b705a0919b9e-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Profesional</div>
                        </div>
                        <div id="w-node-da96086f-3bea-cf40-b8a3-b705a0919ba1-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-da96086f-3bea-cf40-b8a3-b705a0919ba2-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-da96086f-3bea-cf40-b8a3-b705a0919ba3-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                      </div>
                    </div>
                    <div id="w-node-_7321e758-7300-3c11-58f2-b70c9861a301-290239ef" class="div-fila-monetizacion-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai">
                        <div id="w-node-_7321e758-7300-3c11-58f2-b70c9861a303-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">APP  móvil de gestión de inventario</div>
                        </div>
                        <div id="w-node-_7321e758-7300-3c11-58f2-b70c9861a306-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-_7321e758-7300-3c11-58f2-b70c9861a309-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-_7321e758-7300-3c11-58f2-b70c9861a30a-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-_7321e758-7300-3c11-58f2-b70c9861a30d-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                      </div>
                    </div>
                    <div id="w-node-de1157b7-f7e6-b5c6-bc81-c40e726f3afd-290239ef" class="div-fila-monetizacion-ai color-fondo-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai grid-2filas-mon-ai">
                        <div id="w-node-de1157b7-f7e6-b5c6-bc81-c40e726f3aff-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">APP  móvil de usuario</div>
                        </div>
                        <div id="w-node-de1157b7-f7e6-b5c6-bc81-c40e726f3b02-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Básico</div>
                        </div>
                        <div id="w-node-de1157b7-f7e6-b5c6-bc81-c40e726f3b05-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-de1157b7-f7e6-b5c6-bc81-c40e726f3b06-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-de1157b7-f7e6-b5c6-bc81-c40e726f3b09-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-de1157b7-f7e6-b5c6-bc81-c40e726f3b0c-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Profesional</div>
                        </div>
                        <div id="w-node-de1157b7-f7e6-b5c6-bc81-c40e726f3b0f-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-de1157b7-f7e6-b5c6-bc81-c40e726f3b10-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-de1157b7-f7e6-b5c6-bc81-c40e726f3b11-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                      </div>
                    </div>
                    <div id="w-node-e91aa659-db8b-8d96-0317-28d0939fc2aa-290239ef" class="div-fila-monetizacion-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai grid-3filas-mon-ai">
                        <div id="w-node-e91aa659-db8b-8d96-0317-28d0939fc2ac-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">Usuarios  Gestores del sistema</div>
                        </div>
                        <div id="w-node-e91aa659-db8b-8d96-0317-28d0939fc2af-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">1</div>
                        </div>
                        <div id="w-node-e91aa659-db8b-8d96-0317-28d0939fc2b2-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-e91aa659-db8b-8d96-0317-28d0939fc2b5-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-e91aa659-db8b-8d96-0317-28d0939fc2b6-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-e91aa659-db8b-8d96-0317-28d0939fc2b7-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">3</div>
                        </div>
                        <div id="w-node-e91aa659-db8b-8d96-0317-28d0939fc2ba-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-e91aa659-db8b-8d96-0317-28d0939fc2bb-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                        <div id="w-node-e91aa659-db8b-8d96-0317-28d0939fc2be-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-e91aa659-db8b-8d96-0317-28d0939fc2bf-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">5</div>
                        </div>
                        <div id="w-node-e91aa659-db8b-8d96-0317-28d0939fc2c2-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-e91aa659-db8b-8d96-0317-28d0939fc2c3-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-e91aa659-db8b-8d96-0317-28d0939fc2c4-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                      </div>
                    </div>
                    <div id="w-node-f3c8d261-a4a8-642a-db99-b1a89ecd4a29-290239ef" class="div-fila-monetizacion-ai color-fondo-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai">
                        <div id="w-node-f3c8d261-a4a8-642a-db99-b1a89ecd4a2b-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">Compra  de Usuarios Gestores del sistema adicionales.</div>
                        </div>
                        <div id="w-node-f3c8d261-a4a8-642a-db99-b1a89ecd4a2e-290239ef" class="celda-mon-small-ai">
                          <div class="text-rubro-mon-ai">Ilimitado</div>
                        </div>
                        <div id="w-node-f3c8d261-a4a8-642a-db99-b1a89ecd4a31-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-f3c8d261-a4a8-642a-db99-b1a89ecd4a32-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-f3c8d261-a4a8-642a-db99-b1a89ecd4a35-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                      </div>
                    </div>
                    <div id="w-node-e3448590-f3e8-bf04-3276-54ac285bf441-290239ef" class="div-fila-monetizacion-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai">
                        <div id="w-node-e3448590-f3e8-bf04-3276-54ac285bf443-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">RFID</div>
                        </div>
                        <div id="w-node-e3448590-f3e8-bf04-3276-54ac285bf446-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-e3448590-f3e8-bf04-3276-54ac285bf449-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-e3448590-f3e8-bf04-3276-54ac285bf44a-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-e3448590-f3e8-bf04-3276-54ac285bf44d-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                      </div>
                    </div>
                    <div id="w-node-f15b07d3-d093-23c7-7dd0-257e8c7fe6c2-290239ef" class="div-fila-monetizacion-ai color-fondo-ai">
                      <div class="w-layout-grid grid-mon-celdas-ai">
                        <div id="w-node-f15b07d3-d093-23c7-7dd0-257e8c7fe6c4-290239ef" class="div-celda-mon-large-ai">
                          <div class="text-cel-mon-desc-ai">Fotografía  de activos.</div>
                        </div>
                        <div id="w-node-f15b07d3-d093-23c7-7dd0-257e8c7fe6c7-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-f15b07d3-d093-23c7-7dd0-257e8c7fe6ca-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-f15b07d3-d093-23c7-7dd0-257e8c7fe6cb-290239ef" class="celda-mon-small-ai"></div>
                        <div id="w-node-f15b07d3-d093-23c7-7dd0-257e8c7fe6ce-290239ef" class="celda-mon-small-ai">
                          <div class="div-icon-check-ai"><img src="../images/checkGray.svg" loading="lazy" alt="" class="img-mon-check-ai"></div>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div id="w-node-_6aac1572-0764-b60d-f5b2-b6f857fd1574-290239ef" class="div-banner-extremo"></div>
          </div>
        </div>
      </div>
    </div>
    <div class="footer-copy-righ-suscripcion">
      <div class="container-copyright-footer w-container">
        <div class="texto-copyright">Copyright © 2022 Smart Costa, LLC. All rights reserved.</div>
        <div class="text-block-26">
        </div>
      </div>
    </div>
  </div>

    <script src="../Recursos/Vue/vue.js"></script>
    <script src="../Recursos/JQuery/jquery-3.5.1.min.dc5e7f18c8.js"></script>
    <script src="../js/webflow.js"></script>
    <script src="js/Planes.js"></script>

</body>
</html>
