
var url = '../AjaxPrincipalMaster/AjaxGeneralMaster.aspx'

$(document).ready(function () {
    $(document).click(function (event) {
        // Verifica si el evento se originó dentro o fuera del div
        if (!$(event.target).closest('#popupTCContenido').length) {
            // Si se hace clic fuera del div, ejecuta este código
            $("#popupTC").css("display", "none");
        } 
    });
});

setTimeout(function () {

const master = new Vue({
    el: '#main',
    data: {
        options: {},
        idioma: "",
        DUser:"",
        usuario: {}
    },
    mounted: function () {        
        var idi = "ES"
        if (sessionStorage.getItem('DUser') != undefined) {
            DUser = JSON.parse(sessionStorage.getItem('DUser'));
        }
        if (localStorage.getItem("idiomaApp") != undefined) {
            idi = localStorage.getItem("idiomaApp");
        }
        this.idioma = idi;
        this.idiomas(this.idioma)
        //master.usuario = JSON.parse(sessionStorage.getItem('DUser'));
        //this.Loading();
    },
    methods: {
        idiomas: function (tipoIdioma) {
            $.post(url, {
                idiomaMenuGeneral: tipoIdioma,
            }, function (data, error) {
                    master.options = JSON.parse(data);
            });
        },

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
        Loading: function () {
            $(window).on('load', function () {
                setTimeout(function () {
                    $(".loader-page").css({ visibility: "hidden", opacity: "0" })
                }, 850);

            });
        }
    },watch: {
        idioma(val) {           
            if (val)
                localStorage.setItem("idiomaApp", val);    
            this.idiomas(localStorage.getItem("idiomaApp"));            
        }
    },


})
const master2 = new Vue({
    el: '#main2',
    data: {
        options: {},
        idioma: "",
        DUser: "",
        usuario: {}
    },
    mounted: function () {
        var idi = "ES"
        if (sessionStorage.getItem('DUser') != undefined) {
            DUser = JSON.parse(sessionStorage.getItem('DUser'));
        }
        if (localStorage.getItem("idiomaApp") != undefined) {
            idi = localStorage.getItem("idiomaApp");
        }
        this.idioma = idi;
        this.idiomas(this.idioma)
        //master.usuario = JSON.parse(sessionStorage.getItem('DUser'));
    },
    methods: {
        idiomas: function (tipoIdioma) {
            $.post(url, {
                idiomaMenuGeneral: tipoIdioma,
            }, function (data, error) {
                master2.options = JSON.parse(data);
            });
        },

        abrirPopUpTC: function () {
            event.stopPropagation();
            var a = document.getElementById("popupTC");
            a.style.display = "block";
            $('#popupTCContenido').addClass('mostrarPopUpYC');
        },

        cerrarPopUpTC: function () {
            var a = document.getElementById("popupTC");
            var b = document.getElementById("popupTCContenido");
            a.style.display = "none";
            b.style.display = "none";
        },
        //Hace el scroll hacia el inicio de la pagina
        scrollInicio: function () {
                $('html, body').animate({
                    scrollTop: 0
                }, 2000);
        }

    },
    watch: {
        idioma(val) {
            if (val)
                localStorage.setItem("idiomaApp", val);
            this.idiomas(localStorage.getItem("idiomaApp"));
        }
    }

})

document.getElementById("refrescaridioma").addEventListener("change", function(){
    location.reload();
});
}, 600)


