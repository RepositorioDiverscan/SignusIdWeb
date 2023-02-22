var urlIdioma = 'Idioma/AjaxIdioma.aspx'
var urlNotificaciones = '../NotificacionesPerfil/AjaxNotificaciones.aspx'

const Empleados = new Vue({

    el: '#NotificacionesVUE',

    data: {
        //Variables a utilizar
        listaIdioma: [],
        listaNotificaciones: [],
        listaMensajes: [],
        MensajesLenght: 0,
        MensajesLenghtAnt: 0,
        elementosXPagina: 5,
        paginas: 0,
        datosPaginados: [],
        paginaActual: 1,
        IdPerfilActive: '',
        NumeroTicket: '',
        idNotificacion: 0,
        Mensaje: '',
        Emisor: 0,
    },

    mounted: function () {
        this.IdPerfilActive = 129;
        this.listaNotificaciones = this.CargarNotificacionesLista(this.IdPerfilActive);
        //  this.ActualizarChatAuto();
    },

    methods: {



        // Función para cargar las notificaciones
        CargarNotificacionesLista: function (IdPerfilActive) {
            var self = this
            $.post(urlNotificaciones, {
                option: 'ConsultarNotificaciones',
                IdPerfilEmpresa: IdPerfilActive,
            },
                function (data, error) {
                    if (data != "Null") {

                        self.listaNotificaciones = JSON.parse(data);
                        self.CantidadRegistros();
                    }
                });
        },

        /// Función para calcular la cantidad de paginas
        CantidadRegistros: function () {
            this.paginas = Math.ceil(this.listaNotificaciones.length / this.elementosXPagina);
            this.ObtenerDataTabla(1);
        },

        // Función para divir los datos para mostrarlos en la tabla
        ObtenerDataTabla(noPagina) {
            this.datosPaginados = [];
            let inicio = (noPagina * this.elementosXPagina) - this.elementosXPagina;
            let fin = (noPagina * this.elementosXPagina);
            this.datosPaginados = this.listaNotificaciones.slice(inicio, fin);
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


        // Metodos para abrir y cerrar el pop up

        AbrirPopPup: function (IdNotificacion, IdCategoria) {
            var self = this;
            var general = document.getElementById('PopUpGeneral');
            general.style.display = 'block';
            if (IdCategoria == 1) {
                self.idNotificacion = IdNotificacion;
                $.post(urlNotificaciones, {
                    option: 'ConsultarMenasajesChat',
                    IdNoti: self.idNotificacion,
                },
                    function (data, error) {
                        if (data != "Null") {
                            //Consigue los mensajes y número de ticket
                            self.ConsultarTicket(self.idNotificacion);
                            self.listaMensajes = JSON.parse(data);
                            self.MensajesLenght = self.listaMensajes.length;
                        }
                    });
                var a = document.getElementById('POPsoporte');
                a.style.display = 'block';

            }
            else if (IdCategoria == 2) {
                var a = document.getElementById('POPcomercial');
                a.style.display = 'block';
            }
            else if (IdCategoria == 3) {
                var a = document.getElementById('POPadministrativo');
                a.style.display = 'block';
            }
            else {
                console.log("error");
            }

        },
        CerrarPopPup: function (IdCategoria) {
            var self = this;
            var general = document.getElementById('PopUpGeneral');
            general.style.display = 'none';
            if (IdCategoria == 1) {
                var a = document.getElementById('POPsoporte');
                a.style.display = 'none';
                self.listaMensajes = '';
                self.NumeroTicket = '';
                self.idNotificacion = 0;
                self.Mensaje = '';
                self.MensajesLenght = 0;
                self.MensajesLenghtAnt = 0;
            }
            else if (IdCategoria == 2) {
                var a = document.getElementById('POPcomercial');
                a.style.display = 'none';
            }
            else if (IdCategoria == 3) {
                var a = document.getElementById('POPadministrativo');
                a.style.display = 'none';
            }
            else {
                console.log("error");
            }
        },

        sinjQuery: async function () {
            var self = this;
            //Llevo el scroll al fondo
            var objDiv = document.getElementById("SSCCR");

            if (window.getComputedStyle(objDiv).display === "block" && self.MensajesLenght == self.MensajesLenghtAnt) {
                objDiv.scrollTop = objDiv.scrollHeight;
                self.MensajesLenghtAnt = self.MensajesLenght;
            }
            else {
                self.MensajesLenghtAnt += 1;
            }


        },

        //Envía el mensaje y recarga la lista de mensajes
        EnviarMensaje: function () {
            var self = this;
            var auxNoti = self.idNotificacion;
            $.post(urlNotificaciones, {
                option: 'EnviarMensaje',
                IdNoti: self.idNotificacion,
                Texto: self.Mensaje,
                Emisor: self.Emisor,
            },
                function (data, error) {
                    if (data != "Null") {
                        self.Mensaje = '';
                        // self.RecargarMensajes();
                        //self.CerrarPopPup(1); //Con estas 2 funciones se cierra y se abre el popup chat por ende
                        self.AbrirPopPup(auxNoti, 1); //se recargan mensajes y se hace el desplazamiento al último index
                    }
                });
        },
        //Trae el número de ticket del incidente 
        ConsultarTicket: function (IdNotificacion) {
            var self = this
            $.post(urlNotificaciones, {
                option: 'ConsultarTicket',
                IdNoti: IdNotificacion,
            },
                function (data, error) {
                    if (data != "Null") {

                        self.NumeroTicket = JSON.parse(data);
                    }
                });
        },

        //Con esta función se recargan los mensajes sin llevar al último index
        RecargarMensajes: function () {
            var self = this;
            if (self.idNotificacion != 0) {

                $.post(urlNotificaciones, {
                    option: 'ConsultarMenasajesChat',
                    IdNoti: self.idNotificacion,
                },
                    function (data, error) {
                        if (data != "Null") {
                            auxCantMensajes = JSON.parse(data);
                            if (auxCantMensajes.length > self.MensajesLenght) {
                                self.listaMensajes = JSON.parse(data);
                                self.AbrirPopPup(self.idNotificacion, 1);
                            }
                        }
                    });
            }
        },


    },
    watch: {
        //Si un chat está abierto lo recarga cada 1.5 segundos, sino cierra el interval
        idNotificacion: function () {
            var self = this;
            if (self.idNotificacion != 0) {
                self.autoChat = setInterval(function () {
                    self.RecargarMensajes();
                }, 1500);
            } else {
                clearInterval(self.autoChat);
            }
        }
    }

});