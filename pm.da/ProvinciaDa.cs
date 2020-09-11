﻿using pm.be;
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
    public class ProvinciaDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<ProvinciaBe> ListarComboProvincia(SqlConnection cn)
        {
            List<ProvinciaBe> lista = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_provincia_listar_combo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            lista = new List<ProvinciaBe>();

                            while (dr.Read())
                            {
                                ProvinciaBe item = new ProvinciaBe();
                                item.CodigoProvincia = dr.GetData<int>("CodigoProvincia");
                                item.CodigoDepartamento = dr.GetData<int>("CodigoDepartamento");
                                item.CodigoUbigeo = dr.GetData<string>("CodigoUbigeo");
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
