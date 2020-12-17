using DrawMe.Drawing;
using DrawMe.Solves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Figures
{
    class LineFigure : AbstractFigure
    {
        public LineFigure()
        {
            drawing = new DrawByPoligon();
            solves = new LineSolve();
        }
    }
}
