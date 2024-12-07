using RaiderPlan.Sitio.Inicio;
using RaiderPlan.Sitio.Utiles;
using Raiderplan1;
using System;
using System.IO;
using Wisej.Web;

namespace RaiderPlan.Sitio.EspacioPersonal
{
    public partial class ViajeCardEliminado : Wisej.Web.UserControl
    {
        public delegate void Recuperar();
        public event Recuperar EvRecuperar;
        private ViajesEliminados _viaje = null;

        public ViajeCardEliminado(ViajesEliminados viaje)
        {
            InitializeComponent();
            _viaje = viaje;
            this.Load += Viaje_Load;
        }

        private void Viaje_Load(object sender, EventArgs e)
        {
            if (_viaje != null)
            {
                viajeNombre.Text = _viaje.ViajeNombre;
                if (!_viaje.ViajeRow.IsViajeImagenNull())
                {
                    pbImagenViaje.ImageSource = Path.Combine("Resource", "lib", "Viajes", _viaje.ViajeImagen);
                    pbImagenViaje.SizeMode = PictureBoxSizeMode.Cover;
                    pbImagenViaje.Padding = new Padding(0);
                }
                if (!_viaje.ViajeRow.IsFechaSalidaProgramadaNull())
                {
                    fechaViaje.Text = _viaje.FechaSalidaProgramada.ToShortDateString();
                }
                if (!_viaje.ViajeRow.IsLugarPartidaNull())
                {
                    label1.Text = _viaje.LugarPartida;
                }
                else
                {
                    label1.Text = " No definido";
                }
                if (!_viaje.ViajeRow.IsLugarllegadaNull())
                {
                    label2.Text = _viaje.Lugarllegada;
                }
                else
                {
                    label2.Text = " No definido";
                }
                if (!_viaje.ViajeRow.IsViajeMeGustasNull())
                {
                    label3.Text = _viaje.ViajeMeGustas.ToString();
                }
                else
                {
                    label3.Text = "0";

                }
                if (!_viaje.ViajeRow.IsViajeDescargasNull())
                {
                    label4.Text = _viaje.ViajeDescargas.ToString();
                }
                else
                {
                    label4.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("Error al cargar viaje");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Viaje viaje = new Viaje();
                viaje.Fill(_viaje.ViajeID);
                viaje.ViajeEstado = "A";
                viaje.Update();
                this.EvRecuperar?.Invoke();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al recuperar viaje");
            }
            }
    }
}