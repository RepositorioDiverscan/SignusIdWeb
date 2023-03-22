sessionStorage.removeItem("DatosActivoEditar");
var url = 'MenuPrincipalAjax.aspx'
var urlfuncmenu = 'FuncionesMenuPrincipalAjax.aspx'



    const app = new Vue({
        el: '#prinApp',
        data: {
            listaidioma: {},
            idioma: "",
            listaConfig: {},

            btnRegistroGestionActivos: false,
            btnSincronizarActivos: false,
            btnTomasFisicas: false,
            btnPerfil: false,
            btnReportes: false,
            btnTienda: true,
            btnUbicaciones: false,
            btnGestionServicio: false,
            btnRolesPermisos: false,
            btnUsuarios: false,
            btnEmpleados: false,
            btnRFID: false,
            btnDashBoard: false,
            tipoUsuario: '',
            linkPerfil: '',
            tomasVencidas: 0,
            tomasCompletas: 0,
            tomasPendientes: 0,
            totalIncidentes: 0,
            tomasIncompletas: 0,
            usuario: []
        },
        mounted: function () {
            this.ValidarSesion();
            this.usuario = JSON.parse(sessionStorage.getItem('DUser'));
            this.ActualizarTomas();
            this.ConsultarTomasFisicasVencidas();
            this.listaidioma = this.ObtenerIdioma();
            let json = JSON.parse(sessionStorage.getItem('DUser'));
            this.ConsultarIncidentes();
            this.tipoUsuario = json[0].TipoUsuario;
            this.obtenerconfiguracionperfil(json[0].IdPerfilActive, json[0].IdPerfilEmpresa);

        },
        methods: {
            ObtenerIdioma: function () {
                var idi = "ES"
                if (localStorage.getItem("idiomaApp") != undefined) {
                    idi = localStorage.getItem("idiomaApp");
                }
                this.EstablecerIdioma(idi);
            },

            EstablecerIdioma: function (idioma) {
                var self = this
                $.post(url, {
                    idiomaMenu: idioma,
                }, function (data, error) {
                    self.listaidioma = JSON.parse(data);
                });
            },

            obtenerconfiguracionperfil: function (idPerfilActive, idPerfilEmpresa) {
                var self = this;
                $.post(urlfuncmenu, {
                    configMenu: "ObtenerConfiguracionPerfil",
                    idPerfilActive: idPerfilActive,
                    idPerfilEmpresa: idPerfilEmpresa
                }, function (data, error) {
                    app.listaConfig = JSON.parse(data);
                    sessionStorage.setItem('DConfig', data);

                    if (data == "Error Ajax") {
                        window.location.replace("../Login/Login.aspx");
                    }
                    if (app.listaConfig.IdPerfilActive > 0 || app.listaConfig.IdPerfilActive != "") {



                        if (app.listaConfig.CofPerfil) {
                            app.btnPerfil = true;
                            var s = document.getElementById('lnkPerfil');
                            s.href = '../Perfil/PerfilUsuario.aspx';
                            if (self.tipoUsuario == 1) {
                                s.href = '../PerfilEmpresa/PerfilEmpresa.aspx';
                            }



                        }

                        if (app.listaConfig.CofRegistroGestionActivos) {
                            app.btnRegistroGestionActivos = true;

                        }

                        if (app.listaConfig.CofSincronizarActivos) {
                            app.btnSincronizarActivos = true;

                        }

                        if (app.listaConfig.CofTomasFisicas) {
                            app.btnTomasFisicas = true;

                        }

                        if (app.listaConfig.CofReportes) {
                            app.btnReportes = true;
                        }

                        if (app.listaConfig.CofTienda) {
                            app.btnTienda = true;
                        } else {
                            app.btnTienda = false;
                        }

                        if (app.listaConfig.CofUbicaciones) {
                            app.btnUbicaciones = true;

                        }

                        if (app.listaConfig.CofGestionServicio) {
                            app.btnGestionServicio = true;

                        }

                        if (app.listaConfig.CofRolesPermisos) {
                            app.btnRolesPermisos = true;

                        }

                        if (app.listaConfig.CofUsuarios) {
                            app.btnUsuarios = true;

                        }

                        if (app.listaConfig.CofEmpleados) {
                            app.btnEmpleados = true;

                        }

                        if (app.listaConfig.CofRFID) {
                            app.btnRFID = true;

                        }

                        if (app.listaConfig.CofDashBoard) {
                            app.btnDashBoard = true;

                        }



                    } else {
                        window.location.replace("../Login/Login.aspx");
                    }

                });
            },

            ValidarSesion: function () {
                let json = JSON.parse(sessionStorage.getItem('DUser'));

                if (json == null) {
                    window.location.href = window.location.origin + "/AccesoDenegado.aspx";
                }
                else {
                    this.obtenerconfiguracionperfil(json[0].IdPerfilActive, json[0].IdPerfilEmpresa);
                }
            },

            ConsultarTomasFisicasVencidas: function (idioma) {
                var self = this;
                var usuario = JSON.parse(sessionStorage.getItem('DUser'));
                $.post(urlfuncmenu, {
                    configMenu: "ObtenerTomasVencidas",
                    IdPerfilActive: usuario[0].IdPerfilActive,
                }, function (data, error) {
                    self.tomasVencidas = JSON.parse(data);
                    self.ConsultarTomasFisicasCompletas();
                });
            },

            ConsultarTomasFisicasCompletas: function () {
                var self = this;
                var usuario = JSON.parse(sessionStorage.getItem('DUser'));
                $.post(urlfuncmenu, {
                    configMenu: "ObtenerTomasCompletas",
                    IdPerfilActive: usuario[0].IdPerfilActive,
                }, function (data, error) {
                    self.tomasCompletas = JSON.parse(data);
                    self.ConsultarTomasFisicasPendientes();
                });
            },

            ConsultarTomasFisicasPendientes: function () {
                var self = this;
                var usuario = JSON.parse(sessionStorage.getItem('DUser'));
                $.post(urlfuncmenu, {
                    configMenu: "ObtenerTomasPendientes",
                    IdPerfilActive: usuario[0].IdPerfilActive
                }, function (data, error) {
                    self.tomasPendientes = JSON.parse(data);
                    self.ConsultarTomasFisicasIncompletas();
                });
            },

            ConsultarTomasFisicasIncompletas: function () {
                var self = this;
                var usuario = JSON.parse(sessionStorage.getItem('DUser'));
                $.post(urlfuncmenu, {
                    configMenu: "ObtenerTomasIncompletas",
                    IdPerfilActive: usuario[0].IdPerfilActive
                }, function (data, error) {
                    self.tomasIncompletas = JSON.parse(data);
                    self.LlenarGrafica();
                });
            },

            LlenarGrafica: function () {
                var self = this;
                const ctx = document.getElementById('myChart').getContext('2d');
                const myChart = new Chart(ctx, {
                    type: 'pie',
                    data: {
                        datasets: [{
                            label: '# of Votes',
                            data: [self.tomasVencidas, self.tomasCompletas, self.tomasPendientes],
                            backgroundColor: [
                                'rgba(212, 108, 20)',
                                'rgba(68, 68, 68)',
                                'rgba(244, 204, 68)'
                            ],
                            borderColor: [
                                'rgba(249, 243, 220)',
                                'rgba(249, 243, 220)',
                                'rgba(249, 243, 220)'
                            ],
                            borderWidth: 2
                        }]
                    },
                    options: {

                    }
                });
            },

            ConsultarIncidentes: function () {
                var self = this;
                var usuario = JSON.parse(sessionStorage.getItem('DUser'));
                $.post(urlfuncmenu, {
                    configMenu: "ConsultarIncidentes",
                    IdPerfilActive: usuario[0].IdPerfilActive,

                }, function (res, error) {
                    var total = res;
                    self.totalIncidentes = total;
                    
                });


            },



            ActualizarTomas: function () {
                var self = this;
                $.post(urlfuncmenu, {
                    configMenu: "ActualizarTomas",
                }, function (res, error) {
                    var respuesta = JSON.parse(res);
                    if (respuesta != "") {
                    }
                });
            },


        }
    })












