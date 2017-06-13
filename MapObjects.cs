using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingStageOne
{
    class MapPoints
    {
        public string Name { get; }
        public double Latitude { get; }
        public double Longitude { get; }

        public MapPoints(string name, double latitude, double longitude)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }
    }

    class MapLines
    {
        List<MapPoints> linePoints = new List<MapPoints>();

        public MapLines(List<MapPoints> allPoints)
        {
            foreach (MapPoints point in allPoints)
                linePoints.Add(point);
        }

        public List<MapPoints> GetPointList()
        {
            return linePoints;
        }
    }

    class MapCircles : MapPoints
    {
        public ushort Radius { get; }

        public MapCircles(string name, double latitude, double longitude, ushort radius)
            : base(name, latitude, longitude)
        {
            Radius = radius;
        }
    }
}
