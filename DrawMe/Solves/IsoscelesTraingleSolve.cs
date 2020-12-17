using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Solves
{
    public class IsoscelesTraingleSolve : ISolves
    {
        public Point[] DoPoint(Point[] points)
        {
            Point three;
            int x = points[0].X - (points[1].X - points[0].X);
            three = new Point(x, points[1].Y);
            return new Point[] { points[0], points[1], three };
        }

        public Point[] DoPoint(Point[] points, bool check)
        {
            Point three;
            int y = points[0].Y - (points[1].Y - points[0].Y);
            three = new Point(points[1].X, y);
            return new Point[] { points[0], points[1], three };
        }
    }
}
