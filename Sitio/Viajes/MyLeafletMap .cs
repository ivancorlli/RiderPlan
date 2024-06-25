using System;
using Wisej.Core;
using Wisej.Web;

namespace RaiderPlan.Sitio.Viajes
{
    public class MyLeafletMap : Widget
    {
        public MyLeafletMap()
        {
            this.Packages.Add(new Package()
            {
                Name = "LeafletCSS",
                Source = "https://unpkg.com/leaflet@1.7.1/dist/leaflet.css"
            });

            this.Packages.Add(new Package()
            {
                Name = "Leaflet",
                Source = "https://unpkg.com/leaflet@1.7.1/dist/leaflet.js"
            });


            this.Packages.Add(new Package()
            {
                Name = "FontAwesomeCSS",
                Source = "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css"
            });

            //this.Packages.Add(new Package()
            //{
            //    Name = "leafletAwesomeMarkersCSS",
            //    Source = "https://cdnjs.cloudflare.com/ajax/libs/leaflet.awesome-markers/2.0.5/leaflet.awesome-markers.css"
            //});

            //this.Packages.Add(new Package()
            //{
            //    Name = "leafletAwesomeMarkersJS",
            //    Source = "https://cdnjs.cloudflare.com/ajax/libs/leaflet.awesome-markers/2.0.5/leaflet.awesome-markers.js"
            //});

            //this.Packages.Add(new Package()
            //{
            //    Name = "LeafletControlLayers",
            //    Source = "https://unpkg.com/leaflet@1.7.1/dist/leaflet-control-layers.js"
            //});

            this.Packages.Add(new Package()
            {
                Name = "LeafletRoutingMachineCSS",
                Source = "https://unpkg.com/leaflet-routing-machine/dist/leaflet-routing-machine.css"
            });

            this.Packages.Add(new Package()
            {
                Name = "LeafletRoutingMachineJS",
                Source = "https://unpkg.com/leaflet-routing-machine@3.2.12/dist/leaflet-routing-machine.js"
            });

            

        }




    }
}
