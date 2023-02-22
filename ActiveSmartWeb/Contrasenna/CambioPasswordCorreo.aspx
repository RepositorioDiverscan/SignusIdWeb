<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/SiteMasterInicio.Master" AutoEventWireup="true" CodeBehind="CambioPasswordCorreo.aspx.cs" Inherits="ActiveSmartWeb.Contrasenna.CambioPasswordCorreo1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="contenedor-general" id="alertas">
    <div class="main-ai" id="context1">
            <div data-hover="false" data-delay="0" class="dropdown-detalles-ai ayuda-passwrd w-dropdown">
                <div class="toggle-detalles-ai w-dropdown-toggle"><img src="../images/info2.svg" loading="lazy" alt="" class="img-detalles-ai"></div>
                <nav class="detalles-descrp-ai detalles-ayuda w-dropdown-list">
                    <p class="p-desc-detalles-ai"><strong>Reglas para generar claves:</strong></p>
                    <ol role="list" class="list-5">
                        <li class="li-ayuda">La contraseña debe contener como mínimo 8 caracteres.</li>
                        <li class="li-ayuda">La contraseña debe contener al menos una letra mayúscula, una letra minúscula, un número (0-9) y un carácter especial ( @ & $ * \ - _ ¿ # ¡ .)</li>
                        <li class="li-ayuda">Las contraseñas deben cambiarse al menos cada 365 días si se implementa el monitoreo de compromiso de credenciales, de lo contrario, cada 90 días+</li>
                        <li class="li-ayuda">Restricciones en la reutilización de contraseñas utilizadas anteriormente.</li>
                        <li class="li-ayuda">Cuentas de usuario bloqueadas después de cinco o más intentos fallidos de inicio de sesión.</li>
                        <li class="li-ayuda">Las contraseñas se almacenan de manera segura para evitar una fácil divulgación (por ejemplo, encriptadas/hash).</li>
                        <li class="li-ayuda">Prohibición de compartir contraseñas y escribir contraseñas en papel.</li>
                        <li class="li-ayuda">Eliminación/desactivación/cambio de la contraseña predeterminada de Ventor (antes de que el sistema entre en producción).</li>
                        <li class="li-ayuda">Requisitos más estrictos para las contraseñas de administrador.</li>
                    </ol>
                </nav>
            </div>
 
            <div class="wrap-form-ai wrap-new-passwrd">
                <div class="form-block-log-ai fb-new-pass w-form">
                        <div id="email-form" name="email-form" data-name="Email Form" method="get" class="form-login-ai form-new-password">
                        <label for="Password" class="txt-login-ai new-passwrd-lbl">{{listaIdiomas.Password}}</label>
                        <div class="div-reset-passwrd">
                            <input oncopy = 'return false' oncut = 'return false' onpaste = 'return false' id="password" v-model="password" type="password" class="txt-user-log-ai new-password w-input" maxlength="256" name="new-password" data-name="new password" :placeholder="listaIdiomas.PlhPassword" id="new-password" required="">
                            <a id="show-password" data-w-id="7bd69c37-e3dc-ab40-b58e-3936651cc833" href="#" class="show-hide-pswrd w-inline-block">
                                <div id="tippy" data-tippy-content="Hide" data-tippy-distance="1" data-w-id="7bd69c37-e3dc-ab40-b58e-3936651cc834" class="html-embed hide w-embed">
                                </div>
                                <div id="tippy" v-on:click="OcultarMostrarContrasenna()" data-tippy-content="Show" data-tippy-distance="1" data-w-id="7bd69c37-e3dc-ab40-b58e-3936651cc835" class="html-embed showhide w-embed">
                                    <svg id="tippy2" style="display:none" xmlns="http://www.w3.org/2000/svg" width="16" height="16" viewbox="0 0 16 16">
                                        <g fill="#111111">
                                            <path fill="#111111" d="M14.6,5.6l-8.2,8.2C6.9,13.9,7.5,14,8,14c3.6,0,6.4-3.1,7.6-4.9c0.5-0.7,0.5-1.6,0-2.3 C15.4,6.5,15,6.1,14.6,5.6z"></path>
                                            <path fill="#111111" d="M14.3,0.3L11.6,3C10.5,2.4,9.3,2,8,2C4.4,2,1.6,5.1,0.4,6.9c-0.5,0.7-0.5,1.6,0,2.2c0.5,0.8,1.4,1.8,2.4,2.7 l-2.5,2.5c-0.4,0.4-0.4,1,0,1.4C0.5,15.9,0.7,16,1,16s0.5-0.1,0.7-0.3l14-14c0.4-0.4,0.4-1,0-1.4S14.7-0.1,14.3,0.3z M5.3,9.3 C5.1,8.9,5,8.5,5,8c0-1.7,1.3-3,3-3c0.5,0,0.9,0.1,1.3,0.3L5.3,9.3z"></path>
                                        </g>
                                    </svg>
                                    <svg id="tippy1" xmlns="http://www.w3.org/2000/svg" width="16" height="16" viewbox="0 0 16 16">
                                        <g fill="currentColor">
                                            <path fill="currentColor" d="M8,14c3.6,0,6.4-3.1,7.6-4.9c0.5-0.7,0.5-1.6,0-2.3C14.4,5.1,11.6,2,8,2C4.4,2,1.6,5.1,0.4,6.9 c-0.5,0.7-0.5,1.6,0,2.2C1.6,10.9,4.4,14,8,14z M8,5c1.7,0,3,1.3,3,3s-1.3,3-3,3S5,9.7,5,8S6.3,5,8,5z"></path>
                                        </g>
                                    </svg>
                                </div>
                            </a>
                        </div>
                <p class="pass-leyenda" style="display:none" id="advCon">- La contraseña debe contener como mínimo 8 caracteres.
                    <br>- La contraseña debe contener al menos una letra mayúscula, una letra minúscula, un número (0-9) y un carácter especial ( @ &amp; $ * \ - _ ¿ # ¡ .)
                </p>
                        <label for="repeat-passwrd" class="txt-pass-log-ai new-passwrd-lbl">{{listaIdiomas.ConfirmarPassword}}</label>
                        <div class="div-reset-passwrd">
                            <input oncopy = 'return false' oncut = 'return false' onpaste = 'return false' v-model="confirmPassword" type="password" class="txt-user-log-ai new-password w-input" maxlength="256" name="confirm-password" data-name="confirm password" :placeholder="listaIdiomas.PlhConfirmarPassword" id="confirm-password" required="">
                        </div>
                <p class="pass-leyenda" style="display:none">- Las contraseñas no coinciden. <br>
                </p>
                        <input v-on:click="ValidarContrasena()" type="submit" :value="listaIdiomas.Guardar" data-wait="Please wait..." class="btn-login-ai btn-enviar-mew-passwrd w-button">
              </div>
            </div>
          </div>
    </div>
        </div>
    <script src="../js/webflow.js"></script>
    <script src="../Recursos/JQuery/jquery-3.5.1.min.dc5e7f18c8.js"></script>
    <script src="js/CambioPassword2.js"></script>
</asp:Content>
