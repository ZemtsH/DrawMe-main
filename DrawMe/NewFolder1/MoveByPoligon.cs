﻿using DrawMe.Canvases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.NewFolder1
{
    class MoveByPoligon : IMover
    {
        public Point startPoint { get; set; }

        public Bitmap MoveFigure(Color color, int width, Point[] points)
        {
            Pen pen = new Pen(color, width);
            Canvas.Instanse.SetTempBitmap();

            Graphics graphics = Graphics.FromImage(Canvas.Instanse.GetTempBitmap());
            graphics.DrawPolygon(pen, points);
            //crntBit = (Bitmap)crnt.Clone();
            return Canvas.Instanse.GetTempBitmap();
        }
    }
}
