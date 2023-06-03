var urlAjax = 'PasswordAJAX.aspx'
var urlIdioma = 'IdiomaCambioAJAX.aspx'
var urlPagina = window.location.origin;


const cambioPassword = new Vue({
    el: '#context',
    data: {
        listaIdiomas: [],
        Idioma11: '',
        password: '',
        confirmPassword: '',
        IdPefil_Empresa: '',
        IdPerfilU: '',
        correoUsuario: '',
    },
    mounted: function () {
        var logueado = JSON.parse(sessionStorage.getItem('DUser'));
        console.log(urlPagina);
        //this.IdPefil_Empresa = logueado[0].IdPerfilEmpresa;
        this.listaIdiomas = this.ObtenerIdioma();
       // this.IdPefil_Empresa = "1";//+ logueado[0].IdPerfilEmpresa;
        // listaIdiomas = this.ObtenerIdiomaEmpleados();
    },
    methods: {

        // CONFIGURAR EL IDIOMA
        ObtenerIdioma: function () {
            var idiActualiza = "ES"

            if (localStorage.getItem("idiomaApp") != undefined) {
                idiActualiza = localStorage.getItem("idiomaApp");
            }
            this.EstablecerIdioma(idiActualiza);
        },


        EstablecerIdioma: function (idioma) {
            var self = this
            $.post(urlIdioma, {
                IdiomaOption: idioma,
            }, function (data, error) {
                self.listaIdiomas = JSON.parse(data);
                console.log(JSON.parse(data));
            });
        },
        // FIN METODOS DE IDIOMA

        
        ValidarInformacion: function () {
            var self = this;
            //CorreoURL
            if (self.correoUsuario != "") {

                $.post(urlAjax, {
                    option: 'ValidarInformacion',
                    correo: self.correoUsuario,
                }, function (respuesta, error) {
                    if (respuesta != 0) {
                        // ENVÍA EL CORREO
                        self.EnviarCorreo();
                    } else {
                        alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.OlCorreoNo);
                    }
                });

            } else {
                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.OlCorreoIn);
            }
        },
        EnviarCorreo: function () {
            var self = this;
            

            //CorreoURL
            $.post(urlAjax, {
                option: 'EnviarCorreo',
                correo: self.correoUsuario,
                urlPag: urlPagina,
            }, function (respuesta, error) {
                if (respuesta != '0') {

                    self.MensajeAlertaErrorEnvioCorreo(self.listaIdiomas.Atencion, self.listaIdiomas.OlCorreoEr)

                } else {
                    self.MensajeAlertaEnvioCorreo(self.listaIdiomas.Atencion, self.listaIdiomas.OlCorreoEn)
                }
            });

        },
        MensajeAlertaEnvioCorreo: function (atencion,mensaje) {
            Swal.fire({
                icon: 'warning',
                title: atencion,
                text: mensaje,
                confirmButtonColor: '#ebbb00', // Cambia el color del botón de confirmación
                confirmButtonText: 'Entendido',
                willClose: () => {
                    window.location.replace('../InicioSesion/InicioSesion.aspx'); // Reemplaza la URL
                }
            })
        },
        MensajeAlertaErrorEnvioCorreo: function (atencion, mensaje) {
            Swal.fire({
                icon: 'error',
                title: atencion,
                text: mensaje,
                confirmButtonColor: '#ebbb00', // Cambia el color del botón de confirmación
                confirmButtonText: 'Entendido',
            })
        },
        IrMenu: function () {
            window.location.replace('../InicioSesion/InicioSesion.aspx');
        }

    }

})