using DrawMe.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Actions
{
    class DrawAction : IAction
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
            return figure.Draw(p.Point);
        }

        public void OnMouseUp(AbstractFigure figure, ActionParamter paramter)
        {
            throw new NotImplementedException();
        }
    }
}
