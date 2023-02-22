var urlIdioma = 'IdiomaUbicacionAjax.aspx'
var urlEjemplo = 'AjaxEjemplo.aspx'


const Ejemplo = new Vue({

    el: '#IdiomaUbicaciones',

    data: {
        codigo: "",
        listaIdiomas: [],


    },

    mounted: function () {

        this.listaIdiomas = this.ObtenerIdioma();


    },

    methods: {


        // CONFIGURAR EL IDIOMA

        ObtenerIdioma: function () {

            var idiActualiza = "ES"

            if (localStorage.getItem("idiomaApp") != undefined) {

                idiActualiza = localStorage.getItem("idiomaApp");

            }

            this.EstablecerIdioma(idiActualiza);

        },

        EstablecerIdioma: function (idioma) {

            var self = this

            $.post(urlIdioma, {

                idi: idioma,

            },
                function (data, error) {

                    self.listaIdiomas = JSON.parse(data);

                });

        },

        // FIN METODOS DE IDIOMA

       
    },

})