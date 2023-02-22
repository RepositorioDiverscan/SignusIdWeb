var urlIdioma = 'Idioma/IdiomaReporteInventario.aspx'
var urlDetalleToma = '../TomaFisica/DetalleToma/DetalleTomaFisica.aspx'
var urlReporte = '/ReporteInventario/ReporteInventarioAjax.aspx'

var jsPDF = 'jspdf'

Vue.component('reporte', {

    props: {

    },
    data() {
        return {
            listaIdiomaReporte: this.ObtenerIdioma(),
            listaReporte: [],
            listaActivos: [],
            idPerfilActive: '',
            fechaInicio: '',
            fechaInicial: '',
            fechaFin: '',
            nombre: '',
            descripcion: '',
            categoria: '',
            cantidadActivos: '',
            nombreUsuario: '',
            idTomaFisica: '',
            //src: '', 
            //component: jsPDF

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
                            attrs: { class: 'link-block-back w-inline-block', href: "*" },
                            on: {
                                click: "window.history.back()"
                            }
                        }, [
                            createElement('img', {
                                attrs: { src: '../images/Back-arrow.svg', class: 'back' }
                            })
                        ]),
                        createElement('h1', {
                            attrs: { class: 'titulo-principal' },
                            domProps: { innerText: this.listaIdiomaReporte.Titulo }
                        })
                    ])
                ]),

                //Fecha Inicio
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
                                    domProps: { innerText: this.listaIdiomaReporte.FechaInicial }
                                }),
                                createElement('div', {
                                    attrs: { class: 'div-fecha' }
                                }, [
                                    createElement('input', {
                                        attrs: { class: 'text-field w-input', id: 'fechaInicial', type: 'date' },
                                        domProps: {
                                            value: self.fechaInicial
                                        },
                                        on: {
                                            input: function (event) {
                                                self.fechaInicial = event.target.value;
                                            }
                                        }
                                    })
                                ])
                            ]),

                            //Feha Final
                            createElement('div', {
                                attrs: { id: 'w-node-bf5fa935-3dfb-9a2f-1a7d-9dc69d0fcb8a-731f63ba', class: 'form-line' }
                            }, [
                                createElement('label', {
                                    attrs: { class: 'field-label' },
                                    domProps: { innerText: this.listaIdiomaReporte.FechaFinal }
                                }),
                                createElement('div', {
                                    attrs: { class: 'div-fecha' }
                                }, [
                                    createElement('input', {
                                        attrs: { class: 'text-field w-input', id: 'fechaHasta', type: 'date' },
                                        domProps: {
                                            value: self.fechaFin
                                        },
                                        on: {
                                            input: function (event) {
                                                self.fechaFin = event.target.value;

                                            }
                                        }

                                    })
                                ])
                            ]),

                            createElement('a', {
                                attrs: { class: 'contenedor-icono w-inline-block', id: 'w-node-_738cb82b-46f1-6757-96b0-ee5c4a5b81a2-731f63ba' },

                                on: {
                                    click: e => {
                                        this.ObtenerDatos(this.fechaInicial, this.fechaFin)

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
                createElement('tr', {
                    attrs: { id: 'w-node-_1881bb3d-bb04-a65f-0013-ab2c81d34079-731f63ba', class: 'div-tarjeta', }
                }, [
                    createElement('TableBotones', {
                        attrs: {
                            headers: this.ObtenerHeadersInventario(),
                            datatable: this.listaReporte,
                            idDiv: 'w-node-_1881bb3d-bb04-a65f-0013-ab2c81d34079-731f63ba',
                            buttons: this.ObtenerBotones(),
                            tableName: 'TablaTomasReporte'
                        }
                        , domProps: {

                        }
                    }),
                    createElement('TableBotones', {
                        attrs: {
                            headers: this.ObtenerheadersActivos(),
                            datatable: this.listaActivos,
                            idDiv: 'w-node-_57fabf73-cd7d-6e66-6d21-ef26647b1b2b-731f63ba',
                            buttons: [],
                            tableName: 'TablaActivos'
                        }
                        , domProps: {

                        }
                    }),

                ]),
                createElement('div', {
                    attrs: { class: 'contenedor-botones', id: 'w-node-_6ea52258-7b7f-915a-f9c9-a2ae250af096-b415ea5e' }
                }, [
                    createElement('a', {
                        attrs: { class: 'boton gris w-button' },
                        domProps: { innerText: "EXCEL" },
                        on: {
                            click: e => {
                                if (this.listaReporte == 0) {
                                    alertify.error(this.listaIdiomaReporte.DescargaToma)
                                } else if (this.listaActivos == 0) {
                                    alertify.error(this.listaIdiomaReporte.DescargaActivo)
                                } else
                                    this.ExportarExcel();
                            }
                        }
                    }),
                    createElement('a', {
                        attrs: { class: 'boton gris w-button' },
                        domProps: { innerText: "PDF" },
                        on: {
                            click: e => {

                                if (this.listaReporte == 0) {
                                    alertify.error(this.listaIdiomaReporte.DescargaToma)
                                } else if (this.listaActivos == 0) {
                                    alertify.error(this.listaIdiomaReporte.DescargaActivo)
                                } else
                                    this.Exportarpdf();
                            }
                        }
                    }),
                ])

            ])
        ])
    },
    mounted: function () {
        var logueado = JSON.parse(sessionStorage.getItem('DUser'));
        this.idPerfilActive = "" + logueado[0].IdPerfilActive;
        this.EstablecerFechasHoy();
        this.ObtenerIdioma();

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
            var anno = actual.getFullYear().toString();
            this.fechaInicial = anno + "-" + mes + "-" + dia;
            this.fechaFin = anno + "-" + mes + "-" + dia;

        },
        ObtenerBotones: function () {
            let botones = []
            //botones.push([this.Editar, '../images/editar.svg']);
            botones.push([this.ObtenerActivos, '../images/ver.svg']);
            return botones;
        },
        ObtenerHeadersInventario: function () {
            return JSON.parse('{"headersInfo":["' + this.listaIdiomaReporte.NombreTomaF + '","' +
                this.listaIdiomaReporte.DescripcionTomaF + '","' + this.listaIdiomaReporte.FechaInicial + '","'
                + this.listaIdiomaReporte.FechaFinal + '","' + this.listaIdiomaReporte.Categoria + '","' +
                this.listaIdiomaReporte.CantidadActivos + '","' + this.listaIdiomaReporte.NombreUsuario + '"]}')
        },
        EstablecerIdioma: function (idioma) {
            var self = this
            $.post(urlIdioma, {
                IdiomaTomaGeneral: idioma,
            }, function (data, error) {
                self.listaIdiomaReporte = JSON.parse(data);
            })
        },
        ObtenerIdioma: function () {
            var idiomaReporte = "ES"
            if (localStorage.getItem("idiomaApp") != undefined) {
                idiomaReporte = localStorage.getItem("idiomaApp");
            }
            this.EstablecerIdioma(idiomaReporte);
        },
        ObtenerheadersActivos: function () {
            var self = this;
            return JSON.parse('{"headersInfo":["' + this.listaIdiomaReporte.NumActivo + '","' +
                this.listaIdiomaReporte.PlacaActivo + '","' + this.listaIdiomaReporte.ObservActivo + '","'
                + this.listaIdiomaReporte.DescripActivo + '"]}')

        },
        ObtenerActivos: function (info) {
            let idToma = info[0]
            var self = this;
            self.idTomaFisica = info[0];
            self.nombreToma = info[1];
            self.descripcion = info[2];
            self.fechaInicio = info[3].split('T')[0];
            self.fechafin = info[4].split('T')[0];
            self.categoria = info[5];
            self.cantidadActivos = info[6];
            self.nombreUsuario = info[7];



            $.post(urlDetalleToma, {
                option: 'ConsultaActivoporID',
                IdTomaFisica: idToma
            }, function (respuesta, error) {
                var resp = JSON.parse(respuesta);
                self.listaActivos = [];
                for (let i = 0; i < resp.length; i += 1) {
                    self.listaActivos.push([resp[i].IdActivo, resp[i].NumeroActivo, resp[i].PlacaActivo,
                    resp[i].ObservacionActivo, resp[i].DescripcionActivo])


                }

            })

        },
        ObtenerDatos: function (fechaInicio, fechaFin) {
            var self = this
            if (fechaInicio <= fechaFin) {
                $.post(urlReporte, {
                    option: 'ConsultarReporteInventario',
                    idPerfilActive: self.idPerfilActive,
                    FechaInicial: fechaInicio,
                    FechaFinal: fechaFin
                }, function (respuesta, error) {
                    var resp = JSON.parse(respuesta);
                    self.listaReporte = [];
                    for (let i = 0; i < resp.length; i += 1) {
                        let fechainicial = resp[i].FechaInicial.split('T');
                        let fechafinal = resp[i].FechaFinal.split('T');
                        self.listaReporte.push([resp[i].IdTomaFisica, resp[i].Nombre, resp[i].Descripcion,
                        fechainicial[0] + ' ' + fechainicial[1],
                        fechafinal[0] + ' ' + fechafinal[1]
                            , resp[i].NombreCategoria,
                        resp[i].CantidadActivos, resp[i].NombreUsuario]);


                    }
                    if (resp.length == 0) {
                        alertify.error(self.listaIdiomaReporte.ErrorConsulta);
                        self.listaActivos = [];
                    }
                });
            } else {
                alertify.error(this.listaIdiomaReporte.ErrorRango);
                self.listaReporte = [];
                self.listaActivos = [];


            }

        },

        Exportarpdf: function () {
            var self = this
            $.post(urlReporte, {
                option: 'Exportar',
                IdTomaFisicaI: self.idTomaFisica,
                NombreToma: self.nombreToma,
                DescripcionToma: self.descripcion,
                FechaInicio: self.fechaInicio,
                FechaFin: self.fechafin,
                Categoria: self.categoria,
                CantidadActivos: self.cantidadActivos,
                NombreUsuario: self.nombreUsuario
            }, function (data, error) {
                var div = document.createElement('div');
                var inputNombreToma = document.createElement('label')
                var inputdescripcion = document.createElement('label')
                var inputfechaInicio = document.createElement('label')
                var inputfechaFin = document.createElement('label')
                var inputCategoria = document.createElement('label')
                var inputCantidadActivo = document.createElement('label')
                var inputNombreUsua = document.createElement('label')
                var inputTitulo = document.createElement('label')

                var valorNom = document.createElement('label')
                var valorDesc = document.createElement('label')
                var valorFechaInicio = document.createElement('label')
                var valorFechaFinal = document.createElement('label')
                var valorCategoria = document.createElement('label')
                var valorCantidadActivo = document.createElement('label')
                var valorNombreUsuario = document.createElement('label')


                inputNombreToma.innerText = self.listaIdiomaReporte.NombreTomaF
                inputdescripcion.innerText = self.listaIdiomaReporte.DescripcionTomaF
                inputfechaInicio.innerText = self.listaIdiomaReporte.FechaInicial
                inputfechaFin.innerText = self.listaIdiomaReporte.FechaFinal
                inputCategoria.innerText = self.listaIdiomaReporte.Categoria
                inputCantidadActivo.innerText = self.listaIdiomaReporte.CantidadActivos
                inputNombreUsua.innerText = self.listaIdiomaReporte.NombreUsuario
                inputTitulo.innerText = self.listaIdiomaReporte.Titulo


                valorNom.innerText = self.nombreToma
                valorDesc.innerText = self.descripcion
                valorFechaInicio.innerText = self.fechaInicio
                valorFechaFinal.innerText = self.fechafin
                valorCategoria.innerText = self.categoria
                valorCantidadActivo.innerText = self.cantidadActivos
                valorNombreUsuario.innerText = self.nombreUsuario

                inputTitulo.setAttribute('style', 'position:relative;top:20px;font-size:16pt;font-family:sans-serif;color:#eabb00;text-align:center')
                inputNombreToma.setAttribute('style', 'position:relative;top:40px;left:130px;font-size:14pt;font-family:sans-serif;color:#eabb00');
                valorNom.setAttribute('style', 'position: relative; top: 40px; left: 130px')
                inputdescripcion.setAttribute('style', 'position: relative; top: 70px; left: 130px;font-size:14pt;font-family:sans-serif;color:#eabb00');
                valorDesc.setAttribute('style', 'position: relative; top: 70px; left: 130px')
                inputfechaInicio.setAttribute('style', 'position: relative; top: 50px; left: 130px;font-size:14pt;font-family:sans-serif;color:#eabb00')
                valorFechaInicio.setAttribute('style', 'position: relative; top: 50px; left: 130px')
                inputfechaFin.setAttribute('style', 'position: relative; top: 60px; left: 130px;font-size:14pt;font-family:sans-serif;color:#eabb00')
                valorFechaFinal.setAttribute('style', 'position: relative; top: 60px; left: 130px')
                inputCategoria.setAttribute('style', 'position:absolute; top: 60px; left: 530px;font-size:14pt;font-family:sans-serif;color:#eabb00')
                valorCategoria.setAttribute('style', 'position:absolute; top: 85px; left: 530px')
                inputCantidadActivo.setAttribute('style', 'position:absolute; top: 120px; left: 530px;font-size:14pt;font-family:sans-serif;color:#eabb00')
                valorCantidadActivo.setAttribute('style', 'position:absolute; top: 145px; left: 530px')
                inputNombreUsua.setAttribute('style', 'position:absolute; top: 180px; left: 530px;font-size:14pt;font-family:sans-serif;color:#eabb00')
                valorNombreUsuario.setAttribute('style', 'position:absolute; top: 200px; left: 530px')


                div.appendChild(inputTitulo);
                div.appendChild(inputNombreToma);
                div.appendChild(valorNom);
                div.appendChild(inputfechaInicio);
                div.appendChild(valorFechaInicio);
                div.appendChild(inputfechaFin);
                div.appendChild(valorFechaFinal);
                div.appendChild(inputCategoria);
                div.appendChild(valorCategoria);
                div.appendChild(inputCantidadActivo);
                div.appendChild(valorCantidadActivo);
                div.appendChild(inputNombreUsua);
                div.appendChild(valorNombreUsuario);
                div.appendChild(inputdescripcion);
                div.appendChild(valorDesc);


                var divTabla = document.createElement('div');
                divTabla.setAttribute('style', 'margin-top:15%;;position:relative;width: 100%;display:block')

                var table = document.getElementById("TablaActivos")
                myClone = table.cloneNode(true);

                divTabla.appendChild(myClone)

                div.appendChild(divTabla);

                alertify.success(self.listaIdiomaReporte.MsjDescarga);
                const element = div;
                html2pdf()
                    .set({ html2canvas: { scale: 3 } })
                    .from(element)
                    .save("reporte-Inventario.pdf");
            })

        },


        //aun no 
        ExportarExcel: function () {
            var self = this;
            var idiomaReporte = "ES"
            if (localStorage.getItem("idiomaApp") != undefined) {
                idiomaReporte = localStorage.getItem("idiomaApp");
            }
            $.post(urlReporte, {
                option: 'Exportar',
                IdTomaFisicaI: self.idTomaFisica,
                NombreToma: self.nombreToma,
                DescripcionToma: self.descripcion,
                FechaInicio: self.fechaInicio,
                FechaFin: self.fechafin,
                Categoria: self.categoria,
                CantidadActivos: self.cantidadActivos,
                NombreUsuario: self.nombreUsuario,
                IdiomaTomaGeneral: idiomaReporte
            }, function (data, error) {

                var nombre = 'Inventario'
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
                        alertify.success(self.listaIdiomaReporte.MsjDescarga); //alerta de correcto
                    })
                    .catch(() => alertify.error(self.listaIdiomaReporte.MsjIntenteNuev));
            })
        },

    }

})
const reporte = new Vue({
    el: '#reporteinventarios',

    data: {

    }
})

