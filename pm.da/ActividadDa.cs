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
    public class ActividadDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<ActividadBe> ListarComboActividad(SqlConnection cn)
        {
            List<ActividadBe> lista = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_actividad_listar_combo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            lista = new List<ActividadBe>();

                            while (dr.Read())
                            {
                                ActividadBe item = new ActividadBe();
                                item.CodigoActividad = dr.GetData<int>("CodigoActividad");
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
