var urlIdioma = 'IdiomaUbicacionAjax.aspx'

const Ubicacion = new Vue({

    el: '#Ubicacionidioma',

    data: {
        listaIdiomasUbicacion: [],
    },



    mounted: function () {

        this.listaIdiomasUbicacion = this.ObtenerIdiomaUbicaciones();


    },

    methods: {


        // CONFIGURAR EL IDIOMA

        ObtenerIdiomaUbicaciones: function () {

            var idiActualiza = "ES"

            if (localStorage.getItem("idiomaApp") != undefined) {

                idiActualiza = localStorage.getItem("idiomaApp");

            }

            this.EstablecerIdiomaUbicaciones(idiActualiza);

        },

        EstablecerIdiomaUbicaciones: function (idioma) {

            var self = this

            $.post(urlIdioma, {

                idi: idioma,

            },
                function (data, error) {

                    self.listaIdiomasUbicacion = JSON.parse(data);

                });

        },
    }
})


        // FIN METODOS DE IDIOMA