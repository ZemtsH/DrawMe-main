using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Drawing
{
    public interface IDrawing
    {
        Bitmap crntBit { get; set; }
        Point startPoint { get; set; }
        void DrawFigure(Color color, int width, Point[] points, Bitmap mainBm);
    }
}
