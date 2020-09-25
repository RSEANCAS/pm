using pm.be;
using pm.bl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static pm.enums.Enums;

namespace pm.app
{
    public partial class FrmMantenimientoGuiaRemision : Form
    {
        int? codigoGuiaRemision;

        int? codigoCliente, codigoDistritoCliente;
        string nombrePaisCliente, nombreDepartamentoCliente, nombreProvinciaCliente, nombreDistritoCliente;
        string nroDocumentoIdentidadCliente;

        int? codigoTransportista, codigoDistritoTransportista;
        string nombrePaisTransportista, nombreDepartamentoTransportista, nombreProvinciaTransportista, nombreDistritoTransportista;
        string nroDocumentoIdentidadTransportista;

        List<GuiaRemisionDetalleBe> listaDetalleInicial = new List<GuiaRemisionDetalleBe>();
        List<GuiaRemisionDetalleBe> listaDetalle = new List<GuiaRemisionDetalleBe>();

        GuiaRemisionBl guiaRemisionBl = new GuiaRemisionBl();
        TipoComprobanteBl tipoComprobanteBl = new TipoComprobanteBl();
        SerieBl serieBl = new SerieBl();
        TipoDocumentoIdentidadBl tipoDocumentoIdentidadBl = new TipoDocumentoIdentidadBl();
        MotivoTrasladoBl motivoTrasladoBl = new MotivoTrasladoBl();
        ClienteBl clienteBl = new ClienteBl();

        ProveedorBl proveedorBl = new ProveedorBl();

        public FrmMantenimientoGuiaRemision(int? codigoGuiaRemision = null)
        {
            InitializeComponent();
            this.codigoGuiaRemision = codigoGuiaRemision;
        }

        private void FrmMantenimientoGuiaRemision_Load(object sender, EventArgs e)
        {
            Text = !codigoGuiaRemision.HasValue ? "Nueva Guía de Remisión" : "Modificar Guía de Remisión";
            dtpFechaHoraEmision_ValueChanged(dtpFechaHoraEmision, new EventArgs());
            ListarCombos();
            dgvDetalle.AutoGenerateColumns = false;
            if (codigoGuiaRemision.HasValue)
            {
                CargarGuiaRemision();
            }
            HabilitarModificarYEliminar();
        }

        void CargarGuiaRemision()
        {
            GuiaRemisionBe item = guiaRemisionBl.ObtenerGuiaRemision(codigoGuiaRemision.Value, true);

            dtpFechaHoraEmision.Value = item.FechaHoraEmision;
            cbbCodigoTipoComprobante.SelectedValue = item.CodigoTipoComprobante;
            cbbCodigoSerie.SelectedValue = item.CodigoSerie;
            txtNroComprobante.Text = item.NroComprobante.ToString("00000000");
            dtpFechaHoraTraslado.MinDate = new DateTime(item.FechaHoraEmision.Year, item.FechaHoraEmision.Month, item.FechaHoraEmision.Day);
            dtpFechaHoraTraslado.Value = item.FechaHoraTraslado;

            codigoCliente = item.CodigoCliente;
            CargarCliente(codigoCliente);

            codigoTransportista = item.CodigoTransportista;
            CargarTransportista(codigoTransportista);

            txtMarcaVehiculoTransportista.Text = item.MarcaVehiculoTransportista;
            txtPlacaVehiculoTransportista.Text = item.PlacaVehiculoTransportista;
            txtLicenciaConducirTransportista.Text = item.LicenciaConducirTransportista;
            cbbCodigoMotivoTraslado.SelectedValue = item.CodigoMotivoTraslado;

            listaDetalleInicial = item.ListaGuiaRemisionDetalle;
            listaDetalle = item.ListaGuiaRemisionDetalle;
            ListarGuiaRemisionDetalle();
        }

        void ListarCombos()
        {
            ListarComboTipoComprobante();
            ListarComboSerie();
            ListarComboTipoDocumentoIdentidad();
            ListarComboMotivoTraslado();
        }

