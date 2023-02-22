var urlidioma = 'IdiomaUbicacionDAjax.aspx'
var urlUbicacion = 'UbicacionDAjax.aspx'

const UbicacionesD = new Vue({
    el: '#maincontext',
    data: {
        // Variabkes necesarias
        IdPerfil_Empresa: '',
        Listaidiomas: [],
        ListaUbicacionesA: [],
        select_UbicacionA: '',
        ListaUbicacionesB: [],
        select_UbicacionB: '',
        ListaUbicacionesC: [],
        select_UbicacionC: '',
        select_UbicacionD: '',
        Nombre: '',
        Descripcion: '',
        ListaUbicacionesD: [],
        elementosPorPagina: 5,
        paginas: 0,
        datosPaginados: [],
        paginaActual: 1
    },
    mounted: function () {
        var logueado = JSON.parse(sessionStorage.getItem('DUser'));
        this.IdPerfil_Empresa = "" + logueado[0].IdPerfilEmpresa;
        ListaUbicacionesA = this.CargarUbicacionesALista(this.IdPerfil_Empresa);
        this.Listaidiomas = this.ObtenerIdioma();
        this.ListaUbicacionesA = this.CargarUbicacionesALista(this.IdPerfil_Empresa);
    },

    methods: {
        ///Este metodo se encarga de guardar el idioma en una variable de sesion para posteriormente utilizarlo en las paginas
        ObtenerIdioma: function () {
            var idiActualiza = "ES"
            if (localStorage.getItem("idiomaApp") != undefined) {
                idiActualiza = localStorage.getItem("idiomaApp");
            }
            this.EstablecerIdioma(idiActualiza);
            this.ListaUbicacionesD = this.CargarTablaD(this.IdPerfil_Empresa);
        },
          /// Esta funcion nos ayuda a calcular la cantidad de paginas para la paginacion de la tabla , se toma en cuenta la cantidad de filas que queremos por pagina y el total de los registros
        ObtenerPaginas: function () {

            this.paginas = Math.ceil(this.ListaUbicacionesD.length / this.elementosPorPagina);
            this.getDataPagina(1);

        },
           // Esta funcion nos ayuda a mostrar los elementos paginados en la tabla
        getDataPagina(noPagina) {
            this.datosPaginados = [];
            let ini = (noPagina * this.elementosPorPagina) - this.elementosPorPagina;
            let fin = (noPagina * this.elementosPorPagina);
            this.datosPaginados = this.ListaUbicacionesD.slice(ini, fin);

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
                console.log(JSON.parse(data));
            });
        },
           // Esta funcion Carga las Ubicaciones A en el Combobox de Ubicaciones A
        CargarUbicacionesALista: function (idEmpresaActual) {
            var self = this
            $.post(urlUbicacion, {
                option: 'ConsultarUbicacionesA',
                IdPerfilEmpresaU: idEmpresaActual,
            }, function (data, error) {
                self.ListaUbicacionesA = JSON.parse(data);
                console.log(JSON.parse(data));
            });
        },
           // Esta funcion Carga las Ubicaciones B en el Combobox de Ubicaciones B
        CargarUbicacionesBLista: function () {
            var self = this
            $.post(urlUbicacion, {
                option: 'ConsultarUbicacionesB',
                IdPerfilEmpresaU: self.IdPerfil_Empresa,
                IdUbicacionA: self.select_UbicacionA,
            }, function (data, error) {

                self.ListaUbicacionesB = JSON.parse(data);
                console.log(JSON.parse(data));
            });
        },

           // Esta funcion Carga las Ubicaciones C en el Combobox de Ubicaciones C
        CargarUbicacionesCLista: function () {
            var self = this
            $.post(urlUbicacion, {
                option: 'ConsultarUbicacionesC',
                IdPerfilEmpresaU: self.IdPerfil_Empresa,
                IdUbicacionB: self.select_UbicacionB,
            }, function (data, error) {
                self.ListaUbicacionesC = JSON.parse(data);
                console.log(JSON.parse(data));
            });
        },

        // Este metodo limpia los campos del formulario para registrar la ubicacion C
        CancelarUbicacionD: function () {
            var self = this;
            self.Nombre = '';
            self.Descripcion = '';
            self.select_UbicacionA = '';
            self.select_UbicacionB = '';
            self.select_UbicacionC = '';
        },

        // Este metodo carga todas ubicaciones D en la tabla
        CargarTablaD: function (idEmpresaActual) {
            var self = this
            $.post(urlUbicacion, {
                option: 'ConsultarUbicacionesD',
                IdPerfilEmpresaU: idEmpresaActual,
            }, function (data, error) {
                self.ListaUbicacionesD = JSON.parse(data);
                console.log(JSON.parse(data));
                self.ObtenerPaginas();
            });
        },


        CargaUbicacionesBEditar: function (idUbicB, idUbicC) {//1
            var self = this
            $.post(urlUbicacion, {
                option: 'ConsultarUbicacionesB',
                IdPerfilEmpresaU: self.IdPerfil_Empresa,
                IdUbicacionB: self.select_UbicacionB,
            }, function (data, error) {
                self.select_UbicacionB = data;
                console.log(JSON.parse(data));
                self.CargarUbicacionesBLista();
                self.select_UbicacionA = idUbicB;
                self.CargarUbicacionesCLista();
                self.select_UbicacionC = idUbicC;
            });
        },


        CargarFilaD: function (Non, Des, IdUbicacionC) {
            var self = this;
            this.Nombre = Non;
            this.Descripcion = Des;
            $.post(urlUbicacion, {
                option: 'ConsultaUbicacionxIdUbicacionC',
                IdUbicacionC: IdUbicacionC,
            }, function (data, error) {
                self.select_UbicacionB = data;
                self.CargaUbicacionesBEditar(data, IdUbicacionC);
            });
        },

         // Esta funcion es la que se encarga de mandar los datos hacia la base de daos para realizar la insercion del nuevo registro en base de datos
        InsertarUbicacionD: function () {
            var self = this;
            if (this.Nombre == '') {
                alertify.error(this.Listaidiomas.ErrorNombre);
                return
            }
            if (this.Descripcion == '') {
                alertify.error(this.Listaidiomas.ErrorDescripcion);
                return
            }
            if (this.select_UbicacionD != '') {
                self.EditarUbicacionD(self.select_UbicacionD,
                    self.select_UbicacionC,
                    self.Nombre,
                    self.Descripcion);
                return;
            }
            $.post(urlUbicacion, {
                option: 'RegistrarUbicacionD',
                IdPerfil_Empresa: self.IdPerfil_Empresa,
                Nombre: self.Nombre,
                Descripcion: self.Descripcion,
                IdUbicacionC: self.select_UbicacionC,
            }, function (respuesta, error) {

                console.log(respuesta);
                if (respuesta === "Registrado") {
                    alertify.success(self.Listaidiomas.InsertarCorrecto);
                    self.Nombre = '';
                    self.Descripcion = '';
                    self.CargarTablaD(self.IdPerfil_Empresa);
                } else {
                    alertify.error(self.Listaidiomas.InsertarError);
                }
            });
        },
        CargarInformacionPorID: function (nombre, descripcion, idUbicacionD) {
            var self = this;
            self.Nombre = nombre;
            self.Descripcion = descripcion;
            self.select_UbicacionD = idUbicacionD;
            $.post(urlUbicacion, {
                option: 'ConsultaUbicacionesPorIdD',
                IdUbiD: idUbicacionD,
            }, function (data, error) {
                var datos = JSON.parse(data);
                // Cargamos la Ubicacion B
                self.select_UbicacionA = datos[0];
                self.CargarUbicacionesBLista();
                // Cargamos la ubicacion C
                self.select_UbicacionB = datos[1];
                self.CargarUbicacionesCLista();
                // Asignamos la Ubicacion C                 
                self.select_UbicacionC = datos[2];
            });
        },


          // Esta funcion es la que se encarga de editar una ubicacion
        EditarUbicacionD: function (idUbicacionD, idUbicacionC, nombre, descripcion) {
            var self = this;
            if (this.Nombre == '') {
                alertify.error(this.Listaidiomas.ErrorNombre);
                return
            }
            if (this.Descripcion == '') {
                alertify.error(this.Listaidiomas.ErrorDescripcion);
                return
            }
            $.post(urlUbicacion, {
                option: 'ActualizaUbicacionD',
                IdUbicacionD: idUbicacionD,
                IdUbicacionC: idUbicacionC,
                Nombre: nombre,
                Descripcion: descripcion
            },
                function (data, error) {
                    if (data == "Actualizado") {
                        alertify.success(self.Listaidiomas.ActualizaCorrecto);
                        self.Nombre = '';
                        self.Descripcion = '';
                        self.select_UbicacionD = 0 ;
                        self.CargarTablaD(self.IdPerfil_Empresa);
                    } else {
                        alertify.error(self.Listaidiomas.ActualizaError);
                    }
                    return true;
                });
        },
    }
})