using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Solves
{
    public class RightTraingleSolve : ISolves
    {
        public Point[] DoPoint(Point[] points)
        {
            Point three;

            three = new Point(points[0].X, points[1].Y);

            return new Point[] { points[0], points[1], three }; 
        }
    }
}
