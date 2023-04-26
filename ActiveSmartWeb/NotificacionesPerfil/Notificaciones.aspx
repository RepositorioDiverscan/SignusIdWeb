<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/Site.Master" AutoEventWireup="true" CodeBehind="Notificaciones.aspx.cs" Inherits="ActiveSmartWeb.NotificacionesPerfil.Notificaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div id="NotificacionesVUE">
      <div class="section wf-section">
        <div class="container-2 w-container">
          <div class="w-layout-grid grid-main grid-notificaciones">
            <div id="w-node-_43a790c2-3cfd-bba0-50df-88d97a83a425-d245ec1a" class="div-banner-extremo"></div>
            <div id="w-node-f957de86-a358-0834-a66a-63835fb180f9-d245ec1a" class="div-title-a">
              <div class="w-layout-grid grid-container-title" style="padding-top:10px; padding-bottom:10px">
                <a href="#" onclick="window.history.back()" class="link-block-back w-inline-block"><img src="../images/Back-arrow.svg" loading="lazy" height="26" width="26" alt="" class="back"></a>
                <h1 id="w-node-_9be28721-5dbb-5f12-6325-d0dcd6cba1e6-ffdc8228" class="titulo-principal" v-cloak>{{listaIdioma.Titulo}}</h1>
                  <div data-hover="false" data-delay="0" id="w-node-_01c345db-44dd-5950-8797-fc0e77f5b71f-731f63ba" class="dropdown-detalles-ai w-dropdown">
                  <div class="toggle-detalles-ai w-dropdown-toggle" style="padding:0px"><img src="../images/info2.svg" loading="lazy" alt="" class="img-detalles-ai"></div>
                  <nav class="detalles-descrp-ai w-dropdown-list">
                    <p class="p-desc-detalles-ai" v-cloak>{{listaIdioma.Msj1}}<strong><br>{{listaIdioma.Msj2}}</strong></p>
                  </nav>
                </div>
              </div>
            </div>
            <div id="w-node-_0cd2ad67-43b3-6f18-b61f-3e639535070d-d245ec1a" class="div-banner-extremo"></div>
            <div id="w-node-_6f8155e3-64f4-5802-b425-a92cbb5d0597-d245ec1a" class="div-notf-container">
              <div class="div-tarjeta tarjeta-responsive tarjeta-notificaciones">
                <div class="contenedor-grid"></div>
                   <table  style="width:100%; overflow:scroll;" >
    <thead >
        <tr class="w-layout-grid grid _4 grid-notificaciones-ai " style="grid-template-rows: 30px;">
            <th class="texto-blanco" v-cloak>{{listaIdioma.CategoriaTabla}}</th>
        
            <th class="texto-blanco" v-cloak>{{listaIdioma.NumActivo}}</th>
        
            <th class="texto-blanco" v-cloak>{{listaIdioma.Mensaje}}</th>
        
            <th class="texto-blanco" v-cloak>{{listaIdioma.Estado}}</th>
            <th class="texto-blanco"></th>
        </tr>
    </thead>

    <tbody  style="display: table; flex-direction: column; width:100%"  class="w-layout-grid grid _4">
        <tr v-for="(ac, index) in datosPaginados" :key="ac.IdActivo" class="w-layout-grid grid _4 grid-notificaciones-ai " style="grid-template-rows: 30px;">
            <td class="celda-notf-ai" v-cloak>
                <div class="parrafo-grid" v-if="ac.Vista==0" style="font-size: 15px;">
                     <strong>{{ac.CategoriaNotificacion}}</strong>
                </div>
                <div class="parrafo-grid" v-else>
                     {{ac.CategoriaNotificacion}}
                </div>
            </td>
        
            <td class="celda-notf-ai" v-cloak>
                <div class="parrafo-grid" v-if="ac.Vista==0" style="font-size: 15px;">
                     <strong>{{ac.Encabezado}}</strong>
                </div>
                <div class="parrafo-grid" v-else>
                     {{ac.Encabezado}}
                </div>
            </td>

           <td class="celda-notf-ai" v-cloak>
              <div class="parrafo-grid" v-if="ac.Vista==0" style="font-size: 15px;">
                   <strong>{{ac.Mensaje}}</strong>
              </div>
               <div class="parrafo-grid" v-else>
                   {{ac.Mensaje}}
              </div>
          </td>
            <td class="celda-notf-ai celda-icon" v-cloak>
                <div class="parrafo-grid link-block-2 amarillo w-inline-block">
                    <a v-if="ac.Estado==1">
                          <img src="../images/check-dark.svg" loading="lazy" width="20" height="20" alt="" class="image-29">
                    </a>
                    <a v-else>
                          <img src="../images/x-dark.svg" loading="lazy" width="20" height="20" alt="" class="image-29">
                    </a>
                </div>
            </td>
          <td  class="celda-notf-ai celda-icon">
            <div class="parrafo-grid link-block-2 amarillo w-inline-block" 
               v-on:click="AbrirPopPup(ac.IdNotificacion, ac.IdTipoIncidente)">
                <a href="#"> <img src="../images/ver.svg" loading="lazy" width="20" height="20" alt="" class="image-29"></a>
                  
            </div>
          </td>
        </tr>
    </tbody>
  <tfoot>
                         <tr>
                             <td>
                                 <div class="pagination-content">
                                     <div class="form-block-19 block-pag w-form">
                                         <div class="form-11">
                                             <img v-on:click="PaginaAnterior()" src="../images/simbolo-de-doble-flecha-izquierda-hacia-atras-rapido.png"
                                                 loading="lazy" width="15" height="15" alt="" class="image-9">
                                             <label for="name-2" class="cant-paginas" v-cloak>{{paginaActual}}</label>
                                             <label for="name-2" class="cant-paginas" v-cloak>de {{paginas}}</label>
                                             <img v-on:click="PaginaSiguiente()" src="../images/angulos-de-flechas-dobles-a-la-derecha.png" loading="lazy" width="15" height="15" alt="" class="image-9">
                                         </div>
                                     </div>
                                 </div>
                             </td>
                         </tr>
                     </tfoot>
    </table>
              </div>
              <div class="div-tarjeta div-cinta">
                <div class="div-block-170">
                  <div class="text-block-17" v-cloak>{{listaIdioma.MsjTienda}}</div>
                  <a href="../Tienda/Tienda.aspx" class="boton call2action w-button" v-cloak><strong>{{listaIdioma.MsjbtnTienda}}</strong></a>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="background-pop-up" id="PopUpGeneral">

        
        <div class="popup-soporte"  id="POPsoporte" style="display:none">
        <div class="header-modal-ai header-notf">
          <h4 class="texto-h-ai soorte-text">Soporte</h4>
          <div class="div-icon-exit-ai">
              <img v-on:click="CerrarPopPup(1)" src="../images/icono_eliminar_acces-o-01.svg" 
                
                  class="img-salir-ai-2"></div>
        </div>
        <div class="ticket-name">
          <h1 class="heading-ticket">Ticket N°: {{NumeroTicket}}</h1>
        </div>

        <div class="w-clearfix" id="SSCCR" >
          
          <div v-for="(mensaje, index) in listaMensajes" :key="mensaje.IdMensaje">
              <div v-if="mensaje.Emisor == 0">
                  <div class="div-destino-line w-clearfix">
                        <div class="profile-soporte">
                            <h1 class="inicial-user">S</h1>
                        </div>
                        <div class="div-destinatario">
                            <div class="text-destino">{{mensaje.Texto}}</div>
                        </div>
                    </div>
              </div>
              <div v-else>
                  <div class="div-remitente-line w-clearfix">
                        <div class="div-remitente">
                            <div class="text-remitente">{{mensaje.Texto}}</div>
                        </div>
                        <div class="profile-user">
                            <h1 class="inicial-user">U</h1>
                        </div>
                   </div>
              </div>
          </div>

          <span v-onload="sinjQuery()"></span>

        </div>


        <div class="div-mensaje-chat">
          <div class="form-block-23 w-form">
            <div  class="w-clearfix">
                <div> <input  v-on:click="EnviarMensaje()" 
                    type="button" value="Enviar"
                    class="btn-enviar-al-chat w-button"/></div>
               

                 <input type="text" v-model="Mensaje" 
                     v-on:keyup="RecargarMensajes()"
                     @keyup.enter="EnviarMensaje()"
                    class="txt-mensaje w-input" maxlength="256" 
                    placeholder="Escriba su respuesta" />
                <!-- Cuidado: No quitar input, no hace nada, pero  si se quita se cae el chat -->
                <input type="text" style="display:none"/>
            </div>
          
                </div>
                 </div>
                  </div>

        <div class="popup-comercial"  id="POPcomercial" style="display:none">
        <div class="header-modal-ai">
          <h4 class="texto-h-ai">¡Mensaje tipo comercial!</h4>
          <div class="div-icon-exit-ai">
              <img v-on:click="CerrarPopPup(2)"src="../images/icono_eliminar_acces-o-01.svg" 
                  loading="lazy" alt="" class="img-salir-ai"></div>
        </div><img src="../images/carroGris.svg" loading="lazy" alt="" 
            class="img-alert">
        <p class="texto-modal-ai">&quot;<strong>Lorem Ipsum</strong> is simply dummy text of the printing and&quot; </p>
        <a href="#" class="btn-cerrar w-button" v-on:click="CerrarPopPup(2)">Cerrar</a>
      </div>
        <div class="popup-administrativo"  id="POPadministrativo" style="display:none">
        <div class="header-modal-ai">
          <h4 class="texto-h-ai">¡Mensaje admnistrativo!</h4>
          <div class="div-icon-exit-ai">
              <img v-on:click="CerrarPopPup(3)" src="../images/icono_eliminar_acces-o-01.svg" 
                  loading="lazy" alt="" class="img-salir-ai"></div>
        </div>
        <p class="texto-modal-ai">&quot;<strong>Lorem Ipsum</strong> is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&#x27;s standard dummy&quot; </p>

            
            <a href="#" class="btn-cerrar w-button" v-on:click="CerrarPopPup(3)">Cerrar</a>
      </div>
     </div>
    </div>

            

    <script src="js/Notificaciones.js?v=1.2.2"></script>
  
    <script src="../Chat/js/scrollChat.js"></script>


</asp:Content>
