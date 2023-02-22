var urlIdioma = 'AjaxIdiomaTienda.aspx'
var urlAdicionalesContratoAjax = '../RegistroUsuarioEmpresas/AdicionalesContratoAjax.aspx';

const app = new Vue({

    el: '#tiendaVue',

    data: {
        listaIdiomas: [],
        numActivos: 0,
        ubicacionesA: 0,
        personalParaActivos: 0,
        usuariosGestores: 0,
        precio: "0",
        totalpago: "0",
        adicionales: [],
        adicionalesseleccionados: []
    },

    mounted: function () {
        this.listaIdiomas = this.ObtenerIdioma();
        this.CargarAdicionales();
        
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

        SumarAdicional: function (id) {

            if (id == 1) {
                this.numActivos++;
            } else if (id == 2) {
                this.ubicacionesA++;
            } else if (id == 3) {
                this.personalParaActivos++;
            } else {
                this.usuariosGestores++;
            }
        },

        RestarAdicional: function (id) {

            if (id == 1) {
                this.numActivos--;
            } else if (id == 2) {
                this.ubicacionesA--;
            } else if (id == 3) {
                this.personalParaActivos--;
            } else {
                this.usuariosGestores--;
            }
        },

        //Metodo para cargar los adicionales.
        CargarAdicionales: function () {
            var self = this;
            $.post(urlAdicionalesContratoAjax, {
                option: 'CargarAdicionales'
            }, function (data, error) {
                self.adicionales = JSON.parse(data);
                self.AdicionalDesdeNisCompras();
            });
        },

        //Metodo para cargar los adicionales seleccionados.
        CargarAdicionalesContratado: function () {
            var self = this;
            $.post(urlAdicionalesContratoAjax, {
                option: 'CargarAdicionalescontratados'
            }, function (data, error) {
                self.adicionalesseleccionados = JSON.parse(data);
                self.CargarTotal();

            });
        },

        //Metodo para cargar el total de la compra.
        CargarTotal: function () {
            var self = this;
            $.post(urlAdicionalesContratoAjax, {
                option: 'CargarTotal',
                precioplan: self.precio
            }, function (data, error) {

                self.totalpago = data;

            });
        },


        //Metodo para cargar el precio,nombre y la imagen del plan seleccionado.
        CargarPrecio: function () {
            var self = this;
            var codigo = sessionStorage.getItem("CodigoPlan");


            if (codigo == "1") {
                this.rutaImagen = "https://rockcontent.com/es/wp-content/uploads/sites/3/2019/02/Consejos-para-hacer-ima%CC%81genes-increi%CC%81bles-1024x538.png";
            }
            else {
                this.rutaImagen = "../images/smartcostalogo.png";
            }



            $.post(urlAdicionalesContratoAjax, {
                option: 'CargarPrecio',
                CodigoPlan: codigo

            }, function (data, error) {

                let datos = JSON.parse(data);
                self.textoPlan = datos.NombrePlan;
                self.precio = datos.Costo;
                self.totalpago = datos.Costo;
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

                    $.post(urlAdicionalesContratoAjax, {
                        option: 'AgregarSumarAdicional',
                        IdAdicional: adicional.IdPaqueteContratado,
                        NombreAdicional: adicional.Nombre,
                        Cantidadpaquete: adicional.Cantidad,
                        Costo: adicional.Costo,
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
                    document.getElementById(`${adicional.IdPaqueteContratado}`).value = cantidadResta

                    $.post(urlAdicionalesContratoAjax, {
                        option: 'RestarAdicional',
                        IdAdicional: adicional.IdPaqueteContratado,
                        Cantidadpaquete: adicional.Cantidad,
                        Costo: adicional.Costo,
                        CantidaddePaquetes: cantidadResta
                    }, function (respuesta, error) {

                        self.CargarAdicionalesContratado();

                    });

                }
            }
        },

        AdicionalDesdeNisCompras: function () {

            var adicional = JSON.parse(sessionStorage.getItem('adicional'));

            if (adicional != null) {
                var self = this;
                $.post(urlAdicionalesContratoAjax, {
                    option: 'AgregarSumarAdicional',
                    IdAdicional: adicional.IdPaquete,
                    NombreAdicional: adicional.Nombre,
                    Cantidadpaquete: adicional.Cantidad,
                    Costo: adicional.Costo,
                    CantidaddePaquetes: 1
                }, function (respuesta, error) {

                    self.CargarAdicionalesContratado();
                    document.getElementById(`${adicional.IdPaquete}`).value = '1';
                    sessionStorage.setItem('adicional', '');
                });
                
            }

        }

    }


})