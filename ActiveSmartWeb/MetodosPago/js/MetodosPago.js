var urlAjax = 'MetodosPagoAjax.aspx'

const MetodosPago = new Vue({

    el: '#METODOS-DE-PAGO',

    data: {
        //Variables a utilizar
        perfilUsuario: '',
        metodosPago: []
    },

    mounted: function () {
        this.ObtenerMetodosPago();
        
    },

    methods: {

        ObtenerMetodosPago: function () {
            var self = this;
            var usuario = JSON.parse(sessionStorage.getItem("DUser"));

            $.post(urlAjax, {
                Opcion: 'CargarMetodos',
                IdEmpresa: usuario[0].IdPerfilEmpresa,
            }, function (data, error) {
                data = JSON.parse(data);

                self.perfilUsuario = data.PerfilUsuario;
                self.metodosPago = data.MetodosPago

            });
        },

    }
})