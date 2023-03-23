var urlIdioma = 'Encabezado/IdiomaTomaFisicaAjax.aspx'
var urlTomaFisica = 'Encabezado/TomaFisicaAjax.aspx'
var urlCategoria = '../CategoriaActivo/Categoria/CategoriaActivo.aspx'
var urlUbicacion = '../Ubicaciones/UbicacionA/UbicacionAjax.aspx'
var urlUsuarios = '../GestionServicio/AjaxGestionServicio.aspx'


// CREA LA TOMA

const UbicacionesB = new Vue({
    el: '#toma',
    data: {
        // VARIABLES NECESARIA
        Listaidiomas: [],
        ListaUsuarios: [],
        ListaUbicaciones: [],
        nombre: '',
        descripcion: '',
        idTomaFisica: '-1',
        idPerfilActive: '',
        fechaInicial: '',
        fechaFinal: '',
        fechaHoy: '',
        Categorias: Object,
        IdCategoria: '-1',
        cantidadActios: '',
        nombreUsuario: '',
        listaUbicaciones: '',
        select_Usuarios: -1,
        select_UbicacionA: -1,
        select_Categorias: -1,
        idPerfilEmpresa: '',
    },


    mounted: function () {
        this.ValidarSesion();
        var logueado = JSON.parse(sessionStorage.getItem('DUser'));
        this.idPerfilActive = "" + logueado[0].IdPerfilActive;
        this.idPerfilEmpresa = "" + logueado[0].IdPerfilEmpresa;
        Listaidiomas = this.ObtenerIdioma();
        ListaUsuarios = this.ObtenerUsuarios();
        this.ObtenerCategorias();
        this.TiempoTranscurrido();
        this.ConsultaIdToma();
        this.ObtenerUbicaciones();
       
    },
    methods: {
        ObtenerIdioma: function () {
            var idiToma = "ES"
            if (localStorage.getItem("idiomaApp") != undefined) {
                idiToma = localStorage.getItem("idiomaApp");
            }
            this.EstablecerIdiomaTomaFisica(idiToma);
        },
        EstablecerIdiomaTomaFisica: function (idioma) {
            var self = this
            $.post(urlIdioma, {
                idiomaTomaFisica: idioma,
            }, function (data, error) {
                self.Listaidiomas = JSON.parse(data);

            });
        },
        GuardarTomaFisica: function () {
            var self = this;
            if (this.nombre == "") {
                alertas.error(this.Listaidiomas.Atencion, this.Listaidiomas.ValidNombre);
                return
            }
            else if (this.fechaInicial > this.fechaFinal) {
                alertas.error(this.Listaidiomas.Atencion, this.Listaidiomas.Errorfechas);
                return
            }
            else if (this.select_Categorias == -1) {
                alertas.error(this.Listaidiomas.Atencion, this.Listaidiomas.ValidSelCat);
                return
            }
            else if (this.select_Usuarios == -1) {
                alertas.error(this.Listaidiomas.Atencion, this.Listaidiomas.ValidSelUsu);
                return
            }
            else if (this.select_UbicacionA == -1) {
                alertas.error(this.Listaidiomas.Atencion, this.Listaidiomas.ValidSelUbi);
                return
            }
            if (self.idTomaFisica == "-1") {

                $.post(urlTomaFisica, {
                    option: 'InsertarTomaFisica',
                    Nombre: self.nombre,
                    Descripcion: self.descripcion,
                    FechaInicial: self.fechaInicial,
                    FechaFinal: self.fechaFinal,
                    IdPerfilActive: self.idPerfilActive,
                    IdUsuarioAsignado: self.select_Usuarios,
                    IdCategoriaActivo: self.select_Categorias,
                    IdUbicacionA: self.select_UbicacionA,


                }, function (respuesta, error) {
                    if (respuesta == "Registrado") {
                        self.nombre = '';
                        self.descripcion = '';
                        self.idTomaFisica = '-1';
                        self.fechaInicial = '';
                        self.fechaFinal = '';
                        self.IdPerfilActive = '';
                        self.IdCategoria = '';
                        self.select_Categorias = -1;
                        self.select_Usuarios = -1;
                        self.select_UbicacionA = -1;
                        alertas.success(self.Listaidiomas.Atencion, self.Listaidiomas.RegistroE);
                        // self.ObtenerTomasFisicasEncabezado();

                    }
                    else {
                        alertas.error(self.Listaidiomas.Atencion, self.Listaidiomas.ErrorAgreg);
                    }
                });
            }
            else {
                self.EditarTomaFisicaEncabezado();
            }
   
        },
        ObtenerTomasFisicasEncabezado: function () {
            var self = this
            $.post(urlEncabezado, {
                option: 'ConsultaTomaFisica',
                IdPerfilActive: self.IdPerfilActive
            }, function (respuesta, error) {
                var resp = JSON.parse(respuesta);
                self.listaTomasEncabezado = [];
                for (let i = 0; i < resp.length; i += 1) {
                    self.listaTomasEncabezado.push([resp[i].IdTomaFisica,
                        resp[i].Nombre, resp[i].Descripcion, resp[i].FechaInicial,
                        resp[i].FechaFinal, resp[i].NombreCategoria]);
                }
            });

        },
        EditarTomaFisicaEncabezado: function () {
            var self = this;
            $.post(urlTomaFisica, {
                option: 'ActualizarTomaFisica',
                IdTomaFisica: self.idTomaFisica,
                NombreToma: self.nombre,
                DescripcionToma: self.descripcion,
                FechaInicialToma: self.fechaInicial,
                FechaFinalToma: self.fechaFinal,
                IdCategoriaToma: this.select_Categorias,
                UsuarioAsignado: this.select_Usuarios,
                Ubicacion: this.select_UbicacionA

                
            }, function (respuesta, error) {
                if (respuesta == "Actualizado") {
                    self.nombre = '';
                    self.descripcion = '';
                    self.idTomaFisica = '';
                    self.fechaInicial = '';
                    self.fechaFinal = '';
                    self.IdPerfilActive = '';
                    self.IdCategoria = '';
                    self.select_Categorias = -1;
                    self.select_Usuarios = -1;
                    self.select_UbicacionA = -1;
                    self.idTomaFisica = '';
                    alertas.success(self.Listaidiomas.Atencion, self.Listaidiomas.ActualizaE);
                    sessionStorage.removeItem('DatosToma');
                }
                else {
                    alertas.error(self.Listaidiomas.Atencion, self.Listaidiomas.ErrorActual);
                }
            });

        },
        ObtenerCategorias: function () {
            var self = this
            $.post(urlCategoria, {
                option: 'ConsultaCategoriaActivo',
            }, function (data, error) {
                self.Categorias = JSON.parse(data);

            });
        },
        ObtenerUsuarios: function () {
            var self = this
            $.post(urlUsuarios, {
                opciones: 'ObtenerUsuarioPorIdEmpresa',
                IdPerfilEmpresa: self.idPerfilEmpresa
            }, function (data, error) {
                self.ListaUsuarios = JSON.parse(data);

            });
        },
        TiempoTranscurrido: function () {

            var tiempoTranscurrido = Date.now();
            var actual = new Date(tiempoTranscurrido);
            var mes = actual.getMonth() + 1;
            if (mes < 10) {
                mes = '0' + mes;
            }
            var dia = actual.getDate().toString();
            if (dia < 10) {
                dia = '0' + dia;
            }
            var anno = actual.getFullYear().toString();
            this.fechaInicial = anno + "-" + mes + "-" + dia;
            this.fechaFinal = anno + "-" + mes + "-" + dia;
            this.fechaHoy = anno + "-" + mes + "-" + dia;
        },
        ValidarFechaInicial: function () {

            var self = this
            if (self.fechaInicial > self.fechaHoy) {
                self.fechaInicial = self.fechaHoy
            }

        },


        ConsultaIdToma: function () {
            var self = this;
            var datosToma = parseInt(sessionStorage.getItem("DatosToma"));
            if (!isNaN(datosToma)) {
                self.idTomaFisica = datosToma;

                $.post(urlTomaFisica, {
                    option: 'ConsultaIDTomaFisica',
                    IdTomaFisicaI: self.idTomaFisica
                }, function (respuesta, error) {

                    var resp = JSON.parse(respuesta);
                    self.listaTomasEncabezado = [];
                    for (let i = 0; i < resp.length; i += 1) {
                        self.nombre = resp[i].Nombre;
                        self.descripcion = resp[i].Descripcion;
                        self.fechaInicial = resp[i].FechaInicial.split('T')[0];
                        self.fechaFinal = resp[i].FechaFinal.split('T')[0];
                        self.IdCategoria = resp[i].Categoria;
                        self.select_Categorias = resp[i].Categoria;
                        self.select_Usuarios = resp[i].UsuarioAsignado;
                        self.select_UbicacionA = resp[i].IdUbicacion;
                    }

                });

            }
        },
        ObtenerUbicaciones: function () {
            var self = this
            $.post(urlUbicacion, {
                option: 'ConsultarUbicaciones',
                IdPerfilEmpresa: self.idPerfilEmpresa
            }, function (respuesta, error) {
                self.ListaUbicaciones = JSON.parse(respuesta);
               
            });
        },
        ValidarSesion: function () {

            var dConfig = JSON.parse(sessionStorage.getItem('DConfig'));

            if (dConfig == null || dConfig.CofTomasFisicas == false) {
                window.location.href = window.location.origin + "/AccesoDenegado.aspx";
            }
        },
        AbrirDatePicker: function (valor) {
            var inputCalendario = document.getElementById(valor);
            inputCalendario.showPicker();
        },
    }
})
