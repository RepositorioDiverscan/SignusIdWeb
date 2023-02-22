var urlAjax = 'PasswordAJAX.aspx'
var urlIdioma = 'IdiomaCambioAJAX.aspx'

const urlCorreo = new URLSearchParams(window.location.search);
const CorreoURL = urlCorreo.get("CO");

const cambioPassword = new Vue({
    el: '#context',
    data: {
        listaIdiomas: [],
        Idioma11: '',
        password: '',
        confirmPassword:'',
        IdPefil_Empresa: '',
        IdPerfilU: '',
        correoUsuario: '',
    },
    mounted: function () {
        listaIdiomas = this.ObtenerIdioma();
        if (sessionStorage.getItem('DUser') != undefined) {
            var usuarioSesion = JSON.parse(sessionStorage.getItem('DUser'));
            this.IdPerfilU = usuarioSesion[0].IdPerfilUsuario;
            this.correoUsuario = usuarioSesion[0].Correo;
           

        } else {
            this.ObtenerInformacionUsuario();
        }
 
        
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
            });
        },
        // FIN METODOS DE IDIOMA

        // Metodos para cambiar contraseña y validar 

        Cambiar: function () {
            var self = this;
            $.post(urlAjax, {
                option: 'CambiarContrasenna',
                passWPrincipal: self.password,
                IdPerfilUsuario: self.IdPerfilU,
                CorreoUser: self.correoUsuario,
            }, function (respuesta, error) {

                alertas.success(self.listaIdiomas.Atencion, self.listaIdiomas.ContraCambiada);

                    window.location.href = "../Login.aspx";



            });
        },

        ObtenerInformacionUsuario: function () {
            var self = this;
            //CorreoURL
            $.post(urlAjax, {
                option: 'ObtieneUsuarioCorreo',
                correo: CorreoURL,
            }, function (data, error) {
                   var datos = JSON.parse(data)

                    self.correoUsuario = datos.Correo;
                    self.IdPerfilU = datos.IdPerfilUsuario;
            });

        },

        ValidarContrasena: function () {
            var self = this;
            if (self.password == self.confirmPassword) {
                $.post(urlAjax, {
                    option: 'ValidarPassword',
                    passW: self.password,
                    IdPerfilUsuario: self.IdPerfilU,
                }, function (respuesta, error) {

                    if (respuesta == "Atención! La contraseña debe de tener una longitud entre 10-50 caracteres") {
                        alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorLargo);
                        document.getElementById('PswPrincipal').focus();
                    } else if (respuesta == "Atención! La contraseña debe  contener mínimo un número") {
                        alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorNumero);
                        document.getElementById('PswPrincipal').focus();
                    } else if (respuesta == "Atención! La contraseña debe de tener contener mínimo un carácter especial") {
                        alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorCaracterEspecial);
                        document.getElementById('PswPrincipal').focus();
                    } else if (respuesta == "Atención! La contraseña debe  contener mayúsculas" || respuesta == "Atención! La contraseña debe  contener minúsculas") {
                        alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorLetraMayusMinus);
                        document.getElementById('PswPrincipal').focus();
                    } else {
                        self.Cambiar();
                    }
                });
            } else {
                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorNoCoinciden);
                document.getElementById('PswConfirm').focus();
            }
           
        },
       
        
    }

})