        void ListarComboTipoComprobante()
        {
            List<TipoComprobanteBe> listaCombo = tipoComprobanteBl.ListarComboTipoComprobante();
            listaCombo = listaCombo ?? new List<TipoComprobanteBe>();
            listaCombo = listaCombo.Where(x => (new int[] { (int)TipoComprobante.GuiaRemisionRemitente, (int)TipoComprobante.GuiaRemisionTransportista }).Contains(x.CodigoTipoComprobante)).ToList();
            listaCombo.Insert(0, new TipoComprobanteBe { CodigoTipoComprobante = -1, Nombre = "[Seleccione...]" });

            cbbCodigoTipoComprobante.DataSource = null;
            cbbCodigoTipoComprobante.DataSource = listaCombo;
        }

        void ListarComboSerie()
        {
            int codigoTipoComprobante = (int)cbbCodigoTipoComprobante.SelectedValue;
            List<SerieBe> listaCombo = serieBl.ListarComboSerie(codigoTipoComprobante);
            listaCombo = listaCombo ?? new List<SerieBe>();
            listaCombo.Insert(0, new SerieBe { CodigoSerie = -1, Serial = "[Seleccione...]" });

            cbbCodigoSerie.DataSource = null;
            cbbCodigoSerie.DataSource = listaCombo;
        }

        void ListarComboTipoDocumentoIdentidad()
        {
            List<TipoDocumentoIdentidadBe> listaCombo = tipoDocumentoIdentidadBl.ListarComboTipoDocumentoIdentidad();
            listaCombo = listaCombo ?? new List<TipoDocumentoIdentidadBe>();
            listaCombo.Insert(0, new TipoDocumentoIdentidadBe { CodigoTipoDocumentoIdentidad = -1, Descripcion = "[Seleccione...]" });

            cbbCodigoTipoDocumentoIdentidadCliente.DataSource = null;
            cbbCodigoTipoDocumentoIdentidadCliente.DataSource = listaCombo.Select(x => x).ToList();

            cbbCodigoTipoDocumentoIdentidadTransportista.DataSource = null;
            cbbCodigoTipoDocumentoIdentidadTransportista.DataSource = listaCombo.Select(x => x).ToList();
        }

        void ListarComboMotivoTraslado()
        {
            List<MotivoTrasladoBe> listaCombo = motivoTrasladoBl.ListarComboMotivoTraslado();
            listaCombo = listaCombo ?? new List<MotivoTrasladoBe>();
            listaCombo.Insert(0, new MotivoTrasladoBe { CodigoMotivoTraslado = -1, Descripcion = "[Seleccione...]" });

            cbbCodigoMotivoTraslado.DataSource = null;
            cbbCodigoMotivoTraslado.DataSource = listaCombo;
        }

        private void cbbCodigoTipoComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarComboSerie();
        }

        private void dtpFechaHoraEmision_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaHoraTraslado.MinDate = dtpFechaHoraEmision.Value;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (nroDocumentoIdentidadCliente == txtNroDocumentoIdentidadCliente.Text.Trim()) return;
            if (txtNroDocumentoIdentidadCliente.Text.Trim() == "") CargarCliente(null);
            List<dynamic> listaColumnas = new List<dynamic>();
            listaColumnas.Add(new { Campo = "CodigoCliente", NombreColumna = "CodigoCliente", EsVisible = false, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = false });
            listaColumnas.Add(new { Campo = "NroDocumentoIdentidad", NombreColumna = "N° Doc. Identidad", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });
            listaColumnas.Add(new { Campo = "Nombres", NombreColumna = "Nombres", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });
            listaColumnas.Add(new { Campo = "Correo", NombreColumna = "Correo", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });

            string table = "dbo.Cliente";
            DataGridViewColumn[] columns = listaColumnas.Select(x => {
                DataGridViewColumn column = x.TipoColumna;
                column.Name = $"dgvResultados_{x.Campo}";
                column.DataPropertyName = x.Campo;
                column.HeaderText = x.NombreColumna;
                column.Visible = x.EsVisible;
                return column;
            }).ToArray();
            string[] columnsFilter = listaColumnas.Where(x => x.EsFiltro).Select(x => (string)x.Campo).ToArray();

