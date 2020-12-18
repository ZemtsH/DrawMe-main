using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.NewFolder1
{
    public interface IMover
    {
        Point startPoint { get; set; }
        Bitmap MoveFigure(Color color, int width, Point[] points);
    }
}
