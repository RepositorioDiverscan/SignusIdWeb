var urlAjax = 'MetodosPagoAjax.aspx'

const MetodosPago = new Vue({

    el: '#METODOS-DE-PAGO',

    data: {
        //Variables a utilizar
        
    },

    mounted: function () {
        this.ObtenerMetodosPago();
        
    },

    methods: {

        ObtenerMetodosPago: function () {
            $.post(urlAjax, {
                Opcion: 'CargarMetodos',
                IdEmpresa: '123',
            }, function (data, error) {
                //self.listaidioma = JSON.parse(data);
            });
        },

    }
})