            FrmBusquedaSeleccionarRegistro frm = new FrmBusquedaSeleccionarRegistro("Buscar Cliente", table, columns.Cast<DataGridViewColumn>().ToArray(), columnsFilter, typeof(ClienteBe), txtNroDocumentoIdentidadCliente.Text.Trim());
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            CargarCliente(null);
            if (dr == DialogResult.OK)
            {
                dynamic resultado = frm.Resultado;
                CargarCliente(resultado.CodigoCliente);
            }
        }

        private void btnBuscarTransportista_Click(object sender, EventArgs e)
        {
            if (nroDocumentoIdentidadTransportista == txtNroDocumentoIdentidadTransportista.Text.Trim()) return;
            if (txtNroDocumentoIdentidadTransportista.Text.Trim() == "") CargarTransportista(null);
            List<dynamic> listaColumnas = new List<dynamic>();
            listaColumnas.Add(new { Campo = "CodigoProveedor", NombreColumna = "CodigoTransportista", EsVisible = false, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = false });
            listaColumnas.Add(new { Campo = "NroDocumentoIdentidad", NombreColumna = "N° Doc. Identidad", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });
            listaColumnas.Add(new { Campo = "Nombres", NombreColumna = "Nombres", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });
            listaColumnas.Add(new { Campo = "Correo", NombreColumna = "Correo", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });

            string table = "dbo.Proveedor";
            DataGridViewColumn[] columns = listaColumnas.Select(x => {
                DataGridViewColumn column = x.TipoColumna;
                column.Name = $"dgvResultados_{x.Campo}";
                column.DataPropertyName = x.Campo;
                column.HeaderText = x.NombreColumna;
                column.Visible = x.EsVisible;
                return column;
            }).ToArray();
            string[] columnsFilter = listaColumnas.Where(x => x.EsFiltro).Select(x => (string)x.Campo).ToArray();

            FrmBusquedaSeleccionarRegistro frm = new FrmBusquedaSeleccionarRegistro("Buscar Transportista", table, columns.Cast<DataGridViewColumn>().ToArray(), columnsFilter, typeof(ProveedorBe), txtNroDocumentoIdentidadTransportista.Text.Trim());
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            CargarTransportista(null);
            if (dr == DialogResult.OK)
            {
                dynamic resultado = frm.Resultado;
                CargarTransportista(resultado.CodigoProveedor);
            }
        }

        void CargarCliente(int? codigoCliente)
        {
            ClienteBe cliente = codigoCliente == null ? null : clienteBl.ObtenerCliente(codigoCliente.Value);
            if (cliente != null)
            {
                this.codigoCliente = cliente.CodigoCliente;
                this.nroDocumentoIdentidadCliente = cliente.NroDocumentoIdentidad;
                cbbCodigoTipoDocumentoIdentidadCliente.SelectedValue = cliente.CodigoTipoDocumentoIdentidad;
                txtNroDocumentoIdentidadCliente.Text = cliente.NroDocumentoIdentidad;
                txtNombresCliente.Text = cliente.Nombres;
                txtCorreoCliente.Text = cliente.Correo;
                txtDireccionCliente.Text = cliente.Direccion;
                if (cliente.Distrito != null)
                {
                    codigoDistritoCliente = cliente.CodigoDistrito;
                    nombrePaisCliente = cliente.Distrito.Provincia.Departamento.Pais.ToString();
                    nombreDepartamentoCliente = cliente.Distrito.Provincia.Departamento.ToString();
                    nombreProvinciaCliente = cliente.Distrito.Provincia.ToString();
                    nombreDistritoCliente = cliente.Distrito.ToString();
                    txtUbicacionCliente.Text = $"{cliente.Distrito.Provincia.Departamento.Pais} - {cliente.Distrito.Provincia.Departamento} - {cliente.Distrito.Provincia} - {cliente.Distrito}";
                }
            }
            else
            {
                this.codigoCliente = null;
                this.nroDocumentoIdentidadCliente = null;
                txtNroDocumentoIdentidadCliente.Text = "";
                txtNombresCliente.Text = "";
            }
        }

        void CargarTransportista(int? codigoTransportista)
        {
            ProveedorBe transportista = codigoTransportista == null ? null : proveedorBl.ObtenerProveedor(codigoTransportista.Value);
            if (transportista != null)
            {
                this.codigoTransportista = transportista.CodigoProveedor;
                this.nroDocumentoIdentidadTransportista = transportista.NroDocumentoIdentidad;
                cbbCodigoTipoDocumentoIdentidadTransportista.SelectedValue = transportista.CodigoTipoDocumentoIdentidad;
                txtNroDocumentoIdentidadTransportista.Text = transportista.NroDocumentoIdentidad;
                txtNombresTransportista.Text = transportista.Nombres;
                txtCorreoTransportista.Text = transportista.Correo;
                txtDireccionTransportista.Text = transportista.Direccion;
                if (transportista.Distrito != null)
                {
                    codigoDistritoTransportista = transportista.CodigoDistrito;
                    nombrePaisTransportista = transportista.Distrito.Provincia.Departamento.Pais.ToString();
                    nombreDepartamentoTransportista = transportista.Distrito.Provincia.Departamento.ToString();
                    nombreProvinciaTransportista = transportista.Distrito.Provincia.ToString();
                    nombreDistritoTransportista = transportista.Distrito.ToString();
                    txtUbicacionTransportista.Text = $"{transportista.Distrito.Provincia.Departamento.Pais} - {transportista.Distrito.Provincia.Departamento} - {transportista.Distrito.Provincia} - {transportista.Distrito}";
                }
            }
            else
            {
                this.codigoTransportista = null;
                this.nroDocumentoIdentidadTransportista = null;
                txtNroDocumentoIdentidadTransportista.Text = "";
                txtNombresTransportista.Text = "";
            }
        }

        void ListarGuiaRemisionDetalle()
        {
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = listaDetalle;
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            FrmMantenimientoGuiaRemisionDetalle frm = new FrmMantenimientoGuiaRemisionDetalle();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            frm.ListaDetalleInicial = this.listaDetalleInicial;
            frm.ListaDetalleActual = this.listaDetalle;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                frm.Detalle.CodigoGuiaRemisionDetalle = GenerarCodigoGuiaRemisionDetalleTemporal(frm.Detalle.CodigoProductoIndividual);
                listaDetalle.Add(frm.Detalle);
                listaDetalle = listaDetalle.Select((x, i) => { x.Fila = i + 1; return x; }).ToList();
                ListarGuiaRemisionDetalle();
            }
        }

        private void btnModificarDetalle_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvDetalle.CurrentRow.Index;

            var item = (GuiaRemisionDetalleBe)dgvDetalle.Rows[rowIndex].DataBoundItem;
            int indexData = listaDetalle.IndexOf(item);

            FrmMantenimientoGuiaRemisionDetalle frm = new FrmMantenimientoGuiaRemisionDetalle(item);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            frm.ListaDetalleInicial = this.listaDetalleInicial;
            frm.ListaDetalleActual = this.listaDetalle;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                listaDetalle[indexData] = frm.Detalle;
                //listaDetalle = listaDetalle.Select((x, i) => { x.Fila = i + 1; return x; }).ToList();
                ListarGuiaRemisionDetalle();
            }
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvDetalle.CurrentRow.Index;

            var item = (GuiaRemisionDetalleBe)dgvDetalle.Rows[rowIndex].DataBoundItem;
            int indexData = listaDetalle.IndexOf(item);

            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                listaDetalle.RemoveAt(indexData);
                ListarGuiaRemisionDetalle();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            GuiaRemisionBe registro = new GuiaRemisionBe();

            if (codigoGuiaRemision.HasValue) registro.CodigoGuiaRemision = codigoGuiaRemision.Value;
            registro.FechaHoraEmision = dtpFechaHoraEmision.Value;
            registro.CodigoTipoComprobante = (int)cbbCodigoTipoComprobante.SelectedValue;
            registro.CodigoSerie = (int)cbbCodigoSerie.SelectedValue;
            registro.NroComprobante = int.Parse(string.IsNullOrEmpty(txtNroComprobante.Text.Trim()) ? "0" : txtNroComprobante.Text.Trim());
            registro.FechaHoraTraslado = dtpFechaHoraTraslado.Value;
            registro.CodigoCliente = codigoCliente.Value;
            registro.DireccionCliente = txtDireccionCliente.Text.Trim();
            registro.NombrePaisCliente = nombrePaisCliente;
            registro.NombreDepartamentoCliente = nombreDepartamentoCliente;
            registro.NombreProvinciaCliente = nombreProvinciaCliente;
            registro.NombreDistritoCliente = nombreDistritoCliente;
            registro.CodigoDistritoCliente = codigoDistritoCliente.Value;
            registro.CodigoMotivoTraslado = (int)cbbCodigoMotivoTraslado.SelectedValue;
            registro.CodigoTransportista = codigoTransportista.Value;
            registro.DireccionTransportista = txtDireccionTransportista.Text.Trim();
            registro.NombrePaisTransportista = nombrePaisTransportista;
            registro.NombreDepartamentoTransportista = nombreDepartamentoTransportista;
            registro.NombreProvinciaTransportista = nombreProvinciaTransportista;
            registro.NombreDistritoTransportista = nombreDistritoTransportista;
            registro.CodigoDistritoTransportista = codigoDistritoTransportista.Value;
            registro.MarcaVehiculoTransportista = txtMarcaVehiculoTransportista.Text.Trim();
            registro.PlacaVehiculoTransportista = txtPlacaVehiculoTransportista.Text.Trim();
            registro.LicenciaConducirTransportista = txtLicenciaConducirTransportista.Text.Trim();
            registro.ListaGuiaRemisionDetalle = listaDetalle;
            registro.ListaGuiaRemisionDetalleEliminar = listaDetalleInicial == null ? null : listaDetalleInicial.Where(x => listaDetalle.Count(y => y.CodigoGuiaRemisionDetalle == x.CodigoGuiaRemisionDetalle) == 0).Select(x => x.CodigoGuiaRemisionDetalle).ToArray();

            bool seGuardoRegistro = guiaRemisionBl.GuardarGuiaRemision(registro);

            if (seGuardoRegistro)
            {
                DialogResult = MessageBox.Show("¡El registro se guardó correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuardarEmitir_Click(object sender, EventArgs e)
        {

        }

        void LimpiarErrores()
        {
            lblErrorFechaHoraEmision.Text = "";
            lblErrorCodigoTipoComprobante.Text = "";
            lblErrorCodigoSerie.Text = "";
            lblErrorNroComprobante.Text = "";
            lblErrorFechaHoraTraslado.Text = "";
            lblErrorCliente.Text = "";
            lblErrorDetalle.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (cbbCodigoTipoComprobante.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoTipoComprobante.Text = "Debe seleccionar un tipo comprobante";
                SetToolTipError(lblErrorCodigoTipoComprobante);
            }

            if (cbbCodigoSerie.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoSerie.Text = "Debe seleccionar una serie";
                SetToolTipError(lblErrorCodigoSerie);
            }

            if (codigoCliente == null)
            {
                estaValidado = false;
                lblErrorCliente.Text = "Debe seleccionar cliente";
                SetToolTipError(lblErrorCliente);
            }

            if ((listaDetalle ?? new List<GuiaRemisionDetalleBe>()).Count == 0)
            {
                estaValidado = false;
                lblErrorDetalle.Text = "No tiene registros de detalle";
                SetToolTipError(lblErrorDetalle);
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltGuiaRemision.SetToolTip(label, label.Text);
        }

        private void dgvDetalle_SelectionChanged(object sender, EventArgs e)
        {
            HabilitarModificarYEliminar();
        }

        void HabilitarModificarYEliminar()
        {
            bool habilitarEditarYEliminar = dgvDetalle.CurrentRow == null ? false : dgvDetalle.CurrentRow.Index != 1;

            btnModificarDetalle.Enabled = habilitarEditarYEliminar;
            btnEliminarDetalle.Enabled = habilitarEditarYEliminar;
        }

        int GenerarCodigoGuiaRemisionDetalleTemporal(int codigoProductoIndividual)
        {
            int codigoGuiaRemisionDetalle = 0;
            listaDetalleInicial = listaDetalleInicial ?? new List<GuiaRemisionDetalleBe>();
            var registro = listaDetalleInicial.FirstOrDefault(x => x.CodigoProductoIndividual == codigoProductoIndividual);
            listaDetalle = listaDetalle ?? new List<GuiaRemisionDetalleBe>();
            if (registro == null) codigoGuiaRemisionDetalle = listaDetalle.Select(x => x.CodigoGuiaRemisionDetalle).DefaultIfEmpty().Min() - 1;
            else codigoGuiaRemisionDetalle = registro.CodigoGuiaRemisionDetalle;
            return codigoGuiaRemisionDetalle;
        }
    }
}
