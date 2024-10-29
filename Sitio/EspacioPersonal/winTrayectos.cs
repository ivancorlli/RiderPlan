using Raiderplan1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using Wisej.Web;
using static Wisej.Web.ListViewItem;

namespace RaiderPlan.Sitio.Inicio
{
    public partial class winTrayectos : Wisej.Web.Form
    {

        private long _viajeId;

        //Cosntructor
        public winTrayectos(long viajeId)
        {
            InitializeComponent();
            this.Load += (e, x) =>
            {
                _viajeId = viajeId;
                Viaje viaje = new Viaje();
                viaje.Fill(_viajeId);
                label2.Text = viaje.ViajeNombre;
                CargarListView();
            };
        }

        private void CargarListView()
        {
            List<TrayectoViaje> _trayectos = new List<TrayectoViaje>();
            TrayectoViajeCollection trayectos = new TrayectoViajeCollection();
            trayectos.FillByViajeID(_viajeId);
            foreach (TrayectoViaje trayecto in trayectos)
            {
                _trayectos.Add(trayecto);
            }

            listView1.Items.Clear();
            var tra = _trayectos.GroupBy(x => x.EsOrigen);
            foreach (var x in tra)
            {
                string isOriginRoute = x.Key;
                var _tra = x.OrderBy(t => t.Orden).ToList();
                foreach (TrayectoViaje item in _tra)
                {
                    var nombre = string.Empty;
                    if (!item.TrayectoViajeRow.IsEsOrigenNull() && !string.IsNullOrEmpty(item.TrayectoOrigen))
                    {
                        if (isOriginRoute=="S")
                        {
                            nombre = item.TrayectoOrigen;
                        }
                        else
                        {
                            nombre = $"(alt) {item.TrayectoOrigen}";
                        }
                    }
                    else
                    {
                        if (isOriginRoute == "S")
                        {
                            nombre = $"Punto {item.Orden}";
                        }
                        else
                        {
                            nombre = $"(alt) Punto {item.Orden}";
                        }
                    }
                    ListViewItem lvItem = new ListViewItem(nombre);
                    lvItem.Tag = item.TrayectoViajeID;
                    if (!item.TrayectoViajeRow.IsTrayectokmNull())
                    {
                        lvItem.SubItems.Add($"{item.Trayectokm.ToString("F2")}");
                    }
                    else
                    {
                        lvItem.SubItems.Add("-");
                    }

                    if (!item.TrayectoViajeRow.IsTiempoEstimadoNull())
                    {
                        lvItem.SubItems.Add($"{item.TiempoEstimado.ToString("F2")} min");
                    }
                    else
                    {
                        lvItem.SubItems.Add("-");
                    }

                    if (!item.TrayectoViajeRow.IsCombustibleConsumidoNull())
                    {
                        lvItem.SubItems.Add($"{item.CombustibleConsumido.ToString("F2")} L");
                    }
                    else
                    {
                        lvItem.SubItems.Add("-");
                    }

                    if (!item.TrayectoViajeRow.IsEstadoCarreteraNull())
                    {
                        lvItem.SubItems.Add(item.EstadoCarretera);
                    }
                    else
                    {
                        lvItem.SubItems.Add("-");
                    }

                    TrayectoComentarioCollection comentario = new TrayectoComentarioCollection();
                    comentario.Fill(item.ViajeID, item.TrayectoViajeID);

                    if (comentario.Count > 0)
                    {
                        if (!comentario[0].ComentarioViajeRow.IsComentarioTextoNull())
                        {
                            lvItem.SubItems.Add(comentario[0].ComentarioTexto);
                        }
                        else
                        {
                            lvItem.SubItems.Add("-");
                        }
                    }
                listView1.Items.Add(lvItem);
                }
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                ListViewItem lvitem = listView1.SelectedItems[0];
                int trayectoId = int.Parse(lvitem.Tag.ToString());
                winComentario winComentario = new winComentario(_viajeId, trayectoId);
                winComentario.EvActualizar += () =>
                {
                    CargarListView();
                };
                winComentario.ShowDialog();
            }
        }
    }
}
