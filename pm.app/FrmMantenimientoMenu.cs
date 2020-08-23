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
    public partial class FrmMantenimientoMenu : Form
    {
        int? codigoMenu;

        MenuBl menuBl = new MenuBl();

        public FrmMantenimientoMenu(int? codigoMenu = null)
        {
            InitializeComponent();
            this.codigoMenu = codigoMenu;
        }

        private void FrmMantenimientoMenu_Load(object sender, EventArgs e)
        {
            Text = !codigoMenu.HasValue ? "Nuevo Menú" : "Modificar Menú";
            ListarCombos();
            if (codigoMenu.HasValue)
            {
                CargarMenu();
            }
        }

        void CargarMenu()
        {
            MenuBe item = menuBl.ObtenerMenu(codigoMenu.Value);
            txtNombre.Text = item.Nombre;
            txtFormulario.Text = item.Formulario;
            if (item.CodigoMenuPadre.HasValue) cbbCodigoMenuPadre.SelectedValue = item.CodigoMenuPadre;
        }

        void ListarCombos()
        {
            ListarComboMenuPadre();
        }

        void ListarComboMenuPadre()
        {
            List<MenuBe> listaCombo = menuBl.ListarComboMenuPadreMenu(codigoMenu);
            listaCombo = listaCombo ?? new List<MenuBe>();
            listaCombo.Insert(0, new MenuBe { CodigoMenu = -1, Nombre = "[Seleccione...]" });

            cbbCodigoMenuPadre.DataSource = null;
            cbbCodigoMenuPadre.DataSource = listaCombo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            MenuBe registro = new MenuBe();
            if (codigoMenu.HasValue) registro.CodigoMenu = codigoMenu.Value;
            registro.Nombre = txtNombre.Text.Trim();
            registro.Formulario = txtFormulario.Text.Trim();
            if (cbbCodigoMenuPadre.SelectedIndex != 0) registro.CodigoMenuPadre = (int)cbbCodigoMenuPadre.SelectedValue;

            bool seGuardoRegistro = menuBl.GuardarMenu(registro);

            if (seGuardoRegistro)
            {
                DialogResult = MessageBox.Show("¡El registro se guardó correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void LimpiarErrores()
        {
            lblErrorNombre.Text = "";
            lblErrorFormulario.Text = "";
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
                bool existeMenu = menuBl.ExisteMenu(txtNombre.Text.Trim(), codigoMenu);

                if (existeMenu)
                {
                    estaValidado = false;
                    lblErrorNombre.Text = $"El nombre ya existe";
                    SetToolTipError(lblErrorNombre);
                }
            }

            if (cbbCodigoMenuPadre.SelectedIndex != 0 && txtFormulario.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorFormulario.Text = "Debe ingresar formulario";
                SetToolTipError(lblErrorFormulario);
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltMenu.SetToolTip(label, label.Text);
        }
    }
}
