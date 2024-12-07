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
        public delegate void VerMapa(long id);
        public event VerMapa EvVerMapa;
        public delegate void Eliminar();
        public event Eliminar EvEliminar;
        public delegate void Actualizar();
        public event Actualizar EvActualizar;
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
                    label4.Text = _viaje.ViajeDescargas.ToString();
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
                    if(_viaje.ViajePrivado == "S")
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
                TrayectoViajeCollection trayectos = new TrayectoViajeCollection();
                trayectos.FillByViajeID(_viaje.ViajeID);
                if(trayectos.Count > 0)
                {

                Viaje iniciar = new Viaje();
                iniciar.Fill(_viaje.ViajeID);
                iniciar.FechaSalidaEfectiva = DateTime.Now;
                iniciar.ViajeEstado = "P";
                iniciar.Update();
                this.EvIniciar.Invoke(_viaje.ViajeID);
                }
                else
                {
                    MessageBox.Show("No puedes iniciar un viaje sin trayectos.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void Download()
        {
            UtilidadesViaje.GenerarGpx(_viaje.ViajeID);
        }

        private void See()
        {
            winNuevoViaje form = new winNuevoViaje(_viaje.ViajeID);
            form.EvAceptar += (id) =>
            {
                this.EvActualizar.Invoke();
            };
            form.ShowDialog();
        }
        private void ContextMenu1_MenuItemClicked(object sender, MenuItemEventArgs e)
        {
            switch (e.MenuItem.Name)
            {
                case "modificar":
                    See();
                    break;
                case "mapa":
                    this.EvVerMapa(_viaje.ViajeID);
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