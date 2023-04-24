

<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/Site.Master" AutoEventWireup="true" CodeBehind="GestionServicio.aspx.cs" Inherits="ActiveSmartWeb.GestionServicio.GestionServicio" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="main" id="maincontext">
      <div class="section wf-section" id="alertas">
        <div class="container-2 w-container">
          <div class="w-layout-grid grid-main grid-main-gestion">
            <div id="w-node-_1cc4a79b-17e9-a7a4-e9e4-57f9db523060-f37b4657" class="div-banner-extremo"></div>
            <div id="w-node-_1cc4a79b-17e9-a7a4-e9e4-57f9db523061-f37b4657" class="div-banner-extremo"></div>
            <div id="w-node-_1cc4a79b-17e9-a7a4-e9e4-57f9db523062-f37b4657" class="titulo-pagina">
              <div class="w-layout-grid grid-container-title" style="padding-top:10px; padding-bottom:10px">
                <a href="#" onclick="window.history.back()" class="link-block-back w-inline-block" >
                  <img src="../images/Back-arrow.svg" loading="lazy" height="26" width="26" alt="" class="back"></a>
                <h1 id="w-node-_1cc4a79b-17e9-a7a4-e9e4-57f9db523066-f37b4657" class="titulo-principal" v-cloak> {{listaIdiomas.Titulo}} </h1> 
                  <div data-hover="false" data-delay="0" id="w-node-_01c345db-44dd-5950-8797-fc0e77f5b71f-731f63ba" class="dropdown-detalles-ai w-dropdown">
                  <div class="toggle-detalles-ai w-dropdown-toggle" style="padding:0px"><img src="../images/info2.svg" loading="lazy" alt="" class="img-detalles-ai"></div>
                  <nav class="detalles-descrp-ai w-dropdown-list">
                    <p class="p-desc-detalles-ai" v-cloak>{{listaIdiomas.Msj1}}<strong><br>{{listaIdiomas.Msj2}}</strong></p> 
                  </nav>
                </div>
              </div>
            </div>
            <div id="w-node-_1cc4a79b-17e9-a7a4-e9e4-57f9db523111-f37b4657" class="div-tarjeta tarjeta-gestion tarjeta-responsive">
              <div class="form-block w-form">

                <div id="email-form" name="email-form" data-name="Email Form" method="get" class="form">

                  <div class="w-layout-grid grid-form gestion">
                    <div id="w-node-aa9e63be-8ed2-bf88-7fd8-e457b91fd2bc-f37b4657" class="form-line form-line-ai">
                      
                      <label for="field-4" class="field-label" v-cloak>{{listaIdiomas.Solicitante}}*</label> 
                      
                      <select v-cloak id="field-4" name="field-4" data-name="Field 4" class="select-field w-select" v-model="select_Solicitante">
                        <option selected value="">{{listaIdiomas.PlhSeleccionarSol}}</option> 

                        <option v-for="userS in listaUsuarios" :key="userS.IdPerfilUsuario" 
                            :value="userS.IdPerfilUsuario">
                            {{userS.Nombre + ' '+ userS.Apellildo}}
                        </option>
                      </select></div>





                    <div id="w-node-_7bbc17d0-5cc7-a840-d197-1a9d13dc1394-f37b4657" class="form-line form-line-ai">
                      <label v-cloak for="field-4" class="field-label">{{listaIdiomas.Activo}}*</label> 
                      <div class="w-layout-grid grid-busqueda">
                        
                        <select v-cloak id="field-4" name="field-4" data-name="Field 4" class="select-field search-select w-node-_849f5bf1-cf9d-af70-be62-1d9c6c9cafcb-f37b4657 w-select"
                        v-model="tipoBusAct"
                        >
                          <option value="0">{{listaIdiomas.PlhTipoBusqueda}}</option> 
                          <option value=1>{{listaIdiomas.TipBusPlaca}}</option> 
                          <option value=2>{{listaIdiomas.TipBusActivo}}</option> 

                        </select>




                        <div id="w-node-_849f5bf1-cf9d-af70-be62-1d9c6c9cafc7-f37b4657" class="contenedor-buscar search">
                          <input v-on:keyup.enter="ObtenerActivo()" type="text" class="text-field w-input" maxlength="80" name="name-4" data-name="Name 4" placeholder="" id="name-4"
                          v-model="critBusqueda"
                          >
                          <a href="#"  v-on:click="ObtenerActivo()" class="contenedor-icono w-inline-block">
                            <img src="../images/icono_buscar_acces-o-01.svg" loading="lazy" alt=""></a>
                        </div>
                        <div id="w-node-_3dc0bca6-6ba2-b828-6fd1-f6f2d5df88f0-f37b4657" class="div-block-209">
                          <div v-cloak class="parrafo-grid">{{descActivo}}</div>
                        </div>
                      </div>
                    </div>

                    <div id="w-node-aa9e63be-8ed2-bf88-7fd8-e457b91fd2c7-f37b4657" class="form-line form-line-ai">
                      <label v-cloak for="field-4" class="field-label">{{listaIdiomas.RazonServicio}}*</label> 
                      
                      <select v-cloak id="field-4" name="field-4" data-name="Field 4" class="select-field w-select"   v-model="tipoRequerimiento"> 
                        <option value="0">{{listaIdiomas.PlhSeleccionarRazon}}</option> 
                        <option value="Matenimiento Prenventivo">Matenimiento Prenventivo</option>
                        <option value="Daño Leve">Daño Leve</option>
                        <option value="Daño Grave">Daño Grave</option>
                        <option value="Diagnóstico / Revisión">Diagnóstico / Revisión</option>
                        <option value="No Enciende">No Enciende</option>
                        <option value="Instalación/Actualización de Software">Instalación/Actualización de Software</option>
                        <option value="Solicitud de Mejora">Solicitud de Mejora</option>
                        <option value="Falla de Componente/Accesorio">Falla de Componente/Accesorio</option>
                        <option value="Cambio de Placa">Cambio de Placa</option>
                      </select>
                    
                    </div>


                    <div id="w-node-aa9e63be-8ed2-bf88-7fd8-e457b91fd2cb-f37b4657" class="form-line form-line-ai">
                      
                      <label v-cloak for="field-4" class="field-label">{{listaIdiomas.TipRazon}}*</label> 
                      
                      <select v-cloak id="field-4" v-model="estado" name="field-4" data-name="Field 4" class="select-field w-select">
                        <option value="0">{{listaIdiomas.PlhSeleccionartipR}}</option>
                        <option value="Nuevo">Nuevo</option>
                        <option value="En Proceso">En Proceso</option>
                        <option value="Resuelto">Resuelto</option>
                        <option value="Cerrado">Cerrado</option>
                      </select></div>

                    <div id="w-node-a4f4f3a7-2354-2082-8289-5e7ce9355305-f37b4657" class="form-line form-line-ai">
                      <label v-cloak for="field-4" class="field-label">{{listaIdiomas.Asignar}}</label> 
                      <select v-cloak id="field-4" name="field-4"  v-model="select_Asignado" data-name="Field 4" 
                      class="select-field w-select">
                      <option selected value="">{{listaIdiomas.PlhSeleccionarColab}}</option> 

                      <option v-for="userS in listaUsuarios" :key="userS.IdPerfilUsuario" 
                          :value="userS.IdPerfilUsuario">
                          {{userS.Nombre + ' '+ userS.Apellildo}}
                      </option>

                      </select></div>
                    <div id="w-node-aa9e63be-8ed2-bf88-7fd8-e457b91fd2cf-f37b4657" class="form-line form-line-ai">
                      <label for="name-4" class="field-label" v-cloak>{{listaIdiomas.DescReq}}*</label> 
                      <input  v-model="descReq" type="text" class="text-field requerimiento-txt w-input" 
                      maxlength="200" name="name-4" data-name="Name 4" placeholder="" id="name-4"></div>
                    <div id="w-node-_875e4da8-4a0d-9455-7352-a587ea834849-f37b4657" class="contenedor-botones btns-line">

                      <a href="#" class="link-block-boton gestion w-inline-block" v-on:click="InsertarGestionServicio()">
                        <img src="../images/save_blanco.svg" loading="lazy" alt=""></a>
                    </div>
                  </div>
                </div>
              
              </div>
            </div>
             <div id="w-node-_1881bb3d-bb04-a65f-0013-ab2c81d34079-731f63ba" class="div-tarjeta tablagestion tarjeta-gestion tarjeta-responsive">
                  <div class="contenedor-grid visor">
                <table style="width:100%">
                    <thead >
                        <tr class="w-layout-grid grid _3 visor gestion" style="grid-template-rows: auto;grid-template-columns: 20% 20% 20% 20% 20%;">
                        
                          <th class="texto-blanco">Activo</th>
                          <th class="texto-blanco">Requerimiento</th>
                          <th class="texto-blanco">Fecha</th>
                          <th class="texto-blanco">N° Ticket</th>
                          <th id="w-node-cdefa685-77b8-75ae-3c93-e62703cf344c-f37b4657" class="texto-blanco">Estado</th>

                        </tr>
                    </thead>
                    <tbody  style="display: flex; flex-direction: column" >

                        <tr v-for="(gesT, index) in datosPaginados" :key="gesT.IdGestionServicio" 
                            class="w-layout-grid grid _3 visor gestion" style="grid-template-rows: 30px;grid-template-columns: 20% 20% 20% 20% 20%;">

                            <th class="celda-vacia">
                                <div v-cloak class="parrafo-grid">{{gesT.IdActivo}}</div>
                              </th>
                              <th class="celda-vacia">
                                <div v-cloak class="parrafo-grid">{{gesT.Descripcion}}</div>
                              </th>
                              <th class="celda-vacia descrip">
                                <div v-cloak class="parrafo-grid">{{FormatearFecha(gesT.Fecha)}}</div>
                              </th>
                              <th v-cloak class="celda-vacia">
                                <div class="parrafo-grid">{{gesT.NumeroTicket}}</div>
                              </th>
                                <th v-cloak id="email-form-2" name="email-form-2" data-name="Email Form 2" method="get" class="form-7">
                                    <select v-cloak v-model="gesT.Estado" class="select-field-2 w-select" 
                                          :id="gesT.IdGestionServicio" :name="gesT.IdActivo" :value="gesT.IdGestionServicio"
                                           @change="ActualizarEstado(gesT.IdGestionServicio, gesT.Estado)" >
                                          <option value="Nuevo">Nuevo</option>
                                          <option value="En Proceso">En Proceso</option>
                                          <option value="Resuelto">Resuelto</option>
                                          <option value="Cerrado">Cerrado</option>
                                    </select>
                                </th>

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
                                            <label v-cloak for="name-2" class="cant-paginas">{{paginaActual}}</label>
                                            <label v-cloak for="name-2" class="cant-paginas">de {{paginas}}</label>
                                            <img v-on:click="PaginaSiguiente()" src="../images/angulos-de-flechas-dobles-a-la-derecha.png" loading="lazy" width="15" height="15" alt="" class="image-9">
                                        </div>
                                    </div>
                                </div>
                            </td>
                        </tr>
                    </tfoot>
                </table>
                  </div>
              </div>


            <div id="w-node-cdefa685-77b8-75ae-3c93-e62703cf3441-f37b4657" class=""> 
                <div id="w-node-c8689383-f869-af00-8fed-b75b3bbc331a-731f63ba" class="div-tarjeta div-cinta">
              <div class="div-block-170">
                <div class="text-block-17" v-cloak>{{listaIdiomas.MsjTienda}}</div> 
                <a href="../Tienda/Tienda.aspx" class="boton call2action w-button" v-cloak>{{listaIdiomas.MsjbtnTienda}}<strong></strong></a> 
              </div>
            </div>
           </div>
              
          </div>
        </div>
      </div>
    </div>


    <script src="../Recursos/JQuery/jquery-3.5.1.min.dc5e7f18c8.js"></script>
    <script src="../Recursos/Vue/vue.js"></script>
    <script src="js/Gestion.js"></script>
</asp:Content>
