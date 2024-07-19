using RaiderPlan.Sitio.Inicio;
using Raiderplan1;
using System;
using System.IO;
using Wisej.Web;

namespace RaiderPlan.Sitio.EspacioPersonal
{
    public partial class ViajeCard : Wisej.Web.UserControl
    {
        public delegate void Modificar(long id, string nombre);
        public event Modificar EvModificar;
        public delegate void Ver(long id);
        public event Ver EvVer;
        public delegate void Eliminar();
        public event Eliminar EvEliminar;
        private Viaje _viaje = null;

        public ViajeCard(Raiderplan1.Viaje viaje)
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
                    pbImagenViaje.ImageSource = Path.Combine("Resource", "lib", "ImagenesUsuario", _viaje.ViajeImagen);
                }
                if (!_viaje.ViajeRow.IsFechaSalidaProgramadaNull())
                {
                    fechaViaje.Text = _viaje.FechaSalidaProgramada.ToLongDateString();
                }
            }
            else
            {
                MessageBox.Show("Error al cargar viaje");
            }
        }


        private void pbVer_Click(object sender, EventArgs e)
        {
            this.EvVer.Invoke(_viaje.ViajeID);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.EvModificar.Invoke(_viaje.ViajeID, _viaje.ViajeNombre);
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            this.EvEliminar.Invoke();
        }

        private void panel3_PanelCollapsed(object sender, EventArgs e)
        {
            winNuevoViaje popup = new winNuevoViaje();
            popup.Show();
        }
    }
}
