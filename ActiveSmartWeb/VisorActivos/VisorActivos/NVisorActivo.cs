using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.VisorActivos.VisorActivos
{
    public class NVisorActivo
    {
        public readonly IVisorActivo _activosA;
        public NVisorActivo(IVisorActivo activos)
        {
            if (activos is null)
            {
                throw new ArgumentNullException("activosA", "activos is null");
            }
            _activosA = activos;
        }

        public List<EVisorActivo> ObtenerActivoPorNumero(string numActivo, int idPerfilEmpresa)
        {
            try
            {
                var Activo = _activosA.ObtenerActivoPorNumero(numActivo, idPerfilEmpresa);
                return Activo;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EVisorActivo>();

            }
        }
        public List<EVisorActivo> ObtenerActivoPorPlaca(string numPlaca, int idPerfilEmpresa)
        {
            try
            {
                var ActivoPlac = _activosA.ObtenerActivoPorPlaca(numPlaca, idPerfilEmpresa);
                return ActivoPlac;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EVisorActivo>();

            }
        }


        public List<string> ObtenerFotosActivos(string numeroActivo)
        {
          
            try
            {
                var resultado = APIVisorImagenes.ObtenerImagenesAsync(numeroActivo);
                return resultado.Result;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<string>();

            }


        }


        public List<string> ObtenerFotosActivosPRUEBA(string numeroActivo)
        {

            try
            {
                List<string> imagenesPrueba = new List<string>();

                imagenesPrueba.Add("https://www.tooltyp.com/wp-content/uploads/2014/10/1900x920-8-beneficios-de-usar-imagenes-en-nuestros-sitios-web.jpg");
                imagenesPrueba.Add("https://estaticos.muyinteresante.es/media/cache/1140x_thumb/uploads/images/article/60780a5c5cafe8289b20e8f0/1-leon-rugido_0.jpg");
                imagenesPrueba.Add("https://static.onecms.io/wp-content/uploads/sites/28/2021/06/01/costa-rica-arenal-volcano-COSTARICATG0621.jpg");
                imagenesPrueba.Add("https://img2.storyblok.com/f/89778/391x292/376f0af810/cr_00_00_2_m.png");
                imagenesPrueba.Add("../images/Null-Image.jpg");

                return imagenesPrueba;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<string>();

            }


        }
    }
}