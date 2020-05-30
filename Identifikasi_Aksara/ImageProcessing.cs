using Accord.Imaging.Filters;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Identifikasi_Aksara
{
    internal class ImageProcessing
    {
        private Bitmap copy, bmp8bpp, bmpresult, newimg;
        private Color c;
        private Graphics graphics;
        private int r, g, b, w, h, size;
        private Point min, max;
        private Rectangle cropRectangle, newrect;
        private string str;

        internal Bitmap PreProcessing(Bitmap bit, int pb)
        {
            copy = new Bitmap(bit);

            for (int i = 0; i < bit.Width; i++)
            {
                for (int j = 0; j < bit.Height; j++)
                {
                    c = bit.GetPixel(i, j);

                    r = c.R;
                    g = c.G;
                    b = c.B;

                    if (pb == 0)
                    {
                        r = g = b = (r + g + b) / 3;
                    }

                    if (pb == 1)
                    {
                        if (r < 128 || g < 128 || b < 128)
                        {
                            r = g = b = 0;
                        }
                        else
                        {
                            r = g = b = 255;
                        }
                    }

                    copy.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }

            return copy;
        }

        internal Bitmap PreProcessing_Cropping(Bitmap bit)
        {
            min = new Point(int.MaxValue, int.MaxValue);
            max = new Point(int.MinValue, int.MinValue);

            for (int i = 0; i < bit.Width; ++i)
            {
                for (int j = 0; j < bit.Height; ++j)
                {
                    c = bit.GetPixel(i, j);

                    if (!(c.R == 255 && c.G == 255 && c.B == 255))
                    {
                        if (i < min.X) // kiri
                        {
                            min.X = i;
                        }

                        if (j < min.Y) // bawah
                        {
                            min.Y = j;
                        }

                        if (i > max.X) // kanan
                        {
                            max.X = i;
                        }

                        if (j > max.Y) // atas
                        {
                            max.Y = j;
                        }
                    }
                }
            }

            cropRectangle = new Rectangle(min.X, min.Y, max.X - min.X, max.Y - min.Y);

            copy = new Bitmap(cropRectangle.Width, cropRectangle.Height);

            graphics = Graphics.FromImage(copy);
            graphics.DrawImage(bit, 0, 0, cropRectangle, GraphicsUnit.Pixel);

            return copy;
        }

        internal Bitmap PreProcessing_Thinning(Bitmap bit)
        {
            copy = new Bitmap(bit);

            for (int i = 0; i < copy.Width; i++)
            {
                for (int j = 0; j < copy.Height; j++)
                {
                    c = copy.GetPixel(i, j);

                    r = c.R;
                    g = c.G;
                    b = c.B;

                    if (r == 255)
                    {
                        r = 0;
                    }
                    else if (r == 0)
                    {
                        r = 255;
                    }

                    if (g == 255)
                    {
                        g = 0;
                    }
                    else if (g == 0)
                    {
                        g = 255;
                    }

                    if (b == 255)
                    {
                        b = 0;
                    }
                    else if (b == 0)
                    {
                        b = 255;
                    }

                    copy.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }

            ZhangSuenSkeletonization filter = new ZhangSuenSkeletonization();

            bmp8bpp = Grayscale.CommonAlgorithms.BT709.Apply(copy);

            bmpresult = filter.Apply(bmp8bpp);

            copy = new Bitmap(bmpresult.Width, bmpresult.Height, PixelFormat.Format24bppRgb);

            graphics = Graphics.FromImage(copy);
            graphics.DrawImage(bmpresult, new Rectangle(0, 0, copy.Width, copy.Height));

            for (int i = 0; i < copy.Width; i++)
            {
                for (int j = 0; j < copy.Height; j++)
                {
                    c = copy.GetPixel(i, j);

                    r = c.R;
                    g = c.G;
                    b = c.B;

                    if (r == 255)
                    {
                        r = 0;
                    }
                    else if (r == 0)
                    {
                        r = 255;
                    }

                    if (g == 255)
                    {
                        g = 0;
                    }
                    else if (g == 0)
                    {
                        g = 255;
                    }

                    if (b == 255)
                    {
                        b = 0;
                    }
                    else if (b == 0)
                    {
                        b = 255;
                    }

                    copy.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }

            return copy;
        }

        internal string ChainCode(Bitmap bit)
        {
            str = "";
            size = 10; // set size	

            w = size;
            h = size;

            copy = new Bitmap(bit);
            newrect = new Rectangle(0, 0, w, h);
            newimg = new Bitmap(w, h);

            newimg.SetResolution(copy.HorizontalResolution, copy.VerticalResolution);

            graphics = Graphics.FromImage(newimg);
            graphics.CompositingMode = CompositingMode.SourceCopy;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            ImageAttributes wrapMode = new ImageAttributes();
            wrapMode.SetWrapMode(WrapMode.TileFlipXY);
            graphics.DrawImage(copy, newrect, 0, 0, copy.Width, copy.Height, GraphicsUnit.Pixel, wrapMode);

            Color c0, c1, c2, c3, c4, c5, c6, c7;
            int jr, r0, r1, r2, r3, r4, r5, r6, r7;

            for (int x = 0; x < newimg.Width; x++)
            {
                if (x == 0 || (x > 1 && x % 2 == 0))
                {
                    for (int y = newimg.Height - 1; y >= 0; y--)
                    {
                        Color clr = newimg.GetPixel(x, y);
                        if (x < newimg.Width - 1)
                        {
                            c0 = newimg.GetPixel(x + 1, y);
                            r0 = c0.R;
                            if (r0 == 255) { r0 = 0; }
                            else { r0 = 1; }
                        }
                        else { r0 = 0; }

                        if (x < newimg.Width - 1 && y > 0)
                        {
                            c1 = newimg.GetPixel(x + 1, y - 1);
                            r1 = c1.R;
                            if (r1 == 255) { r1 = 0; }
                            else { r1 = 1; }
                        }
                        else { r1 = 0; }

                        if (y > 0)
                        {
                            c2 = newimg.GetPixel(x, y - 1);
                            r2 = c2.R;
                            if (r2 == 255) { r2 = 0; }
                            else { r2 = 1; }
                        }
                        else { r2 = 0; }

                        if (x > 0 && y > 0)
                        {
                            c3 = newimg.GetPixel(x - 1, y - 1);
                            r3 = c3.R;
                            if (r3 == 255) { r3 = 0; }
                            else { r3 = 1; }
                        }
                        else { r3 = 0; }

                        if (x > 0)
                        {
                            c4 = newimg.GetPixel(x - 1, y);
                            r4 = c4.R;
                            if (r4 == 255) { r4 = 0; }
                            else { r4 = 1; }
                        }
                        else { r4 = 0; }

                        if (x > 0 && y < newimg.Height - 1)
                        {
                            c5 = newimg.GetPixel(x - 1, y + 1);
                            r5 = c5.R;
                            if (r5 == 255) { r5 = 0; }
                            else { r5 = 1; }
                        }
                        else { r5 = 0; }

                        if (y < newimg.Height - 1)
                        {
                            c6 = newimg.GetPixel(x, y + 1);
                            r6 = c6.R;
                            if (r6 == 255) { r6 = 0; }
                            else { r6 = 1; }
                        }
                        else { r6 = 0; }

                        if (x < newimg.Width - 1 && y < newimg.Height - 1)
                        {
                            c7 = newimg.GetPixel(x + 1, y + 1);
                            r7 = c7.R;
                            if (r7 == 255) { r7 = 0; }
                            else { r7 = 1; }
                        }
                        else { r7 = 0; }

                        jr = r0 + r1 + r2 + r3 + r4 + r5 + r6 + r7;
                        str = str + jr.ToString();
                    }
                }
                else if (x == 1 || (x > 1 && x % 2 == 1))
                {
                    for (int y = 0; y < newimg.Height; y++)
                    {
                        Color clr = newimg.GetPixel(x, y);
                        if (x < newimg.Width - 1)
                        {
                            c0 = newimg.GetPixel(x + 1, y);
                            r0 = c0.R;
                            if (r0 == 255) { r0 = 0; }
                            else { r0 = 1; }
                        }
                        else { r0 = 0; }

                        if (x < newimg.Width - 1 && y > 0)
                        {
                            c1 = newimg.GetPixel(x + 1, y - 1);
                            r1 = c1.R;
                            if (r1 == 255) { r1 = 0; }
                            else { r1 = 1; }
                        }
                        else { r1 = 0; }

                        if (y > 0)
                        {
                            c2 = newimg.GetPixel(x, y - 1);
                            r2 = c2.R;
                            if (r2 == 255) { r2 = 0; }
                            else { r2 = 1; }
                        }
                        else { r2 = 0; }

                        if (x > 0 && y > 0)
                        {
                            c3 = newimg.GetPixel(x - 1, y - 1);
                            r3 = c3.R;
                            if (r3 == 255) { r3 = 0; }
                            else { r3 = 1; }
                        }
                        else { r3 = 0; }

                        if (x > 0)
                        {
                            c4 = newimg.GetPixel(x - 1, y);
                            r4 = c4.R;
                            if (r4 == 255) { r4 = 0; }
                            else { r4 = 1; }
                        }
                        else { r4 = 0; }

                        if (x > 0 && y < newimg.Height - 1)
                        {
                            c5 = newimg.GetPixel(x - 1, y + 1);
                            r5 = c5.R;
                            if (r5 == 255) { r5 = 0; }
                            else { r5 = 1; }
                        }
                        else { r5 = 0; }

                        if (y < newimg.Height - 1)
                        {
                            c6 = newimg.GetPixel(x, y + 1);
                            r6 = c6.R;
                            if (r6 == 255) { r6 = 0; }
                            else { r6 = 1; }
                        }
                        else { r6 = 0; }

                        if (x < newimg.Width - 1 && y < newimg.Height - 1)
                        {
                            c7 = newimg.GetPixel(x + 1, y + 1);
                            r7 = c7.R;
                            if (r7 == 255) { r7 = 0; }
                            else { r7 = 1; }
                        }
                        else { r7 = 0; }

                        jr = r0 + r1 + r2 + r3 + r4 + r5 + r6 + r7;
                        str = str + jr.ToString();
                    }
                }
            }

            return str;
        }

        internal void PreProcessing_Splitting(Bitmap bit)
        {
            copy = new Bitmap(bit);

            for (int i = 0; i < copy.Width; i++)
            {
                for (int j = 0; j < copy.Height; j++)
                {
                    c = copy.GetPixel(i, j);
                }
            }
        }
    }
}