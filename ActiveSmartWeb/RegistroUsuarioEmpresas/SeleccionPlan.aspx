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
  <link href="../images/logo-02.png" rel="shortcut icon" type="image/x-icon">
  <link href="../images/logo-02.png" rel="apple-touch-icon">

    <style>
        .button-4:hover {
           background-color: #ebbb00 !important; 
        }
    </style>

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

              <div class="div-top-title-ai">
                <h1 class="titulo-principal main-title-ai" v-cloak>{{listaIdiomas.Titulo}}</h1>
                <div class="div-block-237">
                  <a href="#" id="btnAnual" class="button-4 w-button" @click="CambiarFrecuenciaPlanAnual()">Anual</a>
                  <a href="#" id="btnMensual" class="button-5 w-button" @click="CambiarFrecuenciaPlanMensual()">Mensual</a>
                </div>
              </div>

              <div class="div-plans-cont-ai">
                <div class="w-layout-grid grid-planes-ai">


                  <div id="w-node-b20190d1-5103-5567-8fef-7c7cad418b30-290239ef" class="div-plan-ai">
                    <h3 class="titulo-plan-type-ai">free</h3>
                    <div id="w-node-_3110ed63-6f15-f357-6e01-be624e4386bb-290239ef">
                      <a href="#" class="btn-sus-plan-ai w-button" v-cloak v-on:click="FREE()">{{listaIdiomas.BtnFree}}</a>
                    </div>
                    <div id="w-node-_7ab6188d-aefe-cf2a-1e8f-69c54d0f6f9a-290239ef" class="text-facturacion-ai" v-cloak>{{listaIdiomas.MontoUsuarioFree}}<br>‍</div>
                    <div class="text-type-price-ai">$0</div>
                    <p id="w-node-_92eaee5a-a10f-a1d3-3b50-19356d40d8cb-290239ef" class="p-desc-plan-ai" v-cloak>{{listaIdiomas.DescripcionFree}}</p>
                  </div>              


                  <div id="w-node-_24092db5-e6d6-da26-3de5-73eec4e2e55d-290239ef" class="div-plan-ai">
                    <h3 class="titulo-plan-type-ai">basic</h3>
                    <div id="w-node-_770370cc-47ba-47e0-07b7-615b1b75e3e9-290239ef">
                      <a href="#" class="btn-sus-plan-ai w-button" v-cloak v-on:click="BASIC()">{{listaIdiomas.BtnBasic}}</a>
                    </div>
                    <div id="w-node-_4aee93ca-5135-cb53-b2dc-d895f7f6998b-290239ef" class="alance-plan-ai"></div>
                    <div id="w-node-_6d68c22a-6945-7184-f66c-5bf75f0b5635-290239ef" class="text-facturacion-ai" v-cloak>{{listaIdiomas.MontoUsuarioBasic}}<br v-cloak>{{listaIdiomas.FacturaBasic}}</div>
                    <div class="text-type-price-ai" id="basicPrecio" >$14.99</div>
                    <p id="w-node-_925c7339-1ea8-959f-bf04-fa774fddce6b-290239ef" class="p-desc-plan-ai" v-cloak>{{listaIdiomas.DescripcionBasic}}</p>
                  </div>


                  <div id="w-node-_5b8fe47d-7c2f-89fb-e9f4-d931958a25dc-290239ef" class="div-plan-ai">
                    <h3 class="titulo-plan-type-ai">pro</h3>
                    <div id="w-node-ab682563-28ba-3ea9-10cd-b7c4289a8794-290239ef">                     
                      <a href="#" class="btn-sus-plan-ai w-button" v-cloak v-on:click="PRO()">{{listaIdiomas.BtnPro}}</a>
                    </div>
                    <div id="w-node-fe6a28ce-3ad0-8a53-e3a9-91a5c8f724c6-290239ef" class="text-facturacion-ai"v-cloak>{{listaIdiomas.MontoUsuarioPro}}<br>‍</div>
                    <div class="text-type-price-ai"v-cloak>{{listaIdiomas.FacturaPro}}</div>
                    <p id="w-node-_16301317-6e5f-515a-53fb-828d99d608ed-290239ef" class="p-desc-plan-ai" v-cloak>{{listaIdiomas.DescripcionPro}}</p>
                  </div>


                  <div id="w-node-_01c0ae54-b714-1851-f0c8-620771593690-290239ef" class="div-plan-ai">
                    <h3 class="titulo-plan-type-ai">buSineSs</h3>
                    <div id="w-node-efb82b03-3cc6-42c1-b94c-45f349b2cd97-290239ef">
                      <div class="text-type-price-ai">$300</div>
                    </div>
                    <div id="w-node-_36c11641-0617-b84f-0105-f20f8fe746e5-290239ef">
                      <div class="text-facturacion-ai" v-cloak>{{listaIdiomas.MontoUsuarioBusiness}}</div>
                      <div class="text-facturacion-ai" v-cloak>{{listaIdiomas.FacturaBusiness}}</div>
                    </div>
                    <div id="w-node-b5c6f485-40eb-16df-80e4-b045fae44363-290239ef">
                      <a href="#" class="btn-sus-plan-ai w-button" v-cloak v-on:click="BUSINESS()">{{listaIdiomas.BtnBusiness}}</a>
                    </div>
                    <p class="p-desc-plan-ai" v-cloak>{{listaIdiomas.DescripcionBusiness}}</p>
                  </div>
                
                
                </div>

                <div>
                    <img src="../images/rubros signus id-01.png" loading="lazy" width="1008" sizes="(max-width: 991px) 180.00001525878906px, 18vw" alt="">
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
          <a href="#" class="link-3">Cancelar suscripción</a>
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
