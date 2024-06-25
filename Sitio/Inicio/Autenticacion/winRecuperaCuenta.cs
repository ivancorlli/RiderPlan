
using Raiderplan1;
using System;
using System.Text.RegularExpressions;
using Wisej.Web;

namespace RaiderPlan.Sitio.Inicio
{
    public partial class winRecuperaCuenta : Wisej.Web.Form
    {
        public delegate void eventRecuperar(int id);
        public event eventRecuperar EvRecupera;

        public winRecuperaCuenta()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ControlaEmialUsuario(txtEmailUsuario))
            {
                dpUsuarioXEmailXusuarioIDCollectionCollection usuarioXEmail = new dpUsuarioXEmailXusuarioIDCollectionCollection();
                usuarioXEmail.Fill(txtEmailUsuario.Text, "");
                if (usuarioXEmail.Count > 0)
                {
                    Usuario user = new Usuario();
                    user.Fill(usuarioXEmail[0].UsuarioID);
                    user.CodigoRecuperacion = Utiles.Tools.GeneraCodigo(4);
                    user.Update();
                    Utiles.Tools.EnviaEmailRecuperacion(user.CodigoRecuperacion,user.UsuarioEmail);
                    EvRecupera.Invoke(user.UsuarioID);

                }
                this.Close();
            };
        }
        private bool ControlaEmialUsuario(TextBox sender)
        {
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool resp = Regex.IsMatch(sender.Text, patron);
            if (!resp)
            {
                lblError.Text = "El email no es valido";
                lblError.Visible = true;
            }

            return resp;
        }
    }
}

