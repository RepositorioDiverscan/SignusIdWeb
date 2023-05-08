<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/SiteMasterInicio.Master" AutoEventWireup="true" CodeBehind="ContactoView.aspx.cs" Inherits="ActiveSmartWeb.Contacto.ContactoView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
    textarea {
      resize: none;
    }
  </style>

    <div class="main contact" id="contacto">

      <div class="div-block-236"><img src="../images/banner-header-signusid-contact.jpg" loading="lazy" sizes="(max-width: 1920px) 100vw, 1920px" srcset="../images/banner-header-signusid-contact.jpg 500w, ../images/banner-header-signusid-contact.jpg 800w, ../images/banner-header-signusid-contact.jpg 1080w, ../images/banner-header-signusid-contact.jpg 1600w" alt=""></div>

      <div class="section-3 wf-section">
        <div class="div-contac">
          <div class="w-form">

            <form id="wf-form-Contact-Form" name="wf-form-Contact-Form" data-name="Contact Form" method="get" class="form-15">
                <div class="contact-form-grid">
                    <div id="w-node-_0ba4e7cc-0fa9-b929-33b9-a13d966d136d-46128f7f">
                        <label for="First-Name" id="contact-first-name" class="label-contacto">{{listaidioma.Nombre}}*</label>
                        <input tabindex="2" type="text" class="text-field-8 w-input" maxlength="256" name="First-Name" data-name="First Name" placeholder="" id="First-Name" v-model="nombre">
                          
                    </div>
                    <div id="w-node-_0ba4e7cc-0fa9-b929-33b9-a13d966d1371-46128f7f">
                        <label for="Last-Name" id="contact-last-name" class="label-contacto">{{listaidioma.Apellido}}*</label>
                        <input tabindex="3" type="text" class="text-field-8 w-input" maxlength="256" name="Last-Name" data-name="Last Name" placeholder="" id="Last-Name" v-model="apellido">
                        
                    </div>
                    <div id="w-node-_0ba4e7cc-0fa9-b929-33b9-a13d966d1375-46128f7f">
                        <label for="Email" id="contact-email" class="label-contacto">{{listaidioma.Correo}}*</label>
                        <input tabindex="4" type="email" class="text-field-8 w-input" maxlength="256" name="Email" data-name="Email" placeholder="" id="Email" v-model="correo">
                       
                    </div>
                    <div id="w-node-_0ba4e7cc-0fa9-b929-33b9-a13d966d1379-46128f7f" class="div-phone-number w-clearfix">
                        <label for="field" id="contact-phone" class="label-contacto">{{listaidioma.NumTelefono}}</label>
                        <input tabindex="5" type="tel" class="text-field-8 w-input" maxlength="256" name="Contact-Phone-Number-2" data-name="Contact Phone Number 2" placeholder="" id="telNational" v-model="telefono" v-on:keypress="ValidarSoloNumeros()">
                        
                    </div>
                    <div id="w-node-_0ba4e7cc-0fa9-b929-33b9-a13d966d137e-46128f7f">
                        <label for="Message" id="contact-message" class="label-contacto">{{listaidioma.Mensaje}}</label>
                        <textarea tabindex="6" data-name="Message" maxlength="250" id="Message" name="Message" placeholder="" class="textarea-4 w-input" v-model="mensaje"></textarea>
                    </div>
                    <div id="w-node-_9bab9b2e-9967-2731-9a12-b90b5c70ad02-46128f7f">
                        <label for="Message-2" id="contact-message" class="label-contacto">Asunto</label>
                        <input tabindex="1" v-model="asunto" type="text" class="text-field-8 w-input" maxlength="256" name="First-Name-2" data-name="First Name 2" placeholder="" id="First-Name-2" >
                    </div>
              </div>
        
              <input tabindex="7" type="submit" :value="listaidioma.Enviar" @click="ObtenerDatosRegistro()" data-wait="Please wait..." class="submit-button-3 w-button">
            
            </form>
            
          </div>
        </div>
      </div>
    </div>
    

    <script src="https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/17.0.18/js/intlTelInput.min.js"></script>
    <script src="Js/Contacto.js"></script>
</asp:Content>
