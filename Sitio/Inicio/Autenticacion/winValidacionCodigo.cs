
using Raiderplan1;
using System;
using Wisej.Web;


namespace RaiderPlan.Sitio.Inicio
{
    public partial class winValidacionCodigo : Form
    {

        public delegate void delCodigo();
        public event delCodigo evCodigoCorrecto;
        private int _userId;
        public winValidacionCodigo(int id)
        {
            InitializeComponent();
            _userId = id;
        }

        private void Validar()
        {
            Usuario oUsuario = new Usuario();
            bool resp = false;
            oUsuario.Fill(_userId);
            //se ecnontro el mail comparo el codigode validacion
            if (txtCodigoValidacion.Text == oUsuario.CodigoValidation)
            {
                try
                {
                    resp = true;
                    oUsuario.UsuarioRow.SetCodigoValidationNull();
                    oUsuario.Update();
                    //CARGO LA VARIBALE DE SESSION DE UsuarioID
                    Application.Session.UsuarioID = oUsuario.UsuarioID;

                    // lanzo evento de que esta correcto
                    evCodigoCorrecto?.Invoke();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo validar correctamente el código, porblemas en la actualización del campo " + ex.Message);
                }
            }
            else
            {
                //el codigo noes correcto
                resp = false;
            }


            if (!resp)
            {
                MessageBox.Show("El código ingresado no es correcto");
            }

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            Validar();
        }
    }
}

