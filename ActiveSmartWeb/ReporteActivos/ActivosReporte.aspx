<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/Site.Master" AutoEventWireup="true" CodeBehind="ActivosReporte.aspx.cs" Inherits="ActiveSmartWeb.ReporteActivos.ActivosReporte" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="main" id="REA">
      <div class="section wf-section" id="alertas">
        <div class="container-2 w-container">
          <div class="w-layout-grid grid-main grid-activos">
            <div id="w-node-_80b7fc40-ee3a-65fb-484a-db136c4f7f80-81b79b2e" class="div-banner-extremo"></div>
            <div id="w-node-_80b7fc40-ee3a-65fb-484a-db136c4f7f81-81b79b2e" class="div-banner-extremo"></div>
            <div id="w-node-_80b7fc40-ee3a-65fb-484a-db136c4f7f82-81b79b2e" class="div-titulo">
              <div class="w-layout-grid grid-container-title" style="padding-top:10px; padding-bottom:10px">
                <a href="#" onclick="window.history.back()" class="link-block-back-3 w-inline-block">
                    <img src="../images/Back-arrow.svg" loading="lazy" height="26" width="26" alt="" class="back"></a>
                <h1 id="w-node-_80b7fc40-ee3a-65fb-484a-db136c4f7f86-81b79b2e" 
                    class="titulo-principal" v-cloak>{{listaIdioma.Titulo}}</h1> 
                  <div data-hover="false" data-delay="0" id="w-node-_01c345db-44dd-5950-8797-fc0e77f5b71f-731f63ba" class="dropdown-detalles-ai w-dropdown">
                  <div class="toggle-detalles-ai w-dropdown-toggle" style="padding:0px"><img src="../images/info2.svg" loading="lazy" alt="" class="img-detalles-ai"></div>
                  <nav class="detalles-descrp-ai w-dropdown-list">
                    <p class="p-desc-detalles-ai" v-cloak>{{listaIdioma.Msj1}}<strong><br>{{listaIdioma.Msj2}}</strong></p> 
                  </nav>
                </div>
              </div>
            </div>

            
            <div id="w-node-_80b7fc40-ee3a-65fb-484a-db136c4f7fbd-81b79b2e" class="div-tarjeta tarjeta-responsive">
              <div class="form-block w-form">

                <div  id="email-form" name="email-form" data-name="Email Form" method="get" class="form">
                  <div class="w-layout-grid grid-busqueda">
                      
                      <select v-cloak id="Categor-a" name="Categor-a" data-name="Categoría" 
                           v-on:change="FiltrarCE" 
                           v-model="selectCategoria" 
                           class="select-field select-filtro-ai select-activo w-node-e3d6520c-cccc-c8b1-abc5-5e1346015ac1-81b79b2e w-select">
                        <option   value="0">Categoría</option>
                        <option v-for="ubi in Categorias" :key="ubi.IdCategoriaActivo" :value="ubi.IdCategoriaActivo"
                            >{{ubi.NombreCategoria}}</option >                                           
                    
                    </select>
                    
                      <select v-cloak id="Estado" name="Estado" data-name="Estado"
                           v-on:change="FiltrarCE" 
                          v-model="selectEstado" 
                      class="select-field select-filtro-ai select-activo w-node-d5abb89d-4b4f-d2fe-eb00-2132f4ef7838-81b79b2e w-select">
                    
                         <option value="0">Estado</option>
                        <option v-for="estado in Estados" :key="estado.IdEstadoActivo" 
                            :value="estado.IdEstadoActivo"  >{{estado.NombreEstado}}</option >     
                      </select>

                 

                    
                    <input type="text" v-on:keyup.enter="FiltrarDescripcion()" class="text-field txt-descripcion w-node-_1fe7e54c-89d7-0657-8649-7c9f4ea7fb58-81b79b2e w-input" maxlength="80" 
                        name="Desc" data-name="Desc" 
                        v-model="filtro"
                        :placeholder=[[listaIdioma.DescripcionPlace]] id="Desc" required="">
                      
                    <a id="w-node-_80b7fc40-ee3a-65fb-484a-db136c4f7fcf-81b79b2e" href="#"
                        v-on:click="FiltrarDescripcion()"
                        class="contenedor-icono w-inline-block">
                        <img src="../images/icono_buscar_acces-o-01.svg" loading="lazy" alt=""></a>
       
                  </div>
                </div>
              
              </div>
            </div>

            <div id="w-node-_80b7fc40-ee3a-65fb-484a-db136c4f7f90-81b79b2e" 
                class="div-tarjeta tarjeta-responsive">
              <div class="contenedor-grid ">
                <table  style="width:100%; overflow:scroll;" >
                <thead >
                    <tr v-cloak class="w-layout-grid grid _7" style="grid-template-rows: auto;grid-template-columns: 12.4% 12.4% 12.4% 12.4% 12.4% 12.4% 12.4% 12.4%;">
                        <th class="texto-blanco">{{listaIdioma.NumActivo}}</th> 
        
                        <th class="texto-blanco">{{listaIdioma.NumPlaca}}</th> 
        
                        <th class="texto-blanco">{{listaIdioma.Descripcion}}</th> 
        
                        <th class="texto-blanco">{{listaIdioma.IdEstadoActivo}}</th>
       
                        <th class="texto-blanco">{{listaIdioma.IdCategoria}}</th>
      
                        <th class="texto-blanco">{{listaIdioma.IdUbicacionA}}</th> 
        
                        <th class="texto-blanco">{{listaIdioma.FechaRegistro}}</th> 
        
                        <th class="texto-blanco">{{listaIdioma.FechaActualiza}}</th> 
                    </tr>
                </thead>
    <tbody  style="display: table; flex-direction: column;"  class="w-layout-grid grid ">

        <tr v-cloak v-for="(ac, index) in datosPaginados" :key="ac.IdActivo" class="w-layout-grid grid _7" <%--style=" grid-template-columns: 12.4% 12.4% 12.4% 12.4% 12.4% 12.4% 12.4% 12.4%;"--%>>

            <td class=" celda-vacia no-pad">
                <div class="parrafo-grid">
                     {{ac.NumActivo}}
                </div>
            </td>
        
            <td class="celda-vacia no-pad">
                <div class="parrafo-grid">
                     {{ac.NumPlaca}}
                </div>
            </td>

            <td class=" celda-vacia">
              <div class="parrafo-grid">
                   {{ac.DescripcionActivo}}
              </div>
          </td>

          <td  class="celda-vacia">
            <div class="parrafo-grid">
                 {{ac.NombreEstado}}
            </div>
        </td>

        <td  class="celda-vacia">
          <div class="parrafo-grid">
                 {{ac.NombreCategoria}} 
          </div>
      </td>

      <td  class="celda-vacia">
        <div class="parrafo-grid">
            {{ac.NombreUbicacionA}}
        </div>
    </td>
    
    <td  class="celda-vacia">
      <div class="parrafo-grid">
           {{FormatearFecha(ac.FechaRegistro)}}
      </div>
  </td>
  
  <td  class="celda-vacia">
    <div class="parrafo-grid">
      {{FormatearFecha(ac.FechaActualizacon)}}
    </div>
