<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/SiteMasterInicio.Master" AutoEventWireup="true" CodeBehind="ValidarCuenta.aspx.cs" Inherits="ActiveSmartWeb.RegistroUsuarioEmpresas.ValidarCuenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="contenedor-general" id="cod">
    <div class="main-ai">
      <div class="wrap-conf-code-ai">
        <div class="div-block-211 div-steps-ai step_one"><img src="/images/paso_1.png" loading="lazy" width="151" height="" alt=""></div>
        <div class="div-block-code-ai">
          <h4 class="h-welcome-t-ai">{{listaIdiomas.Bienvenido}}</h4>
          <p class="p-mensaje-code-ai">{{listaIdiomas.ParrafoCodigo1}}<span class="txt-correo-conf-code-ai"> ******{{extEmail}}</span><br>{{listaIdiomas.ParrafoCodigo2}} </p>
          <div class="fb-code-verif-ai w-form">
            <label for="name" class="lbl-cod-verf-ai">{{listaIdiomas.CodigoVerificacion}}</label>
                <input type="text" class="txt-code-ai w-input" autofocus="true" maxlength="256" name="name" data-name="Name" :placeholder="[[listaIdiomas.IngreseCodigo]]" id="name" required="" v-model="codigo">
              <div class="undo-div-ai w-clearfix">
                <a href="#" v-on:click="NuevoCodigo()"  class="get-new-code-ai">{{listaIdiomas.GenerarCodigo}}</a>
              </div>
                <input type="submit" :value="[[listaIdiomas.Aceptar]]" data-wait="Please wait..." class="btn-accept-code-ai w-button" v-on:click="ValidarCodigo()">

          </div>
        </div>
      </div>
    </div>
    <div class="pop-up-code-review-ai">
      <div class="modal-code-ai"><img src="images/expired.svg" loading="lazy" width="46" alt="" class="img-expired-ai">
        <p class="p-alert-code-ai">Su código ha expirado</p>
        <p class="p-alert-code-ai p-orden-ai">¡Genérelo nuevamente!</p><img src="images/close.svg" loading="lazy" width="12" alt="" class="close-icon-code-ai">
      </div>
    </div>
    <div class="footer-copy">
      <p class="p-copy">Copyright © 2022 Smart Costa, LLC. All rights reserved.</p>
    </div>
  </div>

    <script src="../Recursos/JQuery/jquery-3.5.1.min.dc5e7f18c8.js"></script>
    <script src="js/webflow.js" type="text/javascript"></script>
    <script src="js/Codigo.js"></script>



</asp:Content>
