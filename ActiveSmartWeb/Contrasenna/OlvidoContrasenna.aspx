<%@ page title="" language="C#" masterpagefile="~/SiteMaster/SiteMasterInicio.Master" autoeventwireup="true" codebehind="OlvidoContrasenna.aspx.cs" inherits="ActiveSmartWeb.Contrasenna.CambioContrasena.OlvidoContrasenna" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="contenedor-general">
        <div class="main-ai" id="context">
            <div class="wrap-form-ai wrap-new-passwrd" id="alertas">
                <div class="form-block-log-ai fb-new-pass w-form">
                    <div id="email-form" name="email-form" data-name="Email Form" method="get" class="form-login-ai form-new-password form-email-get">
                        <label for="Password" class="txt-login-ai new-passwrd-lbl lbl-email-passwrd">{{listaIdiomas.OlvidoContrasenna}}</label>
                        <p class="leyend-top">{{listaIdiomas.TxtAyudaCorreo}}</p>
                        <div class="div-reset-passwrd">
                            <input v-model="correoUsuario" type="email" class="txt-email-get-ai w-input" maxlength="256" name="email" data-name="email" :placeholder="listaIdiomas.Correo" id="email" required="">
                        </div>
                        <input v-on:click="ValidarInformacion()" type="submit" :value="listaIdiomas.Enviar" data-wait="Please wait..." class="btn-login-ai btn-enviar-mew-passwrd btn-enviar-correo w-button">
                    </div>
                </div>
            </div>
        </div>
    </div>

<script src="../Recursos/JQuery/jquery-3.5.1.min.dc5e7f18c8.js"></script>
<script src="../VisorActivos/Vue/vue.min.js"></script>
<script src="js/OlvidoContrasena.js?v=1.1.2"></script>

</asp:Content>
