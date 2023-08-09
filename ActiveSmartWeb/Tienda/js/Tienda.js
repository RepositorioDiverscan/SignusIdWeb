var urlIdioma = 'AjaxIdiomaTienda.aspx'
var urlAdicionalesContratoAjax = '../RegistroUsuarioEmpresas/AdicionalesContratoAjax.aspx';

const app = new Vue({

    el: '#tiendaVue',

    data: {
        listaIdiomas: [],
        numActivos: 0,
        ubicacionesA: 0,
        personalParaActivos: 0,
        usuariosGestores: 0,
        precio: "0",
        totalpago: "0",
        adicionales: [],
        adicionalesseleccionados: []
    },

    mounted: function () {
        this.listaIdiomas = this.ObtenerIdioma();
        this.CargarAdicionales();
        this.CargarAdicionalesContratado();
    },

    methods: {

        ObtenerIdioma: function () {

            var idiActualiza = "ES"

            if (localStorage.getItem("idiomaApp") != undefined) {

                idiActualiza = localStorage.getItem("idiomaApp");

            }

            this.EstablecerIdiomaTienda(idiActualiza);

        },

        EstablecerIdiomaTienda: function (idioma) {

            var self = this

            $.post(urlIdioma, {

                IdiomaTienda: idioma,

            }, function (data, error) {

                self.listaIdiomas = JSON.parse(data);

            });

        },

        //Metodo para cargar los adicionales.
        CargarAdicionales: function () {
            var self = this;
            $.post(urlAdicionalesContratoAjax, {
                option: 'CargarAdicionales'
            }, function (data, error) {
                self.adicionales = JSON.parse(data);
                
            });
        },

        //Metodo para cargar los adicionales seleccionados.
        CargarAdicionalesContratado: function () {
            var self = this;
            $.post(urlAdicionalesContratoAjax, {
                option: 'CargarAdicionalescontratados'
            }, function (data, error) {
                self.adicionalesseleccionados = JSON.parse(data);
                self.CargarTotal();
                //self.validarCodigoPlan();
            });
        },

        //Metodo para cargar el total de la compra.
        CargarTotal: function () {
            var self = this;
            $.post(urlAdicionalesContratoAjax, {
                option: 'CargarTotal',
                precioplan: self.precio
            }, function (data, error) {

                self.totalpago = data;

            });
        },


        //Metodo para cargar el precio,nombre y la imagen del plan seleccionado.
        CargarPrecio: function () {
            var self = this;
            var codigo = sessionStorage.getItem("CodigoPlan");


            if (codigo == "1") {
                this.rutaImagen = "https://rockcontent.com/es/wp-content/uploads/sites/3/2019/02/Consejos-para-hacer-ima%CC%81genes-increi%CC%81bles-1024x538.png";
            }
            else {
                this.rutaImagen = "../images/smartcostalogo.png";
            }



            $.post(urlAdicionalesContratoAjax, {
                option: 'CargarPrecio',
                CodigoPlan: codigo

            }, function (data, error) {

                let datos = JSON.parse(data);
                self.textoPlan = datos.NombrePlan;
                self.precio = datos.Costo;
                self.totalpago = datos.Costo;
            });
        },

        

    }


})