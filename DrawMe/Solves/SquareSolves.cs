using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawMe.Solves
{
    public class SquareSolves : ISolves
    {
        public Point[] DoPoint(Point[] points)
        {
            Point a, b, c;
            int del = points[1].Y - points[0].Y;



            a = new Point(points[0].X+del, points[0].Y);

            b = new Point(points[0].X+del, points[1].Y);

            c = new Point(points[0].X, points[1].Y);


            return new Point[] { points[0], a, b, c };

        }
    }
}
