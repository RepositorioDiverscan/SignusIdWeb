var urlIdioma = 'Idioma/IdiomaSubmenuReportes.aspx'
Vue.component('submenureporte', {
    props: {

    },
    data() {
        return {
            listaIdiomaSubmenu : this.ObtenerIdioma(),
        }
    },
    render: function (createElement) {
        var self = this
        return createElement('div', {
            attrs: { class: 'main' }
        }, [
            createElement('div', {
                attrs: { class: 'section wf-section' }
            }, [
                createElement('div', {
                    attrs: { class: 'container-2 w-container' }
                }, [
                    createElement('div', {
                        attrs: { class: 'w-layout-grid grid-main' }
                    }, [
                        createElement('div', {
                            attrs: { class: 'div-banner-extremo', id:'w-node-_660ae528-b498-da4b-9798-6929642e7299-377288bf' }
                        }),
                            createElement('div', {
                                
                                attrs: { class: 'div-banner-extremo', id: 'w-node-_660ae528-b498-da4b-9798-6929642e729a-377288bf' }

                            }),
                            createElement('div', {
                                attrs: { id: 'w-node-_660ae528-b498-da4b-9798-6929642e729b-377288bf' }

                            },
                                [
                                    createElement('div', {
                                        attrs: { class: 'w-layout-grid grid-container-title', style: 'padding-top:7px; padding-bottom:6px'}
                                    },[
                                            createElement('a', {
                                                attrs: { class: 'link-block-back w-inline-block', href: '#', onclick: 'window.history.back()' }
                                            },    [
                                                        createElement('img', {
                                                            attrs: { src: '/images/Back-arrow.svg', class: 'back', height: '26', width: '26' }
                                                        })
                                            ]),

                                            createElement('h1', {
                                                attrs: { class: 'titulo-principal', id:'w-node-_9be28721-5dbb-5f12-6325-d0dcd6cba1e6-ffdc8228' },
                                                domProps: { innerText: this.listaIdiomaSubmenu.Titulo}
                                            }),

                                            createElement('div', {
                                                attrs: { class: 'dropdown-detalles-ai w-dropdown', id: 'w-node-_01c345db-44dd-5950-8797-fc0e77f5b71f-731f63ba' }
                                            }, [
                                                createElement('div', {
                                                    attrs: { class: 'toggle-detalles-ai w-dropdown-toggle', style: 'padding: 0px' }
                                                    }, [
                                                        createElement('img', {
                                                            attrs: { src: '../images/info2.svg', class: 'img-detalles-ai' }
                                                        })
                                                    ]),

                                                    createElement('nav', {
                                                        attrs: { class: 'detalles-descrp-ai w-dropdown-list'}
                                                    }, [
                                                            createElement('p', {
                                                                attrs: { class: 'p-desc-detalles-ai' },
                                                                domProps: { innerText: this.listaIdiomaSubmenu.Msj1 + ' ' + this.listaIdiomaSubmenu.Msj2 }
                                                            })
                                                        ])
                                                ])
                                            
                                      ]),



                                    //createElement('div', {
                                    //    attrs: { class: 'w-layout-grid grid-container-title' }
                                    //},
                                    //    [
                                    //        createElement('a', {
                                    //            attrs: { class: 'link-block-back w-inline-block', href: '#', onclick: 'window.history.back()' }
                                    //        },      [
                                    //            createElement('img', {
                                    //                attrs: { src: '/images/Back-arrow.svg', class: 'back', height: '26', width: '15' }
                                    //                    })
                                    //                ]),
                                    //        createElement('h1', {
                                    //            attrs: { class: 'titulo-principal' },
                                    //            domProps: { innerText: 'Reportes' }
                                    //        }),
                                    //        createElement('div', {
                                    //            attrs: { class: 'dropdown-detalles-ai w-dropdown'}
                                    //        },  [
                                    //                createElement('div', {
                                    //                    attrs: { class: 'toggle-detalles-ai ubicaiones w-dropdown-toggle' }
                                    //                }, [
                                    //                    createElement('img', {
                                    //                        attrs: { src: '/images/info2.svg', class: 'img-detalles-ai' }
                                    //                        })
                                    //                    ]),
                                    //                createElement('nav', {
                                    //                    attrs: { class: 'detalles-descrp-ai w-dropdown-list' }
                                    //                }, [
                                    //                    createElement('p',{
                                    //                        attrs: { class: 'p-desc-detalles-ai' },
                                    //                        domProps: { innerText: 'En esta página se puede: crear, ver, gestionar y aprobar Tomas Físicas.' }
                                    //                    })
                                    //                   ]),
                                    //            ]),
                                    //    ]),

                               // createElement('div', {
                               //     attrs: { class: 'w-layout-grid grid-container-title' }
                               //     }, [
                               // createElement('a', {
                               //     attrs: { class: 'link-block-back w-inline-block', href: '../Menu/MenuPrincipal.aspx' }
                               // }, [
                               //     createElement('img', {
                               //         attrs: { src: '../images/Back-arrow.svg', class: 'back' }
                               //     })
                               // ]),
                               // createElement('h1', {
                               //     attrs: { class: 'titulo-principal' },
                               //     domProps: { innerText: this.listaIdiomaSubmenu.Titulo }
                               // }),
                               //])
                            ]),
                        //Fin del titulo
                        createElement('div', {
                            attrs: { id: 'w-node-_660ae528-b498-da4b-9798-6929642e72a1-377288bf', class:'div-tarjeta' }
                        }, [
                            createElement('div', {
                                attrs: { class: 'contenedor-general-2' }
                            }, [
                                    createElement('div', {
                                        attrs: { class: 'div-block-menu' }
                                    }, [
                                        //Contenedor de Reporte de activos
                                         createElement('div', {
                                             attrs: { class:'contenedor-admin'}
                                         }, [
                                              createElement('a', {
                                                  attrs: { class: 'contenedor-icono-admin w-inline-block', href:"../ReporteActivos/ActivosReporte.aspx"}

                                              }, [
                                                   createElement('img', {
                                                      attrs: { src: '../images/iconos_admin_activeID_Mesa-de-trabajo-1-copia-7.svg',width:'50',height:'50', class:'icono-smart-admin'}
                                                  })
                                              ]),
                                                 createElement('div', {
                                                     attrs: { class: 'titulo-icono' },
                                                     domProps: { innerText: this.listaIdiomaSubmenu.ReporteActivos }
                                                 })
                                         ]),
                                        //contenedor de reporte de Inventario
                                            createElement('div', {
                                                attrs: { class:'contenedor-admin'}
                                            }, [
                                                    createElement('a', {
                                                        attrs: { class: 'contenedor-icono-admin w-inline-block', href:"../InventariosReporte/ReporteInventario.aspx"}
                                                    }, [
                                                        createElement('img', {
                                                            attrs: { src: '../images/iconos_admin_activeID_Mesa-de-trabajo-1-copia-8.svg', width: '50', height: '50', class:'icono-smart-admin'}
                                                         })
                                                    ]),
                                                    createElement('div', {
                                                        attrs: { class: 'titulo-icono' },
                                                        domProps: { innerText: this.listaIdiomaSubmenu.ReporteInventario }
                                                    })
                                            ]),    

                                        //reporte sin nombre 1
                                            createElement('div', {
                                                attrs: { class: 'contenedor-admin' }
                                            }, [
                                                createElement('div', {
                                                    attrs: { class: 'contenedor-icono-admin none'}
                                                }, [
                                                    createElement('img', {
                                                        attrs: { src: '../images/iconos_admin_activeID_Mesa-de-trabajo-1-copia-4.svg', width: '50', height: '50', class: 'icono-smart-admin' }
                                                    })
                                                ]),
                                                createElement('div', {
                                                    attrs: { class: 'titulo-icono' },
                                                    domProps: { innerText: this.listaIdiomaSubmenu.ReporteUbicacion }
                                                })
                                            ]),  
                                            //reporte sin nombre 2
                                            createElement('div', {
                                                attrs: { class: 'contenedor-admin' }
                                            }, [
                                                createElement('div', {
                                                    attrs: { class: 'contenedor-icono-admin none' }
                                                }, [
                                                    createElement('img', {
                                                        attrs: { src: '../images/iconos_admin_activeID_Mesa-de-trabajo-1-copia-4.svg', width: '50', height: '50', class: 'icono-smart-admin' }
                                                    })
                                                ]),
                                                createElement('div', {
                                                    attrs: { class: 'titulo-icono' },
                                                    domProps: { innerText: this.listaIdiomaSubmenu.ReporteUsuario }
                                                })
                                            ]), 
                                            //reporte sin nombre 3
                                            createElement('div', {
                                                attrs: { class: 'contenedor-admin' }
                                            }, [
                                                createElement('div', {
                                                    attrs: { class: 'contenedor-icono-admin none' }
                                                }, [
                                                    createElement('img', {
                                                        attrs: { src: '../images/iconos_admin_activeID_Mesa-de-trabajo-1-copia-4.svg', width: '50', height: '50',class: 'icono-smart-admin' }
                                                    })
                                                ]),
                                                createElement('div', {
                                                    attrs: { class: 'titulo-icono' },
                                                    domProps: { innerText: this.listaIdiomaSubmenu.ReporteCategoria }
                                                })
                                            ]), 
                                    ])
                                
                            ])
                        ]),
                            createElement('div', {
                                attrs: { class: 'div-tarjeta', id:'w-node-_660ae528-b498-da4b-9798-6929642e72b8-377288bf'}
                            }, [
                                    createElement('div', {
                                        attrs: { class:'div-block-170'}
                                    }, [
                                            createElement('div', {
                                                attrs: { class: 'text-block-17' },
                                                domProps: { innerText: this.listaIdiomaSubmenu.MsjTienda }

                                            }),
                                            createElement('a', {
                                                attrs: { class: 'boton call2action w-button', href:'../Tienda/Tienda.aspx'},
                                                domProps: { innerText: this.listaIdiomaSubmenu.MsjbtnTienda }
                                            })
                                    ])
                            ])
                   ])
               ])
           ])
        ])
    },
    mounted: function () {
        this.ValidarSesion();
        this.ObtenerIdioma();
    },
    methods: {
        EstablecerIdioma: function (idioma) {
            var self = this
            $.post(urlIdioma, {
                IdiomaSubmenu: idioma,
            }, function (data, error) {
                    self.listaIdiomaSubmenu = JSON.parse(data);
            })
        },
        ObtenerIdioma: function () {
            var idiomaSubmenu = "ES"
            if (localStorage.getItem("idiomaApp") != undefined) {
                idiomaSubmenu = localStorage.getItem("idiomaApp");
            }
            this.EstablecerIdioma(idiomaSubmenu);
        },
        ValidarSesion: function () {

            var dConfig = JSON.parse(sessionStorage.getItem('DConfig'));

            if (dConfig == null || dConfig.CofReportes == false) {
                window.location.href = window.location.origin + "/AccesoDenegado.aspx";
            }
        },
    }

})

const submenureporte = new Vue({
    el: '#submenuReportes',
    data: {

    }

})