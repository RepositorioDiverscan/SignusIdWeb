var urlAjax = 'MetodosPagoAjax.aspx'

$(document).ready(function () {

    var popupAgregarTarjeta = $('#popupAgregarTarjeta');

    // Agrega un evento click al documento
    $(document).click(function (event) {

        // Verifica si el evento se originó dentro o fuera del div
        if (!popupAgregarTarjeta.is(event.target) && popupAgregarTarjeta.closest(event.target).length === 0) {
            // Si se hace clic fuera del div, ejecuta este código

        } else {
            // Si se hace clic dentro del div, ejecuta este código
            $("#popupAgregarTarjeta").css("display", "none");
        }

    });

});

const MetodosPago = new Vue({

    el: '#METODOS-DE-PAGO',

    data: {
        //Variables a utilizar
        perfilUsuario: '',
        numerotarjeta: "",
        fechaVencimiento: "",
        codigo: "",
        nombretitular: "",
        apellidotitular: "",
        pais: "",
        estado: "",
        ciudad: "",
        direccion: "",
        metodosPago: []
    },

    mounted: function () {
        this.ObtenerMetodosPago();
        this.CargarInputPaises();
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
        MostrarPopUpAgregarTarjeta: function () {
            $("#popupAgregarTarjeta").css("display", "flex");
        },

        OcultarPopUpAgregarTarjeta: function () {
            $("#popupAgregarTarjeta").css("display", "none");
        },

        validardigitosfechavencimiento: function () {

            var self = this;

            var template = "xx/xx";

            let j = 0;
            let plaintext = "";
            let countj = 0;
            while (j < template.length) {
                if (countj > self.fechaVencimiento.length - 1) {
                    template = template.substring(0, j);
                    break;
                }

                if (template[j] == self.fechaVencimiento[j]) {
                    j++;
                    countj++;
                    continue;
                }

                if (template[j] == "x") {
                    template =
                        template.substring(0, j) + self.fechaVencimiento[countj] + template.substring(j + 1);
                    plaintext = plaintext + self.fechaVencimiento[countj];
                    countj++;
                }
                j++;
            }

            self.fechaVencimiento = template;

            if (self.fechaVencimiento.length <= 3) {

                var split = self.fechaVencimiento.split("/");

                self.fechaVencimiento = split[0];

            }

        },

        validardigitosnumerotarjeta: function () {

            var self = this;

            var template = "xxxx xxxx xxxx xxxx";

            let j = 0;
            let plaintext = "";
            let countj = 0;
            while (j < template.length) {
                if (countj > self.numerotarjeta.length - 1) {
                    template = template.substring(0, j);
                    break;
                }

                if (template[j] == self.numerotarjeta[j]) {
                    j++;
                    countj++;
                    continue;
                }

                if (template[j] == "x") {
                    template =
                        template.substring(0, j) + self.numerotarjeta[countj] + template.substring(j + 1);
                    plaintext = plaintext + self.numerotarjeta[countj];
                    countj++;
                }
                j++;
            }

            self.numerotarjeta = template;

            if (self.numerotarjeta.length == 15 || self.numerotarjeta.length == 10 || self.numerotarjeta.length == 5) {

                var split = self.numerotarjeta.split(" ");

                var splitunido = "";

                for (var i = 0; i < split.length; i++) {

                    splitunido = splitunido + split[i];

                }

                self.numerotarjeta = splitunido;

                self.validardigitosnumerotarjeta();

            }

        },

        CargarInputPaises: function () {
            //Configuracion del campo de seleccion de paises
            $("#Paises-5").countrySelect({
                defaultCountry: "us",
            });
        },

    }
})