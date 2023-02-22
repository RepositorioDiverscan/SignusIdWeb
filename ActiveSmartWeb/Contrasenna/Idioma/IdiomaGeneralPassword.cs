using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Contrasenna.Idioma
{
    public class IdiomaGeneralPassword
    {
        private string _titulo;
        private string _Password;
        private string _PlhPassword;
        private string _ConfirmarPassword;
        private string _PlhConfirmarPassword;
        private string _guardar;
        private string _errorLargoOp;
        private string _errorLargoAd;
        private string _errorLetraMayusMinus;
        private string _errorCaracterEspecial;
        private string _errorNoCoinciden;
        private string _errorNumero;
        private string _contraCambiada;
        private string _atencion;
        private string _ningunaIgual;
        private string olvidoContrasenna;
        private string txtAyudaCorreo;
        private string correo;
        private string enviar;
        private string _olCorreoNo;
        private string _olCorreoIn;
        private string _olCorreoEr;
        private string _olCorreoEn;

        public IdiomaGeneralPassword(){
        
        }

        public IdiomaGeneralPassword(string titulo, string password, string plhPassword, string confirmarPassword, string plhConfirmarPassword, string guardar, string errorLargoOp, string errorLargoAd, string errorLetraMayusMinus, string errorCaracterEspecial, string atencion, string errorNoCoinciden, string errorNumero, string contraCambiada, string ningunaIgual, string olCorreoNo, string olCorreoIn, string olCorreoEr, string olCorreoEn, string olvidoContrasenna = null, string txtAyudaCorreo = null, string correo = null, string enviar = null)
        {
            Titulo = titulo;
            Password = password;
            PlhPassword = plhPassword;
            ConfirmarPassword = confirmarPassword;
            PlhConfirmarPassword = plhConfirmarPassword;
            Guardar = guardar;
            ErrorLargoAd = errorLargoAd;
            ErrorLargoOp = errorLargoOp;
            ErrorLetraMayusMinus = errorLetraMayusMinus;
            ErrorCaracterEspecial = errorCaracterEspecial;
            Atencion = atencion;
            ErrorNoCoinciden = errorNoCoinciden;
            ErrorNumero = errorNumero;
            ContraCambiada = contraCambiada;
            NingunaIgual = ningunaIgual;
            OlvidoContrasenna = olvidoContrasenna;
            TxtAyudaCorreo = txtAyudaCorreo;
            Correo = correo;
            Enviar = enviar;
            OlCorreoNo = olCorreoNo;
            OlCorreoIn = olCorreoIn;
            OlCorreoEr = olCorreoEr;
            OlCorreoEn = olCorreoEn;
        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string PlhPassword { get => _PlhPassword; set => _PlhPassword = value; }
        public string ConfirmarPassword { get => _ConfirmarPassword; set => _ConfirmarPassword = value; }
        public string PlhConfirmarPassword { get => _PlhConfirmarPassword; set => _PlhConfirmarPassword = value; }
        public string Guardar { get => _guardar; set => _guardar = value; }
        public string ErrorLetraMayusMinus { get => _errorLetraMayusMinus; set => _errorLetraMayusMinus = value; }
        public string ErrorCaracterEspecial { get => _errorCaracterEspecial; set => _errorCaracterEspecial = value; }
        public string ErrorNoCoinciden { get => _errorNoCoinciden; set => _errorNoCoinciden = value; }
        public string Atencion { get => _atencion; set => _atencion = value; }
        public string ErrorNumero { get => _errorNumero; set => _errorNumero = value; }
        public string ContraCambiada { get => _contraCambiada; set => _contraCambiada = value; }
        public string NingunaIgual { get => _ningunaIgual; set => _ningunaIgual = value; }
        public string OlvidoContrasenna { get => olvidoContrasenna; set => olvidoContrasenna = value; }
        public string TxtAyudaCorreo { get => txtAyudaCorreo; set => txtAyudaCorreo = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Enviar { get => enviar; set => enviar = value; }
        public string ErrorLargoOp { get => _errorLargoOp; set => _errorLargoOp = value; }
        public string ErrorLargoAd { get => _errorLargoAd; set => _errorLargoAd = value; }
        public string OlCorreoNo { get => _olCorreoNo; set => _olCorreoNo = value; }
        public string OlCorreoIn { get => _olCorreoIn; set => _olCorreoIn = value; }
        public string OlCorreoEr { get => _olCorreoEr; set => _olCorreoEr = value; }
        public string OlCorreoEn { get => _olCorreoEn; set => _olCorreoEn = value; }
    }
}