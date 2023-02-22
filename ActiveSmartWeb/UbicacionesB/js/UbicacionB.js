var urlidioma = 'IdiomaUbicacionBAjax.aspx'
var urlUbicacion = 'UbicacionBAjax.aspx'

const UbicacionesB = new Vue({
    el: '#maincontext',
    data: {
        // VARIABLES NECESARIA
        Listaidiomas: [],
        IdiomaUbicacionB: '',
        ListaUbicacionesA: [],
        select_UbicacionA: '',
        select_UbicacionB: '',
        ListaUbicacionesB: [],
        Nombre: '',
        Descripcion: '',
        Nombre_Ubicacion: '',
        Descripcion_Ubicacion: '',
        IdPerfil_Empresa: '',
        NombreB: '',
        DescripcionB: '',
        mensaje: '',
        elementosPorPagina: 5,
        paginas: 0,
        datosPaginados: [],
        paginaActual: 1
    },

    mounted: function () {
        var logueado = JSON.parse(sessionStorage.getItem('DUser'));
        this.IdPerfil_Empresa = "" + logueado[0].IdPerfilEmpresa;
        Listaidiomas = this.ObtenerIdioma();
        ListaUbicacionesA = this.CargarUbicacionesALista(this.IdPerfil_Empresa);
        ListaUbicacionesB = this.CargarTabla(this.IdPerfil_Empresa);
    },

    methods: {

        ///Este metodo se encarga de guardar el idioma en una variable de sesion para posteriormente utilizarlo en las paginas
        ObtenerIdioma: function () {
            var idiActualiza = "ES"
            if (localStorage.getItem("idiomaApp") != undefined) {
                idiActualiza = localStorage.getItem("idiomaApp");
            }
            this.EstablecerIdioma(idiActualiza);
        },

        /// Esta funcion nos ayuda a calcular la cantidad de paginas para la paginacion de la tabla , se toma en cuenta la cantidad de filas que queremos por pagina y el total de los registros
        ObtenerPaginas: function () {

            this.paginas = Math.ceil(this.ListaUbicacionesB.length / this.elementosPorPagina);
            this.getDataPagina(1);

        },

        // Esta funcion nos ayuda a mostrar los elementos paginados en la tabla
        getDataPagina(noPagina) {
            this.datosPaginados = [];
            let ini = (noPagina * this.elementosPorPagina) - this.elementosPorPagina;
            let fin = (noPagina * this.elementosPorPagina);
            this.datosPaginados = this.ListaUbicacionesB.slice(ini, fin);

        },

        // Esta funcion nos ayuda a saltar a la anterior pagina anterior
        getPreviousPage() {
            if (this.paginaActual > 1) {
                this.paginaActual--;
            }
            this.getDataPagina(this.paginaActual)
        },
        // Esta funcion nos ayuda a saltar a la siguiente pagina
        getNextPage() {
            if (this.paginaActual < this.paginas) {
                this.paginaActual++;
            }
            this.getDataPagina(this.paginaActual)
        },

        // Esta funcion se encarga de establecer el idioma para la pagina

        EstablecerIdioma: function (idioma) {
            var self = this
            $.post(urlidioma, {
                idiomaUbicacion: idioma,
            }, function (data, error) {
                self.Listaidiomas = JSON.parse(data);
                self.select_UbicacionA = self.Listaidiomas.Seleccione
                console.log(JSON.parse(data));
            });
        },

        // Esta funcion limpia los campos en caso de lo que necesitaramos
        CancelarUbicacionB: function () {
            var self = this;
            $.post(urlUbicacion, {
                option: 'LimpiarUbicacionB',
                Nombre: self.Nombre,
                Descripcion: self.Descripcion,
            }, function (respuesta, error) {
                self.Nombre = '';
                self.Descripcion = '';
                self.select_UbicacionA = '';
            });
        },

        // Esta funcion Carga las Ubicaciones A en el Combobox de Ubicaciones A
        CargarUbicacionesALista: function (idEmpresaActual) {
            var self = this
            $.post(urlUbicacion, {
                option: 'ConsultarUbicacionesA',
                IdPerfilEmpresaU: idEmpresaActual,
            }, function (data, error) {
                console.log(JSON.parse(data));
                self.ListaUbicacionesA = JSON.parse(data);
             
            });
        },

        // Esta funcion Carga todas Ubicaciones B registradas para una empresa 
        CargarTabla: function (idEmpresaActual) {  
            var self = this
            $.post(urlUbicacion, {
                option: 'ConsultarUbicacionesB',
                IdPerfilEmpresaU: idEmpresaActual,
            }, function (data, error) {
                self.ListaUbicacionesB = JSON.parse(data);
                console.log(JSON.parse(data));
                self.ObtenerPaginas();
            });
        },


        // Carga los datos de un registro seleccionado , esto para editarlo porteriormente
        CargarFilaB: function (Nnombre, Ddescripcion, IdubiAA, idUbicaB) { //carga la fila seleccionada de la tabla.
            this.Nombre = Nnombre;
            this.Descripcion = Ddescripcion;
            this.select_UbicacionA = IdubiAA;
            this.select_UbicacionB = idUbicaB;
            $.post(urlUbicacion, {
                option: 'CargarFB',
            }, function (respuesta, error) {
                var Json = JSON.parse(respuesta);
                if (Json.length != 0) {
                    self.Descripcion = Json[0].Descripcion;
                    self.Nombre = Json[0].Nombre;
                    self.IdUbicacionA = Json[0].select_UbicacionA;
                    EditarUbicacionB(IdUbicacionB);
                } else {
                }
                return true;
            });
        },

        // Esta funcion es la que se encarga de mandar los datos hacia la base de daos para realizar la insercion del nuevo registro en base de datos
        RegistrarUbicacionB: function () {
            var self = this;
            if (this.Nombre == '') {
                alertify.error(self.Listaidiomas.ErrorNombre);
                return;
            }
            if (this.IdPerfil_Empresa == '') {
                alertify.error(self.Listaidiomas.ErrorNombre);
                return;
            }
            if (this.Descripcion == '') {
                alertify.error(self.Listaidiomas.ErrorDescripcion);
                return;
            }
            if (this.select_UbicacionB != '') {
                self.EditarUbicacionB(self.select_UbicacionB,
                    self.select_UbicacionA,
                    self.Nombre,
                    self.Descripcion);
                return;
            }
            $.post(urlUbicacion, {
                option: 'InsertarUbicacionB',
                IdPefil_Empresa: this.IdPerfil_Empresa,
                Nombre: self.Nombre,
                Descripcion: self.Descripcion,
                IdUbicacionA: self.select_UbicacionA,
            }, function (respuesta, error) {
                if (respuesta == "Registrado") {
                    alertify.success(self.Listaidiomas.InsertarCorrecto);
                    self.Nombre = '';
                    self.Descripcion = '';
                    self.select_UbicacionA = '';
                    this.select_UbicacionB = '';
                    self.CargarTabla(self.IdPerfil_Empresa);
                } else {
                    alertify.error(self.Listaidiomas.InsertarError); //SI
                }
            });

        },
        // Esta funcion es la que se encarga de editar una ubicacion
        EditarUbicacionB: function (idUbicacionB, idUbicacionA, nombre, descripcion) {
            var self = this;
            if (this.Nombre == '') {
                alertify.error(self.Listaidiomas.ErrorNombre);
                return;
            }
            if (this.Descripcion == '') {
                alertify.error(self.Listaidiomas.ErrorDescripcion);
                return;
            }
            $.post(urlUbicacion, {
                option: 'ActualizaUbicacionB',
                IdUbicacionB: idUbicacionB,
                IdUbicacionA: idUbicacionA,
                Nombre: nombre,
                Descripcion: descripcion
            },
                function (data, error) {
                    console.log(data);
                    if (data === 'Actualizado') {
                        alertify.success(self.Listaidiomas.ActualizaCorrecto);
                        self.Nombre = '';
                        self.Descripcion = '';
                        self.select_UbicacionA = '';
                        self.select_UbicacionB = '';
                        self.CargarTabla(self.IdPerfil_Empresa);
                    } else {
                        alertify.error(self.Listaidiomas.ActualizaError);
                    }
                    return true;
                });
        },

    }
})