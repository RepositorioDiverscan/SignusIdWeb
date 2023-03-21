var urlReporte = 'ActivosReporteAjax.aspx'
var urlIdioma = 'Idioma/IdiomaReporteActivos.aspx'
var urlCategoria = '../CategoriaActivo/Categoria/CategoriaActivo.aspx'
var urlEstado = '../EstadoActivoFijo/EstadoActivo/EstadoActivo.aspx'

const ReporteActivos = new Vue({

    el: '#REA',

    data: {

        listaIdioma: [],
        listaActivos: [],
        IdPerfilActive: '',
        IdPerfilEmpresa: '',

        elementosXPagina: 50,
        paginas: 0,
        datosPaginados: [],
        paginaActual: 1,
        elementosXPaginaActivos: 5,

        Categorias: [],
        selectCategoria: 0,

        Estados: [],
        selectEstado: 0,

        listaActivosFija: [],

        filtro: '',


    },
    mounted: function () {
        this.ValidarSesion();
        listaIdioma = this.ObtenerIdioma();
        var logueado = JSON.parse(sessionStorage.getItem('DUser'));
        this.idPerfilActive = "" + logueado[0].IdPerfilActive;
        this.IdPerfilEmpresa = "" + logueado[0].IdPerfilEmpresa;

        this.ObtenerCategorias();
        this.ObtenerEstados();
        this.ObtenerTodosDatos();
    },

    methods: {


        //Consulta todas las tomas fisicas de una empresa
        ObtenerTodosDatos: function () {
            var self = this
            $.post(urlReporte, {
                option: 'ObtenerReporteActivo',
                idPerfilEmpresa: self.IdPerfilEmpresa,
            }, function (respuesta, error) {

                self.listaActivosFija = JSON.parse(respuesta);
                self.paginaActual = 1;
                self.listaActivos = JSON.parse(respuesta);
                if (respuesta.length == 0) {
                    alertify.error('No hay Registros');
                }
                else {
                    self.CantidadRegistros();
                }

            });


        },

        FormatearFecha: function (fecha) {
            var fechaFormato = new Date(fecha);
            return fechaFormato.getDate() + "/" + (fechaFormato.getMonth() + 1) + "/" + fechaFormato.getFullYear();
        },

        // IDIOMA
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
                IdiomaReporteActivo: idioma,
            }, function (data, error) {
                self.listaIdioma = JSON.parse(data);

            })
        },


        // Función para divir los datos para mostrarlos en la tabla de las tomas fisicas
        ObtenerDataTabla(noPagina) {
            this.datosPaginados = [];
            let inicio = (noPagina * this.elementosXPagina) - this.elementosXPagina;
            let fin = (noPagina * this.elementosXPagina);
            this.datosPaginados = this.listaActivos.slice(inicio, fin);
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

            this.paginas = Math.ceil(this.listaActivos.length / this.elementosXPagina);
            this.ObtenerDataTabla(1);

        },

        // Obtener Categorías y Estados 

        ObtenerCategorias: function () {
            var self = this
            $.post(urlCategoria, {
                option: 'ConsultaCategoriaActivo',
            }, function (data, error) {
                self.Categorias = JSON.parse(data);

            });
        },

        ObtenerEstados: function () {
            var self = this
            $.post(urlEstado, {
                option: 'ConsultaEstadoActivo',
            }, function (data, error) {
                self.Estados = JSON.parse(data);

            });
        },

        // Filtros 

        FiltrarCE: function () {

            const array = [];
            this.listaActivos = this.listaActivosFija;
            this.paginaActual = 1;
            if (this.selectCategoria == 0 && this.selectEstado == 0) {
                this.listaActivos = this.listaActivosFija;
                this.CantidadRegistros();


            } else {

                if (this.selectCategoria != 0 && this.selectEstado == 0) {
                    for (var i in this.listaActivos) {
                        if (this.listaActivos[i].IdCategoria == this.selectCategoria) {
                            array.push(this.listaActivos[i]);

                        }
                    }
                }
                if (this.selectCategoria == 0 && this.selectEstado != 0) {
                    for (var i in this.listaActivos) {
                        if (this.listaActivos[i].IdEstado == this.selectEstado) {
                            array.push(this.listaActivos[i]);

                        }
                    }
                }
                if (this.selectCategoria != 0 && this.selectEstado != 0) {
                    for (var i in this.listaActivos) {
                        if (this.listaActivos[i].IdCategoria == this.selectCategoria
                            && this.listaActivos[i].IdEstado == this.selectEstado) {
                            array.push(this.listaActivos[i]);

                        }
                    }
                }


                this.listaActivos = array;

                this.CantidadRegistros();
            }



        },


        FiltrarDescripcion: function () {

            const array = [];
            this.listaActivos = this.listaActivosFija;
            this.paginaActual = 1;

            for (var i in this.listaActivos) {
                let des = ('' + this.listaActivos[i].DescripcionActivo).toLowerCase();

                if (des.includes(this.filtro.toLowerCase())) {
                    array.push(this.listaActivos[i]);
                }
            }
            if (array.length == 0) {
                this.listaActivos = this.listaActivosFija;
            }

            this.listaActivos = array;

            this.CantidadRegistros();




        },


        GenerarReportePDF: function () {
            var pdfsize = 'a0';
            var pdf = new jsPDF('1', 'pt', pdfsize);
            pdf.autoTable({
                html: '#TablaActivos',
                startY: 60,
                styles: {
                    fontSize: 30,
                    cellWidth: 'wrap'
                },
                columnStyles: {
                    1: {
                        columnWidth: 'auto'
                    }
                }
            })
            pdf.save('ReporteActivos.pdf');
            alertify.success(self.listaIdioma.OkDescarga);
            this.FiltrarCE();
        },

        ExportarExcel: function () {
            var self = this;
            idtoma = self.IdTomaFisica;
            if (localStorage.getItem("idiomaApp") != undefined) {
                idiomaReporte = localStorage.getItem("idiomaApp");
            }
            self.ObtenerTodosDatos();

            $.post(urlReporte, {
                option: 'Exportar',
                Lista: JSON.stringify(self.listaActivos),
                PerfilEmpresa:self.IdPerfilEmpresa,
            },

                function (data, error) {

                    var nombre = 'ReporteActivos'
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
                            alertify.success(self.listaIdioma.OkDescarga); //alerta de correcto
                        })
                        .catch(() => alertify.error(self.listaIdioma.ErrorDescarg));
                })
        },
        ValidarSesion: function () {

            var dConfig = JSON.parse(sessionStorage.getItem('DConfig'));

            if (dConfig == null || dConfig.CofReportes == false) {
                window.location.href = window.location.origin + "/AccesoDenegado.aspx";
            }
        },
    },

})