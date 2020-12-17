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

        public Bitmap GetBitmap()
        {
            return _mainBitmap;
        }

        public void SetBitmap(Bitmap bitmap)
        {
             _mainBitmap = bitmap; 
        }

        public Bitmap GetTempBitmap()
        {
            return _tmpBitmap;
        }

        public void SetTempBitmap()
        {
            _tmpBitmap = (Bitmap)_mainBitmap.Clone();
        }

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

    }
}
