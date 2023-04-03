<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionExpirada.aspx.cs" Inherits="ActiveSmartWeb.SessionExpirada" %>

<!DOCTYPE html><!--  This site was created in Webflow. https://www.webflow.com  -->
<!--  Last Published: Thu Aug 18 2022 15:41:03 GMT+0000 (Coordinated Universal Time)  -->
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
  <script type="text/javascript">WebFont.load({  google: {    families: ["Lato:100,100italic,300,300italic,400,400italic,700,700italic,900,900italic","Montserrat:100,100italic,200,200italic,300,300italic,400,400italic,500,500italic,600,600italic,700,700italic,800,800italic,900,900italic"]  }});</script>
  <!-- [if lt IE 9]><script src="https://cdnjs.cloudflare.com/ajax/libs/html5shiv/3.7.3/html5shiv.min.js" type="text/javascript"></script><![endif] -->
  <script type="text/javascript">!function(o,c){var n=c.documentElement,t=" w-mod-";n.className+=t+"js",("ontouchstart"in o||o.DocumentTouch&&c instanceof DocumentTouch)&&(n.className+=t+"touch")}(window,document);</script>
    <link href="../images/logo-02.png" rel="shortcut icon" type="image/x-icon">
  <link href="../images/logo-02.png" rel="apple-touch-icon">
</head>
<body>
  <div class="contenedor-general">
    <div class="main">
      <div class="wf-section">
        <div class="container-2 w-container">
          <div class="w-layout-grid grid-main grid-denegado">
            <div id="w-node-_23ce2afc-7b1f-ca8a-482e-aed36e6a037e-f8d3e178" class="div-banner-extremo"></div>
            <div id="w-node-_23ce2afc-7b1f-ca8a-482e-aed36e6a037f-f8d3e178" class="div-metodos-container cont-denegado">
              <div class="diiv-denegado">
                <div class="top-leyenda w-clearfix">
                  <p class="paragraph-9">La sesión ha expirado.</p>
                  <a href="InicioSesion/InicioSesion.aspx" class="link-block-6 w-inline-block"><img src="images/signus_id.png" loading="lazy" width="200" srcset="images/signus_id-p-500.png 500w, images/signus_id-p-800.png 800w, images/signus_id-p-1080.png 1080w, images/signus_id.png 1730w" sizes="200px" alt="" class="logo"></a>
                </div>
              </div>
            </div>
            <div id="w-node-_23ce2afc-7b1f-ca8a-482e-aed36e6a0387-f8d3e178" class="div-banner-extremo"></div>
          </div>
        </div>
      </div>
    </div>  
  </div>
  <script src="https://d3e54v103j8qbb.cloudfront.net/js/jquery-3.5.1.min.dc5e7f18c8.js?site=606dfb37871f33efa37244d4" type="text/javascript" integrity="sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0=" crossorigin="anonymous"></script>
  <script src="js/webflow.js" type="text/javascript"></script>
  <!-- [if lte IE 9]><script src="https://cdnjs.cloudflare.com/ajax/libs/placeholders/3.0.2/placeholders.min.js"></script><![endif] -->

<script>

        setInterval(function () {
            inicio();
        }, 10000)
    

    var idioma = localStorage.getItem("idiomaApp");

    var dUser = sessionStorage.getItem('DUser');

    if (idioma == 'ES') {
        document.getElementById('Texto').innerText = 'Acceso denegado ¡Por favor regrese!';
    } else{
        document.getElementById('Texto').innerText = 'Access denied Please come back!';
    }


    function inicio() {
        window.location.href = window.location.origin + "/InicioSesion/InicioSesion.aspx";
    }

</script>


</body>
</html>
