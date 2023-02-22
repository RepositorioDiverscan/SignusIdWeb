<%@ page title="" language="C#" masterpagefile="~/SiteMaster/Site.Master" autoeventwireup="true" codebehind="MenuPrincipal.aspx.cs" inherits="ActiveSmartWeb.Menu.MenuPrincipal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="prinApp" class="main" >


        <div class="section wf-section">
            <div class="container-2 w-container">
                <div class="w-layout-grid grid-main grid-menu">
                    <div id="w-node-a911d035-0fb8-b12b-302b-2b0449865d03-a8a2a4c2" class="div-banner-extremo"></div>
                    <div id="w-node-a911d035-0fb8-b12b-302b-2b0449865d04-a8a2a4c2" class="div-banner-extremo"></div>
                    <div id="w-node-a911d035-0fb8-b12b-302b-2b0449865d05-a8a2a4c2" class="block-titulo">
                        <div class="w-layout-grid grid-container-title">
                            <h1 id="w-node-a911d035-0fb8-b12b-302b-2b0449865d09-a8a2a4c2" class="titulo-principal" v-cloak>{{listaidioma.Menu}}</h1><!-- MENU PRINCIPAL -->
                        </div>
                    </div>

                    <div id="w-node-a911d035-0fb8-b12b-302b-2b0449865d0b-a8a2a4c2" class="div-tarjeta tarjeta-menu w-clearfix">

                        <div class="div-block-menu">


                            <div class="contenedor-admin">
                                <a id="lnkPerfil"
                                    :class="btnPerfil ? 'contenedor-icono-admin w-inline-block' : 'contenedor-icono-admin none w-inline-block'">
                                    <div class="menu perfil"></div>
                                </a>

                                <div :class="btnPerfil ? 'titulo-icono' : 'titulo-icono none'" v-cloak>{{listaidioma.Perfil}}</div> <!-- PERFIL -->
                            </div>



                            <div class="contenedor-admin">
                                <a :href="btnRegistroGestionActivos ? '../RegistroActivos/RegistroActivos.aspx' : '#'"
                                    :class="btnRegistroGestionActivos ? 'contenedor-icono-admin w-inline-block' : 'contenedor-icono-admin none w-inline-block'">
                                    <div class="menu registro"></div>
                                </a>
                                <div :class="btnRegistroGestionActivos ? 'titulo-icono' : 'titulo-icono none'" v-cloak>{{listaidioma.RegistroActivo}}</div><!--GESTIÓN DE ACTIVOS-->
                            </div>



                            <div class="contenedor-admin">
                                <a :href="btnSincronizarActivos ? '../SincronizarActivos/SincronizarActivos.aspx' : '#'"
                                    :class="btnSincronizarActivos ? 'contenedor-icono-admin w-inline-block' : 'contenedor-icono-admin none w-inline-block'">
                                    <div class="menu sincronizacion"></div>
                                </a>
                                <div :class="btnSincronizarActivos ? 'titulo-icono' : 'titulo-icono none'" v-cloak>{{listaidioma.SincronizarActivo}}</div> <!--SINCRONIZAR ACTIVO-->
                            </div>


                            <div class="contenedor-admin">
                                <a :href="btnTomasFisicas ? '../Tomafisica/TomaFisica.aspx' : '#'"
                                    :class="btnTomasFisicas ? 'contenedor-icono-admin w-inline-block' : 'contenedor-icono-admin none w-inline-block'">
                                    <div class="menu tomas"></div>
                                </a>
                                <div :class="btnTomasFisicas ? 'titulo-icono' : 'titulo-icono none'" v-cloak>{{listaidioma.TomaFisica}}</div> <!--TOMA FÍSICA-->
                            </div>


                            <div class="contenedor-admin">
                                <a :href="btnReportes ? '../SubMenuReportes/Reportes.aspx' : '#'"
                                    :class="btnReportes ? 'contenedor-icono-admin w-inline-block' : 'contenedor-icono-admin none w-inline-block'">
                                    <div class="menu reportes"></div>
                                </a>
                                <div :class="btnReportes ? 'titulo-icono' : 'titulo-icono none'" v-cloak>{{listaidioma.Reporte}}</div> <!--REPORTE-->
                            </div>


                            <div class="contenedor-admin">
                                <%--<a
                                    :href="btnTienda ? '../Tienda/Tienda.aspx' : '#'" 
                                    :class="btnTienda ? 'contenedor-icono-admin w-inline-block' : 'contenedor-icono-admin none w-inline-block'">
                                    <div class="menu tienda"></div>
                                </a>--%>
                                <a
                                    href="#" 
                                    class="contenedor-icono-admin none w-inline-block">
                                    <div class="menu tienda"></div>
                                </a>
                                 <%--<div :class="btnTienda ? 'titulo-icono' : 'titulo-icono none'" v-cloak>{{listaidioma.Tienda}}</div>--%>
                                <div class="titulo-icono none" v-cloak>{{listaidioma.Tienda}}</div> <!--TIENDA-->
                            </div>


                            <div class="contenedor-admin">
                                <a
                                    :href="btnUbicaciones ? '../Ubicaciones/UbicacionA.aspx' : '#'" 
                                    :class="btnUbicaciones ? 'contenedor-icono-admin w-inline-block' : 'contenedor-icono-admin none w-inline-block'">
                                    <div class="menu ubicaciones"></div>
                                </a>
                                <div :class="btnUbicaciones ? 'titulo-icono' : 'titulo-icono none'" v-cloak>{{listaidioma.Ubicacion}}</div> <!--UBICACIONES-->
                            </div>


                            <div class="contenedor-admin">
                                <a
                                    :href="btnGestionServicio ? '../GestionServicio/GestionServicio.aspx' : '#'" 
                  :class="btnGestionServicio ? 'contenedor-icono-admin w-inline-block' : 'contenedor-icono-admin none w-inline-block'">
                                    <div class="menu gestion"></div>
                                </a>
                                <div :class="btnGestionServicio ? 'titulo-icono' : 'titulo-icono none'" v-cloak>{{listaidioma.GestionServicio}}</div> <!--GESTIÓN DE SERVICIO-->
                            </div>


                            <div class="contenedor-admin">
                                <a
                                    :href="btnRolesPermisos ? '../RolesPermisos/Roles.aspx' : '#'" 
                  :class="btnRolesPermisos ? 'contenedor-icono-admin w-inline-block' : 'contenedor-icono-admin none w-inline-block'">
                                    <div class="menu rolesypermisos"></div>
                                </a>
                                <div :class="btnRolesPermisos ? 'titulo-icono' : 'titulo-icono none'" v-cloak>{{listaidioma.RolPermission}}</div> <!--ROLES Y PERMISOS-->
                            </div>


                            <div class="contenedor-admin">
                                <a
                                    :href="btnUsuarios ? '#' : '#'" 
                  :class="btnUsuarios ? 'contenedor-icono-admin w-inline-block' : 'contenedor-icono-admin none w-inline-block'">
                                    <div class="menu usuario"></div>
                                </a>
                                <div :class="btnUsuarios ? 'titulo-icono' : 'titulo-icono none'" v-cloak>{{listaidioma.User}}</div> <!--USUARIOS-->
                            </div>


                            <div class="contenedor-admin">
                                <a :href="btnEmpleados ? '#' : '#'" 
                  :class="btnEmpleados ? 'contenedor-icono-admin w-inline-block' : 'contenedor-icono-admin none w-inline-block'">
                                    <div class="menu personal "></div>
                                </a>
                                <div :class="btnEmpleados ? 'titulo-icono' : 'titulo-icono none'" v-cloak>{{listaidioma.Personal}}</div> <!--PROVEEDORES-->
                            </div>


                            <div class="contenedor-admin">
                                <a :href="btnRFID ? '#' : '#'" 
                  :class="btnRFID ? 'contenedor-icono-admin w-inline-block' : 'contenedor-icono-admin none w-inline-block'">
                                    <div class="menu rfid"></div>
                                </a>
                                <div :class="btnRFID ? 'titulo-icono' : 'titulo-icono none'">RFID</div>
                            </div>

                            <div class="contenedor-admin">
                                <a :href="btnDashBoard ? '#' : '#'" 
                  :class="btnDashBoard ? 'contenedor-icono-admin w-inline-block' : 'contenedor-icono-admin none w-inline-block'">
                                    <div class="menu dashboard"></div>
                                </a>
                                <div :class="btnDashBoard ? 'titulo-icono' : 'titulo-icono none'">DASHBOARD</div>
                            </div>
                        </div>


                        <div class="type-plan-text-ai">BASIC</div>
                    </div>
                    <div id="w-node-c801d4b9-60fc-9f0d-1568-0b94afe512f8-a8a2a4c2" class="div-resumen-contenedor-ai w-clearfix">
                        <div id="w-node-fdd6831d-b750-e922-1306-c2ddcac0b397-a8a2a4c2" class="resumen-inventarios-e-incidentes mini-resumen">
                            <div id="w-node-fdd6831d-b750-e922-1306-c2ddcac0b398-a8a2a4c2" class="div-tarjeta incientes">
                                <div class="div-block-menu resumen">
                                    <div class="celda-resumen-menu">
                                        <div class="titulo-resumen">

                                            <div v-if="idi = 'ES'" class="text-block-21" v-cloak>
                                                {{listaidioma.Incidentes}}<!--INCIDENTES-->
                                                <br />
                                                {{listaidioma.Pendientes}}<!--PENDIENTES-->
                                            </div>
                                            <div v-else-if="idi = 'EN'" class="text-block-21" v-cloak>
                                                {{ listaidioma.Pendientes }}
                                                <br />
                                                {{ listaidioma.Incidentes }}
                                            </div>

                                        </div>
                                        <div class="numero" v-cloak>{{totalIncidentes}}</div>
                                    </div>
                                </div>
                            </div>
                            <div id="w-node-fdd6831d-b750-e922-1306-c2ddcac0b3a2-a8a2a4c2" class="div-tarjeta inventarios">
                                <div class="div-block-menu resumen">
                                    <div class="celda-resumen-menu">
                                        <div class="titulo-resumen">

                                            <div v-if="idi = 'ES'" class="text-block-21" v-cloak>
                                                {{ listaidioma.Inventarios }}<!--INVENTARIOS--><br />
                                                {{ listaidioma.Incompletos }}<!--INCOMPLETOS-->
                                            </div>
                                            <div v-else-if="idi = 'EN'" class="text-block-21" v-cloak>
                                                {{ listaidioma.Incompletos }}<br />
                                                {{ listaidioma.Inventarios }}
                                            </div>

                                        </div>
                                        <div class="numero" v-cloak>
                                            {{tomasIncompletas}}</div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div id="w-node-aab527a3-3a5b-2ef5-0893-cce136080433-a8a2a4c2" class="div-tarjeta tarjeta-grafico">
                            <div class="div-block-menu resumen">
                                <div class="celda-resumen-menu grafico">
                                    <div style="width: 50%; margin: 0 auto;">
                                        <canvas id="myChart"></canvas>
                                    </div>
                                    <div class="contenedorvalores">
                                        <div class="color-valor">
                                            <div class="color _1"></div>
                                            <div v-cloak>{{listaidioma.Vencidos}}<!--VENCIDOS--></div>
                                        </div>
                                        <div class="color-valor">
                                            <div class="color _2"></div>
                                            <div v-cloak>{{listaidioma.Completos}}<!--COMPLETOS--></div>
                                        </div>
                                        <div class="color-valor">
                                            <div class="color _3"></div>
                                            <div v-cloak>{{listaidioma.Pendientes}}<!--PENDIENTES--></div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div id="w-node-a911d035-0fb8-b12b-302b-2b0449865d22-a8a2a4c2" class="div-tarjeta div-cinta">
                        <div class="div-block-170">
                            <div class="text-block-17" v-cloak>{{listaidioma.LblMasFunciones}}</div>
                            <a href="../Menu/MenuPrincipal.aspx" class="boton call2action w-button" v-cloak>{{listaidioma.BtnPro}}<strong></strong></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>



    </div>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/3.9.1/chart.min.js" integrity="sha512-ElRFoEQdI5Ht6kZvyzXhYG9NqjtkmlkfYk0wr6wHxU9JEHakS7UJZNeml5ALk+8IKlU6jDgMabC3vkumRokgJA==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/webfont/1.6.26/webfont.js" type="text/javascript"></script>
    <script src="../Recursos/JQuery/jquery.min.js"></script>
    <script src="../Recursos/JQuery/jquery-3.5.1.min.dc5e7f18c8.js"></script>
    <script src="../Recursos/Vue/vue.js"></script>
    <script async="async" src="js/Menu.js"></script> 
    

</asp:Content>