</td>


        </tr>
    </tbody>
    <tfoot>
        <tr>
            <td>
                  <br />
                <div class="pagination-content">
                 
                  <div class="contenedor-botones cont-btns-left">
                   <a href="#" v-on:click="ExportarExcel()" class="boton gris w-button">EXCEL</a>
                  <a href="#" v-on:click="GenerarReportePDF()" class="boton gris w-button">PDF</a>
                  </div>
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
            </td>
        </tr>
    </tfoot>
</table>
                   <table  style="width:100%; overflow:scroll;"  hidden="true" id="TablaActivos" >
    <thead >
        <tr v-cloak class="w-layout-grid grid _7">
            <th class="texto-blanco">{{listaIdioma.NumActivo}}</th>
        
            <th class="texto-blanco">{{listaIdioma.NumPlaca}}</th>
        
            <th class="texto-blanco">{{listaIdioma.Descripcion}}</th>
        
            <th class="texto-blanco">{{listaIdioma.IdEstadoActivo}}</th>
       
            <th class="texto-blanco">{{listaIdioma.IdCategoria}}</th>
      
            <th class="texto-blanco">{{listaIdioma.IdUbicacionA}}</th>
        
            <th class="texto-blanco">{{listaIdioma.FechaRegistro}}</th>
        
            <th class="texto-blanco">{{listaIdioma.FechaActualiza}}</th>
        </tr>
    </thead>
    <tbody  style="display: table; flex-direction: column;"  class="w-layout-grid grid _7">

        <tr v-cloak v-for="(ac, index) in listaActivos" :key="ac.IdActivo" 
            
             class="w-layout-grid grid _7 "
            >

            <td class=" celda-vacia no-pad">
                <div class="parrafo-grid">
                     {{ac.NumActivo}}
                </div>
            </td>
        
            <td class="celda-vacia no-pad">
                <div class="parrafo-grid">
                     {{ac.NumPlaca}}
                </div>
            </td>

            <td class=" celda-vacia">
              <div class="parrafo-grid">
                   {{ac.DescripcionActivo}}
              </div>
          </td>

          <td  class="celda-vacia">
            <div class="parrafo-grid">
                 {{ac.NombreEstado}}
            </div>
        </td>

        <td  class="celda-vacia">
          <div class="parrafo-grid">
                 {{ac.NombreCategoria}} 
          </div>
      </td>

      <td  class="celda-vacia">
        <div class="parrafo-grid">
            {{ac.NombreUbicacionA}}
        </div>
    </td>
    
    <td  class="celda-vacia">
      <div class="parrafo-grid">
           {{ac.FechaRegistroMostrar}}
      </div>
  </td>
  
  <td  class="celda-vacia">
    <div class="parrafo-grid">
      {{ac.FechaActualizaMostrar}}
    </div>
</td>


        </tr>
    </tbody>

</table>
            </div>
            <div id="w-node-_7ebb2f58-3823-38f6-0b04-dcf5a7a92582-81b79b2e" class="div-tarjeta div-cinta tarjeta-responisve">
              <div class="div-block-170">
                <div class="text-block-17" v-cloak>{{listaIdioma.MsjTienda}}</div> 
                <a href="../Tienda/Tienda.aspx" class="boton call2action w-button" v-cloak>{{listaIdioma.MsjbtnTienda}}<strong></strong></a> 
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    
   </div>

    <script src="Js/ReporteActivos.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/jspdf/1.5.3/jspdf.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jspdf-autotable/3.2.3/jspdf.plugin.autotable.min.js"></script>


</asp:Content>

