using DrawMe.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Figures
{
    public abstract class AbstractFigure
    {
        public Color Color { get; set; }
        public int Width { get; set; }
        public List<Point> Points { get; set; }
        public IDrawing drawing;
        public ISolves solves;

        public bool CheckDraw()
        {
            if (Points == null)
            {
                return false;
            }
            return true;
        }

        public bool CheckFigure(Point point)
        {
            Point prevP = Points[Points.Count - 1];
            foreach (Point p in Points)
            {
                if (Contain(prevP, p, point, Width))
                {
                    return true;
                }
                prevP = p;
            }
            return false;
        }
        public void Draw(Point crnt, Bitmap mainBM)
        {
            Points = new List<Point>(solves.DoPoint(new Point[] { drawing.startPoint, crnt }));
            drawing.DrawFigure(Color, Width, Points.ToArray(), mainBM);
        }

        public void Move(Point crnt, Bitmap mainBM)
        {
            Point delta = new Point(crnt.X - drawing.startPoint.X, crnt.Y - drawing.startPoint.Y);
            drawing.startPoint = crnt;
            for (int p=0; p < Points.Count(); p++)
            {
                Point i = Points[p];
                Points[p] = new Point(i.X + delta.X, i.Y + delta.Y);
            }
            drawing.DrawFigure(Color, Width, Points.ToArray(), mainBM);
        }

        public void ChangeColor(Color color, Bitmap mainBM)
        {
            Color = color;
            drawing.DrawFigure(Color, Width, Points.ToArray(), mainBM);
        }

        public Bitmap ShowBit()
        {
            return drawing.crntBit;
        }

        public void DoStart(Point startPoint)
        {
            drawing.startPoint = startPoint;
        }

        public static void MouseMoving(AbstractFigure crntFigure, Point crnt, Bitmap mainBM)
        {
            crntFigure.Draw(crnt, mainBM);
        }
        public static void MouseDown(AbstractFigure abstractFigure, Point startPoint)
        {
            abstractFigure.DoStart(startPoint);

        }
        public static void MouseUp()
        {

        }

        private bool Contain(Point start, Point end, Point checkPoint, double accuracy)
        {
            double x1 = start.X;
            double y1 = start.Y;
            double x2 = end.X;
            double y2 = end.Y;
            double x = checkPoint.X;
            double y = checkPoint.Y;

            if (CheckInside(x, x1, x2, accuracy) && CheckInside(y, y1, y2, accuracy))
                return Math.Abs((x - x1) * (y2 - y1) - (y - y1) * (x2 - x1)) < accuracy / 2 * Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            else return false;
        }

        private bool CheckInside(double x, double a, double b, double accuracy)
        {
            if ((x > a - accuracy && x < b + accuracy) || (x > b - accuracy && x < a + accuracy))
                return true;
            else return false;
        }
    }
}
