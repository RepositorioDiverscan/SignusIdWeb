var urlEncabezado = '../ActivosNoPistoleados/ActivosNoPistoleadosAjax.aspx'
var urlIdioma = '../ActivosNoPistoleados/EstablecerIdiomaActivosNoPistoleados.aspx'
var urlIdiomaActivos = '../ActivosNoPistoleados/Detalle/Idioma/EstablecerIdiomaDetalle.aspx'
Vue.component('activos', {
    props: {
    },
    data() {
        return {

            listaIdiomaToma: this.ObtenerIdioma(),
            listaIdiomaActivo: this.ObtenerIdiomaActivos(),
            listaTomasEncabezado: [],
            listaActivos: [],
            IdPerfilActive: '',
            nombredetoma: '',
            descripcion: '',
            fecha: '',
            fechaInicio: '',
            fechaFinal: '',

        }
    },
    render: function (createElement) {
        var self = this
        return createElement('div', {
            attrs: { class: 'container-2 w-container' }
        }, [
            createElement('div', {
                attrs: { class: 'w-layout-grid grid-main' }
            }, [
                createElement('div', {
                    attrs: { id: 'w-node-_1881bb3d-bb04-a65f-0013-ab2c81d3403c-731f63ba', class: 'div-banner-extremo' }
                }),
                createElement('div', {
                    attrs: {
                        id: 'w-node-_1881bb3d-bb04-a65f-0013-ab2c81d3403d-731f63ba', class: 'div-banner-extremo'
                    }
                }),
                createElement('div', {
                    attrs: { id: 'w-node-_1881bb3d-bb04-a65f-0013-ab2c81d3403e-731f63ba' }
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
                            domProps: { innerText: this.listaIdiomaToma.Titulo }
                        })
                    ])
                ]),
              
                //Tabla
                createElement('div', {
                    attrs: { class: 'div-tarjeta', id: 'w-node-_1881bb3d-bb04-a65f-0013-ab2c81d34079-731f63ba' }
                }, [

                    createElement('TableBotones', {
                        attrs: {
                            headers: this.ObtenerHeaders(),
                            datatable: this.listaTomasEncabezado,
                            idDiv: 'w-node-_1881bb3d-bb04-a65f-0013-ab2c81d34079-731f63ba',
                            buttons: this.ObtenerBotones(),
                            tableName: 'TablaTomasEncabezado'
                        }
                        , domProps: {

                        }
                    }),

                ]),

                //Desde
                createElement('div', {
                    attrs: {
                        id: 'w-node-_1881bb3d-bb04-a65f-0013-ab2c81d34099-731f63ba', class: 'div-tarjeta'
                    }
                }, [
                    createElement('div', {
                        attrs: { class: 'form-block w-form' }
                    }, [
                        createElement('div', {
                            attrs: { class: 'w-layout-grid grid-busqueda' }
                        }, [
                            createElement('div', {
                                attrs: { id: 'w-node-_11301461-cbc5-5669-a497-35cca5203f9f-731f63ba', class: 'form-line' }
                            }, [
                                createElement('label', {
                                    attrs: { class: 'field-label' },
                                    domProps: { innerText: this.listaIdiomaToma.FechaInicial }
                                }),
                                createElement('div', {
                                    attrs: { class: 'div-fecha' }
                                }, [
                                    createElement('input', {
                                        attrs: { class: 'text-field w-input', id: 'fechaDesde', type: 'date' },
                                        domProps: {
                                            value: self.fechaInicio
                                        },
                                        on: {
                                            input: function (event) {
                                                self.fechaInicio = event.target.value;
                                            }
                                        }
                                    })
                                ])
                            ]),

                            //Hasta
                            createElement('div', {
                                attrs: { id: 'w-node-bf5fa935-3dfb-9a2f-1a7d-9dc69d0fcb8a-731f63ba', class: 'form-line' }
                            }, [
                                createElement('label', {
                                    attrs: { class: 'field-label' },
                                    domProps: { innerText: this.listaIdiomaToma.FechaFinal }
                                }),
                                createElement('div', {
                                    attrs: { class: 'div-fecha' }
                                }, [
                                    createElement('input', {
                                        attrs: { class: 'text-field w-input', id: 'fechaHasta', type: 'date' },
                                        domProps: {
                                            value: self.fechaFinal
                                        },
                                        on: {
                                            input: function (event) {
                                                self.fechaFinal = event.target.value;

                                            }
                                        }

                                    })
                                ])
                            ]),


                           


                            createElement('a', {
                                attrs: { class: 'contenedor-icono w-inline-block', id: 'w-node-_738cb82b-46f1-6757-96b0-ee5c4a5b81a2-731f63ba' },
                                on: {
                                    click: e => {
                                        this.ObtenerDatos(this.fechaInicio, this.fechaFinal);

                                    }
                                }

                            }, [
                                createElement('img', {
                                    attrs: { src: '../images/icono_buscar_acces-o-01.svg' }
                                }),
                            ])

                        ])

                    ]),


                ]),

                createElement('div', {
                    attrs: { class: 'div-tarjeta', id: 'w-node-_57fabf73-cd7d-6e66-6d21-ef26647b1b2b-731f63ba' }
                }, [

                    createElement('TableBotones', {
                        attrs: {
                            headers: this.ObtenerheadersActivos(),
                            datatable: this.listaActivos,
                            idDiv: 'w-node-_57fabf73-cd7d-6e66-6d21-ef26647b1b2b-731f63ba',
                            buttons: this.ObtenerBotonesActivos(),
                            tableName: 'TablaTomasActivos'

                        }
                        , domProps: {

                        }
                    })


                ]),

            ]),
        ])



    },

    mounted: function () {
        var logueado = JSON.parse(sessionStorage.getItem('DUser'));
        this.idPerfilActive = "" + logueado[0].IdPerfilActive;
        this.EstablecerFechasHoy();
        this.ObtenerIdioma();
        this.ObtenerIdiomaActivos();


    },
    methods: {
        EstablecerFechasHoy: function () {
            var tiempoTranscurrido = Date.now();
            var actual = new Date(tiempoTranscurrido);
            var mes = actual.getMonth() + 1;
            if (mes < 10) {
                mes = '0' + mes;
            }
            var dia = actual.getDate().toString();
            if (dia < 10) {
                dia = '0' + dia;
            }
            var anno = actual.getFullYear().toString();
            this.fechaInicio = anno + "-" + mes + "-" + dia;
            this.fechaFinal = anno + "-" + mes + "-" + dia;

        },
        ObtenerHeaders: function () {

            return JSON.parse('{"headersInfo":["' + this.listaIdiomaToma.Nombre + '","' +
                this.listaIdiomaToma.Descripcion + '","' + this.listaIdiomaToma.FechaInicial + '","'
                + this.listaIdiomaToma.FechaFinal + '","' + this.listaIdiomaToma.Categoria + '","' +
                this.listaIdiomaToma.CantidadActivos + '","' +
                this.listaIdiomaToma.NombreUsuario + '"]}')
        },

        ObtenerDatos: function (fechaInicial, fechaFinal) {
            var self = this
            if (fechaInicial <= fechaFinal) {
                $.post(urlEncabezado, {
                    option: 'ConsultaTomaFisica',
                    idPerfilActive: self.idPerfilActive,
                    FechaInicial: fechaInicial,
                    FechaFinal: fechaFinal
                }, function (respuesta, error) {
                    var resp = JSON.parse(respuesta);
                    self.listaTomasEncabezado = [];
                    for (let i = 0; i < resp.length; i += 1) {
                        var dataFechaInicial = resp[i].FechaInicial.split('T');
                        var dataFechaFinal = resp[i].FechaFinal.split('T');
                        self.listaTomasEncabezado.push([resp[i].IdTomaFisica, resp[i].Nombre, resp[i].Descripcion,
                        dataFechaInicial[0], dataFechaFinal[0], resp[i].NombreCategoria, resp[i].CantidadActivos, resp[i].NombreUsuario]);
                    }
                    if (resp.length == 0) {
                        alertify.error(self.listaIdiomaToma.ErrorRangoFechas);
                    }
                });
            } else {
                alertify.error(self.listaIdiomaToma.ErrorRangoF);
                self.listaTomasEncabezado = [];


            }

        },

        //obtener idioma primer tabla
        ObtenerIdioma: function () {
            var idiomaToma = "ES"
            if (localStorage.getItem("idiomaApp") != undefined) {
                idiomaToma = localStorage.getItem("idiomaApp");
            }
            this.EstablecerIdiomaToma(idiomaToma);
        },
        EstablecerIdiomaToma: function (idioma) {
            var self = this
            $.post(urlIdioma, {
                IdiomaTomaFisica: idioma,
            }, function (data, error) {
                self.listaIdiomaToma = JSON.parse(data);
            })
        },
        //obtener idioma segunda tabla
        ObtenerIdiomaActivos: function () {
            var idiomaToma = "ES"
            if (localStorage.getItem("idiomaApp") != undefined) {
                idiomaToma = localStorage.getItem("idiomaApp");
            }
            this.EstablecerIdiomaTomaActivos(idiomaToma);
        },
        EstablecerIdiomaTomaActivos: function (idioma) {
            var self = this
            $.post(urlIdiomaActivos, {
                listaIdiomaActivo: idioma,
            }, function (data, error) {
                self.listaIdiomaActivo = JSON.parse(data);
            })
        },
        ObtenerBotones: function () {
            let botones = []

            botones.push([this.ObtenerActivos, '../images/ver.svg']);
            return botones;
        },
        ObtenerBotonesActivos: function () {
            let botones = []
        
            botones.push([this.PopObservacion, '../images/Icon_-_Check-01.svg']);
            return botones;
        },
        ObtenerActivos: function (info) {
            let idToma = info[0]
            var self = this;
            sessionStorage.setItem('idToma', idToma);
            $.post(urlEncabezado, {
                option: 'ConsultaActivosNoPistoleados',
                IdTomaFisica: idToma
            }, function (respuesta, error) {
                var resp = JSON.parse(respuesta);
                self.listaActivos = [];
                for (let i = 0; i < resp.length; i += 1) {
                    self.listaActivos.push([resp[i].IdActivo, resp[i].NumeroActivo, resp[i].PlacaActivo,
                    resp[i].DescripcionActivo, resp[i].ObservacionActivo])
                }

            })
        },
        ObtenerheadersActivos: function () {

            return JSON.parse('{"headersInfo":["' + this.listaIdiomaActivo.NumActivo + '","' +
                this.listaIdiomaActivo.PlacaActivo + '","' + this.listaIdiomaActivo.DescripActivo + '","'
                + this.listaIdiomaActivo.ObservActivo + '"]}')


        },


    

        PopObservacion: function (info) {
            let IdActivo = info[0]
            let observacion = info[4]
         
            var self = this

            alertify.prompt(self.listaIdiomaToma.Titulopop, self.listaIdiomaActivo.ObservActivo, observacion
                , function (evt, value) {
                 
                    self.ActualizarObservacion(IdActivo, value);
                }
                , function () { alertify.error('Cancel') });
            

        },

        

        ActualizarObservacion: function (IdActivo, observacion) {
       
            this.idPerfilActive = "" + logueado[0].IdPerfilActive;
            let idToma = sessionStorage.getItem('idToma');
            var self = this;
            if (this.value == '-1') {
                alertify.success(this.listaIdiomaActivo.ObservacionValidacion);
                return
            }
            var self = this
            $.post(urlEncabezado, {
                option: 'ActualizarObservacion',
                IdTomaFisica:idToma,
                IdPerfilActive: self.idPerfilActive,
                IdActivo: IdActivo,
                Observacion: observacion,
            }, function (respuesta, error) {
                    if (respuesta == "Observación ingresada con exito") {

                        alertify.success(self.listaIdiomaActivo.InsertarCorrecto);


                        sessionStorage.removeItem("idtoma");

                    } else if (!respuesta == "Observación ingresada con exito"){
                        alertify.error(self.listaIdiomaActivo.InsertarError);
                    }

                    if (respuesta =="Observación actualizada con éxito") {

                        alertify.success(self.listaIdiomaActivo.ActualizaCorrecto);

                 
                    sessionStorage.removeItem("idtoma");

                    } else if (!respuesta == "Observación actualizada con éxito"){
                        alertify.error(self.listaIdiomaActivo.ActualizaError);
                    }

                    
            })
        },

       




    }
})

const activos = new Vue({
    el: '#activos',
    data: {

    }
})


