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
}
