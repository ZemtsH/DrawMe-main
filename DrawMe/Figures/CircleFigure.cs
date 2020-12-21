using DrawMe.Drawing;
using DrawMe.Solves;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawMe.Figures
{
    public class CircleFigure : AbstractFigure
    {
        
            public CircleFigure()
            {
                drawing = new DrawByPoligon();
                solves = new CircleSolves();
            }
        }
    
}

