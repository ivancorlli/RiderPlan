using RaiderPlan.Sitio.Viajes;
using Raiderplan1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Wisej.Web;

namespace RaiderPlan.Sitio.EspacioPersonal
{
    public partial class Explorar : Wisej.Web.UserControl
    {
        public delegate void AbrirMapa(long id);
        public event AbrirMapa EvAbrirMapa;
        public Explorar()
        {
            InitializeComponent();
            this.Load += Explorar_Load;
        }

        private void Explorar_Load(object sender, EventArgs e)
        {
            Search();
        }
    
        private void ManejaBuscarViajes()
        {
            pnlViajes.Controls.Clear();
            ViajesXUsuarioXOrigenXDestinoCollection _viajes = new ViajesXUsuarioXOrigenXDestinoCollection();
            _viajes.Fill(0,txtOrigen.Text,txtDestino.Text);
  

            if(_viajes.Count > 0)
            {
                long count = _viajes.Count > 25 ? 25 : _viajes.Count - 1;
                for (int i = 0; i <= count ; i++)
                {
                    ViajesXUsuarioXOrigenXDestino v = _viajes[i];
                    string nombre = v.ViajeNombre;
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
                    ViajeCardPublico card = new ViajeCardPublico(nombre, imagen, origen, destino, meGustas, descargas, v.UsuarioID, v.ViajeID);
                    card.Margin = new Wisej.Web.Padding(8, 10, 8, 10);
                    card.EvVerMapa += (id) => EvAbrirMapa.Invoke(id);
                    pnlViajes.Controls.Add(card);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtDestino_TextChanged(object sender, EventArgs e)
        {
                Search();
        }

        private void txtOrigen_TextChanged(object sender, EventArgs e)
        {
                Search();
        }

        private void Search()
        {
            htmlLoader.Visible = true;
            htmlLoader.Dock = DockStyle.Fill;
            pnlViajes.Visible = false;
            ManejaBuscarViajes();
            htmlLoader.Visible = false;
            htmlLoader.Dock = DockStyle.Top;
            pnlViajes.Visible = true;
        }
    }
}
