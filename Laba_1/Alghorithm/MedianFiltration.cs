using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Laba_1
{
    //Сглаживание изображения методом медианной фильтрации
    class MedianFiltration
    {
        byte[] histogram = new byte[256];
        private void fillHistogram(byte[] pixels)
        {
            histogram = new byte[256];
            for (byte i = 0; i < pixels.Length; i++)
            {
                histogram[pixels[i]]++;
            }
        }
        private byte findMedian(byte windowSize)
        {
            byte count = 0;
            int border = (windowSize * windowSize + 1) / 2;
            byte i = 0;
            while (count < border)
            {
                count += histogram[i];
                i++;
            }
            return --i;
        }
        public Bitmap filter(Bitmap img, byte size) {
            if (size <= 0 || size % 2 == 0)
                return img;
            BitmapWrapper bmp = new BitmapWrapper(img);
            byte[] window;
            byte insertPixel;
            int middle = size / 2;

            for (int j = 0; j < img.Height - size; j++)
            {
                window = bmp.cutWindow(0, j, size);
                fillHistogram(window);
                for (int i = 0; i < img.Width - size; i++)
                {
                    insertPixel = findMedian(size);
                    bmp.setPixel(i + middle, j + middle, insertPixel);
                    window = bmp.cutWindow(i + 1, j, size);
                    fillHistogram(window);
                }
            }
            return bmp.getBitmap(img);
        }
    }
}
