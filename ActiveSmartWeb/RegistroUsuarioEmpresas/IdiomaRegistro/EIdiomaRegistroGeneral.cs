using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RegistroUsuarioEmpresas.Entidades
{
    public class EIdiomaRegistroGeneral
    {

        private string _labelInfoEmpresa;
        private string _labelRegistroPerfil;
        private string _labelNombreEmpresa;
        private string _labelTelefonoEmpresa;
        private string _labelCorreoEmpresa;
        private string _labelNombrePerfil;
        private string _labelApellidosPerfil;
        private string _labelCorreoPerfil;
        private string _labelContrasena;
        private string _labelContrasena1;
        private string _btnSiguiente;
        private string _atencion;
        private string _errNombreEmp;
        private string _errTelEmp;
        private string _errNombreUs;
        private string _errApellidoUs;
        private string _errCorreoUs;
        private string _errContrasena;
        private string _errIdEmpresa;
        private string _errIdIndustria;
        private string _errIdEmpresaTam;
        private string _errIdEmpresaPais;
        private string _errIdEmpresaDir;
        private string _errPosUsuario;
        private string _errConIgual;
        private string _errTerminos;

        public EIdiomaRegistroGeneral()
        {
        }

        public EIdiomaRegistroGeneral(string labelInfoEmpresa, string labelRegistroPerfil, string labelNombreEmpresa, string labelTelefonoEmpresa, string labelCorreoEmpresa,
            string labelNombrePerfil, string labelApellidosPerfil, string labelCorreoPerfil, string labelContrasena,
            string labelContrasena1, string btnSiguiente, string errNombreEmp, string errTelEmp, string errNombreUs, string errApellidoUs, string errCorreoUs, string errContrasena, string errIdEmpresa, string errIdIndustria, string errIdEmpresaTam, string errIdEmpresaPais, string errIdEmpresaDir, string errPosUsuario, string errConIgual, string atencion)
        {

            _labelInfoEmpresa = labelInfoEmpresa;
            _labelRegistroPerfil = labelRegistroPerfil;
            _labelNombreEmpresa = labelNombreEmpresa;
            _labelTelefonoEmpresa = labelTelefonoEmpresa;
            _labelCorreoEmpresa = labelCorreoEmpresa;
            _labelNombrePerfil = labelNombrePerfil;
            _labelApellidosPerfil = labelApellidosPerfil;
            _labelCorreoPerfil = labelCorreoPerfil;
            _labelContrasena = labelContrasena;
            _labelContrasena1 = labelContrasena1;
            _btnSiguiente = btnSiguiente;
            ErrNombreEmp = errNombreEmp;
            ErrTelEmp = errTelEmp;
            ErrNombreUs = errNombreUs;
            ErrApellidoUs = errApellidoUs;
            ErrCorreoUs = errCorreoUs;
            ErrContrasena = errContrasena;
            ErrIdEmpresa = errIdEmpresa;
            ErrIdIndustria = errIdIndustria;
            ErrIdEmpresaTam = errIdEmpresaTam;
            ErrIdEmpresaPais = errIdEmpresaPais;
            ErrIdEmpresaDir = errIdEmpresaDir;
            ErrPosUsuario = errPosUsuario;
            ErrConIgual = errConIgual;
            Atencion = atencion;
        }




        public string LabelInfoEmpresa { get => _labelInfoEmpresa; set => _labelInfoEmpresa = value; }
        public string LabelRegistroPerfil { get => _labelRegistroPerfil; set => _labelRegistroPerfil = value; }
        public string LabelNombreEmpresa { get => _labelNombreEmpresa; set => _labelNombreEmpresa = value; }
        public string LabelTelefonoEmpresa { get => _labelTelefonoEmpresa; set => _labelTelefonoEmpresa = value; }
        public string LabelCorreoEmpresa { get => _labelCorreoEmpresa; set => _labelCorreoEmpresa = value; }
        public string LabelNombrePerfil { get => _labelNombrePerfil; set => _labelNombrePerfil = value; }
        public string LabelApellidosPerfil { get => _labelApellidosPerfil; set => _labelApellidosPerfil = value; }
        public string LabelCorreoPerfil { get => _labelCorreoPerfil; set => _labelCorreoPerfil = value; }
        public string LabelContrasena { get => _labelContrasena; set => _labelContrasena = value; }
        public string LabelContrasena1 { get => _labelContrasena1; set => _labelContrasena1 = value; }
        public string BtnSiguiente { get => _btnSiguiente; set => _btnSiguiente = value; }
        public string ErrNombreEmp { get => _errNombreEmp; set => _errNombreEmp = value; }
        public string ErrTelEmp { get => _errTelEmp; set => _errTelEmp = value; }
        public string ErrNombreUs { get => _errNombreUs; set => _errNombreUs = value; }
        public string ErrApellidoUs { get => _errApellidoUs; set => _errApellidoUs = value; }
        public string ErrCorreoUs { get => _errCorreoUs; set => _errCorreoUs = value; }
        public string ErrContrasena { get => _errContrasena; set => _errContrasena = value; }
        public string ErrIdEmpresa { get => _errIdEmpresa; set => _errIdEmpresa = value; }
        public string ErrIdIndustria { get => _errIdIndustria; set => _errIdIndustria = value; }
        public string ErrIdEmpresaTam { get => _errIdEmpresaTam; set => _errIdEmpresaTam = value; }
        public string ErrIdEmpresaPais { get => _errIdEmpresaPais; set => _errIdEmpresaPais = value; }
        public string ErrIdEmpresaDir { get => _errIdEmpresaDir; set => _errIdEmpresaDir = value; }
        public string ErrPosUsuario { get => _errPosUsuario; set => _errPosUsuario = value; }
        public string ErrConIgual { get => _errConIgual; set => _errConIgual = value; }
        public string ErrTerminos { get => _errTerminos; set => _errTerminos = value; }
        public string Atencion { get => _atencion; set => _atencion = value; }
    }
}