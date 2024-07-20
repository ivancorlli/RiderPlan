﻿using RaiderPlan.Sitio.Inicio;
using System;

namespace RaiderPlan.Sitio.EspacioPersonal
{
    public partial class NuevoViaje : Wisej.Web.UserControl
    {
        public delegate void Salir(NuevoViaje viaje);
        public event Salir CancelaNuevoViaje;
        public delegate void ViajeCreado(long id,string nombre);
        public event ViajeCreado NuevoViajeCreado;
        public NuevoViaje()
        {
            InitializeComponent();
            this.Load += NuevoViaje_Load;
        }

        public void NuevoViaje_Load(object sender, EventArgs e)
        {
            AbrirPopupNuevoViaje();
        }

        private void AbrirPopupNuevoViaje()
        {
            winNuevoViaje popup = new winNuevoViaje();
            popup.evCancelar += () =>
            {
                CancelaNuevoViaje?.Invoke(this);

            };
            popup.EvAceptar += (viaje) =>
            {
                NuevoViajeCreado?.Invoke(viaje.ViajeID,viaje.ViajeNombre);
            };
            popup.ShowDialog();
        }

    }
}