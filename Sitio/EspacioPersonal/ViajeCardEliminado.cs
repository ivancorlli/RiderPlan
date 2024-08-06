using RaiderPlan.Sitio.Inicio;
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
        public delegate void Eliminar();
        public event Eliminar EvEliminar;
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
                }
                if (!_viaje.ViajeRow.IsFechaSalidaProgramadaNull())
                {
                    fechaViaje.Text = _viaje.FechaSalidaProgramada.ToShortDateString();
                }
                else
                {
                    fechaViaje.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Error al cargar viaje");
            }
        }


        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Viaje viaje = new Viaje();
                viaje.Fill(_viaje.ViajeID);
                TrayectoViajeCollection trayectos = new TrayectoViajeCollection();
                trayectos.FillByViajeID(viaje.ViajeID);
                if (trayectos.Count > 0)
                {
                    foreach (TrayectoViaje trayecto in trayectos)
                    {
                        trayecto.Delete();
                    }
                }
                viaje.Delete();
                this.EvEliminar?.Invoke();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar viaje");
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
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
