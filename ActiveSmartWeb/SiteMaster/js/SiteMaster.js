
var url = '../../AjaxPrincipalMaster/AjaxGeneralMaster.aspx'
var urlPerfil = '../Perfil/AjaxPerfilUsuario.aspx'

    var logueado = JSON.parse(sessionStorage.getItem('DUser'));








    const master = new Vue({
        el: '#main',
        data: {
            options: {},
            idioma: "",
            empresas: [],
            idPerfilEmpresa: '',
            usuario: {},
            imagenPerfil: '',
            idPerfilUsuario: 0,
            IdPerfilActive: 0,

            TotalNotificaciones: 0,
        },
        mounted: function () {
            var idi = "ES"
            if (sessionStorage.getItem('Empresas') != undefined) {
                this.empresas = JSON.parse(sessionStorage.getItem('Empresas'));

                let jsonDUser = JSON.parse(sessionStorage.getItem('DUser'));
                this.idPerfilEmpresa = jsonDUser[0].IdPerfilEmpresa
            }
            if (localStorage.getItem("idiomaApp") != undefined) {
                idi = localStorage.getItem("idiomaApp");
            }
            var logueado = JSON.parse(sessionStorage.getItem('DUser'));
            this.IdPerfilActive = logueado[0].IdPerfilActive;
            this.idioma = idi;
            this.idiomas(this.idioma);
            this.ObtenerDatosUsuario();
            this.cargarImagen();
            this.ConsultarNotificaciones();
            this.SesionExpirada();
            this.RecargarNotificaciones();
            //this.Loading();
        },
        methods: {
            idiomas: function (tipoIdioma) {
                $.post(url, {
                    idiomaMenuGeneral: tipoIdioma,
                }, function (data, error) {
                    master.options = JSON.parse(data);
                });
            },

            establecerempresa: function () {
                var self = this;
                this.empresas.forEach(function (entry) {
                    if (self.idPerfilEmpresa == entry.IdPerfilEmpresa) {
                        var Json = JSON.stringify([{ IdPerfilUsuario: entry.IdPerfilUsuario, Nombre: entry.Nombre, Apellildo: entry.Apellildo, ImagenPerfil: entry.ImagenPerfil, Identificacion: entry.Identificacion, IdPerfilActive: entry.IdPerfilActive, IdPerfilEmpresa: entry.IdPerfilEmpresa, NombreEmpresa: entry.NombreEmpresa }]);
                        sessionStorage.setItem('DUser', Json);
                        window.location.replace("../Menu/MenuPrincipal.aspx");
                    }
                });
            },

            cargarImagen: function () {
                var self = this;

                self.imagenPerfil = ''

                $.post(urlPerfil, {

                    opciones: "BuscarImagen",
                    IdUsuario: self.idPerfilUsuario,

                }, function (res, error) {
                    var img = JSON.parse(res);
                    self.imagenPerfil = img;

                });


            },

            ConsultarNotificaciones: function () {
                var self = this;


                $.post(urlPerfil, {

                    opciones: "ConsultarNotificaciones",
                    IdPerfilActive: self.IdPerfilActive,

                }, function (res, error) {
                    var total = JSON.parse(res);
                    self.TotalNotificaciones = total;

                });


            },

            ObtenerDatosUsuario: function () {

                let json = JSON.parse(sessionStorage.getItem('DUser'));
                this.datosUsuario = json;
                this.idPerfilUsuario = json[0].IdPerfilUsuario;
                this.imagenPerfil = json[0].ImagenPerfil;
            },

            RecargarNotificaciones: function () {
                var self = this;

                setInterval(function () {
                    self.ConsultarNotificaciones();
                }, 3000);
            },

            CerrarSesion: function () {
                sessionStorage.setItem('DUser', '');
                sessionStorage.setItem('DConfig', '');
                sessionStorage.setItem('Empresas', '');
            },

            //Espera 10 minutos y expira 
            SesionExpirada: function () {
                var self = this;
                setInterval(function () {
                    self.Expirar();
                }, 600000)
            },

            Expirar: function () {
                var self = this;
                self.CerrarSesion();
                window.location.href = window.location.origin + "/SessionExpirada.aspx";
            },

            Loading: function () {
                $(window).on('load', function () {
                    setTimeout(function () {
                        $(".loader-page").css({ visibility: "hidden", opacity: "0" })
                    }, 850);

                });
            }

        }, watch: {
            idioma(val) {
                if (val)
                    localStorage.setItem("idiomaApp", val);
                this.idiomas(localStorage.getItem("idiomaApp"));
            },
            TotalNotificaciones(val) {
                var divNot = document.getElementById('notificaciones');
                if (val > 0) {
                    divNot.setAttribute("style", "display:flex")
                }
                else {
                    divNot.setAttribute("style", "display:none")
                }
            }
        },


    })



    //Footer
    const master2 = new Vue({
        el: '#main2',
        data: {
            options: {},
            idioma: "",
            DUser: "",
            usuario: {}
        },
        mounted: function () {
            var idi = "ES"
            if (sessionStorage.getItem('DUser') != undefined) {
                DUser = JSON.parse(sessionStorage.getItem('DUser'));
            }
            if (localStorage.getItem("idiomaApp") != undefined) {
                idi = localStorage.getItem("idiomaApp");
            }
            this.idioma = idi;
            this.idiomas(this.idioma)
            //master.usuario = JSON.parse(sessionStorage.getItem('DUser'));
        },
        methods: {
            idiomas: function (tipoIdioma) {
                $.post(url, {
                    idiomaMenuGeneral: tipoIdioma,
                }, function (data, error) {
                    master2.options = JSON.parse(data);



                });
            },

            abrirPopUpTC: function () {
                var a = document.getElementById("popupTC");
                a.style.display = "block";
            },

            cerrarPopUpTC: function () {
                var a = document.getElementById("popupTC");
                a.style.display = "none";
            }

        },
        watch: {
            idioma(val) {
                if (val)
                    localStorage.setItem("idiomaApp", val);
                this.idiomas(localStorage.getItem("idiomaApp"));
            }
        }

    })


    document.getElementById("refrescaridioma").addEventListener("change", function () {
        location.reload();
    });










