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
    public class ControlBusquedaDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ControlBusquedaBe ObtenerControlBusqueda(string formulario, string control, SqlConnection cn)
        {
            ControlBusquedaBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_controlbusqueda_obtener_x_formulariocontrol", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@formulario", formulario.GetNullable());
                    cmd.Parameters.AddWithValue("@control", control.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new ControlBusquedaBe();

                            if (dr.Read())
                            {
                                item.CodigoControlBusqueda = dr.GetData<int>("CodigoControlBusqueda");
                                item.Formulario = dr.GetData<string>("Formulario");
                                item.Control = dr.GetData<string>("Control");
                                item.FromTables = dr.GetData<string>("FromTables");
                                item.WhereMain = dr.GetData<string>("WhereMain");
                                item.TituloFormulario = dr.GetData<string>("TituloFormulario");
                                item.TipoObjeto = dr.GetData<string>("TipoObjeto");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }
    }
}
