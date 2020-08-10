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
    public class ProveedorDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<ProveedorBe> BuscarProveedor(string nroDocumentoIdentidad, string nombres, string direccion, int? codigoPais, string correo, string contacto, bool flagActivo, SqlConnection cn)
        {
            List<ProveedorBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_proveedor_buscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nroDocumentoIdentidad", nroDocumentoIdentidad.GetNullable());
                    cmd.Parameters.AddWithValue("@nombres", nombres.GetNullable());
                    cmd.Parameters.AddWithValue("@direccion", direccion.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoPais", codigoPais.GetNullable());
                    cmd.Parameters.AddWithValue("@correo", correo.GetNullable());
                    cmd.Parameters.AddWithValue("@contacto", contacto.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", flagActivo.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<ProveedorBe>();

                            while (dr.Read())
                            {
                                ProveedorBe item = new ProveedorBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoProveedor = dr.GetData<int>("CodigoProveedor");
                                item.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidad");
                                item.TipoDocumentoIdentidad = new TipoDocumentoIdentidadBe();
                                item.TipoDocumentoIdentidad.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidad");
                                item.TipoDocumentoIdentidad.Descripcion = dr.GetData<string>("DescripcionTipoDocumentoIdentidad");
                                item.NroDocumentoIdentidad = dr.GetData<string>("NroDocumentoIdentidad");
                                item.Nombres = dr.GetData<string>("Nombres");
                                item.Direccion = dr.GetData<string>("Direccion");
                                item.CodigoPais = dr.GetData<int>("CodigoPais");
                                item.Pais = new PaisBe();
                                item.Pais.CodigoPais = dr.GetData<int>("CodigoPais");
                                item.Pais.Nombre = dr.GetData<string>("NombrePais");
                                item.Pais.Nacionalidad = dr.GetData<string>("NacionalidadPais");
                                item.Correo = dr.GetData<string>("Correo");
                                item.Telefono = dr.GetData<string>("Telefono");
                                item.Contacto = dr.GetData<string>("Contacto");
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

        public ProveedorBe ObtenerProveedor(int codigoProveedor, SqlConnection cn)
        {
            ProveedorBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_proveedor_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoProveedor", codigoProveedor.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new ProveedorBe();

                            if (dr.Read())
                            {
                                item.CodigoProveedor = dr.GetData<int>("CodigoProveedor");
                                item.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidad");
                                item.NroDocumentoIdentidad = dr.GetData<string>("NroDocumentoIdentidad");
                                item.Nombres = dr.GetData<string>("Nombres");
                                item.Direccion = dr.GetData<string>("Direccion");
                                item.CodigoPais = dr.GetData<int>("CodigoPais");
                                item.Correo = dr.GetData<string>("Correo");
                                item.Telefono = dr.GetData<string>("Telefono");
                                item.Contacto = dr.GetData<string>("Contacto");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public bool ExisteProveedor(string nroDocumentoIdentidad, int? codigoProveedor, SqlConnection cn)
        {
            bool existe = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_proveedor_existe", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nroDocumentoIdentidad", nroDocumentoIdentidad.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoProveedor", codigoProveedor.GetNullable());

                    existe = (bool)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return existe;
        }

        public bool GuardarProveedor(ProveedorBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_proveedor_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoProveedor", registro.CodigoProveedor.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoTipoDocumentoIdentidad", registro.CodigoTipoDocumentoIdentidad.GetNullable());
                    cmd.Parameters.AddWithValue("@nroDocumentoIdentidad", registro.NroDocumentoIdentidad.GetNullable());
                    cmd.Parameters.AddWithValue("@nombres", registro.Nombres.GetNullable());
                    cmd.Parameters.AddWithValue("@direccion", registro.Direccion.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoPais", registro.CodigoPais.GetNullable());
                    cmd.Parameters.AddWithValue("@correo", registro.Correo.GetNullable());
                    cmd.Parameters.AddWithValue("@telefono", registro.Telefono.GetNullable());
                    cmd.Parameters.AddWithValue("@contacto", registro.Contacto.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool CambiarFlagActivoProveedor(ProveedorBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_proveedor_cambiar_flagactivo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoProveedor", registro.CodigoProveedor.GetNullable());
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
