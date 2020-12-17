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
            int del1, del2;
            del1 = points[0].X - points[1].X;
            del2 = points[0].Y - points[1].Y;

            if (del1 > del2 && del1 == del2)
            {
                Point a, b, c;

                b = new Point(points[0].X, points[1].Y+del1);

                a = new Point(points[1].X+del1, points[0].Y);

                c = new Point(points[0].X + del1, points[0].Y + del1);


                return new Point[] { points[0], a, c , b };
            }
            else {
                Point a, b, c;

                b = new Point(points[0].X, points[1].Y + del2);

                a = new Point(points[1].X + del2, points[0].Y);

                c = new Point(points[0].X + del2, points[0].Y + del2);


                return new Point[] { points[0], a, c, b };
            }
        }
    }
}
