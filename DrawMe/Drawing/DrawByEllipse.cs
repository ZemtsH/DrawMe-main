using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Drawing
{
    public class DrawByEllipse : IDrawing
    {
        public Bitmap crntBit { get; set; }
        public Point startPoint { get; set; }
        public void DrawFigure(Color color, int width, Point[] points, Bitmap mainBm)
        {
            
        }
    }
}
