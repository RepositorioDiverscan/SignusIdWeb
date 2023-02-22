var urlIdioma = 'Idioma/IdiomaSincronizacion.aspx'
var urlSincroniza = '../SincronizarActivos/SincronizarActivosAjax.aspx'
var urlCategoria = '../CategoriaActivo/Categoria/CategoriaActivo.aspx'
var urlEstado = '../EstadoActivoFijo/EstadoActivo/EstadoActivo.aspx'
var urlUbicacion = '../Ubicaciones/UbicacionA/UbicacionAjax.aspx'
var EstadoActivo = 0

const contrato = new Vue({

    el: '#context',
    //Variables para utilizar en el v-model de vue.
    data: {
        listaidiomaSincronizActivo: {},
        IdiomaSincronizacion: "",
        listaInicial: [],
        listaActivos: [],
        listaFinal: [],
        ValorBase: "",
        TotalActivos: 0,
        NombreArchivo: "",
        ActivosCorrectos: 0,
        ActivosIncorrectos: 0,
        ActivosPendientes: 0,
        idPerfilEmpresa: "",
        listaCorrectos: [],
        IdArchivo: "",
        listaErrores: [],
        EstadoArchivo: '',
        EstadoActivo: "../images/x.svg",
        SelectorA: [],
        tabla1elementosXPagina: 50,
        tabla1paginas: 0,
        tabla1datosPaginados: [],
        tabla1datosFiltrados: [],
        tabla1paginaActual: 1,
        tabla2elementosXPagina: 50,
        tabla2paginas: 0,
        tabla2datosPaginados: [],
        tabla2datosFiltrados: [],
        tabla2paginaActual: 1,
    },
    mounted: function () {
        this.ValidarSesion();
        var logueado = JSON.parse(sessionStorage.getItem('DUser'));
        this.idPerfilActive = "" + logueado[0].IdPerfilActive;
        this.idPerfilEmpresa = "" + logueado[0].IdPerfilEmpresa;

        /* Llamados a metodos para cargar la informacion necesaria.*/
        var idiLog = "ES"
        if (localStorage.getItem("idiomaApp") != undefined) {
            idiLog = localStorage.getItem("idiomaApp");
        }
        this.idiomaLogin = idiLog;
        this.estableceridiomalogin(this.idiomaLogin);
        this.ObtenerInfoArchivos();
    },
    methods: {

        //Metodo para cargar los idiomas.
        estableceridiomalogin: function (tipoIdioma) {
            var self = this;
            $.post(urlIdioma, {
                idioma: tipoIdioma,
            }, function (data, error) {
                self.listaidiomaSincronizActivo = JSON.parse(data);
            });
        },



        //Codigo del js anterior.


        //Headers
        ObtenerHeaders1: function () {
            return JSON.parse('{"headersInfo":["' + this.listaidiomaSincronizActivo.NombreArch + '","' + this.listaidiomaSincronizActivo.TotalAct + '","'
                + this.listaidiomaSincronizActivo.ActivosCorr + '","' + this.listaidiomaSincronizActivo.ActivosIncorr + '","' + this.listaidiomaSincronizActivo.ActivPend
                + '"]}')
        },
        ObtenerHeadersActivos: function () {
            return JSON.parse('{"headersInfo":["' + this.listaidiomaSincronizActivo.NumAct + '","' + this.listaidiomaSincronizActivo.NumEtiq + '","'
                + this.listaidiomaSincronizActivo.Categ + '","' + this.listaidiomaSincronizActivo.Estado + '","' + this.listaidiomaSincronizActivo.Marca + '","' + this.listaidiomaSincronizActivo.Modelo +
                '","' + this.listaidiomaSincronizActivo.Ubicacion + '","' + this.listaidiomaSincronizActivo.Descripcion + '","' + this.listaidiomaSincronizActivo.Costo + '"]}')
        },
        ObtenerHeadersFinal: function () {
            return JSON.parse('{"headersInfo":["' + this.listaidiomaSincronizActivo.Numero + '","' + this.listaidiomaSincronizActivo.Fecha
                + '"]}')
        },
        //Botones
        ObtenerBotones: function () {
            let botones = []
            botones.push([this.EliminarArchivo, '../images/delete_negro.svg']);
            botones.push([this.InsertarActivoFijo, '../images/save_negro.svg']);
            return botones;
        },
        ObtenerBotonTienda: function () {
            let botones = []
            botones.push([this.ObtenerTienda, '../images/Tienda.png']);
            return botones;
        },
        //Estados
        ObtenerEstadoActivos: function () {
            var imgState = "";
            if (EstadoActivo == 0) {
                imgState = '../images/x.svg';
            } else if (EstadoActivo == 1) {
                imgState = '../images/check.svg';
            }
            return imgState;
        },
        //Metodos
        ObtenerTienda: function () {
        },

        EliminarArchivo: function (informacion) {
            let idArchivoI = informacion.NumActivo;
            var self = this;
            alertify.confirm('Sincronización de Activos', 'Desea eliminar el archivo?', function () {
                $.post(urlSincroniza, {
                    option: 'BorrarArchivo',
                    IdArchivo: idArchivoI,
                    IdPerfilEmpresa: self.idPerfilEmpresa
                }, function (respo, error) {
                    if (respo == "Exitoso") {
                        alertas.success(self.listaidiomaSincronizActivo.Atencion, self.listaidiomaSincronizActivo.MsjEliminado);
                        self.ObtenerInfoArchivos();
                    } else {
                        alertas.error(self.listaidiomaSincronizActivo.Atencion, self.listaidiomaSincronizActivo.MsjErrorEjec);
                    }
                })
            }
                , function () { alertify.error('Cancel') });


        },
        ExportarExcel: function () {
            var self = this;
            var hola = self.idPerfilEmpresa;
            var idiRegistro = "ES";
            if (localStorage.getItem("idiomaApp") != undefined) {
                idiRegistro = localStorage.getItem("idiomaApp");
            }
            $.post(urlSincroniza, {
                option: 'Exportar',
                IdiomaSincronizaActivo: idiRegistro,
                IdPerfilEmpresa: self.idPerfilEmpresa

            }, function (data, error) {
                var nombre = 'Activos'
                fetch(data)
                    .then(resp => resp.blob())
                    .then(blob => {
                        const url = window.URL.createObjectURL(blob);
                        const a = document.createElement('a');
                        a.style.display = 'none';
                        a.href = url;
                        a.download = nombre;
                        document.body.appendChild(a);
                        a.click();
                        window.URL.revokeObjectURL(url);
                    })
            })
        },

       

        Importar: function (evt) {
            var self = this;
            this.ActivosCorrectos = 0;
            let nombrearchivo = evt.target.files[0].name.split('.');

            if (nombrearchivo[1] == "xlsx" || nombrearchivo[1] == "xls") {


                var f = evt.target.files[0];
                var reader = new FileReader();
                reader.onload = (function (theFile) {
                    return function (e) {
                        var binaryData = e.target.result;
                        var base64String = window.btoa(binaryData);
                        self.ValorBase = base64String;

                        $.post(urlSincroniza, {
                            option: 'Importar',
                            ExcelBase64: self.ValorBase,
                            IdPerfilEmpresa: self.idPerfilEmpresa

                        }, function (data, error) {
                            var resp = JSON.parse(data);
                            self.listaActivos = [];
                            self.EstadoActivo = "../images/x.svg";

                            self.CrearTablaActivosNoSincronizados(resp);

                            //Se Crea una variable y se le asigna el nombre del archivo y se le hace un split para
                            //separarlo de la extencion.
                            let nombrearchivo = evt.target.files[0].name.split('.');

                            self.NombreArchivo = nombrearchivo[0];

                            self.TotalActivos = resp.length;
                                self.ActivosCorrectos = 0;
                                self.ActivosIncorrectos = 0;

                            self.ActivosPendientes = resp.length;

                        })

                    };
                })(f);
                reader.readAsBinaryString(f);


            } else {
                alertas.error(self.listaidiomaSincronizActivo.Atencion, "El archivo seleccionado no tiene el formato correcto");
            }
                




        },
        ObtenerInfoArchivos: function () {
            var self = this
            $.post(urlSincroniza, {
                option: 'ConsultaArchivo',
                IdPerfilEmpresa: self.idPerfilEmpresa

            }, function (respuesta, error) {
                var resp = JSON.parse(respuesta);
                self.listaFinal = [];

                for (let i = 0; i < resp.length; i += 1) {

                    //Creacion de Objeto
                    var Archivos = new Object()

                    //Instanciar variables que guarden la información del excel
                    let NumActivo = resp[i].IdArchivo;
                    let NumActivo2 = resp[i].IdArchivo;
                    let FechaRegistro = resp[i].FechaRegistro.split('T')[0];
                    let Estado = "../images/x.svg"
                    if (resp[i].EstadoArchivo == 1) {
                        Estado = "../images/check.svg";
                    } else {
                    }
                    
                    let Nombre = resp[i].Nombre;


                    //Agregar las variables al objeto
                    Archivos.NumActivo = NumActivo;
                    Archivos.NumActivo2 = NumActivo2;
                    Archivos.FechaRegistro = FechaRegistro;
                    Archivos.Estado = Estado;
                    Archivos.Nombre = Nombre;

                    self.listaFinal.push(Archivos);

                    self.CantidadRegistrostabla2();
                }

            });
        },
        InsertarActivoFijo: function (info) {
            let idArchivoI = info;
            var self = this;
            $.post(urlSincroniza, {
                option: 'InsertarActivoFijo',
                IdArchivo: idArchivoI,
                IdPerfilEmpresa: self.idPerfilEmpresa
            }, function (respo, error) {
                if (respo == "exitoso") {
                    alertas.success(self.listaidiomaSincronizActivo.Atencion, self.listaidiomaSincronizActivo.MsjExitoEjec);
                } else if (respo == "Existe") {
                    alertas.error(self.listaidiomaSincronizActivo.Atencion, self.listaidiomaSincronizActivo.MsjErrorEjec);
                }
            })
        },
        InsertarTablaIntermedia: function () {
            var self = this;
            self.ActivosPendientes = 0;


            if (this.listaActivos.length == 0) {
                alertas.error(self.listaidiomaSincronizActivo.Atencion, self.listaidiomaSincronizActivo.CargaArchivo);
                return;
            }
            $.post(urlSincroniza, {
                option: 'InsertarArchivo',
                IdPerfilEmpresa: self.idPerfilEmpresa,
                Estado: 1,
                NombreArchivo: self.NombreArchivo,
            }, function (data, error) {
                self.IdArchivo = data;
                self.listaErrores = [];
                self.listaActivos.forEach(function (valor, indice, array) {
                    $.post(urlSincroniza, {
                        option: 'InsertarActivoSincronizacion',
                        NumeroActivo: valor.NumActivo,
                        PlacaActivo: valor.NumEtiqueta,
                        CategoriaActivo: valor.Categoria,
                        EstadoActivo: valor.Estado,
                        Marca: valor.Marca,
                        Modelo: valor.Modelo,
                        UbicacionA: valor.Ubicacion,
                        DescripcionCorta: valor.Descripcion,
                        CostoActivo: valor.Costo,
                        IdSincArchivo: self.IdArchivo,
                        IdPerfilEmpresa: self.idPerfilEmpresa
                    }, function (respuesta, error) {
                        if (respuesta == "Registrado" || respuesta == "ExisteActivo") {
                           /* alertify.success(self.listaidiomaSincronizActivo.MsjRegistrado);*/
                            valor.EstadoActivo = "../images/check.svg";
                            self.ActivosCorrectos = self.ActivosCorrectos + 1;
                            //self.EstadoArchivo = 'EstSinc1';
                            //self.listaErrores.push("EstSinc1");

                        } else if (respuesta == "Ya supero el total de activos permitidos") {
                           /* alertify.error("Ya supero el total de activos permitidos");*/
/*                            self.EstadoArchivo = 'EstSinc0';*/
                            valor.EstadoActivo = "../images/x.svg";
                            self.ActivosPendientes = self.ActivosPendientes + 1;
/*                            self.listaErrores.push("EstSinc0");*/


                        } else if (respuesta == "ExisteActivo") {
                           /* alertify.error(self.listaidiomaSincronizActivo.RegistroEx);*/
/*                            self.EstadoArchivo = 'EstSinc0';*/
                            valor.EstadoActivo = "../images/x.svg";
                            self.ActivosIncorrectos = self.ActivosIncorrectos + 1;
/*                            self.listaErrores.push("EstSinc0");*/


                        } else if (respuesta == "NoExisteU") {
                         /* alertify.error(self.listaidiomaSincronizActivo.MsjUbicacion);*/
/*                            self.EstadoArchivo = 'EstSinc0';*/
                            valor.EstadoActivo = "../images/x.svg";
                            self.ActivosIncorrectos = self.ActivosIncorrectos + 1;
/*                            self.listaErrores.push("EstSinc0");*/


                        } else if (respuesta == "NoExisteE") {
                        /*    alertify.error(self.listaidiomaSincronizActivo.MsjEstado);*/
/*                            self.EstadoArchivo = 'EstSinc0';*/
                            valor.EstadoActivo = "../images/x.svg";
                            self.ActivosIncorrectos = self.ActivosIncorrectos + 1;
/*                            self.listaErrores.push("EstSinc0");*/

                        } else if (respuesta == "NoExisteC") {
                        /*    alertify.error(self.listaidiomaSincronizActivo.MsjCategoria);*/
                            //self.EstadoArchivo = 'EstSinc0';
                            valor.EstadoActivo = "../images/x.svg";
                            self.ActivosIncorrectos = self.ActivosIncorrectos + 1;
                            //self.listaErrores.push("EstSinc0");

                            }

                        self.listaErrores.forEach(function (valor2, indice, array) {
                            if (valor2 == "EstSinc0") {
                                $.post(urlSincroniza, {
                                    option: 'ActualizaEstadoSinc',
                                    IdArchivo: self.IdArchivo,
                                    EstadoSincronizacion: valor2
                                }, function (data, error) {
                                })

                            }
                        })
                    });


                });

                self.ObtenerInfoArchivos();

                //Crear el archivo excel en el servidor.

                $.post(urlSincroniza, {
                    option: 'Crear',
                    ExcelBase64: self.ValorBase,
                    IdPerfilEmpresa: self.idPerfilEmpresa,
                    Idarchivo:self.IdArchivo,

                }, function (respo, error) {
                })

            })

            self.ObtenerInfoArchivos();


        },

        //Metodo para 
        GuardarArchivo: function (informacion) {
            var self = this
            let idArchivoI = informacion.NumActivo;

            $.post(urlSincroniza, {
                option: 'Guardar',
                IdPerfilEmpresa: self.idPerfilEmpresa,
                IdArchivo: idArchivoI,

            }, function (data, error) {
                var nombre = 'Activos'
                fetch(data)
                    .then(resp => resp.blob())
                    .then(blob => {
                        const url = window.URL.createObjectURL(blob);
                        const a = document.createElement('a');
                        a.style.display = 'none';
                        a.href = url;
                        a.download = nombre;
                        document.body.appendChild(a);
                        a.click();
                        window.URL.revokeObjectURL(url);
                        alertas.success(self.listaidiomaSincronizActivo.Atencion, self.listaidiomaSincronizActivo.Msjdescarga);
                    })
                    .catch(() => alertas.error(self.listaidiomaSincronizActivo.Atencion, self.listaidiomaSincronizActivo.MsjIntenteloNuevo));
            })
        },

        //Paginacion para tabla de activos
        // Función para calcular la cantidad de paginas
        CantidadRegistrostabla1: function () {

            this.tabla1paginas = Math.ceil(this.listaActivos.length / this.tabla1elementosXPagina);
            this.ObtenerDataTabla1(1);

        },

        // Función para divir los datos para mostrarlos en la tabla
        ObtenerDataTabla1(noPagina) {
            this.tabla1datosPaginados = [];
            let inicio = (noPagina * this.tabla1elementosXPagina) - this.tabla1elementosXPagina;
            let fin = (noPagina * this.tabla1elementosXPagina);
            this.tabla1datosPaginados = this.listaActivos.slice(inicio, fin);
        },

        // Función para regresar a la pagina anterior
        PaginaAnteriortabla1() {
            if (this.tabla1paginaActual > 1) {
                this.tabla1paginaActual--;
            }
            this.ObtenerDataTabla1(this.tabla1paginaActual)
        },

        // Función para saltar a la siguiente pagina
        PaginaSiguientetabla1() {
            if (this.tabla1paginaActual < this.tabla1paginas) {
                this.tabla1paginaActual++;
            }
            this.ObtenerDataTabla1(this.tabla1paginaActual)
        },



        //Paginacion para tabla de archivos
        // Función para calcular la cantidad de paginas
        CantidadRegistrostabla2: function () {

            this.tabla2paginas = Math.ceil(this.listaFinal.length / this.tabla2elementosXPagina);
            this.ObtenerDataTabla2(1);

        },

        // Función para divir los datos para mostrarlos en la tabla
        ObtenerDataTabla2(noPagina) {
            this.tabla2datosPaginados = [];
            let inicio = (noPagina * this.tabla2elementosXPagina) - this.tabla2elementosXPagina;
            let fin = (noPagina * this.tabla2elementosXPagina);
            this.tabla2datosPaginados = this.listaFinal.slice(inicio, fin);
        },

        // Función para regresar a la pagina anterior
        PaginaAnteriortabla2() {
            if (this.tabla2paginaActual > 1) {
                this.tabla2paginaActual--;
            }
            this.ObtenerDataTabla2(this.tabla2paginaActual)
        },

        // Función para saltar a la siguiente pagina
        PaginaSiguientetabla2() {
            if (this.tabla2paginaActual < this.tabla2paginas) {
                this.tabla2paginaActual++;
            }
            this.ObtenerDataTabla2(this.tabla2paginaActual)
        },

        ValidarSesion: function () {

            var dConfig = JSON.parse(sessionStorage.getItem('DConfig'));

            if (dConfig == null || dConfig.CofSincronizarActivos == false) {
                window.location.href = window.location.origin + "/AccesoDenegado.aspx";
            }
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


        InsertarActivos: function () {
            var self = this;
            $.post(urlSincroniza, {
                option: 'InsertarListaActivos',
                IdPerfilEmpresa: self.idPerfilEmpresa,
                ListaActivos: JSON.stringify(self.listaActivos)
            }, function (data, error) {
                self.ActivosCorrectos = 0;
                self.ActivosPendientes = 0;
                self.ActivosIncorrectos = 0;
                var result = JSON.parse(data);
                var contadorBuenos = 0;
                var contadorNumPlaca = 0;
                var contadorDesc = 0;
                var contadorMarca = 0;
                var contadorCategoria = 0;
                var contadorEstado = 0;
                var contadorUbicacion= 0;

                for (var j = 0; j < result.length; j++) {

                    if (result[j].EstadoSincronizacionArc == "sincronizado") {

                        contadorBuenos++;

                    } else if (result[j].EstadoSincronizacionArc == "El numero de placa del activo es obligatoria") {

                        contadorNumPlaca++;

                    } else if (result[j].EstadoSincronizacionArc == "La descripcion del activo es obligatoria") {

                        contadorDesc++;

                    } else if (result[j].EstadoSincronizacionArc == "La marca del activo es obligatoria") {

                        contadorMarca++;

                    } else if (result[j].EstadoSincronizacionArc == "No se encontró la categoría del activo que quiere insertar") {

                        contadorCategoria++;

                    } else if (result[j].EstadoSincronizacionArc == "No se encontró el estado del activo que quiere insertar") {

                        contadorEstado++;

                    } else if (result[j].EstadoSincronizacionArc == "No se encontró la ubicación del activo que quiere insertar") {

                        contadorUbicacion++;

                    }

                }


                if (contadorNumPlaca > 0) {

                    alertas.error(self.listaidiomaSincronizActivo.Atencion, contadorNumPlaca + " activos no se sincronizaron porque hay errores en el número de etiqueta");
                }
                if (contadorDesc > 0) {

                    alertas.error(self.listaidiomaSincronizActivo.Atencion, contadorDesc + " activos no se sincronizaron porque hay errores en la descripción del activo");

                }
                if (contadorMarca > 0) {

                    alertas.error(self.listaidiomaSincronizActivo.Atencion, contadorMarca + " activos no se sincronizaron porque hay errores en la marca del activo");

                }
                if (contadorCategoria > 0) {

                    alertas.error(self.listaidiomaSincronizActivo.Atencion, contadorCategoria+" activos no se sincronizaron porque hay errores en la categoría del activo");

                }
                if (contadorEstado > 0) {

                    alertas.error(self.listaidiomaSincronizActivo.Atencion, contadorEstado+" activos no se sincronizaron porque hay errores en el estado del activo");

                }
                if (contadorUbicacion > 0) {

                    alertas.error(self.listaidiomaSincronizActivo.Atencion, contadorUbicacion+" activos no se sincronizaron porque hay errores en la ubicación del activo");

                }

                if (contadorBuenos == self.TotalActivos) {

                    alertas.success(self.listaidiomaSincronizActivo.Atencion, "Todos los activos fueron sincronizados");

                } else {
                    alertas.error(self.listaidiomaSincronizActivo.Atencion, "Algunos de los activos no se pudieron sincronizar");
                }

                self.CrearTablaActivosNoSincronizados(result);
                
            })
        },

        CrearTablaActivosNoSincronizados: function (resp) {

            var self = this;
            self.listaActivos = [];
            for (let i = 0; i < resp.length; i += 1) {

                //Creacion de Objeto
                var Activos = new Object()

                let NumEtiqueta = resp[i].NumEtiqueta;
                let Descripcion = resp[i].Descripcion;
                let Categoria = resp[i].Categoria;
                let Estado = resp[i].Estado;
                let Ubicacion = resp[i].Ubicacion;
                let Marca = resp[i].Marca;
                let Modelo = resp[i].Modelo;
                let Serie = resp[i].Serie;
                let Costo = resp[i].Costo;
                let Factura = resp[i].Factura;
                let FechaCompra = resp[i].FechaCompra;
                let EstadoActivo = self.EstadoActivo;

                if (resp[i].EstadoSincronizacionArc == "sincronizado") {

                    EstadoActivo = "../images/check.svg";
                    self.ActivosCorrectos = self.ActivosCorrectos + 1;

                } else {

                    if (resp[i].EstadoSincronizacionArc == "Ya supero el total de activos permitidos") {

                        self.ActivosPendientes = self.ActivosPendientes + 1;

                    } else {
                        self.ActivosIncorrectos = self.ActivosIncorrectos + 1;
                    }


                }

                //Agregar las variables al objeto
                Activos.NumEtiqueta = NumEtiqueta;
                Activos.Descripcion = Descripcion;
                Activos.Categoria = Categoria;
                Activos.Ubicacion = Ubicacion;
                Activos.Estado = Estado;
                Activos.Marca = Marca;
                Activos.Modelo = Modelo;
                Activos.Serie = Serie;
                Activos.Costo = Costo;
                Activos.Factura = Factura;
                Activos.FechaCompra = FechaCompra;
                Activos.EstadoActivo = EstadoActivo;


                //Agregar a la lista el objeto
                self.listaActivos.push(Activos);
                self.CantidadRegistrostabla1();

            }
        },


        FormatearFecha: function (fecha) {
            var fechaFormato = new Date(fecha);
            return fechaFormato.getDate() + "/" + (fechaFormato.getMonth() + 1) + "/" + fechaFormato.getFullYear();
        },

    },



})
