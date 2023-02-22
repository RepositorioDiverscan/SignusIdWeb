using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;

namespace ActiveSmartWeb.MisCompras.Compras
{
    public class DBMisCompras
    {

        public List<EFechavencimientoPlan> CargarFechaVencimiento(int IdEmpresa)
        {
            List<EFechavencimientoPlan> eFechaVencimiento = new List<EFechavencimientoPlan>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultaVencimientoContrato");
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.Int32, IdEmpresa);
            dbCommand.CommandTimeout = 3600;

            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {

                    eFechaVencimiento.Add(new EFechavencimientoPlan(
                        reader["NombreTipoContrato"].ToString(),
                        Convert.ToDateTime(reader["FechaExpiracion"].ToString())
                    ));
                }
            }
            return eFechaVencimiento;
        }

        public List<EAdicionalesMisCompras> CargarAdicionalesMisCompras(int IdEmpresa)
        {
            List<EAdicionalesMisCompras> eMisCompras = new List<EAdicionalesMisCompras>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultaAdicionalesMisCompras");
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.Int32, IdEmpresa);
            dbCommand.CommandTimeout = 3600;

            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {

                    eMisCompras.Add(new EAdicionalesMisCompras(
                        reader["Nombre"].ToString(),
                        Convert.ToInt32(reader["Total"].ToString()),
                        Convert.ToInt32(reader["Consumido"].ToString()),
                        Convert.ToInt32(reader["IdPaqueteContratado"].ToString()),
                        Convert.ToInt32(reader["Cantidad"].ToString()),
                        Convert.ToDecimal(reader["Costo"].ToString())
                    ));
                }
            }
            return eMisCompras;
        }

    }
}