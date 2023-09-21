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
        idPerfilEmpresa: '',
        elementosXPagina: 50,
        paginas: 0,
        datosPaginados: [],
        paginaActual: 1,
    },
    mounted: function () {
        this.ValidarSesion();
        var logueado = JSON.parse(sessionStorage.getItem('DUser'));
        this.idPerfilEmpresa = "" + logueado[0].IdPerfilEmpresa;
        this.listaidiomalubicacion = this.ObtenerIdioma();
        this.listaiubicaciones = this.ObtenerUbicaciones();
    },
    methods: {

        //Función para cargar la informacion de la ubicación a editar
        Editar: function (id, nombre, descripcion) {
            this.idUbicacionA = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
        },

        ObtenerIdioma: function () {
            var idiUbicacion = "ES"
            if (localStorage.getItem("idiomaApp") != undefined) {
                idiUbicacion = localStorage.getItem("idiomaApp");
            }
            this.EstablecerIdiomaUbicacion(idiUbicacion);
        },

        EstablecerIdiomaUbicacion: function (idioma) {
            var self = this
            $.post(urlIdioma, {
                idi: idioma,
            }, function (data, error) {
                self.listaidiomalubicacion = JSON.parse(data);


            });
        },

        //Carga las ubicaciones
        ObtenerUbicaciones: function () {
            var self = this
            $.post(urlUbicacion, {
                option: 'ConsultarUbicaciones',
                IdPerfilEmpresa: self.idPerfilEmpresa
            }, function (respuesta, error) {
                var resp = JSON.parse(respuesta);
                self.listaiubicaciones = resp;
                self.CantidadRegistros();
            });
        },

        //Función para insertar la informacion de la ubicacion
        GuardarUbicacion: function () {
            if (this.nombre == '') {
                alertas.error(this.listaidiomalubicacion.Atencion, this.listaidiomalubicacion.ErrorNombre);
                return
            }
            if (this.descripcion == '') {
                alertas.error(this.listaidiomalubicacion.Atencion, this.listaidiomalubicacion.InsertarError);
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
                    alertas.success(self.listaidiomalubicacion.Atencion, self.listaidiomalubicacion.InsertarCorrecto);
                   
                    self.ObtenerUbicaciones();
                  
                } else {
                    //alertify.error(self.listaidiomalubicacion.InsertarError);
                    alertas.error(self.listaidiomalubicacion.Atencion, respuesta);
                    Swal.fire('¿Está seguro que desea guardar esta ubicación?')


                }
            });
        },

        //Limpia los campos de las ubicaciones
        LimpiarUbicacion: function () {
            this.nombre = "";
            this.descripcion = "";
            this.idUbicacionA = '';
        },

        //Funcióm para actualizar la ubicación
        ActualizarUbicacion: function () {
            this.ObtenerUbicaciones();
            var self = this
            $.post(urlUbicacion, {
                option: 'ActualizaUbicacion',
                Nombre: this.nombre,
                Descripcion: this.descripcion,
                IdUbicacionA: this.idUbicacionA
                 
            }, function (respuesta, error) 
             
            {
                if (respuesta == "Actualizado") {

                    self.nombre = '';
                    self.descripcion = '';
                    self.idUbicacionA = '';
                    alertas.success(self.listaidiomalubicacion.Atencion, self.listaidiomalubicacion.ActualizaCorrecto);
                    self.ObtenerUbicaciones();
                } else {
                    alertas.error(self.listaidiomalubicacion.Atencion, self.listaidiomalubicacion.ActualizaError);
                }
            });
        },

        /// Funcion para calcular la cantidad de paginas
        CantidadRegistros: function () {

            this.paginas = Math.ceil(this.listaiubicaciones.length / this.elementosXPagina);
            this.ObtenerDataTabla(1);

        },

        // Funcion para divir los datos para mostrarlos en la tabla
        ObtenerDataTabla(noPagina) {
            this.datosPaginados = [];
            let inicio = (noPagina * this.elementosXPagina) - this.elementosXPagina;
            let fin = (noPagina * this.elementosXPagina);
            this.datosPaginados = this.listaiubicaciones.slice(inicio, fin);
        },

        // Funcion para regresar a la pagina anterior
        PaginaAnterior() {
            if (this.paginaActual > 1) {
                this.paginaActual--;
            }
            this.ObtenerDataTabla(this.paginaActual)
        },

        // Funcion para saltar a la siguiente pagina
        PaginaSiguiente() {
            if (this.paginaActual < this.paginas) {
                this.paginaActual++;
            }
            this.ObtenerDataTabla(this.paginaActual)
        },

        ValidarSesion: function () {

            var dConfig = JSON.parse(sessionStorage.getItem('DConfig'));

            if (dConfig == null || dConfig.CofUbicaciones == false) {
                window.location.href = window.location.origin + "/AccesoDenegado.aspx";
            }
        },
    }
})
