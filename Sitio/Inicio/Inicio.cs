using RaiderPlan.Sitio.EspacioPersonal;
using Raiderplan1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Wisej.Web;

namespace RaiderPlan.Sitio.Inicio
{
    public partial class Inicio : Wisej.Web.UserControl
    {
        public event EventHandler EvAutenticado;
        public Inicio()
        {
            InitializeComponent();
            this.Load += Inicio_Load;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ViajesPublicosCollection _viajes = new ViajesPublicosCollection();
            _viajes.Fill();
            List<ViajesPublicos> viajes = new List<ViajesPublicos>();
            foreach(ViajesPublicos v in _viajes)
            {
                    viajes.Add(v);
            }

            foreach(ViajesPublicos v in viajes.Take(5).ToList())
            {
                string nombre= v.ViajeNombre;
                string imagen = string.Empty;
                int meGustas = 0;
                int descargas = 0;
                if (!v.ViajeRow.IsViajeImagenNull())
                {
                    imagen = Path.Combine("Resource", "lib", "Viajes", v.ViajeImagen);
                }
                string origen;
                if (!v.ViajeRow.IsLugarPartidaNull())
                {
                    origen = v.LugarPartida;
                }
                else
                {
                    origen = " No definido";
                }
                string destino;
                if (!v.ViajeRow.IsLugarllegadaNull())
                {
                    destino = v.Lugarllegada;
                }
                else
                {
                    destino = " No definido";
                }
                if (!v.ViajeRow.IsViajeMeGustasNull())
                {
                    meGustas = v.ViajeMeGustas;
                }
                if (!v.ViajeRow.IsViajeDescargasNull())
                {
                    descargas = v.ViajeDescargas;
                }
                ViajeCardPublico card = new ViajeCardPublico(nombre,imagen,origen,destino,meGustas,descargas,v.UsuarioID,v.ViajeID);
                card.Margin = new Padding(8,10,8,10);
                card.EvVerMapa += (id) =>
                {
                    Application.Session.ViajeExplorar = id;
                    label1_Click(this, EventArgs.Empty);
                };
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void ElijeAceptar()
        {
            EvAutenticado?.Invoke(this, EventArgs.Empty);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            winRegistro winRegistro = new winRegistro();
            winRegistro.StartPosition = FormStartPosition.CenterScreen;
            winRegistro.evRegistrado += ManejaValidaCodigo;
            winRegistro.evCancel += ManejaAbreLogin;
            winRegistro.ShowDialog();
        }

        private void ManejaAbreLogin()
        {
            label1_Click(this, EventArgs.Empty);
        }

        private void ManejaValidaCodigo(int userId)
        {
            // creo la ventana para el ingreso del codigo de validacion
            winValidacionCodigo ventana = new winValidacionCodigo(userId);
            ventana.evCodigoCorrecto += manejaCodigoCorrecto;
            ventana.StartPosition = FormStartPosition.CenterScreen;
            ventana.ShowDialog();
        }

        private void manejaCodigoCorrecto()
        {
            //disparo el evento para terminar el inicio y cargar el espacio personal del usuario
            EvAutenticado?.Invoke(this, EventArgs.Empty);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            winLogin winLogin = new winLogin();
            winLogin.EvAceptar += ElijeAceptar;
            winLogin.evValidar += ManejaValidaCodigo;
            winLogin.evCrearCuenta += ManejaCrearCuenta;
            winLogin.evRecuperaCuenta += ManejarRecpuerarCuenta;
            winLogin.evValidaCodigoRecuperacion += ValidaCodigo;
            winLogin.StartPosition = FormStartPosition.CenterScreen;
            winLogin.ShowDialog();
        }

        private void ManejarRecpuerarCuenta()
        {
            winRecuperaCuenta form = new winRecuperaCuenta();
            form.EvRecupera += ValidaCodigo;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void ValidaCodigo(int id)
        {
            winCodigoRecuperacion form = new winCodigoRecuperacion(id)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            form.EvClose += AbreLogin;
            form.ShowDialog();
        }

        private void AbreLogin(string pEmailUsuario)
        {
            winLogin winLogin = new winLogin(pEmailUsuario);
            winLogin.EvAceptar += ElijeAceptar;
            winLogin.evValidar += ManejaValidaCodigo;
            winLogin.evCrearCuenta += ManejaCrearCuenta;
            winLogin.evRecuperaCuenta += ManejarRecpuerarCuenta;
            winLogin.evValidaCodigoRecuperacion += ValidaCodigo;
            winLogin.StartPosition = FormStartPosition.CenterScreen;
            winLogin.ShowDialog();
        }

        private void ManejaCrearCuenta()
        {
            btnRegistro_Click(this, EventArgs.Empty);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1_Click(sender, e);
        }
    }
}
