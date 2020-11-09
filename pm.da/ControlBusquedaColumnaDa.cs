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
    public class ControlBusquedaColumnaDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<ControlBusquedaColumnaBe> ListarControlBusquedaColumna(int codigoControlBusqueda, SqlConnection cn)
        {
            List<ControlBusquedaColumnaBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_controlbusquedacolumna_listar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoControlBusqueda", codigoControlBusqueda.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<ControlBusquedaColumnaBe>();

                            while (dr.Read())
                            {
                                ControlBusquedaColumnaBe item = new ControlBusquedaColumnaBe();
                                item.CodigoControlBusqueda = dr.GetData<int>("CodigoControlBusqueda");
                                item.CodigoControlBusquedaColumna = dr.GetData<int>("CodigoControlBusquedaColumna");
                                item.CampoBD = dr.GetData<string>("CampoBD");
                                item.NombreAtributo = dr.GetData<string>("NombreAtributo");
                                item.Titulo = dr.GetData<string>("Titulo");
                                item.Formato = dr.GetData<string>("Formato");
                                item.EsVisible = dr.GetData<bool>("EsVisible");
                                item.TipoColumna = dr.GetData<string>("TipoColumna");
                                item.EsFiltro = dr.GetData<bool>("EsFiltro");
                                item.Ancho = dr.GetData<int>("Ancho");

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
