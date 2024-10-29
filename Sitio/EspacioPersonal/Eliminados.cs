using Raiderplan1;
using System;
using Wisej.Web;

namespace RaiderPlan.Sitio.EspacioPersonal
{
    public partial class Eliminados : Wisej.Web.UserControl
    {
        public Eliminados()
        {
            InitializeComponent();
            this.Load += Eliminados_Load;
        }

        private void Eliminados_Load(object sender, EventArgs e)
        {
            ViajesEliminadosCollection eli = new ViajesEliminadosCollection();
            eli.Fill(Application.Session.UsuarioID);
            foreach (ViajesEliminados v in eli)
            {
                ViajeCardEliminado card = new ViajeCardEliminado(v);
                card.BringToFront();
                pnlViajes.Controls.Add(card);
            }
        }
    }
}
