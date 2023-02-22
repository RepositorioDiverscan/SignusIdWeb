using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.CategoriaActivo.Categoria
{
    public interface ICategoriaActivo
    {
        List<ECategoriaActivo> ConsultaCategoriaActivos();
        string ConsultaDescCategoriaX(int id);
    }
}