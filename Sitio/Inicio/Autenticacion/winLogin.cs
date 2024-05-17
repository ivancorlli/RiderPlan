using System;
using Wisej.Web;
using Raiderplan1;
using System.Text.RegularExpressions;


namespace RaiderPlan.Sitio.Inicio
{
    public partial class winLogin : Wisej.Web.Form
    {
        public delegate void DelegadoLogin();
        public event DelegadoLogin EvAceptar;

        public delegate void DelegadoValidar(string pEmailUsuario);
        public event DelegadoValidar evValidar;

        public delegate void CrearCuenta();
        public event CrearCuenta evCrearCuenta;

        public delegate void RecuperarCuenta();
        public event RecuperarCuenta evRecuperaCuenta;

        public delegate void ValidaCodigoRecuperacion(int id);
        public event ValidaCodigoRecuperacion evValidaCodigoRecuperacion;
        public winLogin(string email = "")
        {
            InitializeComponent();
            lblError.Visible = false;
            if (email != String.Empty)
            {
                txtEmailUsuario.Text = email;
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            //Creo data provaider
            dpUsuarioXEmailXusuarioIDCollectionCollection usuarioXEmail = new dpUsuarioXEmailXusuarioIDCollectionCollection();

            // si la password y el email son correcton inteto recuperar primero por email o usuario
            if (ControlaPassword(txtPassword) && ControlaEmialUsuario(txtEmailUsuario))
            {
                if (txtEmailUsuario.Text.Contains("@"))
                {
                    //Busco por email
                    usuarioXEmail.Fill(txtEmailUsuario.Text.Trim(), "");
                }
                else
                {
                    //Recupero por usuario
                    usuarioXEmail.Fill("", txtEmailUsuario.Text.Trim());
                }

            }
            //si se recupera un solo objeto 
            if (usuarioXEmail.Count == 1)
            {
                if (usuarioXEmail[0].UsuarioRow.IsCodigoValidationNull() || usuarioXEmail[0].CodigoValidation == "")
                {
                    if (usuarioXEmail[0].UsuarioRow.IsCodigoRecuperacionNull())
                    {
                        string _password = Utiles.Tools.Encripta(txtPassword.Text);
                        if (_password == usuarioXEmail[0].UsuarioPasword)
                        {
                            this.Close();
                            Application.Session.UsuarioID = usuarioXEmail[0].UsuarioID;
                            EvAceptar?.Invoke();
                        }
                        else MessageBox.Show("El correo o la passaword son incorrectos");
                    }
                    else
                    {
                        this.Close();
                        evValidaCodigoRecuperacion.Invoke(usuarioXEmail[0].UsuarioID);
                    }
                }
                else
                {
                    //validacion de código para ingreso
                    evValidar?.Invoke(txtEmailUsuario.Text);
                }

            }
            else
            {
                if (usuarioXEmail.Count == 0) MessageBox.Show("El usuario no existe");
                else MessageBox.Show("Hay porblemas con el usuario con el que intenta ingresar");
            }


        }

        private void txtEmailUsuario_Leave(object sender, EventArgs e)
        {
            bool resp = false;
            resp = ControlaEmialUsuario((TextBox)sender);
            if (!resp)
            {
                errorProvider1.SetError(txtEmailUsuario, "hay errores en el email o usuario");
            }
            else
            {
                errorProvider1.Clear();
                lblError.Visible = false;
            }



        }

        private bool ControlaEmialUsuario(TextBox sender)
        {
            bool resp = false;

            if (sender.Text.Contains("@"))
            {
                string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                resp = Regex.IsMatch(sender.Text, patron);
                if (!resp)
                {
                    lblError.Text = "El email no es valido";
                    lblError.Visible = true;
                }
            }
            else
            {
                //controlamos el nombre de usuario
                if (sender.Text.Trim().Length > 4)
                {
                    string patron = "^[a-zA-Z0-9]+$";
                    resp = Regex.IsMatch(sender.Text, patron);
                    if (!resp)
                    {
                        lblError.Text = "El nombre de usuario no es válido solo acpeta letras y números";
                        lblError.Visible = true;
                    }
                }
                else
                {
                    resp = false;
                    lblError.Text = "El nombre de usuario debe tener mas de 3 caracteres";
                    lblError.Visible = true;
                }
            }

            return resp;
        }

        /// <summary>
        /// cuando deja el foco de password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            bool resp = false;
            resp = ControlaPassword((TextBox)sender);
            if (!resp)
            {
                errorProvider1.SetError(txtPassword, "hay errores en el password");
            }
            else
            {
                errorProvider1.Clear();
                lblError.Visible = false;
            }
        }

        private bool ControlaPassword(TextBox ptextbox)
        {
            bool resp = false;
            string patron = "^[a-zA-Z0-9]+$";


            if (ptextbox.Text.Length < 4)
            {
                lblError.Text = "El password debe tener mas de 3 caracteres";
                lblError.Visible = true;
                resp = false;
                return resp;
            }


            resp = Regex.IsMatch(ptextbox.Text, patron);
            if (!resp)
            {
                lblError.Text = "El password solo admite caracteres alfabeticos y números ";
                lblError.Visible = true;
            }

            return resp;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            evCrearCuenta.Invoke();
        }

        private void lklcontraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            evRecuperaCuenta.Invoke();
        }
    }
}
