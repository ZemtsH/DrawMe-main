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
    public class ChangeColorAction : IAction
    {
        public void OnMouseDown(out AbstractFigure figure, ActionParamter paramter)
        {
            figure = null;
            foreach (AbstractFigure crntFigure in Canvas.Instanse._figures)
            {
                if (crntFigure.CheckFigure(paramter.Point))
                {
                    figure = crntFigure;
                    Canvas.Instanse._figures.Remove(figure);
                    Canvas.Instanse.DrawAll();
                    figure.ChangeColor(paramter.Color);
                    Canvas.Instanse.GetTempBitmap();
                    break;
                }
            }
        }

        public Bitmap OnMouseMove(AbstractFigure figure, ActionParamter paramter)
        {
            return Canvas.Instanse.GetTempBitmap();
        }

        public void OnMouseUp(AbstractFigure figure, ActionParamter paramter)
        {
            throw new NotImplementedException();
        }

       
    }
}
