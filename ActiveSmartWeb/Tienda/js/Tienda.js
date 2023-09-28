var urlIdioma = 'AjaxIdiomaTienda.aspx';
var urlAjax = 'AjaxTienda.aspx';
var urlMetodosAjax ='../MetodosPago/MetodosPagoAjax.aspx';

const app = new Vue({

    el: '#tiendaVue',

    data: {
        listaIdiomas: [],
        numActivos: 0,
        ubicacionesA: 0,
        personalParaActivos: 0,
        usuariosGestores: 0,
        precioAct: 0,
        pagoParcial : 0,
        totalpago: 0,
        frecuenciaPago: "",
        adicionales: [],
        adicionalesseleccionados: [],
        NumTarjeta: "",
        CardholderName: "",
        txtFrecuenciaPago: "",
        contadorRegalias:0
    },

    mounted: function () {
        this.listaIdiomas = this.ObtenerIdioma();
        this.CargarAdicionales();
        this.CargarPrecioActual();
 
        this.CargarFrecuenciaPago();
 

        this.CargarTotal();
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

        CargarPlanUsuario: function () {
            var self = this;
            var usuario = JSON.parse(sessionStorage.getItem('DUser'));
            $.post(urlAjax, {
                option: 'ObtenerPlanUsuario',
                IdPerfilUsuario: usuario[0].IdPerfilUsuario,
            }, function (data, error) {
                self.adicionalesseleccionados = JSON.parse(data);
                self.actualizarValoresInputs();
            });
        },
        //CargarPrecio
        CargarPrecioActual: function () {
            var self = this;
            var usuario = JSON.parse(sessionStorage.getItem('DUser'));
            var idPerfilEmpresa = usuario[0].IdPerfilEmpresa;
            $.post(urlAjax, {
                option: 'CargarPrecioAct',
                idPerfilEmpresa: idPerfilEmpresa
            }, function (data, error) {
               
                self.precioAct = data;

            });
        },

        //Metodo para cargar los adicionales.
        CargarAdicionales: function () {
            var self = this;
            
            $.post(urlAjax, {
                option: 'CargarAdicionales',
                
            }, function (data, error) {
                self.adicionales = JSON.parse(data);
                self.CargarPlanUsuario();
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
                self.CargarTotal();
            });
        },

        //Metodo para cargar el total de la compra.
        CargarTotal: function () {
            var self = this;

            var usuario = JSON.parse(sessionStorage.getItem("DUser"));

            $.post(urlAjax, {
                option: 'CargarTotal',
                IdEmpresa: usuario[0].IdPerfilEmpresa,
                frecuenciaPago: self.frecuenciaPago,
                precioActual : self.precioAct,

            }, function (data, error) {

                self.totalpago = data;
                
                var monto = data.replace(",", ".");
                var actual = self.precioAct.replace(",", ".");



                self.pagoParcial = (parseFloat(monto) - parseFloat(actual)).toFixed(2);

                 if (parseFloat(self.pagoParcial) < 0)
                    self.pagoParcial = 0;
                

            });
        },

        //Metodo para obtener el idContrato
        ObtenerFrecuenciaPago: function () {
            var self = this;

            var usuario = JSON.parse(sessionStorage.getItem("DUser"));

            $.post(urlAjax, {
                option: 'ObtenerFrecuenciaPago',
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
               
                    if (adicional.IdPaqueteContratado == 1) {
                        var cantidadActivosPlan = self.adicionalesseleccionados[1].Cantidad+250;
                        if (cantidadActivosPlan == 500 || cantidadActivosPlan == 1000 || cantidadActivosPlan == 1500 || cantidadActivosPlan ==2000) {
                            if (document.getElementById(`${adicional.IdPaqueteContratado + 1}`).value < 99)
                                document.getElementById(`${adicional.IdPaqueteContratado + 1}`).value++;
                            if (document.getElementById(`${adicional.IdPaqueteContratado + 2}`).value < 99)
                                document.getElementById(`${adicional.IdPaqueteContratado + 2}`).value++;
                            if (document.getElementById(`${adicional.IdPaqueteContratado + 3}`).value < 99)
                                document.getElementById(`${adicional.IdPaqueteContratado + 3}`).value++;
                            self.contadorRegalias++;
                        }
                    }
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
                if (cantidadResta >= 0) {
                if (adicional.IdPaqueteContratado == 1) {
                    var cantidadActivosPlan = self.adicionalesseleccionados[1].Cantidad-250;
                    if (cantidadActivosPlan == 250 || cantidadActivosPlan == 750 || cantidadActivosPlan == 1250 || cantidadActivosPlan == 1750) {
                        if (document.getElementById(`${adicional.IdPaqueteContratado + 1}`).value >= 1)
                            document.getElementById(`${adicional.IdPaqueteContratado + 1}`).value--;
                        if (document.getElementById(`${adicional.IdPaqueteContratado + 2}`).value >= 1)
                            document.getElementById(`${adicional.IdPaqueteContratado + 2}`).value--;
                        if (document.getElementById(`${adicional.IdPaqueteContratado + 3}`).value >= 1)
                            document.getElementById(`${adicional.IdPaqueteContratado + 3}`).value--;
                        self.contadorRegalias--;

                       
                    }
                }
                    if (adicional.IdPaqueteContratado == 1 || (adicional.IdPaqueteContratado != 1 && document.getElementById(`${adicional.IdPaqueteContratado}`).value > self.contadorRegalias)) {

                    document.getElementById(`${adicional.IdPaqueteContratado}`).value = cantidadResta

                    $.post(urlAjax, {
                        option: 'RestarAdicional',
                        IdAdicional: adicional.IdPaqueteContratado,
                        NombreAdicional: adicional.Nombre,
                        Cantidadpaquete: adicional.Cantidad,
                        Costo: adicional.Costo,
                        CostoMensual: adicional.CostoMensual,
                        CantidaddePaquetes: cantidadResta,
                        cantidadActivos: cantidadActivosPlan
                    }, function (respuesta, error) {

                        self.CargarAdicionalesContratado();

                    });
                    }

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
        //actualizarValoresInputs: function () {
        //    var self = this;
        //    //Setea el valor del input de los activos
        //    document.getElementById(`1`).value = self.adicionalesseleccionados[1].Cantidad / self.adicionales[0].Cantidad
        //    $.each(self.adicionalesseleccionados, function (index, adicional) {
        //        if (adicional.IdPaqueteContratado != 1) {
        //            document.getElementById(`${adicional.IdPaqueteContratado}`).value = adicional.Cantidad;
        //        }

        //    });
        //},

        realizarPago: function () {
           
            var self = this;
            var usuario = JSON.parse(sessionStorage.getItem('DUser'));

            $.post(urlAjax, {
                option: 'CargarDatosTarjeta',
                idPerfilEmpresa: usuario[0].IdPerfilEmpresa
            }, function (data, error) {

                var response = data;
                var tarjeta = response.split("-");
                self.NumTarjeta = "XXXXXXXX" + tarjeta[1];
                self.CardholderName = tarjeta[0];

                
                document.getElementById("PopUpPago").style.display = "flex";
            });
        },

        CerrarPopUp: function () {

            document.getElementById("PopUpPago").style.display = "none";
           
        },

        procesarPago: function () {

            var self = this;
            var usuario = JSON.parse(sessionStorage.getItem('DUser'));

            $.post(urlAjax, {
                option: 'ProcesarPago',
                idPerfilEmpresa: usuario[0].IdPerfilEmpresa,
                frecuenciaPago: self.frecuenciaPago,
                pagoParcial: self.pagoParcial,
                pagoTotal:self.pagoTotal

                

            }, function (data, error) {

             


                document.getElementById("PopUpPago").style.display = "flex";
            });
        },


    }


})