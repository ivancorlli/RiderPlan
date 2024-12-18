﻿using RaiderPlan.Properties;
using Raiderplan1;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using Wisej.Web;

namespace RaiderPlan.Sitio.Inicio
{
    public partial class winNuevoViaje : Wisej.Web.Form
    {
        public delegate void Aceptar(long viajeId);
        public event Aceptar EvAceptar;
        public delegate void Salir();
        public event Salir EvSalir;
        private Image _Image = null;
        private Viaje _viaje = null;

        //Cosntructor
        public winNuevoViaje()
        {
            InitializeComponent();
            dtpFechaSalida.TodayDate = DateTime.Now;
            dtpFechaSalida.MinDate = DateTime.Now;
            dtpFechaSalida.MaxDate = DateTime.Now.AddYears(50);
            dtpFechaLlegada.TodayDate = DateTime.Now.AddDays(1);
            dtpFechaLlegada.MinDate = dtpFechaSalida.MinDate;
        }
        public winNuevoViaje(long id)
        {
            InitializeComponent();
            dtpFechaSalida.TodayDate = DateTime.Now;
            _viaje = new Viaje();
            _viaje.Fill(id);
            this.Load += WinNuevoViaje_Load;
        }

        private void WinNuevoViaje_Load(object sender, EventArgs e)
        {
            if(_viaje != null)
            {
                label2.Text = "Modificar Viaje";
                //recupero imagen de perfil
                if (_viaje.ViajeRow.IsViajeImagenNull() || _viaje.ViajeImagen.Trim() == "")
                {
                    pbImagenPerfil.ImageSource = Path.Combine("Resource", "lib", "Imagenes", "mapa.png");
                }
                else
                {
                    pbImagenPerfil.ImageSource = Path.Combine("Resource", "lib", "Viajes", _viaje.ViajeImagen);
                }
                txtNombre.Text = _viaje.ViajeNombre;
                if (!_viaje.ViajeRow.IsFechaSalidaProgramadaNull())
                {
                    dtpFechaSalida.MinDate = _viaje.FechaSalidaProgramada.Date;
                    dtpFechaSalida.Value = _viaje.FechaSalidaProgramada.Date;
                }
                else
                {
                    dtpFechaSalida.MinDate = DateTime.Now;
                }
                dtpFechaLlegada.MinDate = dtpFechaSalida.MinDate;
                if (!_viaje.ViajeRow.IsFechaLlegadaProgramadaNull())
                {
                    if(_viaje.FechaLlegadaProgramada.Date < dtpFechaSalida.MinDate)
                    {
                        dtpFechaLlegada.Value = dtpFechaSalida.MinDate;
                    }
                    else
                    {
                        dtpFechaLlegada.Value = _viaje.FechaLlegadaProgramada.Date;
                    }
                }
                else
                {
                    dtpFechaLlegada.TodayDate = DateTime.Now.AddDays(1);
                }
                if (!_viaje.ViajeRow.IsMotocilcetaMarcaNull())
                {
                    txtMarca.Text = _viaje.MotocilcetaMarca;
                }
                if (!_viaje.ViajeRow.IsMotociletaModeloNull())
                {
                    txtMotocicleta.Text = _viaje.MotociletaModelo;
                }
            }
            else
            {
                label2.Text = "Nuevo Viaje";
            }
        }
        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.EvSalir?.Invoke();
        }
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                lblMansaje.Text = "Debe ingresar el nombre del viaje";
                lblMansaje.Visible = true;
                return;
            }
            Viaje NuevoViaje;
            if(_viaje != null)
            {
                NuevoViaje = _viaje;
            }
            else
            {
                NuevoViaje = new Viaje();
            }
            NuevoViaje.UsuarioID = (int)Application.Session.UsuarioID;
            NuevoViaje.ViajeNombre = txtNombre.Text;
            if (dtpFechaSalida.Value != new DateTime(0001, 1, 1))
            {
                NuevoViaje.FechaSalidaProgramada = dtpFechaSalida.Value;
            }
            else
            {
                NuevoViaje.ViajeRow.SetFechaSalidaEfectivaNull();
            }
            if (dtpFechaLlegada.Value != new DateTime(0001, 1, 1))
            {
                NuevoViaje.FechaLlegadaProgramada = dtpFechaLlegada.Value;
            }
            else
            {
                NuevoViaje.ViajeRow.SetFechaLlegadaProgramadaNull();
            }
            if (NuevoViaje.FechaLlegadaProgramada < NuevoViaje.FechaSalidaProgramada)
            {
                lblMansaje.Text = "La fecha de llegada no puede ser anterior a la de salida";
                lblMansaje.Visible = true;
                return;
            }
            if (!string.IsNullOrEmpty(txtMotocicleta.Text))
            {
                NuevoViaje.MotociletaModelo = txtMotocicleta.Text;
            }
            if (!string.IsNullOrEmpty(txtMarca.Text))
            {
                NuevoViaje.MotocilcetaMarca = txtMarca.Text;
            }
            if (_Image != null)
            {
                NuevoViaje.ViajeImagen = _Image.Tag.ToString();
                GuardarImagen(_Image);
            }
            NuevoViaje.ViajeEstado = "A";
            NuevoViaje.ViajeFechaCreacion = DateTime.Now;
            try
            {

                this.Close();
                NuevoViaje.Update();
                EvAceptar.Invoke(NuevoViaje.ViajeID);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al crear viaje");
            }

        }
        private void upload1_Uploaded(object sender, UploadedEventArgs e)
        {
            CargaArchivo(e.Files);
        }
        private void CargaArchivo(Wisej.Core.HttpFileCollection files)
        {
            if (files == null)
                return;

            if (files.Count == 0)
            {
                this.pbImagenPerfil.Image = null;
            }
            else
            {
                _Image = RecuperaImagenStream(files[0].InputStream);
                this.pbImagenPerfil.Image = _Image;
                // Obtener el formato de imagen
                ImageFormat formato = _Image.RawFormat;
                ImageCodecInfo codecInfo = ImageCodecInfo.GetImageDecoders().FirstOrDefault(codec => codec.FormatID == formato.Guid);

                // Obtener la extensión del formato
                string extension = codecInfo?.FilenameExtension?.Split(';')?.FirstOrDefault();
                string nombreImagen = (Guid.NewGuid().ToString()) + extension.Replace("*", "");
                _Image.Tag = nombreImagen;
            }
        }
        private Image RecuperaImagenStream(Stream stream)
        {
            MemoryStream mem = new MemoryStream();
            stream.CopyTo(mem, 1024);
            mem.Position = 0;
            return Image.FromStream(mem);
        }
        private void GuardarImagen(Image pImagen)
        {
            string rutaGuardar = Path.Combine(Application.StartupPath,"Resource", "lib", "Viajes", pImagen.Tag.ToString()); //donde se va a guardar la imagen 
            string folderPath = Path.GetDirectoryName(rutaGuardar); // Get the directory from the full path
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath); // Create the directory if it doesn't exist
            }
            // Convierte el objeto Image en un arreglo de bytes
            byte[] arregloBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                pImagen.Save(ms, ImageFormat.Jpeg); // Puedes ajustar el formato de la imagen según tus necesidades
                arregloBytes = ms.ToArray();
            }
            // Guarda el arreglo de bytes en un archivo en tu proyecto Wisej
            File.WriteAllBytes(rutaGuardar, arregloBytes);

        }
    }
}
