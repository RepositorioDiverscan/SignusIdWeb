<%@ Page Language="C#" MasterPageFile="~/SiteMaster/Site.Master" AutoEventWireup="true" CodeBehind="ActivosVisor.aspx.cs" Inherits="ActiveSmartWeb.VisorActivos.visorActivos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="css/PopupImages.css" rel="stylesheet" />
    <div class="main" id="maincontext">
      <div class="section wf-section">
        <div class="container-2 w-container">
          <div class="w-layout-grid grid-main">
            <div id="w-node-d6f4ed57-1129-62a6-87cb-1ae24a506ac6-6b5877df" class="div-banner-extremo"></div>
            <div id="w-node-d6f4ed57-1129-62a6-87cb-1ae24a506ac7-6b5877df" class="div-banner-extremo"></div>
            <div id="w-node-d6f4ed57-1129-62a6-87cb-1ae24a506ac8-6b5877df">
              <div class="w-layout-grid grid-container-title">
                <a href="../Menu/MenuPrincipal.aspx" class="link-block-back w-inline-block"><img src="../images/Back-arrow.svg" loading="lazy" height="26" width="26" alt="" class="back"></a>
                <h1 class="titulo-principal">{{listaIdiomas.Titulo}}</h1>
              </div>
            </div>
            <div id="w-node-d6f4ed57-1129-62a6-87cb-1ae24a506ace-6b5877df" class="div-tarjeta">
              <div class="form-block w-form">
                <div id="email-form" name="email-form" data-name="Email Form" method="get" class="form">
                    <label class="field-label-6">{{listaIdiomas.Fotos}}</label></div>
              
              </div>
              <div class="w-layout-grid grid-6">
                
                
                <a href="#" id="w-node-ba64894d-782b-6dc7-d104-2668049c8f28-6b5877df" class="lightbox-link w-inline-block w-lightbox"> 
                  <img  :src="Foto1" loading="lazy" width="140" height="140" id="f1" alt="">
                   <!-- The Modal -->
                  <div id="myModal" class="modal">
                      <span class="close">&times;</span>
                      <img class="modal-content" id="img01">
                  </div> 
                    </a>

                  <a href="#" id="w-node-ba64894d-782b-6dc7-d104-2668049c8f28-6b5877df" class="lightbox-link w-inline-block w-lightbox"> 
                  <img  :src="Foto2" loading="lazy" width="140" height="140" id="f2" alt="">
                   <!-- The Modal -->
                  <div id="myModal" class="modal">
                      <span class="close">&times;</span>
                      <img class="modal-content" id="img01">
                  </div> 
                    </a>



                  <a href="#" id="w-node-ba64894d-782b-6dc7-d104-2668049c8f28-6b5877df" class="lightbox-link w-inline-block w-lightbox"> 
                  <img  :src="Foto3" loading="lazy" width="140" height="140" id="f3" alt="">
                   <!-- The Modal -->
                  <div id="myModal" class="modal">
                      <span class="close">&times;</span>
                      <img class="modal-content" id="img01">
                  </div> 
                    </a>




                  <a href="#" id="w-node-ba64894d-782b-6dc7-d104-2668049c8f28-6b5877df" class="lightbox-link w-inline-block w-lightbox"> 
                  <img  :src="Foto4" loading="lazy" width="140" height="140" id="f4" alt="">
                   <!-- The Modal -->
                  <div id="myModal" class="modal">
                      <span class="close">&times;</span>
                      <img class="modal-content" id="img01">
                  </div> 
                    </a>




                  <a href="#" id="w-node-ba64894d-782b-6dc7-d104-2668049c8f28-6b5877df" class="lightbox-link w-inline-block w-lightbox"> 
                  <img  :src="Foto5" loading="lazy" width="140" height="140" id="f5" alt="">
                   <!-- The Modal -->
                  <div id="myModal" class="modal">
                      <span class="close">&times;</span>
                      <img class="modal-content" id="img01">
                  </div> 
                    </a>



                <div id="w-node-_5ebf7aa3-f91b-15a8-2f5b-31b1fdf23146-6b5877df" class="w-form">
                  <div id="email-form-3" name="email-form-3" data-name="Email Form 3" method="get">
                      <label for="name" class="field-label-7">{{listaIdiomas.Foto1}}</label></div>
                 
                </div>

                <div id="w-node-_50b65674-93f0-175d-ec19-337fa9274245-6b5877df" class="w-form">
                  <div id="email-form-3" name="email-form-3" data-name="Email Form 3" method="get">
                      <label for="name-5" class="field-label-7">{{listaIdiomas.Foto2}}</label></div>
                 

                </div>

                <div id="w-node-_8a6c689b-5d04-c399-5407-a25301e8400c-6b5877df" class="w-form">
                  <div id="email-form-3" name="email-form-3" data-name="Email Form 3" method="get">
                      <label for="name-5" class="field-label-7">{{listaIdiomas.Foto3}}</label></div>
                 
                </div>

                <div id="w-node-dc48fed0-9211-dce2-d3f2-90ce8444737d-6b5877df" class="w-form">
                  <div id="email-form-3" name="email-form-3" data-name="Email Form 3" method="get">
                      <label for="name-5" class="field-label-7">{{listaIdiomas.Foto4}}</label></div>
                 
                </div>

                <div id="w-node-_55e66f73-4803-1a0a-5143-9ee0bc1975c0-6b5877df" class="w-form">
                  <div id="email-form-3" name="email-form-3" data-name="Email Form 3" method="get">
                      <label for="name-5" class="field-label-7">{{listaIdiomas.Foto5}}</label></div>
                  
                </div>
              </div>
            </div>
            <div id="w-node-d6f4ed57-1129-62a6-87cb-1ae24a506afb-6b5877df" class="div-tarjeta">
              <div class="div-block-170">
                <div class="text-block-17">Descubra más de lo que ActiveID Smart tiene para Usted</div>
                <a href="../Menu/MenuPrincipal.aspx" class="boton call2action w-button">Ir a Tienda<strong></strong></a>
              </div>
            </div>
            <div id="w-node-d6f4ed57-1129-62a6-87cb-1ae24a506b03-6b5877df" class="div-tarjeta">
              <div class="contenedor-grid visor">
                <div class="w-layout-grid grid _3 visor">
                  <div class="texto-blanco">{{listaIdiomas.NumActivo}}</div>
                  <div class="texto-blanco">{{listaIdiomas.PlacaActivo}}</div>
                  <div class="texto-blanco">{{listaIdiomas.Serie}}</div>
                  <div class="texto-blanco">{{listaIdiomas.Categoria}}</div>
                  <div class="texto-blanco">{{listaIdiomas.Estado}}</div>
                  <div class="celda-vacia">
                    <div class="parrafo-grid" >{{Numero_Activo}}</div>
                  </div>
                  <div class="celda-vacia">
                    <div class="parrafo-grid"><label>{{Numero_Placa}}</label></div>
                  </div>
                  <div class="celda-vacia">
                    <div class="parrafo-grid">{{Numero_Serie}}</div>
                  </div>
                  <div class="celda-vacia">
                    <div class="parrafo-grid">{{Categoria}}</div>
                  </div>
                  <div class="celda-vacia">
                    <div class="parrafo-grid">{{Estado}}</div>
                  </div>
                </div>
              </div>
              <div class="contenedor-grid visor linea2">
                <div class="w-layout-grid grid _3 visor linea2">
                  <div class="texto-blanco">{{listaIdiomas.Descripcion1}}</div>
                  <div class="texto-blanco">{{listaIdiomas.Descripcion2}}</div>
                  <div class="texto-blanco">{{listaIdiomas.Marca}}</div>
                  <div class="texto-blanco">{{listaIdiomas.Modelo}}</div>

                  <div class="celda-vacia">
                    <div class="parrafo-grid">{{Descripcion1}}</div>
                  </div>
                  <div class="celda-vacia">
                    <div class="parrafo-grid">{{Descripcion2}}</div>
                  </div>
                  <div class="celda-vacia">
                    <div class="parrafo-grid">{{Marca}}</div>
                  </div>
                  <div class="celda-vacia">
                    <div class="parrafo-grid">{{Modelo}}</div>
                  </div>
                </div>
              </div>
              <div class="contenedor-grid visor linea2"></div>
              <div class="form-block-10 w-form">
                <div id="email-form-2" name="email-form-2" data-name="Email Form 2" method="get">
                    <label for="name-5" class="field-label-5">{{listaIdiomas.Ubicaciones}}</label></div>
               
              </div>
              <div class="contenedor-grid visor">
                <div class="w-layout-grid grid _3 visor linea3">
                  <div id="w-node-dba6c407-c6f5-fc6c-1602-3d53d9520240-6b5877df" class="div-block-205"><img src="../images/placeholder_A.svg" loading="lazy" alt="" class="image-49"></div>
                  <div class="ubicacion">{{UbicacionA}}</div>
                  <div id="w-node-abded6b2-5fed-5d81-f75b-8bc16440d8c0-6b5877df" class="div-block-205"><img src="../images/placeholder_B.svg" loading="lazy" alt="" class="image-49"></div>
                  <div class="ubicacion">{{UbicacionB}}</div>
                  <div id="w-node-_91b031af-7220-e02d-79cd-824c958005c5-6b5877df" class="div-block-205"><img src="../images/placeholder_C.svg" loading="lazy" alt="" class="image-49"></div>
                  <div class="ubicacion">{{UbicacionC}}</div>
                  <div id="w-node-d91fc62e-eeda-feb4-7b5f-0ca037681980-6b5877df" class="div-block-205"><img src="../images/placeholder_D.svg" loading="lazy" alt="" class="image-49"></div>
                  <div class="ubicacion" >{{UbicacionD}}</div>
                </div>
              </div>
              <div class="observaciones w-form">
                <div id="email-form-2" name="email-form-2" data-name="Email Form 2" method="get">
                    <label for="name-5" class="field-label-5">{{listaIdiomas.Observaciones}}</label>
                  <div class="celda-vacia observaciones">
                    <div class="parrafo-grid"><span >{{Observaciones}}</span></div>
                  </div>
                </div>
               
              </div>
            </div>
            <div id="w-node-d6f4ed57-1129-62a6-87cb-1ae24a506b23-6b5877df" class="div-tarjeta">
              <div class="form-block w-form">
                <div id="email-form" name="email-form" data-name="Email Form" method="get" class="form">
                  <div class="w-layout-grid grid-busqueda">
                    <div id="w-node-d6f4ed57-1129-62a6-87cb-1ae24a506b27-6b5877df" class="contenedor-buscar"><input type="text" v-model="Criterio_Busqueda" class="text-field w-input" maxlength="256" name="name-4" data-name="Name 4" placeholder="" id="name-4">
                      <a href="#" class="contenedor-icono w-inline-block" v-on:click="BuscarActivoVisor"><img src="../images/icono_buscar_acces-o-01.svg" loading="lazy" alt=""></a>
                    </div><select id="field-4" name="field-4" data-name="field-4" class="select-field w-node-d6f4ed57-1129-62a6-87cb-1ae24a506b2b-6b5877df w-select" v-model="Select_Busqueda">
                     
                        <option  value="0">{{listaIdiomas.SelectFiltro}}</option>
                      <option value="1">{{listaIdiomas.NumActivo}}</option>
                      <option value="2">{{listaIdiomas.PlacaActivo}}</option>

                    </select>
                  </div>
                </div>
                
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
   
    <script src="js/ActivosVisor.js"></script>
    <script src="Vue/vue.min.js"></script>
    <script src="js/PopPupImages.js"></script>

</asp:Content>


