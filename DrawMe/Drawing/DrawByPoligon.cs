using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrawMe.Canvases;

namespace DrawMe.Drawing
{
    public class DrawByPoligon : IDrawing
    {
        public Bitmap crntBit { get; set; }
        public Point startPoint { get; set; }
        public void DrawFigure(Color color, int width, Point[] points, Bitmap m)
        {
            Pen pen = new Pen(color, width);
            Canvas.Instanse.SetTempBitmap();
            
            Graphics graphics = Graphics.FromImage(Canvas.Instanse.GetTempBitmap());
            graphics.DrawPolygon(pen, points);
            //crntBit = (Bitmap)crnt.Clone();
        }
    }
}
