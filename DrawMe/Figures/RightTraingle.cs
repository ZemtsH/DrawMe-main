using DrawMe.Drawing;
using DrawMe.NewFolder1;
using DrawMe.Solves;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Figures
{
    public class RightTraingle : AbstractFigure
    {
        public RightTraingle()
        {
            drawing = new DrawByPoligon();
            solves = new RightTraingleSolve();
            Mover = new MoveByPoligon();
        }

      
    }
}
