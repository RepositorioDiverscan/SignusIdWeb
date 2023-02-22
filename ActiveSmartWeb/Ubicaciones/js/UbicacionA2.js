var urlIdioma = 'IdiomaUbicacionAjax.aspx'
var urlUbicacion = "UbicacionA/UbicacionAjax.aspx"

const Empleados = new Vue({
    el: '#UbicacionAVUE',
    data: {
            listaidiomalubicacion: [],
            nombre: '',
            descripcion: '',
            idUbicacionA: '',
            idiomaubicacion: "",
            listaiubicaciones: [],
            idPerfilEmpresa: ''
    },
    mounted: function () {
        var logueado = JSON.parse(sessionStorage.getItem('DUser'));
        this.idPerfilEmpresa = "" + logueado[0].IdPerfilEmpresa;
        listaidiomalubicacion = this.ObtenerIdioma();
        this.ObtenerUbicaciones();
    },
    methods: {
        ObtenerHeaders: function () {
            return JSON.parse('{"headersInfo":["' + this.listaidiomalubicacion.Nombre + '","' + this.listaidiomalubicacion.Descripcion + '"]}')
        },
        Editar: function (info) {
            this.idUbicacionA = info[0]
            this.nombre = info[1]
            this.descripcion = info[2]
        },
        ObtenerIdioma: function () {
            var idiUbicacion = "ES"
            if (localStorage.getItem("idiomaApp") != undefined) {
                idiUbicacion = localStorage.getItem("idiomaApp");
            }
            this.idiomaLogin = idiUbicacion;
            this.EstablecerIdiomaUbicacion(idiUbicacion);
        },
        EstablecerIdiomaUbicacion: function (idioma) {
            var self = this
            $.post(urlIdioma, {
                idiomaUbicacion: idioma,
            }, function (data, error) {
                self.listaidiomalubicacion = JSON.parse(data);
            });
        },
        ObtenerUbicaciones: function () {
            var self = this
            $.post(urlUbicacion, {
                option: 'ConsultarUbicaciones',
                IdPerfilEmpresa: self.idPerfilEmpresa
            }, function (respuesta, error) {
                var resp = JSON.parse(respuesta);
                self.listaiubicaciones = [];
                for (let i = 0; i < resp.length; i += 1) {
                    self.listaiubicaciones.push([resp[i].IdUbicacionA, resp[i].Nombre, resp[i].Descripcion]);
                }
            });
        },

        GuardarUbicacion: function () {
            if (this.nombre == '') {
                alertify.error(this.listaidiomalubicacion.ErrorNombre);
                return
            }
            if (this.idUbicacionA != '') {
                this.ActualizarUbicacion();
                return;
            }
            var self = this;
            $.post(urlUbicacion, {
                option: 'InsertarUbicacion',
                Nombre: self.nombre,
                Descripcion: self.descripcion,
                IdPerfilEmpresa: self.idPerfilEmpresa
            }, function (respuesta, error) {
                if (respuesta == "Registrado") {
                    self.nombre = '';
                    self.descripcion = '';
                    self.idUbicacionA = '';
                    alertify.success(self.listaidiomalubicacion.InsertarCorrecto);
                    self.ObtenerUbicaciones();
                } else {
                    alertify.error(self.listaidiomalubicacion.InsertarError);
                }
            });
        },

        LimpiarUbicacion: function () {
            this.nombre = "";
            this.descripcion = "";
            this.idUbicacionA = '';
        },
        ActualizarUbicacion: function () {
            this.ObtenerUbicaciones();
            var self = this
            $.post(urlUbicacion, {
                option: 'ActualizaUbicacion',
                Nombre: this.nombre,
                Descripcion: this.descripcion,
                IdUbicacionA: this.idUbicacionA
            }, function (respuesta, error) {
                if (respuesta == "Actualizado") {

                    self.nombre = '';
                    self.descripcion = '';
                    self.idUbicacionA = '';
                    alertify.success(self.listaidiomalubicacion.ActualizaCorrecto);
                    self.ObtenerUbicaciones();
                } else {
                    alertify.error(self.listaidiomalubicacion.ActualizaError);
                }
            });
        },

        ObtenerBotones: function () {
            let botones = []
            botones.push([this.Editar, '../images/editar.svg']);
            return botones;
        }
    }
})
