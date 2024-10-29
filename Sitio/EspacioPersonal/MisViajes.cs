using System;
using System.Collections.Generic;
using System.Linq;
using Raiderplan1;
using Wisej.Web;

namespace RaiderPlan.Sitio.EspacioPersonal
{
    public partial class MisViajes : Wisej.Web.UserControl
    {
        public delegate void Modificar(long id);
        public event Modificar EvModificarViaje;
        public delegate void Iniciar(long id);
        public event Iniciar EvIniciarViaje;
        public MisViajes()
        {
            InitializeComponent();
            this.Load += MisViajesLoad;
        }
        private void MisViajesLoad(object sender, EventArgs e)
        {
            CargarViajes();
        }

        private void CargarViajes()
        {
            pnlViajes.Controls.Clear();
            ViajesEnPlanificacionCollection pla = new ViajesEnPlanificacionCollection();
            pla.Fill(Application.Session.UsuarioID);
            foreach (ViajesEnPlanificacion v in pla)
            {
                ViajeCard card = new ViajeCard(v);
                card.EvEliminar += () =>
                {
                    CargarViajes();
                };
                card.EvIniciar += (id) =>this.EvIniciarViaje(id);
                card.EvModificar += (id) => this.EvModificarViaje(id);
                card.BringToFront();
                pnlViajes.Controls.Add(card);
            }
            ViajesRealizadosCollection rea = new ViajesRealizadosCollection();
            rea.Fill(Application.Session.UsuarioID);
            foreach (ViajesRealizados v in rea)
            {
                ViajeCardRealizado card = new ViajeCardRealizado(v);
                card.BringToFront();
                pnlViajes.Controls.Add(card);
            }
        }
    }
}
