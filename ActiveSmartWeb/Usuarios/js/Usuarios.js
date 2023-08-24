var urlAjaxIdioma = 'IdiomaUsuariosAjax.aspx';
var urlUsuariosAjax = 'UsuariosAjax.aspx';


const contrato = new Vue({

    el: '#context',
    //Variables para utilizar en el v-model de vue.
    data: {
        IdRol: "",
        buscador: "",
        Usuarios: [],
        listaIdiomas: {},
        elementosXPagina: 5,
        paginas: 0,
        datosPaginados: [],
        datosFiltrados: [],
        paginaActual: 1,
    },
    mounted: function () {
        //this.ValidarSesion();
        /* Llamados a metodos para cargar la informacion necesaria.*/
        var idiLog = "ES"
        if (localStorage.getItem("idiomaApp") != undefined) {
            idiLog = localStorage.getItem("idiomaApp");
        }
        this.idiomaLogin = idiLog;
        this.estableceridiomalogin(this.idiomaLogin);
        this.CargarUsuarios();
    },
    methods: {

        //Metodo para cargar los idiomas.
        estableceridiomalogin: function (tipoIdioma) {
            var self = this;
            $.post(urlAjaxIdioma, {
                idioma: tipoIdioma,
            }, function (data, error) {
                self.listaIdiomas = JSON.parse(data);
            });
        },

        //Metodo para cargar los usuarios de la empresa.
        CargarUsuarios: function () {
            var self = this;
            let user = JSON.parse(sessionStorage.getItem('DUser'));
            $.post(urlUsuariosAjax, {
                option: 'CargarUsuarios',
                idEmpresa: user[0].IdPerfilEmpresa
            }, function (data, error) {

                self.Usuarios = JSON.parse(data);
                self.datosFiltrados = JSON.parse(data);
                self.CantidadRegistros();

            });
        },


        //Metodo para actualizar o insertar un usuario de una empresa.
         RegistrarActualizarUsuarioEmpleado: function (e, usuario) {
            var self = this;
             let user = JSON.parse(sessionStorage.getItem('DUser'));
             self.IdRol = e.target.value;

             
                 $.post(urlUsuariosAjax, {

                     option: 'RegistrarActualizarUsuarioEmpleado',
                     idEmpresa: user[0].IdPerfilEmpresa,
                     idRol: self.IdRol,
                     correo: usuario.Correo,

                 }, function (respuesta, error) {
                     self.CargarUsuarios();
                     if (respuesta == "Actualizo") {

                         alertas.success(self.listaIdiomas.Atencion, self.listaIdiomas.RolUsuario);
                     } else if (respuesta == "Ingreso completo") {
                         alertas.success(self.listaIdiomas.Atencion, self.listaIdiomas.CreaUsuario);
                     }
                     else {

                         alertas.error(self.listaIdiomas.Atencion, respuesta);
                     }

                 });
        },


        //Metodo para actualizar el rol del usuario
        ActualizarRol: function (e, usuario) {
            var self = this;
            let user = JSON.parse(sessionStorage.getItem('DUser'));
            self.IdRol = e.target.value;


            $.post(urlUsuariosAjax, {

                option: 'ActualizarRol',
                idEmpresa: user[0].IdPerfilEmpresa,
                idRol: self.IdRol,
                correo: usuario.Correo,

            }, function (respuesta, error) {
                self.CargarUsuarios();
                if (respuesta == "Actualizo") {
                    alertas.success(self.listaIdiomas.Atencion, self.listaIdiomas.RolUsuario);
                } else {
                    alertas.error(self.listaIdiomas.Atencion, respuesta);
                }

            });
        },

         //Función para filtrar los datos por nombre,apellido,correo.
        FiltrarDatos: function () {

            let datobuscar = this.buscador.toUpperCase();

            this.datosFiltrados = this.Usuarios.filter(x => x.Nombre.toUpperCase().indexOf(datobuscar) >= 0 || x.Apellidos.toUpperCase().indexOf(datobuscar) >= 0 || x.Correo.toUpperCase().indexOf(datobuscar) >= 0);

            this.paginas = Math.ceil(this.datosFiltrados.length / this.elementosXPagina);

            this.datosPaginados = this.datosFiltrados;

            this.paginaActual = 1;
            
            this.ObtenerDataTabla(1);
        },

        // Función para calcular la cantidad de paginas
        CantidadRegistros: function () {

            this.paginas = Math.ceil(this.Usuarios.length / this.elementosXPagina);
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


    },
})
