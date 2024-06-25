


using RaiderPlan.Sitio.Inicio;
using Raiderplan1;
using System;
using System.Drawing;
using System.IO;
using Wisej.Web;

namespace RaiderPlan.Sitio.EspacioPersonal
{
    public partial class EspacioPersonal : Wisej.Web.UserControl
    {
        public delegate void Salir();
        public event Salir EvSalir;
        private Persona _Persona;
        private Usuario _Usuario;
        public EspacioPersonal()
        {
            InitializeComponent();
            MuestraDatos();
        }

        private void MuestraDatos()
        {
            //Recupero Usuario y persona
            _Usuario = new Usuario();
            _Usuario.Fill((int)Application.Session.UsuarioID);

            _Persona = new Persona();
            _Persona.Fill(_Usuario.PersonaID);

            lblUsuarioNombre.Text = _Usuario.UsuarioNombre;
            if (!_Persona.PersonaRow.IsImagenPerfilNull() && _Persona.ImagenPerfil != "")
            {
                string rutaImagen = Path.Combine(Application.StartupPath, "Resource", "lib","ImagenesUsuario",_Persona.ImagenPerfil);
                pbUsuario.ImageSource = rutaImagen;
            }

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            EvSalir.Invoke();
        }

        private void pbUsuario_Click(object sender, EventArgs e)
        {
            winPerfil perfil = new winPerfil(_Usuario,_Persona);
            perfil.CenterToParent();
            perfil.ShowDialog();
        }

        private void lblUsuarioNombre_Click(object sender, EventArgs e)
        {
            winPerfil perfil = new winPerfil(_Usuario,_Persona);
            perfil.CenterToParent();
            perfil.ShowDialog();
        }
    }
}
