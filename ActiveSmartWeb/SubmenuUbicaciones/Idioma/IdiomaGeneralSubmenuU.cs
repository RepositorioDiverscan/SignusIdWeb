using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.SubmenuUbicaciones.Idioma
{
    public class IdiomaGeneralSubmenuU
    {
        private string _titulo;
        private string _ubicacionA;
        private string _ubicacionB;
        private string _ubicacionC;
        private string _ubicacionD;
        private string _msjTienda;
        private string _msjbtnTienda;
        public IdiomaGeneralSubmenuU() { }
        public IdiomaGeneralSubmenuU(string titulo, string ubicacionA, string ubicacionB,
            string ubicacionC, string ubicacionD, string msjTienda, string msjbtntienda)
        {
            _titulo = titulo;
            _ubicacionA = ubicacionA;
            _ubicacionB = ubicacionB;
            _ubicacionC = ubicacionC;
            _ubicacionD = ubicacionD;
            _msjbtnTienda = msjbtntienda;
            _msjTienda = msjTienda;
        }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string UbicacionA { get => _ubicacionA; set => _ubicacionA = value; }
        public string UbicacionB { get => _ubicacionB; set => _ubicacionB = value; }
        public string UbicacionC { get => _ubicacionC; set => _ubicacionC = value; }
        public string UbicacionD { get => _ubicacionD; set => _ubicacionD = value; }
        public string MsjTienda { get => _msjTienda; set => _msjTienda = value; }
        public string MsjbtnTienda { get => _msjbtnTienda; set => _msjbtnTienda = value; }
    }
}