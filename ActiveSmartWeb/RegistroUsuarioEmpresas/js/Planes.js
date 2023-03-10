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