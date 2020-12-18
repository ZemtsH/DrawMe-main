using DrawMe.Drawing;
using DrawMe.NewFolder1;
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
        protected ISolves solves;
        public IMover Mover;

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

        public bool CheckFigurePoint(Point point, Point eLoc)
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
        public Bitmap Draw(Point crnt)
        {
            Points = new List<Point>(solves.DoPoint(new Point[] { drawing.startPoint, crnt }));
            return drawing.DrawFigure(Color, Width, Points.ToArray());
        }

        public Bitmap Move(Point crnt)
        {
            Point delta = new Point(crnt.X - drawing.startPoint.X, crnt.Y - drawing.startPoint.Y);
            drawing.startPoint = crnt;
            for (int p=0; p < Points.Count(); p++)
            {
                Point i = Points[p];
                Points[p] = new Point(i.X + delta.X, i.Y + delta.Y);
            }
            return Mover.MoveFigure(Color, Width, Points.ToArray());
        }

        public void ChangeColor(Color color)
        {
            Color = color;
            Mover.MoveFigure(Color, Width, Points.ToArray());
        }

        public void DoStart(Point startPoint)
        {
            drawing.startPoint = startPoint;
        }

        public void DoStartM(Point startPoint)
        {
            Mover.startPoint = startPoint;
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
