sessionStorage.removeItem('DUser');
var urllogin = '../LoginAjax.aspx'
var urlidiomalogin = '../IdiomaLoginAjax.aspx'





Vue.component('login', {
    props: {
        email: String,
        password: String,
        listaidiomalogin: Object,
        idiomaLogin: "",
        intentos: Number
    },
    template: `

<div class="main-ai" id="alertas">
      <div class="wrap-form-ai">
        <div class="form-block-log-ai w-form">

          <form id="email-form" name="email-form" data-name="Email Form" method="get" class="form-login-ai">
            <label class="txt-login-ai" >{{listaidiomalogin.Usuario}}</label>
            <input type="text" 
            v-on:keyup.enter="ValidUser"
            class="txt-user-log-ai w-input" autofocus="true" maxlength="256" name="name"
            data-name="Name" :placeholder="[[listaidiomalogin.Mail]]" id="email" required="" v-model="email">
            <label class="txt-pass-log-ai" >{{listaidiomalogin.Contrasenna}}</label>

            <input  type="password" oncopy = 'return false' oncut = 'return false' onpaste = 'return false'
            v-on:keyup.enter="ValidUser"
            class="txt-passwrd-ai w-input" autofocus="true" maxlength="256" name="email"
            data-name="Email" :placeholder="[[listaidiomalogin.Contrasenna]]"
           id="password" v-model="password" required="">

            <input type="button"

             v-on:click="ValidUser()" v-model="listaidiomalogin.BtnInicio"
           data-wait="Please wait..." class="btn-login-ai w-button">
            <div class="login-cols-ai w-row">
              <div class="col-log-paswrd-ai w-col w-col-8">
                <a href="/Contrasenna/OlvidoContrasenna.aspx" class="p-get-password-ai" >{{listaidiomalogin.OlvCon}}</a>
              </div>
              <div class="col-log-reg-ai w-col w-col-4">
                <a href="/RegistroUsuarioEmpresas/RegistroUsuariosEmpresas.aspx" class="p-register-ai">{{listaidiomalogin.Sucribete}}</a>
              </div>
            </div>
          </form>
             </div>
      </div>
    </div>
        `,
    methods: {


        ValidUser: async function () {
            var self = this;
            if (this.email != '' && this.password != '') {
                $.post(urllogin, {
                    opciones: 'ValidUsers',
                    Email: this.email,
                    Password: this.password
                }, function (data, error) {

                    if (data == 'EL USUARIO SE ENCUENTRA BLOQUEADO, POR FAVOR DIRIGASE AL LINK DE OlLVIDO DE CONTRASEÑA') {
                        alertas.error(self.listaidiomalogin.Atencion, self.listaidiomalogin.CuaIntento);
                    }
                    else if (data == 'EL USUARIO NO EXITE, POR FAVOR INGRESE UN USUARIO VALIDO') {
                        alertas.error(self.listaidiomalogin.Atencion, self.listaidiomalogin.UsNoExiste);
                    }
                    else if (data == 'USAURIO NO VALIDO, POR FAVOR INTENTELO NUEVAMENTE') {
                        alertas.error(self.listaidiomalogin.Atencion, self.listaidiomalogin.UsNoExiste);
                    }
                    else if (data == 'EL USUARIO SE ENCUENTRA BLOQUEADO POR LLEGAR AL LIMITE DE INTENTOS DE INICIO DE SESION FALLIDOS (MAX 4) DIRIJASE AL LINK DE OLVIDO DE CONTRASEÑA') {
                        alertas.error(self.listaidiomalogin.Atencion, self.listaidiomalogin.CuaIntento);
                    }
                    else if (data != 'ErrorAjax') {
                        var re = 0;
                        let arraydatos;
                        try {

                            arraydatos = JSON.parse(data);

                        } catch {

                            re = 1;

                        }

                        if (re == 0) {

                            sessionStorage.setItem('Empresas', data)
                            sessionStorage.setItem('DUser', data)
                            if (arraydatos.length == 1) {
                                window.location.replace("../Menu/MenuPrincipal.aspx");
                            }
                            else {
                                login.empresas = JSON.parse(sessionStorage.getItem('DUser'));
                                login.AbrirPopPup();                            }
                        }
                        else {
                            if (self.intentos == 3) {
                                alertas.error(self.listaidiomalogin.Atencion, self.listaidiomalogin.UnIntento);
                                self.intentos = self.intentos - 1
                            }
                            else if (self.intentos == 2) {
                                alertas.error(self.listaidiomalogin.Atencion, self.listaidiomalogin.SegIntento);
                                self.intentos = self.intentos - 1
                            }
                            else if (self.intentos == 1) {
                                alertas.error(self.listaidiomalogin.Atencion, self.listaidiomalogin.TerIntento);
                                self.intentos = self.intentos - 1
                            }
                            else {
                                alertas.error(self.listaidiomalogin.Atencion, self.listaidiomalogin.CuaIntento);
                            }
                            return;
                        }
                    }
                    else {
                        sessionStorage.removeItem('DUser');
                        return;
                    }
                        
                });
            } else {
                alertas.error(self.listaidiomalogin.Atencion, self.listaidiomalogin.IngCorr);
            }
        },

        ValidarInicioSesion: function () {

            $.post(urllogin, {
                opciones: 'ValidaLogin',
                Email: this.email
            }, function (respuesta, error) {

                return respuesta;

            });

        },
    }


})

