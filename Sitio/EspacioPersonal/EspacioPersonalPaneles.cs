using Raiderplan1;
using System;
using Wisej.Web;

namespace RaiderPlan.Sitio.EspacioPersonal
{
    public partial class EspacioPersonalPaneles : Wisej.Web.UserControl
    {
        public delegate void Mapa(long id);
        public event Mapa EvVerMapa;
        public delegate void Iniciar(long id);
        public event Iniciar EvIniciarViaje;
        public EspacioPersonalPaneles()
        {
            InitializeComponent();
            this.Load += CargarPaneles;
        }

        private void CargarPaneles(object sender, EventArgs e)
        {
            CargarPanelEliminados();
            CargarPanelViajeActual();
        }
        private void LblMisViajes_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
            panel4.Visible = false;
            MisViajes misViajes = new MisViajes();
            misViajes.EvVerMapa += (id)=>this.EvVerMapa(id);
            misViajes.EvIniciarViaje += (id) => this.EvIniciarViaje(id);
            misViajes.EvActualizar += () =>
            {
                CargarPanelEliminados();
            };
            misViajes.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(misViajes);
        }
        private void LblExplorar_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            Explorar explorar = new Explorar();
            explorar.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(explorar);
        }
        private void CargarPanelViajeActual()
        {
            ViajesEnProgresoCollection actual = new ViajesEnProgresoCollection();
            actual.Fill(Application.Session.UsuarioID);
            if (actual.Count > 0)
            {
                pnlViajeActual.Visible = true;
                lblViajeNombre.Text = actual[0].ViajeNombre;
            }
            else
            {
                pnlViajeActual.Visible = false;
            }
        }
        private void CargarPanelEliminados()
        {
            ViajesEliminadosCollection eliminadosCollection = new ViajesEliminadosCollection();
            eliminadosCollection.Fill(Application.Session.UsuarioID);
            if (eliminadosCollection.Count > 0) {
                lblEliminados.Visible = true;
            }
            else
            {
                lblEliminados.Visible = false;
            }
        }
        private void LblEliminados_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel3.Visible = false;
            panel2.Visible = false;
            Eliminados misViajes = new Eliminados();
            misViajes.EvActualizar += () =>
            {
                ViajesEliminadosCollection eliminadosCollection = new ViajesEliminadosCollection();
                eliminadosCollection.Fill(Application.Session.UsuarioID);
                if (eliminadosCollection.Count > 0)
                {
                    lblEliminados.Visible = true;
                    panel4.Visible = true;
                }
                else
                {
                    lblEliminados.Visible = false;
                    panel4.Visible = false;
                    LblMisViajes_Click(sender, e);
                }
            };
            misViajes.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(misViajes);
        }

    }
}
