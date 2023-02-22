<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/SiteMasterInicio.Master" AutoEventWireup="true" CodeBehind="Ejemplo.aspx.cs" Inherits="ActiveSmartWeb.GestionServicio.Ejemplo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

       <div class="main-ai" id="EjemploVUE">
      <div class="wrap-conf-code-ai">
        <div class="div-block-code-ai">

          <h4 class="h-welcome-t-ai">{{listaIdiomas.Bienvenido}}</h4>


          <p class="p-mensaje-code-ai">{{listaIdiomas.ParrafoCodigo}}</p>
          
            <div class="fb-code-verif-ai w-form">
            <div id="email-form" name="email-form" data-name="Email Form" method="get" class="form-code-verf-ai">
  <label for="name" class="lbl-cod-verf-ai">{{listaIdiomas.CodigoVerificacion}}</label>

                <input type="text" class="txt-code-ai w-input" autofocus="true" maxlength="256" name="name" data-name="Name"
                    :placeholder="[[listaIdiomas.IngreseCodigo]]" id="name" required=""  v-model="codigo">

              <div class="undo-div-ai w-clearfix">
                <a href="#" class="get-new-code-ai">{{listaIdiomas.GenerarCodigo}}</a>
              </div>
                <input type="submit" :value="[[listaIdiomas.Aceptar]]" data-wait="Please wait..." class="btn-accept-code-ai w-button"
                   v-on:click="MostrarAlerta()" >
            </div>
       
          </div>
        </div>
      </div>
    </div>

        <script src="js/webflow.js" type="text/javascript"></script>
    <script src="../Recursos/JQuery/jquery-3.5.1.min.dc5e7f18c8.js"></script>
    <script src="../js/webflow.js"></script>
    <script src="js/Ejemplo.js"></script>
</asp:Content>