var urlIdioma = 'AjaxIdiomaEjemplo.aspx'
var urlEjemplo = 'AjaxEjemplo.aspx'


const Ejemplo = new Vue({

    el: '#EjemploVUE',

    data: {
        codigo:"",
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

            this.EstablecerIdiomaEjemplo(idiActualiza);

        },

        EstablecerIdiomaEjemplo: function (idioma) {

            var self = this

            $.post(urlIdioma, {

                idi: idioma,

            },
              function (data, error) {

                self.listaIdiomas = JSON.parse(data);

            });

        },

        // FIN METODOS DE IDIOMA

        MostrarAlerta: function () {
            var self = this;

            $.post(urlEjemplo, {

                opciones: self.codigo,

            },
                function (data, error) {


                });

        }
    },

})