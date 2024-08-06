


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
            this.Load += EspacioPersonal_Load;
        }

        private void EspacioPersonal_Load(object sender, EventArgs e)
        {
            MuestraDatos();
            ViajesEnProgresoCollection actual = new ViajesEnProgresoCollection();
            actual.Fill(Application.Session.UsuarioID);
            if (actual.Count > 0)
            {
                CargarViajeActual(actual[0].ViajeID);
            }
            else
            {
                CargarTabPlanificacion();
                CreaTabEliminados();
            }
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
            perfil.ShowDialog();
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
            perfil.ShowDialog();
        }

        private void btnCrearViaje_Click(object sender, EventArgs e)
        {
            winNuevoViaje popup = new winNuevoViaje();
            popup.EvAceptar += CargarPanelViaje;
            popup.ShowDialog();
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            CerrarPanelViaje();
            CargarTabPlanificacion();
        }
        private void CargarTabPlanificacion()
        {
            planificacion.Controls.Clear();
            ViajesEnPlanificacionCollection viajes = new ViajesEnPlanificacionCollection();
            viajes.Fill(Application.Session.UsuarioID);
            if (viajes.Count > 0)
            {
                FlowLayoutPanel pnl = new FlowLayoutPanel();
                pnl.Visible = true;
                pnl.Dock = DockStyle.Fill;
                pnl.FlowDirection = FlowDirection.LeftToRight;
                pnl.Padding = new Padding(5);
                planificacion.Controls.Add(pnl);
                foreach (ViajesEnPlanificacion viaje in viajes)
                {
                    ViajeCard control = new ViajeCard(viaje);
                    control.BringToFront();
                    control.Visible = true;
                    control.EvModificar += CargarPanelViaje;
                    control.EvEliminar += () =>
                    {
                        CargarTabPlanificacion();
                        CreaTabEliminados();
                    };
                    control.EvIniciar += CargarViajeActual;
                    pnl.Controls.Add(control);
                }
            }
        }

        private void CreaTabEliminados()
        {
            ViajesEliminadosCollection viajes = new ViajesEliminadosCollection();
            viajes.Fill(Application.Session.UsuarioID);
            TabPage tabPage = null;
            foreach (TabPage tab in tabControl1.TabPages)
            {
                if (tab.Name == "eliminados")
                {
                    tabPage = tab;
                }
            }
            if (viajes.Count > 0)
            {
                if (tabPage == null)
                {
                    tabPage = new TabPage();
                    tabPage.Name = "eliminados";
                    tabControl1.TabPages.Insert(tabControl1.TabPages.Count, tabPage);
                }
                tabPage.Text = "Eliminados" + " (" + viajes.Count + ")";
            }
            else
            {
                if (tabPage != null)
                {
                    tabControl1.TabPages.RemoveByKey("eliminados");
                    tabControl1.SelectedIndex = 0;
                }
            }
        }

        private void CargarTabRealizados()
        {

        }
        private void CargarViajeActual(long id)
        {
            // Cargo variable de sesion para manejar en el mapa
            Application.Session.ViajeID = id;
            // Configuro Cabecera
            btnCrearViaje.Visible = false;
            btnInicio.Visible = true;
            ViajeEnProgreso pnl = new ViajeEnProgreso();
            pnl.EvSalir += () =>
            {
                CerrarPanelViaje();
                CargarTabPlanificacion();
            };
            pnl.Dock = DockStyle.Fill;
            tabControl1.Visible = false;
            tabControl1.SelectedIndex = 0;
            pnlContent.Controls.Add(pnl);
        }

        private void CargarPanelViaje(long id)
        {
            // Cargo variable de sesion para manejar en el mapa
            Application.Session.ViajeID = id;
            // Configuro Cabecera
            btnCrearViaje.Visible = false;
            btnInicio.Visible = true;
            Viajes.Viajes pnl = new Viajes.Viajes();
            pnl.EvSalir += () =>
            {
                CerrarPanelViaje();
                CargarTabPlanificacion();
            };
            pnl.Dock = DockStyle.Fill;
            tabControl1.Visible = false;
            tabControl1.SelectedIndex = 0;
            pnlContent.Controls.Add(pnl);
        }

        private void CerrarPanelViaje()
        {
            // Blanqueo variable de sesion del mapa
            Application.Session.ViajeID = 0;
            // Configuro Cabecera
            btnCrearViaje.Visible = true;
            btnInicio.Visible = false;
            for (int i = 0; i <= pnlContent.Controls.Count - 1; i++)
            {
                Control control = pnlContent.Controls[i];
                if (pnlContent.Controls[i] is Viajes.Viajes ||pnlContent.Controls[i] is ViajeEnProgreso)
                {
                    pnlContent.Controls.Remove(control);
                }
                else
                {
                    control.Visible = true;
                }
            }
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

                case "realizados":
                    CargarTabRealizados();
                    break;
                case "eliminados":
                    CargarEliminados(page);
                    break;
            }
        }

        private void CargarEliminados(TabPage page)
        {
            ViajesEliminadosCollection viajes = new ViajesEliminadosCollection();
            viajes.Fill(Application.Session.UsuarioID);
            FlowLayoutPanel pnl = new FlowLayoutPanel();
            pnl.Visible = true;
            pnl.Dock = DockStyle.Fill;
            pnl.FlowDirection = FlowDirection.LeftToRight;
            pnl.Padding = new Padding(10);
            foreach (ViajesEliminados viaje in viajes)
            {
                ViajeCardEliminado control = new ViajeCardEliminado(viaje);
                control.BringToFront();
                control.Visible = true;
                control.EvRecuperar += () =>
                {
                    page.Controls.Clear();
                    CreaTabEliminados();
                    CargarEliminados(page);
                };
                control.EvEliminar += () =>
                {
                    page.Controls.Clear();
                    CreaTabEliminados();
                    CargarEliminados(page);
                };
                pnl.Controls.Add(control);
            }
            page.Controls.Add(pnl);
        }

    }
}
