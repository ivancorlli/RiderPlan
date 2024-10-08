using Raiderplan1;
using System;
using Wisej.Web;

namespace RaiderPlan.Sitio.Inicio
{
    public partial class winComentario : Wisej.Web.Form
    {
        public delegate void Actualizar();
        public event Actualizar EvActualizar;
        private long _viajeId;
        private int _trayectoId;
        private TrayectoViaje _trayecto = null;
        private ComentarioViaje _comentario = null;

        //Cosntructor
        public winComentario(long viajeId, int trayectoId)
        {
            InitializeComponent();
            _viajeId = viajeId;
            _trayectoId = trayectoId;
            this.Load += (e, x) =>
            {
                _trayecto = new TrayectoViaje();
                _trayecto.Fill(trayectoId);
                txtTitulo.Text = _trayecto.TrayectoOrigen != null && _trayecto.TrayectoOrigen != string.Empty ? _trayecto.TrayectoOrigen : $"Punto {_trayecto.Orden}";
                if (!_trayecto.TrayectoViajeRow.IsCombustibleConsumidoNull())
                {
                    textBox1.Text = _trayecto.CombustibleConsumido.ToString("F2");
                }

                if (!_trayecto.TrayectoViajeRow.IsEstadoCarreteraNull())
                {
                    textBox2.Text = _trayecto.EstadoCarretera;
                }

                TrayectoComentarioCollection comentario = new TrayectoComentarioCollection();
                comentario.Fill(viajeId, trayectoId);
                if (comentario.Count > 0)
                {
                    _comentario = new ComentarioViaje();
                    _comentario.Fill(comentario[0].ComentarioViajeID);
                    textBox3.Text = _comentario.ComentarioTexto;
                }
            };
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal d = 0;
                decimal.TryParse(textBox1.Text, out d);
                _trayecto.CombustibleConsumido = d;
                _trayecto.EstadoCarretera = textBox2.Text;
                if (_comentario != null)
                {
                    _comentario.ComentarioTexto = textBox3.Text;
                    _comentario.ComentarioLatitud = _trayecto.TayectoLatitudOrigen;
                    _comentario.ComentarioLongitud = _trayecto.TrayectoLongitudOrigen;
                }
                else
                {
                    _comentario = new ComentarioViaje();
                    _comentario.ViajeID = _viajeId;
                    _comentario.CVTrayectoID = _trayectoId;
                    _comentario.ComentarioTexto = textBox3.Text;
                    _comentario.ComentarioLatitud = _trayecto.TayectoLatitudOrigen;
                    _comentario.ComentarioLongitud = _trayecto.TrayectoLongitudOrigen;
                }
                _trayecto.Update();
                _comentario.Update();
                Close();
                EvActualizar?.Invoke();
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error al guardar datos");
            }
        }
    }
}
