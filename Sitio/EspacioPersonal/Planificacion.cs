using Raiderplan1;
using System;
using Wisej.Web;

namespace RaiderPlan.Sitio.EspacioPersonal
{
    public partial class Planificacion : Wisej.Web.UserControl
    {
        public delegate void Modificar(long id);
        public event Modificar EvModificar;
        public Planificacion()
        {
            InitializeComponent();
            this.Load += Planificacion_Load;
        }

        private void Planificacion_Load(object sender, EventArgs e)
        {

        }

        private void CargarCards()
        {
            ViajeCollection viajes = new ViajeCollection();
            viajes.FillByUsuarioID(Application.Session.UsuarioID);
            if (viajes.Count > 0)
            {
                foreach (Viaje viaje in viajes)
                {
                    ViajeCard control = new ViajeCard(viaje);
                    control.Visible = true;
                    control.EvModificar += (id) => this.EvModificar?.Invoke(id);
                    control.EvEliminar += () => CargarCards();
                    flpViajes.Controls.Add(control);
                }
            }
        }
    }
}
