using System;
using System.Text.RegularExpressions;
using Wisej.Web;
using Raiderplan1;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;

namespace RaiderPlan.Sitio.Inicio
{
    public partial class winPerfil : Wisej.Web.Form
    {
        private readonly Persona _Persona;
        private readonly Usuario _Usuario;
        private Image _ImagenPerfil = null;

        //Cosntructor
        public winPerfil(Usuario usuario, Persona persona)
        {
            InitializeComponent();
            _Persona = persona;
            _Usuario = usuario;
            CargaComboProvincia();
            CargaComboLocalidad();
            CargaPerfil();
        }


        private void CargaComboProvincia()
        {


            //cargo el combo box de provincia
            ProvinciaCollection _Provincia = new ProvinciaCollection();
            _Provincia.FillByPaisID(1);

            Provincia _ProvinciaVacia = new Provincia();
            _ProvinciaVacia.ProvinciaNombre = "";

            List<Provincia> _ProvinciaList = new List<Provincia>
            {
                _ProvinciaVacia
            };

            _ProvinciaList.AddRange(_Provincia.Cast<Provincia>().ToList());
            cbProvincia.DisplayMember = "ProvinciaNombre";
            cbProvincia.ValueMember = "ProvinciaID";
            cbProvincia.DataSource = _ProvinciaList;


        }

        private void CargaComboLocalidad()
        {

            if (cbProvincia.DataSource != null && (int)cbProvincia.SelectedValue > 0)
            {
                //Cargo el combo de localidad
                LocalidadCollection localidades = new LocalidadCollection();
                localidades.FillByProvinciaID((int)cbProvincia.SelectedValue);

                //creo localidad vacia 
                Localidad _LocalidadVacia = new Localidad();
                _LocalidadVacia.LocalidadNombre = "";

                //Agego a la lista
                List<Localidad> oListaLocalidade = new List<Localidad>
            {
               _LocalidadVacia
            };

                oListaLocalidade.AddRange(localidades.Cast<Localidad>().ToList());

                cbCiudad.DisplayMember = "LocalidadNombre";
                cbCiudad.ValueMember = "LoacaliadID";
                cbCiudad.DataSource = oListaLocalidade;

            }
        }

        private void CargaPerfil()
        {

            if (_Usuario != null)
            {
                label2.Text = _Usuario.UsuarioNombre;

                //recupero imagen de perfil
                if (_Persona.PersonaRow.IsImagenPerfilNull() || _Persona.ImagenPerfil.Trim() == "")
                {
                    string rutaImagen = Path.Combine(Application.StartupPath,"Resource","lib","Imagenes","iconousuario.png");
                    pbImagenPerfil.ImageSource = rutaImagen;

                }
                else
                {
                    pbImagenPerfil.ImageSource = Path.Combine(Application.StartupPath, "Resource", "lib", "Imagenes", _Persona.ImagenPerfil);

                }

                txtNombreUsuario.Text = _Usuario.UsuarioNombre;
                txtEmail.Text = _Usuario.UsuarioEmail;

                //cargo los datos de la persona en los textbox
                txtNombre.Text = _Persona.PersonaRow.IsPersonaNombreNull() ? "" : _Persona.PersonaNombre;
                txtApellido.Text = _Persona.PersonaRow.IsPersonaApellidoNull() ? "" : _Persona.PersonaApellido;

                //cargo fecha
                dtpFechaNacimiento.Value = _Persona.PersonaFechaNacimiento;
                //cargo el sexo
                switch (_Persona.PersonaSexo)
                {
                    case Sexo.Masculino:
                        cbSexo.SelectedItem = "Hombre";
                        break;
                    case Sexo.Femenino:
                        cbSexo.SelectedItem = "Mujer";
                        break;
                    default:
                        cbSexo.SelectedItem = "Otro";
                        break;
                }


                //controlo la localidad para determinar el pais la provincia y lalocalidad

                if (!_Persona.PersonaRow.IsLoacaliadIDNull())
                {
                    //tiene localidad cargada recupero la localidad paras obtner la provincia
                    //y relizar la carga del combobox
                    Localidad _LocalidadCargada = new Localidad();
                    _LocalidadCargada.Fill(_Persona.LoacaliadID);

                    //selecciono la provincia
                    cbProvincia.SelectedValue = _LocalidadCargada.ProvinciaID;
                    //selecciono la localidad
                    cbCiudad.SelectedValue = _LocalidadCargada.LoacaliadID;

                }


            }
            else
            {
                //no se recupero el usuario
                MessageBox.Show("Hay problemas para recuperar los datos del Perfil");

            }
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaComboLocalidad();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                _Usuario.UsuarioNombre = txtNombreUsuario.Text.Trim().ToLower();
            }
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                _Usuario.UsuarioEmail = txtEmail.Text.Trim().ToLower();
            }
            try
            {
                _Usuario.Update();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al actualizar usuario");
            }

            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                _Persona.PersonaNombre = txtNombre.Text.Trim();

            }
            if (!string.IsNullOrEmpty(txtApellido.Text))
            {
                _Persona.PersonaApellido = txtApellido.Text.Trim();

            }
            _Persona.PersonaFechaNacimiento = dtpFechaNacimiento.Value;
            Sexo sexo = new Sexo();
            switch (cbSexo.Text)
            {
                case "Hombre":
                    sexo = Sexo.Masculino;
                    break;
                case "Mujer":
                    sexo = Sexo.Femenino;
                    break;
                default:
                    sexo = Sexo.Otro;
                    break;
            }
            _Persona.PersonaSexo = sexo;
            if (cbCiudad.SelectedIndex != -1)
            {
                _Persona.LoacaliadID = cbCiudad.SelectedIndex;
            }
            try
            {
                _Persona.Update();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al actualizar usuario");
            }

            this.Close();
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
                _ImagenPerfil = RecuperaImagenStream(files[0].InputStream);
                this.pbImagenPerfil.Image = _ImagenPerfil;
                // Obtener el formato de imagen
                ImageFormat formato = _ImagenPerfil.RawFormat;
                ImageCodecInfo codecInfo = ImageCodecInfo.GetImageDecoders().FirstOrDefault(codec => codec.FormatID == formato.Guid);

                // Obtener la extensión del formato
                string extension = codecInfo?.FilenameExtension?.Split(';')?.FirstOrDefault();
                string nombreImagen = (DateTime.Now.ToString("dd:MM:yyyy") + _Usuario.PersonaID).Replace(":", "").Replace(" ", "") + extension.Replace("*", "");
                _ImagenPerfil.Tag = nombreImagen;
            }
        }
        private Image RecuperaImagenStream(Stream stream)
        {
            MemoryStream mem = new MemoryStream();
            stream.CopyTo(mem, 1024);
            mem.Position = 0;
            return Image.FromStream(mem);
        }
    }
}
