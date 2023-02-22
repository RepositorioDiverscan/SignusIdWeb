var urlAjaxIdioma = 'IdiomaCodigoAjax.aspx';
var urlRegistroAjax = 'RegistroAjax.aspx';

const codigo = new Vue({
    el: '#cod',
    data: {
        email: "",
        codigo: "",
        listaIdiomas: {},
        idiomaLogin: "",
        display: "none",
        extEmail: "",


    },
    mounted: function () {
        var idiLog = "ES"
        if (localStorage.getItem("idiomaApp") != undefined) {
            idiLog = localStorage.getItem("idiomaApp");
        }
        this.idiomaLogin = idiLog;
        this.estableceridiomalogin(this.idiomaLogin);


        this.email = sessionStorage.getItem('CorreoUsuario');
                               
        this.ExtensionCorreo();


   
    },
    methods: {
        estableceridiomalogin: function (tipoIdioma) {
            var self = this;
            $.post(urlAjaxIdioma, {
                idi: tipoIdioma,
            }, function (data, error) {
                self.listaIdiomas = JSON.parse(data);
            });
        }
        ,
        establecerempresa: function () {
            let array = JSON.parse(sessionStorage.getItem('DUser'));
            let empresa = this.empresa;
            array.forEach(function (entry) {
                if (empresa == entry.IdPerfilEmpresa) {
                    var Json = JSON.stringify([{ IdPerfilUsuario: entry.IdPerfilUsuario, Nombre: entry.Nombre, Apellildo: entry.Apellildo, ImagenPerfil: entry.ImagenPerfil, Identificacion: entry.Identificacion, IdPerfilActive: entry.IdPerfilActive, IdPerfilEmpresa: entry.IdPerfilEmpresa, NombreEmpresa: entry.NombreEmpresa }]);
                    sessionStorage.setItem('DUser', Json);

                    window.location.replace("../Menu/MenuPrincipal.aspx");
                }
            });
        },
   
    

        ValidarCodigo: function () {
            var self = this;
            $.post(urlRegistroAjax, {
                option: 'ValidarCodigo',
                Correo: self.email,
                Codigo: self.codigo,
            }, function (respuesta, error) {

                    if (respuesta != 'VALIDO') {


                } else {

                    window.location.href = "../RegistroUsuarioEmpresas/SeleccionPlan.aspx";
                }


            });
        },

        NuevoCodigo: function () {
            var self = this;
            $.post(urlRegistroAjax, {
                option: 'NuevoCodigo',
                Correo: self.email,
            }, function (respuesta, error) {

                if (respuesta != 'EXITOSO') {


                } else {

                }


            });
        },

        ExtensionCorreo: function () {
            var self = this;

            let posicion = self.email.search("@");

            self.extEmail = self.email.slice(posicion);
        }




    },
})
