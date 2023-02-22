var urlAjax = 'PasswordAJAX.aspx'
var urlIdioma = 'IdiomaCambioAJAX.aspx'

const urlCorreo = new URLSearchParams(window.location.search);
const CorreoURL = urlCorreo.get("CO");
const LinkUrl = urlCorreo.get("LI");

const cambioPassword = new Vue({
    el: '#context1',
    data: {
        listaIdiomas: [],
        Idioma11: '',
        password: '',
        confirmPassword:'',
        IdPefil_Empresa: '',
        IdPerfilU: '',
        correoUsuario: '',
        esconderPass: false,
    },
    mounted: function () {
        listaIdiomas = this.ObtenerIdioma();
        if (sessionStorage.getItem('DUser') != undefined) {
            var usuarioSesion = JSON.parse(sessionStorage.getItem('DUser'));
            this.IdPerfilU = usuarioSesion[0].IdPerfilUsuario;
            this.correoUsuario = usuarioSesion[0].Correo;
           

        } else {
            this.ValidarLink();
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

                //Delay 5 segundos
                setInterval(function () {
                    self.ActualizarLink();
                }, 5000);

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

        ValidarLink: function () {
            var self = this;

            $.post(urlAjax, {
                option: 'validarLink',
                Codigolink: LinkUrl,
            }, function (data, error) {

                if (data != 1) {

                    self.ObtenerInformacionUsuario();

                } else {
                    window.location.replace("../AccesoDenegado.aspx");
                }

            });

        },

        ActualizarLink: function () {

            $.post(urlAjax, {
                option: 'ActualizarLink',
                Codigolink: LinkUrl,
            }, function (data, error) {

                window.location.href = "../Login.aspx";

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

                    if (respuesta == "Atención! La contraseña debe de tener una longitud entre 8-50 caracteres") {
                        var a = document.getElementById("advCon");
                        a.style.display = 'block';
                        alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorLargoOp);
                    }
                    else if (respuesta == "Atención! La contraseña debe de tener una longitud entre 10-50 caracteres") {
                        var a = document.getElementById("advCon");
                        a.style.display = 'block';
                        alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorLargoAd);
                    } else if (respuesta == "Atención! La contraseña debe  contener mínimo un número") {
                        alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorNumero);
                        var a = document.getElementById("advCon");
                        a.style.display = 'block';
                        document.getElementById('PswPrincipal').focus();
                    } else if (respuesta == "Atención! La contraseña debe de tener contener mínimo un carácter especial") {
                        alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorCaracterEspecial);
                        var a = document.getElementById("advCon");
                        a.style.display = 'block';
                        document.getElementById('PswPrincipal').focus();
                    } else if (respuesta == "Atención! La contraseña debe  contener mayúsculas" || respuesta == "Atención! La contraseña debe  contener minúsculas") {
                        alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorLetraMayusMinus);
                        var a = document.getElementById("advCon");
                        a.style.display = 'block';
                        document.getElementById('PswPrincipal').focus();
                    } else if (respuesta == "Atención! La contraseña no puede ser igual a ninguna de las anteriores") {
                        alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.NingunaIgual);
                        var a = document.getElementById("advCon");
                        a.style.display = 'block';
                    } else {
                        self.Cambiar();
                    }
                });
            } else {
                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorNoCoinciden);
                document.getElementById('PswConfirm').focus();
            }
           
        },

        OcultarMostrarContrasenna: function () {

            var self = this;
            var tip1 = document.getElementById('tippy1');
            var tip2 = document.getElementById('tippy2');
            var pass = document.getElementById('password')

            if (self.esconderPass == false) {
                tip1.style.display = "none";
                tip2.style.display = "block";
                pass.type = 'text';
                self.esconderPass = true;
            } else {
                tip1.style.display = "block";
                tip2.style.display = "none";
                pass.type = 'password';
                self.esconderPass = false;
            }


        },
       
        
    }

})