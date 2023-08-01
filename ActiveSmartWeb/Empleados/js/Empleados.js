var urlIdioma = 'Ajax/AjaxIdiomaEmpleados.aspx'
var urlEmpleados = 'Ajax/AjaxEmpleados.aspx'

const Empleados = new Vue({

    el: '#EmpleadosVUE',

    data: {
        //Variables a utilizar
        listaIdiomas: [],
        listaEmpleados: [],
        filtroTabla:'',
        Empleado: [],
        IdEmpleadoIA: 0,
        nombre: '',
        apellidos: '',
        identificacion: '',
        correo: '',
        puesto: '',
        telefono: '',
        IdPefil_Empresa: '',
        elementosXPagina: 5,
        paginas: 0,
        datosPaginados: [],
        paginaActual: 1,
        filtroIdentificacion: '',
        ActualizaError: '',
        telNational: '',
        phoneInput3: '',
        datosFiltrados: [],
        nombreUsuario: '',
        estadoEmpleado: ''
    },

    mounted: function () {
        //this.ValidarSesion();
        var prueba = JSON.parse(sessionStorage.getItem('Empresas'));
        this.IdPefil_Empresa = prueba[0].IdPerfilEmpresa;
        this.listaIdiomas = this.ObtenerIdiomaEmpleados();
        this.CargarInputPaises();
        this.listaEmpleados = this.CargarEmpleadosLista(this.IdPefil_Empresa);
        this.ObtenerDatosUsuario();
    },

    methods: {

        ObtenerDatosUsuario: function () {
            let json = JSON.parse(sessionStorage.getItem('DUser'));
            this.datosUsuario = json;
            this.nombreUsuario = json[0].Nombre + " " + json[0].Apellildo;
        },

        // Metodos para configurar el idioma
        ObtenerIdiomaEmpleados: function () {

            var idiActualiza = "ES"

            if (localStorage.getItem("idiomaApp") != undefined) {

                idiActualiza = localStorage.getItem("idiomaApp");

            }

            this.EstablecerIdiomaEmpleados(idiActualiza);

        },

        EstablecerIdiomaEmpleados: function (idioma) {

            var self = this


            $.post(urlIdioma, {

                IE: idioma,

            }, function (data, error) {

                self.listaIdiomas = JSON.parse(data);
                
            });

        },

        // Función para cargar los empleados segun su estado
        CargarEmpleadosEstado: function () {
            var self = this;
            var prueba = JSON.parse(sessionStorage.getItem('Empresas'));
            this.IdPefil_Empresa = prueba[0].IdPerfilEmpresa;
            $.post(urlEmpleados, {
                option: 'ConsultarEmpleadosEstado',
                IdEmpresa: this.IdPefil_Empresa,
                Estado: self.filtroTabla
            },
                function (data, error) {

                    if (data != "Null") {
                        self.listaEmpleados = JSON.parse(data);
                        self.datosFiltrados = JSON.parse(data);
                        self.CantidadRegistros();

                    }
                });


        },

        // Función para cargar los empleados por empresa
        CargarEmpleadosLista: function (idEmpresa) {
            var self = this
            $.post(urlEmpleados, {
                option: 'ConsultarEmpleadosXEmpresa',
                IdEmpresa: idEmpresa,
            },
            function (data, error) {
                if (data != "Null") {
                    self.listaEmpleados = JSON.parse(data);
                    self.datosFiltrados = JSON.parse(data);
                    self.CantidadRegistros();
                }
            });
        },

        // Función para insertar un nuevo empleado
        InsertarEmpleado: function () {
            var self = this;
            var prueba = JSON.parse(sessionStorage.getItem('Empresas'));
            this.IdPefil_Empresa = prueba[0].IdPerfilEmpresa;
            var IE = this.IdEmpleadoIA;
            var EI=(self.listaIdiomas.InsertaError);
            var EA = (self.listaIdiomas.ActualizaError);

            if (self.nombre == "") {
                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.LlenarNombre);
            } else if (self.apellidos == "") {
                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.LlenarApellidos);
            } else if (self.identificacion == "") {
                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.LlenarIdentificacion);
            } else if (self.correo == "") {
                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorCorreo);
            } else if (self.puesto == "") {
                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.LlenarPuesto);
            } else if (self.phoneInput3.getNumber() == " ") {
                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.LlenarTelefono);
            }
            else {

                $.post(urlEmpleados, {

                    option: "InsertarEmpleado",

                    NuevoEmpleado: JSON.stringify({
                        idEmpleados: IE,
                        nombre: self.nombre,
                        apellidos: self.apellidos,
                        identificacion: self.identificacion,
                        correo: self.correo,
                        puesto: self.puesto,
                        telefono: self.phoneInput3.getNumber(),
                        estado: "true",
                        idPerfilEmpresa: this.IdPefil_Empresa,

                    })

                }, function (respuesta, error) {
                    if (respuesta == "Registrado") {
                        self.IdEmpleadoIA = 0;
                        alertas.success(self.listaIdiomas.Atencion, self.listaIdiomas.InsertarCorrecto);
                        self.CargarEmpleadosEstado();
                    } else if (respuesta == "Actualizado") {
                        self.IdEmpleadoIA = 0;
                        alertas.success(self.listaIdiomas.Atencion, self.listaIdiomas.ActualizaCorrecto);
                        self.CargarEmpleadosEstado();

                    } else if (respuesta == "Correo") {
                        alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorCorreo);
                    } else if (respuesta == "El correo ya existe") {
                        alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorCorreoUs);
                    } else if (respuesta == "Telefono") {
                        alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorTelefono);
                    }else {

                        if (IE == 0) {
                            //alertify.error(EI);
                            alertas.error(self.listaIdiomas.Atencion, respuesta);
                        }
                        else {
                            alertas.error(self.listaIdiomas.Atencion, EA);
                        }

                    }
                    self.LimpiarCampos();
                    document.getElementById("idEmpleadoTxt").disabled = false;
                });
            }

        },

        // Función para modificar el estado de un empleado
        ModificarEstadoEmpleado: function () {
            var self = this;
            $.post(urlEmpleados, {
                option: 'ModificarEstadoEmpleado',
                Estado: self.estadoEmpleado,
                IdEmpleado: self.IdEmpleadoIA,
            }, function (respuesta, error) {
                if (respuesta == "Actualizado") {
                    alertas.success(self.listaIdiomas.Atencion, self.listaIdiomas.ActualizaCorrecto);
                } else if (respuesta == "No se puede actualizar un usuario admin") {
                    alertas.info(self.listaIdiomas.Atencion, self.listaIdiomas.AdminNo);
                }else {
                    alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ActualizaError);
                }
                self.CerrarPopPup();
            });

        },

        // Función para cargar los empleados por empresa por identificacion
        CargarEmpleadosIdentificacion: function () {
            var self = this;
            var prueba = JSON.parse(sessionStorage.getItem('Empresas'));
            this.IdPefil_Empresa = prueba[0].IdPerfilEmpresa;
            var id = self.filtroIdentificacion;

            if (id== "" || id == " ") {
                alertify.error(self.listaIdiomas.BuscarError)
            }
            else {
                $.post(urlEmpleados, {
                    option: 'ConsultarEmpleadoXIdentificacion',
                    IdEmpresa: prueba[0].IdPerfilEmpresa,
                    IdEmpleado: self.filtroIdentificacion
                },
                    function (data, error) {
                        var json = JSON.parse(data);
                    
                        if (json.length !=0) {


                            self.nombre = json[0].Nombre;
                            self.apellidos = json[0].Apellidos;
                            self.identificacion = json[0].Identificacion;
                            self.correo = json[0].Correo;
                            self.puesto = json[0].Puesto;
                            self.phoneInput3.setNumber(json[0].Telefono);
                            self.IdEmpleadoIA = json[0].IdEmpleados;
                            var a = document.getElementById("NombreTxt");
                            var b = document.getElementById("ApellidosTxt")
                            var c = document.getElementById("idEmpleadoTxt");
                            var d = document.getElementById("CorreotTxt");

                            a.disabled = true;
                            b.disabled = true;
                            c.disabled = true;
                            d.disabled = true;
                        }
                        else {
                            alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.BuscarNoEncontrado);
                        }
                    });
            }
        },

        // Función para cargar los empleados por empresa desde la tabla
        CargarEmpleadoTabla: function (identificacion) {
            var self = this;
            var prueba = JSON.parse(sessionStorage.getItem('Empresas'));
            this.IdPefil_Empresa = prueba[0].IdPerfilEmpresa;

            $.post(urlEmpleados, {
                option: 'ConsultarEmpleadoXIdentificacion',
                IdEmpresa: prueba[0].IdPerfilEmpresa,
                IdEmpleado: identificacion
            },
                function (data, error) {

                    var json = JSON.parse(data);

                   
                    self.nombre = json[0].Nombre;
                    self.apellidos = json[0].Apellidos;
                    self.identificacion = json[0].Identificacion;
                    self.correo = json[0].Correo;
                    self.puesto = json[0].Puesto;
                    self.phoneInput3.setNumber(json[0].Telefono);
                    self.IdEmpleadoIA = json[0].IdEmpleados;
                    document.getElementById("NombreTxt").disabled = true;
                    document.getElementById("ApellidosTxt").disabled = true;
                    document.getElementById("idEmpleadoTxt").disabled = true;
                    document.getElementById("CorreotTxt").disabled = true;
                });
        },

        // Función para limpiar todos los campos de registro de un empleado
        LimpiarCampos: function () {
            var self = this;
            self.nombre = ' ';
            self.apellidos = ' ';
            self.identificacion = ' ';
            self.correo = ' ';
            self.puesto = ' ';
            self.telefono = ' ';
            self.IdEmpleadoIA = ' ';
            self.IdEmpleadoIA = 0;
            self.phoneInput3.setNumber("+506");
            document.getElementById("idEmpleadoTxt").disabled = false;
        },

        /// Función para calcular la cantidad de paginas
        CantidadRegistros: function () {
            this.paginas = Math.ceil(this.listaEmpleados.length / this.elementosXPagina);
            this.ObtenerDataTabla(1);
        },

        // Función para divir los datos para mostrarlos en la tabla
        ObtenerDataTabla(noPagina) {
            this.datosPaginados = [];
            let inicio = (noPagina * this.elementosXPagina) - this.elementosXPagina;
            let fin = (noPagina * this.elementosXPagina);
            this.datosPaginados = this.datosFiltrados.slice(inicio, fin);
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

        ValidarSesion: function () {

            var dConfig = JSON.parse(sessionStorage.getItem('DConfig'));
            var dUser = JSON.parse(sessionStorage.getItem('DUser'));

            if (dConfig == null || dConfig.CofPerfil == false || dUser[0].TipoUsuario != 1) {
                window.location.href = window.location.origin + "/AccesoDenegado.aspx";
            }
        },

        CargarInputPaises: function () {
            const phoneInputField = document.getElementById("telNational");

            //Configuración del Input tel 
            this.phoneInput3 = window.intlTelInput(phoneInputField, {
                initialCountry: "cr", //Un prefijo nacional por defecto al cargar
                preferredCountries: ["us", "cr"], //Puedes agregar prefijos preferenciales para que salgan al inicio
                separateDialCode: true, //Mostrar el prefijo seleccionado en el input
                autoPlaceholder: "off", //Desactivar el placeholder por defecto
                utilsScript: "https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/11.0.14/js/utils.js"
            });
        },

        //Función para filtrar los datos por nombre,apellido,correo.
        FiltrarDatos: function () {

            let datobuscar = this.buscador.toUpperCase();

            this.datosFiltrados = this.listaEmpleados.filter(x => x.Nombre.toUpperCase().indexOf(datobuscar) >= 0 || x.Apellidos.toUpperCase().indexOf(datobuscar) >= 0 || x.Correo.toUpperCase().indexOf(datobuscar) >= 0);

            this.paginas = Math.ceil(this.datosFiltrados.length / this.elementosXPagina);

            this.datosPaginados = this.datosFiltrados;

            this.paginaActual = 1;

            this.ObtenerDataTabla(1);

        },

        ValidarSoloNumeros() {
            //Obtener el valor de lo que digita el usuario en la tecla
            var key = String.fromCharCode(!event.charCode ? event.which : event.charCode);

            //Configurar el regex con las expresiones regulares que desea o que se desean
            regex = /^[0-9]$/;

            if (!regex.test(key)) {
                event.preventDefault();
                return false;
            }
        },

        AbrirPopPup: function (idE, est) {
            var self = this;
            var a = document.getElementById('PConfirmar');
            a.style.display = 'flex';
            self.IdEmpleadoIA = idE;
            self.estadoEmpleado = est;
        },
        CerrarPopPup: function () {
            var a = document.getElementById('PConfirmar');
            a.style.display = 'none';
            self.IdEmpleadoIA = 0;
            self.estadoEmpleado = '';
            this.CargarEmpleadosEstado();
        },

    },

})