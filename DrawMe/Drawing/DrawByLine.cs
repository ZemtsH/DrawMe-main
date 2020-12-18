using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrawMe.Canvases;

namespace DrawMe.Drawing
{
    class DrawByLine : IDrawing
    {
        public Bitmap crntBit { get; set; }
        public Point startPoint { get; set; }
        public Bitmap DrawFigure(Color color, int width, Point[] points)
        {
            Pen pen = new Pen(color, width);
            Canvas.Instanse.SetTempBitmap();
            Graphics graphics = Graphics.FromImage(Canvas.Instanse.GetBitmap());
            graphics.DrawLine(pen, startPoint, points[1]);
            startPoint = points[1];
            return Canvas.Instanse.GetBitmap();
        }
    }
}
