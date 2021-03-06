﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Drawing
{
    public interface IDrawing
    {
        
        Point startPoint { get; set; }
        Bitmap DrawFigure(Color color, int width, Point[] points);
    }
}
