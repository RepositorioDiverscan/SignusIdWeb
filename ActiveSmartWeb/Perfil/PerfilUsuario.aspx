<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/Site.Master" AutoEventWireup="true" CodeBehind="PerfilUsuario.aspx.cs" Inherits="ActiveSmartWeb.Perfil.PerfilUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="main" id="Perfil">
      <div class="section wf-section" id="alertas">
        <div class="container-2 w-container">
          <div class="w-layout-grid grid-main">
            <div id="w-node-_9be28721-5dbb-5f12-6325-d0dcd6cba1e0-ffdc8228" class="div-banner-extremo"></div>
            <div id="w-node-_9be28721-5dbb-5f12-6325-d0dcd6cba1e1-ffdc8228" class="div-banner-extremo"></div>
            <div id="w-node-_9be28721-5dbb-5f12-6325-d0dcd6cba1e2-ffdc8228" class="div-block-224">
              <div class="w-layout-grid grid-container-title" style="padding-top:10px; padding-bottom:10px">
                <a href="#" onclick="window.history.back()" class="link-block-back w-inline-block"><img src="../images/Back-arrow.svg" loading="lazy" height="26" width="26" alt="" class="back"></a>
                <h1 id="w-node-_9be28721-5dbb-5f12-6325-d0dcd6cba1e6-ffdc8228" class="titulo-principal" v-cloak>{{listaIdiomas.Titulo}}</h1>
                  <div data-hover="false" data-delay="0" id="w-node-_01c345db-44dd-5950-8797-fc0e77f5b71f-731f63ba" class="dropdown-detalles-ai w-dropdown">
                  <div class="toggle-detalles-ai w-dropdown-toggle" style="padding:0px"><img src="../images/info2.svg" loading="lazy" alt="" class="img-detalles-ai"></div>
                  <nav class="detalles-descrp-ai w-dropdown-list">
                    <p class="p-desc-detalles-ai" v-cloak>{{listaIdiomas.MsjInfo1}}<strong><br>{{listaIdiomas.MsjInfo2}}</strong></p>
                  </nav>
                </div>
              </div>
            </div>
            <div id="w-node-_9d44f16f-8e89-7409-f627-f21553a0392b-ffdc8228" class="div-block-167">
              <div class="div-block-169"></div>
              <div class="w-layout-grid grid-perfil">
                <div id="w-node-_9d44f16f-8e89-7409-f627-f21553a03937-ffdc8228" class="div-tarjeta">
                  <div class="block-form-aid w-form">
                    <div id="email-form" name="email-form" data-name="Email Form" method="get">
                      <div class="w-layout-grid grid-form grid-form-perf"><label for="email" id="w-node-_9d44f16f-8e89-7409-f627-f21553a0393a-ffdc8228" class="field-label" v-cloak>{{listaIdiomas.PerfilGeneral}}</label>
                        <div id="w-node-_3872ecbc-562c-51cb-a196-e7193aa80f60-ffdc8228" class="form-line"><label for="name-5" class="field-label" v-cloak>{{listaIdiomas.Nombre}}</label><input type="text" maxlength="80" v-model="nombre" class="text-field w-input" name="name-4" data-name="Name 4" placeholder="" id="name-4"></div>
                        <div id="w-node-_6b91d3c3-d3ce-8de0-a799-24874e80ac47-ffdc8228" class="form-line"><label for="name-5" class="field-label" v-cloak>{{listaIdiomas.Apellidos}}</label><input type="text" maxlength="80" v-model="apellidos" class="text-field w-input" name="name-4" data-name="Name 4" placeholder="" id="name-4"></div>
                        <div id="w-node-c7261429-dcf6-ecc3-8c7b-95fc96f589c0-ffdc8228" class="form-line">
                            <label for="name-4" class="field-label" v-cloak>{{listaIdiomas.IdentificacionPersonal}}</label>
                            <input type="text" maxlength="80" v-model="identificacion" class="text-field w-input" name="name-4" data-name="Name 4" placeholder="" id="cedula">
                        </div>
                        <div id="w-node-_21be07d3-9023-6cde-91dd-3946eaacc9d1-ffdc8228" class="form-line"><label for="name-4" class="field-label" v-cloak>{{listaIdiomas.Correo}}</label><input readonly="true" type="email" maxlength="80" v-model="correo" class="text-field w-input" name="name-4" data-name="Name 4" placeholder="" id="name-4"></div>
                        <div id="w-node-e6462ae9-6fb1-71e6-055e-6dc341aaf668-ffdc8228" class="form-line"><label for="name-5" class="field-label" v-cloak>{{listaIdiomas.Puesto}}</label><input type="text" v-model="puesto" class="text-field w-input" maxlength="80" name="name-4" data-name="Name 4" placeholder="" id="name-4"></div>
                        <div id="w-node-_937e0f60-0fe9-0468-e93e-05502d25fd1f-ffdc8228" class="form-line">
                            <label for="name-4" class="field-label" v-cloak>{{listaIdiomas.Telefono}}</label>
                            <input autocomplete="off" v-on:keypress="ValidarSoloNumeros()" id="telNational" type="tel" name="telNational" maxlength="80"
                                class="text-field w-input" data-name="Name 4"/>

                        </div>
                        <div id="w-node-b398784d-90a2-6b2d-953e-e45bef532979-ffdc8228" class="contenedor-botones">
                          <a href="#" v-on:click="ActualizarDatosUsuario()" class="link-block-boton w-inline-block"><img src="../images/save_blanco.svg" loading="lazy" alt=""></a>
                        </div>
                      </div>
                    </div>
                  
                  </div>
                </div>
                <div id="w-node-f7a941f7-7bdc-630b-4935-06358723ba97-ffdc8228" class="div-tarjeta">
                  <div class="block-form-aid w-form">
                      <div class="w-layout-grid grid-form grid-contrasennia">
                          <label for="email-3" id="w-node-f7a941f7-7bdc-630b-4935-06358723ba9b-ffdc8228" class="field-label" v-cloak>{{listaIdiomas.CambiarContra}}</label>
                          <div id="w-node-f7a941f7-7bdc-630b-4935-06358723ba9d-ffdc8228" class="form-line">
                            <label for="name-4" class="field-label" v-cloak>{{listaIdiomas.ContraActual}}</label>

                            <input oncopy = 'return false' oncut = 'return false' onpaste = 'return false' autocomplete="off" type="password" maxlength="80" v-model="contraActual" class="text-field w-input" name="name-4" data-name="Name 4" placeholder="" id="name-4">

                        </div>
                        <div id="w-node-f7a941f7-7bdc-630b-4935-06358723baa5-ffdc8228" class="form-line"><label for="name-4" class="field-label" v-cloak>{{listaIdiomas.NuevaContra}}</label><input oncopy = 'return false' oncut = 'return false' onpaste = 'return false' autocomplete="off" type="password" maxlength="80" v-model="nuevaContra" class="text-field w-input" name="name-4" data-name="Name 4" placeholder="" id="name-4"></div>
                        <div id="w-node-f7a941f7-7bdc-630b-4935-06358723baa9-ffdc8228" class="form-line"><label for="name-4" class="field-label" v-cloak>{{listaIdiomas.ConfirmaContra}}</label><input oncopy = 'return false' oncut = 'return false' onpaste = 'return false' autocomplete="off" type="password" maxlength="80" v-model="confirmContra" class="text-field w-input" name="name-4" data-name="Name 4" placeholder="" id="name-4"></div>
                        <div id="w-node-f7a941f7-7bdc-630b-4935-06358723baad-ffdc8228" class="contenedor-botones">
                          <a href="#" v-on:click="CambiarContrasenia()" class="link-block-boton w-inline-block"><img src="../images/save_blanco.svg" loading="lazy" alt=""></a>
                        </div>
                      </div>
                    
                  </div>
                </div>
                <div id="w-node-_9d44f16f-8e89-7409-f627-f21553a0399a-ffdc8228" class="div-tarjeta tarjeta-responsive tarjeta-perf">
                  <div class="div-photo-perfil">
                      <img v-bind:src="[[imagenPerfil]]"
                          loading="lazy" width="110" alt=""  @mouseover="MostrarBoton"
                          @mouseout="OcultarBoton"
                          class="photo-perfil">

                      <div class="div-load-img-ai edit-img-perf" id="BotonEditarImagen"  >

                     
                           <label class="text-edit-photo-ai">
                            Editar Imagen
                        <input  style="display: none;" id="files" type="file" @change="handleFileSelect" />
                       </label>
                     
                      </div>

                    <div class="datos-perfil">
                      <div class="nombre-de-usuario" v-cloak>{{nombre}} {{apellidos}}</div>
                      <div class="title-suscripcion perf-cuenta-titulo-ai" v-cloak>{{listaIdiomas.TipoUsuario}}</div>
                      <div class="suscripcion" v-cloak>{{rol}}</div>
                      <p class="paragraph-5"><strong class="bold-text-2 perf-cuenta-titulo-ai" v-cloak>{{listaIdiomas.NumeroCuenta}}:<br></strong><span>‍</span> <span class="text-span-8">{{idPerfilActive}}</span></p>
                    </div>
                  </div>
                </div>
                <div id="w-node-_14b2d548-173f-9afc-c61a-29c51cd902c5-ffdc8228" class="div-tarjeta div-otorgar-permisos">
                  <div class="block-form-aid w-form">
                    <div >
                      <div class="w-layout-grid grid-form"><label for="email-3" id="w-node-_14b2d548-173f-9afc-c61a-29c51cd902c9-ffdc8228" class="field-label">OTORGAR PERMISOS</label>
                        <div id="w-node-_14b2d548-173f-9afc-c61a-29c51cd902cb-ffdc8228" class="form-line"><label for="name-5" class="field-label">Nombre</label><input type="text" class="text-field w-input" maxlength="80" name="name-4" data-name="Name 4" placeholder="" id="name-4"></div>
                        <div id="w-node-_14b2d548-173f-9afc-c61a-29c51cd902cf-ffdc8228" class="form-line"><label for="name-5" class="field-label">Apellidos</label><input type="text" class="text-field w-input" maxlength="80" name="name-4" data-name="Name 4" placeholder="" id="name-4"></div>
                        <div id="w-node-_14b2d548-173f-9afc-c61a-29c51cd902d3-ffdc8228" class="form-line"><label for="name-5" class="field-label">Correo electrónico</label><input type="text" class="text-field w-input" maxlength="80" name="name-4" data-name="Name 4" placeholder="" id="name-4"></div>
                        <div id="w-node-_14b2d548-173f-9afc-c61a-29c51cd902d7-ffdc8228" class="contenedor-botones">
                          <a href="#" class="link-block-boton w-inline-block"><img src="../images/save_blanco.svg" loading="lazy" alt=""></a>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
                <div id="w-node-_79bd0e9d-731c-fed6-35c1-f093a0c8d3af-ffdc8228" class="div-tarjeta cinta-tienda-ai">
                  <div class="div-block-170">
                    <div class="text-block-17" v-cloak>{{listaIdiomas.Descubra}}</div>
                    <a href="../Tienda/Tienda.aspx" class="boton call2action w-button" v-cloak><strong>{{listaIdiomas.IrTienda}}</strong></a>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>

    

    <!--International cellphone input-->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/17.0.18/js/intlTelInput.min.js"></script>


    <script src="../js/webflow.js"></script>
    <script src="../Recursos/JQuery/jquery-3.5.1.min.dc5e7f18c8.js"></script>
    <script src="js/Perfil.js"></script>

   
    <script>
       

    </script>

</asp:Content>
