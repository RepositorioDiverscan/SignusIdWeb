var urlIncidente = 'AjaxIncidentes.aspx'
var urlIdioma = 'AjaxIdiomaIncidentes.aspx'


const IncidenteVue = new Vue({

    el: '#IncidenteVue',

    data: {
        listaIdiomas: [],
        datosUsuario: [],
        listaTipos: [],
        idTipoIncidente: 0,
        idPerfilActive: 0,
        nombre: '',
        apellido: '',
        telefono: '',
        email: '',
        mensaje: '',
        nombreIncidente: '',
        telNational: '',
        phoneInput5: ''
    },

    mounted: function () {

        this.listaIdiomas = this.ObtenerIdioma();
        this.ObtenerDatosUsuario();
        this.CargarInputPaises();
        this.ListarTiposIncidentes();


    },

    methods: {

        // CONFIGURAR EL IDIOMA

        ObtenerIdioma: function () {

            var idiActualiza = "ES"

            if (localStorage.getItem("idiomaApp") != undefined) {

                idiActualiza = localStorage.getItem("idiomaApp");

            }

            this.EstablecerIdiomaPerfilUsuario(idiActualiza);

        },

        EstablecerIdiomaPerfilUsuario: function (idioma) {

            var self = this

            $.post(urlIdioma, {

                IdiomaPerfilUsuario: idioma,

            }, function (data, error) {

                self.listaIdiomas = JSON.parse(data);

            });

        },
        //Obtiene datos del usuario
        ObtenerDatosUsuario: function () {

            let json = JSON.parse(sessionStorage.getItem('DUser'));
            this.datosUsuario = json;
            this.idPerfilActive = json[0].IdPerfilActive;
            this.nombre = json[0].Nombre;
            this.apellido = json[0].Apellildo;
            this.email = json[0].Correo;
        },

        InsertarIncidente: function () {
            var self = this;
            if (self.idTipoIncidente != 0) {
                if (self.phoneInput5.getNumber() != "") {
                    if (self.mensaje != '') {
                        
                        $.post(urlIncidente, {
                            opciones: 'InsertarIncidente',

                            Nombre: self.nombre,
                            Apellido: self.apellido,
                            IdPerfilActive: self.idPerfilActive,
                            IdTipoIncidente: self.idTipoIncidente,
                            Mensaje: self.mensaje,
                            Correo: self.email,
                            Telefono: self.phoneInput5.getNumber(intlTelInputUtils.numberFormat.E164),

                        }, function (data, error) {
                            var msj = JSON.parse(data);

                            if (msj == "EXITO") {

                                alertas.success(self.listaIdiomas.Atencion, self.listaIdiomas.Guardado);
                                self.EnviarCorreo();
                                self.IdTipoIncidente = 0;
                                self.phoneInput5.setNumber('');
                                self.mensaje = '';
                                
                            } else {
                                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.Error);
                            }
                        }

                        );
                    } else {
                        alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.LlenarMensaje);
                    }
                } else {
                    alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.LlenarTelefono);
                }
            } else {
                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.LlenarTipoIcidente);
            }
            

        },


        ListarTiposIncidentes: function () {
            var self = this;

            $.post(urlIncidente, {
                opciones: 'ConsultarTipos',

                

            }, function (data, error) {
                self.listaTipos = JSON.parse(data);
            }

            );
                    


        },

        EnviarCorreo: function () {
            var self = this;

            $.post(urlIncidente, {
                opciones: 'EnviarCorreo',
                IdTipoIncidente: self.idTipoIncidente,
                IdPerfilActive: self.idPerfilActive,
                Nombre: self.nombre,
                Apellido: self.apellido,
                Telefono: self.phoneInput5.getNumber(),
                Correo: self.email,
                Mensaje: self.mensaje

            }, function (data, error) {
                var respuesta = JSON.parse(data);
                

            }
            );

        },

        ValidarSesion: function () {

            var dConfig = JSON.parse(sessionStorage.getItem('DConfig'));
            var dUser = JSON.parse(sessionStorage.getItem('DUser'));

            if (dConfig == null || dConfig.CofPerfil == false || dUser[0].TipoUsuario != 1) {
                window.location.href = window.location.origin + "/AccesoDenegado.aspx";
            }
        },

        CargarInputPaises: function () {
            const phoneInputField = document.getElementById("telNational");

            //Configuración del Input tel 
            this.phoneInput5 = window.intlTelInput(phoneInputField, {
                initialCountry: "us", //Un prefijo nacional por defecto al cargar
                preferredCountries: ["us"], //Puedes agregar prefijos preferenciales para que salgan al inicio
                separateDialCode: true, //Mostrar el prefijo seleccionado en el input
                
                utilsScript: "https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/11.0.14/js/utils.js",
                customPlaceholder: function (selectedCountryPlaceholder, selectedCountryData) {
                    return "Ingrese su número de teléfono";
                }
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


    },

    })