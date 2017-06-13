using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MappingStageOne
{
    class Draw
    {
        public static DrawingMode drawMode = DrawingMode.none;
        public static List<MapPoints> pointList = new List<MapPoints>();
        public static List<MapLines> lineList = new List<MapLines>();
        public static List<MapCircles> circleList = new List<MapCircles>();

        public enum DrawingMode
        {
            none = -1,
            point = 0,
            line = 1,
            circle = 2
        }

        public static void changeDrawingModes(object sender, EventArgs e)
        {
            CheckBox chkSender = null;
            if (sender.GetType() == typeof(CheckBox))
                chkSender = (CheckBox)sender;

            //Find the new drawing mode by parsing checkbox tag as an enum
            //this requires each checkbox calling this method to contain a
            //valid DrawingMode enum name in its tag
            DrawingMode newDrawingMode = DrawingMode.none;
            if (Enum.TryParse(chkSender.Tag.ToString(), out newDrawingMode))
                drawMode = (drawMode == newDrawingMode) ? drawMode = DrawingMode.none : drawMode = newDrawingMode;
            else
                drawMode = DrawingMode.none;
        }

        public static bool IsUnique(string name)
        {
            foreach (MapPoints point in pointList)
                if (name == point.Name)
                    return false;
            if ((lineList.Count > 0) && (name == lineList[0].GetPointList().ElementAt(0).Name))
                return false;
            foreach (MapCircles circle in circleList)
                if (name == circle.Name)
                    return false;

            return true;
        }
    }
}
