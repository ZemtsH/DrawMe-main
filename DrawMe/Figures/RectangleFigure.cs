using DrawMe.Drawing;
using DrawMe.Solves;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Figures
{
    public class RectangleFigure : AbstractFigure
    {
        public RectangleFigure()
        {
            drawing = new DrawByPoligon();
            solves = new RightTraingleSolve();
        }
    }
}
