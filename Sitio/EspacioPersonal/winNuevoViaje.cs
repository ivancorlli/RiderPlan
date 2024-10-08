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
        public delegate void EvCancelar();
        public event EvCancelar evCancelar;
        public delegate void Aceptar(long viajeId);
        public event Aceptar EvAceptar;
        private Image _Image = null;

        //Cosntructor
        public winNuevoViaje()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            evCancelar?.Invoke();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                lblMansaje.Text = "Debe ingresar el nombre del viaje";
                lblMansaje.Visible = true;
                return;
            }
            Viaje NuevoViaje = new Viaje()
            {
                UsuarioID = (int)Application.Session.UsuarioID,
                ViajeNombre = txtNombre.Text
            };
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
            string rutaGuardar = @"Resource\lib\Viajes\" + pImagen.Tag.ToString(); //donde se va a guardar la imagen 

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
