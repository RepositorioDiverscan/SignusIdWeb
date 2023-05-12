var urlIdioma = 'Ajax/AjaxIdiomaPerfilEmpresa.aspx'
var urlPerfilEmpresa = 'Ajax/AjaxPerfilEmpresa.aspx'
var urlPerfil = '../Perfil/AjaxPerfilUsuario.aspx'

const PerfilEmpresa = new Vue({

    el: '#PerfilEmpresaVUE',

    data: {
        //Variables a utilizar
        listaIdiomas: [],
        ListaPerfilEmpresa: [],
        ListaIndustrias: [],
        DatosUsuario: [],
        selectIndustria: 1,
        selectpais:1,
        Nombre: "",
        Apellido: "",
        IdPerfilActive: "",
        Correo: "",
        CorreoTxt: "",
        Imagen: "",
        IdPerfilEmpresa: "",
        IdPerfilUsuario: "",
        rol: "",
        NombreEmpresa: '',
        NombreEmpresaTitulo: '',
        IdEmpresa: '',
        ContactoPrincipal: '',
        PaisEmpresa: '',
        Direccion: '',
        Telefono: '',
        Industria: '',
        ImagenEmpresa: '',
        ValorBase:"",
        SelectorImagen: [],
        monedas: [],
        monedaSel: 'a',
        telNational: '',
        phoneInput1: '',
        TotalNotificacionesEmp: 0,
    },

    mounted: function () {

        this.ValidarSesion();
        this.listaIdiomas = this.ObtenerIdiomaPerfilEmpresa();
        this.CargarInformacionUsuario();
        this.CargarInformacionEmpresa();
        this.cargarIndustrias();
        this.cargarImagen();
        this.CargarInputPaises();
        this.CargarMonedas();
        this.ConsultarNotificaciones();
        this.RecargarNotificaciones();
    },

    methods: {

        // Metodos para configurar el idioma
        ObtenerIdiomaPerfilEmpresa: function () {

            var idiActualiza = "ES"

            if (localStorage.getItem("idiomaApp") != undefined) {

                idiActualiza = localStorage.getItem("idiomaApp");

            }

            this.EstablecerIdiomaPerfilEmpresa(idiActualiza);

        },

        EstablecerIdiomaPerfilEmpresa: function (idioma) {

            var self = this


            $.post(urlIdioma, {

                IE: idioma,

            }, function (data, error) {
                
                self.listaIdiomas = JSON.parse(data);

            });

        },

        //Carga la información del usuario
        CargarInformacionUsuario: function () {

            var self = this
            
            var prueba = JSON.parse(sessionStorage.getItem('Empresas'));


            self.DatosUsuario = prueba;
            self.Nombre = prueba[0].Nombre;
            self.Apellido = prueba[0].Apellildo;
            self.Correo = prueba[0].Correo;
            self.IdPerfilUsuario = prueba[0].IdPerfilUsuario;
            self.IdPerfilEmpresa = prueba[0].IdPerfilEmpresa;
            self.IdPerfilActive = prueba[0].IdPerfilActive;

            if (prueba[0].ImagenPerfil != "") {
                self.Imagen = prueba[0].ImagenPerfil;
            }
            else {
                self.Imagen = "../images/iconos_admin_activeID_Mesa-de-trabajo-1-copia-3.svg"
            }

            $.post(urlPerfilEmpresa, {
                option: "ConsultarRolUsuario",
                IdEmpresa:self.IdPerfilEmpresa,
                IdperfilUsuario:self.IdPerfilUsuario
            }, function (data, error) {
                self.rol = data;
            });

        },

        //Carga la informacion de la empresa
        CargarInformacionEmpresa: function () {
            var self = this

            var prueba = JSON.parse(sessionStorage.getItem('Empresas'));
            self.IdPerfilEmpresa = prueba[0].IdPerfilEmpresa;

            self.ImagenEmpresa = ' ';

            $.post(urlPerfilEmpresa, {
                option: "ConsultaPerfil",
                IdEmpresa: self.IdPerfilEmpresa
            }, function (data, error) {
                self.ListaPerfilEmpresa = JSON.parse(data);

                var json = JSON.parse(data);
                self.NombreEmpresaTitulo = json[0].Nombre;
                self.ImagenEmpresa = json[0].Imagen;
                self.IdEmpresa = json[0].IdEmpresa;
                self.NombreEmpresa = json[0].Nombre;
                self.ContactoPrincipal = json[0].ContactoPrincipal;
                self.Direccion = json[0].Direccion;
                $("#country1").countrySelect("setCountry", json[0].Pais);
                self.CorreoTxt = json[0].Correo;
                self.phoneInput1.setNumber(json[0].Telefono);
                self.selectIndustria = json[0].Industria;
                self.selectpais = json[0].Pais;
                self.monedaSel = json[0].Moneda;
            });
        },

        //Carga el combo de las industrias
        cargarIndustrias: function () {
            var self = this

            $.post(urlPerfilEmpresa, {
                option: "ConsultarIndustrias",
            }, function (data, error) {
                var resp = JSON.parse(data);
                self.ListaIndustrias = resp;
            });
        },

        //Modifica la informacion del perfil de la empresa
        ModificarPerfilEmpresa: function () {
            var self = this;
            this.PaisEmpresa = $("#country1").countrySelect("getSelectedCountryData").name;
            var prueba = JSON.parse(sessionStorage.getItem('Empresas'));
            self.IdPerfilEmpresa = prueba[0].IdPerfilEmpresa;

            if (self.IdPerfilEmpresa == "" || self.IdEmpresa == "") {
                alertify.error(self.listaIdiomas.DatosIncompletos)
            }
            else if (self.NombreEmpresa == "") {
                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.LlenarNombreEmpresa);
            }
            else if (self.ContactoPrincipal == "") {
                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.LlenarContactoPrincipal);
            }
            else if (self.Direccion == "") {
                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.LlenarDireccion);
            }
            else if (self.CorreoTxt == "") {
                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.LlenarCorreoTxt);
            }
            else if (this.phoneInput1.getNumber(intlTelInputUtils.numberFormat.E164) == "") {
                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.LlenarTelefono);
            }
            else if (self.selectIndustria == 0) {
                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.LlenarIndustria);
            }
            else if (this.PaisEmpresa == "") {
                alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.LlenarPais);
            }
            else {

                $.post(urlPerfilEmpresa, {
                    option: "ActualizarPerfil",
                    NuevoPerfil: JSON.stringify({
                        IdPerfilEmpresa: self.IdPerfilEmpresa,
                        IdEmpresa: self.IdEmpresa,
                        Nombre: self.NombreEmpresa,
                        ContactoPrincipal: self.ContactoPrincipal,
                        Direccion: self.Direccion,
                        Pais: this.PaisEmpresa,
                        Correo: self.CorreoTxt,
                        Telefono: self.phoneInput1.getNumber(),
                        Industria: self.selectIndustria,
                        Moneda: self.monedaSel,
                    })

                }, function (respuesta, error) {
                    if (respuesta == "Actualizado") {
                        alertas.success(self.listaIdiomas.Atencion, self.listaIdiomas.ActualizaOk);
                    } else if (respuesta == "Correo no válido") {
                        alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.CorreoError);
                    } else if (respuesta = "El correo ingresado ya se encuentra registrado") {
                        alertas.error(self.listaIdiomas.Atencion, "El correo ingresado ya se encuentra registrado");
                    }
                    else {
                        alertas.error(self.listaIdiomas.Atencion, self.listaIdiomas.ActualizaError);
                    }

                });
            }
        },

        previewFiles(event) {
            
        },

        handleFileSelect: function (evt) {
            var self = this;
                var f = evt.target.files[0];
                var reader = new FileReader();
                reader.onload = (function (theFile) {
                    return function (e) {
                        var binaryData = e.target.result;
                        var base64String = window.btoa(binaryData);
                        self.ValorBase = base64String;

                        self.cambiarImagen(self.ValorBase, self.IdPerfilEmpresa);
                    };
                })(f);
            reader.readAsBinaryString(f);
         
        },

        cambiarImagen: function (Imagen64A, IdEmpresaA) {
            var self = this;
            $.post(urlPerfilEmpresa, {
                option: "CambiarImagen",
                IdEmpresa: IdEmpresaA,
                Imagen64: Imagen64A,
            }, function (res, error) {
                if (res == 'Ok') {
                    self.CargarInformacionEmpresa();
                    alertify.success(self.listaIdiomas.ModificarImagenOk);
                } else {
                    alertify.error(self.listaIdiomas.ModificarImagenError);
                }
            });

        },

        cargarImagen: function () {
            var self = this;

            self.Imagen = ''

            $.post(urlPerfil, {

                opciones: "BuscarImagen",
                IdUsuario: self.IdPerfilUsuario

            }, function (res, error) {
                var img = JSON.parse(res);

                self.Imagen = img;
            });


        },

        ValidarSesion: function () {

            var dConfig = JSON.parse(sessionStorage.getItem('DConfig'));
            var dUser = JSON.parse(sessionStorage.getItem('DUser'));

            if (dConfig == null || dConfig.CofPerfil == false || dUser == null || dUser[0].TipoUsuario != 1 ) {
                window.location.href = window.location.origin + "/AccesoDenegado.aspx";
            }
        },

        click: function () {
            var self = this;
            
        },

        CargarMonedas: function () {

            var self = this;

            var json = JSON.parse(localStorage.getItem('MonedasJSON'));

            self.monedas = json;

        },

        CargarInputPaises: function () {
            const phoneInputField = document.getElementById("telNational");

            //Configuración del Input tel 
            this.phoneInput1 = window.intlTelInput(phoneInputField, {
                initialCountry: "cr", //Un prefijo nacional por defecto al cargar
                preferredCountries: ["us", "cr"], //Puedes agregar prefijos preferenciales para que salgan al inicio
                separateDialCode: true, //Mostrar el prefijo seleccionado en el input
                autoPlaceholder: "off", //Desactivar el placeholder por defecto
                utilsScript: "https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/11.0.14/js/utils.js"
            });

            //Configuracion del campo de seleccion de paises
            $("#country1").countrySelect({
                defaultCountry: "cr",
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

        ConsultarNotificaciones: function () {
            var self = this;


            $.post(urlPerfil, {

                opciones: "ConsultarNotificaciones",
                IdPerfilActive: self.IdPerfilActive,

            }, function (res, error) {
                var total = JSON.parse(res);
                self.TotalNotificacionesEmp = total;

            });


        },

        RecargarNotificaciones: function () {
            var self = this;

            setInterval(function () {
                self.ConsultarNotificaciones();
            }, 30000);
        },

    },
    watch: {
        //TotalNotificacionesEmp(val) {
        //    var divNot = document.getElementById('notif');
        //    if (val > 0) {
        //        divNot.setAttribute("style", "display:flex")
        //    }
        //    else {
        //        divNot.setAttribute("style", "display:none")
        //    }
        //}
    }
})