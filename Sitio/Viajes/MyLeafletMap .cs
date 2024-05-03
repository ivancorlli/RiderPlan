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
                Name = "Leaflet",
                Source = "https://unpkg.com/leaflet@1.7.1/dist/leaflet.js"
            });

            this.Packages.Add(new Package()
            {
                Name = "LeafletCSS",
                Source = "https://unpkg.com/leaflet@1.7.1/dist/leaflet.css"
            });
        
            //this.Packages.Add(new Package()
            //{
            //    Name = "LeafletControlLayers",
            //    Source = "https://unpkg.com/leaflet@1.7.1/dist/leaflet-control-layers.js"
            //});
           
            //this.Packages.Add(new Package()
            //{
            //    Name = "LeafletRoutingMachineCSS",
            //    Source = "https://unpkg.com/leaflet-routing-machine/dist/leaflet-routing-machine.css"
            //});

            this.Packages.Add(new Package()
            {
                Name = "LeafletRoutingMachineJS",
                Source = "https://unpkg.com/leaflet-routing-machine@3.2.12/dist/leaflet-routing-machine.js"
            });

        
        }




    }
}
