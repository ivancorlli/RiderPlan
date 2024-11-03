using Raiderplan1;
using System;
using Wisej.Web;

namespace RaiderPlan.Sitio.EspacioPersonal
{
    public partial class Eliminados : Wisej.Web.UserControl
    {
        public delegate void Actualizar();
        public event Actualizar EvActualizar;
        public Eliminados()
        {
            InitializeComponent();
            this.Load += Eliminados_Load;
        }

        private void Eliminados_Load(object sender, EventArgs e)
        {
            CargarCards();
        }

        private void CargarCards()
        {
            pnlViajes.Controls.Clear();
            ViajesEliminadosCollection eli = new ViajesEliminadosCollection();
            eli.Fill(Application.Session.UsuarioID);
            foreach (ViajesEliminados v in eli)
            {
                ViajeCardEliminado card = new ViajeCardEliminado(v);
                card.EvRecuperar += () =>
                {
                    CargarCards();
                    this.EvActualizar.Invoke();
                };
                card.BringToFront();
                pnlViajes.Controls.Add(card);
            }
        }
    }
}
