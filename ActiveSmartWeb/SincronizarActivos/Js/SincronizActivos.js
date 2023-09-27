var urlIdioma = 'Idioma/IdiomaSincronizacion.aspx'
var urlSincroniza = '../SincronizarActivos/SincronizarActivosAjax.aspx'
var EstadoActivo = 0
var = carga
Vue.component('sincronizaactivo', {
    props: {

    },
    data() {
        return {
            listaidiomaSincronizActivo: this.ObtenerIdioma(),
            IdiomaSincronizacion: "",
            listaInicial: [],
            listaActivos: [],
            listaFinal: [],
            ValorBase: "",
            TotalActivos: 0,
            NombreArchivo: "",
            ActivosCorrectos: 0,
            ActivosIncorrectos: 0,
            ActivosPendientes:0,
            idPerfilEmpresa: "",
            listaCorrectos: [],
            IdArchivo: "",
            listaErrores: [],
            EstadoArchivo:'',
            EstadoActivo:'',

        }
    },
    render: function (createElement) {
        var self = this;
        return createElement('div', {
            attrs: { class: 'section wf-section' }
        }, [
            createElement('div', {
                attrs: { class: 'container-2 w-container' }
            }, [
                createElement('div', {
                    attrs: { class: 'w-layout-grid grid-main' }
                }, [
                    createElement('div', {
                        attrs: { class: 'div-banner-extremo', id: 'w-node-_28f3db33-b16a-6f10-aeaa-110c3af3f04f-fb048ddf' }
                    }, []),
                    createElement('div', {
                        attrs: { class: 'div-banner-extremo', id: 'w-node-_28f3db33-b16a-6f10-aeaa-110c3af3f050-fb048ddf' }
                    }, []),
                    createElement('div', {
                        attrs: { id: 'w-node-_28f3db33-b16a-6f10-aeaa-110c3af3f051-fb048ddf' }
                    }, [
                        createElement('div', {
                            attrs: { class: 'w-layout-grid grid-container-title' }
                        }, [
                            createElement('a', {
                                attrs: {
                                    class: 'link-block-back w-inline-block',
                                    href: '../Menu/MenuPrincipal.aspx'
                                }
                            }, [
                                createElement('img', {
                                    attrs: {
                                        src: '../images/Back-arrow.svg',
                                        class: 'back'
                                    },
                                    style: {
                                        height: '26',
                                        width: '26'
                                    }
                                })
                            ]),
                            createElement('h1', {
                                attrs: { class: 'titulo-principal' },
                                domProps: { innerText: this.listaidiomaSincronizActivo.Titulo }
                            })

                        ])
                    ]),
                    //botones de carga y descarga

                    // Mostrar el div de carga
                    
                    carga.getElementById("loading-spinner").style.display = "flex",

                 // Ocultar el div de carga (cuando se complete la carga)
                    document.getElementById("loading-spinner").style.display = "none",

                    createElement('div', {
                        attrs: { id: 'w-node-_85f34e9c-c2ff-b66a-5d22-dd251014c3e1-fb048ddf', class: 'contenedor-botones carga-descarga alt' }
                    }, [
                        createElement('a', {
                            attrs: { class: 'link-block-boton dere gris w-inline-block' },
                            on: {
                                click: e => {
                                    this.ExportarExcel();
                                }
                            }
                        }, [
                            createElement('img', {
                                attrs: {
                                    src: '../images/descargar.svg'
                                }
                            }),

                        ]),
                            createElement('a', {
                                attrs: { class: 'link-block-boton gris w-inline-block' },
                                on: {
                                    click: e => {
                                        document.getElementById("files").click();
                                    }
                                }
                                
                            },[
                                createElement('input', {
                                    attrs: {
                                        type: "file",
                                        id: "files", name: 'files'
                                },
                                on: {
                                    click: e => {
                                        this.Importar();

                                    }
                                    },
                                    style: {

                                        display: "none"
                                    }
                            }),
                                createElement('img', {
                                    attrs: {
                                       src: '../images/cargar.svg'
                                    }
                                })
                            ]),
                    ]),
                    //Primeras 2 tablas
                        createElement('div', {
                            attrs: { class: 'div-tarjeta sinc', id:'w-node-_28f3db33-b16a-6f10-aeaa-110c3af3f057-fb048ddf'}
                        }, [
                                createElement('div', {
                                    attrs: { class:'contenedor-grid'}
                                }, [
                                    createElement('div', {
                                        attrs: { class: 'w-layout-grid grid'}
                                    }, [
                                            createElement('TableElementos', {
                                              attrs: {
                                                 headers: this.ObtenerHeaders1(),
                                                 datatable: this.listaInicial,
                                                  idDiv: 'w-node-_1881bb3d-bb04-a65f-0013-ab2c81d34079-731f63ba',
                                                  buttons: this.ObtenerBotonTienda(),
                                                    tableName: 'TablaInicial',
                                                    tituloBtns: this.listaidiomaSincronizActivo.Tienda

                                              }
                                              , domProps: {

                                              }
                                          }),
                                    ]),
                                        createElement('div', {
                                            attrs: { class:'w-layout-grid grid'}
                                        }, [
                                                createElement('TableElementos', {
                                                    attrs: {
                                                        headers: this.ObtenerHeadersActivos(),
                                                        datatable: this.listaActivos,
                                                        idDiv: 'w-node-_57fabf73-cd7d-6e66-6d21-ef26647b1b2b-731f63ba',
                                                        buttons: [],
                                                        tableName: 'TablaActivosenSincronizacion',
                                                        state: true,
                                                        stateName: this.listaidiomaSincronizActivo.EstadoSinc,
                                                        imgState: this.ObtenerEstadoActivos()
                                                    }
                                                    , domProps: {

                                                    }
                                                }), 

                                        ])
                                ]),
                     
                            //boton de sincronizar activos
                        createElement('div', {
                            attrs: { class: 'contenedor-botones' }
                        }, [
                            createElement('a', {
                                attrs: { class: 'boton up w-button' },
                                domProps: { innerText: this.listaidiomaSincronizActivo.BtnSinc },
                                on: {
                                    click: e => {
                                        this.InsertarTablaIntermedia();
                                    }
                                }
                            })
                        ])
                    ]),
                    // Tercer Tabla
                    createElement('div', {
                        attrs: { class: 'div-tarjeta', id: 'w-node-_0cdd3411-3ea6-84f5-42a4-1d9057da0e98-fb048ddf' }
                    }, [
                        createElement('div', {
                            attrs: { class: 'contenedor-grid' }
                        }, [
                                createElement('TableElementos', {
                                attrs: {
                                   headers: this.ObtenerHeadersFinal(),
                                   datatable: this.listaFinal,
                                     idDiv: 'w-node-_0cdd3411-3ea6-84f5-42a4-1d9057da0e98-fb048ddf',
                                   buttons: this.ObtenerBotones(),
                                     tableName: 'TablaFinal',
                                        state: true,
                                        stateName: this.listaidiomaSincronizActivo.Estado,
                                        imgState: '../images/x.svg'
                                 }
                                , domProps: {

                                }
                             }),
                            
                         ])
                    ]),
                    //Mensajes de Activos
               
                    createElement('div', {
                         attrs: { class: 'div-tarjeta', id: 'w-node-_28f3db33-b16a-6f10-aeaa-110c3af3f084-fb048ddf' }
                    }, [
                            createElement('div', {
                                attrs: { class: 'div-block-170' }
                            }, [
                                createElement('div', {
                                    attrs: { class: 'text-block-17' },
                                    domProps: { innerText: this.listaidiomaSincronizActivo.ActDisp }
                                }),
                                createElement('a', {
                                    attrs: { class: 'boton call2action w-button' },
                                    domProps: { innerText: this.listaidiomaSincronizActivo.IrTienda }
                                })
                            ])
                        ]),
                    //Boton de salvar blanco
                    createElement('div', {
                          attrs: { class: 'contenedor-botones centrado', id: 'w-node-_85fb6269-9596-9f9c-b6d8-cf233f998bd4-fb048ddf' }
                    }, [
                            createElement('a', {
                                attrs: { class: 'link-block-boton gris w-inline-block' }
                            }, [
                                createElement('img', {
                                    attrs: {
                                        src: '../images/save_blanco.svg'
                                    }
                                }),
                            ])
                        ]),
                  
                ]),

            ])
        ])
    },
    mounted: function () {
        this.ValidarSesion();
        var logueado = JSON.parse(sessionStorage.getItem('DUser'));
        this.idPerfilActive = "" + logueado[0].IdPerfilActive;
        this.idPerfilEmpresa = "" + logueado[0].IdPerfilEmpresa;
        this.ObtenerIdioma();
        this.ObtenerInfoArchivos();
    },

    methods: {
        //Idioma
        ObtenerIdioma: function () {
            var idiRegistro = "ES"
            if (localStorage.getItem("idiomaApp") != undefined) {
                idiRegistro = localStorage.getItem("idiomaApp");
            }
            this.EstablecerIdiomaSincronizar(idiRegistro);
        },
        EstablecerIdiomaSincronizar: function (idioma) {
            var self = this
            $.post(urlIdioma, {
                IdiomaSincronizacion: idioma,
            }, function (data, error) {
                self.listaidiomaSincronizActivo = JSON.parse(data);
            });
        },
        //Headers
        ObtenerHeaders1: function () {
            return JSON.parse('{"headersInfo":["' + this.listaidiomaSincronizActivo.NombreArch + '","' + this.listaidiomaSincronizActivo.TotalAct + '","'
                + this.listaidiomaSincronizActivo.ActivosCorr + '","' + this.listaidiomaSincronizActivo.ActivosIncorr + '","' + this.listaidiomaSincronizActivo.ActivPend
                  + '"]}')
        },
        ObtenerHeadersActivos: function () {
            return JSON.parse('{"headersInfo":["' + this.listaidiomaSincronizActivo.NumAct + '","' + this.listaidiomaSincronizActivo.NumEtiq + '","'
                + this.listaidiomaSincronizActivo.Categ + '","' + this.listaidiomaSincronizActivo.Estado + '","' + this.listaidiomaSincronizActivo.Marca + '","' + this.listaidiomaSincronizActivo.Modelo +
                '","' + this.listaidiomaSincronizActivo.Ubicacion + '","' + this.listaidiomaSincronizActivo.Descripcion + '","' + this.listaidiomaSincronizActivo.Costo + '"]}')
        },
        ObtenerHeadersFinal: function () {
            return JSON.parse('{"headersInfo":["' + this.listaidiomaSincronizActivo.Numero + '","' + this.listaidiomaSincronizActivo.Fecha
                + '"]}')
        },
        //Botones
        ObtenerBotones: function () {
            let botones = []
            botones.push([this.EliminarArchivo, '../images/delete_negro.svg']);
            botones.push([this.InsertarActivoFijo, '../images/save_negro.svg']);
            return botones;
        },
        ObtenerBotonTienda: function () {
            let botones = []
            botones.push([this.ObtenerTienda, '../images/Tienda.png']);
            return botones;
        },
        //Estados
        ObtenerEstadoActivos: function () {
            var imgState = ""; 
            if (EstadoActivo == 0) {
                imgState = '../images/x.svg';
            } else if (EstadoActivo == 1) {
                imgState = '../images/check.svg';
            }
            return imgState;
        },
        //Metodos
        ObtenerTienda: function () {
        },
        EliminarArchivo: function (informacion) {
            let idArchivoI = informacion[0]
            var self = this;
            alertify.confirm('Sincronización de Activos', 'Desea eliminar el archivo?', function () {
                $.post(urlSincroniza, {
                    option: 'BorrarArchivo',
                    IdArchivo: idArchivoI,
                    IdPerfilEmpresa: self.idPerfilEmpresa
                }, function (respo, error) {
                    if (respo == "Exitoso") {
                        alertas.success(self.listaidiomaSincronizActivo.Atencion, self.listaidiomaRegistroActivo.MsjEliminado);
                        self.ObtenerInfoArchivos();
                    } else {
                        alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.MsjErrorEjec);
                    }
                })
            }
                , function () { alertify.error('Cancel') });
               
            
        },
        ExportarExcel: function () {
            var self = this
            var idiRegistro = "ES"
            if (localStorage.getItem("idiomaApp") != undefined) {
                idiRegistro = localStorage.getItem("idiomaApp");
            }
            $.post(urlSincroniza, {
                option: 'Exportar',
                IdiomaSincronizaActivo: idiRegistro

            }, function (data, error) {
                var nombre = 'Activos'
                fetch(data)
                    .then(resp => resp.blob())
                    .then(blob => {
                        const url = window.URL.createObjectURL(blob);
                        const a = document.createElement('a');
                        a.style.display = 'none';
                        a.href = url;
                        a.download = nombre;
                        document.body.appendChild(a);
                        a.click();
                        window.URL.revokeObjectURL(url);
                        alertas.success(self.listaidiomaSincronizActivo.Atencion, self.listaidiomaRegistroActivo.Msjdescarga);
                    })
                    .catch(() => alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.MsjIntenteloNuevo) );
            })
        },
        Importar: function () {
            var self = this;
           
            if (window.File && window.FileReader && window.FileList && window.Blob) {
                document.getElementById('files').addEventListener('change', handleFileSelect, false);
            } else {

            }
            function handleFileSelect(evt) {
                var f = evt.target.files[0]; 
                var reader = new FileReader();
                reader.onload = (function (theFile) {
                    return function (e) {
                        var binaryData = e.target.result;
                        var base64String = window.btoa(binaryData);
                        self.ValorBase = base64String;

                        $.post(urlSincroniza, {
                            option: 'Importar',
                            ExcelBase64: self.ValorBase

                        }, function (data, error) {
                                var resp = JSON.parse(data);
                                self.listaActivos = [];
                                self.EstadoActivo = 'EstSinc0';
                                for (let i = 1; i < resp.length; i += 1) {

                                    self.listaActivos.push([resp[i].NumActivo, resp[i].NumActivo, resp[i].NumEtiqueta,
                                    resp[i].Categoria, resp[i].Estado, resp[i].Marca, resp[i].Modelo,
                                        resp[i].Ubicacion, resp[i].Descripcion, resp[i].Costo, self.EstadoActivo]);
                                  
                                }
                        })

                    };
                })(f);
                reader.readAsBinaryString(f);

            }
        },
        ObtenerInfoArchivos: function () {
            var self = this
            $.post(urlSincroniza, {
                option: 'ConsultaArchivo',
                IdPerfilEmpresa: self.idPerfilEmpresa

            }, function (respuesta, error) {
                var resp = JSON.parse(respuesta);
                    self.listaFinal = [];

                for (let i = 0; i < resp.length; i += 1) {
                    self.listaFinal.push([resp[i].IdArchivo,
                        resp[i].IdArchivo, resp[i].FechaRegistro.split('T')[0], resp[i].EstadoSincronizacionArc]);
                }
            });
        },
        InsertarActivoFijo: function (info) {
            let idArchivoI = info[0]
            var self = this;
            $.post(urlSincroniza, {
                option: 'InsertarActivoFijo',
                IdArchivo: idArchivoI,
                IdPerfilEmpresa: self.idPerfilEmpresa
            }, function (respo, error) {
                    if (respo == "exitoso") {
                        alertas.success(self.listaidiomaSincronizActivo.Atencion, self.listaidiomaRegistroActivo.MsjExitoEjec);
                } else if(respo == "Existe") {
                        alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.MsjErrorEjec)
                }
            })
        },
        InsertarTablaIntermedia: function () {
            var self = this;
            if (this.listaActivos.length == 0) {
                alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.CargaArchivo)
                return;
            }
            $.post(urlSincroniza, {
                option: 'InsertarArchivo',
                IdPerfilEmpresa: self.idPerfilEmpresa,
                Estado: 1
            }, function (data, error) {
                    self.IdArchivo = data;
                    self.listaErrores = [];
                self.listaActivos.forEach(function (valor, indice, array) {
                $.post(urlSincroniza, {
                    option: 'InsertarActivoSincronizacion',
                    NumeroActivo: valor[1],
                    PlacaActivo: valor[2],
                    CategoriaActivo: valor[3],
                    EstadoActivo: valor[4],
                    Marca: valor[5],
                    Modelo: valor[6],
                    UbicacionA: valor[7],
                    DescripcionCorta: valor[8],
                    CostoActivo: valor[9],
                    IdSincArchivo: self.IdArchivo,
                    IdPerfilEmpresa: self.idPerfilEmpresa
                }, function (respuesta, error) {
                    if (respuesta == "Registrado") {
                        alertas.success(self.listaidiomaSincronizActivo.Atencion, self.listaidiomaRegistroActivo.MsjRegistrado);
                        valor[10] = 'EstSinc1';
                        self.EstadoArchivo = 'EstSinc1';
                        self.listaErrores.push("EstSinc1");

                    } else if (respuesta == "ExisteActivo") {
                        alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.RegistroEx);
                        self.EstadoArchivo = 'EstSinc0';
                        valor[10] = 'EstSinc0';
                        self.listaErrores.push("EstSinc0");


                    } else if (respuesta == "NoExisteU") {
                        alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.MsjUbicacion);
                        self.EstadoArchivo = 'EstSinc0';
                        valor[10] = 'EstSinc0';
                        self.listaErrores.push("EstSinc0");


                    } else if (respuesta == "NoExisteE") {
                        alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.MsjEstado);
                        self.EstadoArchivo = 'EstSinc0';
                        valor[10] = 'EstSinc0';
                        self.listaErrores.push("EstSinc0");

                    } else if (respuesta == "NoExisteC") {
                        alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.MsjCategoria);
                        self.EstadoArchivo = 'EstSinc0';
                        valor[10] = 'EstSinc0';
                        self.listaErrores.push("EstSinc0");


                        }
                        self.listaErrores.forEach(function (valor2, indice, array) {
                            if (valor2 == "EstSinc0") {
                                $.post(urlSincroniza, {
                                    option: 'ActualizaEstadoSinc',
                                    IdArchivo: self.IdArchivo,
                                    EstadoSincronizacion: valor2
                                }, function (data, error) {
                                })

                            }
                        })
                        self.ObtenerInfoArchivos();
                });
                    
                  
                });
                   

                    self.ObtenerInfoArchivos();
            })
           
            self.ObtenerInfoArchivos();
          
        },



    }
})

const sincronizaactivo = new Vue({
    el: '#sincronizactivos',
    data: {

    }
})

