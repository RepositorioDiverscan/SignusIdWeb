<%@ Page Language="C#" MasterPageFile="~/SiteMaster/Site.Master" AutoEventWireup="true" CodeBehind="MetodosPago.aspx.cs" Inherits="ActiveSmartWeb.MetodosPago.MetodosPago" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div id="METODOS-DE-PAGO" class="div-block-260" style="margin-top: 5%;">
        <div class="div-block-261">
            <div id="w-node-_78e2992d-60a1-4eee-75ed-9b306bae5558-c75df771" class="div-block-280"></div>
            <div id="w-node-_2c6d322f-101d-bf16-78bb-defab30f3234-c75df771" class="div-block-263">
                <h1 class="heading-50">MÉTODOS DE PAGO</h1>
                <div class="div-block-262">
                    <div class="text-block-34">TARJETAS</div>
                    <div class="text-block-35">AGREGAR TARJETAS</div>
                    <a href="#" class="div-block-268" @click="MostrarPopUpAgregarTarjeta()">

                        <img src="../images/icono_mas_activeID.svg" loading="lazy" alt="" class="image-70">
                    </a>
                </div>

                <%--Tarjeta--%>
                <div v-for="(metodo,index) in metodosPago" :key="index" class="div-block-264">
                    <img v-if="metodo.Tipo == 'Visa'" src="../images/visa.svg" loading="lazy" alt="" class="image-68">
                    <img v-if="metodo.Tipo == 'MasterCard'" src="../images/MasterCard_Logo.svg.png" loading="lazy" sizes="(max-width: 479px) 33.4765625px, (max-width: 767px) 7vw, (max-width: 991px) 5vw, 4vw" srcset="../images/MasterCard_Logo.svg-p-500.png 500w, ../images/MasterCard_Logo.svg-p-800.png 800w, ../images/MasterCard_Logo.svg-p-1080.png 1080w, ../images/MasterCard_Logo.svg-p-1600.png 1600w, ../images/MasterCard_Logo.svg-p-2000.png 2000w, ../images/MasterCard_Logo.svg.png 2560w" alt="" class="image-68">
                    <div class="div-block-265">
                        <div>{{metodo.NumeroTarjeta}}</div>
                        <div>{{metodo.NombreDuenno}} {{metodo.ApellidoDuenno}}</div>
                        <div v-if="metodo.Estado" >{{metodo.FechaExpiracion}}</div>
                        <div v-if="!metodo.Estado">Expiró {{metodo.FechaExpiracion}}</div>                  
                    </div>
                    <div class="div-block-266">
                        <h1 v-if="metodo.Predeterminado" class="heading-51">PREDETERMINADO</h1>
                        <div v-if="!metodo.Predeterminado" class="form-block-33 w-form">
                            <div id="email-form-4" name="email-form-4" data-name="Email Form 4" method="get" class="form-21" data-wf-page-id="62cdf3fe3f0aa172c75df771" data-wf-element-id="dad112fa-1a32-bf3f-1be2-ace1ce489485">
                                <label class="w-checkbox checkbox-field-4">
                                    <input type="checkbox" name="" data-name="." id="checkbox" class="w-checkbox-input checkbox-3"><span class="w-form-label">.</span></label>
                            </div>

                        </div>
                        
                    </div>
                    <div v-if="!metodo.Predeterminado" class="div-block-267 _2">
                        <img src="../images/cerrar_x_signus.svg" loading="lazy" alt="Icono_X_Cerrar" class="image-69">
                    </div>
                </div>


               
                <%--<div class="div-block-264">
                    <img src="../images/MasterCard_Logo.svg.png" loading="lazy" sizes="(max-width: 479px) 33.4765625px, (max-width: 767px) 7vw, (max-width: 991px) 5vw, 4vw" srcset="../images/MasterCard_Logo.svg-p-500.png 500w, ../images/MasterCard_Logo.svg-p-800.png 800w, ../images/MasterCard_Logo.svg-p-1080.png 1080w, ../images/MasterCard_Logo.svg-p-1600.png 1600w, ../images/MasterCard_Logo.svg-p-2000.png 2000w, ../images/MasterCard_Logo.svg.png 2560w" alt="" class="image-68">
                    <div class="div-block-265">
                        <div>*************123.</div>
                        <div>Marianela Estrada Brenes</div>
                        <div>Expiró 25/08/23</div>
                    </div>
                    <div class="div-block-266"></div>
                    <div class="div-block-270">
                        <div class="form-block-32 w-form">
                            <div id="email-form-4" name="email-form-4" data-name="Email Form 4" method="get" class="form-21" data-wf-page-id="62cdf3fe3f0aa172c75df771" data-wf-element-id="9bae134c-4b72-1d71-7733-2cc030681f1f">
                                <label class="w-checkbox">
                                    <input type="checkbox" name="" data-name="." id="checkbox" class="w-checkbox-input checkbox-3"><span class="w-form-label">.</span></label>
                            </div>

                        </div>
                    </div>
                    <div class="div-block-267 _2">
                        <img src="../images/cerrar_x_signus.svg" loading="lazy" alt="Icono_X_Cerrar" class="image-69">
                    </div>
                </div>--%>


            </div>
            <div id="w-node-e7498a71-99bf-2046-a623-8b785ce502f0-c75df771" class="div-block-279"></div>
        </div>


         <%--Modal agregar metodo de pago--%>
        <div class="background-pop-up background-pago" id="popupAgregarTarjeta">
            <div class="popup-comercial add-pago-pp">
                <div class="header-modal-ai">
                    <h4 class="texto-h-ai">Agregar método de pago</h4>
                    <a href="#" @click="OcultarPopUpAgregarTarjeta()" class="div-icon-exit-ai">
                        <img src="../images/icono_eliminar_acces-o-01.svg" loading="lazy" alt="" class="img-salir-ai"></a>
                </div>
                <div class="form-block-payment-ai form-pp-pago w-form">
                    <div id="email-form" name="email-form" data-name="Email Form" method="get" class="form-pay-ai w-clearfix" data-wf-page-id="62cdf3fe3f0aa172c75df771" data-wf-element-id="82c6117e-1aa9-e6b9-4ce7-9308970c13e5">
                        <label for="n-mero-de-tarjeta-3" class="lbl-pago-info-ai">Número de la tarjeta</label>
                        <img src="../images/tarjeta.svg" loading="lazy" width="28" alt="" class="icon-tarjeta-pago-ai">
                        <input type="text" class="input-info-pago-ai w-input" maxlength="256"
                             v-model="numerotarjeta" onkeypress="return event.charCode>=48 && event.charCode<=57" @keyup="validardigitosnumerotarjeta()"
                            name="num-tarjeta" data-name="num tarjeta" placeholder="Ingrese el número de la tarjeta" id="num-tarjeta" required="">
                        <div class="data-payment-ai month-ai w-clearfix">
                            <label for="fecha" class="lbl-pago-info-ai">Fecha de vencimiento</label>
                            <input v-model="fechaVencimiento" onkeypress="return event.charCode>=48 && event.charCode<=57" @keyup="validardigitosfechavencimiento()" type="text" class="input-info-pago-ai w-input" maxlength="256" name="fecha" data-name="fecha" placeholder="MM / AA" id="fecha" required="">
                        </div>
                        <div class="data-payment-ai w-clearfix">
                            <label for="Cvv-3" class="lbl-pago-info-ai">CVV</label>
                            <input  v-model="codigo" type="text" class="input-info-pago-ai w-input" maxlength="256" name="Cvv" data-name="Cvv" placeholder="CVV" id="Cvv-3" required="">
                        </div>
                        <label for="nombre" class="lbl-pago-info-ai">Nombre del tituar</label>
                        <input
                            v-model="nombretitular" type="text" class="input-info-pago-ai txt-titular w-input" maxlength="256" name="nombre" data-name="nombre" placeholder="Ingrese el nombre del titular" id="nombre" required="">
                        <div>
                            <div>Apellido del titular </div>
                            <input v-model="apellidotitular" type="text" class="text-field-18 w-input" maxlength="256" name="field-7" data-name="Field 7" placeholder="Example Text" id="field-7" required="">
                        </div>
                        <label for="Paises-5" class="lbl-pago-info-ai">País/Región</label>
                        <input id="Paises-5" name="Paises" data-name="Paises" required="" class="select-info-pago-ai w-select">
                        <div class="data-payment-ai state-box-ai w-clearfix">
                            <label for="Estado-3" class="lbl-pago-info-ai">Estado</label>
                            <input v-model="estado" type="text" class="input-info-pago-ai w-input" maxlength="256" name="Estado" data-name="Estado" placeholder="Ingrese el estado" id="Estado-3" required="">
                        </div>
                        <div class="data-payment-ai w-clearfix">
                            <label for="Ciudad-3" class="lbl-pago-info-ai">Ciudad</label>
                            <input v-model="ciudad" type="text" class="input-info-pago-ai w-input" maxlength="256" name="Ciudad" data-name="Ciudad" placeholder="Ingrese la iudad" id="Ciudad-3" required="">
                        </div>
                        <label
                            for="direcci-n-3" class="lbl-pago-info-ai lbl-direcc-ai">
                            Dirección</label>
                        <textarea v-model="direccion" placeholder="Ingrese la dirección" maxlength="5000" id="direcci-n-3" name="direcci-n" data-name="dirección" required="" class="text-area-direcci-n-ai w-input"></textarea>
                    </div>
                    
                </div>
                <a href="#" class="btn-cerrar w-button">Guardar</a>
            </div>
        </div>

    </div>



    <script src="../Recursos/JQuery/jquery-3.5.1.min.dc5e7f18c8.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/country-select-js/2.1.1/js/countrySelect.min.js"></script>
    <script src="../Recursos/Vue/vue.js"></script>
    <script src="js/MetodosPago.js"></script>

</asp:Content>
