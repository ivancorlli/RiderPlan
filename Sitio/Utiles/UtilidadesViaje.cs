using RaiderPlan.Sitio.Viajes;
using Raiderplan1;
using System.Text;
using System;
using Wisej.Web;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Data;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net;
using RestSharp;

namespace RaiderPlan.Sitio.Utiles
{
    public static class UtilidadesViaje
    {
        /// <summary>
        /// este metodo se encarga de guardar todos los trayecto para cada viaje
        /// </summary>
        /// <param name="parametro"></param>
        public static async Task GuardaViaje(Ruta parametro)
        {
            //controlo que el parametro no llegue nulo o con un solo punto
            if (parametro.InputWaypoints.Count > 1)
            {
                //recorro los waypoints (los distintos marcadores para armar los trayectos del viaje en el detalle)
                int oOrden = 1;// establece el orden de los trayectos
                int inicioInstrucion = 0;//para establecer el indice de las instrucciones y poder concatenar las instruciones correctamente
                //recorro los puntos maracados en el mapa menos el ultimo ya que este marca el destino
                for (int i = 0; i < parametro.InputWaypoints.Count - 1; i++)
                {
                    TrayectoViaje oTrayectoViaje = new TrayectoViaje();

                    oTrayectoViaje.Orden = oOrden;
                    oTrayectoViaje.ViajeID = parametro.ViajeID; //relaciono con el viaje con el trayecto
                    oTrayectoViaje.TayectoLatitudOrigen = (decimal)parametro.InputWaypoints[i].LatLng.Lat;
                    oTrayectoViaje.TrayectoLongitudOrigen = (decimal)parametro.InputWaypoints[i].LatLng.Lng; ;

                    oTrayectoViaje.TrayectoLatidudDestino = (decimal)parametro.InputWaypoints[i + 1].LatLng.Lat;
                    oTrayectoViaje.TrayectoLongitudDestino = (decimal)parametro.InputWaypoints[i + 1].LatLng.Lng;

                    double distanciaTrayecto = 0;//acumula el total en metros de el trayecto
                    double tiempoTrayecto = 0;//acumula el tiempo en seg
                    StringBuilder concatenacionInstrucciones = new StringBuilder();// para realizar la concatenacion
                    int auxIndice = 0;
                    for (int J = inicioInstrucion; J < parametro.Instrucciones.Count; J++)
                    {

                        //Mientras sea distinto del waitpointreach "es la llegada aun punto intermedio"
                        // concateno las instruccioness
                        if (parametro.Instrucciones[J].Type != "WaypointReached")
                        {
                            concatenacionInstrucciones.Append(parametro.Instrucciones[J].Text);
                            concatenacionInstrucciones.Append(" por: " + parametro.Instrucciones[J].Distance.ToString() + " mts");
                            concatenacionInstrucciones.Append(";");
                            distanciaTrayecto += parametro.Instrucciones[J].Distance;
                            tiempoTrayecto += parametro.Instrucciones[J].Time;
                        }
                        //llego aun punto intermedio termina las instrucciones para el trayecto
                        else
                        {
                            concatenacionInstrucciones.Append(parametro.Instrucciones[J].Road + " ,");
                            concatenacionInstrucciones.Append(parametro.Instrucciones[J].Text);
                            auxIndice = J + 1;
                            break; //dejo de concatenarlas instrucciones 
                        }

                        auxIndice = J;
                    }

                    oTrayectoViaje.TrayectoOrigen = parametro.Instrucciones[inicioInstrucion].Road;
                    oTrayectoViaje.TrayectoDestino = auxIndice > parametro.Instrucciones.Count - 1 ? parametro.Instrucciones[auxIndice - 3].Road : parametro.Instrucciones[auxIndice - 1].Road;
                    oTrayectoViaje.Instrucciones = concatenacionInstrucciones.ToString();
                    oTrayectoViaje.Trayectokm = Math.Round((decimal)distanciaTrayecto / 1000);//transformo a km
                    oTrayectoViaje.TiempoEstimado = Math.Round((decimal)tiempoTrayecto / 60);//transformo a minutos
                    oTrayectoViaje.EsOrigen = parametro.EsOrigen.ToString();
                    inicioInstrucion = auxIndice;

                    oOrden += 1; //para establecer el orden de los trayectos
                    //guardo el trayecto
                    try
                    {
                        oTrayectoViaje.Update();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"No se pudo guardar el {oOrden}° trayecto");
                        return; // se corta el proceso de guardado de los proyectos
                    }

                }

                try
                {
                    Viaje viaje = new Viaje();
                    viaje.Fill(parametro.ViajeID);
                    viaje.LatitudPartida = (decimal)parametro.Waypoints[0].LatLng.Lat;
                    viaje.LongitudPartida = (decimal)parametro.Waypoints[0].LatLng.Lng;
                    viaje.LatitudLlegada = (decimal)parametro.Waypoints[parametro.Waypoints.Count - 1].LatLng.Lat;
                    viaje.LongitudLegada = (decimal)parametro.Waypoints[parametro.Waypoints.Count - 1].LatLng.Lng;
                    GeoResponse partida = await ReverseGeocode(parametro.Waypoints[0].LatLng.Lng, parametro.Waypoints[0].LatLng.Lat);
                    if(partida != null)
                    {
                        if (partida.Features[0].Properties.Address != null)
                        {
                            if(partida.Features[0].Properties.Address.Town != null)
                            {
                                viaje.LugarPartida = partida.Features[0].Properties.Address.Town;
                            }
                            if (partida.Features[0].Properties.Address.State != null)
                            {
                                viaje.LugarPartida = partida.Features[0].Properties.Address.State;
                            }
                        }
                    }
                    GeoResponse llegada = await ReverseGeocode(parametro.Waypoints[parametro.Waypoints.Count - 1].LatLng.Lng, parametro.Waypoints[parametro.Waypoints.Count - 1].LatLng.Lat);
                    if (llegada != null)
                    {
                        if (llegada.Features[0].Properties.Address != null && llegada.Features[0].Properties.Address.State != null)
                        {
                            if (llegada.Features[0].Properties.Address.Town != null)
                            {
                                viaje.Lugarllegada = llegada.Features[0].Properties.Address.Town;
                            }
                            if (llegada.Features[0].Properties.Address.State != null) { 

                                viaje.Lugarllegada = llegada.Features[0].Properties.Address.State;
                            }
                        }
                    }
                    viaje.Update();
                }
                catch (Exception)
                {

                }
            }
            else
            {
                MessageBox.Show("Necesita un origen y un destino para poder guardar");
            }
        }

