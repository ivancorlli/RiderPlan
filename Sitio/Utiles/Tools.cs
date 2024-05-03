using System.Net.Mail;
using System.Net;
using System;
using System.Security.Cryptography;
using System.Text;
using Wisej.Web;

namespace RaiderPlan.Sitio.Utiles
{
    public static class Tools
    {
        public static string Encripta(string Texto) 
        {

            using (SHA256 sha256 = SHA256.Create())
            {
                // Convierte la contraseña en un array de bytes
                byte[] passwordBytes = Encoding.UTF8.GetBytes(Texto);

                // Calcula el hash SHA256 de la contraseña
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                // Convierte el hash en una cadena hexadecimal
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
           
        }

        public static int EnviaMail(string codigoHtml, string codigoAEnviar) 
        {
                try
                {
                    // Configurar los detalles del remitente
                    string remitente = "appuntes2@gmail.com";
                    string password = "ubarxpqictktkosy";
                    string destinatario = "carloshurzagasti@gmail.com";

                    // Configurar el cliente SMTP
                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new NetworkCredential(remitente, password);

                    // Crear el mensaje
                    MailMessage mensaje = new MailMessage(remitente, destinatario);
                    mensaje.Subject = "ProbandoCorreo";

                    mensaje.IsBodyHtml = true;

                    // Asignar los parámetros a las variables correspondientes en el código HTML
                    codigoHtml = codigoHtml.Replace("XXXX", codigoAEnviar);
                //    mensaje.Body = codigoHtml;
                mensaje.Body = $"Este es el codigo {codigoAEnviar},que deberás usar para ingresar ";
                    // Enviar el mensaje
                    smtpClient.Send(mensaje);

                    return 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al enviar el correo: " + ex.Message);
                }

                return 0;
            }



            //try
            //{
            //    // Configurar los detalles del remitente
            //    string remitente = "appuntes2@gmail.com";
            //    string password = "ubarxpqictktkosy";
            //    string destinatario = "carloshurzagasti@gmail.com";

            //    // Configurar el cliente SMTP
            //    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            //    smtpClient.EnableSsl = true;
            //    smtpClient.Credentials = new NetworkCredential(remitente, password);

            //    // Crear el mensaje
            //    MailMessage mensaje = new MailMessage(remitente, destinatario);
            //    mensaje.Subject = "ProbandoCorreo";
            //    mensaje.Body = "Este es el codigo de verificacion debes ingresarlo en la ventana que lo reuiqera XZe9";

            //    // Enviar el mensaje
            //    smtpClient.Send(mensaje);

            //    return 1;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al enviar el correo: " + ex.Message);
            //}

            //return 0;
        
            public static string GeneraCodigo(int longitud)
            {
              Random random = new Random();
              string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < longitud; i++)
                {
                    int indiceCaracter = random.Next(caracteresPermitidos.Length);
                    char caracterAleatorio = caracteresPermitidos[indiceCaracter];
                    sb.Append(caracterAleatorio);
                }

                return sb.ToString();
            }

        }

   

}

    
    
    

