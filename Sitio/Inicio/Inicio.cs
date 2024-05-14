using System;
using Wisej.Web;

namespace RaiderPlan.Sitio.Inicio
{
    public partial class Inicio : Wisej.Web.UserControl
    {
        public event EventHandler EvAutenticado;
        public Inicio()
        {
            InitializeComponent();
        }

        private void ElijeAceptar()
        {
            EvAutenticado?.Invoke(this, EventArgs.Empty);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            winRegistro winRegistro = new winRegistro();
            winRegistro.StartPosition = FormStartPosition.CenterScreen;
            winRegistro.evRegistrado += ManejaValidaCodigo;
            winRegistro.ShowDialog();
        }

        private void ManejaValidaCodigo(string pEmailUsuario)
        {
            // creo la ventana para el ingreso del codigo de validacion
            winValidacionCodigo ventana = new winValidacionCodigo(pEmailUsuario);
            ventana.evCodigoCorrecto += manejaCodigoCorrecto;
            ventana.StartPosition = FormStartPosition.CenterScreen;
            ventana.ShowDialog();
        }

        private void manejaCodigoCorrecto()
        {
            //disparo el evento para terminar el inicio y cargar el espacio personal del usuario
            EvAutenticado?.Invoke(this, EventArgs.Empty);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            winLogin winLogin = new winLogin();
            winLogin.EvAceptar += ElijeAceptar;
            winLogin.evValidar += ManejaValidaCodigo;
            winLogin.evCrearCuenta += ManejaCrearCuenta;
            winLogin.StartPosition = FormStartPosition.CenterScreen;
            winLogin.ShowDialog();
        }

        private void ManejaCrearCuenta()
        {
            btnRegistro_Click(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1_Click(sender, e);
        }
    }
}
