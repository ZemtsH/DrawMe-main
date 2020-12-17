using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawMe.Solves
{
    public class RectangleSolve : ISolves
    {
        public Point[] DoPoint(Point[] points)
        {
            Point a, b;

            b = new Point(points[0].X, points[1].Y);
            a = new Point(points[1].X, points[0].Y);

            return new Point[] { points[0], a, points[1], b };
        }
    }
}
