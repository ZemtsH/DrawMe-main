using DrawMe.Drawing;
using DrawMe.Solves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Figures
{
    public class BrushFigure : AbstractFigure
    {
        public BrushFigure()
        {
            drawing = new DrawByLine();
            solves = new BrushSolve();
        }
    }
}
