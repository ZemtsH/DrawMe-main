using DrawMe.Canvases;
using DrawMe.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Actions
{
    public class MovePointAction : IAction
    {
        int indPoint;
        public void OnMouseDown(out AbstractFigure figure, ActionParamter paramter)
        {
            figure = null;
            foreach (AbstractFigure crntFigure in Canvas.Instanse._figures)
            {
                if (crntFigure.CheckFigure(paramter.Point))
                {
                    for (int i = 0; i < crntFigure.Points.Count(); i++)
                    {
                        if (crntFigure.CheckInsidePoint(crntFigure.Points[i], paramter.Point))
                        {
                            indPoint = i;
                            figure = crntFigure;
                            Canvas.Instanse._figures.Remove(figure);
                            Canvas.Instanse.DrawAll();
                            break;
                        }
                    }
                    break;
                }
            }
        }

        public void OnMouseMove(AbstractFigure figure, ActionParamter paramter)
        {
            if (figure != null)
            {
                Color color = figure.Color;
                int width = figure.Width;
                figure.Points[indPoint] = paramter.Point;
                figure.Mover.MoveFigure(color, width, figure.Points.ToArray());
            }
            Canvas.Instanse.GetBitmap();
        }

        public void OnMouseUp(AbstractFigure figure, ActionParamter paramter)
        {
            if (figure != null && figure.CheckDraw())
            {
                Canvas.Instanse.AddFigure(figure);
            }
            Canvas.Instanse.SetBitmap(Canvas.Instanse.GetTempBitmap());
        }

        
    }
}
