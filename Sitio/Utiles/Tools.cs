using System.Net.Mail;
using System.Net;
using System;
using System.Security.Cryptography;
using System.Text;
using Wisej.Web;
using System.IO;

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
       
        private static int EnviaMail(string codigoHtml, string subject, string to)
        {
            try
            {
                // Configurar los detalles del remitente
                string remitente = "riderplan.official@gmail.com";
                string password = "whfxfssfjdsdnzpl";
                string destinatario = to;

                // Configurar el cliente SMTP
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    EnableSsl = true,
                    Credentials = new NetworkCredential(remitente, password)
                };

                // Crear el mensaje
                MailMessage mensaje = new MailMessage(remitente, destinatario);
                mensaje.Subject = subject;
                mensaje.IsBodyHtml = true;
                mensaje.Body = codigoHtml;
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

        public static int EnviaEmailBienvenida(string code, string email)
        {
            string htmlFilePath = Path.Combine(Application.StartupPath, "Resource", "lib","html", "CodigoValidacion.html");
            // Read the HTML content from the file
            string htmlContent = File.ReadAllText(htmlFilePath);
            htmlContent = htmlContent.Replace("XXXX", code);
            int response = EnviaMail(htmlContent, "Bienvenido a Rider Plan", email);
            return response;
        }
        public static int EnviaEmailRecuperacion(string code, string email)
        {
            string htmlFilePath = Path.Combine(Application.StartupPath, "Resource", "lib","html", "CodigoRecuperacion.html");
            // Read the HTML content from the file
            string htmlContent = File.ReadAllText(htmlFilePath);
            htmlContent = htmlContent.Replace("XXXX", code);
            int response = EnviaMail(htmlContent, "Recuperar cuenta", email);
            return response;
        }

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





