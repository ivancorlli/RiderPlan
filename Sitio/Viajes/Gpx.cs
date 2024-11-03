using System.Collections.Generic;

namespace RaiderPlan.Sitio.Viajes
{


public class Point
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}

public
class Track
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Point> Segments { get; set; } = new List<Point>();
}
};

