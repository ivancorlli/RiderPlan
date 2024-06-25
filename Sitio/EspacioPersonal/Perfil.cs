
using System;
using System.IO;
using Wisej.Web;
using Raiderplan1;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Data;
using System.Collections.Generic;
using System.Drawing.Imaging;
using Microsoft.Ajax.Utilities;

namespace RaiderPlan.Sitio.EspacioPersonal
{
    public partial class Perfil : Wisej.Web.UserControl
    {
        public delegate void miDelegado();
        public event miDelegado EvElijeaceptar;
        public event miDelegado EvElijeCancelar;
        Usuario _usario;
        Persona _Persona;
        Image _ImagenPerfil=null;        
        public Perfil()
        {
            InitializeComponent();
            //Asigno controlador al evento load
            this.Load += Load_Perfil;
            _usario = new Usuario();
            _usario.Fill((int)Application.Session.UsuarioID);

            _Persona = new Persona();
            _Persona.Fill(_usario.PersonaID);
        }

        private void Load_Perfil(object sender, EventArgs e)
        {

            CargaComboPais();
            CargaTagBotones();
            CargaPerfil();
           
        }

        private void CargaComboPais() 
        {
            
            //Cargo los combobox de pais , provincia, localidad
            PaisCollection pais = new PaisCollection();
            pais.Fill();
            //Para agregar un pasi en blanco 
            Pais paisVacio = new Pais();
            paisVacio.PaisNombre = "";
            List<Pais> oListaPais = new List<Pais>
            {
                paisVacio
            };

            oListaPais.AddRange(pais.Cast<Pais>().ToList());

            cbPais.DisplayMember = "PaisNombre";
            cbPais.ValueMember = "PaisID";
            cbPais.DataSource = oListaPais;
            
        }


        private void CargaComboProvincia()
        {
           
            if (cbPais.SelectedValue!=null && (int)cbPais.SelectedValue>0) { 
            //cargo el combo box de provincia
            ProvinciaCollection _Provincia = new ProvinciaCollection();
            _Provincia.FillByPaisID((int)cbPais.SelectedValue);

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
           
            }else
            {
                cbProvincia.DataSource = null;
            }
        }

        private void CargaComboLocalidad()
        {
          
           if(cbProvincia.DataSource!=null && (int)cbProvincia.SelectedValue>0) { 
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

            cbLocalidad.DisplayMember = "LocalidadNombre";
            cbLocalidad.ValueMember = "LoacaliadID";
            cbLocalidad.DataSource = oListaLocalidade;
            
            }
        }


        /// <summary>
        /// Cargo los tag de los botones con los correspondientes contoles
        ///a los que afectara su evento click en el tag y cambio la poscion de los votones ok
        /// </summary>
        private void CargaTagBotones()
        {
            //Cargo los tag de los botones con los correspondientes contoles
            //a los que afectara su evento click en el tag y cambio la poscion de los votones ok
            btnokNombreUsuario.Tag = txtNombreUsuario;
            btnokNombreUsuario.Location = btnEditNombreUsuario.Location;
            btnEditNombreUsuario.Tag= txtNombreUsuario;

            btnOKEmail.Tag = txtEmail;
            btnOKEmail.Location = btnEditEmail.Location; 
            btnEditEmail.Tag= txtEmail;

            btnOkNombrePersona.Tag=txtNombre;
            btnOkNombrePersona.Location = btnEditNombrePersona.Location;
            btnEditNombrePersona.Tag= txtNombre;

            btnOkApellido.Tag = txtApellido;
            btnOkApellido.Location=btnEditApellido.Location;
            btnEditApellido.Tag= txtApellido;

            btnOkPais.Tag = cbPais;
            btnOkPais.Location = btnEditPais.Location;
            btnEditPais.Tag= cbPais;

            btnOkProvincia.Tag= cbProvincia;
            btnOkProvincia.Location= btnEditProvincia.Location;
            btnEditProvincia.Tag= cbProvincia;

            btnOKLocalidad.Tag= cbLocalidad;
            btnOKLocalidad.Location=btnEditLocalidad.Location;
            btnEditLocalidad.Tag= cbLocalidad;

            btnOKFechaNac.Tag = dtpFechaNacimiento;
            btnOKFechaNac.Location = btnEditFechaNac.Location;
            btnEditFechaNac.Tag = dtpFechaNacimiento;

            btnOKSexo.Tag= cbSexo;
            btnOKSexo.Location = btnEditSexo.Location; 
            btnEditSexo.Tag= cbSexo;
        }

