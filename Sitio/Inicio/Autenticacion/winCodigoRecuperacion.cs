
using Raiderplan1;
using System;
using System.Text.RegularExpressions;
using Wisej.Web;

namespace RaiderPlan.Sitio.Inicio
{

    public partial class winCodigoRecuperacion : Wisej.Web.Form
    {
        public delegate void evClose(string pEmailUsuario="");
        public event evClose EvClose;
        private int _userId;
        
        public winCodigoRecuperacion(int id)
        {
            InitializeComponent();
            this._userId = id;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            EvClose.Invoke();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            TextBox oTextBox = (TextBox)sender;
            string patron = "^[a-zA-Z0-9_ ]+$";
            bool resp = Regex.IsMatch(oTextBox.Text, patron);

            if (!resp)
            {
                lblMensaje.Text = "El password no puede tener caracteres especiales,ni ser vacio";
                lblMensaje.Visible = true;
                errorProvider1.SetError(oTextBox, "El password no puede tener caracteres especiales,ni ser vacio");
            }
            else
                errorProvider1.SetError(oTextBox, "");
            lblMensaje.Visible = false;
        }

        private void txtPassword2_Leave(object sender, EventArgs e)
        {
            //uso el mismo metodo que usa txtPassword
            txtPassword_Leave(sender, e);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ControlIntegral())
            {
                Usuario user = new Usuario();
                user.Fill(_userId);
                if (!user.UsuarioRow.IsCodigoRecuperacionNull())
                {
                    if (!user.CodigoRecuperacion.Equals(txtCodigo.Text))
                    {
                        lblMensaje.Text = "El codigo ingresado es invalido";
                        errorProvider1.SetError(txtCodigo, "El codigo ingresado es invalido");
                        lblMensaje.Visible = true;
                        return;
                    }else
                    {
                        errorProvider1.Clear();
                        user.UsuarioRow.SetCodigoRecuperacionNull();
                        user.UsuarioPasword = Utiles.Tools.Encripta(txtPassword.Text);
                        user.Update();
                        this.Close();
                        EvClose.Invoke(user.UsuarioEmail);
                    }
                }
            }
        }

        private bool ControlIntegral()
        {
            string patron = "^[a-zA-Z0-9_ ]+$";
            bool resp = Regex.IsMatch(txtPassword.Text, patron);
            if (!resp)
            {
                lblMensaje.Text = "El password no puede tener caracteres especiales,ni ser vacio";
                errorProvider1.SetError(txtPassword, "El password no puede tener caracteres especiales,ni ser vacio");
                lblMensaje.Visible = true;
            }

            resp = Regex.IsMatch(txtPassword2.Text, patron);

            if (!resp)
            {
                lblMensaje.Text = "El password no puede tener caracteres especiales,ni ser vacio";
                errorProvider1.SetError(txtPassword2, "El password no puede tener caracteres especiales,ni ser vacio");
                lblMensaje.Visible = true;
            }

            //controlo si los passwords coinciden
            if (txtPassword.Text != txtPassword2.Text)
            {
                lblMensaje.Text = "El password no coincide con el paswword de verificación";
                errorProvider1.SetError(txtPassword2, "El password no coincide con el paswword de verificación");
                lblMensaje.Visible = true;
            }

            if(txtCodigo.Text != String.Empty)
            {
                lblMensaje.Text = "Debe ingresar un codigo valido";
                errorProvider1.SetError(lblMensaje, "Debe ingresar un codigo valido");
                lblMensaje.Visible = true;
            }

            if (resp)
            {
                errorProvider1.Clear();
                lblMensaje.Visible = false;
            };
            return resp;

        }


    }
}

