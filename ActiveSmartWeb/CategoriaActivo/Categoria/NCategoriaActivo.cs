using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.CategoriaActivo.Categoria
{
    public class NCategoriaActivo
    {
        public readonly ICategoriaActivo _categoriaActivos;
        public NCategoriaActivo(ICategoriaActivo categoriaActivos)
        {
            if (categoriaActivos is null)
                throw new ArgumentException("categoriaActivos", "categoriaActivos is null");
            _categoriaActivos = categoriaActivos;
        }
        public List<ECategoriaActivo> ConsultaCategoriaActivos()
        {
            try
            {
                var CategoriaActivos = _categoriaActivos.ConsultaCategoriaActivos();
                return CategoriaActivos;

            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<ECategoriaActivo>();
                
            }
        }
        public string ConsultaDescCategoriaX(int idCategoria)
        {
            try
            {
                string CategoriaActivos = _categoriaActivos.ConsultaDescCategoriaX(idCategoria);
                return CategoriaActivos;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "Error";

            }
        }
    }
}