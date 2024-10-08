using RaiderPlan.Sitio.Utiles;
using Raiderplan1;
using System;
using System.IO;
using Wisej.Web;

namespace RaiderPlan.Sitio.EspacioPersonal
{
    public partial class ViajeCardRealizado : Wisej.Web.UserControl
    {
        public delegate void Ver(long id);
        public event Ver EvVer;
        private ViajesRealizados _viaje = null;

        public ViajeCardRealizado(ViajesRealizados viaje)
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


        private void btnVer_Click(object sender, EventArgs e)
        {
            this.EvVer?.Invoke(_viaje.ViajeID);
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            UtilidadesViaje.GenerarGpx(_viaje.ViajeID);
        }
    }
}
