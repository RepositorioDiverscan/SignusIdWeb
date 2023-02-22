var urlIdioma = 'Idioma/ContactoIdioma.aspx'
var urlContactoAjax = 'ContactoAjax.aspx';

const contactos = new Vue({
    el: '#contacto',

    data: {
            listaidioma: {},
            IdiomaContactos: "",
            nombre: "",
            apellido: "",
            correo: "",
            telefono: "",
            mensaje:"",
            telNational: '',
            phoneInput4: '',
            asunto: ''
    },
    mounted: function () {
        this.ObtenerIdioma();
        this.CargarInputPaises();
    },
    methods: {
        ObtenerIdioma: function () {
            var idiRegistro = "ES"
            if (localStorage.getItem("idiomaApp") != undefined) {
                idiRegistro = localStorage.getItem("idiomaApp");
            }
            this.EstablecerIdiomaContacto(idiRegistro);
        },
        EstablecerIdiomaContacto: function (idioma) {
            var self = this
            $.post(urlIdioma, {
                IdiomaContactos: idioma,
            }, function (data, error) {
                self.listaidioma = JSON.parse(data);
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

        ObtenerDatosRegistro: function () {
            var self = this;
            if (this.nombre != '') {

                if (this.apellido != '') {


                    if (this.correo != '') {

                        $.post(urlContactoAjax, {
                            option: 'EnviarCorreoContacto',
                            Nombre: self.nombre,
                            Apellido: self.apellido,
                            Correo: self.correo,
                            Telefono: self.phoneInput4.getNumber(),
                            Mensaje: self.mensaje,
                            Asunto: self.asunto
                        }, function (data, error) {


                        });


                    } else {
                        alertas.error("Atención:", this.listaidioma.ErrCorreo);
                    }


                } else {
                    alertas.error("Atención:", this.listaidioma.ErrApellido);
                }

            } else {
                alertas.error("Atención:", this.listaidioma.ErrNombre);
            }


        },

    },
})
