var urlIdioma = 'Idioma/IdiomaActualizaAct.aspx'
var urlActivos = '../Activos/ActivoAjax.aspx'

Vue.component('actualizaactivo', {
    props: {
    },
    data() {
        return {
            listaidiomaActualizaAct: this.ObtenerIdioma(),
            IdiomaActualizaActivos: "",
            listaActivos: [],
            numeroActivo: '',
            idPerfilActive: '',
            idPerfilEmpresa: '',
            Seleccion: '-1',
            ValorAct: '1',
            ValorPlac: '2',
            ValorDesc:'3'
        }
    },
    render: function (createElement) {
        var self = this;
        const obteneropcionesfiltro = () => {
            let optionArray = []
            optionArray.push(
                createElement('option', {
                    domProps: {
                        innerText: this.listaidiomaActualizaAct.SelectFiltro,
                        value: -1
                    }

                }))
            optionArray.push(
                createElement('option', {
                    domProps: {
                        innerText: this.listaidiomaActualizaAct.NumActivo,
                        value: self.ValorAct
                    }

                })), optionArray.push(
                    createElement('option', {
                        domProps: {
                            innerText: this.listaidiomaActualizaAct.PlacaActivo,
                            value: self.ValorPlac
                        }
                    })),
                optionArray.push(
                    createElement('option', {
                        domProps: {
                            innerText: this.listaidiomaActualizaAct.Descripcion,
                            value: self.ValorDesc
                        }
                    }))
            
            return optionArray
           }
        
        return createElement('div', {
            attrs: { class: 'section' }
        }, [
            createElement('div', {
                attrs: { class: 'container-2 w-container' }
            }, [
                createElement('div', {
                    attrs: { class: 'w-layout-grid grid-main' }
                }, [createElement('div', {
                        attrs: { class: 'div-banner-extremo', id: 'w-node-a00a1564-3645-4a63-ae55-70dd1344b632-780e62be' }
                    }, [
                    ]),
                    createElement('div', {
                        attrs: { class: 'div-banner-extremo', id: 'w-node-a00a1564-3645-4a63-ae55-70dd1344b633-780e62be' }
                    }, [
                    ]),
                    createElement('div', {

                        attrs: { id: 'w-node-a00a1564-3645-4a63-ae55-70dd1344b634-780e62be' }
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
                            ]), [
                                createElement('h1', {
                                    attrs: {
                                        class: 'titulo-principal'

                                    }, domProps: {
                                        innerText: this.listaidiomaActualizaAct.Titulo
                                    }
                                })
                            ]

                        ])
                    ]),
                    //Fin del titulo
                    //inserto de tabla                   
                        createElement('TableBotones', {
                        attrs: {
                            headers: this.ObtenerHeaders(),
                            datatable: this.listaActivos,
                            idDiv: 'w-node-_2e71522f-abb1-9bfe-fedf-7c5d89cf9023-780e62be',
                                buttons: this.ObtenerBotones(),
                                tableName: 'TablaActivos'
                        }   
                    }),
                    // fin de la tabla
                    createElement('div', {
                        attrs: {
                            id: 'w-node-_2c1a7e9b-76b3-1d7e-7198-756f58c24a9c-780e62be', class: 'div-tarjeta'
                        }
                    }, [
                        createElement('div', {
                            attrs: { class: 'form-block w-form' }

                        }, [
                            createElement('div', {
                                attrs: { id: 'email-form', class: 'form' }

                            }, [
                                createElement('div', {
                                    attrs: { class: 'w-layout-grid grid-busqueda' }

                                }, [
                                    createElement('div', {
                                        attrs: {
                                            id: 'w-node-b6c4182a-16c4-2048-e3ef-a33861956377-780e62be', class: 'contenedor-buscar'
                                        }
                                    }, [
                                        //Txt para filtrar
                                        createElement('input', {
                                            attrs: {
                                                class: 'text-field w-input', id: 'name-4', type: 'text'

                                            }, domProps: {
                                                value: self.numeroActivo
                                            },
                                            on: {
                                                input: function (event) {
                                                    self.numeroActivo = event.target.value;
                                                }
                                            }

                                        }),
                                        //botón de busqueda
                                        createElement('a', {
                                            attrs: {
                                                class: 'contenedor-icono w-inline-block', id: 'busqueda'}
                                            ,
                                            on: {
                                                click: e => {
                                                    if (self.Seleccion == self.ValorAct) {
                                                        this.ObtenerActivoPorNumActivo();
                                                    } else if (self.Seleccion == self.ValorPlac) {
                                                        this.ObtenerActivoPorNumPlaca();
                                                    } else if (self.Seleccion == self.ValorDesc) {

                                                        this.ObtenerActivoPorDescripcion();
                                                    } else {
                                                        alertify.error(this.listaidiomaActualizaAct.Selectmsj);
                                                    }
                                                }
                                            }

                                        }, [
                                            createElement('img', {
                                                attrs: { src: '../images/icono_buscar_acces-o-01.svg' }
                                            })

                                        ])

                                    ]),
                                    //Creacion del select 

                                    createElement('Select', {
                                        attrs: { id: 'field-4', class: 'select-field w-node-_735fa451-b343-8bf7-805a-2ab83ed51584-780e62be w-select' },
                                        
                                        domProps: { value: self.Seleccion },
                                        on: {
                                            input: function (event) {
                                                self.Seleccion = event.target.value
                                            }
                                        }

                                    }, [
                                            obteneropcionesfiltro()
                                        ]),
                                        //Botón de más
                                        createElement('div', {
                                            attrs: {
                                                id: 'w-node-_45f0aee6-1bf7-389b-aa06-dbcdafd20bcd-731f63ba',
                                                class: 'contenedor-botones carga-descarga'
                                            }

                                        }, [createElement('a', {
                                            attrs: {
                                                class: 'link-block-boton dere w-inline-block',
                                                href: '../RegistroActivos/RegistroActivos.aspx'
                                            }
                                        }, [
                                            createElement('img', {
                                                attrs: {
                                                    src: '../images/icono_mas_activeID.svg'
                                                }
                                            }, [

                                            ])

                                        ])
                                        ]),
                                        //redireccionamiento del boton
                                        createElement('div', {
                                            attrs: { id: 'w-node-_45f0aee6-1bf7-389b-aa06-dbcdafd20bcd-731f63ba', class: 'contenedor-botones carga-descarga' }
                                        }, [
                                            createElement('a', {
                                                attrs: { class: 'link-block-boton dere w-inline-block', href: '../RegistroActivos/RegistroActivos.aspx' },
                                                on: {
                                                    click: e => {

                                                        sessionStorage.removeItem('DatosActivoEditar');
                                                    }
                                                }
                                            }, [
                                                createElement('img', {
                                                    attrs: { src: '../images/icono_mas_activeID.svg' }
                                                })
                                            ]),
                                            //createElement('a', {
                                            //    attrs: { class: 'link-block-boton w-inline-block' }
                                            //}, [
                                            //    createElement('img', {
                                            //        attrs: { src: '../images/clock.svg' }
                                            //    })
                                            //])
                                        ]),


                                 ])

                            ])

                        ])

                    ])
                ])


            ])
        ],

    )},
    mounted: function () {
        var logueado = JSON.parse(sessionStorage.getItem('DUser'));
        this.idPerfilActive = "" + logueado[0].IdPerfilActive;
        this.idPerfilEmpresa = "" + logueado[0].IdPerfilEmpresa;
        this.ObtenerIdioma();
    },
    methods: {
        ObtenerIdioma: function () {
            var idiActualiza = "ES"
            if (localStorage.getItem("idiomaApp") != undefined) {
                idiActualiza = localStorage.getItem("idiomaApp");
            }
            this.EstablecerIdiomaActulizaActivo(idiActualiza);
        },
        EstablecerIdiomaActulizaActivo: function (idioma) {
            var self = this
            $.post(urlIdioma, {
                IdiomaActualizaActivos: idioma,
            }, function (data, error) {
                self.listaidiomaActualizaAct = JSON.parse(data);
            });
        },
        ObtenerActivoPorNumActivo: function () {
            var self = this
            $.post(urlActivos, {
                option: 'ObtenerActivoPorNumActivo',
                NumeroActivo: self.numeroActivo,
                IdPerfilEmpresa: self.idPerfilEmpresa
            }, function (respuesta, error) {
                var resp = JSON.parse(respuesta);
                    self.listaActivos = [];
                    for (let i = 0; i < resp.length; i += 1) {
                        self.listaActivos.push([resp[i].IdActivo, resp[i].NumeroActivo, resp[i].PlacaActivo, resp[i].Descripcion,
                            resp[i].NombreEstado, resp[i].NombreUbicacion]);
                    }
                    if (resp.length == 0) {
                        alertify.error(self.listaidiomaActualizaAct.IngrErrNumActivo);
                        self.numeroActivo = '';
                    }
                  
            });
           
            
        },
        ObtenerActivoPorDescripcion: function () {
            var self = this
            $.post(urlActivos, {
                option: 'ObtenerActivoPorDescripcion',
                DescripcionActivo: self.numeroActivo,
                IdPerfilEmpresa: self.idPerfilEmpresa
            }, function (respuesta, error) {
                var resp = JSON.parse(respuesta);
                self.listaActivos = [];
                for (let i = 0; i < resp.length; i += 1) {
                    self.listaActivos.push([resp[i].IdActivo, resp[i].NumeroActivo, resp[i].PlacaActivo, resp[i].Descripcion,
                    resp[i].NombreEstado, resp[i].NombreUbicacion]);
                    }
                    if (resp.length == 0) {
                        alertify.error(self.listaidiomaActualizaAct.IngrErrDescripcion);
                        self.numeroActivo = '';
                    }

            });

        },
        ObtenerActivoPorNumPlaca: function () {
            var self = this
            $.post(urlActivos, {
                option: 'ObtenerActivoPorNumPlaca',

                PlacaActivo: self.numeroActivo,
                IdPerfilEmpresa: self.idPerfilEmpresa
            }, function (respuesta, error) {
                var resp = JSON.parse(respuesta);
                self.listaActivos = [];
                for (let i = 0; i < resp.length; i += 1) {
                    self.listaActivos.push([resp[i].IdActivo, resp[i].NumeroActivo, resp[i].PlacaActivo, resp[i].Descripcion,
                    resp[i].NombreEstado, resp[i].NombreUbicacion]);
                }
                    if (resp.length == 0) {
                        alertify.error(self.listaidiomaActualizaAct.IngrErrNumPlaca);
                        self.numeroActivo = '';
                    }
            });

        },
        ObtenerHeaders: function () {
            return JSON.parse('{"headersInfo":["' + this.listaidiomaActualizaAct.NumActivo + '","' + this.listaidiomaActualizaAct.PlacaActivo + '","'
                + this.listaidiomaActualizaAct.Descripcion + '","' + this.listaidiomaActualizaAct.IdEstadoActivo + '","'  + this.listaidiomaActualizaAct.IdUbicacionA +  '"]}')
        },
        Editar: function (info) {
            sessionStorage.setItem('DatosActivoEditar', info);
            window.location.href = "../RegistroActivos/RegistroActivos.aspx";

        },
        ObtenerBotones: function () {
            let botones = []
            botones.push([this.Editar, '../images/editar.svg']);           
            return botones;
        },
        ObtenerActivoPorNumActivoCompleto: function () {
            var self = this
            $.post(urlActivos, {
                option: 'ObtenerActivoPorNumActivoCompleto',
                NumeroActivo: self.numeroActivo,
                IdPerfilEmpresa: self.idPerfilEmpresa
            }, function (respuesta, error) {
                var resp = JSON.parse(respuesta);
                self.listaActivos = [];
                for (let i = 0; i < resp.length; i += 1) {
                    self.listaActivos.push([resp[i].IdActivo, resp[i].NumeroActivo, resp[i].PlacaActivo, resp[i].Observacion,
                        resp[i].Marca, resp[i].Modelo, resp[i].NombreCategoria,resp[i].NombreEstado, resp[i].NombreUbicacion, resp[i].NumeroSerie,
                        resp[i].DescripcionCorta,resp[i].DescripcionCategoria, resp[i].DescripcionEstado, resp[i].NumeroFactura, resp[i].FechaCompra,
                        resp[i].CostoActivo]);
                    
                }
                if (resp.length == 0) {
                    alertify.error(self.listaidiomaActualizaAct.IngrErrNumActivo);
                    self.numeroActivo = '';
                }

            });


        },

      
    }

})
const actualizaactivo = new Vue({
    el: '#actualizaactivos',
    data: {

    }
})

