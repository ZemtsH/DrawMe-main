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
        public void DrawFigure(Color color, int width, Point[] points, Bitmap mainBm)
        {
            Pen pen = new Pen(color, width);
            //Canvas.Instanse.GetBitmap();
            Graphics graphics = Graphics.FromImage(Canvas.Instanse.GetBitmap());
            graphics.DrawLine(pen, startPoint, points[1]);
            startPoint = points[1];
            //crntBit = (Bitmap)mainBm.Clone();
        }
    }
}
