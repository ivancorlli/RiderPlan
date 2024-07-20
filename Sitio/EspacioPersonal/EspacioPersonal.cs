


using RaiderPlan.Sitio.Inicio;
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

        private Dictionary<string, string> _currentPage = new Dictionary<string, string>();
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
            EvSalir.Invoke();
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
                    control.EvModificar += CargarTabViajeCreado;
                    control.EvEliminar += CargarTabPlanificacion;
                    pnl.Controls.Add(control);
                }
            }
        }

        private void CargarTabNuevo()
        {
            NuevoViaje nuevoViaje = new NuevoViaje();
            nuevoViaje.Dock = DockStyle.Fill;
            nuevoViaje.Name = "nuevoViajeControl";
            nuevoViaje.CancelaNuevoViaje += (NuevoViaje) =>
            {
                tabControl1.SelectedIndex = 0;
                nuevo.Controls.Clear();
            };
            nuevoViaje.NuevoViajeCreado += CargarTabViajeCreado;
            nuevo.Controls.Add(nuevoViaje);
        }

        private void CargarTabViajeCreado(long id,string nombre)
        {
            _currentPage["Id"] = id.ToString();
            _currentPage["Nombre"] = nombre.Trim();

            TabPage newPage = new TabPage();
            newPage.Name = _currentPage["Id"];
            newPage.Text = _currentPage["Nombre"];

            var position = tabControl1.TabPages.Count - 1;
            tabControl1.TabPages.Insert(position, newPage);
            tabControl1.SelectedIndex = position;
            nuevo.Controls.Clear();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            TabPage page = e.TabPage;
            page.Controls.Clear();
            if (_currentPage.TryGetValue("Id", out string value) && _currentPage.ContainsKey("Nombre"))
            {
                if (page.Name != value)
                {
                    tabControl1.TabPages.RemoveByKey(value);
                }
                else
                {
                    Viajes.Viajes mapa = new Viajes.Viajes();
                    mapa.Dock = DockStyle.Fill;
                    page.Controls.Add(mapa);
                }
            }
            switch (page.Name)
            {
                case "nuevo":
                    CargarTabNuevo();
                    break;
                case "planificacion":
                    CargarTabPlanificacion();
                    break;
            }
        }

    }
}
