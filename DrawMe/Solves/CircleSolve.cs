

using DrawMe.Drawing;
using DrawMe.Solves;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DrawMe.Solves
{
    public class CircleSolves : ISolves
    {
        public Point[] DoPoint(Point[] points)
        {
            int num_theta = 360;
            int cx = points[0].X;
            int cy = points[0].Y;
            int rx = points[1].X;
            int ry = points[1].Y;
            List<Point> finalPoints = new List<Point>();
            int dtheta = (int)(2 * Math.PI / num_theta);
            int theta = 0;
            for (int i = 0; i < num_theta; i++)
            {
                int x = (int)(cx + rx * Math.Cos(theta));
                int y = (int)(cy + ry * Math.Sin(theta));
                finalPoints.Add(new Point(x, y));
                theta += dtheta;
            }
            return finalPoints.ToArray();
        }
    }
}