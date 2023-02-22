var urlAjaxIdioma = 'IdiomaRegistroAjax.aspx';
var urlRegistroAjax = 'RegistroAjax.aspx';

const login = new Vue({
    el: '#context',
    data: {
        email: "",
        password: "",
        listaIdiomas: {},
        idiomaLogin: "",
        display: "none",
        empresa: '',
        empresas: [],
        nombreEmpresa: "",
        telefonoEmpresa: "",
        correoEmpresa: "",
        nombreUsuario: "",
        apellidosUsuario: "",
        correoUsuario: "",
        contrasena: "",
        contrasena1: "",

        idEmpresa: "",
        idIndustria: "",
        idEmpresaTamano: "",
        pais: "",
        direccion: "",
        posicion:"",

        industrias: [],
        numeroEmpleados: [],
        telNational: '',
        phoneInput4: '',
        moneda: '',
        listaMonedas: [],
        chterminos: true,

    },
    mounted: function () {
        var idiLog = "ES"
        if (localStorage.getItem("idiomaApp") != undefined) {
            idiLog = localStorage.getItem("idiomaApp");
        }
        this.idiomaLogin = idiLog;
        this.estableceridiomalogin(this.idiomaLogin);
        this.CargarIndustrias();
        this.CargarEmpresaTamano();
        this.CargarInputPaises();
        this.CargarMonedas();
    },
    methods: {
        estableceridiomalogin: function (tipoIdioma) {
            var self = this;
            $.post(urlAjaxIdioma, {
                idioma: tipoIdioma,
            }, function (data, error) {
                self.listaIdiomas = JSON.parse(data);
            });
        },

        establecerempresa: function () {
            let array = JSON.parse(sessionStorage.getItem('DUser'));
            let empresa = this.empresa;
            array.forEach(function (entry) {
                if (empresa == entry.IdPerfilEmpresa) {
                    var Json = JSON.stringify([{ IdPerfilUsuario: entry.IdPerfilUsuario, Nombre: entry.Nombre, Apellildo: entry.Apellildo, ImagenPerfil: entry.ImagenPerfil, Identificacion: entry.Identificacion, IdPerfilActive: entry.IdPerfilActive, IdPerfilEmpresa: entry.IdPerfilEmpresa, NombreEmpresa: entry.NombreEmpresa }]);
                    sessionStorage.setItem('DUser', Json);

                    window.location.replace("../Menu/MenuPrincipal.aspx");
                }
            });
        },

        ObtenerDatosRegistro: function () {
            this.pais = $("#country").countrySelect("getSelectedCountryData").name;
            var self = this;
            if (this.nombreEmpresa != '') {

                if (this.telefonoEmpresa != '') {

                    if (this.nombreUsuario != '') {

                        if (this.apellidosUsuario != '') {

                            if (this.correoUsuario != '') {

                                if (this.contrasena != '') {

                                    if (this.idEmpresa != '') {

                                        if (this.idIndustria != '') {

                                            if (this.idEmpresaTamano != '') {

                                                if (this.pais != '') {

                                                    this.SeleccionarMonedas($("#country").countrySelect("getSelectedCountryData").iso2);

                                                    if (this.direccion != '') {

                                                        if (this.posicion != '') {

                                                            if (this.chterminos != false) {
                                                                if (this.contrasena == this.contrasena1) {
                                                                    $.post(urlRegistroAjax, {
                                                                        option: 'ValidarPassword',
                                                                        passW: this.contrasena
                                                                    }, function (respuesta, error) {
                                                                        if (respuesta != 'VALIDA') {
                                                                            document.getElementById('PswPrincipal').focus();
                                                                        } else {
                                                                            sessionStorage.setItem('NombreEmpresa', self.nombreEmpresa);
                                                                            sessionStorage.setItem('TelefonoEmpresa', self.phoneInput4.getNumber());
                                                                            sessionStorage.setItem('CorreoEmpresa', self.correoUsuario);
                                                                            sessionStorage.setItem('NombreUsuario', self.nombreUsuario);
                                                                            sessionStorage.setItem('ApellidosUsuario', self.apellidosUsuario);
                                                                            sessionStorage.setItem('CorreoUsuario', self.correoUsuario);
                                                                            sessionStorage.setItem('Contrasena', self.contrasena);
                                                                            sessionStorage.setItem('IdEmpresa', self.idEmpresa);
                                                                            sessionStorage.setItem('IdIndustria', self.idIndustria);
                                                                            sessionStorage.setItem('IdEmpresaTamano', self.idEmpresaTamano);
                                                                            sessionStorage.setItem('Pais', self.pais);
                                                                            sessionStorage.setItem('Direccion', self.direccion);
                                                                            sessionStorage.setItem('Posicion', self.posicion);
                                                                            sessionStorage.setItem('Moneda', self.moneda);
                                                                            self.InsertarUsuariosEmpresas();
                                                                            window.location.href = "ValidarCuenta.aspx";
                                                                        }
                                                                    });
                                                                } else {
                                                                    alertas.error(this.listaIdiomas.Atencion, this.listaIdiomas.ErrConIgual);
                                                                }
                                                            } else {
                                                                alertas.error(this.listaIdiomas.Atencion, this.listaIdiomas.ErrTerminos);
                                                            }
                                                        } else {
                                                            alertas.error(this.listaIdiomas.Atencion, this.listaIdiomas.ErrPosUsuario);
                                                        }
                                                    } else {
                                                        alertas.error(this.listaIdiomas.Atencion, this.listaIdiomas.ErrIdEmpresaDir);
                                                    }
                                                } else {
                                                    alertas.error(this.listaIdiomas.Atencion, this.listaIdiomas.ErrIdEmpresaPais);
                                                }
                                            } else {
                                                alertas.error(this.listaIdiomas.Atencion, this.listaIdiomas.ErrIdEmpresaTam);
                                            }
                                        } else {
                                            alertas.error(this.listaIdiomas.Atencion, this.listaIdiomas.ErrIdIndustria);
                                        }
                                    } else {
                                        alertas.error(this.listaIdiomas.Atencion, this.listaIdiomas.ErrIdEmpresa);
                                    }
                                } else {
                                    alertas.error(this.listaIdiomas.Atencion, this.listaIdiomas.ErrContrasena);
                                }
                            } else {
                                alertas.error(this.listaIdiomas.Atencion, this.listaIdiomas.ErrCorreoUs);
                            }
                        } else {
                            alertas.error(this.listaIdiomas.Atencion, this.listaIdiomas.ErrApellidoUs);
                        }
                    } else {
                        alertas.error(this.listaIdiomas.Atencion, this.listaIdiomas.ErrNombreUs);
                    }
                } else {
                    alertas.error(this.listaIdiomas.Atencion, this.listaIdiomas.ErrTelEmp);
                }

            } else {
                alertas.error(this.listaIdiomas.Atencion, this.listaIdiomas.ErrNombreEmp);
            }
        },

        InsertarUsuariosEmpresas: function () {
           
            var self = this;

            $.post(urlRegistroAjax, {

                option: "RegistroUsuariosEmpresas",

                InfoUsuarioEmpresa: JSON.stringify({
                    nombreEmpresa: sessionStorage.getItem('NombreEmpresa'),
                    telefonoEmpresa: sessionStorage.getItem('TelefonoEmpresa'),
                    correoEmpresa: sessionStorage.getItem('CorreoEmpresa'),
                    nombreUsuario: sessionStorage.getItem('NombreUsuario'),
                    apellidosUsuario: sessionStorage.getItem('ApellidosUsuario'),
                    correoUsuario: sessionStorage.getItem('CorreoUsuario'),
                    contrasena: sessionStorage.getItem('Contrasena'),

                    idEmpresa: sessionStorage.getItem('IdEmpresa'),
                    idIndustria: sessionStorage.getItem('IdIndustria'),
                    idEmpresaTamano: sessionStorage.getItem('IdEmpresaTamano'),
                    pais: sessionStorage.getItem('Pais'),
                    direccion: sessionStorage.getItem('Direccion'),
                    posicion: sessionStorage.getItem('Posicion'),
                    moneda: sessionStorage.getItem('Moneda')
                })    

             
            }, function (data, error) {
                    self.listaIdiomas = JSON.parse(data);
            });
        },

        CargarIndustrias: function () {
            var self = this;
            $.post(urlRegistroAjax, {
                option: 'CargarIndustrias'
            }, function (data, error) {
                    self.industrias = JSON.parse(data);
            });
        },

        CargarEmpresaTamano: function () {
            var self = this;
            $.post(urlRegistroAjax, {
                option: 'CargarEmpresaTamano'
            }, function (data, error) {
                    self.numeroEmpleados = JSON.parse(data);
            });
        },

        CargarInputPaises: function () {
            const phoneInputField = document.getElementById("telNational");

            //Configuración del Input tel 
            this.phoneInput4 = window.intlTelInput(phoneInputField, {
                initialCountry: "cr", //Un prefijo nacional por defecto al cargar
                preferredCountries: ["us", "cr"], //Puedes agregar prefijos preferenciales para que salgan al inicio
                separateDialCode: true, //Mostrar el prefijo seleccionado en el input
                autoPlaceholder: "off", //Desactivar el placeholder por defecto
                utilsScript: "https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/11.0.14/js/utils.js"
            });

            //Configuracion del campo de seleccion de paises
            $("#country").countrySelect({
                defaultCountry: "cr",
            });
        },

        ValidarSoloNumeros() {
            //Obtener el valor de lo que digita el usuario en la tecla
            var key = String.fromCharCode(!event.charCode ? event.which : event.charCode);

            //Configurar el regex con las expresiones regulares que desea o que se desean
            regex = /^[0-9]$/;

            if (!regex.test(key)) {
                event.preventDefault();
                return false;
            }
        },


        //Método para mensajes en general
        mostrarMensaje(mensaje) {
            Swal.fire({
                icon: 'info',
                title: mensaje,
                showClass: {
                    popup: 'animate__animated animate__fadeInDown'
                },
                hideClass: {
                    popup: 'animate__animated animate__fadeOutUp'
                }
            })
        },

        CargarMonedas: function () {

            var self = this;

            var json = JSON.parse(localStorage.getItem('MonedasJSON'));

            self.listaMonedas = json;

        },

        SeleccionarMonedas: function (codPais) {
            var self = this;

            this.moneda = "USD $";

            this.listaMonedas.forEach(obj => {
                var codMo = obj.Codigo.substring(0, 2);
                var CodPais = codPais.toUpperCase();
                if (codMo == CodPais) {
                    this.moneda = obj.Codigo;
                }
            });

        }
        
    },
})
