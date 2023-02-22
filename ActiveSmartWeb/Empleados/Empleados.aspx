<%@ page title="" language="C#" masterpagefile="~/SiteMaster/Site.Master" autoeventwireup="true" codebehind="Empleados.aspx.cs" inherits="ActiveSmartWeb.Empleados.Empleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="main" id="EmpleadosVUE">
        <div class="wf-section" id="alertas">
            <div class="container-2 w-container">
                <div class="w-layout-grid grid-main">
                    <div id="w-node-_9cf1d33f-1f83-9189-54c6-06f92eacb0e1-ee1567c5" class="div-banner-extremo"></div>
                    <div id="w-node-_9cf1d33f-1f83-9189-54c6-06f92eacb0e2-ee1567c5" class="div-title-a">
                        <div>
                            <div class="w-layout-grid grid-container-title">
                                <a href="#" onclick="window.history.back()" class="link-block-back w-inline-block"><img src="../images/Back-arrow.svg" loading="lazy" height="26" width="26" alt="" class="back"></a>
                  <h1 id="w-node-_042796da-094d-1fbc-7383-a94233637c85-ee1567c5" class="titulo-principal" v-cloak>{{listaIdiomas.Titulo}}</h1>
                  <div data-hover="false" data-delay="0" id="w-node-_8c5e42f9-fffb-ad33-84ed-0fbd39ceec51-ee1567c5" class="dropdown-detalles-ai w-dropdown">
                    <div class="toggle-detalles-ai w-dropdown-toggle" style="padding:0px"><img src="/images/info2.svg" loading="lazy" alt="" class="img-detalles-ai"></div>
                    <nav class="detalles-descrp-ai w-dropdown-list">
                      <p class="p-desc-detalles-ai" v-cloak>{{listaIdiomas.Msj1}} <strong><br>{{listaIdiomas.Msj2}}</strong></p>
                    </nav>
                  </div>
                </div>
                        </div>
                    </div>
                    <div id="w-node-_9cf1d33f-1f83-9189-54c6-06f92eacb0e7-ee1567c5" class="div-banner-extremo"></div>
                    <div id="w-node-_9cf1d33f-1f83-9189-54c6-06f92eacb0e8-ee1567c5" class="div-users-container-ai empleados-content-ai">

                        <div class="div-tarjeta">
                            <div class="block-form-aid w-form">
                                <div id="email-form" name="email-form" data-name="Email Form" method="get">
                                    <div class="w-layout-grid grid-form">
                                        <label for="email" id="w-node-_35e72e90-026b-9e5d-9026-0dd1a2c36b9d-ee1567c5" class="field-label" v-cloak>{{listaIdiomas.Tituloagregar}}</label>
                                        <div id="w-node-_35e72e90-026b-9e5d-9026-0dd1a2c36b9f-ee1567c5" class="form-line">
                                            <label for="name-5" class="field-label" v-cloak>{{listaIdiomas.Nombre}}</label>
                                            <input type="text" class="text-field w-input" maxlength="80" name="name-4" data-name="Name 4" placeholder="" id="NombreTxt" v-model="nombre">
                                        </div>
                                        <div id="w-node-_35e72e90-026b-9e5d-9026-0dd1a2c36ba3-ee1567c5" class="form-line">
                                            <label for="name-5" class="field-label" v-cloak>{{listaIdiomas.Apellidos}}</label>
                                            <input type="text" class="text-field w-input" maxlength="80" name="name-4" data-name="Name 4" placeholder="" id="ApellidosTxt" v-model="apellidos">
                                        </div>
                                        <div id="w-node-_35e72e90-026b-9e5d-9026-0dd1a2c36ba7-ee1567c5" class="form-line">
                                            <label for="name-4" class="field-label" v-cloak>{{listaIdiomas.Identificacion}}</label>
                                            <input type="text" class="text-field w-input" maxlength="80" name="name-4" data-name="Name 4" placeholder="" id="idEmpleadoTxt" v-model="identificacion">
                                        </div>
                                        <div id="w-node-_35e72e90-026b-9e5d-9026-0dd1a2c36bab-ee1567c5" class="form-line">
                                            <label for="name-4" class="field-label" v-cloak>{{listaIdiomas.Correo}}</label>
                                            <input type="email" class="text-field w-input" maxlength="80" name="name-4" data-name="Name 4" placeholder="" id="CorreotTxt" v-model="correo">
                                        </div>
                                        <div id="w-node-_35e72e90-026b-9e5d-9026-0dd1a2c36baf-ee1567c5" class="form-line">
                                            <label for="name-5" class="field-label" v-cloak>{{listaIdiomas.Puesto}}</label>
                                            <input type="text" class="text-field w-input" maxlength="80" name="name-4" data-name="Name 4" placeholder="" id="PuestoTxt" v-model="puesto">
                                        </div>
                                        <div id="w-node-_35e72e90-026b-9e5d-9026-0dd1a2c36bb3-ee1567c5" class="form-line">
                                            <label for="name-4" class="field-label" v-cloak>{{listaIdiomas.Telefono}}</label>
                                            <input type="tel" class="text-field w-input" maxlength="80" name="telNational" data-name="Name 4" id="telNational" v-on:keypress="ValidarSoloNumeros()"/>
                                        </div>
                                        <div id="w-node-_35e72e90-026b-9e5d-9026-0dd1a2c36bb7-ee1567c5" class="contenedor-botones">
                                            <a href="#" class="link-block-boton dere w-inline-block" v-on:click="InsertarEmpleado">
                                                <img src="../images/save_blanco.svg" loading="lazy" alt=""></a>
                                            <a href="#" class="link-block-boton dere w-inline-block" v-on:click="LimpiarCampos">
                                                <img src="../../images/eraser.svg" loading="lazy" alt=""></a>

                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>
                        
                        <%-- Tarjeta de Tabla de Empleados --%>
                        <div class="div-tarjeta div-usuarios-ai tarjeta-responsive">
                            <div class="form-block-usuarios w-form">
                                <div id="email-form-4" name="email-form-4" data-name="Email Form 4" method="get" class="form-rol-usuarios-ai">
                                   
                                    <%-- Contendor de la tarjeta --%>
                                    <div class="contenedor-grid tabla-usuarios-ai w-clearfix" style="overflow: hidden;">
                                      
                                        <%-- Campo de Seleccion de Filtro --%>
                                        <select v-cloak id="field-4" v-model="filtroTabla" v-on:change="CargarEmpleadosEstado"  name="field-4" data-name="Field 4" class="select-field select-type filtro-ai w-select">
                                            <option value="" selected>{{listaIdiomas.FiltraT}}</option>
                                            <option value="true">{{listaIdiomas.FiltraA}}</option>
                                            <option value="false">{{listaIdiomas.FiltraI}}</option>
                                        </select>

                                        <%-- Campo de busqueda --%>
                                        <div class="contenedor-buscar buscador-usuarios-ai">
                                            <input v-model="buscador" @keyup="FiltrarDatos()" type="text" class="text-field txt-buscador w-input" maxlength="80" name="name-4" data-name="Name 4" placeholder="">
                                     
                                            <a href="#" class="contenedor-icono div-icon w-inline-block">
                                                <img src="/images/icono_buscar_acces-o-01.svg" loading="lazy" alt="">
                                            </a>
                                        </div>
                                        <%-- Fin campo busqueda --%>

                                        <%-- Tabla de Empleados --%>
                                        <div style="float:left; width:100%">
                                             <table style="margin-top: 15px; width: 100%;">
                                                <thead>
                                                    <tr v-cloak>
                                                        <th class="encabezado-tabla-empleados" style="width: 115px;"> {{listaIdiomas.NombreTabla}} </th>
                                                        <th class="encabezado-tabla-empleados" style="width: 115px;"> {{listaIdiomas.ApellidoTabla}} </th>
                                                        <th class="encabezado-tabla-empleados"> {{listaIdiomas.CorreoTabla}} </th>
                                                        <th class="encabezado-tabla-empleados"> {{listaIdiomas.TelefonoTabla}} </th>
                                                        <th class="encabezado-tabla-empleados"> {{listaIdiomas.PuestoTabla}} </th>
                                                        <th class="encabezado-tabla-empleados"> {{listaIdiomas.EstadoTabla}} </th>
                                                        <th class="encabezado-tabla-empleados"> </th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <tr v-cloak  v-for="(empleado, index) in datosPaginados" :key="empleado.IdEmpleados">
                                                        <td class="detalle-tabla-empleado"> {{empleado.Nombre}} </td>
                                                        <td class="detalle-tabla-empleado"> {{empleado.Apellidos}}</td>
                                                        <td class="detalle-tabla-empleado"> {{empleado.Correo}} </td>
                                                        <td class="detalle-tabla-empleado"> {{empleado.Telefono}} </td>
                                                        <td class="detalle-tabla-empleado"> {{empleado.Puesto}} </td>
                                                        <td class="detalle-tabla-empleado" v-if="empleado.Estado == 'True'">
                                                            <select  v-model="empleado.Estado" @change="AbrirPopPup(empleado.IdEmpleados,empleado.Estado)"
                                                                class="select-field select-tabla-ai w-select"
                                                                :id="empleado.Estado" :name="empleado.Estado" :value="empleado.Estado"> 
                                                                <option value="True">{{listaIdiomas.SelectA}}</option>
                                                                <option value="False">{{listaIdiomas.SelectI}}</option>
                                                            </select>
                                                        </td>
                                                       
                                                        <td class="detalle-tabla-empleado" v-else>{{listaIdiomas.SelectI}}</td>
                                                        <td class="detalle-tabla-empleado">
                                                            <div @click="CargarEmpleadoTabla(empleado.Identificacion)" class="text-block-23 link-block-2 amarillo w-inline-block">
                                                                <a :id="empleado.IdEmpleados"  :name="empleado.Nombre":value="empleado.IdEmpleados">
                                                                    <img src="../images/ver.svg" loading="lazy" alt="" class="image-29">
                                                                </a>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </div>
                                </div>
                            </div>
                        </div>
                             
                            <%-- Paginación --%>
                            <div class="pagination-content">
                                    <div class="form-block-19 block-pag w-form">
                                        <div id="email-form-3" name="email-form-3" data-name="Email Form 3" method="get" class="form-11">
                                            <img v-on:click="PaginaAnterior()" src="../images/simbolo-de-doble-flecha-izquierda-hacia-atras-rapido.png"
                                                loading="lazy" width="15" height="15" alt="" class="image-9">
                                            <label for="name-2" class="cant-paginas" v-cloak>{{paginaActual}}</label>
                                            <label for="name-2" class="cant-paginas" v-cloak>de {{paginas}}</label>
                                            <img v-on:click="PaginaSiguiente()" src="../images/angulos-de-flechas-dobles-a-la-derecha.png" loading="lazy" width="15" height="15" alt="" class="image-9">
                                        </div>
                                    </div>
                                </div>
              
                        <div class="div-tarjeta cinta-go-store-ai">
                            <div class="div-block-170 go-store-ai">
                                <div class="text-block-17" v-cloak>{{listaIdiomas.Descubra}}</div>
                                <a href="*" class="boton call2action w-button" v-cloak><strong>{{listaIdiomas.Tienda}}</strong></a>
                            </div>
                        </div>
                        <h4 class="heading-3 h-empleados-ai">Activos asignados</h4>
                        <h4 class="heading-4-subheading" v-cloak>{{nombreUsuario}}</h4>
                        <div class="div-tarjeta div-usuarios-ai">
                            <div class="form-block-usuarios w-form">
                                <div id="email-form-4" name="email-form-4" data-name="Email Form 4" method="get" class="form-rol-usuarios-ai">
                                    <div class="contenedor-grid tabla-usuarios-ai"></div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
        <div class="background-pop-up" id="PConfirmar" style="display:none; text-align:center">
            
      <div class="popup-comercial"  style="display:flex; place-content:center; top: 40%;">
        <div class="header-modal-ai" style="display:block;">
          <h4 class="texto-h-ai" style="text-align: center; font-size: 21px" v-cloak>{{listaIdiomas.MsjConf1}}</h4>
            <br />
            <h4 class="texto-h-ai" style="text-align: center; font-size: 21px" v-cloak>{{listaIdiomas.MsjConf2}}</h4>
        </div>
        
        <div class="div-botones-pp" style="padding-top:2%">
          <a href="#"  class="btn-aceptar-pp w-button" @click="ModificarEstadoEmpleado()" style="margin-right: 25%;" v-cloak>{{listaIdiomas.CofSi}}</a>
            <a href="#"  class="btn-aceptar-pp w-button" @click="CerrarPopPup()" v-cloak>{{listaIdiomas.ConfNo}}</a>
        </div>
      </div>
    </div>
        </div>
    <!--International cellphone input-->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/17.0.18/js/intlTelInput.min.js"></script>
    <script src="../Recursos/JQuery/jquery-3.5.1.min.dc5e7f18c8.js"></script>
    <script src="../js/webflow.js"></script>
    <script src="js/Empleados.js"></script>
</asp:Content>
