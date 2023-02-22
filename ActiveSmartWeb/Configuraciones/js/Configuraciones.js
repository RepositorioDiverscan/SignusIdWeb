var urlIdioma = 'Ajax/AjaxIdiomaConfiguraciones.aspx'
var urlConfiguraciones= 'Ajax/AjaxConfiguraciones.aspx'

const Configuraciones = new Vue({

    el: '#ConfiguracionesVUE',

    data: {
        //Variables a utilizar
        listaIdiomas: [],
        listaConfiguraciones: [],
        Configuracion: [],
        IdConfiguracionIA: 0,
        nombre: '',
        descripcion: '',
        estado: '',
        CMBtipo: '',
        FechaRegistro: '',
        elementosXPagina: 5,
        paginas: 0,
        datosPaginados: [],
        paginaActual: 1,
    },

    mounted: function () {

        this.listaIdiomas = this.ObtenerIdiomaConfiguraciones();
        this.listaConfiguraciones = this.CargarConfiguracionesLista();
    },

    methods: {

        // Metodos para configurar el idioma
        ObtenerIdiomaConfiguraciones: function () {

            var idiActualiza = "ES"

            if (localStorage.getItem("idiomaApp") != undefined) {

                idiActualiza = localStorage.getItem("idiomaApp");

            }

            this.EstablecerIdiomaConfiguracion(idiActualiza);

        },

        EstablecerIdiomaConfiguracion: function (idioma) {

            var self = this


            $.post(urlIdioma, {

                IE: idioma,

            }, function (data, error) {

                self.listaIdiomas = JSON.parse(data);
            });

        },

        // Función para cargar los empleados por empresa
        CargarConfiguracionesLista: function () {
            var self = this
            $.post(urlConfiguraciones, {
                option: 'ConsultarConfiguracion',
            },
                function (data, error) {
                    if (data != "Null") {
                        self.listaConfiguraciones = JSON.parse(data);
                        self.CantidadRegistros();
                    }
                });
        },

        // Función para insertar una nueva configuración 
        InsertarConfiguraciones: function () {
            var self = this;
            var IE = this.IdConfiguracionIA;
            var EI =(self.listaIdiomas.InsertarCorrecto);
            var CI =  (self.listaIdiomas.InsertaError);
            var DI = (self.listaIdiomas.Datosincorrectos);
            var cmbt = document.getElementById("cmbTipo");
            var tip = cmbt.options[cmbt.selectedIndex].text;
            if (self.nombre == " " || self.nombre == "") {
                alertify.error(DI);
            }
            else if (self.descripcion == " " || self.descripcion == "") {
                alertify.error(DI);
            }
            else if (IE != 0) {
                self.ModificarConfiguracion(IE);
            }
            else {
                $.post(urlConfiguraciones, {

                    option: "InsertarConfiguracion",

                    NuevoConfiguraciones: JSON.stringify({
                        nombre: self.nombre,
                        descripcion: self.descripcion,
                        Tipo: tip,
                        Estado: 1
                    })
                }, function (respuesta, error) {
                    if (respuesta == "Registrado") {
                        self.IdConfiguracionIA = 0;
                        alertify.success(EI)
                        self.CargarConfiguracionesLista();
                    }
                    else {
                        alertify.error(CI);
                    }
                    self.LimpiarCampos();

                });
            }

        },

        // Funcion para modificar el estado de una configuración
        ModificarEstadoConfiguracion: function (IdE, Est) {
            var self = this;
            $.post(urlConfiguraciones, {
                option: 'ModificarEstadoConfiguracion',
                Estado: Est,
                IdConfiguracion: IdE,
            }, function (respuesta, error) {
                if (respuesta == "Actualizado") {
                    alertify.success(self.listaIdiomas.ActualizaCorrecto)
                    self.CargarConfiguracionesLista();
                } else {
                    alertify.error(self.listaidiomas.ActualizaError);
                }

            });

        },

        // Función para modificar una configuración
        ModificarConfiguracion: function (id) {
            var self = this;
            var CA = (self.listaIdiomas.ActualizaCorrecto);
            var EA = (self.listaIdiomas.ActualizaError);
            var cmbt = document.getElementById("cmbTipo");
            var tip = cmbt.options[cmbt.selectedIndex].text;
            var prueba = id;
            $.post(urlConfiguraciones, {

                option: "ActualizarConfiguraciones",
                IdConfiguracion: prueba,
                Nombre: self.nombre,
                Tipo: tip,
                Descripcion: self.descripcion,


            }, function (respuesta, error) {
                if (respuesta == "Actualizado") {
                    self.IdConfiguracionIA = 0;
                    alertify.success(CA)
                    self.CargarConfiguracionesLista();
                }
                else {
                    alertify.error(EA);
                }
                self.LimpiarCampos();
            });
        },

        // Función para cargar las configuraciones en los campos
        CargarConfiguracion: function (idConfiguracion) {
            var self = this;

            $.post(urlConfiguraciones, {
                option: 'ConsultarConfiguracionX',
                IdConfiguracion: idConfiguracion
            },
                function (data, error) {

                    var json = JSON.parse(data);
                    const select = document.getElementById('cmbTipo');
                    select.value = json[0].Tipo;
                    self.nombre = json[0].Nombre;
                    self.descripcion = json[0].Descripcion;
                    self.estado = json[0].Estado;
                    self.IdConfiguracionIA = idConfiguracion;


                });
        },

        // Función para limpiar todos los campos de configuraciones
        LimpiarCampos: function () {
            var self = this;
            self.nombre = ' ';
            self.descripcion = ' ';
            self.IdConfiguracionIA = 0;
        },

        // Función para calcular la cantidad de paginas
        CantidadRegistros: function () {

            this.paginas = Math.ceil(this.listaConfiguraciones.length / this.elementosXPagina);
            this.ObtenerDataTabla(1);

        },

        // Función para divir los datos para mostrarlos en la tabla
        ObtenerDataTabla(noPagina) {
            this.datosPaginados = [];
            let inicio = (noPagina * this.elementosXPagina) - this.elementosXPagina;
            let fin = (noPagina * this.elementosXPagina);
            this.datosPaginados = this.listaConfiguraciones.slice(inicio, fin);
        },

        // Función para regresar a la pagina anterior
        PaginaAnterior() {
            if (this.paginaActual > 1) {
                this.paginaActual--;
            }
            this.ObtenerDataTabla(this.paginaActual)
        },

        // Función para saltar a la siguiente pagina
        PaginaSiguiente() {
            if (this.paginaActual < this.paginas) {
                this.paginaActual++;
            }
            this.ObtenerDataTabla(this.paginaActual)
        },
    },

})