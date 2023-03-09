<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/SiteMaster/SiteMasterInicio.Master"   CodeBehind="RegistroUsuariosEmpresas.aspx.cs" Inherits="ActiveSmartWeb.RegistroUsuarioEmpresas.RegistroUsuariosEmpresas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="main-ai" id="context">

      <div id="alertas" class="section-ai">

        <div class="wrapper-registro">

          <div class="w-layout-grid grid-registro-form-ai">

            <div id="w-node-_4cf9cfb8-b9ab-ea9b-532f-5afa6a2bd1e9-b1186ab5" class="div-left-block-ai"></div>

            <div id="w-node-_31a3fdc1-be9a-23d2-42b2-d2ccb2c57212-b1186ab5" class="div-right-form-ai">

              <h4 class="main-t-form-reg-ai">Regístrate para comenzar</h4>

              <p class="p-reg-top-ai">Complete el formulario para empezar a usar la aplicación. </p>

              <div class="form-reg-block-ai w-form">

                <div id="email-form" name="email-form" data-name="Email Form"  class="form-registro-ai w-clearfix">

                  <div class="cols-labels-reg-ai w-row">

                    <div class="col-left-label-ai w-col w-col-6">
                      <label class="lbl-reg-top-ai" v-cloak>{{listaIdiomas.LabelNombrePerfil}}</label>
                    </div>

                    <div class="col-right-label-ai w-col w-col-6">
                      <label class="lbl-reg-top-ai label-last-name-ai" v-cloak>{{listaIdiomas.LabelApellidosPerfil}}</label>
                    </div>

                  </div>
                  
                  <input type="text" class="txt-registro-aii txt-name-reg-ai w-input" 
                  autofocus="true" maxlength="80" name="name" data-name="Name" placeholder="Introduzca su nombre" id="name" v-model="nombreUsuario">

                  <input type="text" class="txt-registro-aii txt-lat-name-reg-ai w-input"
                   autofocus="true" maxlength="80" name="Apellidos" data-name="Apellidos" placeholder="Introduzca sus apellidos" id="Apellidos" v-model="apellidosUsuario">

                  <label for="Cargo" class="lbel-registro-ai">Posición</label>
                  <input type="text" class="txt-registro-aii w-input" autofocus="true" maxlength="80" 
                  name="Cargo" data-name="Cargo" placeholder="Introduzca su cargo laboral" id="Cargo" v-model="posicion">

                  <label for="email-2" class="lbel-registro-ai" v-cloak>{{listaIdiomas.LabelCorreoPerfil}}</label>
                  <input autocomplete="off" type="email" class="txt-registro-aii txt-correc-reg-ai w-input" 
                  autofocus="true" maxlength="80" name="email-2" data-name="Email 2" placeholder="Introduzca su correo electrónico" id="email-2" v-model="correoUsuario">
                  
                  <div class="cols-labels-reg-ai cols-contra-lbls-ai w-row">
                    <div class="col-left-label-ai w-col w-col-6"
                    ><label class="lbl-reg-top-ai" v-cloak>{{listaIdiomas.LabelContrasena}}</label>
                  </div>
                    
                    <div class="col-right-label-ai col-conf-pss-ai w-col w-col-6">
                      <label class="lbl-reg-top-ai label-last-name-ai lbl-con-psswrd-ai" v-cloak>{{listaIdiomas.LabelContrasena1}}</label>
                    </div>
                  </div>

                  <input oncopy = 'return false' oncut = 'return false' onpaste = 'return false' autocomplete="off" type="password"
                      class="txt-registro-aii txt-contrase-a-ai w-input" autofocus="true" maxlength="80" name="email-2" 
                  data-name="Email 2" placeholder="Introduzca su contraseña" id="PswPrincipal" v-model="contrasena">

                  <input oncopy = 'return false' oncut = 'return false' onpaste = 'return false' autocomplete="off" type="password" class="txt-registro-aii txt-confirm-contra-ai w-input" autofocus="true" 
                  maxlength="80" name="email-2" data-name="Email 2" placeholder="Confirme su contraseña" id="email-2" v-model="contrasena1">

                  <label for="email-2" class="lbel-registro-ai" v-cloak>{{listaIdiomas.LabelTelefonoEmpresa}}</label>
                  <div >
                      
                  <input type="tel" class="txt-registro-aii w-input" autofocus="true" maxlength="80" name="email-2" data-name="Email 2" v-model="telefonoEmpresa" v-on:keypress="ValidarSoloNumeros()" 
                      id="telNational" style="display:block; margin: 0; padding: 8px 12px; display:inline-grid" />
                  </div>

                
                  <label for="Empresa" class="lbel-registro-ai" v-cloak>{{listaIdiomas.LabelNombreEmpresa}}</label>
                  <input type="text" class="txt-registro-aii w-input" autofocus="true" maxlength="80" name="Empresa" data-name="Empresa" 
                  placeholder="Introduzca el nombre de la empresa" id="Empresa" v-model="nombreEmpresa">
                  
                  <label for="ID-empresa" class="lbel-registro-ai">ID de la empresa</label>
                  <input type="text" class="txt-registro-aii w-input" autofocus="true" maxlength="80" name="ID-empresa" data-name="ID empresa" 
                  placeholder="Introduzca el ID de la empresa" id="ID-empresa" v-model="idEmpresa">


                   <label for="email-2" class="lbel-registro-ai">País / Región</label>
                  <div>
                      <input type="text" id="country" autofocus="true" maxlength="80" name="email-2" data-name="Email 2"
                      class="txt-registro-aii w-input"  />                                 
                  </div>

                  <div class="cols-labels-reg-ai cols-contra-lbls-ai w-row">
                    <div class="col-left-label-ai w-col w-col-6">
                      <label for="field-2" class="lbl-reg-top-ai">Industria</label></div>
                      
                    <div class="col-right-label-ai col-conf-pss-ai w-col w-col-6">
                      <label for="empleados-2" class="lbl-reg-top-ai label-last-name-ai lbl-con-psswrd-ai">Empleados</label></div>

                  </div>

                    <div style="display:flex;">


                          <select v-cloak id="field" name="field" data-name="Field" class="txt-registro-aii txt-contrase-a-ai w-input" v-model="idIndustria"
                              style="height:40px;">
                            <option selected value="">Seleccione la Industria</option>
                            <option v-for="i in  industrias"  :key="i.IdIndustria" :value="i.IdIndustria">{{i.Nombre}}</option>
                          </select>

                          <select v-cloak id="empleados" name="empleados" data-name="empleados" class="txt-registro-aii txt-confirm-contra-ai w-input" 
                              v-model="idEmpresaTamano" style="clear: right; height:40px;">
                            <option selected value="">Empleados</option>
                            <option v-for="j in  numeroEmpleados"  :key="j.IdEmpresaTamano" :value="j.IdEmpresaTamano">{{j.Rango}}</option>
                          </select>
                  
                    </div>
                  

                  <label for="direccion" class="lbel-registro-ai lbl-direccion-reg-ai">Dirección</label>

                  <textarea id="direccion" name="direccion" maxlength="200" data-name="field"
                   placeholder="Ingrese la dirección" v-model="direccion" autofocus="true" class="textarea-registro-ai w-input">
                  </textarea>

                  <label class="w-checkbox checkbox-registro-ai">
                    <input v-model="chterminos" type="checkbox" name="checkbox" id="checkbox" data-name="Checkbox" required="" 
                    checked="" class="w-checkbox-input chekbox-registro-ai"><span class="label-check-registro-ai w-form-label" 
                    for="checkbox">Estoy de acuerdo con los <a href="#" class="link-reg-ai">
                      <span class="tyc-span-reg-ai">Términos y Condiciones</span></a></span></label>
                 
                    <a href ="ValidarCuenta.aspx">Siguiente</a>
                  <%--<button v-cloak  v-on:click="ObtenerDatosRegistro()" class="btn-siguiente-reg-ai w-button">{{listaIdiomas.BtnSiguiente}}</button>--%>
                </div>
                
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>


    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>   
<script src="https://cdnjs.cloudflare.com/ajax/libs/country-select-js/2.1.1/js/countrySelect.min.js"></script>
 <script src="https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/17.0.18/js/intlTelInput.min.js"></script>
<script src="../VisorActivos/Vue/vue.min.js"></script>
    <script src="../Recursos/JSON/ConsultaMonedas.js"></script>
<script src="js/Registro.js?v=1.2.4"></script>
    </asp:Content>
   

