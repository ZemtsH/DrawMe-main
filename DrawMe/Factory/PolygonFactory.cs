﻿using DrawMe.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Factory
{
    class PolygonFactory : IFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new PolygonFigure();
        }
    }
}
