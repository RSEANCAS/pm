using pm.be;
using pm.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.da
{
    public class ClienteDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<ClienteBe> BuscarCliente(string nroDocumentoIdentidad, string nombres, string direccion, string correo, string contacto, string areaContacto, bool flagActivo, SqlConnection cn)
        {
            List<ClienteBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_cliente_buscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nroDocumentoIdentidad", nroDocumentoIdentidad.GetNullable());
                    cmd.Parameters.AddWithValue("@nombres", nombres.GetNullable());
                    cmd.Parameters.AddWithValue("@direccion", direccion.GetNullable());
                    cmd.Parameters.AddWithValue("@correo", correo.GetNullable());
                    cmd.Parameters.AddWithValue("@contacto", contacto.GetNullable());
                    cmd.Parameters.AddWithValue("@areaContacto", areaContacto.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", flagActivo.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<ClienteBe>();

                            while (dr.Read())
                            {
                                ClienteBe item = new ClienteBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoCliente = dr.GetData<int>("CodigoCliente");
                                item.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidad");
                                item.TipoDocumentoIdentidad = new TipoDocumentoIdentidadBe();
                                item.TipoDocumentoIdentidad.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidad");
                                item.TipoDocumentoIdentidad.Descripcion = dr.GetData<string>("DescripcionTipoDocumentoIdentidad");
                                item.NroDocumentoIdentidad = dr.GetData<string>("NroDocumentoIdentidad");
                                item.Nombres = dr.GetData<string>("Nombres");
                                item.Direccion = dr.GetData<string>("Direccion");
                                item.Correo = dr.GetData<string>("Correo");
                                item.Telefono = dr.GetData<string>("Telefono");
                                item.CodigoActividadPrincipal = dr.GetData<int?>("CodigoActividadPrincipal");
                                if(item.CodigoActividadPrincipal != null)
                                {
                                    item.ActividadPrincipal = new ActividadBe();
                                    item.ActividadPrincipal.CodigoActividad = dr.GetData<int>("CodigoActividadPrincipal");
                                    item.ActividadPrincipal.Nombre = dr.GetData<string>("NombreActividadPrincipal");
                                    item.ActividadPrincipal.FlagActivo = dr.GetData<bool>("FlagActivoActividadPrincipal");
                                }
                                item.Contacto = dr.GetData<string>("Contacto");
                                item.AreaContacto = dr.GetData<string>("AreaContacto");
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

        public ClienteBe ObtenerCliente(int codigoCliente, SqlConnection cn)
        {
            ClienteBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_cliente_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoCliente", codigoCliente.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new ClienteBe();

                            if (dr.Read())
                            {
                                item.CodigoCliente = dr.GetData<int>("CodigoCliente");
                                item.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidad");
                                item.NroDocumentoIdentidad = dr.GetData<string>("NroDocumentoIdentidad");
                                item.Nombres = dr.GetData<string>("Nombres");
                                item.Direccion = dr.GetData<string>("Direccion");
                                item.CodigoDistrito = dr.GetData<int>("CodigoDistrito");
                                item.Distrito = new DistritoBe();
                                item.Distrito.CodigoDistrito = dr.GetData<int>("CodigoDistrito");
                                item.Distrito.CodigoUbigeo = dr.GetData<string>("CodigoUbigeoDistrito");
                                item.Distrito.Nombre = dr.GetData<string>("NombreDistrito");
                                item.Distrito.CodigoProvincia = dr.GetData<int>("CodigoProvincia");
                                item.Distrito.Provincia = new ProvinciaBe();
                                item.Distrito.Provincia.CodigoProvincia = dr.GetData<int>("CodigoProvincia");
                                item.Distrito.Provincia.CodigoUbigeo = dr.GetData<string>("CodigoUbigeoProvincia");
                                item.Distrito.Provincia.Nombre = dr.GetData<string>("NombreProvincia");
                                item.Distrito.Provincia.CodigoDepartamento = dr.GetData<int>("CodigoDepartamento");
                                item.Distrito.Provincia.Departamento = new DepartamentoBe();
                                item.Distrito.Provincia.Departamento.CodigoDepartamento = dr.GetData<int>("CodigoDepartamento");
                                item.Distrito.Provincia.Departamento.CodigoUbigeo = dr.GetData<string>("CodigoUbigeoDepartamento");
                                item.Distrito.Provincia.Departamento.Nombre = dr.GetData<string>("NombreDepartamento");
                                item.Distrito.Provincia.Departamento.CodigoPais = dr.GetData<int>("CodigoPais");
                                item.Distrito.Provincia.Departamento.Pais = new PaisBe();
                                item.Distrito.Provincia.Departamento.Pais.CodigoPais = dr.GetData<int>("CodigoPais");
                                item.Distrito.Provincia.Departamento.Pais.Nombre = dr.GetData<string>("NombrePais");
                                item.Correo = dr.GetData<string>("Correo");
                                item.Telefono = dr.GetData<string>("Telefono");
                                item.CodigoActividadPrincipal = dr.GetData<int?>("CodigoActividadPrincipal");
                                item.Contacto = dr.GetData<string>("Contacto");
                                item.AreaContacto = dr.GetData<string>("AreaContacto");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public bool ExisteCliente(string nroDocumentoIdentidad, int? codigoCliente, SqlConnection cn)
        {
            bool existe = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_cliente_existe", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nroDocumentoIdentidad", nroDocumentoIdentidad.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoCliente", codigoCliente.GetNullable());

                    existe = (bool)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return existe;
        }

        public bool GuardarCliente(ClienteBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_cliente_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoCliente", registro.CodigoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoTipoDocumentoIdentidad", registro.CodigoTipoDocumentoIdentidad.GetNullable());
                    cmd.Parameters.AddWithValue("@nroDocumentoIdentidad", registro.NroDocumentoIdentidad.GetNullable());
                    cmd.Parameters.AddWithValue("@nombres", registro.Nombres.GetNullable());
                    cmd.Parameters.AddWithValue("@direccion", registro.Direccion.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoDistrito", registro.CodigoDistrito.GetNullable());
                    cmd.Parameters.AddWithValue("@correo", registro.Correo.GetNullable());
                    cmd.Parameters.AddWithValue("@telefono", registro.Telefono.GetNullable());
                    cmd.Parameters.AddWithValue("@contacto", registro.Contacto.GetNullable());
                    cmd.Parameters.AddWithValue("@areaContacto", registro.AreaContacto.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoActividadPrincipal", registro.CodigoActividadPrincipal.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool CambiarFlagActivoCliente(ClienteBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_cliente_cambiar_flagactivo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoCliente", registro.CodigoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", registro.FlagActivo.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }
    }
}
