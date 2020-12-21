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
    class MoveAction : IAction
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
                    //figure.DoStartM(paramter.Point);
                    break;
                }
            }

        }

        public Bitmap OnMouseMove(AbstractFigure figure, ActionParamter paramter)
        {
            return figure.Move(paramter.Point); ;
        }

        public void OnMouseUp(AbstractFigure figure, ActionParamter paramter)
        {
            throw new NotImplementedException();
        }

        //private void DrawAll()
        //{
        //    int width = Canvas.Instanse.Width;
        //    int height = Canvas.Instanse.Height;
        //    Canvas.Instanse.SetBitmap(new Bitmap(width, height));


        //    foreach (AbstractFigure fig in Canvas.Instanse._figures)
        //    {
        //        var bitmap = fig.Mover.MoveFigure(fig.Color, fig.Width, fig.Points.ToArray());
        //        Canvas.Instanse.SetBitmap(bitmap);

        //    }

        //}
    }
}
