<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/SiteMasterInicio.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ActiveSmartWeb.Login.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div id="paglogin"> 
     <div class="pop-up-empresa" :style="{display: display}">
    <div class="div-empresa">
      <div class="form-block-empresa w-form">
        <div id="email-form-2" name="email-form-2" data-name="Email Form 2">
            <select v-model="empresa" class="select-field empresa w-select" @change="establecerempresa">
             <option  v-for="emp in empresas" v-bind:value="emp.IdPerfilEmpresa">{{emp.NombreEmpresa}}</option>
          </select></div>
      </div>
    </div>
  </div>
    <div class="main">
      <div class="section-campa-a wf-section">
            <div class="container-campaa tab w-container">
                <div class="div-block-campa-a der">
                    <div class="centro-de-recursos">{{listaidiomalogin.CtroRecursos}}</div>
                    <a href="#" class="nombre-recurso w-inline-block">{{listaidiomalogin.CuidArch}}</a>
                </div>
            </div>
            <div class="div-block-prueba der">
                <a href="#" class="boton-compra w-button">{{listaidiomalogin.BtnPruebFree}}</a>
                <a href="#" class="boton-compra w-button">{{listaidiomalogin.BtnVeDemo}}</a>
            </div>
            <div class="div-block-prueba izq">
                <a href="../RegistroUsuarioEmpresas/RegistroUsuariosEmpresas.aspx" class="boton-compra compra w-button">{{listaidiomalogin.Suscrib}}</a>
            </div>
        </div>
      <div class="section-banner-animado wf-section">
        <div class="w-layout-grid">
          <div id="w-node-_59f26435-a030-9f74-024a-595142f3f928-1d7244d5" class="form-block-8 w-form">
           
            <login :password="password" :email ="email" :listaidiomalogin="listaidiomalogin" :idiomaLogin="idiomaLogin"></login>
  
          </div>
          <div id="w-node-_69982091-82f8-4580-e5a1-162a8f6b28ce-1d7244d5" class="div-banner-animado">
            <img src="../images/Banner_Active_ID_Smart_1.gif" loading="lazy" alt=""></div>
        </div>
      </div>

      <div class="section-presentacion wf-section">
        <div class="container-6 w-container">
          <div class="div-presentacion">
              <h1 class="heading-inicial">{{listaidiomalogin.TitActFij}}</h1>
              <h2 class="h2-promo-texto"><strong class="bold-text">{{listaidiomalogin.Aprov}}</strong></h2>
              <p class="paragraph-presentacion">{{listaidiomalogin.Msj1}}</p>
          </div>
        </div>
      </div>   
      <div class="section-presentacion wf-section">
        <div class="container w-container">
          <div class="colums w-row">
            <div class="column-presentation w-col w-col-4">
              <img src="../images/acces-o_activeIDsmart_automatice.jpg" loading="lazy" alt="Manos sostienen un teléfono Móvil  mientras revisa sus activos actualizados en el app de Active ID Smart." class="image-colum">
              <h2 class="title-colum">{{listaidiomalogin.Registre}}</h2>
              <p class="paragraph-colum">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse varius enim in eros elementum tristique. Duis cursus, mi quis viverra ornare, eros dolor interdum nulla, ut commodo diam libero vitae erat. Aenean faucibus nibh et justo cursus id rutrum lorem imperdiet. Nunc ut sem vitae risus tristique posuere.</p>
            </div>
            <div class="column-presentation w-col w-col-4">
              <img src="../images/active_ID_smart_partners_carousel_gosocket.png" loading="lazy" alt="Go Socket Logo" class="image-colum">
              <h2 class="title-colum">{{listaidiomalogin.Controle}}</h2>
              <p class="paragraph-colum">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse varius enim in eros elementum tristique. Duis cursus, mi quis viverra ornare, eros dolor interdum nulla, ut commodo diam libero vitae erat. Aenean faucibus nibh et justo cursus id rutrum lorem imperdiet. Nunc ut sem vitae risus tristique posuere.</p>
            </div>
            <div class="column-presentation w-col w-col-4">
               <img src="../images/acces-o_activeIDsmart_controle.jpg" loading="lazy" alt="Una mano sostiene un lapiz mientras marca sus activos registrados" class="image-colum">
              <h2 class="title-colum">{{listaidiomalogin.Automatice}}</h2>
              <p class="paragraph-colum">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse varius enim in eros elementum tristique. Duis cursus, mi quis viverra ornare, eros dolor interdum nulla, ut commodo diam libero vitae erat. Aenean faucibus nibh et justo cursus id rutrum lorem imperdiet. Nunc ut sem vitae risus tristique posuere.</p>
            </div>
          </div>
          <div class="w-layout-grid grid-diagonal">
            <div data-w-id="937a3a74-a632-ef2c-fcb9-3127688f07c3" class="div-contenedor-diagonal">
              <img src="../images/acces-o_activeIDsmart_registre.jpg" loading="lazy" alt="Mano con handheld realiza lectura_RFID sobre un activo" width="275" class="image-diagonal">
              <a href="#" class="contenedor-texto-diagonal w-inline-block">
                <h2 class="title-colum">{{listaidiomalogin.Registre}}</h2>
              </a>
              <div class="div-info-diagonal" style="transform: translate3d(0px, -1%, 0px) scale3d(1, 1, 1) rotateX(0deg) rotateY(0deg) rotateZ(0deg) skew(0deg, 0deg); transform-style: preserve-3d;">
                <div class="contenedor-info-diagonal">
                  <h1 class="title-colum">{{listaidiomalogin.Registre}}</h1>
                  <p class="parrafo-diagonal">{{listaidiomalogin.MsjSuminist}}</p>
                </div>
                <div class="div-degrado-diagonal">
                  <a href="#" class="link-2">{{listaidiomalogin.Sabermas}}</a>
                </div>
              </div>
            </div>
            <div data-w-id="937a3a74-a632-ef2c-fcb9-3127688f07d1" class="div-contenedor-diagonal">
              <img src="../images/acces-o_activeIDsmart_controle.jpg" loading="lazy" alt="Una mano verifica la lista de activos registrados" class="image-diagonal">
              <a href="#" class="contenedor-texto-diagonal w-inline-block">
                <h2 class="title-colum">{{listaidiomalogin.Controle}}</h2>
              </a>
              <div class="div-info-diagonal">
                <div class="contenedor-info-diagonal">
                  <h1 class="title-colum">{{listaidiomalogin.Controle}}</h1>
                  <p class="parrafo-diagonal">Tarjetas de identificación para su Empresa.</p>
                </div>
                <div class="div-degrado-diagonal">
                  <a href="#" class="link-2">{{listaidiomalogin.Sabermas}}</a>
                </div>
              </div>
            </div>
            <div data-w-id="937a3a74-a632-ef2c-fcb9-3127688f07df" class="div-contenedor-diagonal">
                <img src="../images/acces-o_activeIDsmart_automatice.jpg" loading="lazy" width="150" alt="Manos sostienen un teléfono móvil mientras utiliza aplicación de acces-o para identificar activos automáticamente." class="image-diagonal">
              <a href="#" class="contenedor-texto-diagonal w-inline-block">
                <h2 class="title-colum auto">{{listaidiomalogin.Automatice}}</h2>
              </a>
              <div class="div-info-diagonal">
                <div class="contenedor-info-diagonal">
                  <h1 class="title-colum">{{listaidiomalogin.Automatice}}</h1>
                  <p class="parrafo-diagonal">Servicio en Sitio, Contratos, Diagnóstico y Reparación.</p>
                </div>
                <div class="div-degrado-diagonal">
                  <a href="#" class="link-2">{{listaidiomalogin.Sabermas}}</a>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="section-presentacion wf-section">
        <div class="container w-container">
          <div class="w-layout-grid grid-descubra">
            <h2 id="w-node-_4beaf352-2021-c1d6-e6fe-6f8df04a27bd-1d7244d5" class="heading-grid-descubra">{{listaidiomalogin.Titulo2}}</h2>
            <div id="w-node-_4cb27d67-2717-a12a-1e63-866b68dc2bbd-1d7244d5" class="tarjeta-2">
               <img src="../images/activeID_sector_distribucion.png" loading="lazy" alt="dibujo de camión realizando distribución de activos por mapa" width="135" class="image-colum">
              <h3 class="titulo-tarjeta dist">{{listaidiomalogin.Distribucion}}</h3>
              <p class="paragraph-tarjeta">{{listaidiomalogin.MsjDistribucion}}</p>
            </div>
            <div id="w-node-_7cc4a488-dc7a-1a40-dc99-3b8382bd9060-1d7244d5" class="tarjeta-2">
               <img src="../images/activeID_sector_produccion.png" loading="lazy" width="135" alt="Imagen de Fabrica dedicada al sector de producción de activos " class="image-colum">
              <h3 class="titulo-tarjeta prod">{{listaidiomalogin.Produccion}}</h3>
              <p class="paragraph-tarjeta">{{listaidiomalogin.MsjProduccion}}</p>
            </div>
            <div id="w-node-a7063d94-57dd-c998-0739-1757a305b9c7-1d7244d5" class="tarjeta-2">
              <img src="../images/activeID_sector_servicios.png" loading="lazy" alt="laptop muestra servicios de mantenimiento de activos" class="image-colum">
              <h3 class="titulo-tarjeta serv">{{listaidiomalogin.Servicios}}</h3>
              <p class="paragraph-tarjeta">{{listaidiomalogin.MsjServicios}}</p>
            </div>
            <div id="w-node-_06224b09-ade5-6a0c-d584-2d5966897b3d-1d7244d5" class="tarjeta-2">
              <img src="../images/activeID_sector_salud.png" loading="lazy" alt="Imagen representando el sector de salud con ambulancia frente hospital y corazón saludable desplegado al fondo" class="image-colum">
              <h3 class="titulo-tarjeta sal">{{listaidiomalogin.Salud}}</h3>
              <p class="paragraph-tarjeta">{{listaidiomalogin.MsjSalud}}</p>
            </div>
            <div id="w-node-_9bef926d-aee1-1f80-a35e-640384b4878a-1d7244d5" class="tarjeta-2">
              <img src="../images/activeID_sector_educacion.png" loading="lazy" alt="Mapamundi y libros como representación del sector educativo " class="image-colum">
              <h3 class="titulo-tarjeta educ">{{listaidiomalogin.Educacion}}</h3>
              <p class="paragraph-tarjeta">{{listaidiomalogin.MsjEducacion}}</p>
            </div>
            <div id="w-node-_17068e2f-d79c-d9e4-2f3b-d888fb5040b9-1d7244d5" class="tarjeta-2">
              <img src="../images/activeID_sector_financiero.png" loading="lazy" alt="Mano sostiene en su palma abierta el símbolo de dólar y el incremento de ingresos del sector financiero." class="image-colum">
              <h3 class="titulo-tarjeta finan">{{listaidiomalogin.Financiero}}</h3>
              <p class="paragraph-tarjeta">{{listaidiomalogin.MsjFinanciero}}</p>
            </div>
            <div id="w-node-f6d7c650-3a85-03ac-23ab-d546b50d8e72-1d7244d5" class="tarjeta-2">
              <img src="../images/activeID_sector_agricola-Industrial.png" loading="lazy" alt="Imagen de granja con modernos molinos de viento y tractor representando el sector agrícola industrial" width="135" class="image-colum">
              <h3 class="titulo-tarjeta agri">{{listaidiomalogin.Agricola}}</h3>
              <p class="paragraph-tarjeta">{{listaidiomalogin.MsjAgricola}}</p>
            </div>
            <div id="w-node-d6bdc4f3-dd8a-2e63-6a45-128658b79909-1d7244d5" class="tarjeta-2">
              <img src="../images/activeID_sector_turismo.png" loading="lazy" width="259" alt="Imagen de cámara fotográfica y equipaje y viaje en avión y de la estatua de la libertad representando el sector turístico " class="image-colum">
              <h3 class="titulo-tarjeta turis">{{listaidiomalogin.Turismo}}</h3>
              <p class="paragraph-tarjeta">{{listaidiomalogin.MsjTurismo}}</p>
            </div>
          </div>
        </div>
      </div>   

      <div class="section-banner-video wf-section">
        <div class="container-5 w-container">
          <div class="w-layout-grid grid-banner-video">
            <div id="w-node-f12f28ac-c677-93be-3972-b43fc32f30a6-1d7244d5" class="div-degrado-banner"></div>
            <div id="w-node-f12f28ac-c677-93be-3972-b43fc32f30a7-1d7244d5" class="diagonal-amarillo"></div>
            <div id="w-node-f12f28ac-c677-93be-3972-b43fc32f30a8-1d7244d5" class="div-diagonal-gris"></div>
            <div id="w-node-f12f28ac-c677-93be-3972-b43fc32f30a9-1d7244d5" class="div-background-video">
              <div data-poster-url="videos/ZebraCenter_video-poster-00001.jpg" data-video-urls="videos/ZebraCenter_video-transcode.mp4,videos/ZebraCenter_video-transcode.webm" data-autoplay="true" data-loop="true" data-wf-ignore="true" id="Products_video" class="background-video w-background-video w-background-video-atom"><video autoplay="" loop="" style="background-image:url(&quot;videos/ZebraCenter_video-poster-00001.jpg&quot;)" muted="" playsinline="" data-wf-ignore="true" data-object-fit="cover">
                  <source src="../images/videos/ZebraCenter_video-transcode.mp4" data-wf-ignore="true">
                  <source src="../images/videos/ZebraCenter_video-transcode.webm" data-wf-ignore="true">
                </video></div>
            </div>
            <div id="w-node-f12f28ac-c677-93be-3972-b43fc32f30ab-1d7244d5" class="div-text-banner-video">
              <div class="div-text-paquete">
                <div class="div-title-paquetes">
                  <img src="../images/Icono_ActiveID_Smart-Basic.svg" loading="lazy" alt="Imagen de Icono Active-ID-Smart_basico" class="icono-basic-peque">
                  <h1 class="active-id-smart">Active ID Smart</h1>
                  <h1 class="basic">BASIC</h1>
                <img src="../images/Logo_ActiveID_Smart_Basic.svg" loading="lazy" width="300" alt="Logo_activeIDsmart_basic" class="logo_activeid-basic">
                </div>
                <p class="paragraph-paquete">{{listaidiomalogin.MsjVersBasic}}</p>
                <a href="basico.html" class="button-more-info w-button">{{listaidiomalogin.Masinfo}}</a>
                <a href="#" class="button-activeid w-button">{{listaidiomalogin.Suscrib}}</a>
              </div>
            </div>
            <div id="w-node-df94e58f-99ae-3057-5fc3-6f3572e7080e-1d7244d5" class="div-text-banner-video">
              <div class="div-text-paquete">
                <div class="div-title-paquetes">
                 <img src="../images/Icono_ActiveID_Smart-Pro.svg" loading="lazy" alt="Icono de Active-ID-Smart_Pro_Logo" class="icono-basic-peque">
                  <h1 class="active-id-smart">Active ID Smart</h1>
                  <h1 class="basic">PRO</h1>
                <img src="../images/Logo_ActiveID_Smart_Pro.svg" loading="lazy" width="300" alt="Logo_activeIDsmart_Pro" class="logo_activeid-pro">
                </div>
                <p class="paragraph-paquete">{{listaidiomalogin.MsjVersPro}}</p>
                <a href="pro.html" class="button-more-info w-button">{{listaidiomalogin.Masinfo}}</a>
                <a href="#" class="button-activeid w-button">{{listaidiomalogin.Suscrib}}</a>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="section-carousel wf-section">
        <div class="w-container">
          <div data-delay="3000" data-animation="slide" data-autoplay="1" data-nav-spacing="5" data-duration="500" data-infinite="1" class="slider-2 clients w-slider" role="region" aria-label="carousel">
            <div class="div-block-clientes-head">
              <div class="text-block-20">{{listaidiomalogin.Testimonio}}</div>
            </div>
            <div class="mask w-slider-mask" id="w-slider-mask-0">
                <div class="slide w-slide" aria-label="1 of 14" role="group" aria-hidden="true" style="transform: translateX(-250px); opacity: 1; transition: transform 500ms ease 0s;">
                    <img src="../images/active_ID_smart_partners_carousel_diverscan.png" loading="lazy" height="" alt="Grupo_Diverscan_Logo" class="client-diverscan" aria-hidden="true"></div>
                <div class="slide-2 w-slide" aria-label="2 of 14" role="group" aria-hidden="true" style="transform: translateX(-250px); opacity: 1; transition: transform 500ms ease 0s;">
                        <img src="../images/active_ID_smart_partners_carousel_seguridad_actual.png" loading="lazy" alt="Seguridad_Actual_Logo" class="client-seguridad-actual" aria-hidden="true"></div>
                <div class="slide-2 w-slide" aria-label="3 of 14" role="group" style="transform: translateX(-250px); opacity: 1; transition: transform 500ms ease 0s;">
                    <img src="../images/active_ID_smart_partners_carousel_lincoln_school.png" loading="lazy" alt="Lincoln_School_Logo" class="client-colegio-lincoln"></div>
                <div class="slide-2 w-slide" aria-label="4 of 14" role="group" style="transform: translateX(-250px); opacity: 1; transition: transform 500ms ease 0s;">
                    <img src="../images/active_ID_smart_partners_carousel_Datasys.png" loading="lazy" alt="DATASYS_Logo" class="client-datasys"></div>
                <div class="slide-2 w-slide" aria-label="5 of 14" role="group" aria-hidden="true" style="transform: translateX(-250px); opacity: 1; transition: transform 500ms ease 0s;">
                    <img src="../images/active_ID_smart_partners_carousel_Covergenets.png" loading="lazy" alt="Convergenets_Logo" class="client-convergenets" aria-hidden="true"></div>
                <div class="slide-2 w-slide" aria-label="6 of 14" role="group" aria-hidden="true" style="transform: translateX(-250px); opacity: 1; transition: transform 500ms ease 0s;">
                    <img src="../images/active_ID_smart_partners_carousel_getnuts.png" loading="lazy" alt="GetNuts_Logo" class="client-getnuts" aria-hidden="true"></div>
                <div class="slide-2 w-slide" aria-label="7 of 14" role="group" aria-hidden="true" style="transform: translateX(-250px); opacity: 1; transition: transform 500ms ease 0s;">
                    <img src="../images/active_ID_smart_partners_carousel_zebracenter.png" loading="lazy" alt="Zebracenter_Logo" class="client-zebra_center" aria-hidden="true"></div>
                <div class="slide-2 w-slide" aria-label="8 of 14" role="group" aria-hidden="true" style="transform: translateX(-250px); opacity: 1; transition: transform 500ms ease 0s;">
                    <img src="../images/active_ID_smart_partners_carousel_gosocket.png" loading="lazy" alt="Go Socket Logo" class="client-d_aquidesign" aria-hidden="true"></div>
                <div class="slide-2 w-slide" aria-label="9 of 14" role="group" aria-hidden="true" style="transform: translateX(-250px); opacity: 1; transition: transform 500ms ease 0s;">
                    <img src="../images/active_ID_smart_partners_carousel_gosocket_1.png" loading="lazy" height="170" width="145" alt="GoSocket_Logo" class="client-gosocket" aria-hidden="true"></div>
                <div class="slide-2 w-slide" aria-label="10 of 14" role="group" aria-hidden="true" style="transform: translateX(-250px); opacity: 1; transition: transform 500ms ease 0s;">
                    <img src="../images/active_ID_smart_partners_carousel_catie.png" loading="lazy" height="170" width="270" alt="Catie_Logo" class="client-catie" aria-hidden="true"></div>
                <div class="slide-2 w-slide" aria-label="12 of 14" role="group" aria-hidden="true" style="transform: translateX(-250px); opacity: 1; transition: transform 500ms ease 0s;">
                    <img src="../images/active_ID_smart_partners_carousel_municipalidad_turrialba.png" loading="lazy" height="170" alt="Escudo-Municipalidad-de-Turrialba" class="client-muni_turrialba" aria-hidden="true"></div>
                <div class="slide-2 w-slide" aria-label="13 of 14" role="group" aria-hidden="true" style="transform: translateX(-250px); opacity: 1; transition: transform 500ms ease 0s;">
                    <img src="../images/active_ID_smart_partners_carousel_boatrax.png" loading="lazy" height="170" alt="BOATRAX_Logo" class="client-etamobile" aria-hidden="true"></div>
                <div class="slide-2 w-slide" aria-label="14 of 14" role="group" aria-hidden="true" style="transform: translateX(-250px); opacity: 1; transition: transform 500ms ease 0s;">
                    <img src="../images/active_ID_smart_partners_carousel_eta_mobile.png" loading="lazy" height="170" alt="ETA-Mobile_Logo" class="client-etamobile" aria-hidden="true"></div>
                <div aria-live="off" aria-atomic="true" class="w-slider-aria-label" data-wf-ignore="">Slide 2 of 7.</div></div>
            <div class="left-arrow w-slider-arrow-left" role="button" tabindex="0" aria-controls="w-slider-mask-0" aria-label="previous slide">
              <div class="icon w-icon-slider-left"></div>
            </div>
            <div class="right-arrow w-slider-arrow-right" role="button" tabindex="0" aria-controls="w-slider-mask-0" aria-label="next slide">
              <div class="icon-2 w-icon-slider-right"></div>
            </div>
            <div class="slide-nav w-slider-nav w-shadow w-round">
                <div class="w-slider-dot" data-wf-ignore="" aria-label="Show slide 1 of 7" aria-pressed="false" role="button" tabindex="-1" style="margin-left: 5px; margin-right: 5px;">
            </div>
                <div class="w-slider-dot w-active" data-wf-ignore="" aria-label="Show slide 2 of 7" aria-pressed="true" role="button" tabindex="0" style="margin-left: 5px; margin-right: 5px;"></div>
                <div class="w-slider-dot" data-wf-ignore="" aria-label="Show slide 3 of 7" aria-pressed="false" role="button" tabindex="-1" style="margin-left: 5px; margin-right: 5px;"></div>
                <div class="w-slider-dot" data-wf-ignore="" aria-label="Show slide 4 of 7" aria-pressed="false" role="button" tabindex="-1" style="margin-left: 5px; margin-right: 5px;"></div>
                <div class="w-slider-dot" data-wf-ignore="" aria-label="Show slide 5 of 7" aria-pressed="false" role="button" tabindex="-1" style="margin-left: 5px; margin-right: 5px;"></div>
                <div class="w-slider-dot" data-wf-ignore="" aria-label="Show slide 6 of 7" aria-pressed="false" role="button" tabindex="-1" style="margin-left: 5px; margin-right: 5px;"></div>
                <div class="w-slider-dot" data-wf-ignore="" aria-label="Show slide 7 of 7" aria-pressed="false" role="button" tabindex="-1" style="margin-left: 5px; margin-right: 5px;"></div>

            </div>
          </div>
        </div>
      </div>
      <div class="section-partners wf-section">
        <div class="text-partners">{{listaidiomalogin.Certif}}</div>
        <div class="container-3 w-container">
          <div class="w-layout-grid grid-partners">
            <div id="w-node-_6d7d8755-37e8-5631-cae1-fd02da433048-1d7244d5" class="div-partner-logo partner-a">
                <img src="../images/919px-Logo_GS1.svg-p-500.png" loading="lazy" sizes="(max-width: 767px) 50vw, (max-width: 991px) 47vw, 470px" alt="GS-1_Logo" class="image-43"></div>
            <div id="w-node-_79f7482f-eb89-976c-7453-e0f1c8aadfc1-1d7244d5" class="div-partner-logo partner-b">
                <img src="../images/919px-Logo_rfid-technology-p-500.png" loading="lazy" sizes="(max-width: 767px) 50vw, (max-width: 991px) 47vw, 470px" alt="RFID_Logo" class="image-44"></div>
            <div id="w-node-e2dbe70d-f181-36f5-c7b5-d1ee3fcaacd4-1d7244d5" class="div-partner-logo partner-c">
                <img src="../images/Logo_Sin_Contacto.png" loading="lazy" sizes="(max-width: 767px) 50vw, (max-width: 991px) 47vw, 470px"  alt="Sin-Contacto_Logo" class="image-45"></div>
            <div id="w-node-be86cd7d-e1ca-4f08-4d8f-c82bc48b55d9-1d7244d5" class="div-partner-logo partner-d">
                <img src="../images/MicrosoftTeams-image-4.png" loading="lazy" alt="Plan-Nacional-Ciudad-Inteligente_Logo" class="image-46"></div>
          </div>
        </div>
      </div>
    </div>
    </div>

    <script src="js/Login.js?v=1.1.4"></script>
</asp:Content>
