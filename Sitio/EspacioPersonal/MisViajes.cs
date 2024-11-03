using System;
using System.Collections.Generic;
using System.Linq;
using RaiderPlan.Sitio.Inicio;
using Raiderplan1;
using Wisej.Web;

namespace RaiderPlan.Sitio.EspacioPersonal
{
    public partial class MisViajes : Wisej.Web.UserControl
    {
        public delegate void VerMapa(long id);
        public event VerMapa EvVerMapa;
        public delegate void Iniciar(long id);
        public event Iniciar EvIniciarViaje;
        public delegate void Actualizar();
        public event Actualizar EvActualizar;
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
            int count = 0;
            ViajesEnPlanificacionCollection pla = new ViajesEnPlanificacionCollection();
            pla.Fill(Application.Session.UsuarioID);
            count += pla.Count;
            foreach (ViajesEnPlanificacion v in pla)
            {
                ViajeCard card = new ViajeCard(v);
                card.EvEliminar += () =>
                {
                    CargarViajes();
                };
                card.EvIniciar += (id) =>this.EvIniciarViaje(id);
                card.EvVerMapa += (id) => this.EvVerMapa(id);
                card.EvEliminar += () =>
                {
                    CargarViajes();
                    this.EvActualizar.Invoke();
                };
                card.EvActualizar += () => CargarViajes();
                card.Margin = new Padding(8,0,8,0);
                card.BringToFront();
                pnlViajes.Controls.Add(card);
            }
            ViajesRealizadosCollection rea = new ViajesRealizadosCollection();
            rea.Fill(Application.Session.UsuarioID);
            count += rea.Count;
            foreach (ViajesRealizados v in rea)
            {
                ViajeCardRealizado card = new ViajeCardRealizado(v);
                card.EvVerMapa += (id) => this.EvVerMapa(id);
                card.EvActualizar += () => CargarViajes();
                card.BringToFront();
                card.Margin = new Padding(8, 0, 8, 0);
                pnlViajes.Controls.Add(card);
            }
            if(count > 0)
            {
                pnlSinViajes.Visible = false;
                pnlViajes.Visible = true;
            }
            else
            {
                pnlSinViajes.Visible = true;
                pnlViajes.Visible = false;
            }
        }

        private void btnCrearViaje_Click(object sender, EventArgs e)
        {
            winNuevoViaje popup = new winNuevoViaje();
            popup.EvAceptar += (id) => this.EvVerMapa(id);
            popup.ShowDialog();
        }

        private void htmlPanel1_ElementClick(object sender, HtmlPanelElementClickArgs e)
        {

        }
    }
}
