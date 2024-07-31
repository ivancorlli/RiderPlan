


using RaiderPlan.Sitio.Inicio;
using RaiderPlan.Sitio.Viajes;
using Raiderplan1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
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
            this.Load += EspacioPersonal_Load;
        }

        private void EspacioPersonal_Load(object sender, EventArgs e)
        {
            CargarTabPlanificacion();
        }

        private void MuestraDatos()
        {
            //Recupero Usuario y persona
            _Usuario = new Usuario();
            _Usuario.Fill((int)Application.Session.UsuarioID);

            _Persona = new Persona();
            _Persona.Fill(_Usuario.PersonaID);

            lblUsuarioNombre.Text = _Usuario.UsuarioNombre;
            //recupero imagen de perfil
            if (_Persona.PersonaRow.IsImagenPerfilNull() || _Persona.ImagenPerfil.Trim() == "")
            {
                pbUsuario.ImageSource = Path.Combine("Resource", "lib", "Imagenes", "iconousuario.png");

            }
            else
            {
                pbUsuario.ImageSource = Path.Combine("Resource", "lib", "ImagenesUsuario", _Persona.ImagenPerfil);

            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            EvSalir?.Invoke();
        }

        private void pbUsuario_Click(object sender, EventArgs e)
        {
            winPerfil perfil = new winPerfil(_Usuario, _Persona);
            perfil.EvACtualizar += Perfil_EvACtualizar;
            perfil.CenterToParent();
            perfil.Show();
        }

        private void Perfil_EvACtualizar()
        {
            MuestraDatos();
        }

        private void lblUsuarioNombre_Click(object sender, EventArgs e)
        {
            winPerfil perfil = new winPerfil(_Usuario, _Persona);
            perfil.EvACtualizar += Perfil_EvACtualizar;
            perfil.CenterToParent();
            perfil.Show();
        }

        private void CargarTabPlanificacion()
        {
            planificacion.Controls.Clear();
            ViajeCollection viajes = new ViajeCollection();
            viajes.FillByUsuarioID(Application.Session.UsuarioID);
            if (viajes.Count > 0)
            {
                FlowLayoutPanel pnl = new FlowLayoutPanel();
                pnl.Visible = true;
                pnl.Dock = DockStyle.Fill;
                pnl.FlowDirection = FlowDirection.LeftToRight;
                pnl.Padding = new Padding(5);
                planificacion.Controls.Add(pnl);
                foreach (Viaje viaje in viajes)
                {
                    ViajeCard control = new ViajeCard(viaje);
                    control.BringToFront();
                    control.Visible = true;
                    control.EvModificar += CargarViaje;
                    control.EvEliminar += CargarTabPlanificacion;
                    pnl.Controls.Add(control);
                }
            }
        }

        private void CargarViaje(long id)
        {
            // Cargo variable de sesion para manejar en el mapa
            Application.Session.ViajeID = id;
            Viajes.Viajes pnl = new Viajes.Viajes();
            pnl.EvSalir += () =>
            {
                // Blanqueo variable de sesion del mapa
                Application.Session.ViajeID = 0;
                for (int i = 0; i <= pnlContent.Controls.Count - 1; i++)
                {
                    Control control = pnlContent.Controls[i];
                    if (pnlContent.Controls[i] is Viajes.Viajes)
                    {
                        pnlContent.Controls.Remove(control);
                    }
                    else
                    {
                        control.Visible = true;
                    }
                }

            };
            pnl.Dock = DockStyle.Fill;
            tabControl1.Visible = false;
            tabControl1.SelectedIndex = 0;
            pnlContent.Controls.Add(pnl);
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            TabPage page = e.TabPage;
            page.Controls.Clear();
            switch (page.Name)
            {
                case "planificacion":
                    CargarTabPlanificacion();
                    break;
            }
        }

        private void btnCrearViaje_Click(object sender, EventArgs e)
        {
            winNuevoViaje popup = new winNuevoViaje();
            popup.EvAceptar += CargarViaje;
            popup.Show();
        }

       
    }
}