        private void CargaPerfil()
        {
                      
            if (_usario != null)
            {
                //encotro el usuario
                lblNombreUsuario.Text = _usario.UsuarioNombre;
                //controlo los datos de persona

                //recupero imagen de perfil
                if (_Persona.PersonaRow.IsImagenPerfilNull() || _Persona.ImagenPerfil.Trim() == "")
                {


                    string rutaImagen = @"Resource\lib\Imagenes\iconousuario.png";
                    pbImagenPerfil.ImageSource = rutaImagen;

                }
                else
                {
                    pbImagenPerfil.ImageSource = @"Resource\lib\ImagenesUsuario\" + _Persona.ImagenPerfil;

                }

                txtNombreUsuario.Text = _usario.UsuarioNombre;
                txtEmail.Text = _usario.UsuarioEmail;
                
                //cargo los datos de la persona en los textbox
                txtNombre.Text = _Persona.PersonaRow.IsPersonaNombreNull() ? "" : _Persona.PersonaNombre;
                txtApellido.Text= _Persona.PersonaRow.IsPersonaApellidoNull() ? "" : _Persona.PersonaApellido;

                //cargo fecha
                dtpFechaNacimiento.Value = _Persona.PersonaFechaNacimiento;                
                //cargo el sexo
                switch (_Persona.PersonaSexo)
                {
                    case Sexo.Masculino :
                        cbSexo.SelectedItem= "Hombre";
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
                   
                    //seleccion Argentina
                    cbPais.SelectedValue = 1;

                    CargaComboProvincia();
                    //selecciono la provincia
                    cbProvincia.SelectedValue = _LocalidadCargada.ProvinciaID;
                    
                    CargaComboLocalidad();
                    //selecciono la localidad
                    cbLocalidad.SelectedValue = _LocalidadCargada.LoacaliadID;
                    
                }
            
                        
            }
            else
            {
                //no se recupero el usuario
                MessageBox.Show("Hay problemas para recuperar los datos del Perfil");

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
                _ImagenPerfil= RecuperaImagenStream(files[0].InputStream);
                this.pbImagenPerfil.Image = _ImagenPerfil;
                // Obtener el formato de imagen
                ImageFormat formato = _ImagenPerfil.RawFormat;
                ImageCodecInfo codecInfo = ImageCodecInfo.GetImageDecoders().FirstOrDefault(codec => codec.FormatID == formato.Guid);

                // Obtener la extensión del formato
                string extension = codecInfo?.FilenameExtension?.Split(';')?.FirstOrDefault();
                string nombreImagen = (DateTime.Now.ToString("dd:MM:yyyy") + _usario.PersonaID).Replace(":", "").Replace(" ","")+extension.Replace("*", "");
                _ImagenPerfil.Tag= nombreImagen;
            }
        }
        private Image RecuperaImagenStream(Stream stream)
        {
            MemoryStream mem = new MemoryStream();
            stream.CopyTo(mem, 1024);
            mem.Position = 0;
            return Image.FromStream(mem);
        }

        private void HabilitaEdicion(Button pBoton,bool pHabilita)
        {
            
            //casteo el pBoton como control para poder habiliar o desabilitar el objeto
            //ya que buene ser que elc ontenido del tag sea button, datePiker,o combobox
            // y determino si lo hailito o lo desabilito
            Control _ControlSeleccionado = (Control) pBoton.Tag;
            _ControlSeleccionado.Enabled = pHabilita ? true : false;
            if (_ControlSeleccionado.Enabled) _ControlSeleccionado.Focus();
            pBoton.Visible=!pBoton.Visible;// desbilito el o habilito el boton que dispara el evento
        }
        private void btEditNombreUsuario_Click(object sender, EventArgs e)
        {
            //paso como parametro el sender queproviene de un botn lo casteo como button
            HabilitaEdicion((Button)sender,true);
            btnokNombreUsuario.Visible= true;
        }

