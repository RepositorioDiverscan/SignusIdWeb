var urlPerfil = 'AjaxPerfilUsuario.aspx'
var urlIdioma = 'AjaxIdiomaPerfilUsuario.aspx'


/*const alertas = require('../Alertas/alertas.js');*/



const Perfil = new Vue({

    el: '#Perfil',

    data: {
        listaIdiomas: [],
        datosUsuario: [],
        idPerfilUsuario: 0,
        nombre: '',
        apellidos: '',
        identificacion: '',
        correo: '',
        contrasenia: '',
        imagenPerfil: '',
        telefono: '',
        puesto: '',
        rol: '',
        idPerfilActive: 0,
        idPerfilEmpresa: 0,
        nuevoNombre: '',
        nuevoApellido: '',
        nuevaIdentificacion: '',
        nuevoCorreo: '',
        nuevoPuesto: '',
        nuevoTelefono: '',
        contrasenia: '',
        contraActual: '',
        nuevaContra: '',
        confirmContra: '',
        selectorImagen: [],
        valorBase: '',
        recargar: 0,
        paises: [],
        paisSel: [],
        monedas: [],
        monedaSel: 0,
        telNational: '',
        phoneInput: ''

    },

    mounted: function () {
        this.ValidarSesion();
        this.listaIdiomas = this.ObtenerIdioma();
        this.CargarInputPaises();
        this.ObtenerDatosUsuario();
        this.cargarImagen();
        this.ObtenerUsuario();
        this.CargarMonedas();
        var a = document.getElementById('BotonEditarImagen');
        a.style.display = "none";
    },

    methods: {

        click() {
            var self = this;
 
        },

        // CONFIGURAR EL IDIOMA

        ObtenerIdioma: function () {

            var idiActualiza = "ES"

            if (localStorage.getItem("idiomaApp") != undefined) {

                idiActualiza = localStorage.getItem("idiomaApp");

            }

            this.EstablecerIdiomaPerfilUsuario(idiActualiza);

        },

        EstablecerIdiomaPerfilUsuario: function (idioma) {

            var self = this

            $.post(urlIdioma, {

                IdiomaPerfilUsuario: idioma,

            }, function (data, error) {

                self.listaIdiomas = JSON.parse(data);

            });

        },

        Limpiar: function () {
            var self = this

            self.nuevoNombre = '';
            self.nuevoApellido = '';
            self.nuevaIdentificacion = '';
            self.nuevoCorreo = '';
            self.nuevoPuesto = '';
            self.nuevoTelefono = '';
        },
        //Obtiene el IdPerfil del usuario y el Id de la empresa con la que conectó el usuario
        ObtenerDatosUsuario: function () {

            let json = JSON.parse(sessionStorage.getItem('DUser'));
            this.datosUsuario = json;

            this.idPerfilUsuario = json[0].IdPerfilUsuario;
            this.idPerfilEmpresa = json[0].IdPerfilEmpresa;
            this.imagenPerfil = json[0].ImagenPerfil;


        },
        //Obtiene los datos completos del usuario y los carga en variables para su uso
        ObtenerUsuario: function () {
            var self = this;

            $.post(urlPerfil, {
                opciones: 'ObtenerUsuario',
                IdPerfilU: self.idPerfilUsuario,
                IdPerfilE: self.idPerfilEmpresa
            }, function (data, error) {
                var usuario = JSON.parse(data);
                self.nombre = usuario.Nombre;
                self.apellidos = usuario.Apellidos;
                self.rol = usuario.Rol;
                self.idPerfilActive = usuario.IdPerfilActive;
                self.identificacion = usuario.Identificacion;
                self.correo = usuario.Correo;
                self.puesto = usuario.Posicion;
                self.phoneInput.setNumber(usuario.Telefono);
                self.contrasenia = usuario.Contrasenia;
                if (usuario.Identificacion != "") {
                    document.getElementById("cedula").readOnly = true;
                }
            }

            );

        },

        //revisa que no hayan inputs vacios y envia los datos para ser evaluados
        ActualizarDatosUsuario: function () {
            var self = this;

            if (self.nombre != "") {
                if (self.apellidos != "") {
                    if (self.identificacion != "") {
                        if (self.correo != "") {
                            if (self.puesto != "") {
                                if (self.phoneInput.getNumber() != "") {

                                    $.post(urlPerfil, {
                                        opciones: 'ActualizarUsuario',
                                        
                                        IdPerfilUsuario: self.idPerfilUsuario,
                                        Nombre: self.nombre,
                                        Apellidos: self.apellidos,
                                        Identificacion: self.identificacion,
                                        Correo: self.correo,
                                        Puesto: self.puesto,
                                        Telefono: self.phoneInput.getNumber(intlTelInputUtils.numberFormat.E164),
                                        IdPerfilEmpresa: self.idPerfilEmpresa

                                    }, function (data, error) {
                                        var msj = JSON.parse(data);

                                        if (msj == "ERROR") {

                                            alertify.error("No se pudo actualizar");

                                        } else if (msj == "TNValido") {
                                            alertify.error(self.listaIdiomas.TelefonoError);

                                        } else if (msj == "CNValido") {
                                            alertify.error(self.listaIdiomas.CorreoError);
                                        } else {
                                            self.ObtenerUsuario();
                                            self.Limpiar();
                                            var prueba = JSON.parse(sessionStorage.getItem('Empresas'));
                                            prueba[0].Nombre = self.nombre;
                                            sessionStorage.setItem('Empresas', JSON.stringify(prueba));
                                            console.log(JSON.parse(sessionStorage.getItem('Empresas')));
                                            alertas.success(self.listaIdiomas.Atencion, self.listaIdiomas.UsuarioActualizado);
                                        }

                                    }

                                    );

                                } else {
                                    alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.LlenarTelefono);
                                }
                            } else {
                                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.LlenarPuesto);
                            }
                        } else {
                            alertify.error(self.listaIdiomas.FaltanCampos);
                        }
                    } else {
                        alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.LlenarIdentificacion);
                    }
                } else {
                    alertify.error(self.listaIdiomas.FaltanCampos);
                }
            } else {
                alertify.error(self.listaIdiomas.FaltanCampos);
            }



        },

        //Envia datos relacionados a contraseñas a ser evaluados
        CambiarContrasenia: function () {
            var self = this;

            $.post(urlPerfil, {
                opciones: 'CambiarContrasennia',

                IdPerfilU: self.idPerfilUsuario,
                Contrasenia: self.contrasenia,
                Correo: self.correo,
                ContraActual: self.contraActual,
                NuevaContrasenia: self.nuevaContra,
                ConfirmCon: self.confirmContra



            }, function (data, error) {
                var msj = JSON.parse(data);

                if (msj == "ActualNo") {
                    alertify.error(self.listaIdiomas.ErrorContraActNoCoincide);
                    alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorContraActNoCoincide);
                } else if (msj == "NuevaNo") {
                    alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorNuevaContraConf);
                } 
                else if (msj == "EXITO") {
                    alertas.success(self.listaIdiomas.Atencion, self.listaIdiomas.ContraActualizada);
                    self.contraActual = ''
                    self.nuevaContra = ''
                    self.confirmContra = ''
                    self.ObtenerUsuario();
                } else if (msj == "Atención! La contraseña debe de tener una longitud entre 8-50 caracteres") {
                    alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorNuevaContraLargo);
                } else if (msj == "Atención! La contraseña debe  contener mínimo un número") {
                    alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorNuevaContraNumero);
                } else if (msj == "Atención! La contraseña debe de tener contener mínimo un carácter especial") {
                    alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorNuevaContraEspecial);
                } else if (msj == "Atención! La contraseña debe  contener mayúsculas") {
                    alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorNuevaContraMayus);
                } else if (msj == "Atención! La contraseña debe  contener minúsculas") {
                    alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorNuevaContraMinus);
                } else if (msj == "Atención! La contraseña no puede ser igual a ninguna de las anteriores") {
                    alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorNuevaContranIgual);
                } else {
                    alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ErrorNuevaContraActualizar);
                }


            }

            );

        },

        // Mostrar Botón Editar imagen cuando pase el mouse

        MostrarBoton: function () {
            var a = document.getElementById('BotonEditarImagen');
            a.style.display = "block";
        },

        OcultarBoton: function () {
            var a = document.getElementById('BotonEditarImagen');



            setTimeout(() => {
                a.style.display = "none";
            }, 2000);

        },

        handleFileSelect: function (evt) {
            var self = this;
            var f = evt.target.files[0];
            var reader = new FileReader();
            reader.onload = (function (theFile) {
                return function (e) {
                    var binaryData = e.target.result;
                    var base64String = window.btoa(binaryData);
                    self.valorBase = base64String;



                    self.cambiarImagen(self.valorBase, self.idPerfilUsuario);
                };
            })(f);
            reader.readAsBinaryString(f);

        },

        cambiarImagen: function (Imagen64A, IdPerfilUsuario) {
            var self = this;
            $.post(urlPerfil, {
                opciones: "CambiarImagen",
                IdUsuario: IdPerfilUsuario,
                Imagen64: Imagen64A,
            }, function (res, error) {
                if (res == 'Ok') {
                    self.cargarImagen();
                    window.location.reload();
                } else {
                    alertify.error(self.listaIdiomas.ModificarImagenError);
                }
            });

        },


        cargarImagen: function () {
            var self = this;

            self.imagenPerfil = ''

            $.post(urlPerfil, {

                opciones: "BuscarImagen",
                IdUsuario: self.idPerfilUsuario,

            }, function (res, error) {
                var img = JSON.parse(res);

                self.imagenPerfil = img;



            });


        },

        ValidarSesion: function () {

            var dConfig = JSON.parse(sessionStorage.getItem('DConfig'));

            if (dConfig == null || dConfig.CofPerfil == false) {
                window.location.href = window.location.origin + "/AccesoDenegado.aspx";
            }
        },

        CargarInputPaises: function () {
            const phoneInputField = document.getElementById("telNational");

            //Configuración del Input tel 
            this.phoneInput = window.intlTelInput(phoneInputField, {
                initialCountry: "cr", //Un prefijo nacional por defecto al cargar
                preferredCountries: ["us", "cr"], //Puedes agregar prefijos preferenciales para que salgan al inicio
                separateDialCode: true, //Mostrar el prefijo seleccionado en el input
                //customPlaceholder: function () {
                //    return "8888-8888";
                //},
                utilsScript: "https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/11.0.14/js/utils.js"
            });
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

        CargarMonedas: function () {

            var self = this;

            var json = JSON.parse(localStorage.getItem('MonedasJSON'));

            self.monedas = json;

        },

    },
    
})




