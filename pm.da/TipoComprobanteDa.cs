using pm.be;
using pm.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.da
{
    public class TipoComprobanteDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<TipoComprobanteBe> ListarComboTipoComprobante(SqlConnection cn)
        {
            List<TipoComprobanteBe> lista = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_tipocomprobante_listar_combo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            lista = new List<TipoComprobanteBe>();

                            while (dr.Read())
                            {
                                TipoComprobanteBe item = new TipoComprobanteBe();
                                item.CodigoTipoComprobante = dr.GetData<int>("CodigoTipoComprobante");
                                item.Nombre = dr.GetData<string>("Nombre");

                                lista.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return lista;
        }
    }
}
