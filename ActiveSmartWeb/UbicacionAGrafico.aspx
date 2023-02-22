<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UbicacionAGrafico.aspx.cs" Inherits="ActiveSmartWeb.UbicacionAGrafico" %>

<!DOCTYPE html><!--  This site was created in Webflow. http://www.webflow.com  -->
<!--  Last Published: Wed Feb 02 2022 21:47:35 GMT+0000 (Coordinated Universal Time)  -->
<html data-wf-page="61fac864ab028cd5ed85e7ae" data-wf-site="6058e9c14ad3f6bd0eb8c138">
<head>
  <meta charset="utf-8">
  <title>Graficos</title>
  <meta content="Comandas de Pedidos" property="og:title">
  <meta content="Comandas de Pedidos" property="twitter:title">
  <meta content="width=device-width, initial-scale=1" name="viewport">
  <meta content="Webflow" name="generator">
  <link href="css/normalize.css" rel="stylesheet" type="text/css">
  <link href="css/webflow.css" rel="stylesheet" type="text/css">
<link href="Graficos/css/Graficos.css" rel="stylesheet" />
  <script src="https://ajax.googleapis.com/ajax/libs/webfont/1.6.26/webfont.js" type="text/javascript"></script>
  <script type="text/javascript">WebFont.load({ google: { families: ["Montserrat:100,100italic,200,200italic,300,300italic,400,400italic,500,500italic,600,600italic,700,700italic,800,800italic,900,900italic", "Lato:100,100italic,300,300italic,400,400italic,700,700italic,900,900italic", "Oswald:200,300,400,500,600,700"] } });</script>
  <!-- [if lt IE 9]><script src="https://cdnjs.cloudflare.com/ajax/libs/html5shiv/3.7.3/html5shiv.min.js" type="text/javascript"></script><![endif] -->
  <script type="text/javascript">!function (o, c) { var n = c.documentElement, t = " w-mod-"; n.className += t + "js", ("ontouchstart" in o || o.DocumentTouch && c instanceof DocumentTouch) && (n.className += t + "touch") }(window, document);</script>
  <link href="images/favicon.ico" rel="shortcut icon" type="image/x-icon">
  <link href="images/webclip.png" rel="apple-touch-icon">
</head>
<body class="body">

  <div class="div-general comandas">
    <div class="div-block-212">
      <div class="div-block-213">
        <h3 class="heading-9">Graficos</h3>
      </div>
       
          <div class="chart-container" style="position: relative; height:40vh; width:80vw">
              <canvas id="myChart"></canvas>
          </div>
        <div>
              <canvas width="600" height="400"></canvas>
          </div>
           <div>
          </div>
          <div id="ContieneCanvas" class="chart-container" style="position: relative; height:40vh; width:80vw">
             
          </div>
         
           <div>
              <canvas width="600" height="400"></canvas>
          </div>
           <div id="ContieneCanvasC" class="chart-container" style="position: relative; height:40vh; width:80vw">
             
          </div>
           <div>
              <canvas width="600" height="400"></canvas>
          </div>
      
           <div id="ContieneCanvasD" class="chart-container" style="position: relative; height:40vh; width:80vw">
             
          </div>
   
    </div>


<script src="Graficos/js/GraficosUbicacionA.js"></script>
  <script src="https://d3e54v103j8qbb.cloudfront.net/js/jquery-3.5.1.min.dc5e7f18c8.js?site=6058e9c14ad3f6bd0eb8c138" type="text/javascript" integrity="sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0=" crossorigin="anonymous"></script>
  <script src="js/webflow.js" type="text/javascript"></script>
  <!-- [if lte IE 9]><script src="https://cdnjs.cloudflare.com/ajax/libs/placeholders/3.0.2/placeholders.min.js"></script><![endif] -->

    <%--<script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.5.0/Chart.min.js" type="text/javascript"></script>--%>
<script src="Graficos/js/Chart.min.js"></script>
</body>
</html>

