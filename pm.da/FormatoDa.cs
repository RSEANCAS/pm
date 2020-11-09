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
    public class FormatoDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<FormatoBe.Letra> ListarFormatoLetra(int[] codigosLetra, SqlConnection cn)
        {
            List<FormatoBe.Letra> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_formato_letra_masivo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigosLetra", (codigosLetra == null ? null : string.Join(",", codigosLetra)).GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<FormatoBe.Letra>();

                            while (dr.Read())
                            {
                                FormatoBe.Letra item = new FormatoBe.Letra();
                                item.Numero = dr.GetData<int>("Numero");
                                item.FechaGiro = dr.GetData<DateTime>("FechaGiro");
                                item.LugarGiro = dr.GetData<string>("LugarGiro");
                                item.FechaVencimiento = dr.GetData<DateTime>("FechaVencimiento");
                                item.CodigoMoneda = dr.GetData<int>("CodigoMoneda");
                                item.Importe = dr.GetData<decimal>("Importe");
                                item.ImporteEnLetras = dr.GetData<string>("ImporteEnLetras");
                                item.RucCliente = dr.GetData<string>("RucCliente");
                                item.NombresCliente = dr.GetData<string>("NombresCliente");
                                item.DireccionCliente = dr.GetData<string>("DireccionCliente");
                                item.LocalidadCliente = dr.GetData<string>("LocalidadCliente");
                                item.TelefonoCliente = dr.GetData<string>("TelefonoCliente");
                                item.NroDocIdentidadAval = dr.GetData<string>("NroDocIdentidadAval");
                                item.NombresAval = dr.GetData<string>("NombresAval");
                                item.DireccionAval = dr.GetData<string>("DireccionAval");
                                item.LocalidadAval = dr.GetData<string>("LocalidadAval");
                                item.TelefonoAval = dr.GetData<string>("TelefonoAval");

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
