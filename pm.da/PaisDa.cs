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
    public class PaisDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<PaisBe> ListarComboPais(SqlConnection cn)
        {
            List<PaisBe> lista = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_pais_listar_combo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            lista = new List<PaisBe>();

                            while (dr.Read())
                            {
                                PaisBe item = new PaisBe();
                                item.CodigoPais = dr.GetData<int>("CodigoPais");
                                item.Nombre = dr.GetData<string>("Nombre");
                                item.Nacionalidad = dr.GetData<string>("Nacionalidad");

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
