
var urlIdioma = 'Idioma/IdiomaRegistroActivos.aspx'
var urlRegistro = '../RegistroActivos/RegistroActivosAjax.aspx'
var urlCategoria = '../CategoriaActivo/Categoria/CategoriaActivo.aspx'
var urlEstado = '../EstadoActivoFijo/EstadoActivo/EstadoActivo.aspx'
var urlUbicacion = '../Ubicaciones/UbicacionA/UbicacionAjax.aspx'
var urlActivos = '../Activos/ActivoAjax.aspx'

const registroactivo = new Vue({
    el: '#registroactivosVUE',
    data: {
        listaidiomaRegistroActivo: [],
        IdiomaRegistroActivos: "",
        //Datos para select
        editarselect: '',
        NSelect: 'pointer-events:none',
        editarcampos: false,
        fechaCompra: '',
        fechaHoy: '',
        selectCategoria: '0',
        selectEstado: '0',
        selectUbicacion: '0',
        Categorias: Object,
        Estados: Object,
        Ubicaciones: Object,
        idActivo: '-1',
        IdCategoria: '-1',
        IdEstado: '-1',
        IdUbicacion: '-1',
        listaRegistroActivos: [],
        numActivo: '',
        numPlaca: '',
        marca: '',
        modelo: '',
        ubicacion: '',
        observaciones: '',
        descripcion: '',
        numSerie: '',
        idPerfilActive: '',
        idPerfilEmpresa: '',
        select: '',
        descripCorta: '',
        descripcionCategoria: '',
        descripEstado: '',
        numFactura: '',
        costoActivo: '',
        Seleccion: '0',
        ValorAct: '1',
        ValorPlac: '2',
        ValorDesc: '3',
        numeroActivo: '',
        listaActivos: [],
        NumParteActivo: '',
        Decreciado: '',
        Descripcion: '',
        VidaUtil: '',
        CuentaContable: '',
        CentroCostos: '',
        DesEst: '',
        TagECP: '',
        txtnumActivo:'',
        FechaG: '',
        Color: '',
        Tam: '',
        Observ: '',
        Fechagarantia:'',
    },
    mounted: function () {
        this.ValidarSesion();
        var self = this;
        var logueado = JSON.parse(sessionStorage.getItem('DUser'));
        this.idPerfilActive = "" + logueado[0].IdPerfilActive;
        this.idPerfilEmpresa = "" + logueado[0].IdPerfilEmpresa;
        this.EstablecerFechasHoy();
        listaidiomaRegistroActivo= this.ObtenerIdioma();
        this.ObtenerCategorias();
        this.ObtenerEstados();
        this.ObtenerUbicaciones();
        this.DesactivarCampos();
 
    },
    methods: {
        activo(activo) {
            if (activo > 0) {
                return true
            } else {
                return false
            }
        },
        EstablecerFechasHoy: function () {
            var tiempoTranscurrido = Date.now();
            var actual = new Date(tiempoTranscurrido);
            var mes = actual.getMonth() + 1;
            if (mes < 10) {
                mes = '0' + mes;
            }
            var dia = actual.getDate().toString();
            if (dia < 10) {
                dia = '0' + dia;
            }
            var anno = actual.getFullYear().toString();
            this.fechaCompra = anno + "-" + mes + "-" + dia;
            this.fechaHoy = anno + "-" + mes + "-" + dia;
        },
        ValidarFecha: function () {

            var self = this
            if (self.fechaCompra > self.fechaHoy) {
                self.fechaCompra = self.fechaHoy
            }

        },

        ObtenerIdioma: function () {
            var idiRegistro = "ES"
            if (localStorage.getItem("idiomaApp") != undefined) {
                idiRegistro = localStorage.getItem("idiomaApp");
            }
            this.EstablecerIdiomaRegistroActivo(idiRegistro);
        },
        EstablecerIdiomaRegistroActivo: function (idioma) {
            var self = this
            $.post(urlIdioma, {
                IdiomaRegistroActivos: idioma,
            }, function (data, error) {
                self.listaidiomaRegistroActivo = JSON.parse(data);
            });
        },
        ObtenerCategorias: function () {
            var self = this
            $.post(urlCategoria, {
                option: 'ConsultaCategoriaActivo',
            }, function (data, error) {
                self.Categorias = JSON.parse(data);

            });
        },
        ObtenerEstados: function () {
            var self = this
            $.post(urlEstado, {
                option: 'ConsultaEstadoActivo',
            }, function (data, error) {
                self.Estados = JSON.parse(data);

            });
        },
        ObtenerUbicaciones: function (IdPerfil) {
            var self = this
            $.post(urlUbicacion, {
                option: 'ConsultarUbicaciones',
                IdPerfilEmpresa: self.idPerfilEmpresa

            }, function (data, error) {
                self.Ubicaciones = JSON.parse(data);

            });
        },
        ObtenerRegistroActivos: function () {
            var self = this
            $.post(urlRegistro, {
                option: 'ConsultaRegistroActivo',
                IdPerfilEmpresa: self.idPerfilEmpresa

            }, function (respuesta, error) {
                var resp = JSON.parse(respuesta);
                self.listaRegistroActivos = resp


            });
        },

        GuardarRegistroActivos: function () {
            var self = this;
            var a;
            if (this.numActivo != "") {
                this.ModificarActivo();
            }
            else if (this.numPlaca == "") {
                alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.Valnumetiqueta);
                a = document.getElementById('nPlaca');
                a.focus();
                return
            }
            else if (this.descripCorta == "") {
                alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.ValidDescCorta);
                a = document.getElementById('descCorta');
                a.focus();
                return
            }
            else if (this.selectCategoria == '0') {
                alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.ValidCategoria);
                a = document.getElementById('selCat');
                a.focus();
                return
            }
            else if (this.selectEstado == '0') {
                alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.ValidEstado);
                a = document.getElementById('selEst');
                a.focus();
                return
            }
            else if (this.selectUbicacion == '0') {
                alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.ValidUbicacion);
                a = document.getElementById('selU');
                a.focus();
                return
            }
            else if (this.marca == '') {
                alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.Valmarca);
                a = document.getElementById('marca');
                a.focus();
                return
            }

            else {

                
                

                Swal.fire({
                    title: '<strong>Una vez que confirmes este proceso no se van a poder editar los siguientes campos <u>Número de serie, </u> <u>Número de factura,</u><u>Modelo,</u></u><u>Marca,</u><u>Categoría</u></strong > ',
                    icon: 'info',
                    html:
                        'Por favor, verifique que los datos sean correctos antes de confirmar' 
                         +
                        '',
                    showCloseButton: true,
                    showCancelButton: true,
                    focusConfirm: false,
                    confirmButtonText:
                        'Guardar',
                    confirmButtonAriaLabel: "thumbs-up",
                    cancelButtonText:
                        'Cancelar',
                    cancelButtonAriaLabel:" thumbs-down",
                }).then((result) => {
                    /* Read more about isConfirmed, isDenied below */
                    if (result.isConfirmed)

                    {

                        self.InsertarActivo();

                        
                    } else if (result.isDenied) {
                        Swal.fire('Cancelar', '', 'info')
                    }
                })

               
            }
        },

      
        InsertarActivo: function () {
            var self = this;
            

            $.post(urlRegistro, {
                option: 'InsertarActivoFijo',
                IdPerfilEmpresa: self.idPerfilEmpresa,
                NumeroActivo: self.txtnumActivo,
                PlacaActivo: self.numPlaca,
                Observacion: 'sin observacion',
                Marca: self.marca,
                Modelo: self.modelo,
                IdEstadoActivo: self.selectEstado,
                IdCategoriaActivo: self.selectCategoria,
                IdUbicacionA: self.selectUbicacion,
                NumeroSerie: self.numSerie,
                DescripcionCorta: self.descripCorta,
                DescripcionCategoria: self.descripcionCategoria,
                DescripcionEstado: self.descripEstado,
                NumeroFactura: self.numFactura,
                FechaCompra: self.fechaCompra,
                CostoActivo: self.costoActivo,
            }, function (respuesta, error) {
                if (respuesta == "Registrado") {
                    alertas.success(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.AgregarCorrecto);
                    self.BorrarDatos();
                } else if (respuesta == "Existe") {
                    alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.ValidActNumAct);
                    self.BorrarDatos();
                } else {
                    //alertify.error(self.listaidiomaRegistroActivo.AgregarError);
                    alertas.error(self.listaidiomaRegistroActivo.Atencion, respuesta);
                  
                    return
                }

            });
        },
        ModificarActivo: function () {
            var self = this;
            if (this.txtnumActivo == '' || this.txtnumActivo == ' ') {
                alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.ValidNumActivo);
                return
            }
            else if (this.numPlaca == "") {
                alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.Valnumetiqueta);
                a = document.getElementById('nPlaca');
                a.focus();
                return
            }
            else if (this.descripCorta == "") {
                alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.ValidDescCorta);
                a = document.getElementById('descCorta');
                a.focus();
                return
            }
            else if (this.selectCategoria == '0') {
                alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.ValidCategoria);
                a = document.getElementById('selCat');
                a.focus();
                return
            }
            else if (this.selectEstado == '0') {
                alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.ValidEstado);
                a = document.getElementById('selEst');
                a.focus();
                return
            }
            else if (this.selectUbicacion == '0') {
                alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.ValidUbicacion);
                a = document.getElementById('selU');
                a.focus();
                return
            }
            else if (this.marca == '') {
                alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.Valmarca);
                a = document.getElementById('marca');
                a.focus();
                return






            }

            else {
                var self = this
                $.post(urlRegistro, {

                    option: 'ActualizaActivoFijo',
                    IdActivo: this.idActivo,
                    NumeroActivo: this.txtnumActivo,
                    PlacaActivo: this.numPlaca,
                    Observacion: 'sin observacion',
                    Marca: this.marca,
                    Modelo: this.modelo,
                    IdEstadoActivo: this.selectEstado,
                    IdCategoriaActivo: this.selectCategoria,
                    IdUbicacionA: this.selectUbicacion,
                    NumeroSerie: this.numSerie,
                    DescripcionCorta: this.descripCorta,
                    DescripcionCategoria: this.descripcionCategoria,
                    DescripcionEstado: this.descripEstado,
                    NumeroFactura: this.numFactura,
                    FechaCompra: this.fechaCompra,
                    CostoActivo: this.costoActivo,

                }, function (respuesta, error) {
                    if (respuesta == "Actualizado") {
                        self.BorrarDatos();
                        alertas.success(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.ActualizaCorrecto);
                        //aca
                        sessionStorage.removeItem("DatosActivoEditar");

                    } else {
                        alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.ActualizaError);
                    }
                })
            }

         
        },

        DatosActivoEditar: function () {
            var self = this;
            
            // ir a la base datos
            $.post(urlActivos, {
                option: 'ObtenerActivoPorNumActivoCompleto',
                NumeroActivo: self.numActivo,
                IdPerfilEmpresa: self.idPerfilEmpresa
            }, function (respuesta, error) {
                var resp = JSON.parse(respuesta);
                self.listaActivos = [];
                for (let i = 0; i < resp.length; i += 1) {
                    this.idActivo = resp[i].IdActivo;
                    self.numeroActivo = '';
                    self.txtnumActivo = resp[i].NumeroActivo;
                    self.numPlaca = resp[i].PlacaActivo;
                    self.descripCorta = resp[i].DescripcionCorta;
                    self.selectCategoria = resp[i].IdCategoriaActivo;
                    self.descripcionCategoria = resp[i].DescripcionCategoria;
                    self.selectEstado = resp[i].IdEstadoActivo;
                    self.descripEstado = resp[i].DescripcionEstado;
                    self.selectUbicacion = resp[i].IdUbicacionA;
                    self.marca = resp[i].Marca;
                    self.modelo = resp[i].Modelo;
                    self.numSerie = resp[i].NumeroSerie;
                    self.costoActivo = resp[i].CostoActivo;
                    self.numFactura = resp[i].NumeroFactura;
                    self.editarcampos = true;
                    self.editarselect= "pointer-events:none";
                    self.fechaCompra = resp[i].FechaCompra.split('T')[0];
                    self.ObtenerDescripcionCategoria();
                    self.ObtenerDescripcionEstados();
                }
            });
        },

        BorrarDatos: function () {
            var self = this;
            this.idActivo = '';
            self.numActivo = '';
            self.editarselect = "pointer-events:all";
            self.numeroActivo = '';
            self.txtnumActivo = '';
            self.numPlaca = '';
            self.descripCorta = '';
            self.selectCategoria = '0';
            self.descripcionCategoria = '';
            self.selectEstado = '0';
            self.descripEstado = '';
            self.selectUbicacion = '0';
            self.Seleccion = '0';
            self.marca = '';
            self.modelo = '';
            self.numSerie = '';
            self.costoActivo = '';
            self.numFactura = '';
            self.fechaCompra = '';
            this.EstablecerFechasHoy();
            self.editarcampos = false;
            sessionStorage.removeItem("DatosActivoEditar");
        },


        ObtenerActivoPorNumActivo: function () {
            var self = this
            $.post(urlActivos, {
                option: 'ObtenerActivoPorNumActivo',
                NumeroActivo: self.numeroActivo,
                IdPerfilEmpresa: self.idPerfilEmpresa
            }, function (respuesta, error) {
                var resp = JSON.parse(respuesta);
                self.listaActivos = [];
                for (let i = 0; i < resp.length; i += 1) {
                    self.idActivo = resp[i].IdActivo;
                    self.numActivo = resp[i].NumeroActivo;
                }
               
                if (resp.length == 0) {
                    alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.IngrErrNumActivo);
                }
                else {
                    self.DatosActivoEditar();
                }

            });


        },

        ObtenerActivoPorNumPlaca: function () {
            var self = this
            $.post(urlActivos, {
                option: 'ObtenerActivoPorNumPlaca',

                PlacaActivo: self.numeroActivo,
                IdPerfilEmpresa: self.idPerfilEmpresa
            }, function (respuesta, error) {
                var resp = JSON.parse(respuesta);
                self.listaActivos = [];
                for (let i = 0; i < resp.length; i += 1) {
                    self.idActivo = resp[i].IdActivo;
                    self.numActivo = resp[i].NumeroActivo;
                }
                self.DatosActivoEditar();
                if (resp.length == 0) {
                    alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.IngrErrNumActivo);
                }
                else {
                    self.DatosActivoEditar();
                }

            });

        },
        //Carga la descripcion del estado
        ObtenerDescripcionCategoria: function () {
            var self = this
            $.post(urlCategoria, {
                option: 'ConsultaDescCategoriaX',
                IdCategoria: self.selectCategoria,
            }, function (data, error) {
                self.descripcionCategoria = data;

            });
        },
        //Carga la descripcion del estado
        ObtenerDescripcionEstados: function () {
            var self = this
            $.post(urlEstado, {
                option: 'ConsultaDescEstadoX',
                IdEstado: self.selectEstado,
            }, function (data, error) {
                self.descripEstado = data;

            });
        },
        //Inhabilita los campos 
        DesactivarCampos: function () {
            Decreciado = true;
            Descripcion = true;
            VidaUtil = true;
            CuentaContable = true;
            CentroCostos = true;
            DesEst = true;
            TagECP = true;
            FechaG = true;
            Color = true;
            Tam = true;
            Observ = true;
            NumParteActivo = true;
        },
        //Busca las el activo segun el filtro de busqueda
        BuscarActivo: function () {
            var self = this;
            if (self.Seleccion == '0') {
                alertas.error(self.listaidiomaRegistroActivo.Atencion, self.listaidiomaRegistroActivo.Selectmsj);
            }
            else if (this.numeroActivo == '' || this.numeroActivo == ' ') {
                if (self.Seleccion == self.ValorAct) {
                    alertify.error(this.listaidiomaRegistroActivo.ValidNumActivo);
                } else if (self.Seleccion == self.ValorPlac) {
                    alertify.error(this.listaidiomaRegistroActivo.Valnumetiqueta);
                }
            } else {
                if (self.Seleccion == self.ValorAct) {
                    this.ObtenerActivoPorNumActivo();
                } else if (self.Seleccion == self.ValorPlac) {
                    this.ObtenerActivoPorNumPlaca();
                } else if (self.Seleccion == self.ValorDesc) {
                    this.ObtenerActivoPorDescripcion();
                }
            }
        },

        ValidarSesion: function () {

            var dConfig = JSON.parse(sessionStorage.getItem('DConfig'));

            if (dConfig == null || dConfig.RegistroActivos == false) {
                window.location.href = window.location.origin + "/AccesoDenegado.aspx";
            }
        },

        AbrirDatePicker: function(valor) {
            var inputCalendario = document.getElementById(valor);
            inputCalendario.showPicker();

        },

    },
})





