using System;
using System.Text.RegularExpressions;
using Wisej.Web;
using Raiderplan1;

namespace RaiderPlan.Sitio.Inicio
{
    public partial class winRegistro : Wisej.Web.Form
    {

        public delegate void delRegistrado(string pEmailUsuario);
        public event delRegistrado evRegistrado;


        
        //Cosntructor
        public winRegistro()
        {
            InitializeComponent();

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       public bool ValidaCadena(string pCadena)
        {
            bool resp=false;
            if (pCadena.Trim().Length > 0) 
            { 
                //controlo si es valida la cadena
                string patron = "^[a-zA-Z0-9 ]+$";
                resp = Regex.IsMatch(pCadena, patron);
            }
            //la cadena es vacia
            else {resp=false;}
            
            return resp;
        }
        
        private bool ValidaNombreUsuario() 
        {
            bool resp = true;
            String Mensaje = "";

            if (txtNombreUsuario.Text.Trim().Length <4 )
            {
                resp = false;
                Mensaje = "El nombre de usuario debe ser mayor a tres caracteres";
                
            }

            if (txtNombreUsuario.Text.Trim().Length > 3 )
            {
                string patron = "^[a-zA-Z0-9_ ]+$";
                resp = Regex.IsMatch(txtNombreUsuario.Text, patron);
              if ( !resp ) { Mensaje = "El nombre de usuario solo permite letras y números"; };
            }

            if (resp && txtNombreUsuario.Text.Trim().Length > 3)
            {
                //controlo si el nombre de usuario ya existe
                dpUsuarioXEmailXusuarioIDCollectionCollection oNombreUsuario = new dpUsuarioXEmailXusuarioIDCollectionCollection();
                 oNombreUsuario.Fill("", txtNombreUsuario.Text);
                if (oNombreUsuario.Count > 0) 
                { 
                    resp = false;
                    Mensaje = "El nombre de usuario ya esta siendo usado";
                }

            }
            
            
            if (!resp) 
            {
                errorProvider1.SetError(txtNombreUsuario, Mensaje);
                lblMansaje.Text = Mensaje;
            }

            if (resp) errorProvider1.SetError(txtNombreUsuario, "");

            return resp;
        }

        private bool ValidaEmail() 
        {
            bool resp=true;
            String Mensaje = "";
            
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            resp = Regex.IsMatch(txtEmail.Text, patron);
            if ( !resp ) 
            {
                Mensaje = "el email no es valido";
                if (!resp)
                {
                    errorProvider1.SetError(txtEmail, Mensaje);
                    lblMansaje.Text = Mensaje;
                }
            };

            if (resp)
            {
                //controlo si el nombr de email ya existe
                dpUsuarioXEmailXusuarioIDCollectionCollection oEmail = new dpUsuarioXEmailXusuarioIDCollectionCollection();
                oEmail.Fill(txtEmail.Text, "");
                if (oEmail.Count > 0)
                {
                    resp = false;
                    Mensaje = "la direccion de correo le pertenece a otro usuario";
                    errorProvider1.SetError(txtEmail, Mensaje);
                    lblMansaje.Text = Mensaje;
                }

            }

            if (resp) errorProvider1.SetError(txtEmail, ""); 
            return resp;
        }

        

        private void txtNombreUsuario_Leave(object sender, EventArgs e)
        {

            ValidaNombreUsuario();

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            ValidaEmail();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {

            bool resp = true;
            TextBox oTextBox = (TextBox)sender;
            string patron = "^[a-zA-Z0-9_ ]+$";
            resp = Regex.IsMatch(oTextBox.Text, patron);
            
            if (!resp)
            {
                lblMansaje.Text = "El password no puede tener caracteres especiales,ni ser vacio";
                errorProvider1.SetError(oTextBox, "El password no puede tener caracteres especiales,ni ser vacio");
            }
            else
                errorProvider1.SetError(oTextBox, "");  
        }

        private void txtPassword2_Leave(object sender, EventArgs e)
        {
            //uso el mismo metodo que usa txtPassword
            txtPassword_Leave(sender, e);
        }

        private void dtpFechaNacimiento_Leave(object sender, EventArgs e)
        {


            if (dtpFechaNacimiento.Value >= DateTime.Now)
            {
                lblMansaje.Text = "la fecha de nacimento es incorrecta";
                errorProvider1.SetError(dtpFechaNacimiento, "la fecha de nacimento no es valida,debe ser mayor a 16 años");
                
            }
            else
            {
                TimeSpan diferencia = DateTime.Now.Subtract(dtpFechaNacimiento.Value);
                double años = diferencia.TotalDays / 365.25;
                if (años > 16)
                {
                    errorProvider1.SetError(dtpFechaNacimiento, "");
                    
                }
                else
                {
                    errorProvider1.SetError(dtpFechaNacimiento, "\"la fecha de nacimento no es valida,debe ser mayor a 16 años\"");
                    
                }

            }
        }

        private bool ControlIntegral()
        {
            bool resp=true;


            if (!(dtpFechaNacimiento.Value < DateTime.Now && dtpFechaNacimiento.Value > new DateTime(1901, 01, 01)))
            {

                if (dtpFechaNacimiento.Value >= DateTime.Now)
                {
                    lblMansaje.Text = "la fecha de nacimento es incorrecta";
                    errorProvider1.SetError(dtpFechaNacimiento, "la fecha de nacimento no es valida,debe ser mayor a 16 años");
                    resp = false;
                    return resp;
                }
                else
                {
                    TimeSpan diferencia = DateTime.Now.Subtract(dtpFechaNacimiento.Value);
                    double años = diferencia.TotalDays / 365.25;
                    if (años > 16)
                    {
                        errorProvider1.SetError(dtpFechaNacimiento, "");
                        resp = true;
                    }
                    else
                    {
                        lblMansaje.Text = "la fecha de nacimento es incorrecta";
                        errorProvider1.SetError(dtpFechaNacimiento, "la fecha de nacimento no es valida,debe ser mayor a 16 años");
                        resp = false;
                        return resp;
                    }

                }
            }



            string patron = "^[a-zA-Z0-9_ ]+$";
            resp = Regex.IsMatch(txtPassword.Text, patron);
            if (!resp)
            {
                lblMansaje.Text = "El password no puede tener caracteres especiales,ni ser vacio";
                errorProvider1.SetError(txtPassword, "El password no puede tener caracteres especiales,ni ser vacio");
                return resp;
            }

            resp = Regex.IsMatch(txtPassword2.Text, patron);
            
            if (!resp)
            {
                lblMansaje.Text = "El password no puede tener caracteres especiales,ni ser vacio";
                errorProvider1.SetError(txtPassword2, "El password no puede tener caracteres especiales,ni ser vacio");
                return resp;
            }

            //controlo si los passwords coinciden
            if (txtPassword.Text != txtPassword2.Text) 
            {
                lblMansaje.Text = "El password no coincide con el paswword de verificación";
                errorProvider1.SetError(txtPassword2, "El password no coincide con el paswword de verificación");
                resp=false;
                return resp;
             }
            
            if (!chkTerminos.Checked)
            {
                resp = false;
                lblMansaje.Text = "Debe aceptar los terminos y condiciones de uso";
                return resp;
            }

            if (resp) errorProvider1.Clear();
            return resp;

        }
            
        
        
        
        private void Registrarme_Click(object sender, EventArgs e)
        {
            bool resp = true;
            resp = ControlIntegral();

            
            if (resp) 
            {

                int oUsuarioID = 0;
                //crea la persona el usuadiro y roldel usuario y retorna el ID  del Usauario
                oUsuarioID= CreaPersonaUsuarioRol();

                if (oUsuarioID != 0)
                {
                    //Recupero el usuario creado para tomar inyectar el codigo generado
                    Usuario oUsuario = new Usuario();
                    oUsuario.Fill(oUsuarioID);
                    string rutaArchivo = @"C;:\Users\Carlos\Desktop\RaiderPlan\RaiderPlan\Resource\lib\html\Codigovalidacion.html";
                    //string contenidoHTML = File.ReadAllText(rutaArchivo);

                    Utiles.Tools.EnviaMail(rutaArchivo, oUsuario.CodigoValidation);
                    evRegistrado?.Invoke(txtEmail.Text.Trim());
                    MessageBox.Show("Tu registro ha sido existoso");
                         
                    
                    this.Close();
                }
                else MessageBox.Show("Hubo un problema con la creación del usuario");
            }
            else 
            {
                MessageBox.Show("Hay errores en el formulario");
                lblMansaje.Visible = true;
            }
        }

        /// <summary>
        /// este medodo crea la persona el usuario y el usuario rol en la base de datos
        /// y retorna un usuaarioid
        /// </summary>
        private int CreaPersonaUsuarioRol()
        {
            Persona persona = new Persona();
            Usuario usuario = new Usuario();
            RolUsuario rolUsuario = new RolUsuario();
            
            //Al existir campos que no permiten nulos en le estructura por defecto se los carga vacio
            //En caso de sexo se pone por defecto "otro"
            persona.PersonaNombre ="";
            persona.PersonaApellido = "";
            persona.PersonaFechaNacimiento = dtpFechaNacimiento.Value;
            persona.PersonaSexo = Sexo.Otro;
            persona.ImagenPerfil = "iconousuario.png";
            //persona.LoacaliadID = 0;

            bool creacionCorrecta = true;
            try
            {
                persona.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo crear la persona"+ ex.Message);
                creacionCorrecta = false;
            }
            int oUsuarioID = 0;
            if (creacionCorrecta)
            {
                string passworencriptada = "";
                passworencriptada = Utiles.Tools.Encripta(txtPassword.Text);
                usuario.UsuarioNombre = txtNombreUsuario.Text;
                usuario.UsuarioEmail = txtEmail.Text;
                usuario.UsuarioPasword = passworencriptada;
                usuario.UsuarioActivo = "S";
                usuario.UsuarioFechaAlta = DateTime.Now;
                usuario.PersonaID = persona.PersonaID;

                //genera codigo alfanumerico con la cantidad de digitos especificado en el parametro
                usuario.CodigoValidation = Utiles.Tools.GeneraCodigo(4);
                try
                {
                    usuario.Update();
                    oUsuarioID = usuario.UsuarioID;
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo crear el usuario");
                    creacionCorrecta = false;

                }
            }

            if(creacionCorrecta)
            {
                rolUsuario.Rol=UsuarioRol.usuario ;
                rolUsuario.UsuarioID= usuario.UsuarioID;
                try
                {
                    rolUsuario.Update();

                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo crear la rol del usuario");
                    creacionCorrecta = false;
                }
            }
            return oUsuarioID;
        }

        
    }
}
