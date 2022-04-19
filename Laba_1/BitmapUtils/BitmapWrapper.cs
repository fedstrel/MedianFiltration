using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Laba_1
{
    class BitmapWrapper
    {
        byte[] bmp;
        System.Drawing.Imaging.BitmapData bmpData;
        public BitmapWrapper()
        { 
            
        }
        public BitmapWrapper(Bitmap img)
        {
            Rectangle frame = new Rectangle(0, 0, img.Width, img.Height);
            bmpData = img.LockBits(frame, System.Drawing.Imaging.ImageLockMode.ReadWrite, img.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            bmp = new byte[bmpData.Stride * bmpData.Height];
            Marshal.Copy(ptr, bmp, 0, bmpData.Stride * bmpData.Height);
        }
        public Bitmap getBitmap(Bitmap img)
        {
            Marshal.Copy(bmp, 0, bmpData.Scan0, bmpData.Stride * bmpData.Height);
            img.UnlockBits(bmpData);
            return img;
        }
        public byte getPixel(int x, int y)
        {
            int pos = y * bmpData.Stride + x * 4;
            return bmp[pos];
        }
        public void setPixel(int x, int y, byte color)
        {
            int pos = y * bmpData.Stride + x * 4;
            bmp[pos] = color;
            bmp[pos + 1] = color;
            bmp[pos + 2] = color;
            bmp[pos + 3] = 255;
        }
        public byte[] cutWindow(int x, int y, byte size)
        {
            byte[] window = new byte[size * size];
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    window[j * size + i] = bmp[(j + y) * bmpData.Stride + (i + x) * 4];
                }
            }
            return window;
        }
        public byte[] getColumn(byte[] array, int colNum, byte size)
        {
            byte[] col = new byte[size];
            for (int i = 0; i < size; i ++)
            {
                col[i] = array[colNum + i * size];
            }
            return col;
        }
    }
}
