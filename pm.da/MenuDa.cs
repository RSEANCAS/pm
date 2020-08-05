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
    public class MenuDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<MenuBe> ListarMenuPorPerfil(int codigoPerfil, SqlConnection cn)
        {
            List<MenuBe> lista = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_menu_listar_x_perfil", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoPerfil", codigoPerfil);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            lista = new List<MenuBe>();

                            while (dr.Read())
                            {
                                MenuBe item = new MenuBe();
                                item.CodigoMenu = dr.GetData<int>("CodigoMenu");
                                item.Nombre = dr.GetData<string>("Nombre");
                                item.Formulario = dr.GetData<string>("Formulario");
                                item.CodigoMenuPadre = dr.GetData<int?>("CodigoMenuPadre");

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
