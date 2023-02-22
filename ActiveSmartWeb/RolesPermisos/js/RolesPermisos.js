var urlIdioma = '../RolesPermisos/Idioma/EstablecerIdiomaAjax.aspx'
var urlAcceder = '../RolesPermisos/RolesPermisos/RolesReporteAjax.aspx'

Vue.component('rolespermisos', {
    props: {
    },
    data() {
        return {
            listaIdiomaRoles: this.ObtenerIdioma(),
            listaRoles: [],
            listapermisos: [],
            IdPerfilActive: '',
            IdPerfilUsuario: '',//new
            Correo: '',
            nombre: '',
            apellidos: '',
            fechaInicio: '',
            fechaFinal: '',
            IdConfigEmpresa: '',
            IdPerfilEmpresa: '',
            creacionActivoWeb: false,
            actualizarActivosWeb: false,
            tomasFisicasWeb: false,
            reporteWeb: false,
            creacionUbicacionWeb: false,
            actualizaActivosAPP: false,
            tomaFisicaAPP: false,
            perfilAPP: false,
            resultadoTomaAPP: false,
            rolesPermisosWeb: false,
            activosNoPistoleados: false,


        }
    },
    render: function (createElement) {
        var self = this;
        return createElement('div', {
            attrs: { class: '' }
        }, [createElement('div', {
            attrs: { class: 'container-2 w-container' }

        },
            [createElement('div', {
                attrs: { class: 'w-layout-grid grid-main' }

            }, [createElement('div', {
                attrs: { class: 'div-banner-extremo', id: 'w-node-a00a1564-3645-4a63-ae55-70dd1344b632-780e62be' }
            }, [
            ]),
            createElement('div', {
                attrs: { class: 'div-banner-extremo', id: 'w-node-a00a1564-3645-4a63-ae55-70dd1344b633-780e62be' }
            }, [
            ]),
            createElement('div', {

                attrs: { id: 'w-node-a00a1564-3645-4a63-ae55-70dd1344b634-780e62be' }
            }, [
                createElement('div', {
                    attrs: { class: 'w-layout-grid grid-container-title' }
                }, [
                    createElement('a', {
                        attrs: {
                            class: 'link-block-back w-inline-block',
                            href: '../Menu/MenuPrincipal.aspx'
                        }
                    }, [
                        createElement('img', {
                            attrs: {
                                src: '../images/Back-arrow.svg',
                                class: 'back'
                            },
                            style: {
                                height: '26',
                                width: '26'
                            }

                        })
                    ]),
                    [
                        createElement('h1', {
                            attrs: {
                                class: 'titulo-principal'
                            }, domProps: {
                                innerText: this.listaIdiomaRoles.Titulo
                            }
                        })


                    ]

                ])
            ]),
            createElement('div', {
                attrs: {
                    id: 'w-node-_2c1a7e9b-76b3-1d7e-7198-756f58c24a9c-780e62be', class: 'div-tarjeta'
                }
            }, [
                createElement('div', {
                    attrs: { class: 'form-block w-form' }

                }, [
                    createElement('div', {
                        attrs: { id: 'email-form', class: 'form' }

                    }, [
                        createElement('div', {
                            attrs: { class: 'w-layout-grid grid-busqueda' }

                        }, [createElement('label', {
                            attrs: {
                                class: 'field-label',

                            },
                            domProps: {
                                innerText: this.listaIdiomaRoles.Correo
                            }
                        }, [
                        ]),
                        createElement('div', {
                            attrs: {
                                id: 'w-node-b6c4182a-16c4-2048-e3ef-a33861956377-780e62be', class: 'contenedor-buscar'
                            }
                        }, [
                            //input de correo
                            createElement('input', {
                                attrs: {
                                    class: 'text-field w-input', id: 'name-4', type: 'text',
                                    id: 'Correo',
                                    type: 'input'

                                }, domProps: {

                                    value: self.Correo
                                },
                                on: {
                                    input: function (event) {
                                        self.Correo = event.target.value;
                                    }
                                }

                            }),
                            createElement('a', {
                                attrs: {
                                    class: 'contenedor-icono w-inline-block', id: 'busqueda'
                                }
                                ,
                                on: {
                                    click: e => {

                                        //evento boton 
                                        this.HabilitarPermisosCorreo();

                                    }
                                }

                            }, [
                                createElement('img', {
                                    attrs: { src: '../images/icono_buscar_acces-o-01.svg' }
                                })

                            ])
                        ]),
                        createElement('div', {
                            attrs: {
                                id: 'w-node-_45f0aee6-1bf7-389b-aa06-dbcdafd20bcd-731f63ba',
                                class: 'contenedor-botones carga-descarga'
                            }

                        }, [



                        ]), createElement('div', {
                            attrs: { id: 'w-node-_45f0aee6-1bf7-389b-aa06-dbcdafd20bcd-731f63ba', }
                        }, [createElement('a', {
                            attrs: { class: 'boton gris w-button' },
                            domProps: { innerText: this.listaIdiomaRoles.CrearUsuario },
                            on: {
                                click: e => {
                                    //crear usuario
                                    sessionStorage.removeItem('DatosActivoEditar');
                                    //validacion de idioma para mostrar el pop 
                                    var ididiomaRol = "ES"
                                    if (localStorage.getItem("idiomaApp") != undefined) {
                                        ididiomaRol = localStorage.getItem("idiomaApp");
                                    }   
                                        
                                    if (ididiomaRol == "ES") {
                                        this.PopCrearUsuarioES();
                                    } else {
                                       this.PopCrearUsuarioEN();
                                    }
                                 
                                }
                            }
                        }, [

                        ]),
                        ]),


                        ]),

                        createElement('label', {
                            attrs: {
                                class: 'field-label',

                            },
                            domProps: {
                                innerText: this.listaIdiomaRoles.Nombre
                            }
                        }, [
                        ]),
                        //nombre
                        createElement('input', {
                            attrs: {
                                class: 'text-field w-input', id: 'name-4', type: 'text',
                                id: 'Nombre'
                            }, domProps: {
                                value: self.nombre
                            },
                            on: {
                                input: function (event) {
                                    self.nombre = event.target.value;
                                }
                            }

                        }),
                        createElement('label', {
                            attrs: {
                                class: 'field-label',

                            },
                            domProps: {
                                innerText: this.listaIdiomaRoles.Apellido
                            }
                        }, [
                        ]),//apellidos
                        createElement('input', {
                            attrs: {
                                class: 'text-field w-input', id: 'name-4', type: 'text',
                                id: 'Apellidos'

                            }, domProps: {
                                value: self.apellidos
                            },
                            on: {
                                input: function (event) {
                                    self.apellidos = event.target.value;
                                }
                            }

                        }),



                    ]),



                ]),
                createElement('label', {
                    attrs: {
                        class: 'field-label',

                    },
                    domProps: {
                        innerText: this.listaIdiomaRoles.CreacionActivos
                    }
                }, [
                ]), createElement('input', {
                    attrs: {
                        id: 'creacionActivoWeb',
                        type: 'checkbox'

                    },
                    domProps: {
                        checked: self.creacionActivoWeb
                    },
                    on: {
                        input: event => {
                            self.creacionActivoWeb = event.target.checked
                        }
                    }
                }), createElement('label', {
                    attrs: {
                        class: 'field-label',

                    },
                    domProps: {
                        innerText: this.listaIdiomaRoles.ActualizarActivos
                    }
                }, [

                ]), createElement('input', {
                    attrs: {
                        id: 'actualizarActivoWeb',
                        type: 'checkbox'
                    },
                    domProps: {
                        checked: self.actualizarActivosWeb
                    },
                    on: {
                        input: event => {
                            self.actualizarActivosWeb = event.target.checked
                        }
                    }
                }),
                createElement('label', {
                    attrs: {
                        class: 'field-label',

                    },
                    domProps: {
                        innerText: this.listaIdiomaRoles.TomasFisicas
                    }
                }, [

                ]), createElement('input', {
                    attrs: {
                        id: 'tomasFisicasWeb',
                        type: 'checkbox',


                    },
                    domProps: {
                        checked: self.tomasFisicasWeb
                    },
                    on: {
                        input: event => {
                            self.tomasFisicasWeb = event.target.checked
                        }
                    }
                }),

                createElement('label', {
                    attrs: {
                        class: 'field-label',

                    },
                    domProps: {
                        innerText: this.listaIdiomaRoles.Reportes
                    }
                }, [

                ]), createElement('input', {
                    attrs: {
                        id: 'reporteWeb',
                        type: 'checkbox',

                    },
                    domProps: {
                        checked: self.reporteWeb
                    },
                    on: {
                        input: event => {
                            self.reporteWeb = event.target.checked
                        }
                    }
                }),

                createElement('label', {
                    attrs: {
                        class: 'field-label',

                    },
                    domProps: {
                        innerText: this.listaIdiomaRoles.CreacionUbicaciones
                    }
                }, [

                ]), createElement('input', {
                    attrs: {
                        id: 'creacionUbicacionWeb',
                        type: 'checkbox'
                    },
                    domProps: {
                        checked: self.creacionUbicacionWeb
                    },
                    on: {
                        input: event => {
                            self.creacionUbicacionWeb = event.target.checked
                        }
                    }

                }), createElement('label', {
                    attrs: {

                        class: 'field-label',

                    },
                    domProps: {
                        innerText: this.listaIdiomaRoles.RolesPermisos
                    }
                }, [

                ]), createElement('input', {
                    attrs: {
                        id: 'rolesPermisosWeb',
                        type: 'checkbox'
                    },
                    domProps: {
                        checked: self.rolesPermisosWeb
                    },
                    on: {
                        input: event => {
                            self.rolesPermisosWeb = event.target.checked
                        }
                    }

                }), createElement('label', {
                    attrs: {
                        class: 'field-label',

                    },
                    domProps: {
                        innerText: this.listaIdiomaRoles.ActualizarActivosAPP
                    }
                }, [

                ]), createElement('input', {
                    attrs: {
                        id: 'actualizarActivosAPP',
                        type: 'checkbox'
                    },
                    domProps: {
                        checked: self.actualizaActivosAPP
                    },
                    on: {
                        input: event => {
                            self.actualizaActivosAPP = event.target.checked
                        }
                    }

                }), createElement('label', {
                    attrs: {
                        class: 'field-label',

                    },
                    domProps: {
                        innerText: this.listaIdiomaRoles.TomasFisicasAPP
                    }
                }, [

                ]), createElement('input', {
                    attrs: {
                        id: 'tomasFisicaAPP',
                        type: 'checkbox',

                    },
                    domProps: {
                        checked: self.tomaFisicaAPP
                    },
                    on: {
                        input: event => {
                            self.tomaFisicaAPP = event.target.checked
                        }
                    }
                }), createElement('label', {
                    attrs: {
                        class: 'field-label',

                    },
                    domProps: {
                        innerText: this.listaIdiomaRoles.ResultadoTomaAPP
                    }
                }, [

                ]), createElement('input', {
                    attrs: {
                        id: 'resultadoTomaAPP',
                        type: 'checkbox'
                    },
                    domProps: {
                        checked: self.resultadoTomaAPP
                    },
                    on: {
                        input: event => {
                            self.resultadoTomaAPP = event.target.checked
                        }
                    }
                }), createElement('label', {
                    attrs: {
                        class: 'field-label',

                    },
                    domProps: {
                        innerText: this.listaIdiomaRoles.PerfilAPP
                    }
                }, [

                ]), createElement('input', {
                    attrs: {
                        id: 'perfilAPP',
                        type: 'checkbox'
                    },
                    domProps: {
                        checked: self.perfilAPP
                    },
                    on: {
                        input: event => {
                            self.perfilAPP = event.target.checked
                        }
                    }
                }), createElement('label', {
                    attrs: {
                        class: 'field-label',

                    },
                    domProps: {
                        innerText: this.listaIdiomaRoles.ActivosNoPistoleados
                    }
                }, [

                ]), createElement('input', {
                    attrs: {
                        id: 'activosNoPistoleados',
                        type: 'checkbox'
                    },
                    domProps: {
                        checked: self.activosNoPistoleados
                    },
                    on: {
                        input: event => {
                            self.activosNoPistoleados = event.target.checked
                        }
                    }
                }), createElement('br', {
                    attrs: { class: '' },

                }), createElement('br', {
                    attrs: { class: '' },

                }), createElement('div', {
                    attrs: { class: 'contenedor-botones centrado', id: 'w-node-_7685835f-fa3e-95f3-036b-6363be028cbd-81b79b2e' }
                }, [
                    createElement('a', {
                        attrs: { class: 'boton gris w-button' },
                        domProps: { innerText: this.listaIdiomaRoles.BtnGuardarCambios },
                        on: {
                            click: e => {
                                if (this.Correo == 0) {
                                    alertify.error(this.listaIdiomaRoles.ErrorCorreo)
                                } else if (this.Nombre == 0) {
                                    alertify.error(this.listaIdiomaRoles.ErrorNombre)
                                } else if (this.Apellido == 0) {
                                    alertify.error(this.listaIdiomaRoles.ErrorApellido)
                                } else {
                                    // var datosEditar = sessionStorage.getItem("DatosEditar");
                                    this.GuardarCambios();
                                }
                            }
                        }
                    }),

                ])
            ])

            ]),

            ])

        ],

        )
    },


    mounted: function () {
        this.ValidarSesion();
        var logueado = JSON.parse(sessionStorage.getItem('DUser'));
        this.idPerfilActive = "" + logueado[0].IdPerfilActive;
        this.idPerfilEmpresa = "" + logueado[0].IdPerfilEmpresa;
        this.ObtenerIdioma();
        this.HabilitarPermisosEmpresa(logueado[0].IdPerfilEmpresa);

    },
    methods: {
        ObtenerIdioma: function () {
            var ididiomaRol = "ES"
            if (localStorage.getItem("idiomaApp") != undefined) {
                ididiomaRol = localStorage.getItem("idiomaApp");
            }
            this.EstablecerIdiomaRolesPermisos(ididiomaRol);
          
        },
        EstablecerIdiomaRolesPermisos: function (idioma) {
            var self = this
            $.post(urlIdioma, {
                IdiomaRoles: idioma,
            }, function (data, error) {
                self.listaIdiomaRoles = JSON.parse(data);
            });
        },
        //aca
        


        CrearUsuario: function () {
            var self = this;
            //console.log(self.Correo);
            //console.log(self.nonbre);

            //console.log(self.apellidos);

            $.post(urlAcceder, {
               
                option: "CrearUsuario",
                Correo: self.Correo,
                Nombre: self.nombre,
                Apellido: self.apellidos


            }, function (data3, error) {
                    if (data3 == "Usuario creado con exito") {

                        alertify.success(self.listaIdiomaRoles.CreadoConExito);// agreagr a entidad idioma 

                    } else if (data3 == "Usuario existente") {
                        alertify.error(self.listaIdiomaRoles.YaExiste);// ""

                } else {
                        alertify.error(self.listaIdiomaRoles.ErorConsulta);// ""
                    return
                }
            });

        },
        //pop español

        PopCrearUsuarioES: function () {

            var self = this

            const { value: formValues } = Swal.fire({

                title: 'Crear Usuario',

                html: '<label>Nombre<label>' +

                    '<input id="swal-input1" class="swal2-input">' +

                    '<label>Apellidos<label>' +

                    '<input id="swal-input2" class="swal2-input">' +

                    '<label>Correo<label>' +

                    '<input id="swal-input3" class="swal2-input">',

                focusConfirm: false,

                preConfirm: () => {

                    return [

                        self.nombre = document.getElementById('swal-input1').value,

                        self.apellidos = document.getElementById('swal-input2').value,

                        self.Correo = document.getElementById('swal-input3').value,

                        self.CrearUsuario(),

                    ]

                }

            })

            if (formValues) {

                Swal.fire(JSON.stringify(formValues))

            }

        },
        //pop ingles

        PopCrearUsuarioEN: function () {

            var self = this

            const { value: formValues } = Swal.fire({

                title: 'Create User',

                html: '<label>Name <label>' +

                    '<input id="swal-input1" class="swal2-input">' +

                    '<label>Surnames<label>' +

                    '<input id="swal-input2" class="swal2-input">' +

                    '<label>Email<label>' +

                    '<input id="swal-input3" class="swal2-input">',

                focusConfirm: false,

                preConfirm: () => {

                    return [

                        self.nombre = document.getElementById('swal-input1').value,

                        self.apellidos = document.getElementById('swal-input2').value,

                        self.Correo = document.getElementById('swal-input3').value,

                        self.CrearUsuario(),

                    ]

                }

            })

            if (formValues) {

                Swal.fire(JSON.stringify(formValues))

            }

        },




        HabilitarPermisosCorreo: function () {
            var self = this;

            $.post(urlAcceder, {

                option: "ObtenerConfigPerfil",
                Correo: self.Correo,
                IdPerfilEmpresa: self.idPerfilEmpresa

            }, function (data1, error) {
                console.log(data1);
                RolesPermisos.listaConfig = JSON.parse(data1);
                var resp = JSON.parse(data1);


                self.IdPerfilUsuario = resp.IdPerfilUsuario;//
                self.Correo = resp.Correo;
                self.nombre = resp.Nombre;
                self.apellidos = resp.Apellido;
                self.creacionActivoWeb = resp.CreacionActivosWeb;
                self.actualizarActivoWeb = resp.ActualizacionActivosWeb;
                self.tomasFisicasWeb = resp.TomasFisicasWeb;
                self.reporteWeb = resp.ReportesWeb;
                self.creacionUbicacionWeb = resp.CreacionUbicacionWeb;
                self.actualizaActivosAPP = resp.ActualizarActivoApp;
                self.tomaFisicaAPP = resp.TomaFisicaApp;
                self.perfilAPP = resp.PerfilApp;
                self.resultadoTomaAPP = resp.ResultadoTomaAPP;
                self.rolesPermisosWeb = resp.RolesPermisosWeb;
                self.activosNoPistoleados = resp.ActivosNoPistoleados;//
                    






            });
        },
        HabilitarPermisosEmpresa: function (idPerfilEmpresa) {
            var self = this;
            $.post(urlAcceder, {
                option: "ObtenerConfigEmpresa",
                idPerfilEmpresa: idPerfilEmpresa
            }, function (data, error) {
                console.log(data);
                RolesPermisos.listaConfig = JSON.parse(data);
                if (RolesPermisos.listaConfig.IdPerfilEmpresa > 0 || RolesPermisos.listaConfig.IdPerfilEmpresa != "") {
                    if (!RolesPermisos.listaConfig.CreacionActivosWeb) {
                        document.getElementById("creacionActivoWeb").setAttribute("disabled", "disabled");

                    } else {
                        document.getElementById("creacionActivoWeb").removeAttribute("disabled", "disabled");

                    }

                    if (!RolesPermisos.listaConfig.ActualizacionActivosWeb) {
                        document.getElementById("actualizarActivoWeb").setAttribute("disabled", "disabled");
                    } else {
                        document.getElementById("actualizarActivoWeb").removeAttribute("disabled", "disabled");

                    }
                    if (!RolesPermisos.listaConfig.TomasFisicasWeb) {

                        document.getElementById("tomasFisicasWeb").setAttribute("disabled", "disabled");
                    } else {
                        document.getElementById("tomasFisicasWeb").removeAttribute("disabled", "disabled");

                    }

                    if (!RolesPermisos.listaConfig.ReportesWeb) {

                        document.getElementById("reporteWeb").setAttribute("disabled", "disabled");

                    } else {

                        document.getElementById("reporteWeb").removeAttribute("disabled", "disabled");

                    }
                    if (!RolesPermisos.listaConfig.CreacionUbicacionWeb) {
                        document.getElementById("creacionUbicacionWeb").setAttribute("disabled", "disabled");
                    } else {
                        document.getElementById("creacionUbicacionWeb").removeAttribute("disabled", "disabled");


                    }

                    if (!RolesPermisos.listaConfig.ActualizarActivoApp) {
                        document.getElementById("actualizarActivosAPP").setAttribute("disabled", "disabled");
                    } else {
                        document.getElementById("actualizarActivosAPP").removeAttribute("disabled", "disabled");


                    }
                    if (!RolesPermisos.listaConfig.TomaFisicaApp) {
                        document.getElementById("tomasFisicaAPP").setAttribute("disabled", "disabled");
                    } else {
                        document.getElementById("tomasFisicaAPP").removeAttribute("disabled", "disabled");


                    }

                    if (!RolesPermisos.listaConfig.PerfilApp) {
                        document.getElementById("perfilAPP").setAttribute("disabled", "disabled");
                    } else {
                        document.getElementById("perfilAPP").removeAttribute("disabled", "disabled");


                    }
                    if (!RolesPermisos.listaConfig.ResultadoTomaAPP) {
                        document.getElementById("resultadoTomaAPP").setAttribute("disabled", "disabled");
                    } else {
                        document.getElementById("resultadoTomaAPP").removeAttribute("disabled", "disabled");


                    }

                    if (!RolesPermisos.listaConfig.RolesPermisosWeb) {
                        document.getElementById("rolesPermisosWeb").setAttribute("disabled", "disabled");
                    } else {
                        document.getElementById("rolesPermisosWeb").removeAttribute("disabled", "disabled");

                    }
                    //nuevo
                    if (!RolesPermisos.listaConfig.RolesPermisosWeb) {
                        document.getElementById("activosNoPistoleados").setAttribute("disabled", "disabled");
                    } else {
                        document.getElementById("activosNoPistoleados").removeAttribute("disabled", "disabled");

                    }

                } else {
                    window.location.replace("../Menu/MenuPrincipal.aspx");

                }

            });




        },

        GuardarCambios: function () {
            var self = this;
            $.post(urlAcceder, {
                option: 'GuardarCambios',
                IdPerfilUsuario: self.IdPerfilUsuario,
                IdPerfilEmpresa: self.idPerfilEmpresa,
                CreacionActivoWeb: self.creacionActivoWeb,
                ActualizarActivosWeb: self.actualizarActivoWeb,
                TomasFisicasWeb: self.tomasFisicasWeb,
                ReporteWeb: self.reporteWeb,
                CreacionUbicacionWeb: self.creacionUbicacionWeb,
                ActualizaActivosAPP: self.actualizaActivosAPP,
                TomaFisicaAPP: self.tomaFisicaAPP,
                PerfilAPP: self.perfilAPP,
                ResultadoTomaAPP: self.resultadoTomaAPP,
                RolesPermisosWeb: self.rolesPermisosWeb,
                ActivosNoPistoleados: self.activosNoPistoleados,

            }, function (data2, error) {
                if (data2 == "Permisos Asignados") {

                    alertify.success(self.listaIdiomaRoles.PermisosAsignados);

                } else if (data2 == "Ya excedió la cantidad maxima de usuarios") {
                    alertify.error(self.listaIdiomaRoles.ExcedioUsuarios);

                } else {
                    alertify.error(self.listaIdiomaRoles.ErrorPermisos);
                    return
                }
            });

        },

        ValidarSesion: function () {

            var dConfig = JSON.parse(sessionStorage.getItem('DConfig'));

            if (dConfig == null || dConfig.CofRolesPermisos == false) {
                window.location.href = window.location.origin + "/AccesoDenegado.aspx";
            }
        },

    }
})
const RolesPermisos = new Vue({
    el: '#rol',
    data: {
        listaConfig: {},
    }
})

