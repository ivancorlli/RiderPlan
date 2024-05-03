

using Raiderplan1;
using System;
using Wisej.Core;
using Wisej.Web;

namespace RaiderPlan.Sitio.EspacioPersonal
{
    public partial class EspacioPersonal : Wisej.Web.UserControl
    {
        Viajes.Viajes _Viaje;
        public delegate void Salir();
        public event Salir evSalir;
        public EspacioPersonal()
        {
            InitializeComponent();
            _Viaje = new Viajes.Viajes();
            MuestraDatos();
        }

        private void MuestraDatos() 
        {
            //Recupero Usuario y persona
            Usuario _usario = new Usuario();
            _usario.Fill((int)Application.Session.UsuarioID);

            Persona _Persona = new Persona();
            _Persona.Fill(_usario.PersonaID);

            lblUsuarioNombre.Text = _usario.UsuarioNombre;
            if (!_Persona.PersonaRow.IsImagenPerfilNull() && _Persona.ImagenPerfil != "")
            {
                string rutaImagen = @"Resource\lib\ImagenesUsuario\" + _Persona.ImagenPerfil;
                pbUsuario.ImageSource = rutaImagen;
            }

        }

        private void eliminaObjetos() 
        {
            foreach (Control item in pnlContent.Controls)
            {
                if(item.Name!= "pnlMenu") { 
                pnlContent.Controls.Remove(item);
                }
            }

        }
        private void pbUsuario_Click(object sender, EventArgs e)
        {
            eliminaObjetos();
                       
            Perfil _Perfil=new Perfil();
            _Perfil.EvElijeaceptar += ManejaAceptar;
            _Perfil.EvElijeCancelar += ManejaCancelar;
            _Perfil.Margin = new Padding(20, 0, 0, 0);
            _Perfil.Dock = DockStyle.Fill;
            pnlContent.Controls.Add( _Perfil );
        }

        private void ManejaAceptar()
        {
            eliminaObjetos();
            MuestraDatos();

        }

        private void ManejaCancelar()
        {
            eliminaObjetos();
        }

        private void pbPerfil_Click(object sender, EventArgs e)
        {
            pbUsuario.PerformClick();
        }
              

        private void pbMapa1_Click(object sender, EventArgs e)
        {
            eliminaObjetos();
            Viajes.Viajes _Viaje = new Viajes.Viajes();
           _Viaje.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(_Viaje);
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            evSalir?.Invoke();
        }

        
    }
}
