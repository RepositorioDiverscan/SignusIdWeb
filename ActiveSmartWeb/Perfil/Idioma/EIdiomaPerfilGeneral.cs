using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Perfil.Idioma
{
    public class EIdiomaPerfilGeneral
    {
        private string _titulo;
        private string _tipoUsuario;
        private string _numeroCuenta;
        private string _perfilGeneral;
        private string _nombre;
        private string _apellidos;
        private string _identificacionPersonal;
        private string _correo;
        private string _puesto;
        private string _telefono;
        private string _cambiarContra;
        private string _contraActual;
        private string _nuevaContra;
        private string _confirmaContra;
        private string _descubra;
        private string _irTienda;
        private string _correoError;
        private string _telefonoError;
        private string _faltanCampos;
        private string _usuarioActualizado;
        private string _errorContrasIguales;
        private string _errorContraActNoCoincide;
        private string _errorNuevaContraConf;
        private string _contraActualizada;
        private string _errorNuevaContraLargo;
        private string _errorNuevaContraNumero;
        private string _errorNuevaContraEspecial;
        private string _errorNuevaContraMayus;
        private string _errorNuevaContraMinus;
        private string _errorNuevaContraActualizar;
        private string _errorNuevaContranIgual;
        private string _llenarIdentificacion;
        private string _llenarPuesto;
        private string _llenarTelefono;
        private string _atencion;
        private string _msjInfo1;
        private string _msjInfo2;

        public EIdiomaPerfilGeneral()
        {
        }

        public EIdiomaPerfilGeneral(string titulo, string tipoUsuario, string numeroCuenta, string perfilGeneral, string nombre, string apellidos, string identificacionPersonal, string correo, string puesto, string telefono, string cambiarContra, string contraActual, string nuevaContra, string confirmaContra, string descubra, string irTienda, string correoError, string telefonoError, string faltanCampos, string usuarioActualizado, string errorContrasIguales, string errorContraActNoCoincide, string errorNuevaContraConf, string contraActualizada, string errorNuevaContraLargo, string errorNuevaContraNumero, string errorNuevaContraEspecial, string errorNuevaContraMayus, string errorNuevaContraMinus, string errorNuevaContraActualizar, string errorNuevaContranIgual, string llenarIdentificacion, string llenarPuesto, string llenarTelefono, string atencion, string msjInfo1, string msjInfo2)
        {
            Titulo = titulo;
            TipoUsuario = tipoUsuario;
            NumeroCuenta = numeroCuenta;
            PerfilGeneral = perfilGeneral;
            Nombre = nombre;
            Apellidos = apellidos;
            IdentificacionPersonal = identificacionPersonal;
            Correo = correo;
            Puesto = puesto;
            Telefono = telefono;
            CambiarContra = cambiarContra;
            ContraActual = contraActual;
            NuevaContra = nuevaContra;
            ConfirmaContra = confirmaContra;
            Descubra = descubra;
            IrTienda = irTienda;
            CorreoError = correoError;
            TelefonoError = telefonoError;
            FaltanCampos = faltanCampos;
            UsuarioActualizado = usuarioActualizado;
            ErrorContrasIguales = errorContrasIguales;
            ErrorContraActNoCoincide = errorContraActNoCoincide;
            ErrorNuevaContraConf = errorNuevaContraConf;
            ContraActualizada = contraActualizada;
            ErrorNuevaContraLargo = errorNuevaContraLargo;
            ErrorNuevaContraNumero = errorNuevaContraNumero;
            ErrorNuevaContraEspecial = errorNuevaContraEspecial;
            ErrorNuevaContraMayus = errorNuevaContraMayus;
            ErrorNuevaContraMinus = errorNuevaContraMinus;
            ErrorNuevaContraActualizar = errorNuevaContraActualizar;
            ErrorNuevaContranIgual = errorNuevaContranIgual;
            LlenarIdentificacion = llenarIdentificacion;
            LlenarPuesto = llenarPuesto;
            LlenarTelefono = llenarTelefono;
            Atencion = atencion;
            MsjInfo1 = msjInfo1;
            MsjInfo2 = msjInfo2;
        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string TipoUsuario { get => _tipoUsuario; set => _tipoUsuario = value; }
        public string NumeroCuenta { get => _numeroCuenta; set => _numeroCuenta = value; }
        public string PerfilGeneral { get => _perfilGeneral; set => _perfilGeneral = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public string IdentificacionPersonal { get => _identificacionPersonal; set => _identificacionPersonal = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Puesto { get => _puesto; set => _puesto = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string CambiarContra { get => _cambiarContra; set => _cambiarContra = value; }
        public string ContraActual { get => _contraActual; set => _contraActual = value; }
        public string NuevaContra { get => _nuevaContra; set => _nuevaContra = value; }
        public string ConfirmaContra { get => _confirmaContra; set => _confirmaContra = value; }
        public string Descubra { get => _descubra; set => _descubra = value; }
        public string IrTienda { get => _irTienda; set => _irTienda = value; }
        public string CorreoError { get => _correoError; set => _correoError = value; }
        public string TelefonoError { get => _telefonoError; set => _telefonoError = value; }
        public string FaltanCampos { get => _faltanCampos; set => _faltanCampos = value; }
        public string UsuarioActualizado { get => _usuarioActualizado; set => _usuarioActualizado = value; }
        public string ErrorContrasIguales { get => _errorContrasIguales; set => _errorContrasIguales = value; }
        public string ErrorContraActNoCoincide { get => _errorContraActNoCoincide; set => _errorContraActNoCoincide = value; }
        public string ErrorNuevaContraConf { get => _errorNuevaContraConf; set => _errorNuevaContraConf = value; }
        public string ContraActualizada { get => _contraActualizada; set => _contraActualizada = value; }
        public string ErrorNuevaContraLargo { get => _errorNuevaContraLargo; set => _errorNuevaContraLargo = value; }
        public string ErrorNuevaContraNumero { get => _errorNuevaContraNumero; set => _errorNuevaContraNumero = value; }
        public string ErrorNuevaContraEspecial { get => _errorNuevaContraEspecial; set => _errorNuevaContraEspecial = value; }
        public string ErrorNuevaContraMayus { get => _errorNuevaContraMayus; set => _errorNuevaContraMayus = value; }
        public string ErrorNuevaContraMinus { get => _errorNuevaContraMinus; set => _errorNuevaContraMinus = value; }
        public string ErrorNuevaContraActualizar { get => _errorNuevaContraActualizar; set => _errorNuevaContraActualizar = value; }
        public string ErrorNuevaContranIgual { get => _errorNuevaContranIgual; set => _errorNuevaContranIgual = value; }
        public string LlenarIdentificacion { get => _llenarIdentificacion; set => _llenarIdentificacion = value; }
        public string LlenarPuesto { get => _llenarPuesto; set => _llenarPuesto = value; }
        public string LlenarTelefono { get => _llenarTelefono; set => _llenarTelefono = value; }
        public string Atencion { get => _atencion; set => _atencion = value; }
        public string MsjInfo1 { get => _msjInfo1; set => _msjInfo1 = value; }
        public string MsjInfo2 { get => _msjInfo2; set => _msjInfo2 = value; }
    }
}