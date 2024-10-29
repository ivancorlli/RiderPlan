﻿using RaiderPlan.Sitio.Inicio;
using Raiderplan1;
using System;
using System.IO;
using Wisej.Web;

namespace RaiderPlan.Sitio.EspacioPersonal
{
    public partial class HomePage : Wisej.Web.UserControl
    {
        public delegate void Salir();
        public event Salir EvSalir;
        private Persona _Persona;
        private Usuario _Usuario;
        public HomePage()
        {
            InitializeComponent();
            this.Load += EspacioPersonal_Load;
        }
        private void EspacioPersonal_Load(object sender, EventArgs e)
        {
            MuestraDatos();
            ViajesEnProgresoCollection actual = new ViajesEnProgresoCollection();
            actual.Fill(Application.Session.UsuarioID);
            CargarEspacioPersonal();
        }
        private void MuestraDatos()
        {
            //Recupero Usuario y persona
            _Usuario = new Usuario();
            _Usuario.Fill((int)Application.Session.UsuarioID);

            _Persona = new Persona();
            _Persona.Fill(_Usuario.PersonaID);

            lblUsuarioNombre.Text = $"@{_Usuario.UsuarioNombre}";
            lblNombre.Text = $"{_Persona.PersonaNombre} {_Persona.PersonaApellido}";
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
        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            EvSalir?.Invoke();
        }
        private void Perfil_EvACtualizar()
        {
            MuestraDatos();
        }
        private void LblUsuarioNombre_Click_1(object sender, EventArgs e)
        {
            winPerfil perfil = new winPerfil(_Usuario, _Persona);
            perfil.EvACtualizar += Perfil_EvACtualizar;
            perfil.CenterToParent();
            perfil.ShowDialog();
        }
        private void LblNombre_Click(object sender, EventArgs e)
        {
            winPerfil perfil = new winPerfil(_Usuario, _Persona);
            perfil.EvACtualizar += Perfil_EvACtualizar;
            perfil.CenterToParent();
            perfil.ShowDialog();
        }
        private void PbUsuario_Click_1(object sender, EventArgs e)
        {
            winPerfil perfil = new winPerfil(_Usuario, _Persona);
            perfil.EvACtualizar += Perfil_EvACtualizar;
            perfil.CenterToParent();
            perfil.ShowDialog();
        }
        private void BtnCrearViaje_Click_1(object sender, EventArgs e)
        {
            winNuevoViaje popup = new winNuevoViaje();
            popup.EvAceptar += CargarNuevoViaje;
            popup.ShowDialog();
        }
        private void CargarEspacioPersonal()
        {
            EspacioPersonalPaneles paneles = new EspacioPersonalPaneles();
            paneles.Dock = DockStyle.Fill;
            paneles.EvModificarViaje += (id) =>
            {
                TrayectoViajeCollection trayectos = new TrayectoViajeCollection();
                trayectos.FillByViajeID(id);
                if(trayectos.Count > 0)
                {
                    CargarViajeEnProgreso(id);
                }
                else
                {
                    CargarNuevoViaje(id);
                }
            };
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(paneles);
        }
        private void CargarNuevoViaje(long id)
        {
            // Cargo variable de sesion para manejar en el mapa
            Application.Session.ViajeID = id;
            // Configuro Cabecera
            btnCrearViaje.Visible = false;
            //btnInicio.Visible = true;
            Viajes.Viajes pnl = new Viajes.Viajes();
            pnl.EvSalir += () =>
            {
                CargarEspacioPersonal();
            };
            pnl.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(pnl);
        }
        private void CargarViajeEnProgreso(long id)
        {
            // Cargo variable de sesion para manejar en el mapa
            Application.Session.ViajeID = id;
            // Configuro Cabecera
            btnCrearViaje.Visible = false;
            //btnInicio.Visible = true;
            ViajeEnProgreso pnl = new ViajeEnProgreso();
            pnl.EvSalir += () =>
            {
                CargarEspacioPersonal();
            };
            pnl.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(pnl);
        }
    }
}