var urlIdioma = 'Ajax/AjaxIdiomaPaquetes.aspx'
var urlPaquetes = 'Ajax/AjaxPaquetes.aspx'

const Paquetes = new Vue({

    el: '#PaquetesVUE',

    data: {
        //Variables a utilizar
        listaIdiomas: [],
        listaPaquetes: [],
        Paquete: [],
        IdPaqueteIA: 0,
        nombre: '',
        descripcion: '',
        cantidad: '',
        costo: '',
        elementosXPagina: 5,
        paginas: 0,
        datosPaginados: [],
        paginaActual: 1,
    },

    mounted: function () {

        this.listaIdiomas = this.ObtenerIdiomaPaquetes();
        this.listaPaquetes = this.CargarPaquetesLista();
    },

    methods: {

        // Metodos para configurar el idioma
        ObtenerIdiomaPaquetes: function () {

            var idiActualiza = "ES"

            if (localStorage.getItem("idiomaApp") != undefined) {

                idiActualiza = localStorage.getItem("idiomaApp");

            }

            this.EstablecerIdiomaPaquetes(idiActualiza);

        },

        EstablecerIdiomaPaquetes: function (idioma) {

            var self = this


            $.post(urlIdioma, {

                IE: idioma,

            }, function (data, error) {

                self.listaIdiomas = JSON.parse(data);
            });

        },

        //Funcion para cargar los paquetes
        CargarPaquetesLista: function () {
            var self = this
            $.post(urlPaquetes, {
                option: 'ConsultarPaquete',
            },
                function (data, error) {
                    if (data != "Null") {
                        self.listaPaquetes = JSON.parse(data);
                        self.CantidadRegistros();
                    }
                });
        },

        // Funcion para insertar un nuevo paquete
        InsertarPaquete: function () {
            var self = this;
        
            var IE = this.IdPaqueteIA;
            var EI = (self.listaIdiomas.InsertarCorrecto);
            var CI = (self.listaIdiomas.InsertaError);
            var DI = (self.listaIdiomas.Datosincorrectos);
            if (self.nombre == "" || self.descripcion == "" || self.cantidad == "" || self.costo == "") {
              
                    alertify.error(DI);
            }
            else if  (IE != 0) {
                self.ModificarPaquete();
            }
            else {

                $.post(urlPaquetes, {

                    option: "InsertarPaquete",

                    NuevoPaquete: JSON.stringify({
                        nombre: self.nombre,
                        descripcion: self.descripcion,
                        cantidad: self.cantidad,
                        costo: self.costo,
                     
                    })

                }, function (respuesta, error) {
                    if (respuesta == "Registrado") {
                        self.IdEmpleadoIA = 0;
                        alertify.success(EI)
                        self.CargarPaquetesLista();
                    }
                    else {

                    
                            alertify.error(CI);
                     

                    }
                    self.LimpiarCampos();
                 
                });
            }

        },

        // Funcion para modificar el estado de un paquete
        ModificarPaquete: function () {
            var self = this;
            var EA = (self.listaIdiomas.ActualizaCorrecto);
            var CA = (self.listaIdiomas.ActualizaError);

            $.post(urlPaquetes, {

                option: "ActualizarPaquete",

                ActualizarPaquete: JSON.stringify({
                    idPaqueteContratado: self.IdPaqueteIA,
                    nombre: self.nombre,
                    descripcion: self.descripcion,
                    cantidad: self.cantidad,
                    costo: self.costo,
                })

            }, function (respuesta, error) {
                if (respuesta == "Actualizado") {
                    self.IdEmpleadoIA = 0;
                    alertify.success(EA)
                    self.CargarPaquetesLista();
                }
                else {
                    alertify.error(CA);
                }
                self.LimpiarCampos();
            });
        },

        // Funcion para cargar los paquetes en los campos
        CargarPaquetes: function (idPaquete) {
            var self = this;

            $.post(urlPaquetes, {
                option: 'ConsultarPaqueteX',
                IdPaquete: idPaquete,
            },
                function (data, error) {

                    var json = JSON.parse(data);


                    self.nombre = json[0].Nombre;
                    self.descripcion = json[0].Descripcion;
                    self.cantidad = json[0].Cantidad;
                    self.costo = json[0].Costo;
                    self.IdPaqueteIA = idPaquete;
                });
        },

        // Funcion para limpiar todos los campos de un paquete
        LimpiarCampos: function () {
            var self = this;
            self.nombre = ' ';
            self.descripcion = ' ';
            self.costo = ' ';
            self.cantidad = ' ';
            self.IdPaqueteIA = 0;
        },

        /// Funcion para calcular la cantidad de paginas
        CantidadRegistros: function () {

            this.paginas = Math.ceil(this.listaPaquetes.length / this.elementosXPagina);
            this.ObtenerDataTabla(1);

        },

        // Funcion para divir los datos para mostrarlos en la tabla
        ObtenerDataTabla(noPagina) {
            this.datosPaginados = [];
            let inicio = (noPagina * this.elementosXPagina) - this.elementosXPagina;
            let fin = (noPagina * this.elementosXPagina);
            this.datosPaginados = this.listaPaquetes.slice(inicio, fin);
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
    },

})