setTimeout(function () {
const login = new Vue({
    el: '#paglogin',
    data: {
        email: "",
        password: "",
        listaidiomalogin: {},
        idiomaLogin: "",
        display: "none",
        empresa: '',
        empresas: [],
        intentos: 3
    },
    mounted: function () {
        var idiLog = "ES"
        if (localStorage.getItem("idiomaApp") != undefined) {
            idiLog = localStorage.getItem("idiomaApp");
        }
        this.idiomaLogin = idiLog;
        this.estableceridiomalogin(this.idiomaLogin);
    },
    methods: {
        estableceridiomalogin: function (tipoIdioma) {
            $.post(urlidiomalogin, {
                idiomaLogin: tipoIdioma,
            }, function (data, error) {
                login.listaidiomalogin = JSON.parse(data);
            });
        }
        ,
        establecerempresa: function () {
            let array = JSON.parse(sessionStorage.getItem('DUser'));
            let empresa = this.empresa;
            array.forEach(function (entry) {
                if (empresa == entry.IdPerfilEmpresa) {
                    var Json = JSON.stringify([{ IdPerfilUsuario: entry.IdPerfilUsuario, Nombre: entry.Nombre, Apellildo: entry.Apellildo, ImagenPerfil: entry.ImagenPerfil, Identificacion: entry.Identificacion, IdPerfilActive: entry.IdPerfilActive, IdPerfilEmpresa: entry.IdPerfilEmpresa, NombreEmpresa: entry.NombreEmpresa, Correo: entry.Correo, TipoUsuario: entry.TipoUsuario}]);
                    sessionStorage.setItem('DUser', Json);

                    window.location.replace("../Menu/MenuPrincipal.aspx");
                }
            });
        },
        AbrirPopPup: function () {
            var a = document.getElementById('PopPupEmpresas');
            a.style.display = 'block';
        },
        CerrarPopPup: function () {
            var a = document.getElementById('PopPupEmpresas');
            a.style.display = 'none';
        },

        OnPaste: function (id) {
            var pass = document.getElementById(id);
            pass.oncopy = function (e) {
                e.preventDefault();
            }
        },

        ValidUser: async function () {
            var self = this;
            if (this.email != '' && this.password != '') {
                $.post(urllogin, {
                    opciones: 'ValidUsers',
                    Email: this.email,
                    Password: this.password
                }, function (data, error) {

                    if (data == 'EL USUARIO SE ENCUENTRA BLOQUEADO, POR FAVOR DIRIGASE AL LINK DE OlLVIDO DE CONTRASEÑA') {
                        alertas.error(self.listaidiomalogin.Atencion, self.listaidiomalogin.CuaIntento);
                    }
                    else if (data == 'EL USUARIO NO EXITE, POR FAVOR INGRESE UN USUARIO VALIDO') {
                        alertas.error(self.listaidiomalogin.Atencion, self.listaidiomalogin.UsNoExiste);
                    }
                    else if (data == 'USAURIO NO VALIDO, POR FAVOR INTENTELO NUEVAMENTE') {
                        alertas.error(self.listaidiomalogin.Atencion, self.listaidiomalogin.UsNoExiste);
                    }
                    else if (data == 'EL USUARIO SE ENCUENTRA BLOQUEADO POR LLEGAR AL LIMITE DE INTENTOS DE INICIO DE SESION FALLIDOS (MAX 4) DIRIJASE AL LINK DE OLVIDO DE CONTRASEÑA') {
                        alertas.error(self.listaidiomalogin.Atencion, self.listaidiomalogin.CuaIntento);
                    }
                    else if (data != 'ErrorAjax') {
                        var re = 0;
                        let arraydatos;
                        try {

                            arraydatos = JSON.parse(data);

                        } catch {

                            re = 1;

                        }

                        if (re == 0) {
                            if (arraydatos.length == 1) {
                                if (arraydatos[0].Verificacion == 0) {
                                    window.location.replace("../RegistroUsuarioEmpresas/ValidarCuenta.aspx");
                                } else {
                                    sessionStorage.setItem('Empresas', data)
                                    sessionStorage.setItem('DUser', data)
                                    window.location.replace("../Menu/MenuPrincipal.aspx");
                                }
                                
                            }
                            else {
                                sessionStorage.setItem('Empresas', data)
                                sessionStorage.setItem('DUser', data)
                                login.empresas = JSON.parse(sessionStorage.getItem('DUser'));
                                login.AbrirPopPup();

                            }
                        } else {
                            if (self.intentos == 3) {
                                alertas.error(self.listaidiomalogin.Atencion, self.listaidiomalogin.UnIntento);
                                self.intentos = self.intentos - 1
                            }
                            else if (self.intentos == 2) {
                                alertas.error(self.listaidiomalogin.Atencion, self.listaidiomalogin.SegIntento);
                                self.intentos = self.intentos - 1
                            }
                            else if (self.intentos == 1) {
                                alertas.error(self.listaidiomalogin.Atencion, self.listaidiomalogin.TerIntento);
                                self.intentos = self.intentos - 1
                            } else {
                                console.log(self.intentos);
                                alertas.error(self.listaidiomalogin.Atencion, self.listaidiomalogin.CuaIntento);
                            }
                            return;
                        }
                    }
                    else {
                        sessionStorage.removeItem('DUser');
                        return;
                    }

                });
            } else {
                alertas.error(self.listaidiomalogin.Atencion, self.listaidiomalogin.IngCorr);
            }
        },

        ValidarInicioSesion: function () {

            $.post(urllogin, {
                opciones: 'ValidaLogin',
                Email: this.email
            }, function (respuesta, error) {

                return respuesta;

            });

        },

    },
    watch: {
        empresas(val) {
            if (val) {
                var a = document.getElementById('PopPupEmpresas');
                a.style.display("block");
            }
        }
    }
})
}, 650)