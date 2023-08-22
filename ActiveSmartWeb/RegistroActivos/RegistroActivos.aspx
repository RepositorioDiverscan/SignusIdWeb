<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/Site.Master" AutoEventWireup="true" CodeBehind="RegistroActivos.aspx.cs" Inherits="ActiveSmartWeb.RegistroActivos.RegistroActivos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="main">
      <div class="main" id="registroactivosVUE">
      <div class="section wf-section" id="alertas">
        <div class="container-2 w-container">
          <div class="w-layout-grid grid-main grid-main-registro">
            <div id="w-node-_87695020-6f5c-ec03-bb3a-4174fa111f76-2106bd5d" class="div-banner-extremo"></div>
            <div id="w-node-_87695020-6f5c-ec03-bb3a-4174fa111f77-2106bd5d" class="div-banner-extremo"></div>
            <div id="w-node-b2b454db-f944-4f86-8396-8e297f8863d7-2106bd5d" class="div-title-a">
              <div class="w-layout-grid grid-container-title" style="padding-top:7px; padding-bottom:6px">
                <a href="#" onclick="window.history.back()" class="link-block-back w-inline-block"><img src="../images/Back-arrow.svg" loading="lazy" height="26" width="26" alt="" class="back"></a>
                <h1 id="w-node-_9be28721-5dbb-5f12-6325-d0dcd6cba1e6-ffdc8228" class="titulo-principal" v-cloak>{{listaidiomaRegistroActivo.Titulo}}</h1> 
                  <div data-hover="false" data-delay="0" id="w-node-_01c345db-44dd-5950-8797-fc0e77f5b71f-731f63ba" class="dropdown-detalles-ai w-dropdown">
                  <div class="toggle-detalles-ai w-dropdown-toggle" style="padding:0px"><img src="../images/info2.svg" loading="lazy" alt="" class="img-detalles-ai"></div>
                  <nav class="detalles-descrp-ai w-dropdown-list">
                    <p class="p-desc-detalles-ai" v-cloak>{{listaidiomaRegistroActivo.Ms1}} <strong><br>{{listaidiomaRegistroActivo.Ms2}}</strong></p> 
                  </nav>
                </div>
              </div>
            </div>
            <div id="w-node-bfbebe24-e91b-8d4c-ea7f-36ace24ace5d-2106bd5d" class="div-tarjeta buscador-activos-ai tarjeta-registro">
              <div class="form-block w-form">
                <div id="email-form" name="email-form" data-name="Email Form" method="get" class="form">
                  <div class="w-layout-grid grid-busqueda grid-buscar-activo"><label for="name-5" id="w-node-c7c5851e-202c-9f56-4042-6b2b1ea7c78b-2106bd5d" class="field-label label-buscar" v-cloak>{{listaidiomaRegistroActivo.Buscar}}</label>
                      <select v-cloak id="field-4" v-model="Seleccion"  name="field-4" data-name="Field 4" class="select-field select-filtro w-node-bfbebe24-e91b-8d4c-ea7f-36ace24ace65-2106bd5d w-select">
                      <option value="0">{{listaidiomaRegistroActivo.SelectFiltro}}</option> 
                      <option value="1" selected>{{listaidiomaRegistroActivo.NumActivo}}</option> 
                      <option value="2">{{listaidiomaRegistroActivo.NFEti}}</option> 
                    </select>
                    <div id="w-node-bfbebe24-e91b-8d4c-ea7f-36ace24ace61-2106bd5d" class="contenedor-buscar cont-search"><input type="text" class="text-field w-input" v-on:keyup.enter="BuscarActivo" v-model="numeroActivo" maxlength="80" name="searh" data-name="searh" placeholder="" id="searh">
                      <a  v-on:click="BuscarActivo" href="#" class="contenedor-icono w-inline-block"><img src="../images/icono_buscar_acces-o-01.svg" loading="lazy" alt=""></a>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div id="w-node-_87695020-6f5c-ec03-bb3a-4174fa111f7e-2106bd5d" class="div-tarjeta tarjeta-registro">
              <div class="form-block w-form">
                <div id="email-form" name="email-form" data-name="Email Form" method="get" class="form">
                  <div class="w-layout-grid grid-form">

                    <div id="w-node-_87695020-6f5c-ec03-bb3a-4174fa111f82-2106bd5d" class="form-line"><label for="name-5"  class="field-label" v-cloak>{{listaidiomaRegistroActivo.NumActivo}}</label> 
                        <input disabled type="text" class="text-field w-input" v-model="txtnumActivo" maxlength="80" name="name-4" data-name="Name 4" placeholder="" id="nActivo"></div>
                   
                      <div id="w-node-_5f3d9e97-34c6-4c7a-c0af-e153521f43bc-2106bd5d" class="form-line"><label for="name-5" class="field-label" v-cloak>{{listaidiomaRegistroActivo.NumPlaca}}</label>
                          <input type="text" class="text-field w-input" v-model="numPlaca" maxlength="80" name="name-4" data-name="Name 4" placeholder="" id="nPlaca"></div>
                    <div id="w-node-c9a4d20a-fe8d-a437-9ed9-31a992874599-2106bd5d" class="form-line">
                        <label for="name-5" class="field-label" v-cloak>{{listaidiomaRegistroActivo.Categoria}}</label> 
                        
                        <select v-cloak id="selCat" name="field-4" v-on:change="ObtenerDescripcionCategoria"  v-bind:style="editarselect" v-model="selectCategoria" data-name="Field 4" class="select-field w-select">
                        <option value="0">{{listaidiomaRegistroActivo.SelectUbi}}</option> 
                        <option v-for="ubi in Categorias" :key="ubi.IdCategoriaActivo" :value="ubi.IdCategoriaActivo"  >{{ubi.NombreCategoria}}</option >                                          
                      </select></div>


                    <div id="w-node-ed5adf6d-e2d1-95b0-5168-866a50deba40-2106bd5d" class="form-line"><label for="field-4" class="field-label">{{listaidiomaRegistroActivo.Estado}}</label>  
                      <select v-cloak id="selEst" name="field-4" v-on:change="ObtenerDescripcionEstados" v-model="selectEstado"  data-name="Field 4" class="select-field w-select">
                        <option value="0">{{listaidiomaRegistroActivo.SelectUbi}}</option> 
                        <option v-for="estado in Estados" :key="estado.IdEstadoActivo" :value="estado.IdEstadoActivo"  >{{estado.NombreEstado}}</option >
                      </select></div>


                    <div id="w-node-c85d08fd-8f30-e283-590c-ebaa080b8048-2106bd5d" class="form-line"><label v-cloak for="name-5" class="field-label">{{listaidiomaRegistroActivo.Marca}}</label> 
                        <input v-bind:disabled="editarcampos" type="text" v-model="marca" class="text-field w-input" maxlength="50" name="name-4" data-name="Name 4" placeholder="" id="marca"></div>
                    <div id="w-node-e462f054-586b-dc08-bbfc-3cd35a18ede3-2106bd5d" class="form-line"><label v-cloak for="name-5" class="field-label">{{listaidiomaRegistroActivo.Modelo}}</label> 
                        <input v-bind:disabled="editarcampos" type="text" v-model="modelo"  class="text-field w-input" maxlength="50" name="name-4" data-name="Name 4" placeholder="" id="modelo"></div>

                    <div id="w-node-_9e8e6069-b991-1517-a8fd-bd574f24680f-2106bd5d" class="form-line"><label v-cloak for="name-5" class="field-label">{{listaidiomaRegistroActivo.Ubicacion}}</label> 
                        <select v-cloak id="selU" name="field-4"  v-model="selectUbicacion"  data-name="Field 4" class="select-field w-select">
                        <option value="0">{{listaidiomaRegistroActivo.SelectUbi}}</option> 
                        <option v-for="ubicacion in Ubicaciones" :key="ubicacion.IdUbicacionA" :value="ubicacion.IdUbicacionA" >{{ubicacion.Nombre}}</option >    
                     </select></div>




                    <div id="w-node-_8faaaf60-83b7-62d5-90e1-7a4a277fd5e3-2106bd5d" class="form-line"><label for="name-5" class="field-label" v-cloak>{{listaidiomaRegistroActivo.NumeroSerie}}</label> 
                        <input v-bind:disabled="editarcampos" type="text" v-model="numSerie" class="text-field-11 w-input" maxlength="80" name="field-5" data-name="Field 5" placeholder="" id="serie" required=""></div>
                    <div id="w-node-f458b917-f9d6-b2a4-56bf-a2ccbcab8e05-2106bd5d" class="form-line"><label for="name-5" class="field-label" v-cloak >{{listaidiomaRegistroActivo.DescripcionCorta}}</label> 
                        <input type="text" v-model="descripCorta" class="text-field-12 w-input" maxlength="50" name="field-5" data-name="Field 5" placeholder="" id="descCorta" required=""></div>
                    <div id="w-node-_73f94c8e-1f62-764b-6381-d7810db00f77-2106bd5d" class="form-line"><label for="name-5" class="field-label" v-cloak>{{listaidiomaRegistroActivo.DescripcionCategoria}}</label> 
                        <input type="text" v-model="descripcionCategoria" class="text-field-13 w-input" maxlength="80" name="field-5" data-name="Field 5" placeholder="" id="field-5" required="" disabled="disabled"></div>
                    <div id="w-node-_0e22c0da-cfd1-5848-1eaf-b5be00d8d6f2-2106bd5d" class="form-line"><label for="name-5" class="field-label" v-cloak>{{listaidiomaRegistroActivo.DescripcionEstado}}</label> 
                        <input  type="text" v-model="descripEstado" class="text-field-14 w-input" maxlength="80" name="field-5" data-name="Field 5" placeholder="" id="field-5" required="" disabled="disabled"></div>
                    <div id="w-node-d5e55e7c-4128-2247-a011-1ce7d3a2a0d5-2106bd5d" class="form-line"><label for="name-5" class="field-label" v-cloak>{{listaidiomaRegistroActivo.NumeroFactura}}</label> 
                        <input v-bind:disabled="editarcampos" type="text" v-model="numFactura" class="text-field-9 w-input" maxlength="80" name="field-5" data-name="Field 5" placeholder="" id="nFactura" required=""></div>
                    <div id="w-node-fa236aec-8879-8489-8b60-9146962aa33c-2106bd5d" class="form-line"><label for="name-5" class="field-label" v-cloak>{{listaidiomaRegistroActivo.FechaCompra}}</label> 
                      <div class="div-fecha"><input type="date" v-model="fechaCompra" class="text-field w-input" maxlength="80" name="FECHA-3" data-name="FECHA 3" id="FechaC"  :max="fechaHoy" @mouseout="ValidarFecha()"><img v-on:click="AbrirDatePicker('FechaC')" src="../images/calendar.svg" loading="lazy" alt="" class="contenedor-icono cal"></div>
                    </div>
                    <div id="w-node-_3895fd63-ed75-d65e-92f7-d7ab59ea7761-2106bd5d" class="form-line"><label for="name-5" class="field-label" v-cloak>{{listaidiomaRegistroActivo.Costo}}</label> 
                        <input type="number" v-bind:disabled="editarcampos" v-model="costoActivo" class="text-field-11 w-input" autofocus="true" maxlength="80" name="field-5" data-name="Field 5" placeholder="" id="costo" required=""></div>
                    <div id="w-node-_87695020-6f5c-ec03-bb3a-4174fa111f8a-2106bd5d" class="contenedor-botones">
                      <a href="#" v-on:click="GuardarRegistroActivos" class="link-block-boton dere w-inline-block"><img src="../images/save_blanco.svg" loading="lazy" alt=""></a>
                      <a href="#"  v-on:click="BorrarDatos" class="link-block-boton dere w-inline-block"><img src="../images/eraser.svg" loading="lazy" alt=""></a>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div id="w-node-_67ea17a5-0864-b43e-d363-995e3e85454f-2106bd5d" class="div-tarjeta div-cinta">
              <div class="div-block-170">
                <div class="text-block-17" v-cloak> {{listaidiomaRegistroActivo.MsjTienda}}</div> 
                <a href="../Tienda/Tienda.aspx" class="boton call2action w-button" v-cloak>{{listaidiomaRegistroActivo.MsjBtnTienda}}<strong></strong></a> 
              </div>
            </div>
            <div id="w-node-aa3c62d1-2c7e-3084-f639-dda43903fc83-2106bd5d" class="div-tarjeta tarjeta-registro">
              <div class="w-form">
                <div id="email-form-2" name="email-form-2" data-name="Email Form 2" method="get">
                  <div class="w-layout-grid grid-form premsec">
                    <div id="w-node-_694fea24-b243-f518-0293-f243acc98c4b-2106bd5d" class="form-line"><label for="name-5" class="field-label na">{{listaidiomaRegistroActivo.NumParteActivo}}</label> 
                        <input type="text" v-bind:disabled="NumParteActivo" class="text-field-9 w-input" maxlength="80" name="field-5" data-name="Field 5" placeholder="" id="field-5" required=""></div>
                    <div id="w-node-d4714e0e-8612-88fd-8b77-f04946d4673b-2106bd5d" class="form-line"><label class="w-checkbox checkbox-field deprec"><input type="checkbox" id="checkbox" name="checkbox" v-bind:disabled="Decreciado" data-name="Checkbox" class="w-checkbox-input"><span class="checkbox-label w-form-label" for="checkbox" v-cloak>{{listaidiomaRegistroActivo.Depreciado}}</span></label></div>
                    <div id="w-node-c5246496-ecb3-4592-ede0-1f8a39395725-2106bd5d" class="form-line"><label for="name-5" class="field-label" v-cloak>{{listaidiomaRegistroActivo.Descripcion}}</label> 
                        <input type="text" v-bind:disabled="Descripcion" class="text-field-9 w-input" maxlength="80" name="field-5" data-name="Field 5" placeholder="" id="field-5" required=""></div>
                    <div id="w-node-f3b11203-8271-e7a3-1e1c-ceee98785f71-2106bd5d" class="form-line"><label for="name-5" class="field-label" v-cloak>{{listaidiomaRegistroActivo.DiasvidaU}}</label> 
                        <input type="text" v-bind:disabled="VidaUtil" class="text-field-9 w-input" maxlength="80" name="field-5" data-name="Field 5" placeholder="" id="field-5" required=""></div>
                    <div id="w-node-_297d8f35-65d9-93c6-b606-9bb3fc5ad9e0-2106bd5d" class="form-line"><label for="name-5" class="field-label" v-cloak> {{listaidiomaRegistroActivo.CuentaContable}}</label> 
                        <input type="text" v-bind:disabled="CuentaContable"class="text-field-9 w-input" maxlength="80" name="field-5" data-name="Field 5" placeholder="" id="field-5" required=""></div>
                    <div id="w-node-_0c775fe9-c69c-d3b2-769b-99c5ef00706d-2106bd5d" class="form-line"><label for="name-5" class="field-label" v-cloak>{{listaidiomaRegistroActivo.CentroCostos}}</label> 
                        <input type="text" v-bind:disabled="CentroCostos" class="text-field-9 w-input" maxlength="80" name="field-5" data-name="Field 5" placeholder="" id="field-5" required=""></div>
                    <div id="w-node-ec189693-5d0e-234a-342c-3ceed00ef456-2106bd5d" class="form-line"><label for="name-5" class="field-label" v-cloak>{{listaidiomaRegistroActivo.DescripcionEstado}}</label> 
                        <input type="text" v-bind:disabled="DesEst" class="text-field-9 w-input" maxlength="80" name="field-5" data-name="Field 5" placeholder="" id="field-5" required=""></div>
                    <div id="w-node-_321d266b-436a-b49d-a31d-be83ba487c51-2106bd5d" class="form-line"><label for="name-5" class="field-label" v-cloak>Tag/ECP</label><input type="text" v-bind:disabled="TagECP" class="text-field-9 w-input" maxlength="80" name="field-5" data-name="Field 5" placeholder="" id="field-5" required=""></div>
                    <div id="w-node-_59ef7327-c658-b751-f955-70f2322cb831-2106bd5d" class="form-line line-reg-inv"><label for="name-5" class="field-label" v-cloak>{{listaidiomaRegistroActivo.Empleado}}</label> 
                        <select v-cloak v-bind:style="NSelect"  id="field-6" name="field-6" data-name="field" class="select-field w-select">
                       <option value="0">{{listaidiomaRegistroActivo.SelectUbi}}</option> 
                      </select></div>
                    <div id="w-node-_68c4999e-4d38-87a5-5339-41267034b771-2106bd5d" class="form-line line-reg-inv"><label for="name-5" class="field-label" v-cloak>{{listaidiomaRegistroActivo.UbicacionB}}</label> <!-- Ubicación B --> 
                        <select v-cloak v-bind:style="NSelect" id="field-6" name="field-6" data-name="field" class="select-field w-select">
                        <option value="0">{{listaidiomaRegistroActivo.SelectUbi}}</option> 
                      </select></div>
                    <div id="w-node-_57d1d025-623e-3039-6160-24fb723f6d52-2106bd5d" class="form-line line-reg-inv"><label for="name-5" class="field-label" v-cloak>{{listaidiomaRegistroActivo.UbicacionC}}</label> <!-- Ubicación C -->
                        <select v-cloak v-bind:style="NSelect" id="field-6" name="field-6" data-name="field" class="select-field w-select">
                        <option value="0">{{listaidiomaRegistroActivo.SelectUbi}}</option> 
                      </select></div>
                    <div id="w-node-_10e068bb-c32c-699c-18ba-3f729408104e-2106bd5d" class="form-line line-reg-inv"><label for="name-5" class="field-label" v-cloak>{{listaidiomaRegistroActivo.UbicacionD}}</label> <!-- Ubicación D -->
                        <select v-cloak v-bind:style="NSelect" id="field-6" name="field-6" data-name="field" class="select-field w-select">
                        <option value="0">{{listaidiomaRegistroActivo.SelectUbi}}</option> 
                      </select></div>
                    <div id="w-node-_8a1ebf1f-43dd-e33b-1fab-2707a48d82b5-2106bd5d" class="form-line line-reg-inv"><label for="name-5" class="field-label" v-cloak>{{listaidiomaRegistroActivo.FechaGarantia}}</label> <!-- Fecha de Garantía -->
                      <div class="div-fecha"><input  v-bind:disabled="FechaG" type="date" class="text-field w-input" maxlength="256" name="FECHA-3" data-name="FECHA 3" id="Fechagarantia" v-model="Fechagarantia" ><img src="../images/calendar.svg" loading="lazy" alt="" class="contenedor-icono cal"></div>
                    </div>
                    <div id="w-node-_7233447d-1dec-b326-5eff-659847d6b539-2106bd5d" class="form-line line-reg-inv"><label v-cloak for="name-5" class="field-label">{{listaidiomaRegistroActivo.Color}}</label> <!-- Color -->
                        <input type="text" v-bind:disabled="Color" class="text-field-9 w-input" maxlength="80" name="field-5" data-name="Field 5" placeholder="" id="field-5" required=""></div>
                    <div id="w-node-f446de3d-5772-01ec-ff1a-0def333a72fb-2106bd5d" class="form-line line-reg-inv"><label v-cloak for="name-5" class="field-label">{{listaidiomaRegistroActivo.TamañoMed}}</label> <!-- Tamaño/Medida -->
                        <input type="text" v-bind:disabled="Tam" class="text-field-9 w-input" maxlength="80" name="field-5" data-name="Field 5" placeholder="" id="field-5" required=""></div>
                    <div id="w-node-_160a73a7-2c4e-fa37-15da-52a0c727a3ee-2106bd5d" class="form-line line-reg-inv"><label v-cloak for="name-5" class="field-label">{{listaidiomaRegistroActivo.Observaciones}}</label> <!-- Observaciones -->
                        <textarea v-bind:disabled="Observ" placeholder="" maxlength="200" id="field-3" name="field-3" data-name="field" class="textarea w-input"></textarea></div>
                  </div>
                </div>
              </div>
            </div>
            <!--<div id="w-node-_00d2d577-74a7-9579-ec29-920859061c5d-2106bd5d" class="div-tarjeta tarjeta-registro tarjeta-imgs-ai">
              <div class="form-block form-titulo-ig w-form">
                <div id="email-form" name="email-form" data-name="Email Form" method="get" class="form"><label class="field-label-6 titulo-fotos-ai">{{listaidiomaRegistroActivo.Fotos}}</label></div>
                <div class="w-form-done">
              </div>
              <div class="w-layout-grid grid-6 grid-imgs-registro-ai">
                <a href="#" id="w-node-_00d2d577-74a7-9579-ec29-920859061c69-2106bd5d" class="lightbox-link lbox-img-ai w-inline-block w-lightbox"><img src="../images/caracteristicas-clave-silla-escritorio-despacho-ergonomicas-hola-decoracion-m.jpg" loading="lazy" alt="" class="img-registro-ai">
                  <script type="application/json" class="w-json">{
  "items": [
    {
      "_id": "example_img",
      "origFileName": "caracteristicas-clave-silla-escritorio-despacho-ergonomicas-hola-decoracion-m.jpg",
      "fileName": "caracteristicas-clave-silla-escritorio-despacho-ergonomicas-hola-decoracion-m.jpg",
      "fileSize": 91148,
      "height": 500,
      "url": "../images/caracteristicas-clave-silla-escritorio-despacho-ergonomicas-hola-decoracion-m.jpg",
      "width": 500,
      "type": "image"
    }
  ],
  "group": ""
}
                  </script>
                </a>
                <a href="#" id="w-node-_00d2d577-74a7-9579-ec29-920859061c6b-2106bd5d" class="lightbox-link lbox-img-ai w-inline-block w-lightbox"><img src="../images/elegir-silla-escritorio-4-a.jpg" loading="lazy" alt="" class="img-registro-ai">
                  <script type="application/json" class="w-json">{
  "items": [
    {
      "_id": "example_img",
      "origFileName": "elegir-silla-escritorio-4-a.jpg",
      "fileName": "elegir-silla-escritorio-4-a.jpg",
      "fileSize": 67813,
      "height": 500,
      "url": "../images/elegir-silla-escritorio-4-a.jpg",
      "width": 500,
      "type": "image"
    }
  ],
  "group": ""
}</script>
                </a>
                <a href="#" id="w-node-_15b1279f-6f3e-e08c-6c98-636f3db18785-2106bd5d" class="lightbox-link lbox-img-ai w-inline-block w-lightbox"><img src="../images/Null-Image.jpg" loading="lazy" alt="" class="img-registro-ai">
                  <script type="application/json" class="w-json"><%--{
  "items": [
    {
      "_id": "example_img",
      "origFileName": "elegir-silla-escritorio-4-a.jpg",
      "fileName": "elegir-silla-escritorio-4-a.jpg",
      "fileSize": 67813,
      "height": 500,
      "url": "images/elegir-silla-escritorio-4-a.jpg",
      "width": 500,
      "type": "image"
    }
  ],
  "group": ""
}--%></script>
                </a>
                <a href="#" id="w-node-_3dd32405-56c5-5c9a-d677-9a44f82a1109-2106bd5d" class="lightbox-link lbox-img-ai w-inline-block w-lightbox"><img src="../images/Null-Image.jpg" loading="lazy" alt="" class="img-registro-ai">
                  <script type="application/json" class="w-json"><%--{
  "items": [
    {
      "_id": "example_img",
      "origFileName": "elegir-silla-escritorio-4-a.jpg",
      "fileName": "elegir-silla-escritorio-4-a.jpg",
      "fileSize": 67813,
      "height": 500,
      "url": "images/elegir-silla-escritorio-4-a.jpg",
      "width": 500,
      "type": "image"
    }
  ],
  "group": ""
}--%></script>
                </a>
                <a href="#" id="w-node-e3307fe0-6733-718b-f500-bda54739e941-2106bd5d" class="lightbox-link lbox-img-ai w-inline-block w-lightbox"><img src="../images/Null-Image.jpg" loading="lazy" alt="" class="img-registro-ai">
                  <script type="application/json" class="w-json"><%--{
  "items": [
    {
      "_id": "example_img",
      "origFileName": "elegir-silla-escritorio-4-a.jpg",
      "fileName": "elegir-silla-escritorio-4-a.jpg",
      "fileSize": 67813,
      "height": 500,
      "url": "images/elegir-silla-escritorio-4-a.jpg",
      "width": 500,
      "type": "image"
    }
  ],
  "group": ""
}--%></script>
                </a>
                <div id="w-node-_00d2d577-74a7-9579-ec29-920859061c98-2106bd5d" class="w-form">
                  <div id="email-form-3" name="email-form-3" data-name="Email Form 3" method="get"><label for="name-5" class="field-label-7 text-img-ai">{{listaidiomaRegistroActivo.Foto1}}</label></div>
                  
                </div>
                <div id="w-node-_81664fd7-1946-7551-acae-be7d6d9a867c-2106bd5d" class="w-form">
                  <div id="email-form-3" name="email-form-3" data-name="Email Form 3" method="get"><label for="name-5" class="field-label-7 text-img-ai">{{listaidiomaRegistroActivo.Foto2}}</label></div>
                 
                </div>
                <div id="w-node-_8e473740-7d0b-01ce-6f8e-aac628291617-2106bd5d" class="w-form">
                  <div id="email-form-3" name="email-form-3" data-name="Email Form 3" method="get"><label for="name-5" class="field-label-7 text-img-ai">{{listaidiomaRegistroActivo.Foto3}}</label></div>
                 
                </div>
                <div id="w-node-b358bfaa-1f01-28a2-2929-c4b6a8dd9f3b-2106bd5d" class="w-form">
                  <div id="email-form-3" name="email-form-3" data-name="Email Form 3" method="get"><label for="name-5" class="field-label-7 text-img-ai">{{listaidiomaRegistroActivo.Foto4}}</label></div>
                 
                </div>
                <div id="w-node-eb5d6e11-9cba-71a4-40e7-ba5dd1e2c045-2106bd5d" class="w-form">
                  <div id="email-form-3" name="email-form-3" data-name="Email Form 3" method="get"><label for="name-5" class="field-label-7 text-img-ai">{{listaidiomaRegistroActivo.Foto5}}</label></div>
                  
                </div>
              </div>
            </div>
          </div>-->
        </div>
      </div>
    </div>

  </div>
    </div>
    <style>
         /*ocultar controles de input date*/  
     input[type="date"]::-webkit-inner-spin-button,
                  ::-webkit-calendar-picker-indicator{
        display: none;
    }

    </style>
    <script src="../Recursos/JQuery/jquery-3.5.1.min.dc5e7f18c8.js"></script>
    <link href="../css/signusid.webflow.css" rel="stylesheet" />
    <script src="js/RegistroActivos.js"></script>
</asp:Content>
