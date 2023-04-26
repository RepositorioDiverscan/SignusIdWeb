<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/Site.Master" AutoEventWireup="true" CodeBehind="UbicacionA.aspx.cs" Inherits="ActiveSmartWeb.Ubicaciones.Ubicaciona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div id="UbicacionAVUE" class="main">
      <div class="section wf-section" id="alertas">
        <div class="container-2 w-container">
          <div class="w-layout-grid grid-main">
            <div id="w-node-_99e74211-4a22-c27b-c950-d59b6c2656bd-4390f686" class="div-banner-extremo">
            </div>
            <div id="w-node-e789812d-661d-4ea1-b313-7168a149b982-4390f686" class="div-banner-extremo">
            </div>

              <div id="w-node-dc51fb7a-3c3a-ef2c-a975-38bc30be6df8-4390f686">

                  <div class="w-layout-grid grid-container-title" style="padding-top:7px; padding-bottom:6px">
                  <a href="#" onclick="window.history.back()" class="link-block-back w-inline-block">
                      <img src="../images/Back-arrow.svg" loading="lazy" height="26" width="26" alt="" class="  ">
                  </a>
                  <h1 id="w-node-_9be28721-5dbb-5f12-6325-d0dcd6cba1e6-ffdc8228" class="titulo-principal" v-cloak>{{listaidiomalubicacion.Titulo}}</h1>
                  <div data-hover="false" data-delay="0" id="w-node-_01c345db-44dd-5950-8797-fc0e77f5b71f-731f63ba" class="dropdown-detalles-ai w-dropdown">
                      <div class="toggle-detalles-ai w-dropdown-toggle" style="padding:0px">
                          <img src="../images/info2.svg" loading="lazy" alt="" class="img-detalles-ai">
                      </div>
                      <nav class="detalles-descrp-ai w-dropdown-list">
                          <p class="p-desc-detalles-ai" v-cloak>{{listaidiomalubicacion.Msj1}}<strong><br>{{listaidiomalubicacion.Msj2}}</strong></p> 
                      </nav>
                  </div>
              </div>
            </div>

            <div id="w-node-_7645695c-a7b6-7ca7-fb54-56023d3cf8ce-4390f686" class="div-tarjeta">
              <div class="form-block w-form">
                <div id="email-form" name="email-form" data-name="Email Form" method="get" class="form">
                  <div class="w-layout-grid grid-form">
                    <div id="w-node-_73e39b70-5f2f-d37a-7927-af786541e888-4390f686" class="form-line"><label for="name-5" class="field-label" v-cloak>{{listaidiomalubicacion.Nombre}}</label> 
                        <input type="text" class="text-field w-input" maxlength="80" name="name-4" data-name="Name 4" placeholder="" v-model="nombre" id="name-4">
                    </div>
                    <div id="w-node-_3d51aca7-09c2-8c86-b1d3-4faada7c9ac6-4390f686" class="form-line"><label for="name-5" class="field-label" v-cloak>{{listaidiomalubicacion.Descripcion}}</label> 
                        <textarea name="field-3" maxlength="200" id="field-3" data-name="field" placeholder="" v-model="descripcion" class="textarea w-input" style="resize: none !important"></textarea>
                    </div>
                    <div id="w-node-_720f0417-bbba-240a-9e24-15dfdeec01cd-4390f686" class="contenedor-botones">
                      <a href="#" class="link-block-boton dere w-inline-block" v-on:click="GuardarUbicacion"><img src="../images/save_blanco.svg" loading="lazy" alt=""></a>
                      <a href="#" class="link-block-boton w-inline-block" v-on:click="LimpiarUbicacion"><img src="../images/eraser.svg" loading="lazy" alt=""></a>
                    </div>
                   </div>
                  </div>
              </div>
            </div>
            <div id="w-node-_62f3f67f-6fd3-0fe1-0968-1efdd5f37669-4390f686" class="div-tarjeta">
              <div class="contenedor-grid">
                  <table class=""style="width:100%">
                      <thead>
                          <tr v-cloak class="w-layout-grid grid-ubicaci-n-a"style="grid-template-rows: 30px; grid-template-columns: 45% 49% 5%;">
                            <td class="texto-blanco" >{{listaidiomalubicacion.NombreTablaNombre}}</td>
                            <td class="texto-blanco">{{listaidiomalubicacion.DescripcionTablaNombre}}</td>
                            <td class="texto-blanco"></td>
                          </tr>   
                      </thead>
                      <tbody style="display: flex; flex-direction: column">
                          <tr v-for="(ubicacion, index) in datosPaginados" :key="ubicacion.IdUbicacionA"
                            class="w-layout-grid grid _4 grid-tabla-ai grid-empleados" style="grid-template-rows: 30px; grid-template-columns: 45% 49% 5%;"> 
                            <td id="w-node-_15005c8e-5141-aa28-c762-dc7b437ea3d1-ee1567c5"  class="celda-vacia">
                              <div class="parrafo-grid">
                                {{ubicacion.Nombre}}
                              </div>
                            </td>
                            <td id="w-node-_15005c8e-5141-aa28-c762-dc7b437ea3d1-ee1567c5"  class="celda-vacia">
                              <div class="parrafo-grid">
                               {{ubicacion.Descripcion}}
                             </div>
                            </td>
                            
                             <td id="w-node-_15005c8e-5141-aa28-c762-dc7b437ea3d1-ee1567c5"  class="celda-vacia link-block-2 amarillo w-inline-block">
                               <div >
                                  <a :id="ubicacion.IdUbicacionA" 
                                       @click="Editar(ubicacion.IdUbicacionA,ubicacion.Nombre,ubicacion.Descripcion)"
                                  :name="ubicacion.Nombre":value="(ubicacion.IdUbicacionA)">
                                  <img src="../images/editar.svg"  loading="lazy" width="20" height="20" alt="" class="image-29">    
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
                                                                    <img v-on:click="PaginaAnterior()" src="../images/simbolo-de-doble-flecha-izquierda-hacia-atras-rapido.png"
                                                                        loading="lazy" width="15" height="15" alt="" class="image-9">
                                                                    <label for="name-2" class="cant-paginas" v-cloak>{{paginaActual}}</label>
                                                                    <label for="name-2" class="cant-paginas" v-cloak>de {{paginas}}</label>
                                                                    <img  v-on:click="PaginaSiguiente()" src="../images/angulos-de-flechas-dobles-a-la-derecha.png" loading="lazy" width="15" height="15" alt="" class="image-9">
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </td>
                                                </tr>
                                            </tfoot>
                  </table>
              </div>
            </div>
              <div id="w-node-c8689383-f869-af00-8fed-b75b3bbc331a-731f63ba" class="div-tarjeta div-cinta" style="margin-top: -110px;">
              <div class="div-block-170">
                <div class="text-block-17" v-cloak>{{listaidiomalubicacion.MsjTienda}}</div>
                <a href="../Tienda/Tienda.aspx" class="boton call2action w-button" v-cloak><strong>{{listaidiomalubicacion.MsjbtnTienda}}</strong></a>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div id="w-node-_55273ac8-0182-8fff-edf9-b3093925a5e2-4390f686" class="div-block-206 popup">
        <div class="div-block-207">
          <div class="div-block-208"><img src="../images/icono_mas_acces-o_Mesa-de-trabajo-1.svg" loading="lazy" width="20" height="20" alt=""></div>
        </div>
      </div>
    </div>

    <script src="../Recursos/JQuery/jquery-3.5.1.min.dc5e7f18c8.js"></script>
    <script src="../js/webflow.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.0.js" ></script>
    <script src="js/UbicacionA.js"></script>
</asp:Content>
