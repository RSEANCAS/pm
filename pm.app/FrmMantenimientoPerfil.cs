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

namespace pm.app
{
    public partial class FrmMantenimientoPerfil : Form
    {
        int? codigoPerfil;

        PerfilBl perfilBl = new PerfilBl();
        MenuBl menuBl = new MenuBl();

        public FrmMantenimientoPerfil(int? codigoPerfil = null)
        {
            InitializeComponent();
            this.codigoPerfil = codigoPerfil;
        }

        private void FrmMantenimientoPerfil_Load(object sender, EventArgs e)
        {
            Text = !codigoPerfil.HasValue ? "Nuevo Perfil" : "Modificar Perfil";
            if (codigoPerfil.HasValue)
            {
                CargarPerfil();
            }
            else
            {
                CargarListaMenu();
            }
        }

        void CargarPerfil()
        {
            PerfilBe item = perfilBl.ObtenerPerfil(codigoPerfil.Value);
            txtNombre.Text = item.Nombre;
            CargarListaMenu();
        }

        void CargarListaMenu()
        {
            List<MenuBe> listaMenu = menuBl.ListarMenuDefaultPorPerfil(codigoPerfil);

            List<MenuBe> listaMenuPadre = listaMenu.Where(x => !x.CodigoMenuPadre.HasValue).ToList();
            CargarListaMenuRecursivo(listaMenuPadre, listaMenu);
            CargarCheckBoxTreeView(listaMenuPadre);

        }

        void CargarListaMenuRecursivo(List<MenuBe> listaMenuActual, List<MenuBe> listaMenu)
        {
            if(listaMenuActual != null)
            {
                foreach(MenuBe item in listaMenuActual)
                {
                    List<MenuBe> listaMenuHijo = listaMenu.Where(x => x.CodigoMenuPadre == item.CodigoMenu).ToList();
                    item.ListaMenu = listaMenuHijo;
                    CargarListaMenuRecursivo(item.ListaMenu, listaMenu);
                }
            }
        }

        void CargarCheckBoxTreeView(List<MenuBe> listaMenu)
        {
            if (listaMenu != null)
            {
                List<TreeNode> lista = ListarCheckBoxTreeView(listaMenu);
                tvwMenu.Nodes.AddRange(lista.ToArray());
            }
        }

        List<TreeNode> ListarCheckBoxTreeView(List<MenuBe> listaMenu)
        {
            List<TreeNode> lista = null;
            if (listaMenu != null)
            {
                foreach (MenuBe item in listaMenu)
                {
                    lista = lista ?? new List<TreeNode>();

                    TreeNode treeNode = new TreeNode(item.Nombre);
                    treeNode.Checked = item.Check;
                    treeNode.Tag = item.CodigoMenu;

                    if (item.ListaMenu != null)
                    {
                        List<TreeNode> listaSubMenu = ListarCheckBoxTreeView(item.ListaMenu);
                        if(listaSubMenu != null) treeNode.Nodes.AddRange(listaSubMenu.ToArray());
                    }

                    lista.Add(treeNode);
                }
            }

            return lista;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            PerfilBe registro = new PerfilBe();
            if (codigoPerfil.HasValue) registro.CodigoPerfil = codigoPerfil.Value;
            registro.Nombre = txtNombre.Text.Trim();
            TreeNode[] treeNodeArray = tvwMenu.Nodes.Cast<TreeNode>().ToArray();
            List<MenuBe> listaMenuMarcados = ListarMenuesMarcados(treeNodeArray);
            registro.ListaMenu = listaMenuMarcados;

            bool seGuardoRegistro = perfilBl.GuardarPerfil(registro);

            if (seGuardoRegistro)
            {
                DialogResult = MessageBox.Show("¡El registro se guardó correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        List<MenuBe> ListarMenuesMarcados(TreeNode[] nodes)
        {
            List<MenuBe> lista = null;

            foreach(TreeNode node in nodes)
            {
                if (node.Checked)
                {
                    MenuBe item = new MenuBe { CodigoMenu = (int)node.Tag };
                    lista = lista ?? new List<MenuBe>();
                    lista.Add(item);
                    if(node.Nodes.Count > 0)
                    {
                        TreeNode[] treeNodes = node.Nodes.Cast<TreeNode>().ToArray();
                        List<MenuBe> subLista = ListarMenuesMarcados(treeNodes);
                        lista.AddRange(subLista);
                    }
                }
            }

            return lista;
        }

        void LimpiarErrores()
        {
            lblErrorNombre.Text = "";
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
                bool existePerfil = perfilBl.ExistePerfil(txtNombre.Text.Trim(), codigoPerfil);

                if (existePerfil)
                {
                    estaValidado = false;
                    lblErrorNombre.Text = $"El nombre ya existe";
                    SetToolTipError(lblErrorNombre);
                }
            }

            TreeNode[] treeNodeArray = tvwMenu.Nodes.Cast<TreeNode>().ToArray();
            List<MenuBe> listaMenuMarcados = ListarMenuesMarcados(treeNodeArray);

            if(listaMenuMarcados == null)
            {
                estaValidado = false;
                lblErrorListaMenu.Text = $"Debe marcar mínimo un menú";
                SetToolTipError(lblErrorListaMenu);
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltPerfil.SetToolTip(label, label.Text);
        }
    }
}
