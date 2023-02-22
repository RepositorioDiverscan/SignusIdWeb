<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Planes.aspx.cs" Inherits="ActiveSmartWeb.RegistroUsuarioEmpresas.Planes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <style>.grid-container {
  display: grid;
  grid-template-columns: auto auto auto;
  background-color: #2196F3;
  padding: 15px;

  margin-left:20%;
  margin-right:20%
}
.grid-item {
  background-color: rgba(255, 255, 255, 0.8);
  border: 5px solid #2196F3;;
  padding: 20px;
  font-size: 30px;
  text-align: center;
}</style>
</head>
<body>
    
        <div id="context">
            <h1 style="text-align:center;">Planes</h1>

            <div class="grid-container">
                <div  class="grid-item"> <input v-model="plan" type="radio" name="plan" id="free" value = "1">   <label for="html">Free</label> <h3>El plan gratuito</h3> </div>
                <div  class="grid-item"><input v-model="plan" type="radio"  name="plan" id="basic" value = "2">   <label for="html">Basic</label> <h3> El plan basico para tus activos </h3> </div>
                <div class="grid-item"><input v-model="plan" type="radio" name="plan" id="pro" value = "3">   <label for="html">Pro</label> <h3>El plan mas completo para tus activos</h3> </div>  
            </div>

    
    <input type="button" value="Guardar" v-on:click="InsertarUsuariosEmpresas()"/> 

        </div>
  


    

    <script src="../Recursos/Vue/vue.js"></script>
    <%--<script src="../Recursos/JQuery/jquery-3.5.1.min.dc5e7f18c8.js"></script> --%>
    <script src="../Recursos/JQuery/jquery.min.js"></script>
    <script src="js/Registro.js"></script>
</body>
</html>
