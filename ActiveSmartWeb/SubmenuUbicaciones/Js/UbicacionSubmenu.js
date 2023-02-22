var urlIdioma = 'Idioma/IdiomaSubmenuU.aspx'
Vue.component('submenuubicacion', {
    props: {

    },
    data() {
        return {
            listaIdiomaSubmenuU : this.ObtenerIdioma()
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
                        attrs: { class: 'div-banner-extremo', id: 'w-node-_0b1e8e1b-a500-7347-f3df-1ec77fc9072f-973c21a0' }
                    }),
                    createElement('div', {
                        attrs: { class: 'div-banner-extremo', id: 'w-node-_0b1e8e1b-a500-7347-f3df-1ec77fc90730-973c21a0' }
                    }),
                    createElement('div', {
                        attrs: { id: 'w-node-_0b1e8e1b-a500-7347-f3df-1ec77fc90731-973c21a0' }
                    }, [
                        createElement('div', {
                            attrs: { class: 'w-layout-grid grid-container-title' }

                        }, [
                            createElement('a', {
                                attrs: { class: 'link-block-back w-inline-block', href: '../Menu/MenuPrincipal.aspx' }
                            }, [
                                createElement('img', {
                                    attrs: { src: '../images/Back-arrow.svg', class: 'back' }
                                })
                            ]),
                            createElement('h1', {
                                attrs: { class: 'titulo-principal' },
                                domProps: { innerText: this.listaIdiomaSubmenuU.Titulo }
                            })
                        ])
                    ]),
                    createElement('div', {
                        attrs: { class: 'div-tarjeta', id: 'w-node-_0b1e8e1b-a500-7347-f3df-1ec77fc90737-973c21a0' }

                    }, [
                        createElement('div', {
                            attrs: { class: 'contenedor-general-2' }
                        }, [
                            createElement('div', {
                                attrs: { class: 'div-block-menu' }
                            }, [
                                createElement('div', {
                                    attrs: { class: 'contenedor-admin' }
                                }, [
                                    createElement('a', {
                                        attrs: {
                                            href: '../Ubicaciones/Ubicaciona.aspx',
                                            class: 'contenedor-icono-admin w-inline-block'
                                        }
                                    }, [
                                        createElement('div', {
                                            attrs: { class: 'a' }
                                        })
                                    ]),
                                    createElement('div', {
                                        attrs: { class: 'titulo-icono' },
                                        domProps: { innerText: this.listaIdiomaSubmenuU.UbicacionA }
                                    })
                                ]),
                                createElement('div', {
                                    attrs: { class: 'contenedor-admin'}
                                }, [
                                        createElement('a', {
                                            attrs: { class: 'contenedor-icono-admin w-inline-block none'}

                                        }, [
                                                createElement('div', {
                                                    attrs: { class: 'b'}
                                                })
                                        ]),

                                        createElement('div', {
                                            attrs: { class: 'titulo-icono none' },
                                            domProps: { innerText: this.listaIdiomaSubmenuU.UbicacionB }
                                        })

                                ]),
                                    createElement('div', {
                                        attrs: { class:'contenedor-admin'}
                                    }, [
                                            createElement('a', {
                                                attrs: { class:'contenedor-icono-admin w-inline-block none'}
                                            }, [
                                                    createElement('div', {
                                                        attrs: {class:'c'}
                                                    })
                                            ]),
                                            createElement('div', {
                                                attrs: { class: 'titulo-icono none' },
                                                domProps: { innerText: this.listaIdiomaSubmenuU.UbicacionC }
                                            })


                                    ]),
                                    createElement('div', {
                                        attrs: { class:'contenedor-admin'}
                                    }, [
                                            createElement('a', {
                                                attrs: { class:'contenedor-icono-admin w-inline-block none'}
                                            }, [
                                                    createElement('div', {
                                                        attrs: {class:'d'}
                                                    })

                                            ]),
                                            createElement('div', {
                                                attrs: { class: 'titulo-icono none' },
                                                domProps: { innerText: this.listaIdiomaSubmenuU.UbicacionD }
                                            })

                                    ])
                            ])

                        ])

                    ]),
                        createElement('div', {
                            attrs: { class: 'div-tarjeta', id:'w-node-e5672c72-0dfc-7bc9-5a53-1737af2e1497-973c21a0'}
                        }, [
                                createElement('div', {
                                    attrs: { class:'div-block-170'}
                                }, [
                                        createElement('div', {
                                            attrs: { class: 'text-block-17' },
                                            domProps: { innerText: this.listaIdiomaSubmenuU.MsjTienda }
                                        }),
                                        createElement('a', {
                                            attrs: { class: 'boton call2action w-button' },
                                            domProps: { innerText: this.listaIdiomaSubmenuU.MsjbtnTienda }
                                        })
                                ])

                        ])
                ])

            ])

        ])
    },
    mounted: function () {
        this.ObtenerIdioma();
    },
    methods: {
        EstablecerIdioma: function (idioma) {
            var self = this;
            $.post(urlIdioma, {
                IdiomaSubmenuUbi: idioma,
            }, function (data, error) {
                    self.listaIdiomaSubmenuU = JSON.parse(data);

            })
        },
        ObtenerIdioma: function () {
            var IdiomaSubmenuUbi = "ES"
            if (localStorage.getItem("idiomaApp") != undefined) {
                IdiomaSubmenuUbi = localStorage.getItem("idiomaApp");
            }
            this.EstablecerIdioma(IdiomaSubmenuUbi);
        }
    }

})

const submenuubicacion = new Vue({
    el: '#submenuUbicaciones',
    data: {

    }
})