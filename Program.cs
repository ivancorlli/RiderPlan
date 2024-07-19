using RaiderPlan.Sitio.Viajes;
using System;
using System.Runtime.InteropServices.ComTypes;
using Wisej.Core;
using Wisej.Web;
using Raiderplan1;
using Newtonsoft.Json;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

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
        public static void MiMetodoWeb2(string jsonParametro)
        {

            // var parametro= Newtonsoft.Json.JsonConvert.DeserializeObject<List<Marcador>>(jsonParametro);
            Ruta parametro = Newtonsoft.Json.JsonConvert.DeserializeObject<Ruta>(jsonParametro);
            //Viajes.MiMetodoWeb(parametro);
            //controlo que el parametro no llegue nulo
            if (parametro.InputWaypoints.Count > 1)
            {
                //recorro los waypoints (los distintos marcadores para armar los trayectos del viaje en el detalle)

                //recorro los puntos maracados en el mapa menos el ultimo ya que este marca el destino
                for (int i = 0; i < parametro.InputWaypoints.Count-1; i++)
                {
                    TrayectoViaje oTrayectoViaje = new TrayectoViaje();

                    oTrayectoViaje.ViajeID = 1; //relaciono con el viaje con el trayecto
                    oTrayectoViaje.TayectoLatitudOrigen = (decimal)parametro.InputWaypoints[i].LatLng.Lat;
                    oTrayectoViaje.TrayectoLongitudOrigen = (decimal)parametro.InputWaypoints[i].LatLng.Lng; ;

                    oTrayectoViaje.TrayectoLatidudDestino = (decimal)parametro.InputWaypoints[i+1].LatLng.Lat;
                    oTrayectoViaje.TrayectoLongitudDestino = (decimal)parametro.InputWaypoints[i+1].LatLng.Lng;



                }





            }
            else
            {
                MessageBox.Show("Necesita un origen y un destino para poder guardar");
            }



        }

        // You can use the entry method below
        // to receive the parameters from the URL in the args collection.
        //
        //static void Main(NameValueCollection args)
        //{
        //}

    }


}