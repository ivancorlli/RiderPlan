﻿using Raiderplan1;
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
        private ViajesEnProgreso _viajeActual;
        public EspacioPersonalPaneles()
        {
            InitializeComponent();
            this.Load += CargarPaneles;
        }

        private void CargarPaneles(object sender, EventArgs e)
        {
            CargarPanelEliminados();
            if (Application.Session.ViajeExplorar == null || Application.Session.ViajeExplorar <= 0)
            {
                CargarPanelViajeActual();
            }
            if (Application.Session.ViajeExplorar != null && Application.Session.ViajeExplorar > 0)
            {
                ManejaAbrirViajePublico(Application.Session.ViajeExplorar);
            }
            else
            {
                LblExplorar_Click(sender, e);
            }
        }
        private void LblMisViajes_Click(object sender, EventArgs e)
        {
            if (pnlViajeActual.Visible == false)
            {
                CargarPanelViajeActual();
            }
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
            if (pnlViajeActual.Visible == false)
            {
                CargarPanelViajeActual();
            }
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            Explorar explorar = new Explorar();
            explorar.Dock = DockStyle.Fill;
            explorar.EvAbrirMapa += (id) => ManejaAbrirViajePublico(id);
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
                _viajeActual = actual[0];
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
            if(pnlViajeActual.Visible == false)
            {
                CargarPanelViajeActual();
            }
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
        private void ManejaAbrirViajePublico(long id)
        {
            pnlViajeActual.Visible = false;
            Application.Session.ViajeID = id;
            ViajePublico viaje = new ViajePublico();
            viaje.EvSalir += () =>
            {
                Application.Session.ViajeExplorar = null;
                pnlContent.Controls.Clear();
                LblExplorar_Click(new { }, EventArgs.Empty);
            };
            viaje.EvClonar += (x) =>
            {
                Application.Session.ViajeExplorar = null;
                pnlContent.Controls.Clear();
                LblMisViajes_Click(new { }, EventArgs.Empty);
            };
            viaje.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(viaje);
        }

        
        private void panel5_PanelCollapsed(object sender, EventArgs e)
        {
            this.EvVerMapa.Invoke(this._viajeActual.ViajeID);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.EvVerMapa.Invoke(this._viajeActual.ViajeID);
        }

        private void lblContinuarViaje_Click(object sender, EventArgs e)
        {
            this.EvVerMapa.Invoke(this._viajeActual.ViajeID);
        }

        private void lblViajeNombre_Click(object sender, EventArgs e)
        {
            this.EvVerMapa.Invoke(this._viajeActual.ViajeID);
        }
    }
}
