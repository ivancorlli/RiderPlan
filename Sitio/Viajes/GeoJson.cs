using System.Collections.Generic;

namespace RaiderPlan.Sitio.Viajes
{
    public class GeoResponse
    {
        public string Type { get; set; }
        public string Licence { get; set; }
        public Feature[] Features { get; set; }
    }

    public class Feature
    {
        public string Type { get; set; }
        public Properties Properties { get; set; }
        public List<double> Bbox { get; set; }
        public Geometry Geometry { get; set; }
    }

    public class Geometry
    {
        public double[] Coordinates { get; set; } // [longitude, latitude]
        public string Type { get; set; }
    }

    public class Properties
    {
        public long PlaceId { get; set; }
        public string OsmType { get; set; }
        public long OsmId { get; set; }
        public int PlaceRank { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public double Importance { get; set; }
        public string Addresstype { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string Road { get; set; }
        public string IsolatedDwelling { get; set; }
        public string Town { get; set; }
        public string StateDistrict { get; set; }
        public string State { get; set; }
        public string ISO3166_2_lvl4 { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
    }

}
