var urlAjax = 'Ajax/ActivosVisorAjax.aspx'
var urlIdioma = 'Idioma/IdiomaVisorAjax.aspx' 
var a = ''

const ActivosVisor = new Vue({
    el: '#maincontext',
    data: {
        listaIdiomas: [] ,
        IdiomaVisorActivos: '',
        Select_Busqueda: '0',
        Criterio_Busqueda: '',
        Numero_Activo: '',
        Numero_Placa: '',
        Numero_Serie: '',
        Descripcion1: '',
        Descripcion2: '',
        Categoria: '',
        Estado: '',
        Marca: '',
        Modelo: '',
        UbicacionA: '',
        UbicacionB: '',
        UbicacionC: '',
        UbicacionD: '',
        Observaciones: '',
        Foto1: '../images/Null-Image.jpg',
        Foto2: '../images/Null-Image.jpg',
        Foto3: '../images/Null-Image.jpg',
        Foto4: '../images/Null-Image.jpg',
        Foto5: '../images/Null-Image.jpg',
        IdPefil_Empresa: ''
    },
    mounted: function () {
        // OBTENER DE LA VARIABLE DE SESIÓN LA EMPRESA
        var logueado = JSON.parse(sessionStorage.getItem('DUser'));
        this.IdPefil_Empresa = logueado[0].IdPerfilEmpresa;
        listaIdiomas = this.ObtenerIdioma();
    },
    methods: {

        // CONFIGURAR EL IDIOMA
        ObtenerIdioma: function () {
            var idiActualiza = "ES"
            if (localStorage.getItem("idiomaApp") != undefined) {
                idiActualiza = localStorage.getItem("idiomaApp");
            }
            this.EstablecerIdiomaVisorActivo(idiActualiza);
        },
        EstablecerIdiomaVisorActivo: function (idioma) {
            var self = this
            $.post(urlIdioma, {
                IdiomaVisorActivos: idioma,
            }, function (data, error) {
                    self.listaIdiomas = JSON.parse(data);
            });
        },
        // FIN METODOS DE IDIOMA

        // Busqueda y carga del Activo
        CargarInformacionActivoXNumero: function () {
               var self = this;
            $.post(urlAjax, {
                option: 'ObtenerActivoPorNumero',
                NumeroActivo: self.Criterio_Busqueda,
                IdPerfilEmpresa: self.IdPefil_Empresa
            }, function (data, error) {

                    var Json = JSON.parse(data);
                    if (Json.length != 0) {

                    self.Numero_Activo = Json[0].NumeroActivo;
                    self.Numero_Placa = Json[0].PlacaActivo;
                    self.Numero_Serie = Json[0].Serie;
                    self.Descripcion1 = Json[0].DescripcionCorta;
                    self.Descripcion2 = Json[0].DescripcionLarga;
                    self.Categoria = Json[0].Categoria;
                    self.Estado = Json[0].Estado ;
                    self.Marca = Json[0].Marca;
                    self.Modelo = Json[0].Modelo;
                    self.UbicacionA = Json[0].UbicacionA;
                    self.UbicacionB = Json[0].UbicacionB;
                    self.UbicacionC = Json[0].UbicacionC;
                    self.UbicacionD = Json[0].UbicacionD;
                    self.Observaciones = Json[0].Observaciones;
                }
                else {
                    // HAY QUE MOSTRAR UN MENSAJE QUE NO SE ENCONTRÓ EL ACTIVO
                        self.Numero_Activo = '';
                        self.Numero_Placa = '';
                        self.Numero_Serie = '';
                        self.Descripcion1 = '';
                        self.Descripcion2 = '';
                        self.Categoria = '';
                        self.Estado = '';
                        self.Marca = '';
                        self.Modelo = '';
                        self.UbicacionA = '';
                        self.UbicacionB = '';
                        self.UbicacionC = '';
                        self.UbicacionD = '';
                        self.Observaciones = '';
                        self.Foto1 = '../images/Null-Image.jpg';
                        self.Foto2 = '../images/Null-Image.jpg';
                        self.Foto3 = '../images/Null-Image.jpg';
                        self.Foto4 = '../images/Null-Image.jpg';
                        self.Foto5 = '../images/Null-Image.jpg';
                    
                   
                }
            });
        },

        CargarInformacionActivoXPlaca: function () {
            var self = this;
            $.post(urlAjax, {
                option: 'ObtenerActivoPorPlaca',
                PlacaActivo: self.Criterio_Busqueda,
                IdPerfilEmpresa: self.IdPefil_Empresa
            }, function (data, error) {

                    var Json = JSON.parse(data);
                    if (Json.length != 0) {
                    
                    self.Numero_Activo = Json[0].NumeroActivo;
                    self.Numero_Placa = Json[0].PlacaActivo;
                    self.Numero_Serie = Json[0].Serie;
                    self.Descripcion1 = Json[0].DescripcionCorta;
                    self.Descripcion2 = Json[0].DescripcionLarga;
                    self.Categoria = Json[0].Categoria;
                    self.Estado = Json[0].Estado;
                    self.Marca = Json[0].Marca;
                    self.Modelo = Json[0].Modelo;
                    self.UbicacionA = Json[0].UbicacionA;
                    self.UbicacionB = Json[0].UbicacionB;
                    self.UbicacionC = Json[0].UbicacionC;
                    self.UbicacionD = Json[0].UbicacionD;
                    self.Observaciones = Json[0].Observaciones;
                }
                else {
                    // HAY QUE MOSTRAR UN MENSAJE QUE NO SE ENCONTRÓ EL ACTIVO
                        self.Numero_Activo = '';
                        self.Numero_Placa = '';
                        self.Numero_Serie = '';
                        self.Descripcion1 = '';
                        self.Descripcion2 = '';
                        self.Categoria = '';
                        self.Estado = '';
                        self.Marca = '';
                        self.Modelo = '';
                        self.UbicacionA = '';
                        self.UbicacionB = '';
                        self.UbicacionC = '';
                        self.UbicacionD = '';
                        self.Observaciones = '';
                        self.Foto1 = '../images/Null-Image.jpg';
                        self.Foto2 = '../images/Null-Image.jpg';
                        self.Foto3 = '../images/Null-Image.jpg';
                        self.Foto4 = '../images/Null-Image.jpg';
                        self.Foto5 = '../images/Null-Image.jpg';
                  


                }
            });
        },

        BuscarActivoVisor: function () {
            var self = this;
            if (self.Select_Busqueda == '0' || self.Select_Busqueda == '-1') {
                alert("DEBE SELECCIONAR UN MÉTODO DE BÚSQUEDA");
                return;
            }
            if (self.Criterio_Busqueda == '') {
                alert("DEBE ESCRIBIR UN CRITERIO DE BUSQUEDA");
                return;
            }
            if (self.Select_Busqueda == '1') {
                self.CargarInformacionActivoXNumero();
                self.ObtenerFotosActivos();
            } else {
                self.CargarInformacionActivoXPlaca();
                self.ObtenerFotosActivos();
            }
           
        },

        ObtenerFotosActivos: function () {
            var self = this;
            $.post(urlAjax, {
                option: 'ObtenerFotosActivos',
                Numero: self.Numero_Activo
            }, function (data, error) {

                    var Json = JSON.parse(data);
                    self.Foto1 = Json[0] ;
                    self.Foto2 = Json[1];
                    self.Foto3 = Json[2];
                    self.Foto4 = Json[3];
                    self.Foto5 = Json[4];
                  
            });
        }
    }

})

