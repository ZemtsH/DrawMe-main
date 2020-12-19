using DrawMe.Canvases;
using DrawMe.Factory;
using DrawMe.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Actions
{
    public interface IAction
    {
        Bitmap OnMouseMove( AbstractFigure figure, ActionParamter paramter);
        void OnMouseDown(out AbstractFigure figure, ActionParamter paramter);
        void OnMouseUp( AbstractFigure figure, ActionParamter paramter);

    }



    //public interface IActionResult
    //{


    //}

    //public class EmptyActionResult : IActionResult
    //{

    //}

    //public class BitmapActionResult : IActionResult
    //{
    //    public Bitmap Image { get; set; }

    //    public Bitmap BitmapActionResultt(Bitmap image)
    //    {
    //        return image;
    //    }
    //}

    public class ActionParamter
    {
        public Point Point { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }
        public IFactory Factory { get; set; }

    }


    public class DrawAction : IAction
    {
        public void OnMouseDown(out AbstractFigure figure, ActionParamter paramter)
        {
            var p = paramter;
            figure = p.Factory.CreateFigure();
            figure.Color = p.Color;
            figure.Width = p.Width;
            figure.DoStart(p.Point);
            //return new EmptyActionResult();
        }

        public Bitmap OnMouseMove(AbstractFigure figure, ActionParamter paramter)
        {
            var p = (ActionParamter)paramter;
            return  figure.Draw(p.Point);
        }

        public void OnMouseUp(AbstractFigure figure, ActionParamter paramter)
        {
            throw new NotImplementedException();
        }
    }

    public class MoveAction : IAction
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
                    DrawAll();
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

        private void DrawAll()
        {
            int width = Canvas.Instanse.Width;
            int height = Canvas.Instanse.Height;
            Canvas.Instanse.SetBitmap(new Bitmap(width, height));


            foreach (AbstractFigure fig in Canvas.Instanse._figures)
            {
                var bitmap = fig.Mover.MoveFigure(fig.Color, fig.Width, fig.Points.ToArray());
                Canvas.Instanse.SetBitmap(bitmap);

            }

        }
    }

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
                    DrawAll();
                    figure.ChangeColor(paramter.Color);
                    Canvas.Instanse.GetTempBitmap();
                    break;
                }
            }
        }

        public Bitmap OnMouseMove(AbstractFigure figure, ActionParamter paramter)
        {
            return Canvas.Instanse.GetBitmap();
        }

        public void OnMouseUp(AbstractFigure figure, ActionParamter paramter)
        {
            throw new NotImplementedException();
        }

        private void DrawAll()
        {
            int width = Canvas.Instanse.Width;
            int height = Canvas.Instanse.Height;
            Canvas.Instanse.SetBitmap(new Bitmap(width, height));


            foreach (AbstractFigure fig in Canvas.Instanse._figures)
            {
                var bitmap = fig.Mover.MoveFigure(fig.Color, fig.Width, fig.Points.ToArray());
                Canvas.Instanse.SetBitmap(bitmap);

            }

        }
    }
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
                            DrawAll();
                            break;
                        }
                    }
                    break;
                }
            }
        }

        public Bitmap OnMouseMove(AbstractFigure figure, ActionParamter paramter)
        {
            if (figure != null)
            {
                Color color = figure.Color;
                int width = figure.Width;
                figure.Points[indPoint] = paramter.Point;
                return figure.Mover.MoveFigure(color, width, figure.Points.ToArray());
            }
            return Canvas.Instanse.GetBitmap();
        }

        public void OnMouseUp(AbstractFigure figure, ActionParamter paramter)
        {
            throw new NotImplementedException();
        }

        private void DrawAll()
        {
            int width = Canvas.Instanse.Width;
            int height = Canvas.Instanse.Height;
            Canvas.Instanse.SetBitmap(new Bitmap(width, height));


            foreach (AbstractFigure fig in Canvas.Instanse._figures)
            {
                var bitmap = fig.Mover.MoveFigure(fig.Color, fig.Width, fig.Points.ToArray());
                Canvas.Instanse.SetBitmap(bitmap);

            }

        }
    }
}
