using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.VisorActivos.Idioma
{
    public partial class IdiomaVisorAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IdiomaVisorGeneral Idioma = new IdiomaVisorGeneral();
            try
            {
                switch (Request.Form["IdiomaVisorActivos"])
                {
                    case "ES":
                        Idioma.Titulo = IdiomaVisorEspa._titulo;
                        Idioma.SelectFiltro = IdiomaVisorEspa._selectFiltro;
                        Idioma.NumActivo = IdiomaVisorEspa._numActivo;
                        Idioma.PlacaActivo = IdiomaVisorEspa._placaActivo;
                        Idioma.Serie = IdiomaVisorEspa._serie;
                        Idioma.Descripcion1 = IdiomaVisorEspa._descripcion1;
                        Idioma.Descripcion2 = IdiomaVisorEspa._descripcion2;
                        Idioma.Categoria = IdiomaVisorEspa._categoria;
                        Idioma.Estado = IdiomaVisorEspa._estado;
                        Idioma.Marca = IdiomaVisorEspa._marca;
                        Idioma.Modelo = IdiomaVisorEspa._modelo;
                        Idioma.Ubicaciones = IdiomaVisorEspa._ubicaciones;
                        Idioma.Observaciones = IdiomaVisorEspa._observaciones;
                        Idioma.Fotos = IdiomaVisorEspa._fotos;
                        Idioma.Foto1 = IdiomaVisorEspa._foto1;
                        Idioma.Foto2 = IdiomaVisorEspa._foto2;
                        Idioma.Foto3 = IdiomaVisorEspa._foto3;
                        Idioma.Foto4 = IdiomaVisorEspa._foto4;
                        Idioma.Foto5 = IdiomaVisorEspa._foto5;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;

                    case "EN":
                        Idioma.Titulo = IdiomaVisorEng._titulo;
                        Idioma.SelectFiltro = IdiomaVisorEng._selectFiltro;
                        Idioma.NumActivo = IdiomaVisorEng._numActivo;
                        Idioma.PlacaActivo = IdiomaVisorEng._placaActivo;
                        Idioma.Serie = IdiomaVisorEng._serie;
                        Idioma.Descripcion1 = IdiomaVisorEng._descripcion1;
                        Idioma.Descripcion2 = IdiomaVisorEng._descripcion2;
                        Idioma.Categoria = IdiomaVisorEng._categoria;
                        Idioma.Estado = IdiomaVisorEng._estado;
                        Idioma.Marca = IdiomaVisorEng._marca;
                        Idioma.Modelo = IdiomaVisorEng._modelo;
                        Idioma.Ubicaciones = IdiomaVisorEng._ubicaciones;
                        Idioma.Observaciones = IdiomaVisorEng._observaciones;
                        Idioma.Fotos = IdiomaVisorEng._fotos;
                        Idioma.Foto1 = IdiomaVisorEng._foto1;
                        Idioma.Foto2 = IdiomaVisorEng._foto2;
                        Idioma.Foto3 = IdiomaVisorEng._foto3;
                        Idioma.Foto4 = IdiomaVisorEng._foto4;
                        Idioma.Foto5 = IdiomaVisorEng._foto5;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    default:
                        Idioma.Titulo = IdiomaVisorEspa._titulo;
                        Idioma.SelectFiltro = IdiomaVisorEspa._selectFiltro;
                        Idioma.NumActivo = IdiomaVisorEspa._numActivo;
                        Idioma.PlacaActivo = IdiomaVisorEspa._placaActivo;
                        Idioma.Serie = IdiomaVisorEspa._serie;
                        Idioma.Descripcion1 = IdiomaVisorEspa._descripcion1;
                        Idioma.Descripcion2 = IdiomaVisorEspa._descripcion2;
                        Idioma.Categoria = IdiomaVisorEspa._categoria;
                        Idioma.Estado = IdiomaVisorEspa._estado;
                        Idioma.Marca = IdiomaVisorEspa._marca;
                        Idioma.Modelo = IdiomaVisorEspa._modelo;
                        Idioma.Ubicaciones = IdiomaVisorEspa._ubicaciones;
                        Idioma.Observaciones = IdiomaVisorEspa._observaciones;
                        Idioma.Fotos = IdiomaVisorEspa._fotos;
                        Idioma.Foto1 = IdiomaVisorEspa._foto1;
                        Idioma.Foto2 = IdiomaVisorEspa._foto2;
                        Idioma.Foto3 = IdiomaVisorEspa._foto3;
                        Idioma.Foto4 = IdiomaVisorEspa._foto4;
                        Idioma.Foto5 = IdiomaVisorEspa._foto5;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;




                }
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }

        }
    }
}