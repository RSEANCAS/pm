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
    public class TipoDocumentoIdentidadDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<TipoDocumentoIdentidadBe> ListarComboTipoDocumentoIdentidad(SqlConnection cn)
        {
            List<TipoDocumentoIdentidadBe> lista = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_tipodocumentoidentidad_listar_combo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            lista = new List<TipoDocumentoIdentidadBe>();

                            while (dr.Read())
                            {
                                TipoDocumentoIdentidadBe item = new TipoDocumentoIdentidadBe();
                                item.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidad");
                                item.Descripcion = dr.GetData<string>("Descripcion");
                                item.CantidadCaracteres = dr.GetData<int>("CantidadCaracteres");

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
