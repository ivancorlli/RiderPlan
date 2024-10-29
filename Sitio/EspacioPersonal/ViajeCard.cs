using RaiderPlan.Sitio.Inicio;
using RaiderPlan.Sitio.Utiles;
using Raiderplan1;
using System;
using System.IO;
using Wisej.Web;

namespace RaiderPlan.Sitio.EspacioPersonal
{
    public partial class ViajeCard : Wisej.Web.UserControl
    {
        public delegate void Modificar(long id);
        public event Modificar EvModificar;
        public delegate void Eliminar();
        public event Eliminar EvEliminar;
        public delegate void Iniciar(long id);
        public event Iniciar EvIniciar;
        private ViajesEnPlanificacion _viaje = null;

        public ViajeCard(ViajesEnPlanificacion viaje)
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
                label3.Text = "0";
                label4.Text = "0";
            }
            else
            {
                MessageBox.Show("Error al cargar viaje");
            }
        }

        private void Delete()
        {
            try
            {
                Raiderplan1.Viaje viaje = new Raiderplan1.Viaje();
                viaje.Fill(_viaje.ViajeID);
                viaje.ViajeEstado = "Z";
                viaje.Update();
                this.EvEliminar?.Invoke();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar viaje");
            }
        }

        private void Init()
        {
            ViajesEnProgresoCollection viaje = new ViajesEnProgresoCollection();
            viaje.Fill(Application.Session.UsuarioID);
            if (viaje.Count > 0)
            {
                MessageBox.Show("No puedes tener mas de un viaje iniciado en simultaneo.","", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                winIniciaViaje form = new winIniciaViaje(_viaje.ViajeID);
                form.EvIniciar += (id) => this.EvIniciar?.Invoke(id);
                form.ShowDialog();
            }
        }

        private void Download()
        {
            UtilidadesViaje.GenerarGpx(_viaje.ViajeID);
        }

        private void ContextMenu1_MenuItemClicked(object sender, MenuItemEventArgs e)
        {
            switch (e.MenuItem.Name)
            {
                case "ver":
                    break;
                case "modificar":
                    this.EvModificar(_viaje.ViajeID);
                    break;
                case "iniciar":
                    Init();
                    break;
                case "descargar":
                    Download();
                    break;
                case "eliminar":
                    Delete();
                    break;
            }
        }
    }
}
