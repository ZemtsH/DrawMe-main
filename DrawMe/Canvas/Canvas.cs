using DrawMe.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMe.Canvases
{
    public class Canvas
    {
        static private Canvas _main;

        private Bitmap _mainBitmap;
        private Bitmap _tmpBitmap;

        public int Width { get; set; }
        public int Height{ get; set; }

        public List<AbstractFigure> _figures;

        public static Canvas Instanse
        {
            get
            {
                {
                    if (_main == null)
                    {
                        _main = new Canvas();
                    }
                    return _main;
                }
            }
        }
        public Bitmap GetBitmap()
        {
            return _mainBitmap;
        }

        public void SetBitmap(Bitmap bitmap)
        {
             _mainBitmap = bitmap;
           // _figures = new List<AbstractFigure>();
        }

        public Bitmap GetTempBitmap()
        {
            return _tmpBitmap;
        }

        public void SetTempBitmap()
        {
            _tmpBitmap = (Bitmap)_mainBitmap.Clone();
        }

        public void AddFigure(AbstractFigure figure)
        {
            _figures.Add(figure);
        }

        public void DrawAll()
        {
            int width = Instanse.Width;
            int height = Instanse.Height;
            Instanse.SetBitmap(new Bitmap(width, height));
            Instanse.SetTempBitmap();


            foreach (AbstractFigure fig in Instanse._figures)
            {
                var bitmap = fig.Mover.MoveFigure(fig.Color, fig.Width, fig.Points.ToArray());
                Instanse.SetBitmap(bitmap);
            }

        }




    }
}
