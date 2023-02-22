<%@ Page Language="C#" MasterPageFile="~/SiteMaster/SiteMasterInicio.Master" AutoEventWireup="true" CodeBehind="ConfiguracionesPlan.aspx.cs" Inherits="ActiveSmartWeb.ConfiguracionPlanes.ConfiguracionesPlan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
              <div class="w-layout-grid grid-main roa" id="context">
            <div id="w-node-_87695020-6f5c-ec03-bb3a-4174fa111f76-da1b5eb4" class="div-banner-extremo left"></div>
            <div id="w-node-_87695020-6f5c-ec03-bb3a-4174fa111f77-da1b5eb4" class="div-banner-extremo"></div>
            <div id="w-node-_87695020-6f5c-ec03-bb3a-4174fa111f78-da1b5eb4" class="div-block-198">
              <div class="w-layout-grid grid-container-title">
                <a href="menu.html" class="link-block-back w-inline-block"><img src="../images/Back-arrow.svg" loading="lazy" height="26" width="26" alt="" class="back"></a>
                <h1 class="titulo-principal">{{listaIdiomas.Titulo}}</h1>
              </div>
            </div>
            <div id="w-node-_87695020-6f5c-ec03-bb3a-4174fa111f7e-da1b5eb4" class="div-tarjeta res-roa">
              <div class="form-block w-form">
                <div id="email-form" name="email-form" data-name="Email Form" method="get" class="form">
                  <div class="w-layout-grid grid-form">
                    <div id="w-node-c9a4d20a-fe8d-a437-9ed9-31a992874599-da1b5eb4" class="form-line"><label for="name-5" class="field-label">{{listaIdiomas.TituloPlanDisponible}}</label>
                        <select id="fplanes" name="field-4" data-name="Field 4" class="select-field w-select" @change="CargarConfiguracionesPorPlan($event)"  vmodel="idtipocontrato">
                        <option value="0">{{listaIdiomas.CampoSelect}}</option>
                        <option value="1">FREE</option>
                        <option value="2">BASIC</option>
                        <option value="3">PRO</option>
                      </select>

                    </div>
                   
                    
                  </div>

                        <div class="div-tarjeta">
                            <table id="w-node-_1881bb3d-bb04-a65f-0013-ab2c81d34079-731f63ba" class="contenedor-grid">
                                <thead class="w-layout-grid grid-tablas">
                                    <tr>
                                        <td class="texto-blanco">{{listaIdiomas.TablaCampo1}}</td>
                                    </tr>
                                    <tr>
                                        <td class="texto-blanco">{{listaIdiomas.TablaCampo2}}</td>
                                    </tr>
                                    <tr>
                                        <td class="texto-blanco">{{listaIdiomas.TablaCampo3}}</td>
                                    </tr> 
                                    <tr>
                                        <td class="texto-blanco">{{listaIdiomas.TablaCampo4}}</td>
                                    </tr>
                                    <tr>
                                        <td class="texto-blanco"></td>
                                    </tr>  
                                </thead>
                                <tbody v-for="(configuracion,index) in configuraciones" :key="index" class="w-layout-grid grid-tablas">
                                    
                                    <tr class="celda-vacia">
                                      <td>{{configuracion.Nombre}}</td>
                                    </tr>  
                                    <tr class="celda-vacia">
                                      <td>{{configuracion.Tipo}}</td>
                                    </tr>    
                                    <tr class="celda-vacia">
                                        <td>{{configuracion.FechaRegistro}}</td>
                                    </tr>   
                                    <tr class="celda-vacia">
                                        <td>{{configuracion.Estado}}</td>
                                    </tr>
                                    <tr class="celda-vacia">
                                        <td><input type="checkbox" :id="configuracion.IdConfiguracion"  @change="ActualizarInsertarConfiguracion(configuracion)" disabled/></td>
                                    </tr>
                                                            
                                </tbody>

                            </table>
                       </div>
                </div>
                <div class="w-form-done">
                  <div>Thank you! Your submission has been received!</div>
                </div>
                <div class="w-form-fail">
                  <div>Oops! Something went wrong while submitting the form.</div>
                </div>
              </div>
            </div>
            <div id="w-node-_3f31075b-ed94-ac1e-d4fb-094ba346af89-da1b5eb4" class="div-tarjeta">
              <div class="div-block-170">
                <div class="text-block-17">{{listaIdiomas.TextoLeyenda}}</div>
                <a href="../Menu/MenuPrincipal.aspx" class="boton call2action w-button">{{listaIdiomas.BotonIrTienda}}<strong></strong></a>
              </div>
            </div>
          </div>


  <script src="https://d3e54v103j8qbb.cloudfront.net/js/jquery-3.5.1.min.dc5e7f18c8.js?site=606dfb37871f33efa37244d4" type="text/javascript" integrity="sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0=" crossorigin="anonymous"></script>
  <script src="../js/webflow.js" type="text/javascript"></script>
  <!-- [if lte IE 9]><script src="https://cdnjs.cloudflare.com/ajax/libs/placeholders/3.0.2/placeholders.min.js"></script><![endif] -->
    <script src="../Recursos/JQuery/jquery-3.5.1.min.dc5e7f18c8.js"></script>
    <script src="../VisorActivos/Vue/vue.min.js"></script>
    <script src="js/Configuraciones.js?v=1.2.4"></script>
</asp:Content>
