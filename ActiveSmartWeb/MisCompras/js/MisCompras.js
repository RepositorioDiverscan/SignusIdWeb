var urlAjaxIdioma = 'IdiomaMisComprasAjax.aspx';
var urlMisComprasAjax = 'MisComprasAjax.aspx';


const contrato = new Vue({

    el: '#context',
    //Variables para utilizar en el v-model de vue.
    data: {
        AdicionalesMisCompras: [],
        Informaciones: [],
        listaIdiomas: {},
    },
    mounted: function () {
       /* Llamados a metodos para cargar la informacion necesaria.*/
        var idiLog = "ES"
        if (localStorage.getItem("idiomaApp") != undefined) {
            idiLog = localStorage.getItem("idiomaApp");
        }
        this.idiomaLogin = idiLog;
        this.estableceridiomalogin(this.idiomaLogin);
        this.CargarFechaVencimiento();
        this.CargarAdicionalesMisCompras();
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

        //Metodo para cargar la informacion del plan.
        CargarFechaVencimiento: function () {
            var self = this;
            let user = JSON.parse(sessionStorage.getItem('DUser'));
            $.post(urlMisComprasAjax, {
                option: 'CargarFechaVencimiento',
                idEmpresa: user[0].IdPerfilEmpresa
            }, function (data, error) {

                var datos = JSON.parse(data);

                var fechavencimiento = new Date(datos[0].FechaVencimiento);

                datos[0].FechaVencimiento = fechavencimiento.getDate() + "/" + (fechavencimiento.getMonth() + 1) + "/" + fechavencimiento.getFullYear();

                self.Informaciones = datos;

            });
        },


        //Metodo para cargar los adicionales mis compras.
        CargarAdicionalesMisCompras: function () {
            var self = this;
            let user = JSON.parse(sessionStorage.getItem('DUser'));
            $.post(urlMisComprasAjax, {
                option: 'CargarAdicionalesMisCompras',
                idEmpresa: user[0].IdPerfilEmpresa
            }, function (data, error) {


                self.AdicionalesMisCompras = JSON.parse(data);


            });
        },

        ValidarSesion: function () {

            var dConfig = JSON.parse(sessionStorage.getItem('DConfig'));
            var dUser = JSON.parse(sessionStorage.getItem('DUser'));

            if (dConfig == null || dConfig.CofPerfil == false || dUser[0].TipoUsuario != 1) {
                window.location.href = window.location.origin + "/AccesoDenegado.aspx";
            }
        },


        AdicionalTienda: function (adicional) {

            var adicional = JSON.stringify(adicional);

            sessionStorage.setItem('adicional', adicional);

            window.location.href = window.location.origin + "/Tienda/Tienda.aspx";

        },

    },
})
