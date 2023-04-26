<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/Site.Master" AutoEventWireup="true" CodeBehind="TomaFisicaEncabezado.aspx.cs" Inherits="ActiveSmartWeb.TomaFisica.TomaFisicaEncabezado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
<div class="main" id="toma">
    <div class="section wf-section" id="alertas">
      <div class="container-2 w-container">
        <div class="w-layout-grid grid-main grid-add-toma">
          <div id="w-node-d648a741-eb22-8676-6b39-5000b52a816c-53d8c7b1" class="div-banner-extremo"></div>
          <div id="w-node-d648a741-eb22-8676-6b39-5000b52a816d-53d8c7b1" class="div-banner-extremo"></div>
          <div id="w-node-d648a741-eb22-8676-6b39-5000b52a816e-53d8c7b1">
            <div class="w-layout-grid grid-container-title" style="padding-top:10px; padding-bottom:10px">
              <a href="../Tomafisica/TomaFisica.aspx" class="link-block-back w-inline-block"><img src="../images/Back-arrow.svg" loading="lazy" height="26" width="26" alt="" class="back"></a>
              <h1 v-if="!editando" id="w-node-d648a741-eb22-8676-6b39-5000b52a8172-53d8c7b1" class="titulo-principal" v-cloak>{{Listaidiomas.Titulo}}</h1> 
              <h1 v-if="editando" id="w-node-d648a741-eb22-8676-6b39-5000b52a8172-53d8c7b1" class="titulo-principal" v-cloak>{{Listaidiomas.TituloEditando}}</h1> 
                <div data-hover="false" data-delay="0" id="w-node-_01c345db-44dd-5950-8797-fc0e77f5b71f-731f63ba" class="dropdown-detalles-ai w-dropdown">
                  <div class="toggle-detalles-ai w-dropdown-toggle" style="padding:0px"><img src="../images/info2.svg" loading="lazy" alt="" class="img-detalles-ai"></div>
                  <nav class="detalles-descrp-ai w-dropdown-list">
                    <p class="p-desc-detalles-ai" v-cloak>{{Listaidiomas.Msj1}}<strong><br>{{Listaidiomas.Msj2}}</strong></p> 
                  </nav>
                </div>
            </div>
          </div>
          <div id="w-node-d648a741-eb22-8676-6b39-5000b52a8174-53d8c7b1" class="div-tarjeta tarjeta-toma tarjeta-responsive">
            <div class="form-block w-form">
             
                <div class="w-layout-grid grid-form grid-add-toma">
                  <div id="w-node-_3c615a3e-97b2-a095-a9a2-7c542956b230-53d8c7b1" class="form-line line-toma fecha">
                    <label for="name-5" class="field-label" v-cloak>{{Listaidiomas.FechaInicial}}</label> 
                    <div class="div-fecha"><input type="date" class="text-field w-input" maxlength="80" name="FECHA-3" data-name="FECHA 3" placeholder="DD / MM / AAAA"  id="fechaDesde" v-model="fechaInicial" :min="fechaHoy" @mouseout="ValidarFechaInicial()">
                      <a href="#" class="contenedor-icono w-inline-block"><img v-on:click="AbrirDatePicker('fechaDesde')" src="../images/calendar.svg" loading="lazy" alt=""></a>
                    </div>
                  </div>
                  <div id="w-node-_86b2b888-459f-4f21-5ac9-eca9b3b3f8c8-53d8c7b1" class="form-line fecha-final-ai line-toma"><label for="name-5" class="field-label" v-cloak>{{Listaidiomas.FechaFinal}}</label> 
                    <div class="div-fecha"><input type="date" class="text-field w-input" maxlength="80" name="FECHA-3" data-name="FECHA 3" placeholder="DD / MM / AAAA"  id="fechaHasta" v-model="fechaFinal">
                      <a href="#" class="contenedor-icono w-inline-block"><img v-on:click="AbrirDatePicker('fechaHasta')" src="../images/calendar.svg" loading="lazy" alt=""></a>
                    </div>
                  </div>
                  <div id="w-node-d648a741-eb22-8676-6b39-5000b52a8178-53d8c7b1" class="form-line form-add-toma line-toma"><label for="name-5" class="field-label" v-cloak>{{Listaidiomas.Nombre}}</label> 
                  <input type="text" class="text-field txt-name-toma w-input" maxlength="80" name="name-4" data-name="Name 4" placeholder="" id="name-4"  v-model="nombre"></div>
                  <div id="w-node-d648a741-eb22-8676-6b39-5000b52a8197-53d8c7b1" class="form-line line-toma textbox-toma"><label for="name-5" class="field-label" v-cloak>{{Listaidiomas.Descripcion}}</label>
                    <textarea :placeholder="Listaidiomas.PlhDesc" maxlength="200" id="field-3" name="field-3" data-name="field" class="textarea w-input" v-model="descripcion" style="resize: none !important"></textarea></div>
                        <div id="w-node-c95da2a8-3cdc-044d-03b6-57f5054191ec-53d8c7b1" class="form-line line-toma">
                      <label for="name-5" class="field-label" v-cloak>{{Listaidiomas.Categoria}}</label> 
                    <select v-cloak id="field-5" name="field-5" data-name="field" class="select-field w-select" v-model="select_Categorias">
                        <option :value="-1">{{Listaidiomas.SelCat}}</option>
                        <option :value="0">{{Listaidiomas.Todos}}</option>
                        <option v-for="categoria in Categorias" :key="categoria.IdCategoriaActivo" :value="categoria.IdCategoriaActivo">{{categoria.NombreCategoria}}</option > 
                    
                    </select></div>
                  <div id="w-node-_1a548786-188c-b46d-5f92-ee113d88447d-53d8c7b1" class="form-line line-toma"><label for="name-5" class="field-label" v-cloak>{{Listaidiomas.UsuAsig}}</label> 
                    <select v-cloak id="field-5" name="field-5" data-name="field" class="select-field w-select" v-model="select_Usuarios">
                        <option :value="-1">{{Listaidiomas.SelUsu}}</option>
                    <option v-for="usuarios in ListaUsuarios" :key="usuarios.IdPerfilUsuario" :value="usuarios.IdPerfilUsuario" >{{usuarios.Nombre + ' ' + usuarios.Apellildo}}</option> 
                    </select></div>
                  <div id="w-node-_4001b60c-7c14-8e0e-6918-e1a6d6cf6c6f-53d8c7b1" class="form-line linetoma">
                      <label for="field-5" class="field-label" v-cloak>{{Listaidiomas.Ubicaciones}}</label> 
                    <select v-cloak id="field-5" name="field-5" data-name="field" required="" class="select-field w-select" v-model="select_UbicacionA">
                        <option :value="-1">Seleccione una Ubicación</option>
                        <option :value="0">{{Listaidiomas.Todos}}</option>
                        <option v-for="ubicaciones in ListaUbicaciones" :key="ubicaciones.IdUbicacionA" :value="ubicaciones.IdUbicacionA" >{{ubicaciones.Nombre}}</option > 
                    </select>

                  </div>
                  <div id="w-node-d648a741-eb22-8676-6b39-5000b52a8180-53d8c7b1" class="contenedor-botones btn-save-info">
                    <a href="#" class="link-block-boton dere w-inline-block"  v-on:click="GuardarTomaFisica()" ><img src="../images/save_blanco.svg" loading="lazy" alt=""></a>
                  </div>
                </div>
             
            </div>
          </div>
          <div id="w-node-d648a741-eb22-8676-6b39-5000b52a81a1-53d8c7b1" class="div-tarjeta cinta-tienda-ai">
            <div class="div-block-170">
              <div class="text-block-17" v-cloak>{{Listaidiomas.Anuncio}}</div> 
              <a href="../Tienda/Tienda.aspx" class="boton call2action w-button" v-cloak>{{Listaidiomas.Tienda}}<strong></strong></a> 
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>

    <style>
        /*ocultar controles de input date*/
        input[type="date"]::-webkit-inner-spin-button,
        ::-webkit-calendar-picker-indicator {
            display: none;
        }
    </style>
    <script src="https://code.jquery.com/jquery-3.6.0.js"></script>
    <script src="Encabezado/js/TomaFisicaEncabezado.js" type="text/javascript"></script>
</asp:Content>
