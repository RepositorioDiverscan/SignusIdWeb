var urlidioma = 'IdiomaUbicacionCAjax.aspx'
var urlUbicacion = 'UbicacionCAjax.aspx'

const UbicacionesC = new Vue({
    el: '#maincontext',
    data: {
        // VARIABLES NECESARIAS
        IdPerfil_Empresa: '',
        Listaidiomas: [],
        ListaUbicacionesA: [],
        select_UbicacionA: '',
        ListaUbicacionesB: [],
        select_UbicacionB: '',
        Nombre: '',
        Descripcion: '',
        ListaUbicacionesC: [],
        select_UbicacionC: '',
        elementosPorPagina: 5,
        paginas: 0,
        datosPaginados: [],
        paginaActual: 1
    },

    mounted: function () {
        var logueado = JSON.parse(sessionStorage.getItem('DUser'));
        this.IdPerfil_Empresa = "" + logueado[0].IdPerfilEmpresa;
        this.Listaidiomas = this.ObtenerIdioma();
        this.ListaUbicacionesA = this.CargarUbicacionesALista(this.IdPerfil_Empresa);

        this.ListaUbicacionesC = this.CargarTablaC(this.IdPerfil_Empresa);
        this.getDataPagina(1);
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

            this.paginas = Math.ceil(this.ListaUbicacionesC.length / this.elementosPorPagina);
            this.getDataPagina(1);

        },

           // Esta funcion nos ayuda a mostrar los elementos paginados en la tabla
        getDataPagina(noPagina) {
            this.datosPaginados = [];
            let ini = (noPagina * this.elementosPorPagina) - this.elementosPorPagina;
            let fin = (noPagina * this.elementosPorPagina);
            this.datosPaginados = this.ListaUbicacionesC.slice(ini, fin);

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
                if (data != "Null") {

                    self.ListaUbicacionesA = JSON.parse(data);
                    console.log(JSON.parse(data));

                }

            });
        },

         // Esta funcion Carga las Ubicaciones B en el Combobox de Ubicaciones B
        CargarUbicacionesBLista: function () {
            var self = this
            var id = self.IdPerfil_Empresa;
            var IdUbiA = self.select_UbicacionA;
            $.post(urlUbicacion, {
                option: 'ConsultarUbicacionesB',
                IdPerfilEmpresaU: id,
                IdUbicacionA: IdUbiA,
            }, function (data, error) {

                self.ListaUbicacionesB = JSON.parse(data);
                console.log(JSON.parse(data));
               
            });
        },

        CargaUbicacionesBEditar: function (idUbicaB) {
            var self = this
            $.post(urlUbicacion, {
                option: 'ConsultarUbicacionesB',
                IdPerfilEmpresaU: self.IdPerfil_Empresa,
                IdUbicacionA: self.select_UbicacionA,
            }, function (data, error) {
                self.ListaUbicacionesB = JSON.parse(data);
                self.select_UbicacionB = idUbicaB;
                console.log(JSON.parse(data));
            });
        },

        // Esta funcion se enarga de cargar todas la ubicaciones C en la tabla 
        CargarTablaC: function (idEmpresaActual) {
            var self = this
            $.post(urlUbicacion, {
                option: 'ConsultarUbicacionesC',
                IdPerfilEmpresaU: idEmpresaActual,
            }, function (data, error) {
                self.ListaUbicacionesC = JSON.parse(data);
                console.log(JSON.parse(data));
                self.ObtenerPaginas();
            });
        },

        // Esta funcion se encarga de limpiar todos los campos de registro de una ubicacion C
        CancelarUbicacionC: function () {
            var self = this;
            self.Nombre = '';
            self.Descripcion = '';
            self.select_UbicacionB = '';
            self.select_UbicacionA = '';
            self.select_UbicacionC = '';
        },

        
        CargarFilaC: function (Non, Des, IdUbicacionB, IdUbicacionC) {
            var self = this;
            this.Nombre = Non;
            this.Descripcion = Des;
            this.select_UbicacionB = IdUbicacionB;
            this.select_UbicacionC = IdUbicacionC;

            $.post(urlUbicacion, {
                option: 'ConsultarUbicacionesXId',
                IdUbicacionB: IdUbicacionB,
            }, function (data, error) {
                self.select_UbicacionA = data;
           
               self.CargaUbicacionesBEditar(IdUbicacionB);


            });
        },

         // Esta funcion es la que se encarga de mandar los datos hacia la base de daos para realizar la insercion del nuevo registro en base de datos
        InsertarUbicacionC: function () {
            var self = this;
            if (this.Nombre == '') {
                alertify.error(this.Listaidiomas.ErrorNombre)
                return
            }
            if (this.Descripcion == '') {
                alertify.error(this.Listaidiomas.ErrorDescripcion);
                return
            }
            if (this.select_UbicacionC != '') {
                self.EditarUbicacionC(self.select_UbicacionC, self.select_UbicacionB, self.Nombre, self.Descripcion);
                return;
            }
            $.post(urlUbicacion, {
                option: 'RegistrarUbicacionC',
                IdPefil_Empresa: self.IdPerfil_Empresa,
                Nombre: self.Nombre,
                Descripcion: self.Descripcion,
                IdUbicacionB: self.select_UbicacionB,
            }, function (respuesta, error) {
                if (respuesta == "Registrado") {
                    self.Nombre = '';
                    self.Descripcion = '';
                    self.select_UbicacionB = '';
                    self.select_UbicacionC = '';
                    alertify.success(self.Listaidiomas.InsertarCorrecto)
                    self.CargarTablaC(self.IdPerfil_Empresa);
                } else {
                    alertify.error(self.Listaidiomas.InsertarError);
                }
            });
        },

         // Esta funcion es la que se encarga de editar una ubicacion
        EditarUbicacionC: function (idUbicacionC, idUbicacionB, nombre, descripcion) {
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
                option: 'ActualizaUbicacionC',
                IdUbicacionC: idUbicacionC,
                IdUbicacionB: idUbicacionB,
                Nombre: nombre,
                Descripcion: descripcion
            },
                function (data, error) {
                    if (data == "Actualizado") {
                        alertify.success(self.Listaidiomas.ActualizaCorrecto);
                         self.CargarTablaC(self.IdPerfil_Empresa);
                    } else {
                        alertify.error(self.Listaidiomas.ActualizaError);
                    }
                    return true;
                });
        },
    }
})