        private void btnEditEmail_Click(object sender, EventArgs e)
        {
            //paso como parametro el sender queproviene de un botn lo casteo como button
            HabilitaEdicion((Button)sender, true);
            btnOKEmail.Visible =true;
        }

        private void btnEditNombrePersona_Click(object sender, EventArgs e)
        {
            //paso como parametro el sender queproviene de un botn lo casteo como button
            HabilitaEdicion((Button)sender, true);
            btnOkNombrePersona.Visible = true;
        }

        private void btnEditApellido_Click(object sender, EventArgs e)
        {
            //paso como parametro el sender queproviene de un botn lo casteo como button
            HabilitaEdicion((Button)sender, true);
            btnOkApellido.Visible = true;   
        }

        private void btnEditPais_Click(object sender, EventArgs e)
        {
            //paso como parametro el sender queproviene de un botn lo casteo como button
            HabilitaEdicion((Button)sender, true);
            btnOkPais.Visible = true;
        }

        private void btnEditProvincia_Click(object sender, EventArgs e)
        {
            //paso como parametro el sender queproviene de un botn lo casteo como button
            HabilitaEdicion((Button)sender, true);
            btnOkProvincia.Visible = true;
        }

        private void btnEditLocalidad_Click(object sender, EventArgs e)
        {
            //paso como parametro el sender queproviene de un botn lo casteo como button
            HabilitaEdicion((Button)sender, true);
            btnOKLocalidad.Visible = true;
        }

        private void btnEditFechaNac_Click(object sender, EventArgs e)
        {
            //paso como parametro el sender queproviene de un botn lo casteo como button
            HabilitaEdicion((Button)sender, true);
            btnOKFechaNac.Visible = true;
        }

        private void btnEditSexo_Click(object sender, EventArgs e)
        {
            //paso como parametro el sender queproviene de un botn lo casteo como button
            HabilitaEdicion((Button)sender, true);
            btnOKSexo.Visible = true;
        }

        private void btnokNombreUsuario_Click(object sender, EventArgs e)
        {
            if (ValidaNombreUsuario()) { 
            //paso como parametro el sender queproviene de un botn lo casteo como button
            HabilitaEdicion((Button)sender, false);
            btnEditNombreUsuario.Visible = true;
            }
        }

        private void btnOKEmail_Click(object sender, EventArgs e)
        {
           if (ValidaEmail())
            {
                //paso como parametro el sender queproviene de un botn lo casteo como button
                HabilitaEdicion((Button)sender, false);
                btnEditEmail.Visible = true;

            }
        }

        private void btnOkNombrePersona_Click(object sender, EventArgs e)
        {
            if (ValidaCadena(txtNombre.Text))
            {
                //paso como parametro el sender queproviene de un botn lo casteo como button
                HabilitaEdicion((Button)sender, false);
                btnEditNombrePersona.Visible = true;
                errorProvider1.SetError(btnOkNombrePersona, "");
            }
            else
            {
                lblMensaje.Text = "El nombre no puede tener caracteres especiales,ni ser vacio";
                errorProvider1.SetError(btnOkNombrePersona, "El nombre no puede tener caracteres especiales,ni ser vacio");
            }


        }
    

        private void btnOkApellido_Click(object sender, EventArgs e)
        {
            if (ValidaCadena(txtApellido.Text)) 
            { 
                //paso como parametro el sender queproviene de un botn lo casteo como button
                HabilitaEdicion((Button)sender, false);
                btnEditApellido.Visible = true;
                errorProvider1.SetError(btnOkApellido, "");
            }
            else
            {
                lblMensaje.Text = "El apellido no puede tener caracteres especiales,ni ser vacio";
                errorProvider1.SetError(btnOkApellido, "El apellido no puede tener caracteres especiales,ni ser vacio");

            }
        }

