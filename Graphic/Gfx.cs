using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImgRescale
{
  class Gfx
  {
    /// <summary>
    /// Get image constraints
    /// </summary>
    /// <param name="org_x"></param>
    /// <param name="org_y"></param>
    /// <param name="max_x"></param>
    /// <param name="max_y"></param>
    /// <returns></returns>
    public static int[] GetConstraints(int org_x, int org_y,
                                       int max_x, int max_y)
    {
      int[] r = new int[2];
      float s = Math.Min((float)max_x / (float)org_x,
                         (float)max_y / (float)org_y);
      r[0] = (int)Math.Round(s * org_x);
      r[1] = (int)Math.Round(s * org_y);

      return r;
    }

    /// <summary>
    /// Scale image to <paramref name="width"/> and <paramref name="height"/>
    /// </summary>
    /// <param name="img"></param>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <returns></returns>
    public static Bitmap ScaleImage(Bitmap img, int width, int height)
    {
      Bitmap bmp = new Bitmap(img, width, height);
      bmp.SetResolution(96, 96);
      Graphics g = Graphics.FromImage(bmp);
      g.InterpolationMode =
        System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
      g.DrawImage(img,
                  new Rectangle(0, 0, width, height),
                  new Rectangle(0, 0, img.Width, img.Height),
                  GraphicsUnit.Pixel);

      g.Dispose();
      g = null;
      return bmp;
    }

    public static Bitmap ApplyAttributes(Bitmap img, ImageAttributes attr)
    {
      Bitmap bmp = new Bitmap(img.Width, img.Height);
      Graphics g = Graphics.FromImage(bmp);
      g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attr);
      g.Dispose();
      g = null;
      return bmp;
    }

    /// <summary>
    /// Returns a <see cref="ImageCodecInfo"/> info for
    /// <paramref name="mimetype"/> that can be used for compression settings.
    /// </summary>
    /// <param name="mimetype"></param>
    /// <returns></returns>
    public static ImageCodecInfo GetEncoderInfo(string mimetype)
    {
      foreach (ImageCodecInfo ici in ImageCodecInfo.GetImageDecoders()) {
        if (ici.MimeType == mimetype)
          return ici;
      }

      return null;
    }
  }
}
