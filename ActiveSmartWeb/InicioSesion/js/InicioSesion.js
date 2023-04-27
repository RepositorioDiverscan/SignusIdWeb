sessionStorage.removeItem('DUser');
var urllogin = '../LoginAjax.aspx'
var urlidiomalogin = '../IdiomaLoginAjax.aspx'


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
                                    sessionStorage.setItem('NombreEmpresa', arraydatos[0].NombreEmpresa);
                                    sessionStorage.setItem('CorreoEmpresa', arraydatos[0].Correo);
                                    sessionStorage.setItem('NombreUsuario', arraydatos[0].Nombre);
                                    sessionStorage.setItem('ApellidosUsuario', arraydatos[0].Apellidos);
                                    sessionStorage.setItem('CorreoUsuario', arraydatos[0].Correo);
                                    sessionStorage.setItem('IdEmpresa', arraydatos[0].IdPerfilEmpresa);
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
                            if (data == 'Su subscripción se encuentra suspendida' || data == 'Este usuario no posee una subscripcón') {
                                alertas.error(self.listaidiomalogin.Atencion, data);
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
                                } else {
                                    alertas.error(self.listaidiomalogin.Atencion, self.listaidiomalogin.CuaIntento);
                                }
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