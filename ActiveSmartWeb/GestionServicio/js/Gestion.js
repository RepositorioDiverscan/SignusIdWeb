var urlIdioma = 'AjaxIdiomaGestionServicio.aspx'
var urlGestion = 'AjaxGestionServicio.aspx'


const GestionServicio = new Vue({

    el: '#maincontext',

    data: {

        listaIdiomas: [],
        select_Solicitante: "",
        select_Asignado: "",
        listaUsuarios: [],
        idPerfilEmpresa: "",
        idActivo: "",
        tipoBusAct: "0",
        critBusqueda: "",
        descActivo: "",
        tipoRequerimiento: "0",
        estado: "0",
        descReq: "",
        respuesta: "",
        ListaGestionS: [],
        elementosPorPagina: 50,
        paginas: 0,
        datosPaginados: [],
        paginaActual: 1,
        EstadoEdita: "",
        IdGestion: ""

    },

    mounted: function () {
        this.ValidarSesion();
        this.listaIdiomas = this.ObtenerIdioma();
        this.idPerfilEmpresa = JSON.parse(sessionStorage.getItem('Empresas'))[0].IdPerfilEmpresa;

        this.ObtenerUsuarios();
        this.ObtenerGestiones();

    },

    methods: {
        ObtenerPaginas: function () {

            this.paginas = Math.ceil(this.ListaGestionS.length / this.elementosPorPagina);
            this.getDataPagina(1);

        },
        getDataPagina: function (noPagina) {
            this.datosPaginados = [];
            let ini = (noPagina * this.elementosPorPagina) - this.elementosPorPagina;
            let fin = (noPagina * this.elementosPorPagina);
            this.datosPaginados = this.ListaGestionS.slice(ini, fin);

        },
        PaginaAnterior: function () {
            if (this.paginaActual > 1) {
                this.paginaActual--;
            }
            this.getDataPagina(this.paginaActual)
        },
        PaginaSiguiente: function () {
            if (this.paginaActual < this.paginas) {
                this.paginaActual++;
            }
            this.getDataPagina(this.paginaActual)
        },

        // CONFIGURAR EL IDIOMA

        ObtenerIdioma: function () {

            var idiActualiza = "ES"

            if (localStorage.getItem("idiomaApp") != undefined) {

                idiActualiza = localStorage.getItem("idiomaApp");

            }

            this.EstablecerIdiomaGestionServicio(idiActualiza);

        },

        EstablecerIdiomaGestionServicio: function (idioma) {

            var self = this

            $.post(urlIdioma, {

                IdiomaGestionServicio: idioma,

            }, function (data, error) {

                self.listaIdiomas = JSON.parse(data);

            });

        },

        // FIN METODOS DE IDIOMA

        ObtenerUsuarios: function () {
            var self = this;

            $.post(urlGestion, {
                opciones: 'ObtenerUsuarioPorIdEmpresa',
                IdPerfilEmpresa: self.idPerfilEmpresa,

            }, function (data, error) {
                self.listaUsuarios = JSON.parse(data);
            }

            );

        },

        ObtenerActivo: function () {
            var self = this;
            if (self.tipoBusAct != 0) {
                $.post(urlGestion, {
                    opciones: 'BuscarActivo',
                    TipoBusqueda: self.tipoBusAct,
                    CriterioBusqueda: self.critBusqueda,
                    IdPerfilEmpresa: self.idPerfilEmpresa
                }, function (data, error) {
                    var result = JSON.parse(data);
                    if (result.length != 0) {
                        self.idActivo = result[0];
                        self.descActivo = result[1];
                    }
                    else {
                        alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.NoActivo);
                        self.descActivo = "";
                    }

                }

                );
            }
            else {
                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.SelTipoBuq);
                self.descActivo = "";
            }

        },

        InsertarGestionServicio: function () {
            var self = this;

            if (self.idActivo != "") {
                if (self.tipoRequerimiento != 0) {
                    if (self.estado != 0) {
                        if (self.select_Solicitante != "") {
                            if (self.select_Asignado != "") {
                                if (self.descReq != "") {
                                    $.post(urlGestion, {
                                        opciones: 'InsertarGestion',

                                        IdActivo: self.idActivo,
                                        TipoRequerimiento: self.tipoRequerimiento,
                                        Estado: self.estado,
                                        IdUsuarioSolicita: self.select_Solicitante,
                                        IdUsuarioAsignado: self.select_Asignado,
                                        Descripcion: self.descReq,
                                        IdPerfilEmpresa: self.idPerfilEmpresa

                                    }, function (data, error) {
                                        self.respuesta = JSON.parse(data);
                                        if (data == "ERROR") {
                                            alertas.error(self.listaIdiomas.Atencion, data);
                                        } else {
                                            self.ObtenerGestiones();
                                            alertas.success(self.listaIdiomas.Atencion, data);
                                            self.idActivo = "";
                                            self.tipoRequerimiento = "0";
                                            self.estado = "0";
                                            self.tipoBusAct = "0"
                                            self.select_Solicitante = "";
                                            self.select_Asignado = "";
                                            self.descReq = "";
                                            self.descActivo = "";
                                            self.critBusqueda = "";
                                        }

                                    }
                                    );
                                } else {
                                    alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErDescReq);
                                }
                            } else {
                                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.SelColab);
                            }
                        } else {
                            alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.SelSoli);
                        }
                    } else {
                        alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.SelEst);
                    }
                } else {
                    alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.SelReq);
                }
            } else {
                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.BusqActivo);
            }
            this.ObtenerGestiones();
        },

        ObtenerGestiones: function () {
            var self = this;

            $.post(urlGestion, {
                opciones: 'ObtenerGestionesPorIdEmpresa',
                IdPerfilEmpresa: self.idPerfilEmpresa,

            }, function (data, error) {
                console.log(JSON.parse(data));
                self.ListaGestionS = JSON.parse(data);
                self.ObtenerPaginas();
            }


            );

        },

        FormatearFecha: function (fecha) {
            var fechaFormato = new Date(fecha);
            return fechaFormato.getDate() + "/" + (fechaFormato.getMonth() + 1) + "/" + fechaFormato.getFullYear();
        },

        ActualizarEstado: function (IdGestionS, EstadoGestion) {
            var self = this;

            $.post(urlGestion, {
                opciones: 'ActualizarGestion',

                IdGestion: IdGestionS,
                Estado: EstadoGestion

            }, function (data, error) {
                self.respuesta = JSON.parse(data);
                if (data == "ERROR") {
                    alertas.error(self.listaIdiomas.Atencion, data);
                } else {
                    self.ObtenerGestiones();
                    self.getDataPagina(self.paginaActual);
                    alertas.success(self.listaIdiomas.Atencion, data);
                    self.idActivo = "";
                    self.tipoRequerimiento = "0";
                    self.estado = "0";
                    self.select_Solicitante = "";
                    self.tipoBusAct = "0";
                    self.select_Asignado = "";
                    self.descReq = "";
                    self.descActivo = "";
                    self.critBusqueda = "";
                }

            }
            );

        },
        FormatearFecha: function (fecha) {
            var fechaFormato = new Date(fecha);
            return fechaFormato.getDate() + "/" + (fechaFormato.getMonth() + 1) + "/" + fechaFormato.getFullYear();
        },

        ValidarSesion: function () {
          
            var dConfig = JSON.parse(sessionStorage.getItem('DConfig'));

            if (dConfig == null  ||  dConfig.CofGestionServicio == false) {
                window.location.href = window.location.origin + "/AccesoDenegado.aspx";
            }
        },

    },

})