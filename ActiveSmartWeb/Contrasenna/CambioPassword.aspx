<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambioPassword.aspx.cs"
    Inherits="ActiveSmartWeb.Contrasenna.CambioPassword" %>

<div id="context"  style=" width: 100%;
  max-width: 600px;
  margin: 0 auto;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;">
   
        <label style="text-align:left;" for="fname">{{listaIdiomas.Password}}</label><br>
        <input id="PswPrincipal" type="password" v-model="password"><br>

        <label style="text-align:left;" for="lname">{{listaIdiomas.ConfirmarPassword}}</label><br>
        <input id="PswConfirm" type="password"  v-model="confirmPassword"><br>
        <br>
        <button  v-on:click="ValidarContrasena()">CAMBIAR</button>

</div>
<script src="../Recursos/JQuery/jquery-3.5.1.min.dc5e7f18c8.js"></script>
<script src="../VisorActivos/Vue/vue.min.js"></script>
<script src="js/CambioPassword.js"></script>
