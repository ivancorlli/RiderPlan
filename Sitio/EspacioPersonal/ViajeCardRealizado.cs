using RaiderPlan.Sitio.Inicio;
using RaiderPlan.Sitio.Utiles;
using Raiderplan1;
using System;
using System.IO;
using Wisej.Web;

namespace RaiderPlan.Sitio.EspacioPersonal
{
    public partial class ViajeCardRealizado : Wisej.Web.UserControl
    {
        public delegate void VerMapa(long id);
        public event VerMapa EvVerMapa;
        public delegate void Actualizar();
        public event Actualizar EvActualizar;
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
                    pbImagenViaje.SizeMode = PictureBoxSizeMode.Zoom;
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
                    label3.Text = _viaje.ViajeDescargas.ToString();
                }
                else
                {
                    label4.Text = "0";
                }
                MenuItem publicar = new MenuItem
                {
                    Name = "publicar",
                    Text = "Publicar"
                };

                MenuItem privar = new MenuItem
                {
                    Name = "privar",
                    Text = "Restringir"
                };

                if (!_viaje.ViajeRow.IsViajePrivadoNull())
                {
                    if (_viaje.ViajePrivado == "S")
                    {
                        pictureBox7.Visible = true;
                        contextMenu1.MenuItems.Add(publicar);
                    }
                    else
                    {
                        contextMenu1.MenuItems.Add(privar);
                    }
                }
                else
                {
                    contextMenu1.MenuItems.Add(privar);
                }
            }
            else
            {
                MessageBox.Show("Error al cargar viaje");
            }
        }

        private void ContextMenu1_MenuItemClicked(object sender, MenuItemEventArgs e)
        {
            switch (e.MenuItem.Name)
            {
                case "mapa":
                    this.EvVerMapa(_viaje.ViajeID);
                    break;
                case "descargar":
                    UtilidadesViaje.GenerarGpx(_viaje.ViajeID);
                    break;
                case "publicar":
                    Viaje v = new Viaje();
                    v.Fill(_viaje.ViajeID);
                    v.ViajePrivado = "N";
                    v.Update();
                    this.EvActualizar.Invoke();
                    break;
                case "privar":
                    Viaje vi = new Viaje();
                    vi.Fill(_viaje.ViajeID);
                    vi.ViajePrivado = "S";
                    vi.Update();
                    this.EvActualizar.Invoke();
                    break;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var mousePosition = pictureBox6.PointToClient(MousePosition);

            // Show the context menu at the mouse position
            contextMenu1.Show(pictureBox6, mousePosition);
        }
    }
}