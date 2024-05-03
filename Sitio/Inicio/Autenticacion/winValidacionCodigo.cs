
using Raiderplan1;
using System;
using Wisej.Web;


namespace RaiderPlan.Sitio.Inicio
{
    public partial class winValidacionCodigo : Form
    {

        public delegate void delCodigo();
        public event delCodigo evCodigoCorrecto;
        public winValidacionCodigo(string   pEmailUsuario )
        {
            InitializeComponent();
        lblEmailUsuario.Text = pEmailUsuario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            dpUsuarioXEmailXusuarioIDCollectionCollection oEmailoUsuario = new dpUsuarioXEmailXusuarioIDCollectionCollection();
            bool resp=false;
            int OIDUsuario = 0;
            //controlo si la etiqueta usuario contiene email o usuario
            if (lblEmailUsuario.Text.Contains("@"))
            {
                //controlo si el email ya existe
                oEmailoUsuario.Fill(lblEmailUsuario.Text, "");
                if (oEmailoUsuario.Count > 0)
                {
                    //se ecnontro el mail comparo el codigode validacion
                    if (txtCodigoValidacion.Text == oEmailoUsuario[0].CodigoValidation) {
                        OIDUsuario = oEmailoUsuario[0].UsuarioID;
                        resp = true;
                    } 
                    else {
                        //el codigo noes correcto
                        resp = false;
                         }

                }
            }
            else
                {
                    //recupero por usuario
                    //controlo si el email ya existe
                    oEmailoUsuario.Fill("", lblEmailUsuario.Text.Trim());
                    if (oEmailoUsuario.Count > 0)
                    {
                        //se ecnontro el mail comparo el codigode validacion
                        if (txtCodigoValidacion.Text == oEmailoUsuario[0].CodigoValidation)
                        {
                            OIDUsuario = oEmailoUsuario[0].UsuarioID;
                            resp = true;
                        }
                        else
                        {
                            //el codigo noes correcto
                            resp = false;
                        }

                    }
                }

               if (resp) {
                
                    Usuario oUsuario = new Usuario();
                    oUsuario.Fill(OIDUsuario);
                    //el codigo es correcto paso el campode validacion a null esto significa que ya esta validado
                    oUsuario.UsuarioRow.SetCodigoValidationNull();
                    try
                    {
                        oUsuario.Update();
                        //CARGO LA VARIBALE DE SESSION DE UsuarioID
                        Application.Session.UsuarioID=oUsuario.UsuarioID;
                                       
                        // lanzo evento de que esta correcto
                        evCodigoCorrecto?.Invoke(); 
                        this.Close();
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show("No se pudo validar correctamente el código, porblemas en la actualización del campo "+ex.Message);
                    }

                } 
                else { MessageBox.Show("El código ingresado no es correcto"); }

        }

    }
}

