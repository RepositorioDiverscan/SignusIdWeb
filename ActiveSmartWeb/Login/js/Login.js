

sessionStorage.removeItem('DUser');
var urllogin = 'LoginAjax.aspx'
var urlidiomalogin = 'IdiomaLoginAjax.aspx'





Vue.component('login', {
    props: {
        email: String,
        password: String,
        listaidiomalogin: Object,
        idiomaLogin: ""
    },
    template: `
        
            <div id="email-form" name="email-form" data-name="Email Form" class="form-5">
                <label class="subtitulo centrado ingreso ingresar">{{listaidiomalogin.Titulo}}</label>
                <input type="email" class="text-field _90 w-input" maxlength="256"  :placeholder="[[listaidiomalogin.Mail]]" id="field-2" required="" v-model="email">
                <input type="password" class="text-field _90 w-input" maxlength="256"  :placeholder="[[listaidiomalogin.Contrasenna]]" id="field-2" required="" v-model="password">

                  <a  href="../Contrasenna/OlvidoContrasenna.aspx">Recuperar Contraseña</a>

                <a  class="boton w-button" v-on:click="ValidUser()">{{listaidiomalogin.BtnInicio}}</a>
            </div>    
        `,
    methods: {
        ValidUser: async function () {
            var self = this;
            if (this.email != '' && this.password != '') {
                $.post(urllogin, {
                    opciones: 'ValidUsers',
                    Email: this.email,
                    Password: this.password
                }, function (data, error) {
                      
                        if (data != 'ErrorAjax') {
                            var re = 0;
                            let arraydatos;

                            try {
                                arraydatos = JSON.parse(data);

                            } catch{
                                re = 1;
                            }

                          
                            if (re == 0) {

                                sessionStorage.setItem('Empresas', data)
                                sessionStorage.setItem('DUser', data)
                                if (arraydatos.length == 1) {
                                    window.location.replace("../Menu/MenuPrincipal.aspx");
                                }
                                else {
                                    login.empresas = JSON.parse(sessionStorage.getItem('DUser'));
                                    console.log('Revisa la variable');
                                }
                            } else {
                                return;
                            }
                    }
                    else {
                        sessionStorage.removeItem('DUser');
                        return;
                    }
                });
            }
        },

        ValidarInicioSesion:  function () {
          
                $.post(urllogin, {
                    opciones: 'ValidaLogin',
                    Email: this.email
                }, function (respuesta, error) {
                       
                        return respuesta;  
                        
                });
            
        }
    }


})


const login = new Vue({
    el: '#paglogin',
    data: {
        email: "",
        password: "",
        listaidiomalogin: {},
        idiomaLogin: "",
        display: "none",
        empresa: '',
        empresas: [],
    },
    mounted: function () {
        var idiLog = "ES"



        if (localStorage.getItem("idiomaApp") != undefined) {
            idiLog = localStorage.getItem("idiomaApp");

           
        }



        this.idiomaLogin = idiLog;
        this.estableceridiomalogin(this.idiomaLogin);
    },
    methods: {
        estableceridiomalogin: function (tipoIdioma) {
            $.post(urlidiomalogin, {
                idiomaLogin: tipoIdioma,
            }, function (data, error) {
                login.listaidiomalogin = JSON.parse(data);
            });
        }
        ,
        establecerempresa: function () {
            let array = JSON.parse(sessionStorage.getItem('DUser'));
            let empresa = this.empresa;
            array.forEach(function (entry) {
                if (empresa == entry.IdPerfilEmpresa) {
                    var Json = JSON.stringify([{ IdPerfilUsuario: entry.IdPerfilUsuario, Nombre: entry.Nombre, Apellildo: entry.Apellildo, ImagenPerfil: entry.ImagenPerfil, Identificacion: entry.Identificacion, IdPerfilActive: entry.IdPerfilActive, IdPerfilEmpresa: entry.IdPerfilEmpresa, NombreEmpresa: entry.NombreEmpresa, Correo: entry.Correo }]);
                    sessionStorage.setItem('DUser', Json);
                    
                    window.location.replace("../Menu/MenuPrincipal.aspx");
                }
            });
        }
    },
    watch: {
        empresas(val) {
            if (val)
                this.display = ''
        }
    }
})

