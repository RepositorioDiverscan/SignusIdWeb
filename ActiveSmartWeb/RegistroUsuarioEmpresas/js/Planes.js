var urlIdioma = 'AjaxPlanIdioma.aspx'

const Planes = new Vue({

    el: '#Planesidioma',

    data: {
        listaIdiomas: [],
    },

    mounted: function () {

        this.listaIdiomas = this.ObtenerIdiomaPlan();


    },

    methods: {


        // CONFIGURAR EL IDIOMA

        ObtenerIdiomaPlan: function () {

            var idiActualiza = "ES"

            if (localStorage.getItem("idiomaApp") != undefined) {

                idiActualiza = localStorage.getItem("idiomaApp");

            }

            this.EstablecerIdiomaPlan(idiActualiza);

        },

        EstablecerIdiomaPlan: function (idioma) {

            var self = this

            $.post(urlIdioma, {

                idi: idioma,

            },
                function (data, error) {

                    self.listaIdiomas = JSON.parse(data);

                });

        },


        // FIN METODOS DE IDIOMA


        //Metodo para cambiar la frecuencia de pago a anual
        CambiarFrecuenciaPlanAnual: function () {
            var self = this;

            $(btnMensual).removeClass("button-4").addClass("button-5");
            $(btnAnual).removeClass("button-5").addClass("button-4");

            $(basicPrecio).text('$14.99');
            $('#w-node-_6d68c22a-6945-7184-f66c-5bf75f0b5635-290239ef').text(`${self.listaIdiomas.MontoUsuarioBasic}\n${self.listaIdiomas.FacturaBasic}`);
        },

        //Metodo para cambiar la frecuencia de pago a mensual
        CambiarFrecuenciaPlanMensual: function () {
            var self = this;

            $(btnAnual).removeClass("button-4").addClass("button-5");
            $(btnMensual).removeClass("button-5").addClass("button-4");

            $(basicPrecio).text('$17.50');
            $('#w-node-_6d68c22a-6945-7184-f66c-5bf75f0b5635-290239ef').text(`${self.listaIdiomas.MontoUsuarioBasicMensual}\n${self.listaIdiomas.FacturaMensual}`);
            
        },


       PRO: function () {
            var self = this;

        },
        BASIC: function () {
            var self = this;

            sessionStorage.setItem('CodigoPlan', '2');
            window.location.assign('Checkout.aspx');
        },
        FREE: function () {
            var self = this;


            sessionStorage.setItem('CodigoPlan', '1');
            window.location.assign('Checkout.aspx');
        },

        BUSINESS: function () {
            window.location.assign('../Contacto/ContactoView.aspx');
        }
    },

})