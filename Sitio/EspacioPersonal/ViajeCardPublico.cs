using RaiderPlan.Sitio.Inicio;
using RaiderPlan.Sitio.Utiles;
using Raiderplan1;
using System;
using System.IO;
using Wisej.Web;

namespace RaiderPlan.Sitio.EspacioPersonal
{
    public partial class ViajeCardPublico : Wisej.Web.UserControl
    {
        public delegate void VerMapa(long id);
        public event VerMapa EvVerMapa;
        private string _ImagenPath = null;
        private string _Nombre = null;
        private string _Destino = null;
        private string _Origen = null;
        private int _MeGustas = 0;
        private int _Descargas = 0;
        private long _UserId = 0;
        private long _ViajeId = 0;

        public ViajeCardPublico(string nombre="",string imagen=null, string origen = "", string destino ="",int meGustas=0,int descargas=0,long userId=0,long viajeId =0 )
        {
            InitializeComponent();
            _ImagenPath = imagen;
            _Nombre = nombre;
            _Destino = destino;
            _Origen = origen;
            _MeGustas = meGustas;
            _Descargas = descargas;
            _UserId = userId;
            _ViajeId = viajeId;
            this.Load += Viaje_Load;
        }

        private void Viaje_Load(object sender, EventArgs e)
        {
            viajeNombre.Text = _Nombre;
                if (!string.IsNullOrEmpty(_ImagenPath))
                {
                pbImagenViaje.ImageSource = _ImagenPath;
                    pbImagenViaje.SizeMode = PictureBoxSizeMode.Zoom;
                    pbImagenViaje.Padding = new Padding(0);
                }
               
                if (!string.IsNullOrEmpty(_Origen))
                {
                    label1.Text = _Origen;
                }
               
                if (!string.IsNullOrEmpty(_Destino))
                {
                    label2.Text = _Destino;
                }

            label3.Text = _MeGustas.ToString();
            label4.Text = _Descargas.ToString();
            if (_UserId>0){
                Usuario user = new Usuario();
                user.Fill((int)_UserId);
                Persona _Persona = new Persona();
                _Persona.Fill(user.PersonaID);
                label5.Text = $"@{user.UsuarioNombre}";
                //recupero imagen de perfil
                if (_Persona.PersonaRow.IsImagenPerfilNull() || _Persona.ImagenPerfil.Trim() == "")
                {
                    pictureBox7.ImageSource = Path.Combine("Resource", "lib", "Imagenes", "iconousuario.png");
                }
                else
                {
                    pictureBox7.ImageSource = Path.Combine("Resource", "lib", "ImagenesUsuario", _Persona.ImagenPerfil);
                }
                pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }

        private void ViajeCardPublico_Click(object sender, EventArgs e)
        {
            this.EvVerMapa?.Invoke(this._ViajeId);
        }

        private void panel1_PanelCollapsed(object sender, EventArgs e)
        {
            this.EvVerMapa?.Invoke(this._ViajeId);
        }

        private void panel2_PanelCollapsed(object sender, EventArgs e)
        {
            this.EvVerMapa?.Invoke(this._ViajeId);
        }

        private void pbImagenViaje_Click(object sender, EventArgs e)
        {
            this.EvVerMapa?.Invoke(this._ViajeId);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.EvVerMapa?.Invoke(this._ViajeId);
        }

        private void viajeNombre_Click(object sender, EventArgs e)
        {
            this.EvVerMapa?.Invoke(this._ViajeId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.EvVerMapa?.Invoke(this._ViajeId);
        }
    }
}