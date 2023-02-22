<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccesoDenegado.aspx.cs" Inherits="ActiveSmartWeb.AccesoDenegado" %>

<!DOCTYPE html><!--  This site was created in Webflow. https://www.webflow.com  -->
<!--  Last Published: Mon Oct 31 2022 19:21:47 GMT+0000 (Coordinated Universal Time)  -->
<html data-wf-page="62fd4754bb03427a725d6f80" data-wf-site="606dfb37871f33efa37244d4">
<head>
  <meta charset="utf-8">
  <title>Acceso denegado</title>
  <meta content="Acceso denegado" property="og:title">
  <meta content="Acceso denegado" property="twitter:title">
  <meta content="width=device-width, initial-scale=1" name="viewport">
  <meta content="Webflow" name="generator">
  <link href="css/normalize.css" rel="stylesheet" type="text/css">
  <link href="css/webflow.css" rel="stylesheet" type="text/css">
  <link href="css/signusid.webflow.css" rel="stylesheet" type="text/css">
  <script src="https://ajax.googleapis.com/ajax/libs/webfont/1.6.26/webfont.js" type="text/javascript"></script>
  <script type="text/javascript">WebFont.load({ google: { families: ["Lato:100,100italic,300,300italic,400,400italic,700,700italic,900,900italic", "Montserrat:100,100italic,200,200italic,300,300italic,400,400italic,500,500italic,600,600italic,700,700italic,800,800italic,900,900italic"] } });</script>
  <!-- [if lt IE 9]><script src="https://cdnjs.cloudflare.com/ajax/libs/html5shiv/3.7.3/html5shiv.min.js" type="text/javascript"></script><![endif] -->
  <script type="text/javascript">!function (o, c) { var n = c.documentElement, t = " w-mod-"; n.className += t + "js", ("ontouchstart" in o || o.DocumentTouch && c instanceof DocumentTouch) && (n.className += t + "touch") }(window, document);</script>
  <link href="images/favicon.ico" rel="shortcut icon" type="image/x-icon">
  <link href="images/webclip.png" rel="apple-touch-icon">
</head>
<body>
  <div class="contenedor-general">
    <div class="main">
      <div class="wf-section">
        <div class="container-2 w-container">
          <div class="w-layout-grid grid-main grid-denegado">
            <div id="w-node-_6bce17b8-1f99-3688-78ea-cfef2b517def-725d6f80" class="div-banner-extremo"></div>
            <div id="w-node-_6bce17b8-1f99-3688-78ea-cfef2b517df6-725d6f80" class="div-metodos-container cont-denegado">
              <div class="diiv-denegado">
                <div class="top-leyenda w-clearfix">
                  <a href="../InicioSesion/InicioSesion.aspx" class="link-block-back-3 link-go-ai go-back-denegado w-inline-block"><img src="images/Back-arrow.svg" loading="lazy" height="26" width="26" alt="" class="back"></a>
                  <p class="paragraph-9">Acceso denegado.</p>
                </div><img src="images/signus_id.png" loading="lazy" width="200" srcset="images/signus_id-p-500.png 500w, images/signus_id-p-800.png 800w, images/signus_id-p-1080.png 1080w, images/signus_id.png 1730w" sizes="200px" alt="" class="logo">
              </div>
            </div>
            <div id="w-node-_6bce17b8-1f99-3688-78ea-cfef2b517df5-725d6f80" class="div-banner-extremo"></div>
          </div>
        </div>
      </div>
    </div>
  </div>
  <script src="https://d3e54v103j8qbb.cloudfront.net/js/jquery-3.5.1.min.dc5e7f18c8.js?site=606dfb37871f33efa37244d4" type="text/javascript" integrity="sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0=" crossorigin="anonymous"></script>
  <script src="js/webflow.js" type="text/javascript"></script>
  <!-- [if lte IE 9]><script src="https://cdnjs.cloudflare.com/ajax/libs/placeholders/3.0.2/placeholders.min.js"></script><![endif] -->

<script>

    var idioma = localStorage.getItem("idiomaApp");

    var dUser = sessionStorage.getItem('DUser');

    if (idioma == 'ES') {
        document.getElementById('Texto').innerText = 'Acceso denegado ¡Por favor regrese!';
    } else{
        document.getElementById('Texto').innerText = 'Access denied Please come back!';
    }

    function Denegar() {
        if (dUser == null) {
            window.location.href = 'Login.aspx'
        } else {
            window.history.back()
        }
    }

</script>


</body>
</html>
