using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BATCHTO16BITBMP
{
    class cimage
    {
       
        
        public Bitmap to16bit(Bitmap sourceimg)
        {
            Bitmap bb = new Bitmap(sourceimg.Width, sourceimg.Height, System.Drawing.Imaging.PixelFormat.Format16bppRgb565);

            for (int i = 0; i < sourceimg.Height; i++)
            {
                for (int j = 0; j < sourceimg.Width; j++)
                {
                    bb.SetPixel(j, i, sourceimg.GetPixel(j, i));
                }
            }
            return bb;

        }
    }

}
