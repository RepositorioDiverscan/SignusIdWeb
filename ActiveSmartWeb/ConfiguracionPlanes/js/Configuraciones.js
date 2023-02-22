var urlAjaxIdioma = 'IdiomaConfiguracionAjax.aspx';
var urlConfiguracionAjax = 'ConfiguracionAjax.aspx';

const contrato = new Vue({

    el: '#context',
    //Variables para utilizar en el v-model de vue.
    data: {
        plan: "",
        configuraciones: [],
        listaIdiomas: {},
        estado: true,
        idtipocontrato: "",
    },
    mounted: function () {
        //Llamados a metodos para cargar la informacion necesaria.
        var idiLog = "ES"
        if (localStorage.getItem("idiomaApp") != undefined) {
            idiLog = localStorage.getItem("idiomaApp");
        }
        this.idiomaLogin = idiLog;
        this.estableceridiomalogin(this.idiomaLogin);
        this.CargarConfiguraciones();

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

        //Metodo para cargar las configuraciones.
        CargarConfiguraciones: function () {
            var self = this;
            $.post(urlConfiguracionAjax, {
                option: 'CargarConfiguraciones'
            }, function (data, error) {

                var datos = JSON.parse(data);

                for (i = 0; i < datos.length; i++) {

                    datos[i].FechaRegistro = datos[i].FechaRegistro.substr(0, 9);

                }

                self.configuraciones = datos;

                
            });
        },


        //Metodo para cargar las configuraciones por plan.
        CargarConfiguracionesPorPlan: function (e) {
            var self = this;

            //Le asigna el valor seleccionado del select a la variable del vue.
            self.idtipocontrato = e.target.value;

            //Ciclo for para desmarcar los checkbox.
            for (i = 0; i < self.configuraciones.length; i++) {

                let elemento = document.getElementById(self.configuraciones[i].IdConfiguracion);

                elemento.checked = false;

            }

            if (self.idtipocontrato > 0 && self.idtipocontrato < 3) {


                $.post(urlConfiguracionAjax, {
                    option: 'CargarConfiguracionesPorPlan',
                    idtipocontrato: self.idtipocontrato,
                }, function (data, error) {

                    var datos = JSON.parse(data);

                    //Ciclo for para habilitar los checkbox y marcar los del plan.
                    for (i = 0; i < self.configuraciones.length; i++) {


                        let elemento = document.getElementById(self.configuraciones[i].IdConfiguracion);

                        elemento.disabled = false;

                        for (j = 0; j < datos.length; j++) {

                            if (self.configuraciones[i].IdConfiguracion == datos[j].IdConfiguracion) {

                                elemento.checked = true;

                            }

                        }

                    }

                });
            } else if (self.idtipocontrato == 0) {

                //Ciclo for para deshabilitar los checkbox si el plan seleccionado es seleccione uno.
                for (i = 0; i < self.configuraciones.length; i++) {

                    let elemento = document.getElementById(self.configuraciones[i].IdConfiguracion);
                    elemento.disabled = true;

                }

            } else {
                alertify.set('notifier', 'position', 'top-right');
                alertify.success("Este plan no esta disponible en este momento");
            }
        },

        //Metodo para actualizar o insertar una configuracion a un plan.
        ActualizarInsertarConfiguracion: function (configuracion) {
            var self = this;
            let elemento = document.getElementById((configuracion.IdConfiguracion));

            //Validamos si estamos marcando o desmarcando el checkbox.
            //Si estamos marcando crea o habilita la configuracion al plan seleccionado.
            //Si estamos desmarcando deshabilita la configuracion al plan seleccionado.
            if (elemento.checked == true) {

                $.post(urlConfiguracionAjax, {

                    option: 'ActualizarInsertarConfiguracion',
                    IdConfiguracion: configuracion.IdConfiguracion,
                    IdTipoContrato: self.idtipocontrato,
                    Accion: 1,

                }, function (respuesta, error) {


                });

            } else {

                $.post(urlConfiguracionAjax, {

                    option: 'ActualizarInsertarConfiguracion',
                    IdConfiguracion: configuracion.IdConfiguracion,
                    IdTipoContrato: self.idtipocontrato,
                    Accion: 2,

                }, function (respuesta, error) {


                });

            }

        },


    },
})
