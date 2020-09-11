using pm.be;
using pm.bl;
using pm.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pm.app
{
    public partial class FrmMantenimientoUsuario : Form
    {
        int? codigoUsuario;
        int? codigoPersonal;
        string nroDocumentoIdentidad;

        UsuarioBl usuarioBl = new UsuarioBl();
        PerfilBl perfilBl = new PerfilBl();
        PersonalBl personalBl = new PersonalBl();

        public FrmMantenimientoUsuario(int? codigoUsuario = null)
        {
            InitializeComponent();
            this.codigoUsuario = codigoUsuario;
        }

        private void FrmMantenimientoUsuario_Load(object sender, EventArgs e)
        {
            Text = !codigoUsuario.HasValue ? "Nuevo Usuario" : "Modificar Usuario";
            if (codigoUsuario.HasValue)
            {
                CargarUsuario();
            }
            else
            {
                CargarListaPerfil();
            }
        }

        void CargarUsuario()
        {
            UsuarioBe item = usuarioBl.ObtenerUsuario(codigoUsuario.Value);
            txtNombre.Text = item.Nombre;
            CargarListaPerfil();
            CargarPersonal(item.CodigoPersonal);
            txtContraseña.ReadOnly = codigoPersonal != null;
        }

        void CargarListaPerfil()
        {
            List<PerfilBe> listaPerfil = perfilBl.ListarPerfilDefaultPorUsuario(codigoUsuario);

            CargarCheckBoxTreeView(listaPerfil);

        }

        void CargarCheckBoxTreeView(List<PerfilBe> listaPerfil)
        {
            if (listaPerfil != null)
            {
                List<TreeNode> lista = ListarCheckBoxTreeView(listaPerfil);
                tvwPerfil.Nodes.AddRange(lista.ToArray());
            }
        }

        List<TreeNode> ListarCheckBoxTreeView(List<PerfilBe> listaPerfil)
        {
            List<TreeNode> lista = null;
            if (listaPerfil != null)
            {
                foreach (PerfilBe item in listaPerfil)
                {
                    lista = lista ?? new List<TreeNode>();

                    TreeNode treeNode = new TreeNode(item.Nombre);
                    treeNode.Checked = item.Check;
                    treeNode.Tag = item.CodigoPerfil;

                    lista.Add(treeNode);
                }
            }

            return lista;
        }

        private void btnBuscarPersonal_Click(object sender, EventArgs e)
        {
            if (nroDocumentoIdentidad == txtNroDocIdentidadPersonal.Text.Trim()) return;
            List<dynamic> listaColumnas = new List<dynamic>();
            listaColumnas.Add(new { Campo = "CodigoPersonal", NombreColumna = "CodigoPersonal", EsVisible = false, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = false });
            listaColumnas.Add(new { Campo = "NroDocumentoIdentidad", NombreColumna = "N° Doc. Identidad", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });
            listaColumnas.Add(new { Campo = "Nombres", NombreColumna = "Nombres", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });
            listaColumnas.Add(new { Campo = "Correo", NombreColumna = "Correo", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });

            string table = "dbo.Personal";
            DataGridViewColumn[] columns = listaColumnas.Select(x => {
                DataGridViewColumn column = x.TipoColumna;
                column.Name = $"dgvResultados_{x.Campo}";
                column.DataPropertyName = x.Campo;
                column.HeaderText = x.NombreColumna;
                column.Visible = x.EsVisible;
                return column;
            }).ToArray();
            string[] columnsFilter = listaColumnas.Where(x => x.EsFiltro).Select(x => (string)x.Campo).ToArray();

            FrmBusquedaSeleccionarRegistro frm = new FrmBusquedaSeleccionarRegistro("Buscar Personal", table, columns.Cast<DataGridViewColumn>().ToArray(), columnsFilter, typeof(PersonalBe), txtNroDocIdentidadPersonal.Text.Trim());
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            CargarPersonal(null);
            if (dr == DialogResult.OK)
            {
                dynamic resultado = frm.Resultado;
                CargarPersonal(resultado.CodigoPersonal);
            }
        }

        void CargarPersonal(int? codigoPersonal)
        {
            PersonalBe personal = codigoPersonal == null ? null : personalBl.ObtenerPersonal(codigoPersonal.Value);
            if (personal != null)
            {
                this.codigoPersonal = personal.CodigoPersonal;
                this.nroDocumentoIdentidad = personal.NroDocumentoIdentidad;
                txtNroDocIdentidadPersonal.Text = personal.NroDocumentoIdentidad;
                txtNombresPersonal.Text = personal.Nombres;
            }
            else
            {
                this.codigoPersonal = null;
                this.nroDocumentoIdentidad = null;
                txtNroDocIdentidadPersonal.Text = "";
                txtNombresPersonal.Text = "";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            UsuarioBe registro = new UsuarioBe();
            if (codigoUsuario.HasValue) registro.CodigoUsuario = codigoUsuario.Value;
            registro.Nombre = txtNombre.Text.Trim();
            registro.Contraseña = Seguridad.MD5Byte(txtContraseña.Text);
            registro.CodigoPersonal = codigoPersonal.Value;
            TreeNode[] treeNodeArray = tvwPerfil.Nodes.Cast<TreeNode>().ToArray();
            List<PerfilBe> listaPerfilMarcados = ListarPerfilesMarcados(treeNodeArray);
            registro.ListaPerfil = listaPerfilMarcados;

            bool seGuardoRegistro = usuarioBl.GuardarUsuario(registro);

            if (seGuardoRegistro)
            {
                DialogResult = MessageBox.Show("¡El registro se guardó correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        List<PerfilBe> ListarPerfilesMarcados(TreeNode[] nodes)
        {
            List<PerfilBe> lista = null;

            foreach (TreeNode node in nodes)
            {
                if (node.Checked)
                {
                    PerfilBe item = new PerfilBe { CodigoPerfil = (int)node.Tag };
                    lista = lista ?? new List<PerfilBe>();
                    lista.Add(item);
                }
            }

            return lista;
        }

        void LimpiarErrores()
        {
            lblErrorNombre.Text = "";
            lblErrorContraseña.Text = "";
            lblErrorPersonal.Text = "";
            lblErrorListaPerfil.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (txtNombre.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorNombre.Text = "Debe ingresar nombre";
                SetToolTipError(lblErrorNombre);
            }
            else
            {
                bool existeUsuario = usuarioBl.ExisteUsuario(txtNombre.Text.Trim(), codigoUsuario);

                if (existeUsuario)
                {
                    estaValidado = false;
                    lblErrorNombre.Text = $"El nombre ya existe";
                    SetToolTipError(lblErrorNombre);
                }
            }

            if (codigoUsuario == null && txtContraseña.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorContraseña.Text = "Debe ingresar contraseña";
                SetToolTipError(lblErrorContraseña);
            }

            if (codigoPersonal == null)
            {
                estaValidado = false;
                lblErrorPersonal.Text = "Debe seleccionar un personal";
                SetToolTipError(lblErrorPersonal);
            }

            TreeNode[] treeNodeArray = tvwPerfil.Nodes.Cast<TreeNode>().ToArray();
            List<PerfilBe> listaPerfilMarcados = ListarPerfilesMarcados(treeNodeArray);

            if (listaPerfilMarcados == null)
            {
                estaValidado = false;
                lblErrorListaPerfil.Text = $"Debe marcar mínimo un perfil";
                SetToolTipError(lblErrorListaPerfil);
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltUsuario.SetToolTip(label, label.Text);
        }
    }
}
