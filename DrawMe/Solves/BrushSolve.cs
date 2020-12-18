using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Solves
{
    public class BrushSolve : ISolves
    {
        List<Point> pointsL = new List<Point>();
        public Point[] DoPoint(Point[] points)
        {
            pointsL.Add(points[points.Length - 1]);
            return pointsL.ToArray(); // вроде так
        }
    }
}
