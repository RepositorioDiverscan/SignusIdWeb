<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/SiteMasterInicio.Master" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="ActiveSmartWeb.InicioSesion.InicioSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


<div id="paglogin">

 

    <%--<div class="back-popup-tc none">--%>
    <div v-cloak  id="PopPupEmpresas" class="tarjeta-popup selecem" style="margin: 0 auto; display: none; z-index: 25;">
      <div class="header-modal-ai">
        <h4 class="texto-h-ai">Seleccione su empresa</h4>
      </div>
      <div class="div-icon-exit-ai"><img src="images/icono_eliminar_acces-o-01.svg" loading="lazy" alt="" class="img-salir-ai"></div>
      <div class="form-block-empresa w-form">
        
            <select  v-cloak v-model="empresa" id="field-3" name="field-3" data-name="field" class="select-field empresa w-select">
            <option v-for="emp in empresas" v-bind:value="emp.IdPerfilEmpresa">{{emp.NombreEmpresa}}</option>
          </select>
      </div>
      <a href="#" style="margin-right: 44%" @click="establecerempresa" v-on:keyup.enter="establecerempresa()" class="btn-ingresar-ai w-button">Ingresar</a>
    </div>
  <%--</div>--%>

 

 

  <%-- <login       
       :password="password" 
       :email ="email" 
       :listaidiomalogin="listaidiomalogin" 
       :idiomaLogin="idiomaLogin"
       :intentos=3>
    </login>--%>

 <div class="main-ai" id="alertas">
      <div class="wrap-form-ai">
        <div class="form-block-log-ai w-form">

          <form id="email-form" name="email-form" data-name="Email Form" method="get" class="form-login-ai">
            <label class="txt-login-ai" v-cloak>{{listaidiomalogin.Usuario}}</label>
            <input type="text" 
            v-on:keyup.enter="ValidUser"
            class="txt-user-log-ai w-input" autofocus="true" maxlength="256" name="name"
            data-name="Name" :placeholder="[[listaidiomalogin.Mail]]" id="email" required="" v-model="email" oncopy = 'return false' oncut = 'return false' onpaste = 'return false'>
            <label class="txt-pass-log-ai" v-cloak>{{listaidiomalogin.Contrasenna}}</label>

            <input v-cloak type="password" oncopy = 'return false' oncut = 'return false' onpaste = 'return false'
            v-on:keyup.enter="ValidUser"
            class="txt-passwrd-ai w-input" autofocus="true" maxlength="256" name="email"
            data-name="Email" :placeholder="[[listaidiomalogin.Contrasenna]]"
           id="password" v-model="password" required="">

            <input type="button"

             v-on:click="ValidUser()" v-model="listaidiomalogin.BtnInicio"
           data-wait="Please wait..." class="btn-login-ai w-button">
            <div class="login-cols-ai w-row">
              <div class="col-log-paswrd-ai w-col w-col-8">
                <a href="/Contrasenna/OlvidoContrasenna.aspx" class="p-get-password-ai" v-cloak>{{listaidiomalogin.OlvCon}}</a>
              </div>
              <div class="col-log-reg-ai w-col w-col-4">
                <a href="/RegistroUsuarioEmpresas/RegistroUsuariosEmpresas.aspx" class="p-register-ai" v-cloak>{{listaidiomalogin.Sucribete}}</a>
              </div>
            </div>
          </form>
             </div>
      </div>
    </div>

  
</div>

 

    <script src="js/InicioSesion.js"></script>

</asp:Content>
