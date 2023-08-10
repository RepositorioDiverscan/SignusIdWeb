var urlIdioma = 'AjaxIdiomaTienda.aspx';
var urlAjax = 'AjaxTienda.aspx';

const app = new Vue({

    el: '#tiendaVue',

    data: {
        listaIdiomas: [],
        numActivos: 0,
        ubicacionesA: 0,
        personalParaActivos: 0,
        usuariosGestores: 0,
        precio: "0",
        totalpago: "1",
        frecuenciaPago: "",
        adicionales: [],
        adicionalesseleccionados: []
    },

    mounted: function () {
        this.listaIdiomas = this.ObtenerIdioma();
        this.CargarAdicionales();
        this.CargarFrecuenciaPago();
        this.CargarTotal();
        this.CargarAdicionalesContratado();
        
    },

    methods: {

        ObtenerIdioma: function () {

            var idiActualiza = "ES"

            if (localStorage.getItem("idiomaApp") != undefined) {

                idiActualiza = localStorage.getItem("idiomaApp");

            }

            this.EstablecerIdiomaTienda(idiActualiza);

        },

        EstablecerIdiomaTienda: function (idioma) {

            var self = this

            $.post(urlIdioma, {

                IdiomaTienda: idioma,

            }, function (data, error) {

                self.listaIdiomas = JSON.parse(data);

            });

        },

        //Metodo para cargar los adicionales.
        CargarAdicionales: function () {
            var self = this;
            $.post(urlAjax, {
                option: 'CargarAdicionales'
            }, function (data, error) {
                self.adicionales = JSON.parse(data);
                
            });
        },

        //Metodo para cargar los adicionales seleccionados.
        CargarAdicionalesContratado: function () {
            var self = this;
            $.post(urlAjax, {
                option: 'CargarAdicionalescontratados'
            }, function (data, error) {
                self.adicionalesseleccionados = JSON.parse(data);
                self.CargarTotal();
                self.validarCodigoPlan();
            });
        },

        CargarFrecuenciaPago: function () {
            var self = this;

            var usuario = JSON.parse(sessionStorage.getItem("DUser"));

            $.post(urlAjax, {
                option: 'obtenerFrecuenciaPago',
                IdEmpresa: usuario[0].IdPerfilEmpresa,
            }, function (data, error) {
                self.frecuenciaPago = data;
            });
        },

        //Metodo para cargar el total de la compra.
        CargarTotal: function () {
            var self = this;

            var usuario = JSON.parse(sessionStorage.getItem("DUser"));

            $.post(urlAjax, {
                option: 'CargarTotal',
                IdEmpresa: usuario[0].IdPerfilEmpresa,
            }, function (data, error) {

                self.totalpago = data;

            });
        },

        //Metodo para sumar un adicional.
        sumaradicional: function (adicional) {
            var self = this;
            let cantidadSumar = parseInt(parseInt(document.getElementById(`${adicional.IdPaqueteContratado}`).value))
            cantidadSumar = cantidadSumar + 1
            if (!isNaN(cantidadSumar)) {
                if (cantidadSumar <= 99) {
                    document.getElementById(`${adicional.IdPaqueteContratado}`).value = cantidadSumar

                    $.post(urlAjax, {
                        option: 'AgregarSumarAdicional',
                        IdAdicional: adicional.IdPaqueteContratado,
                        NombreAdicional: adicional.Nombre,
                        Cantidadpaquete: adicional.Cantidad,
                        Costo: adicional.Costo,
                        CostoMensual: adicional.CostoMensual,
                        CantidaddePaquetes: cantidadSumar
                    }, function (respuesta, error) {

                        self.CargarAdicionalesContratado();

                    });

                }
            }
        },

        //Metodo para restar un adicional.
        Restaadicional: function (adicional) {
            var self = this;
            let cantidadResta = parseInt(parseInt(document.getElementById(`${adicional.IdPaqueteContratado}`).value))
            cantidadResta = cantidadResta - 1
            if (!isNaN(cantidadResta)) {
                if ((cantidadResta > 0 && adicional.IdPaqueteContratado == 1) || (cantidadResta > 1 && adicional.IdPaqueteContratado != 1)) {
                    document.getElementById(`${adicional.IdPaqueteContratado}`).value = cantidadResta

                    $.post(urlAjax, {
                        option: 'RestarAdicional',
                        IdAdicional: adicional.IdPaqueteContratado,
                        NombreAdicional: adicional.Nombre,
                        Cantidadpaquete: adicional.Cantidad,
                        Costo: adicional.Costo,
                        CostoMensual: adicional.CostoMensual,
                        CantidaddePaquetes: cantidadResta
                    }, function (respuesta, error) {

                        self.CargarAdicionalesContratado();

                    });

                }
            }
        },

        //Metodo para agregar un adicional de activos por medio de un metodo change.
        agregaradicionalActivos: function (adicional) {
            var self = this;
            let cantidadSumar = parseInt(parseInt(document.getElementById(`${adicional.IdPaqueteContratado}`).value))
            if (!isNaN(cantidadSumar)) {
                if (cantidadSumar <= 99 && cantidadSumar > 0) {
                    document.getElementById(`${adicional.IdPaqueteContratado}`).value = cantidadSumar

                    $.post(urlAjax, {
                        option: 'agregaradicional',
                        IdAdicional: adicional.IdPaqueteContratado,
                        NombreAdicional: adicional.Nombre,
                        Cantidadpaquete: adicional.Cantidad,
                        Costo: adicional.Costo,
                        CostoMensual: adicional.CostoMensual,
                        CantidaddePaquetes: cantidadSumar
                    }, function (respuesta, error) {

                        self.CargarAdicionalesContratado();

                    });


                } else {
                    document.getElementById(`${adicional.IdPaqueteContratado}`).value = 1;
                    self.agregaradicionalActivos(adicional);
                }
            } else {
                document.getElementById(`${adicional.IdPaqueteContratado}`).value = 1;
                self.agregaradicionalActivos(adicional);
            }

        },

        //Metodo para agregar un adicional de activos por medio de un metodo change.
        agregaradicional: function (adicional) {
            var self = this;
            let cantidadSumar = parseInt(parseInt(document.getElementById(`${adicional.IdPaqueteContratado}`).value))
            if (!isNaN(cantidadSumar)) {
                if (cantidadSumar <= 99 && cantidadSumar >= 2) {
                    document.getElementById(`${adicional.IdPaqueteContratado}`).value = cantidadSumar

                    $.post(urlAjax, {
                        option: 'agregaradicional',
                        IdAdicional: adicional.IdPaqueteContratado,
                        NombreAdicional: adicional.Nombre,
                        Cantidadpaquete: adicional.Cantidad,
                        Costo: adicional.Costo,
                        CostoMensual: adicional.CostoMensual,
                        CantidaddePaquetes: cantidadSumar
                    }, function (respuesta, error) {

                        self.CargarAdicionalesContratado();

                    });


                } else {
                    document.getElementById(`${adicional.IdPaqueteContratado}`).value = 2;
                    self.agregaradicional(adicional);
                }
            } else {
                document.getElementById(`${adicional.IdPaqueteContratado}`).value = 2;
                self.agregaradicional(adicional);
            }

        },


        //valida el codigo del plan para cargar los valores en los inputs
        validarCodigoPlan: function () {
            var self = this;
 
            self.actualizarValoresInputs();
            
        },

        //Actualiza los valores de los inputs
        actualizarValoresInputs: function () {
            var self = this;
            $.each(self.adicionalesseleccionados, function (index, adicional) {
                if (adicional.IdPaqueteContratado != 1) {
                    document.getElementById(`${adicional.IdPaqueteContratado}`).value = adicional.Cantidad;
                }

            });
        },

    }


})