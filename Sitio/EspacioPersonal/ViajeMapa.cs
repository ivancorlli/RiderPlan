using Raiderplan1;
using System;
using Wisej.Web;

namespace RaiderPlan.Sitio.EspacioPersonal
{
    public partial class ViajeMapa : Wisej.Web.UserControl
    {
        public delegate void Salir();
        public event Salir EvSalir;
        private Viaje _viaje = null;
        public ViajeMapa(long viajeId)
        {
            InitializeComponent();
            this.Load += ViajeMapa_Load;
            if (viajeId > 0)
            {
                _viaje = new Viaje();
                _viaje.Fill(viajeId);
                lblTitulo.Text = _viaje.ViajeNombre;
                
            }
        }

        private void ViajeMapa_Load(object sender, EventArgs e)
        {
            Viajes.Viajes mapa = new Viajes.Viajes();
            mapa.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(mapa);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            EvSalir?.Invoke();
        }
    }
}
