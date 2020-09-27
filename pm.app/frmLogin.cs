using pm.be;
using pm.bl;
using pm.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace pm.app
{
    public partial class FrmLogin : RadForm
    {
        UsuarioBl usuarioBl = new UsuarioBl();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            bool formularioValido = ValidarFormulario();

            if (!formularioValido) return;

            string nombre = txtUsuario.Text.Trim();

            UsuarioBe usuario = usuarioBl.ObtenerUsuarioPorNombre(nombre);

            if(usuario == null)
            {
                lblErrorUsuario.Text = "Usuario no existe";
                return;
            }

            string contraseña = txtContraseña.Text;

            bool contraseñaValida = Seguridad.CompareMD5(contraseña, usuario.Contraseña);

            if (!contraseñaValida)
            {
                lblErrorContraseña.Text = "Contraseña incorrecta";
                return;
            }

            FrmMain frmMain = new FrmMain(usuario);
            frmMain.Show();
            Close();
        }

        void LimpiarErrores()
        {
            lblErrorUsuario.Text = "";
            lblErrorContraseña.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (txtUsuario.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorUsuario.Text = "Debe ingresar usuario";
            }

            if (txtContraseña.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorContraseña.Text = "Debe ingresar contraseña";
            }

            return estaValidado;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            bool autoLogin = AppSettings.Get<bool>("autoLogin");

            if (autoLogin)
            {
                string usuario = AppSettings.Get<string>("login.usuario");
                string contraseña = AppSettings.Get<string>("login.contraseña");

                txtUsuario.Text = usuario;
                txtContraseña.Text = contraseña;

                btnIniciarSesion_Click(btnIniciarSesion, new EventArgs());
            }
        }
    }
}
