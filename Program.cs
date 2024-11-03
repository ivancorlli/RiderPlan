using RaiderPlan.Sitio.Viajes;
using System;
using Wisej.Core;
using Wisej.Web;
using Raiderplan1;
using RaiderPlan.Sitio.Utiles;
using System.IO;
using RaiderPlan.Sitio.Inicio;
using System.Threading.Tasks;

namespace RaiderPlan
{
    internal static class Program
    {
        //


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Application.MainPage = new Page1();

        }

        [WebMethod]
        public static async Task GeneraViaje(string jsonParametro)
        {
            Ruta parametro = Newtonsoft.Json.JsonConvert.DeserializeObject<Ruta>(jsonParametro);

            bool oEliminaTrayectos = UtilidadesViaje.EliminaTrayectos(parametro.ViajeID, parametro.EsOrigen);
            if (oEliminaTrayectos && parametro.Coordenadas!=null)
            {
                await UtilidadesViaje.GuardaViaje(parametro);
            };
        }
        [WebMethod]
        public static string GeneraComentario(string jsonParametro)
        {
            Comentario parametro = Newtonsoft.Json.JsonConvert.DeserializeObject<Comentario>(jsonParametro);

            ComentarioViaje comentario = new ComentarioViaje()
            {
                ViajeID = parametro.ViajeID,
                ComentarioLatitud = (decimal)parametro.Lat,
                ComentarioLongitud = (decimal)parametro.Lng,
                ComentarioTexto = "",
            };
            try
            {
                comentario.Update();
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error al crear comentario");
            }
            return comentario.ComentarioViajeID.ToString();
        }

        [WebMethod]
        public static void ActualizaComentario(string jsonParametro,string image)
        {
            Comentario parametro = Newtonsoft.Json.JsonConvert.DeserializeObject<Comentario>(jsonParametro);
            if(image != "")
            {
                string newId = Guid.NewGuid().ToString();
                byte[] imageBytes = Convert.FromBase64String(image);
                string imagePath = Path.Combine("Resource","lib","Viajes", newId + ".jpg");
                File.WriteAllBytes(imagePath, imageBytes);
                parametro.Imagen = newId + ".jpg";
            }
            ComentarioViaje comentario = new ComentarioViaje();
            comentario.Fill((int)parametro.ID);
            comentario.ComentarioTexto = parametro.Texto;
            comentario.ComentarioImagen = parametro.Imagen;
            try
            {
                comentario.Update();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al actualizar comentario");
            }
        }

        [WebMethod]
        public static void EliminaComentario(string id)
        {
            ComentarioViaje comentario = new ComentarioViaje();
            comentario.Fill(int.Parse(id));
            try
            {
                if (!comentario.ComentarioViajeRow.IsComentarioImagenNull())
                {
                    if (File.Exists(Path.Combine("Resource", "lib", "Viajes", comentario.ComentarioImagen)))
                    {
                        // Delete the file
                        File.Delete(Path.Combine("Resource", "lib", "Viajes", comentario.ComentarioImagen));
                    };
                }
                comentario.Delete();
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error al crear comentario");
            }
        }

    }


}