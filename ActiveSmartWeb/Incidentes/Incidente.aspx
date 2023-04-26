<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/Site.Master" AutoEventWireup="true" CodeBehind="Incidente.aspx.cs" Inherits="ActiveSmartWeb.Incidentes.Incidente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="main" id="IncidenteVue">
      <div class="wf-section" id="alertas">
        <div class="container-2 w-container">
          <div class="w-layout-grid grid-main">
            <div id="w-node-_97aed38c-2d77-41dc-114b-ad2dca7555bc-68a28f38" class="div-banner-extremo"></div>
            <div id="w-node-_97aed38c-2d77-41dc-114b-ad2dca7555bd-68a28f38" class="div-title-a">
              <div class="w-layout-grid grid-container-title" style="padding-top:10px; padding-bottom:10px">
                <a href="#" onclick="window.history.back()" class="link-block-back w-inline-block"><img src="../images/Back-arrow.svg" loading="lazy" height="26" width="26" alt="" class="back"></a>
                <h1 id="w-node-_9be28721-5dbb-5f12-6325-d0dcd6cba1e6-ffdc8228" class="titulo-principal" v-cloak>{{listaIdiomas.Titulo}}</h1>
                  <div data-hover="false" data-delay="0" id="w-node-_01c345db-44dd-5950-8797-fc0e77f5b71f-731f63ba" class="dropdown-detalles-ai w-dropdown">
                  <div class="toggle-detalles-ai w-dropdown-toggle" style="padding:0px"><img src="../images/info2.svg" loading="lazy" alt="" class="img-detalles-ai"></div>
                  <nav class="detalles-descrp-ai w-dropdown-list">
                    <p class="p-desc-detalles-ai" v-cloak>{{listaIdiomas.Msj1}}<strong><br>{{listaIdiomas.Msj2}}</strong></p>
                  </nav>
                </div>
              </div>
            </div>
            <div id="w-node-_97aed38c-2d77-41dc-114b-ad2dca7555c2-68a28f38" class="div-banner-extremo"></div>
            <div id="w-node-_97aed38c-2d77-41dc-114b-ad2dca7555c3-68a28f38" class="div-metodos-container">
              <div class="div-tarjeta tarjeta-responsive tarjeta-incidentez">
                <div class="incidentes-container">
                  <div class="form-block-9 fb-incidentes w-form">
                      <div class="w-layout-grid grid-3 grid-incidentes">
                        
                          <div id="w-node-e8129148-b40d-f58c-c0bc-252ae84e14e3-68a28f38" class="form-line line-incidentes">
                              <label for="field-4" class="field-label" v-cloak>{{listaIdiomas.Asunto}}</label>
                              
                              <select v-cloak v-model="idTipoIncidente" id="field-4" name="field-4" data-name="Field 4" required="" class="select-field select-filtro-ai slct-incidentes w-select">
                                <option value="0">Seleccionar un asunto</option>
                                <option v-for="tipoIncidente in listaTipos" :value="tipoIncidente.IdTipoIncidente">{{tipoIncidente.Nombre}}</option>
                              </select>

                        </div>

                        <div id="w-node-_6c2b7d18-a179-16c8-3e10-2760b65f2063-68a28f38" class="form-line line-incidentes"><label for="nombrre" class="field-label" v-cloak>{{listaIdiomas.Nombre}}</label><input readonly="true" type="text" v-model="nombre" class="text-field w-input" maxlength="80" name="nombrre" data-name="nombrre" placeholder="" id="nombrre" required=""></div>
                        <div id="w-node-_886a7634-c42d-82f4-022e-63de9c7168d3-68a28f38" class="form-line line-incidentes"><label for="apellidos" class="field-label" v-cloak>{{listaIdiomas.Apellidos}}</label><input readonly="true" type="text" v-model="apellido" class="text-field w-input" maxlength="80" name="apellidos" data-name="apellidos" placeholder="" id="apellidos" required=""></div>
                        <div id="w-node-_6c2b7d18-a179-16c8-3e10-2760b65f2067-68a28f38" class="form-line line-incidentes">
                            <label for="phone" class="field-label" v-cloak>
                                {{listaIdiomas.NumeroTelefono}}
                            </label>
                            <input autocomplete="off" v-on:keypress="ValidarSoloNumeros()" id="telNational" type="tel" name="telNational" maxlength="50"
                                class="text-field w-input" data-name="Name 4"/>

                        </div>
                        <div id="w-node-_6c2b7d18-a179-16c8-3e10-2760b65f206b-68a28f38" class="form-line line-incidentes"><label for="email" class="field-label" v-cloak>{{listaIdiomas.Correo}}</label><input readonly="true" type="email" v-model="email" class="text-field w-input" maxlength="80" name="email" data-name="email" placeholder="" id="email" required=""></div>
                        <div id="w-node-_6c2b7d18-a179-16c8-3e10-2760b65f206f-68a28f38" class="form-line line-incidentes"><label for="mensaje" class="field-label" v-cloak>{{listaIdiomas.Mensaje}}</label><textarea v-model="mensaje" :placeholder="listaIdiomas.PhMensaje" maxlength="200" id="mensaje" name="mensaje" data-name="mensaje" required="" class="textarea w-input" style="resize: none !important"></textarea></div>
                        <div id="w-node-_6c2b7d18-a179-16c8-3e10-2760b65f2073-68a28f38" class="contenedor-botones cont-botones-incidentes">
                          <a href="#" v-on:click="InsertarIncidente()" class="boton btn-incidentes w-button" v-cloak>{{listaIdiomas.Enviar}}</a>
                        </div>
                        <div id="w-node-_1ec520d7-6fba-044a-9f75-11142b67630c-68a28f38" class="campos-obligatosios-incidentes"><strong></strong></div> 
                      </div>
                  </div>
                </div>
              </div>
              <div class="div-tarjeta div-cinta">
                <div class="div-block-170">
                  <div class="text-block-17" v-cloak>{{listaIdiomas.Descubra}}</div>
                  <a href="../Tienda/Tienda.aspx" class="boton call2action w-button" v-cloak>{{listaIdiomas.Tienda}}<strong></strong></a>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <!--International cellphone input-->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/17.0.18/js/intlTelInput.min.js"></script>
    <script src="js/Incidente.js"></script>
</asp:Content>
