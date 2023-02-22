var urlEncabezado = 'Encabezado/TomaFisicaAjax.aspx'
var urlIdioma = 'Idioma/IdiomaToma.aspx'
var urlDetalleToma = 'DetalleToma/DetalleTomaFisica.aspx'
var urlUbicacion = '../Ubicaciones/UbicacionA/UbicacionAjax.aspx'

const TomaFisica = new Vue({

    el: '#TomaFisicaVue',

    data: {
        //TODO Jose, clase agregada wf-section
        listaIdiomaToma: [],
        listaTomasEncabezado: [],
        listaActivos: [],
        IdPerfilActive: '',
        nombredetoma: '',
        descripcion: '',
        fecha: '',
        fechaInicio: '',
        fechaFinal: '',
        filtradoActivos: '-1',
        valorEncontrados: 1,
        valorNoEncontrados: 2,
        valorSobrantes: 3,
        elementosXPagina: 3,
        paginas: 0,
        datosPaginados: [],
        paginaActual: 1,
        elementosXPaginaActivos: 5,
        paginasActivos: 0,
        datosPaginadosActivos: [],
        paginaActualActivos: 1,
        selectActivos: 1,
        ValDescripcion: '',
        IdTomaFisica: '',
        NuevaObservacion: '',
        IdActivoEditar: '',
        respDetalle: '',
        respObsrv: '',
    },
    mounted: function () {

        listaIdiomaToma = this.ObtenerIdioma();
        var logueado = JSON.parse(sessionStorage.getItem('DUser'));
        this.idPerfilActive = "" + logueado[0].IdPerfilActive;
        this.EstablecerFechasHoy();
        this.ObtenerTodosDatos();
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
        Editar: function (info) {

            sessionStorage.setItem('DatosToma', info);

            //window.location.href = "http://localhost:44336/TomaFisica/TomaFisicaEncabezado.aspx?" + info;

            window.location.href = "TomaFisicaEncabezado.aspx";
            //sessionStorage.setItem('DatosToma', this.datatable[y]);

            //location.reload();
            //$.post('Encabezado/TomaFisicaAjax.aspx', {

            //}, function () {

            //});
        },

        //Consulta todas las tomas fisicas de una empresa
        ObtenerTodosDatos: function () {
            var self = this
            $.post(urlEncabezado, {
                option: 'ConsultaTodosTomaFisica',
                idPerfilActive: self.idPerfilActive,
            }, function (respuesta, error) {

                self.paginaActual = 1;
                self.listaTomasEncabezado = JSON.parse(respuesta);
                console.log(self.listaTomasEncabezado);
                if (respuesta.length == 0) {
                    alertify.error(self.listaIdiomaToma.ErrorRangoFechas);
                }
                else {
                    self.CantidadRegistros();
                }

            });


        },

        //Consulta las tomas fisicas de un rango de fechas
        ObtenerDatos: function () {
            var self = this
            self.paginas = 0;
            if (self.fechaInicio <= self.fechaFinal) {
                $.post(urlEncabezado, {
                    option: 'ConsultaTomaFisica',
                    idPerfilActive: self.idPerfilActive,
                    FechaInicial: self.fechaInicio,
                    FechaFinal: self.fechaFinal
                }, function (respuesta, error) {
                    self.listaTomasEncabezado = JSON.parse(respuesta);
                    self.paginaActual = 1;
                    if (self.listaTomasEncabezado.length == 0) {
                        alertify.error(self.listaIdiomaToma.ErrorRangoFechas);
                    }
                    else {
                        self.CantidadRegistros();
                    }

                });
            } else {
                self.ObtenerTodosDatos();
                alertify.error(self.listaIdiomaToma.ErrorRangoF);

            }

        },

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
                console.log(self.listaIdiomaToma);

            })
        },
        ObtenerBotones: function () {
            let botones = []
            botones.push([this.Editar, '../images/editar.svg']);
            botones.push([this.ObtenerActivos, '../images/ver.svg']);
            return botones;
        },

        //Muestra los activos de una toma fisica, sin filtro
        ObtenerActivos: function (info) {
            var self = this;
            self.IdTomaFisica = info;
            $.post(urlDetalleToma, {
                option: 'ConsultaActivoporID',
                IdTomaFisica: self.IdTomaFisica
            }, function (respuesta, error) {
                console.log(respuesta);
                self.selectActivos = '1';
                self.listaActivos = JSON.parse(respuesta);
                self.paginaActualActivos = 1;
                self.CantidadRegistrosActivos();
                //console.log(self.listaActivos);
                //if (resp.length == 0) {
                //    alertify.error("No se encontro ningún activo");
                //}
            })
        },
        ObtenerheadersActivos: function () {

            return JSON.parse('{"headersInfo":["' + this.listaIdiomaToma.NumActivo + '","' +
                this.listaIdiomaToma.PlacaActivo + '","' + this.listaIdiomaToma.ObservActivo + '","'
                + this.listaIdiomaToma.DescripActivo + '"]}')

        },
        FormatearFecha: function (fecha) {
            var fechaFormato = new Date(fecha);
            return fechaFormato.getDate() + "/" + (fechaFormato.getMonth() + 1) + "/" + fechaFormato.getFullYear();
        },

        //Carga los activos de una toma fisica
        ObtenerActivosTomaFisica: function (inf) {
            var self = this;
            var accion = self.selectActivos;

            if (inf != null) {
                self.IdTomaFisica = inf;
            }

            //carga todos los activos dela toma 
            if (accion == 1) {
                $.post(urlDetalleToma, {
                    option: 'ObtenerActivosTodosToma',
                    IdTomaFisica: self.IdTomaFisica
                }, function (respuesta, error) {
                    if (self.IdTomaFisica != '-1') {
                        console.log(respuesta);
                        self.listaActivos = JSON.parse(respuesta);
                        self.paginaActualActivos = 1;
                        self.CantidadRegistrosActivos();
                        if (self.listaActivos.length == 0) {
                            alertify.error("No se encontro ningún activo");
                        }
                    }
                })
            }
            //Carga los activos encontrados
            if (accion == 2) {
                $.post(urlDetalleToma, {
                    option: 'ObtenerActivosEncontradosToma',
                    IdTomaFisica: self.IdTomaFisica
                }, function (respuesta, error) {
                    if (self.IdTomaFisica != '-1') {
                        self.listaActivos = JSON.parse(respuesta);
                        self.paginaActualActivos = 1;
                        self.CantidadRegistrosActivos();
                        if (self.listaActivos.length == 0) {
                            alertify.error("No se encontro ningún activo");
                        }
                    }
                })
            }
            //Carga los activos no encontrados
            if (accion == 3) {
                $.post(urlDetalleToma, {
                    option: 'ObtenerActivosNoEncontradosToma',
                    IdTomaFisica: self.IdTomaFisica
                }, function (respuesta, error) {
                    if (self.IdTomaFisica != '-1') {
                        self.listaActivos = JSON.parse(respuesta);
                        self.paginaActualActivos = 1;
                        self.CantidadRegistrosActivos();
                        if (self.listaActivos.length == 0) {
                            alertify.error("No se encontro ningún activo");
                        }
                    }
                })
            }
        },

        // Función para divir los datos para mostrarlos en la tabla de las tomas fisicas
        ObtenerDataTabla(noPagina) {
            this.datosPaginados = [];
            let inicio = (noPagina * this.elementosXPagina) - this.elementosXPagina;
            let fin = (noPagina * this.elementosXPagina);
            this.datosPaginados = this.listaTomasEncabezado.slice(inicio, fin);
        },

        // Función para regresar a la pagina anterior de la tabla de las tomas fisicas
        PaginaAnterior() {
            if (this.paginaActual > 1) {
                this.paginaActual--;
            }
            this.ObtenerDataTabla(this.paginaActual)
        },

        // Función para saltar a la siguiente pagina de la tabla de las tomas fisicas
        PaginaSiguiente() {
            if (this.paginaActual < this.paginas) {
                this.paginaActual++;
            }
            this.ObtenerDataTabla(this.paginaActual)
        },

        // Función para calcular la cantidad de paginas de la tabla de las tomas fisicas
        CantidadRegistros: function () {

            this.paginas = Math.ceil(this.listaTomasEncabezado.length / this.elementosXPagina);
            this.ObtenerDataTabla(1);

        },

        // Función para divir los datos para mostrarlos en la tabla de las tomas fisicas
        ObtenerDataTablaActivos(noPagina) {
            this.datosPaginadosActivos = [];
            let inicio = (noPagina * this.elementosXPaginaActivos) - this.elementosXPaginaActivos;
            let fin = (noPagina * this.elementosXPaginaActivos);
            this.datosPaginadosActivos = this.listaActivos.slice(inicio, fin);
        },

        // Función para regresar a la pagina anterior de la tabla de las tomas fisicas
        PaginaAnteriorActivos() {
            if (this.paginaActualActivos > 1) {
                this.paginaActualActivos--;
            }
            this.ObtenerDataTablaActivos(this.paginaActualActivos)
        },

        // Función para saltar a la siguiente pagina de la tabla de las tomas fisicas
        PaginaSiguienteActivos() {
            if (this.paginaActualActivos < this.paginasActivos) {
                this.paginaActualActivos++;
            }
            this.ObtenerDataTablaActivos(this.paginaActualActivos)
        },

        // Función para calcular la cantidad de paginas de la tabla de las tomas fisicas
        CantidadRegistrosActivos: function () {

            this.paginasActivos = Math.ceil(this.listaActivos.length / this.elementosXPaginaActivos);
            this.ObtenerDataTablaActivos(1);

        },


        // Metodos para abrir y cerrar el pop up de editar observaciones

        AbrirPopPup: function (IdActivo, observ) {
            var self = this;
            var a = document.getElementById('PObservaciones');
            a.style.display = 'block';
            self.IdActivoEditar = IdActivo;
            if (observ == "Sin observación") {

            } else {
                self.NuevaObservacion = observ;
            }
        },
        CerrarPopPup: function () {
            var a = document.getElementById('PObservaciones');
            a.style.display = 'none';
            self.IdActivoEditar = 0;
        },
        //Metodo para editar la observacion de un activo
        EditarPopUp: function () {
            var self = this;

            var prueba = JSON.parse(sessionStorage.getItem('Empresas'));
            self.IdPerfilActive = prueba[0].IdPerfilActive;
            if (self.NuevaObservacion == "" || self.NuevaObservacion == " ") {
                alertify.error(self.listaIdiomaToma.ErrorObserv);
            }
            else {

                $.post(urlDetalleToma, {
                    option: 'ActualizarObservacionToma',
                    IdActivo: self.IdActivoEditar,
                    IdTomaFisica: self.IdTomaFisica,
                    IdPerfilActive: self.IdPerfilActive,
                    Observacion: self.NuevaObservacion
                }, function (respuesta, error) {
                    console.log(respuesta);
                    if (respuesta.length < 12) {
                        alertify.error(self.listaIdiomaToma.ErrorActualizarObsrv);
                        return
                    }
                })
                $.post(urlDetalleToma, {
                    option: 'ActualizarDetalleToma',
                    IdActivo: self.IdActivoEditar,
                    IdTomaFisica: self.IdTomaFisica,
                    IdPerfilActive: self.IdPerfilActive,
                }, function (respuesta, error) {
                    console.log(respuesta);
                    self.respDetalle = respuesta;
                    if (respuesta.length < 12) {
                        alertify.error(self.listaIdiomaToma.ErrorActualizarObsrv);
                    }
                    else {
                        alertify.success(self.listaIdiomaToma.ActualizarCorrecto);
                    }
                })

            }

            var a = document.getElementById('PObservaciones');

            a.style.display = 'none';
            self.IdActivoEditar = 0;
            self.IdPerfilActive = 0;
            self.NuevaObservacion = "";
            self.ObtenerActivosTomaFisica(self.IdTomaFisica);
        }
    },

})
