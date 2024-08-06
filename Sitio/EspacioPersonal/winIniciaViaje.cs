using Raiderplan1;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using Wisej.Web;

namespace RaiderPlan.Sitio.Inicio
{
    public partial class winIniciaViaje : Wisej.Web.Form
    {
        public delegate void EvCancelar();
        public event EvCancelar evCancelar;
        public delegate void Iniciar(long ViajeID);
        public event Iniciar EvIniciar;
        private Image _Image = null;
        private Viaje _viaje = null;

        //Cosntructor
        public winIniciaViaje(long viajeId)
        {
            InitializeComponent();
            if (viajeId > 0)
            {
                _viaje = new Viaje();
                _viaje.Fill(viajeId);
                lblViajeNombre.Text = _viaje.ViajeNombre;
                if (!_viaje.ViajeRow.IsFechaSalidaProgramadaNull())
                {
                    lblFechaProgramada.Text ="Fecha programada:" + _viaje.FechaSalidaProgramada.ToShortDateString();
                }
                else
                {
                    lblFechaProgramada.Visible = false;
                }
                if (_viaje.ViajeRow.IsViajeImagenNull() || _viaje.ViajeImagen.Trim() == "")
                {
                    pbImagenPerfil.ImageSource = Path.Combine("Resource", "lib", "Imagenes", "mapa.png");

                }
                else
                {
                    pbImagenPerfil.ImageSource = Path.Combine("Resource", "lib", "Viajes", _viaje.ViajeImagen);

                }
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            evCancelar?.Invoke();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {

            if (dtpFechaSalida.Value == new DateTime(0001, 1, 1))
            {
                lblMansaje.Text = "Debe indicar la fecha de salida.";
                lblMansaje.Visible = true;
            }
            else
            {
                try
                {
                    _viaje.FechaSalidaEfectiva = dtpFechaSalida.Value;

                    _viaje.ViajeEstado = "P";
                    _viaje.Update();
                    this.Close();
                    this.EvIniciar?.Invoke(_viaje.ViajeID);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al crear viaje");
                }
            }


        }


    }
}
