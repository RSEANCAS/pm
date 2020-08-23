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

        public List<MenuBe> BuscarMenu(string nombre, string formulario, bool flagActivo, SqlConnection cn)
        {
            List<MenuBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_menu_buscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombre.GetNullable());
                    cmd.Parameters.AddWithValue("@formulario", formulario.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", flagActivo.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<MenuBe>();

                            while (dr.Read())
                            {
                                MenuBe item = new MenuBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoMenu = dr.GetData<int>("CodigoMenu");
                                item.Nombre = dr.GetData<string>("Nombre");
                                item.Formulario = dr.GetData<string>("Formulario");
                                item.CodigoMenuPadre = dr.GetData<int?>("CodigoMenuPadre");
                                if(item.CodigoMenuPadre != null)
                                {
                                    item.MenuPadre = new MenuBe();
                                    item.MenuPadre.CodigoMenu = dr.GetData<int>("CodigoMenuPadre");
                                    item.MenuPadre.Nombre = dr.GetData<string>("NombreMenuPadre");
                                }
                                item.FlagActivo = dr.GetData<bool>("FlagActivo");

                                resultados.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return resultados;
        }

        public MenuBe ObtenerMenu(int codigoMenu, SqlConnection cn)
        {
            MenuBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_menu_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoMenu", codigoMenu.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new MenuBe();

                            if (dr.Read())
                            {
                                item.CodigoMenu = dr.GetData<int>("CodigoMenu");
                                item.Nombre = dr.GetData<string>("Nombre");
                                item.Formulario = dr.GetData<string>("Formulario");
                                item.CodigoMenuPadre = dr.GetData<int?>("CodigoMenuPadre");
                                item.FlagActivo = dr.GetData<bool>("FlagActivo");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public bool ExisteMenu(string nombre, int? codigoMenu, SqlConnection cn)
        {
            bool existe = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_menu_existe", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombre.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoMenu", codigoMenu.GetNullable());

                    existe = (bool)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return existe;
        }

        public bool GuardarMenu(MenuBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_menu_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoMenu", registro.CodigoMenu.GetNullable());
                    cmd.Parameters.AddWithValue("@nombre", registro.Nombre.GetNullable());
                    cmd.Parameters.AddWithValue("@formulario", registro.Formulario.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoMenuPadre", registro.CodigoMenuPadre.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool CambiarFlagActivoMenu(MenuBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_menu_cambiar_flagactivo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoMenu", registro.CodigoMenu.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", registro.FlagActivo.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

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

        public List<MenuBe> ListarMenuDefaultPorPerfil(int? codigoPerfil, SqlConnection cn)
        {
            List<MenuBe> lista = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_menu_listar_default_x_perfil", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoPerfil", codigoPerfil.GetNullable());

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
                                item.Check = dr.GetData<bool>("Check");

                                lista.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return lista;
        }

        public List<MenuBe> ListarComboMenuPadreMenu(int? codigoMenu, SqlConnection cn)
        {
            List<MenuBe> lista = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_menu_listar_combo_menupadre", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoMenu", codigoMenu.GetNullable());

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