        private void btnOkPais_Click(object sender, EventArgs e)
        {
            //paso como parametro el sender queproviene de un botn lo casteo como button
            HabilitaEdicion((Button)sender, false);
            btnEditPais.Visible = true;
        }

        private void btnOkProvincia_Click(object sender, EventArgs e)
        {
            //paso como parametro el sender queproviene de un botn lo casteo como button
            HabilitaEdicion((Button)sender, false);
            btnEditProvincia.Visible = true;
        }

        private void btnOKLocalidad_Click(object sender, EventArgs e)
        {
            //paso como parametro el sender queproviene de un botn lo casteo como button
            HabilitaEdicion((Button)sender, false);
            btnEditLocalidad.Visible = true;
        }

        private void btnOKFechaNac_Click(object sender, EventArgs e)
        {
            if (ValidaFeha()) 
            { 
                //paso como parametro el sender queproviene de un botn lo casteo como button
                HabilitaEdicion((Button)sender, false);
                btnEditFechaNac.Visible = true;
            }
        }

        private void btnOKSexo_Click(object sender, EventArgs e)
        {
            //paso como parametro el sender queproviene de un botn lo casteo como button
            HabilitaEdicion((Button)sender, false);
            btnEditSexo.Visible = true;
        }

        private bool ValidaNombreUsuario()
        {
            bool resp = true;
            String Mensaje = "";

            if (txtNombreUsuario.Text.Trim().Length < 4)
            {
                resp = false;
                Mensaje = "El nombre de usuario debe ser mayor a tres caracteres";

            }

            if (txtNombreUsuario.Text.Trim().Length > 3)
            {
                string patron = "^[a-zA-Z0-9_ ]+$";
                resp = Regex.IsMatch(txtNombreUsuario.Text, patron);
                if (!resp) { Mensaje = "El nombre de usuario solo permite letras y números"; };
            }

            if (resp && txtNombreUsuario.Text.Trim().Length > 3)
            {
                //controlo si el nombre de usuario ya existe
                dpUsuarioXEmailXusuarioIDCollectionCollection oNombreUsuario = new dpUsuarioXEmailXusuarioIDCollectionCollection();
                oNombreUsuario.Fill("", txtNombreUsuario.Text);
                if (oNombreUsuario.Count > 0)
                {
                  if (!(oNombreUsuario[0].UsuarioNombre.ToUpper()==lblNombreUsuario.Text.ToUpper()))
                    resp = false;
                    Mensaje = "El nombre de usuario ya esta siendo usado";
                }
            }


            if (!resp)
            {
                errorProvider1.SetError(btnokNombreUsuario, Mensaje);
                lblMensaje.Text = Mensaje;
            }

            if (resp) errorProvider1.SetError(txtNombreUsuario, "");

            return resp;
        }

        private bool ValidaEmail()
        {
            bool resp = true;
            String Mensaje = "";

            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            resp = Regex.IsMatch(txtEmail.Text, patron);
            if (!resp)
            {
                Mensaje = "el email no es valido";
                if (!resp)
                {
                    errorProvider1.SetError(btnOKEmail, Mensaje);
                    lblMensaje.Text = Mensaje;
                }
            };

            if (resp)
            {
                //controlo si el nombr de email ya existe
                dpUsuarioXEmailXusuarioIDCollectionCollection oEmail = new dpUsuarioXEmailXusuarioIDCollectionCollection();
                oEmail.Fill(txtEmail.Text, "");
                if (oEmail.Count > 0)
                {
                    if (!(oEmail[0].UsuarioEmail==txtEmail.Text)) 
                    { 
                        resp = false;
                        Mensaje = "la direccion de correo le pertenece a otro usuario";
                        errorProvider1.SetError(btnOKEmail, Mensaje);
                        lblMensaje.Text = Mensaje;
                    
                    }
                }
            }

            if (resp) errorProvider1.SetError(btnOKEmail, "");
            return resp;
        }
        private bool ValidaFeha()
        {
            bool resp = true;
            
            if (dtpFechaNacimiento.Value >= DateTime.Now)
            {
                lblMensaje.Text = "la fecha de nacimento es incorrecta";
                errorProvider1.SetError(btnOKFechaNac, "la fecha de nacimento no es valida,debe ser mayor a 16 años");
                resp=false;
            }
            else
            {
                TimeSpan diferencia = DateTime.Now.Subtract(dtpFechaNacimiento.Value)  ;
                double años=diferencia.TotalDays / 365.25;
                if (años > 16) 
                {
                    errorProvider1.SetError(dtpFechaNacimiento, "");
                    resp = true; 
                }
                else 
                { 
                    errorProvider1.SetError(btnOKFechaNac, "\"la fecha de nacimento no es valida,debe ser mayor a 16 años\""); 
                    resp = false; 
                }
                
            }
            return resp;
        }

