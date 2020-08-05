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
    public class PersonalDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PersonalBe ObtenerPersonal(int codigoPersonal, SqlConnection cn)
        {
            PersonalBe personal = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_personal_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoPersonal", codigoPersonal);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            personal = new PersonalBe();
                            if (dr.Read())
                            {
                                personal.CodigoPersonal = dr.GetData<int>("CodigoPersonal");
                                personal.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidad");
                                personal.NroDocumentoIdentidad = dr.GetData<string>("NroDocumentoIdentidad");
                                personal.Nombres = dr.GetData<string>("Nombres");
                                personal.Correo = dr.GetData<string>("Correo");
                                personal.CodigoArea = dr.GetData<int>("CodigoArea");
                                personal.FlagActivo = dr.GetData<bool>("FlagActivo");
                                personal.Estado = dr.GetData<int>("Estado");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return personal;
        }
    }
}
