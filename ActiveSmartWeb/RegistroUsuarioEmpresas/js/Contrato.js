var urlAjaxIdioma = 'IdiomaAdicionalesAjax.aspx';
var urlAjax = 'AdicionalesContratoAjax.aspx';

const contrato = new Vue({
    
    el: '#context',
    //Variables para utilizar en el v-model de vue.
    data: {
        numerotarjeta: "",
        fechaVencimiento: "",
        codigo: "",
        nombretitular: "",
        apellidotitular: "",
        pais: "",
        estado: "",
        ciudad: "",
        direccion: "",

        listaIdiomas: {},
        codigoPlan: sessionStorage.getItem("CodigoPlan"),
        idiomaLogin: "",
        adicionales: [],
        totalpago: "0",
        textoPlan: "",
        precio: "0",
        rutaImagen: "../images/signus_id_basic.svg",
        frecuenciaPago: "1",
        terminoscondiciones: true,
        adicionalesseleccionados: [],

        btnPagar: false

    },
    mounted: function () {
        //Llamados a metodos para cargar la informacion necesaria.
        var idiLog = "ES"
        if (localStorage.getItem("idiomaApp") != undefined) {
            idiLog = localStorage.getItem("idiomaApp");
        }
        this.idiomaLogin = idiLog;
        this.estableceridiomalogin(this.idiomaLogin);
        this.CargarAdicionales();
        this.CargarPrecio();
        this.CargarInputPaises();
        //this.CargarAdicionalesContratado();
        this.frecuenciaPago = this.obtenerFrecuencia();
    },
    watch: {
        frecuenciaPago: function (valorNuevo, ValorAnterior) {
            var self = this;
            self.CargarPrecio();
            self.CargarAdicionalesContratado();
        }
    },
    methods: {

        //Metodo para cargar los idiomas.
        estableceridiomalogin: function (tipoIdioma) {
            var self = this;
            $.post(urlAjaxIdioma, {
                idioma: tipoIdioma,
            }, function (data, error) {
                self.listaIdiomas = JSON.parse(data);
            });
        },
        //Obtiene la frecuencia de pago seleccionada, esta viene en el url
        obtenerFrecuencia: function () {
            self = this;
            var seccionSeleccionada = self.getParameterByName('frecuencia');
            if (seccionSeleccionada == null) {
                return '1';
            }
            return seccionSeleccionada;
        },

        //Obtiene el valor del parametro enviado, este viene en el url
        getParameterByName: function (name, url) {
            if (!url) url = window.location.href;
            name = name.replace(/[\[\]]/g, '\\$&');
            var regex = new RegExp('[?&]' + name + '(=([^&#]*)|&|#|$)'),
                results = regex.exec(url);
            if (!results) return null;
            if (!results[2]) return '';
            return decodeURIComponent(results[2].replace(/\+/g, ' '));
        },

        validardigitosfechavencimiento: function () {

            var self = this;

            var template = "xx/xx";

            let j = 0;
            let plaintext = "";
            let countj = 0;
            while (j < template.length) {
                if (countj > self.fechaVencimiento.length - 1) {
                    template = template.substring(0, j);
                    break;
                }

                if (template[j] == self.fechaVencimiento[j]) {
                    j++;
                    countj++;
                    continue;
                }

                if (template[j] == "x") {
                    template =
                        template.substring(0, j) + self.fechaVencimiento[countj] + template.substring(j + 1);
                    plaintext = plaintext + self.fechaVencimiento[countj];
                    countj++;
                }
                j++;
            }

            self.fechaVencimiento = template;

            if (self.fechaVencimiento.length <= 3) {

                var split = self.fechaVencimiento.split("/");

                self.fechaVencimiento = split[0];

            }

        },

        validardigitosnumerotarjeta: function () {

            var self = this; 

            var template = "xxxx xxxx xxxx xxxx";

            let j = 0;
            let plaintext = "";
            let countj = 0;
            while (j < template.length) {
                if (countj > self.numerotarjeta.length - 1) {
                    template = template.substring(0, j);
                    break;
                }

                if (template[j] == self.numerotarjeta[j]) {
                    j++;
                    countj++;
                    continue;
                }

                if (template[j] == "x") {
                    template =
                        template.substring(0, j) + self.numerotarjeta[countj] + template.substring(j + 1);
                    plaintext = plaintext + self.numerotarjeta[countj];
                    countj++;
                }
                j++;
            }

            self.numerotarjeta = template;

            if (self.numerotarjeta.length == 15 || self.numerotarjeta.length == 10 || self.numerotarjeta.length == 5) {

                var split = self.numerotarjeta.split(" ");

                var splitunido = "";

                for (var i = 0; i < split.length; i++) {

                   splitunido = splitunido + split[i];
                    
                }

                self.numerotarjeta = splitunido;

                self.validardigitosnumerotarjeta();

            }

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

        //Metodo para cargar el total de la compra.
        CargarTotal: function () {
            var codigoCupon = sessionStorage.getItem("CodigoCupon")
            var self = this;
            $.post(urlAjax, {
                option: 'CargarTotal',
                precioplan: self.precio,
                frecuenciaPago: self.frecuenciaPago,
                codigoCupon: codigoCupon
            }, function (data, error) {

                self.totalpago = data;

            });
        },
        
        //Metodo para cargar el precio,nombre y la imagen del plan seleccionado.
        CargarPrecio: function () {
            var self = this;
            
                if (self.codigoPlan == "1"){
                    this.rutaImagen = "../images/signus_id_basic.svg";
                }
                else{
                    this.rutaImagen = "../images/signus_id_basic.svg";
                }
             
            

            $.post(urlAjax, {
                option: 'CargarPrecio',
                CodigoPlan: self.codigoPlan

            }, function (data, error) {

                let datos = JSON.parse(data);
                self.textoPlan = datos.NombrePlan;
                



                if (self.frecuenciaPago == "1") {
                    self.precio = datos.Costo;
                    //if (datos.Cantidad == self.adicionales[0].Cantidad) {
                    //    self.totalpago = datos.Costo;
                    //}

                    
                } else {
                    self.precio = datos.CostoMensual;
                    //if (datos.Cantidad == self.adicionales[0].Cantidad) {
                    //    self.totalpago = datos.CostoMensual;
                    //}
                    
                }
                var cupon = sessionStorage.getItem("CodigoCupon");
                if (cupon != 'null') 
                    self.precio = 0;
                self.CargarAdicionalesContratado();
                
            });
        },

        //Metodo para obtener los datos de registro del usuario.
        ObtenerDatosRegistro: function () {

            var self = this;
            this.pais = $("#country5").countrySelect("getSelectedCountryData").name;
            
            if (this.numerotarjeta != '') {
                if (this.fechaVencimiento != '') {
                    if (this.codigo != '') {
                        if (this.nombretitular != '') {
                            if (this.apellidotitular != '') {
                                if (this.pais != '') {
                                    if (this.estado != '') {
                                        if (this.ciudad != '') {
                                            if (this.direccion != '') {
                                                if (this.frecuenciaPago != '') {
                                                    if (this.terminoscondiciones) {                                                      

                                                        sessionStorage.setItem('frecuencia', self.frecuenciaPago);
                                                        self.btnPagar = true;
                                                        $.post(urlAjax, {

                                                            option: "RealizarPago",

                                                            Numerotarjeta: this.numerotarjeta,
                                                            FechaVencimiento: this.fechaVencimiento,
                                                            Codigo: this.codigo,
                                                            Nombretitular: this.nombretitular,
                                                            Apellidotitular: this.apellidotitular,
                                                            Frecuencia: this.frecuenciaPago,
                                                            CodigoPlan: this.codigoPlan,
                                                            correoUsuario: sessionStorage.getItem('CorreoUsuario'),
                                                            tipocontrato: sessionStorage.getItem("CodigoPlan"),
                                                            codigoCupon: sessionStorage.getItem("CodigoCupon")
                                                            

                                                        }, function (data, error) {
                                                            
                                                            if (data == "Transacción realizada correctamente") {
                                                                self.MensajeTransaccionSucces()
                                                            } else {
                                                                self.MensajeTransaccionError(data)
                                                                self.btnPagar = false;
                                                            }

                                                        });
                                                    }
                                                    else {
                                                        alertas.error("Error", "Debe aceptar los términos y condiciones");
                                                    }

                                                    
                                                }
                                            } else {
                                                alertas.error("Error", "Por favor ingrese su dirección");
                                            }
                                        } else {
                                            alertas.error("Error", "Por favor ingrese la ciudad");
                                        }
                                    } else {
                                        alertas.error("Error", "Por favor ingrese el estado");
                                    }
                                } else {
                                    alertas.error("Error", "Por favor seleccione el país");
                                }
                            } else {
                                alertas.error("Error", "Por favor ingrese el apellido del titular de la tarjeta");
                            }
                        } else {
                            alertas.error("Error", "Por favor ingrese el nombre del titular de la tarjeta");
                        }
                    } else {
                        alertas.error("Error", "Por favor ingrese el código de la tarjeta");
                    }
                } else {
                    alertas.error("Error", "Por favor ingrese la fecha de vencimiento de la tarjeta");
                }
            } else {
                alertas.error("Error", "Por favor ingrese el número de la tarjeta");
            }

        },

        MensajeTransaccionSucces: function () {
            Swal.fire({
                icon: 'success',
                title: 'Trasacción Exitosa',
                text: 'Transacción realizada correctamente',
                confirmButtonColor: '#ebbb00', // Cambia el color del botón de confirmación
                confirmButtonText: 'Entendido',
                willClose: () => {
                    window.location.assign('../../InicioSesion/InicioSesion.aspx'); // Reemplaza la URL
                }
            })
        },

        MensajeTransaccionError: function (data) {
            Swal.fire({
                icon: 'error',
                title: 'Error',
                text: data,
                confirmButtonColor: '#ebbb00', // Cambia el color del botón de confirmación
                confirmButtonText: 'Entendido'
            })
        },

        //Metodo para ingresar el contrato.
        InsertarContrato: function () {

            var self = this;

            $.post(urlAjax, {

                option: "InsertarContrato",

                //InfoUsuariotarjeta: JSON.stringify({
                //    numeroTarjeta: sessionStorage.getItem('NumeroTarjeta'),
                //    fechaVencimiento: sessionStorage.getItem('fechavencimiento'),
                //    nombretritular: sessionStorage.getItem('Nombretitular'),
                //    codigo: sessionStorage.getItem('Codigo'),
                //    pais: sessionStorage.getItem('Pais'),
                //    estado: sessionStorage.getItem('Estado'),
                //    ciudad: sessionStorage.getItem('Ciudad'),
                //    direccion: sessionStorage.getItem('Direccion'),
                //}),
                frecuencia: sessionStorage.getItem('frecuencia'),
                correoUsuario: sessionStorage.getItem('CorreoUsuario'),
                tipocontrato: sessionStorage.getItem("CodigoPlan")

            }, function (data, error) {
                self.listaIdiomas = JSON.parse(data);
                window.location.assign('../../InicioSesion/InicioSesion.aspx');
            });
            

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
                        CantidaddePaquetes: cantidadSumar,
                        Cupon: sessionStorage.getItem("CodigoCupon"),
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
                         CantidaddePaquetes: cantidadResta,
                         Cupon: sessionStorage.getItem("CodigoCupon"),
                     }, function (respuesta, error) {

                         self.CargarAdicionalesContratado();
                         
                     });
                     
                 }
             }  
        },

        //valida el codigo del plan para cargar los valores en los inputs
        validarCodigoPlan: function () {
            var self = this;
            if (self.codigoPlan == 2) {
                self.actualizarValoresInputs();
            }
        },

        //Actualiza los valores de los inputs
        actualizarValoresInputs: function () {
            var self = this;
            $.each(self.adicionalesseleccionados, function (index, adicional) {
                if (adicional.IdPaqueteContratado != 1 ) {
                    document.getElementById(`${adicional.IdPaqueteContratado}`).value = adicional.Cantidad;
                }

            });
        },


        CargarInputPaises: function () {
            //Configuracion del campo de seleccion de paises
            $("#country5").countrySelect({
                defaultCountry: "cr",
            });
        },

    },
})