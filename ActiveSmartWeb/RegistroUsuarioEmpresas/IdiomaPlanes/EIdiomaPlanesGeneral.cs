using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RegistroUsuarioEmpresas.IdiomaPlanes
{
    public class EIdiomaPlanesGeneral
    {

        private string _titulo;
        private string _descripcionFree;
        private string _descripcionBasic;
        private string _descripcionPro;
        private string _descripcionBusiness;
        private string _montoUsuarioFree;
        private string _montoUsuarioBasic;
        private string _montoUsuarioPro;
        private string _montoUsuarioBusiness;
        private string _facturaFree;
        private string _facturaBasic;
        private string _facturaPro;
        private string _facturaBusiness;
        private string _BtnFree;
        private string _BtnBasic;
        private string _BtnPro ;
        private string _BtnBusiness;
        public EIdiomaPlanesGeneral()
        {
        }

        public EIdiomaPlanesGeneral(string titulo, string descripcionFree, string descripcionBasic, string descripcionPro, string descripcionBusiness, string montoUsuarioFree, string montoUsuarioBasic, string montoUsuarioPro, string montoUsuarioBusiness, string facturaFree, string facturaBasic, string facturaPro, string facturaBusiness, string btnFree, string btnBasic, string btnPro, string btnBusiness )
        {                                                                                                                                                                                                                                                                                                                                          
            Titulo = titulo;                                                                                                                                                                                                                                                                                                                    
            DescripcionFree = descripcionFree;                                                                                                                                                                                                                                                                                    
            DescripcionBasic = descripcionBasic;
            DescripcionPro = descripcionPro;
            DescripcionBusiness = descripcionBusiness;
            MontoUsuarioFree = montoUsuarioFree;
            MontoUsuarioBasic = montoUsuarioBasic;
            MontoUsuarioPro = montoUsuarioPro;
            MontoUsuarioBusiness = montoUsuarioBusiness;
            FacturaFree = facturaFree;
            FacturaBasic = facturaBasic;
            FacturaPro = facturaPro;
            FacturaBusiness = facturaBusiness;
            BtnFree = btnFree;
            BtnBasic = btnBasic;
            BtnPro = btnBasic;
            BtnBusiness = btnBusiness;


        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string DescripcionFree { get => _descripcionFree; set => _descripcionFree = value; }
        public string DescripcionBasic { get => _descripcionBasic; set => _descripcionBasic = value; }
        public string DescripcionPro { get => _descripcionPro; set => _descripcionPro = value; }
        public string DescripcionBusiness { get => _descripcionBusiness; set => _descripcionBusiness = value; }
        public string MontoUsuarioFree { get => _montoUsuarioFree; set => _montoUsuarioFree = value; }
        public string MontoUsuarioBasic { get => _montoUsuarioBasic; set => _montoUsuarioBasic = value; }
        public string MontoUsuarioPro { get => _montoUsuarioPro; set => _montoUsuarioPro = value; }
        public string MontoUsuarioBusiness { get => _montoUsuarioBusiness; set => _montoUsuarioBusiness = value; }
        public string FacturaFree { get => _facturaFree; set => _facturaFree = value; }
        public string FacturaBasic { get => _facturaBasic; set => _facturaBasic = value; }
        public string FacturaPro { get => _facturaPro; set => _facturaPro = value; }
        public string FacturaBusiness { get => _facturaBusiness; set => _facturaBusiness = value; }
        public string BtnFree { get => _BtnFree; set => _BtnFree = value; }
        public string BtnBasic{ get => _BtnBasic; set => _BtnBasic = value; }
        public string BtnPro { get => _BtnPro; set => _BtnPro = value; }
        public string BtnBusiness { get => _BtnBusiness; set => _BtnBusiness = value; }
    }
}