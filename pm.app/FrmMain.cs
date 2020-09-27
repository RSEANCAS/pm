using pm.be;
using pm.bl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace pm.app
{
    public partial class FrmMain : RadForm
    {
        UsuarioBe usuarioSession { get; set; }

        PersonalBl personalBl = new PersonalBl();
        PerfilBl perfilBl = new PerfilBl();
        MenuBl menuBl = new MenuBl();

        public FrmMain(UsuarioBe usuario)
        {
            InitializeComponent();
            if (usuario == null) Close();
            usuario.Personal = personalBl.ObtenerPersonal(usuario.CodigoPersonal);
            usuario.ListaPerfil = perfilBl.ListarPerfilPorUsuario(usuario.CodigoUsuario);
            usuario.PerfilActual = usuario.ListaPerfil.FirstOrDefault();
            usuarioSession = usuario;
        }

        void CargarComboPerfiles()
        {
            if (usuarioSession.ListaPerfil == null) return;

            if (usuarioSession.PerfilActual != null)
            {
                cbbPerfil.Text = usuarioSession.PerfilActual.Nombre;
                cbbPerfil.Tag = usuarioSession.PerfilActual.CodigoPerfil;
                CargarMenuPorPerfil();
            }

            foreach (PerfilBe item in usuarioSession.ListaPerfil)
            {
                ToolStripItem toolStripButton = new ToolStripButton(item.Nombre);
                toolStripButton.Tag = item.CodigoPerfil;
                toolStripButton.Click += cbbPerfil_Item_Click;

                cbbPerfil.DropDown.Items.Add(toolStripButton);
            }
        }

        ToolStripItem[] ObtenerMenuCollection(List<MenuBe> listaMenu)
        {
            List<ToolStripItem> listaItems = null;

            if(listaMenu != null)
            {
                foreach(MenuBe menu in listaMenu)
                {
                    if (listaItems == null) listaItems = new List<ToolStripItem>();
                    ToolStripMenuItem itemMenu = new ToolStripMenuItem(menu.Nombre);
                    ToolStripItem[] itemsSubMenu = ObtenerMenuCollection(menu.ListaMenu);
                    if(itemsSubMenu != null) itemMenu.DropDownItems.AddRange(itemsSubMenu);
                    if (!string.IsNullOrEmpty(menu.Formulario))
                    {
                        itemMenu.Tag = menu.Formulario;
                        itemMenu.Click += ItemMenu_Click;
                    }
                    listaItems.Add(itemMenu);
                }
            }

            return listaItems == null ? null : listaItems.ToArray(); ;
        }

        private void ItemMenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem itemMenu = (ToolStripMenuItem)sender;

            Assembly asm = Assembly.GetEntryAssembly();
            Type formtype = asm.GetType(itemMenu.Tag.ToString());

            if (formtype == null) return;

            Form f = (Form)Activator.CreateInstance(formtype);
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.BringToFront();
            f.ShowInTaskbar = false;
            f.Show();
        }

        List<MenuBe> ObtenerListaMenuHijo(MenuBe menu, List<MenuBe> listaMenu)
        {
            List<MenuBe> listaMenuHijo = listaMenu.Where(x => x.CodigoMenuPadre == menu.CodigoMenu).ToList();

            if(listaMenuHijo != null)
            {
                foreach(MenuBe menuHijo in listaMenuHijo)
                {
                    menuHijo.ListaMenu = ObtenerListaMenuHijo(menuHijo, listaMenu);
                }
            }

            return listaMenuHijo;

        }

        void CargarMenuPorPerfil()
        {
            int codigoPerfil = (int)cbbPerfil.Tag;

            List<MenuBe> listaMenu = menuBl.ListarMenuPorPerfil(codigoPerfil);
            List<MenuBe> listaMenuPadre = listaMenu.Where(x => x.CodigoMenuPadre == null).ToList();

            foreach (MenuBe item in listaMenuPadre)
            {
                List<MenuBe> listaMenuHijo = listaMenu.Where(x => x.CodigoMenuPadre == item.CodigoMenu).ToList();
                item.ListaMenu = ObtenerListaMenuHijo(item, listaMenu);
            }

            ToolStripItem[] itemsMenu = ObtenerMenuCollection(listaMenuPadre);
            if (MdiChildren.Length > 0)
            {
                DialogResult dr = MessageBox.Show("Antes de cambiar de perfil, se cerrarán todas las ventanas, ¿Deseas continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    foreach (Form f in MdiChildren)
                    {
                        f.Close();
                    }

                    mnsMenu.Items.Clear();
                    if (itemsMenu != null) mnsMenu.Items.AddRange(itemsMenu);
                }
            }
            else
            {
                mnsMenu.Items.Clear();
                if (itemsMenu != null) mnsMenu.Items.AddRange(itemsMenu);
            }
        }

        private void cbbPerfil_Item_Click(object sender, EventArgs e)
        {
            ToolStripItem item = (ToolStripButton)sender;
            cbbPerfil.Text = item.Text;
            cbbPerfil.Tag = item.Tag;

            CargarMenuPorPerfil();
        }

        void CargarInformacionUsuario()
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST  
            string ip = Dns.GetHostByName(hostName).AddressList[0].ToString();

            lblUsuarioNombre.Text = usuarioSession.Nombre;
            lblPersonalNombres.Text = usuarioSession.Personal.Nombres;
            lblIP.Text = ip;
            lblPC.Text = hostName;
            CargarComboPerfiles();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CargarInformacionUsuario();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
