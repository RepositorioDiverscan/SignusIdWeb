var urlEncabezado = '../TomaFisica/Encabezado/TomaFisicaAjax.aspx'
var urlIdioma = 'Idioma/IdiomaReporteInventarios.aspx'
var urlDetalleToma = 'DetalleInventario/DetalleReporteInventario.aspx'
var urlUbicacion = '../Ubicaciones/UbicacionA/UbicacionAjax.aspx'

const ReporteInventarios = new Vue({

    el: '#ReporteInventariosVue',

        data: {
        listaIdiomaToma: [],
        listaTomasEncabezado: [],
        listaActivos: [],
        IdPerfilActive: '',
        nombredetoma: '',
        descripcion: '',
        fecha: '',
        fechaInicio: '',
        fechaFinal: '',
        fechaHoy: '',
        filtradoActivos: '-1',
        valorEncontrados: 1,
        valorNoEncontrados: 2,
        valorSobrantes: 3,
        elementosXPagina: 50,
        paginas: 0,
        datosPaginados: [],
        paginaActual: 1,
        elementosXPaginaActivos: 50,
        paginasActivos: 0,
        datosPaginadosActivos: [],
        paginaActualActivos: 1,
        selectActivos: 1,
        ValDescripcion: '',
        IdTomaFisica: '',
        IdCategoria: '',
        IdUbicacion: '',
        NuevaObservacion: '',
        IdActivoEditar: '',
        respDetalle:'',
        respObsrv:'',
        },
        mounted: function () {
            this.ValidarSesion();
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
                this.fechaHoy = anno + "-" + mes + "-" + dia;

            },
            ValidarFechaInicial: function () {

                var self = this
                if (self.fechaInicio > self.fechaHoy) {
                    self.fechaInicio = self.fechaHoy
                }

            },

            ValidarFechaFinal: function () {

                var self = this
                if (self.fechaFinal > self.fechaHoy) {
                    self.fechaFinal = self.fechaHoy
                }

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
                    if (respuesta.length == 0) {
                        alertas.error(self.listaIdiomaToma.Atencion, self.listaIdiomaToma.ErrorRangoFechas);
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
                            alertas.error(self.listaIdiomaToma.Atencion, self.listaIdiomaToma.ErrorRangoFechas);
                        }
                        else {
                            self.CantidadRegistros();
                        }

                    });
                } else {
                    self.ObtenerTodosDatos();
                    alertas.error(self.listaIdiomaToma.Atencion, self.listaIdiomaToma.ErrorRangoF);
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
                    IdiomaInventariosFisica: idioma,
                }, function (data, error) {
                    self.listaIdiomaToma = JSON.parse(data);

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
                    self.selectActivos = '1';
                    self.listaActivos = JSON.parse(respuesta);
                    self.paginaActualActivos = 1;
                    self.CantidadRegistrosActivos();
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
            ObtenerActivosTomaFisica: function (idToma, idCat, idUb) {
                var self = this;
                var accion = self.selectActivos;

                if (idToma != null) {
                    self.IdTomaFisica = idToma;
                    self.IdCategoria = idCat;
                    self.IdUbicacion = idUb;
                }

                //carga todos los activos dela toma 
                if (accion == 1) {
                    $.post(urlDetalleToma, {
                        option: 'ObtenerActivosTodosToma',
                        IdTomaFisica: self.IdTomaFisica,
                        IdCategoria: self.IdCategoria,
                        IdUbicacion: self.IdUbicacion
                    }, function (respuesta, error) {
                        if (self.IdTomaFisica != '-1') {
                            self.listaActivos = JSON.parse(respuesta);
                            self.paginaActualActivos = 1;
                            self.CantidadRegistrosActivos();
                            if (self.listaActivos.length == 0) {
                                alertas.error(self.listaIdiomaToma.Atencion, "No se encontro ningún activo");
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
                                alertas.error(self.listaIdiomaToma.Atencion, "No se encontro ningún activo");
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
                                alertas.error(self.listaIdiomaToma.Atencion, "No se encontro ningún activo");
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
                    alertas.error(self.listaIdiomaToma.Atencion, self.listaIdiomaToma.ErrorObserv);
                }
                else {

                $.post(urlDetalleToma, {
                    option: 'ActualizarObservacionToma',
                    IdActivo: self.IdActivoEditar,
                    IdTomaFisica: self.IdTomaFisica,
                    IdPerfilActive: self.IdPerfilActive,
                    Observacion: self.NuevaObservacion
                }, function (respuesta, error) {
                    if (respuesta.length < 12) {
                        alertas.error(self.listaIdiomaToma.Atencion, self.listaIdiomaToma.ErrorActualizarObsrv);
                        return
                    }
                })
                $.post(urlDetalleToma, {
                    option: 'ActualizarDetalleToma',
                    IdActivo: self.IdActivoEditar,
                    IdTomaFisica: self.IdTomaFisica,
                    IdPerfilActive: self.IdPerfilActive,
                }, function (respuesta, error) {
                    self.respDetalle = respuesta;
                    if (respuesta.length < 12) {
                        alertas.error(self.listaIdiomaToma.Atencion, self.listaIdiomaToma.ErrorActualizarObsrv);
                    }
                    else {
                        alertas.success(self.listaIdiomaToma.Atencion, self.listaIdiomaToma.ActualizarCorrecto);
                    }
                })
                  
                }

                var a = document.getElementById('PObservaciones');

                a.style.display = 'none';
                self.IdActivoEditar = 0;
                self.IdPerfilActive = 0;
                self.NuevaObservacion = "";
                datosPaginadosActivos = [];
                self.ObtenerActivosTomaFisica(self.IdTomaFisica);
            },

            GenerarReportePDF: function () {
                var pdfsize = 'a0';
                var pdf = new jsPDF('1', 'pt', pdfsize);
                pdf.autoTable({
                    html: '#TablaActivos',
                    startY: 60,
                    styles: {
                        fontSize: 30,
                        cellWidth:'wrap'
                    },
                    columnStyles: {
                        1: {
                            columnWidth:'auto'
                        }
                    }
                })
                pdf.save('ReporteActivos.pdf');
                alertas.error(self.listaIdiomaToma.Atencion, self.listaIdiomaReporte.OkDescarga);
            },

            ExportarExcel: function () {
                var self = this;
                var idiomaReporte = "ES"
                var ubicacion, categoria, nombretoma, idtoma;
                idtoma = self.IdTomaFisica;
                if (localStorage.getItem("idiomaApp") != undefined) {
                    idiomaReporte = localStorage.getItem("idiomaApp");
                }
                self.ObtenerTodosDatos();
                for (i = 0; i < self.listaTomasEncabezado.length; i++) {

                    if (self.listaTomasEncabezado[i].IdTomaFisica == idtoma) {
                        ubicacion = self.listaTomasEncabezado[i].Ubicacion;
                        categoria = self.listaTomasEncabezado[i].NombreCategoria;
                        nombretoma = self.listaTomasEncabezado[i].Nombre;
                    }
                }
                
                $.post(urlDetalleToma, {
                    option: 'Exportar',
                    IdTomaFisica: self.IdTomaFisica,
                    Lista: JSON.stringify(self.listaActivos),
                    Nombre: nombretoma,
                    ubicacion: ubicacion,
                    NombreCategoria: categoria
                }, 

                   function(data, error) {

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
                    alertify.success(self.listaIdiomaReporte.ErrorDescarg); //alerta de correcto
                })
                .catch(() => alertify.error(self.listaIdiomaReporte.OkDescarga));
        })
            },

            AbrirDatePicker: function (valor) {
                var inputCalendario = document.getElementById(valor);
                inputCalendario.showPicker();
            },

            ValidarSesion: function () {

                var dConfig = JSON.parse(sessionStorage.getItem('DConfig'));
                var dUser = JSON.parse(sessionStorage.getItem('DUser'));

                if (dConfig == null || dConfig.CofReportes == false || dUser[0].TipoUsuario != 1) {
                    window.location.href = window.location.origin + "/AccesoDenegado.aspx";
                }
            },
        },
    
})