        /// <summary>
        /// elimina todos los trayecos relacionados con un viaje
        /// </summary>
        /// <param name="pViajeI"></param>
        /// <returns></returns>
        public static bool EliminaTrayectos(long pViajeI, char pEsorigen)
        {
            TrayectoViajeCollection lTrayectos = new TrayectoViajeCollection();
            lTrayectos.FillByViajeID(pViajeI);

            if (lTrayectos.Count > 0)
            {
                foreach (TrayectoViaje item in lTrayectos.Cast<TrayectoViaje>().ToList())
                {
                    if (pEsorigen == item.EsOrigen[0])
                    {
                        try
                        {
                            item.Delete();
                        }
                        catch
                        {
                            return false;//nose pudo eliminar el viaje salgo del proceso
                        }

                    }
                }


            }

            return true; // se eliminaron todos los trayectos

        }

        public static void GenerarGpx(long ViajeId)
        {
            try
            {

                Viaje viaje = new Viaje();
                viaje.Fill(ViajeId);
                TrayectoViajeCollection trayectos = new TrayectoViajeCollection();
                trayectos.FillByViajeID(ViajeId);
                List<TrayectoViaje> trayEn = new List<TrayectoViaje>();

                foreach (TrayectoViaje tra in trayectos)
                {
                    trayEn.Add(tra);
                }

                var routeGroups = trayEn.GroupBy(t => t.EsOrigen);
                List<Track> tracks = new List<Track>();

                foreach (var group in routeGroups)
                {
                    string isOriginRoute = group.Key;
                    var orderedWaypoints = group.OrderBy(t => t.Orden).ToList();
                    Track track = new Track() { Name =isOriginRoute == "S" ? "Ruta Original" : "Ruta alternativa"};

                    if (orderedWaypoints.Any())
                    {
                        foreach (var trayecto in orderedWaypoints)
                        {
                            var originPoint = new Point() { 
                                Latitude= (double)trayecto.TayectoLatitudOrigen,
                                Longitude= (double)trayecto.TrayectoLongitudOrigen,
                                Name = trayecto.TrayectoOrigen,
                                Description= $"Punto: {trayecto.Orden}"
                            };
                            track.Segments.Add(originPoint);
                            if (orderedWaypoints.IndexOf(trayecto) == orderedWaypoints.Count - 1)
                            {
                                var destPoint = new Point()
                                {
                                    Latitude = (double)trayecto.TrayectoLatidudDestino,
                                    Longitude = (double)trayecto.TrayectoLongitudDestino,
                                    Name = trayecto.TrayectoDestino,
                                    Description = $"Punto: {trayecto.Orden}"
                                };
                                track.Segments.Add(destPoint);
                            }
                        }

                    }
                    tracks.Add(track);
                }

                string kmlContent = File.ReadAllText(Path.Combine("Resource","lib","kml","viaje_template.xml"));

                // Reemplazar @VIAJENOMBRE
                kmlContent = kmlContent.Replace("@VIAJENOMBRE", viaje.ViajeNombre);
                string folderContent = string.Empty;
                foreach(var track in tracks)
                {
                    folderContent += GenerateFolderContent(track);
                }
                // Reemplazar @FOLDER
                kmlContent = kmlContent.Replace("@FOLDER", folderContent);
                string name = $"{viaje.ViajeNombre}.kml";
                string tempFile = Path.Combine("Resource", "temp", name);
                File.WriteAllText(tempFile, kmlContent);
                // Trigger the download
                Application.Download(tempFile, name);

                // Set a timer to delete the temporary file after 5 seconds
                Application.StartTimer(5000, 5000, () =>
                {
                    try
                    {
                        if (File.Exists(tempFile))
                            File.Delete(tempFile);
                    }
                    catch { /* Ignore cleanup errors */ }
                });
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error al generar archivo gpx");
            }
        }
        private static string GenerateFolderContent(Track track)
        {
            StringBuilder folderContent = new StringBuilder();
            folderContent.AppendLine("<Folder>");
            folderContent.AppendLine($"    <name>{track.Name}</name>");

            foreach (var placemark in track.Segments)
            {
                folderContent.AppendLine("    <Placemark>");
                folderContent.AppendLine($"        <name>{placemark.Name}</name>");
                folderContent.AppendLine($"        <description>{placemark.Description}</description>");
                folderContent.AppendLine("        <Point>");
                folderContent.AppendLine($"            <coordinates>{placemark.Longitude.ToString().Replace(",",".")},{placemark.Latitude.ToString().Replace(",", ".")}</coordinates>");
                folderContent.AppendLine("        </Point>");
                folderContent.AppendLine("    </Placemark>");
            }

            // Aquí agregamos un ejemplo de una línea que conecta dos puntos.
            if (track.Segments.Count > 1)
            {
       
                    folderContent.AppendLine("    <Placemark>");
                folderContent.AppendLine("        <name>Trayecto</name>");
                folderContent.AppendLine("        <styleUrl>#line-1267FF-5000-nodesc</styleUrl>");
                folderContent.AppendLine("        <LineString>");
                folderContent.AppendLine("            <tessellate>1</tessellate>");
                folderContent.AppendLine("            <coordinates>");

                // Solo tomamos las coordenadas de los dos primeros puntos para la línea.
                foreach (var placemark in track.Segments)
                { 
                folderContent.AppendLine($"                {placemark.Longitude.ToString().Replace(",", ".")},{placemark.Latitude.ToString().Replace(",", ".")}");
                }

                folderContent.AppendLine("            </coordinates>");
                folderContent.AppendLine("        </LineString>");
                folderContent.AppendLine("    </Placemark>");
            }

            folderContent.AppendLine("</Folder>");
            return folderContent.ToString();
        }

        public static async Task<GeoResponse> ReverseGeocode(double Lng, double Lat)
        {
            try
            {

                string url = $"https://nominatim.openstreetmap.org/reverse?lon={Lng.ToString().Replace(",",".")}&lat={Lat.ToString().Replace(",", ".")}&format=geojson";

                var client = new RestClient("https://nominatim.openstreetmap.org/");
                var request = new RestRequest("reverse", Method.GET);
                request.AddParameter("lon", Lng.ToString().Replace(",", "."));
                request.AddParameter("lat", Lat.ToString().Replace(",", "."));
                request.AddParameter("format", "geojson");

                var response = await client.ExecuteTaskAsync(request);
                if (response.IsSuccessful)
                {
                    return JsonConvert.DeserializeObject<GeoResponse>(response.Content);
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
