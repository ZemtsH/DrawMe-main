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
    public class PolygonSolve : ISolves
    {
        public Point[] DoPoint(Point[] points)
        {
            int num_theta = 6;
            float cx = Math.Abs(points[0].X - points[1].X) / 2;
            float cy = Math.Abs(points[0].Y - points[1].Y) / 2;
            float rx = Math.Min(cx, cy) - 10;
            float ry = rx;
            List<Point> finalPoints = new List<Point>();
            float dtheta = (float)(2 * Math.PI / num_theta);
            float theta = 0;

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
