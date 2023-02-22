var urlIdioma = 'Ajax/AjaxIdiomaEmpleados.aspx'


const Empleados = new Vue({

    el: '#EmpleadosVUE',

    data: {
       
        listaIdiomas: [],
    },

    mounted: function () {

        this.listaIdiomas = this.ObtenerIdiomaEmpleados();

    },

    methods: {


        // CONFIGURAR EL IDIOMA

        ObtenerIdiomaEmpleados: function () {

            var idiActualiza = "ES"

            if (localStorage.getItem("idiomaApp") != undefined) {

                idiActualiza = localStorage.getItem("idiomaApp");

            }

            this.EstablecerIdiomaEmpleados(idiActualiza);

        },

        EstablecerIdiomaEmpleados: function (idioma) {

            var self = this


            $.post(urlIdioma, {

                IE: idioma,

            }, function (data, error) {

                self.listaIdiomas = JSON.parse(data);

            });

        },

        // FIN METODOS DE IDIOMA
    },

})