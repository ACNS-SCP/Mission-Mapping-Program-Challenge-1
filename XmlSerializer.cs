using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MappingStageOne
{
    class XmlSerializer
    {
        public static bool ImportXML(string fileName)
        {
            XmlReaderSettings settings = new XmlReaderSettings()
            {
                ConformanceLevel = ConformanceLevel.Fragment,
                IgnoreWhitespace = true,
                IgnoreComments = true
            };
            XmlReader xmlReader = XmlReader.Create(fileName, settings);

            try
            {
                while (xmlReader.Read())
                {
                    if (xmlReader.NodeType == XmlNodeType.Element)
                    {
                        double markerLatitude, markerLongitude;
                        switch (xmlReader.Name)
                        {
                            case "points":
                                if ((xmlReader.ReadToDescendant("point")) && (xmlReader.HasAttributes))
                                {
                                    Draw.pointList.Clear();
                                    do
                                    {
                                        string[] markerAttributes = { xmlReader.GetAttribute("name"), xmlReader.GetAttribute("latitude"),
                                        xmlReader.GetAttribute("longitude") };

                                        //Verifies the marker name is not null and the lat/lng are numbers
                                        if ((markerAttributes[0] != null) &&
                                            (double.TryParse(markerAttributes[1], out markerLatitude)) &&
                                            (double.TryParse(markerAttributes[2], out markerLongitude)))
                                            Draw.pointList.Add(new MapPoints(markerAttributes[0], markerLatitude, markerLongitude));
                                    } while (xmlReader.ReadToNextSibling("point"));
                                }
                                break;
                            case "lines":
                                if (xmlReader.ReadToDescendant("line"))
                                {
                                    Draw.lineList.Clear();
                                    do
                                    {
                                        List<MapPoints> linePoints = new List<MapPoints>();
                                        if ((xmlReader.ReadToDescendant("point")) && (xmlReader.HasAttributes))
                                        {
                                            do
                                            {
                                                string[] markerAttributes = { xmlReader.GetAttribute("name"), xmlReader.GetAttribute("latitude"),
                                        xmlReader.GetAttribute("longitude") };

                                                if ((markerAttributes[0] != null) &&
                                                            (double.TryParse(markerAttributes[1], out markerLatitude)) &&
                                                            (double.TryParse(markerAttributes[2], out markerLongitude)))
                                                    linePoints.Add(new MapPoints(markerAttributes[0], markerLatitude, markerLongitude));
                                            } while (xmlReader.ReadToNextSibling("point"));
                                            Draw.lineList.Add(new MapLines(linePoints));
                                        }
                                    } while (xmlReader.ReadToNextSibling("line"));

                                }
                                break;
                            case "circles":
                                if ((xmlReader.ReadToDescendant("circle")) && (xmlReader.HasAttributes))
                                {
                                    Draw.circleList.Clear();
                                    do
                                    {
                                        ushort radius;
                                        string[] markerAttributes = { xmlReader.GetAttribute("name"), xmlReader.GetAttribute("latitude"),
                                        xmlReader.GetAttribute("longitude"), xmlReader.GetAttribute("radius") };

                                        //Verifies the marker name is not null and the lat/lng/radius are numbers
                                        if ((markerAttributes[0] != null) &&
                                            (double.TryParse(markerAttributes[1], out markerLatitude)) &&
                                            (double.TryParse(markerAttributes[2], out markerLongitude)) &&
                                            (ushort.TryParse(markerAttributes[3], out radius)))
                                            Draw.circleList.Add(new MapCircles(markerAttributes[0], markerLatitude, markerLongitude, radius));
                                    } while (xmlReader.ReadToNextSibling("circle"));
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
                if ((Draw.pointList.Count > 0) || (Draw.lineList.Count > 0) || (Draw.circleList.Count > 0))
                    return true;
                return false;
            }
            catch
            {
                throw;
            }
            finally
            {
                xmlReader.Close();
            }
        }

        public static void ExportXML(string fileName)
        {
            XmlWriterSettings settings = new XmlWriterSettings()
            {
                Indent = true,
                IndentChars = "\t"
            };
            XmlWriter xmlWriter = XmlWriter.Create(fileName, settings);

            try
            {
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("markers");

                xmlWriter.WriteStartElement("points");
                foreach (MapPoints point in Draw.pointList)
                {
                    xmlWriter.WriteStartElement("point");
                    xmlWriter.WriteAttributeString("name", point.Name);
                    xmlWriter.WriteAttributeString("latitude", point.Latitude.ToString());
                    xmlWriter.WriteAttributeString("longitude", point.Longitude.ToString());
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("lines");
                foreach (MapLines line in Draw.lineList)
                {
                    xmlWriter.WriteStartElement("line");
                    foreach (MapPoints point in line.GetPointList())
                    {
                        xmlWriter.WriteStartElement("point");
                        xmlWriter.WriteAttributeString("name", point.Name);
                        xmlWriter.WriteAttributeString("latitude", point.Latitude.ToString());
                        xmlWriter.WriteAttributeString("longitude", point.Longitude.ToString());
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("circles");
                foreach (MapCircles circle in Draw.circleList)
                {
                    xmlWriter.WriteStartElement("circle");
                    xmlWriter.WriteAttributeString("name", circle.Name);
                    xmlWriter.WriteAttributeString("latitude", circle.Latitude.ToString());
                    xmlWriter.WriteAttributeString("longitude", circle.Longitude.ToString());
                    xmlWriter.WriteAttributeString("radius", circle.Radius.ToString());
                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
            }
            catch
            {
                throw;
            }
        }
    }
}