        private void cbPais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if((int)cbPais.SelectedValue >0)
            {
                CargaComboProvincia();
                CargaComboLocalidad();
            }
            else 
            {
                cbProvincia.DataSource = null;
                cbLocalidad.DataSource = null;
            }
        }

        private void cbProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((int)cbPais.SelectedValue > 0)
            {
                CargaComboLocalidad();
            }
            else
            {
                cbProvincia.DataSource = null;
                cbLocalidad.DataSource = null;
            }

        }
        private void GuardarImagen(Image pImagen)
        {

            var mome = pImagen.Tag.ToString();
            //@"Resource\lib\ImagenesUsuario"
            string rutaGuardar = @"Resource\lib\ImagenesUsuario\"+pImagen.Tag.ToString() ; //donde se va a guardar la imagen 

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
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (EsCargaValida())
            {
                //Oculto el mensaje
                lblMensaje.Visible = false;

                //Cargo los nuevo valores de persona            
                _Persona.PersonaNombre =txtNombre.Text ;
                _Persona.PersonaApellido = txtApellido.Text;
                _Persona.PersonaFechaNacimiento = dtpFechaNacimiento.Value;
                //controlo el sexo elegido
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
                //se se levanto una imagen se guarda 
                _Persona.ImagenPerfil = _ImagenPerfil != null ?_ImagenPerfil.Tag.ToString():"";
                //impacto en la base de datos de persona
                bool lanzaEvento = false;
                try
                {
                    _Persona.Update();
                    lanzaEvento = true;
                }
                catch (Exception)
                {

                    MessageBox.Show("Hay inconvenientes para  al actualizar los datos de la persona");
                }
                if (_ImagenPerfil != null)
                {
                    GuardarImagen(_ImagenPerfil);
                }
                
                if (lanzaEvento)
                {

                    // imapcto en usuario
                    _usario.UsuarioNombre=txtNombreUsuario.Text;
                    _usario.UsuarioEmail = txtEmail.Text;
                    try
                    {
                        _usario.Update();
                        lanzaEvento=true;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Hay inconvenientes para  al actualizar los datos del usuario");
                    }
                                        
                }
                if (lanzaEvento)
                {
                    //lanzo el evento de aceptar
                    EvElijeaceptar?.Invoke();
                }

            }
            else
            {
                //Muestro el mensaje en pantalla
                lblMensaje.Text = "Hay Datos en modo de edición, termine de editar y vuelva a intentar";
                lblMensaje.Visible = true;
            }
        }

        public bool ValidaCadena(string pCadena)
        {
            bool resp = false;
            if (pCadena.Trim().Length > 0)
            {
                //controlo si es valida la cadena
                string patron = "^[a-zA-Z0-9 ]+$";
                resp = Regex.IsMatch(pCadena, patron);
            }
            //la cadena es vacia
            else { resp = false; }

            return resp;
        }
        private bool EsCargaValida()
        {
            bool resp = true;
            foreach(Control oitem in pnlContent.Controls.Cast<Control>())
            { 
                if ((oitem is TextBox) || (oitem is ComboBox) || (oitem is DateTimePicker)) 
                { 
                 if (oitem.Enabled) 
                    {
                       return false;
                    } 
                
                
                }
            }


            return resp;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //lanzo el evento
            EvElijeCancelar?.Invoke();
        }
    }
}
