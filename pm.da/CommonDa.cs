using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.da
{
    public class CommonDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<dynamic> BuscarQuery(string table, string columns, string columnsFilter, string where, SqlConnection cn)
        {
            List<dynamic> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_query_buscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@table", table);
                    cmd.Parameters.AddWithValue("@columns", columns);
                    cmd.Parameters.AddWithValue("@columnsFilter", columnsFilter);
                    cmd.Parameters.AddWithValue("@where", where);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<dynamic>();

                            while (dr.Read())
                            {
                                var item = new ExpandoObject() as IDictionary<string, object>;
                                for (int i = 0; i < dr.FieldCount; i++){
                                    string fieldName = dr.GetName(i);
                                    object fieldValue = dr[fieldName];

                                    item.Add(fieldName, fieldValue);
                                }

                                resultados.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return resultados;
        }
    }
}
