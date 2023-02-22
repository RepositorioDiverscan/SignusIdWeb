<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/Site.Master" AutoEventWireup="true" CodeBehind="Ubicacionc.aspx.cs" Inherits="ActiveSmartWeb.UbicacionesC.Ubicacionc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


      <div class="main" id="maincontext">
      <div class="section wf-section">
        <div class="container-2 w-container">
          <div class="w-layout-grid grid-main">
            <div id="w-node-_8b3b4f69-5ece-e697-43ad-712f3d758f79-0774bde5" class="div-banner-extremo"></div>
            <div id="w-node-_8b3b4f69-5ece-e697-43ad-712f3d758f7a-0774bde5" class="div-banner-extremo"></div>
            <div id="w-node-_8b3b4f69-5ece-e697-43ad-712f3d758f7b-0774bde5">
              <div class="w-layout-grid grid-container-title">
                <a href="ubicaciones.html" class="link-block-back w-inline-block"><img src="../../images/Back-arrow.svg" loading="lazy" height="26" width="26" alt="" class="back"></a>
                <h1 class="titulo-principal">{{Listaidiomas.Titulo}}</h1>
              </div>
            </div>
            <div id="w-node-_8b3b4f69-5ece-e697-43ad-712f3d758f81-0774bde5" class="div-tarjeta">
              <div class="form-block w-form">
                <form id="email-form" name="email-form" data-name="Email Form" method="get" class="form">
                  <div class="w-layout-grid grid-form">
                    <div id="w-node-_8b3b4f69-5ece-e697-43ad-712f3d758f85-0774bde5" class="form-line"><label for="name-5" class="field-label">{{Listaidiomas.UbicacionA}}</label>
                        <select id="field-4" name="field-4" data-name="Field 4" class="select-field w-select" v-model="select_UbicacionA" @change ="CargarUbicacionesBLista()">
                        <option selected value="">{{Listaidiomas.SeleccioneA}}</option>
                        <option v-for="ubiA in ListaUbicacionesA" :key="ubiA.IdUbicacionA" :value="ubiA.IdUbicacionA"  >{{ubiA.Nombre}}</option >                                           
                        </select> 
                    </div>
 
                      <div id="w-node-_8b3b4f69-5ece-e697-43ad-712f3d758f89-0774bde5" class="form-line"><label for="name-5" class="field-label">{{Listaidiomas.Nombre}}</label>
                          <input type="text" v-model="Nombre" class="text-field w-input" maxlength="256" name="name-4" data-name="Name 4" placeholder="" id="name-4"></div>
                      <div id="w-node-_4c3b693d-70e4-c097-0d98-59dfc452f75d-0774bde5" class="form-line"><label for="name-5" class="field-label">{{Listaidiomas.UbicacionB}}</label>
                          <select id="field-4" name="field-4" data-name="Field 4" class="select-field w-select"  v-model="select_UbicacionB">
                        <option selected value="">{{Listaidiomas.SeleccioneB}}</option>
                        <option v-for="ubiB in ListaUbicacionesB" :key="ubiB.IdUbicacionB" :value="ubiB.IdUbicacionB">{{ubiB.Nombre}}</option >                                                                  
                      </select></div>
                    <div id="w-node-_8b3b4f69-5ece-e697-43ad-712f3d758f8d-0774bde5" class="form-line"><label for="name-5" class="field-label">{{Listaidiomas.Descripcion}}</label>
                        <textarea name="field-3" v-model="Descripcion" maxlength="5000" id="field-3" data-name="field" placeholder="" class="textarea w-input"></textarea></div>
                    <div id="w-node-_8b3b4f69-5ece-e697-43ad-712f3d758f91-0774bde5" class="contenedor-botones">
                      <a href="#" class="link-block-boton dere w-inline-block" v-on:click="InsertarUbicacionC">
                      <img src="../../images/save_blanco.svg" loading="lazy" alt=""></a>
                      <a href="#" class="link-block-boton w-inline-block" v-on:click="CancelarUbicacionC">
                      <img src="../../images/eraser.svg" loading="lazy" alt=""></a>
                    </div>
                  </div>
                </form>
                <div class="w-form-done">
                  <div>Thank you! Your submission has been received!</div>
                </div>
                <div class="w-form-fail">
                  <div>Oops! Something went wrong while submitting the form.</div>
                </div>
              </div>
            </div>
         <table  id="w-node-_1881bb3d-bb04-a65f-0013-ab2c81d34079-731f63ba" class="div-tarjeta tablagestion">
                       <thead class="w-layout-grid grid-ubicaci-n-a">
                         <tr>
                           <td class="texto-blanco">{{Listaidiomas.NombreTablaNombre}}</td>
                             </tr>
                               <tr>
                                 <td class="texto-blanco">{{Listaidiomas.DescripcionTablaNombre}}</td>
                               </tr>
                               <tr>
                                 <td class="texto-blanco">&nbsp</td>
                               </tr>                                      
                                </thead>
                                <tbody style="display: flex; flex-direction: column" text-align="center">
                                    <tr  class="w-layout-grid grid-tabla-ai  grid-ubicaci-n-a" style="grid-template-rows: 30px;"
                                        v-for="(ubiCC , index) in datosPaginados" :key="ubiCC.IdUbicacionC">
                                      <td class="celda-vacia">
                                          <div class="parrafo-grid">
                                            {{ubiCC.Nombre}}
                                          </div>
                                      </td>
                                      <td class="celda-vacia">
                                         <div class="parrafo-grid">
                                             {{ubiCC.Descripcion}}
                                         </div>
                                      </td>
                                      <td class="celda-vacia link-block-2 amarillo w-inline-block"> 
                                         <div class="parrafo-grid">
                                           <a :id="ubiCC.IdUbicacionC" 
                                            :name="ubiCC.Nombre":value="ubiCC.IdUbicacionC"
                                            @click="CargarFilaC(ubiCC.Nombre,ubiCC.Descripcion, ubiCC.IdUbicacionB, ubiCC.IdUbicacionC)" >
                                            <img src="../images/editar.svg" loading="lazy"alt="" class="image-29">    
                                           </a>                            
                                         </div>
                                      </td>
                                    </tr>        
                                </tbody>
                 <tfoot>
                                                <tr>
                                                    <td>
                                                        <div class="pagination-content">
                                                            <div class="form-block-19 block-pag w-form">
                                                                <div id="email-form-3" name="email-form-3" data-name="Email Form 3" method="get" class="form-11">
                                                                    <img v-on:click="getPreviousPage()" src="../images/simbolo-de-doble-flecha-izquierda-hacia-atras-rapido.png"
                                                                        loading="lazy" width="15" height="15" alt="" class="image-9">
                                                                    <label for="name-2" class="cant-paginas">{{paginaActual}}</label>
                                                                    <label for="name-2" class="cant-paginas">de {{paginas}}</label>
                                                                    <img  v-on:click="getNextPage()" src="../images/angulos-de-flechas-dobles-a-la-derecha.png" loading="lazy" width="15" height="15" alt="" class="image-9">
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </td>
                                                </tr>
                                        </tfoot>

                            </table>
                           </div>
                         </div>
                      </div>
                    
   
  <script src="js/webflow.js"></script>
  <script src="https://d3e54v103j8qbb.cloudfront.net/js/jquery-3.5.1.min.dc5e7f18c8.js?site=606dfb37871f33efa37244d4" type="text/javascript" integrity="sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0=" crossorigin="anonymous"></script>
  <script src="../VisorActivos/Vue/vue.min.js"></script>
    <script src="js/UbicacionC.js"></script>
     <script src="js/UbicacionB.js"></script>

</asp:Content>
