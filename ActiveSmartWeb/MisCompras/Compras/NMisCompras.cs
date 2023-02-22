using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ActiveSmartWeb.Utilities;

namespace ActiveSmartWeb.MisCompras.Compras
{
    public class NMisCompras
    {

        DBMisCompras dBMisCompras = new DBMisCompras();

        public List<EFechavencimientoPlan> CargarFechaVencimiento(int IdEmpresa)
        {
            try
            {

                return dBMisCompras.CargarFechaVencimiento(IdEmpresa);

            }
            catch (Exception ex)
            {

                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return null;

            }
        }

        public List<EAdicionalesMisCompras> CargarAdicionalesMisCompras(int IdEmpresa)
        {
            try
            {

                return dBMisCompras.CargarAdicionalesMisCompras(IdEmpresa);

            }
            catch (Exception ex)
            {

                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return null;

            }
        }

    }
}