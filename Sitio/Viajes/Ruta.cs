using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RaiderPlan.Sitio.Viajes
{

        public class Resumen
    {
        [JsonProperty("totalDistance")]
        public double TotalDistance { get; set; }

        [JsonProperty("totalTime")]
        public double TotalTime { get; set; }
    }

    public class Coordenada
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

   
    public class LatLng
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public class Waypoint
    {
       
        [JsonProperty("latLng")]
        public LatLng LatLng { get; set; }

        
    }

    public class Instruccion
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("time")]
        public double Time { get; set; }

        [JsonProperty("road")]
        public string Road { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("modifier")]
        public string Modifier { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class InputWaypoint
    {
        
        [JsonProperty("latLng")]
        public LatLng LatLng { get; set; }
               
    }

    public class Ruta
    {
        [JsonProperty("resumen")]
        public Resumen Resumen { get; set; }

        [JsonProperty("coordenadas")]
        public List<Coordenada> Coordenadas { get; set; }

        [JsonProperty("waypoints")]
        public List<Waypoint> Waypoints { get; set; }

        [JsonProperty("instrucciones")]
        public List<Instruccion> Instrucciones { get; set; }

        [JsonProperty("inputWaypoints")]
        public List<InputWaypoint> InputWaypoints { get; set; }
    }






}
