using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImgRescale
{
  /// <summary>
  /// Class that manipulates images
  /// </summary>
  public class Image : Indexer, IDisposable
  {
    /// <summary>
    /// Max width for images
    /// </summary>
    public static int MaxWidth = 1024;

    /// <summary>
    /// Max height for images
    /// </summary>
    public static int MaxHeight = 1000;

    /// <summary>
    /// Handled extensions
    /// </summary>
    public static readonly string[] AllowedFiles = new string[]{
			".jpg", ".jpeg", ".tif", ".tiff", ".gif", ".png", ".bmp"
		};

    /// <summary>
    /// Attributes to apply to images
    /// </summary>
    public static ImageAttributes Attributes = null;

    /// <summary>
    /// Callback for when an image object is created
    /// </summary>
    public static ImageProcessedCallback ImageCreated;

    /// <summary>
    /// Returns the mimetype for an extension.
    /// </summary>
    /// <param name="ext"></param>
    /// <param name="fmt"></param>
    /// <returns></returns>
    public static string GetMimeTypeForExtension(string ext, out ImageFormat fmt)
    {
      switch (ext.ToLower()) {
        case ".tif":
        case ".tiff":
          fmt = ImageFormat.Tiff;
          return "image/tiff";

        case ".png":
          fmt = ImageFormat.Png;
          return "image/png";

        case ".gif":
          fmt = ImageFormat.Gif;
          return "image/gif";

        case ".bmp":
          fmt = ImageFormat.Bmp;
          return "image/bmp";

        default:
          fmt = ImageFormat.Jpeg;
          return "image/jpeg";
      }
    }

    /// <summary>
    /// Checks if the extension <paramref name="s"/> exists in
    /// <see cref="AllowedFiles"/>
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    private static bool isKnownExtension(string s)
    {
      s = s.ToLower();
      foreach (string ss in AllowedFiles)
        if (s == ss)
          return true;
      return false;
    }

    /// <summary>
    /// Chekcks if <paramref name="path"/> is a valid image file
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public static bool IsAllowed(string path)
    {
      FileInfo fi = new FileInfo(path);
      
      Log.Debug("+ Kollar om \"{0}\" kan processas...", fi.Name);

      if (!fi.Exists) {
        Log.Debug("NEJ! Filen finns inte!\n");
        return false;
      }

      if (!isKnownExtension(fi.Extension)) {
        Log.Debug("NEJ! Inte en tillåten filtyp\n");
        return false;
      }

      try {
        if (Attributes == null) {
          System.Drawing.Image img = (System.Drawing.Image)(new Bitmap(path, true));
          if (img.Width > MaxWidth || img.Height > MaxHeight ||
              img.HorizontalResolution > 96.0 || img.VerticalResolution > 96.0) {
            Log.Debug("JA!\n");
            img.Dispose();
            img = null;
            return true;
          }
        }
        else {
          return true;
        }
        Log.Debug("NEJ! Inte nödvändigt.\n");
      }
      catch (Exception e) {
        Log.File("NEJ! Bildladdningsfel: {0}\n", e.Message);
      }

      return false;
    }

    /// <summary>
    /// The <seealso cref="FileInfo"/> object of the image
    /// </summary>
    public System.IO.FileInfo File { get; private set; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="img"></param>
    /// <param name="path"></param>
    public Image(string path) : this(new FileInfo(path)) {}

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="img"></param>
    /// <param name="path"></param>
    public Image(FileInfo path)
      : base()
    {
      Instances++;
      File = path;

      if (ImageCreated != null) {
        ImageCreated();
      }
    }

    /// <summary>
    /// Processes the file
    /// </summary>
    /// <returns></returns>
    public override bool Run()
    {
      //if (image == null)
      System.Drawing.Image image;
      image = (System.Drawing.Image)(new Bitmap(File.FullName, true));

      Log.Debug("  * Bearbetar fil: {0}...", File.Name);

      string new_name = getNewName(File);

      Log.Debug("nytt namn {0}...", new_name);

      FileInfo nfi = new FileInfo(new_name);
      if (nfi.Exists) {
        try { System.IO.File.Delete(nfi.FullName); }
        catch (Exception e) {
          Log.File("Kunde inte radera gammal kopia:\n    {0}\n", e.Message);
          Log.File("    Nästa operation kommer förmodligen att misslyckas!\n");
        }
      }

      if (MaxWidth == 0 && MaxHeight == 0) {
        if (Attributes != null) {
          Bitmap nimg;
          using (nimg = Gfx.ApplyAttributes((Bitmap)image, Image.Attributes)) {
            image.Dispose();
            image = null;

            EncoderParameters eparams = new EncoderParameters(1);
            eparams.Param[0] =
              new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)95);
            ImageFormat fmt;
            string mime = GetMimeTypeForExtension(nfi.Extension, out fmt);
            ImageCodecInfo ici = Gfx.GetEncoderInfo(mime);

            try {
              if (ici != null)
                nimg.Save(new_name, ici, eparams);
              else
                nimg.Save(new_name, fmt);

              Log.Debug("klar\n");

              nimg.Dispose();
              nimg = null;
            }
            catch (Exception e) {
              Log.File("    misslyckades!\n");
              Log.File("    fel: {0}\n", e.Message);
              FileInfo fi = new FileInfo(new_name);
              if (fi.Exists) {
                try { System.IO.File.Delete(fi.FullName); }
                catch { }
              }

              nimg.Dispose();
              nimg = null;
              return false;
            }
          }
        }
      }
      else {

        int[] constraints = Gfx.GetConstraints(image.Width, image.Height,
                                               MaxWidth, MaxHeight);
        Bitmap nimg;
        using (nimg = Gfx.ScaleImage((Bitmap)image, constraints[0],
                                            constraints[1])) {
          //image = null;
          image.Dispose();
          image = null;

          if (Image.Attributes != null)
            nimg = Gfx.ApplyAttributes(nimg, Image.Attributes);

          EncoderParameters eparams = new EncoderParameters(1);
          eparams.Param[0] =
            new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)95);
          ImageFormat fmt;
          string mime = GetMimeTypeForExtension(nfi.Extension, out fmt);
          ImageCodecInfo ici = Gfx.GetEncoderInfo(mime);

          try {
            if (ici != null)
              nimg.Save(new_name, ici, eparams);
            else
              nimg.Save(new_name, fmt);

            Log.Debug("klar\n");

            nimg.Dispose();
            nimg = null;
          }
          catch (Exception e) {
            Log.File("    misslyckades!\n");
            Log.File("    fel: {0}\n", e.Message);
            FileInfo fi = new FileInfo(new_name);
            if (fi.Exists) {
              try { System.IO.File.Delete(fi.FullName); }
              catch { }
            }

            nimg.Dispose();
            nimg = null;
            return false;
          }
        }
      }

      return true;
    }

    
    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (isDisposed)
        return;

      if (disposing) {
        /*
        if (image != null) {
          image.Dispose();
          image = null;
        }
        */
        File = null;
      }

      isDisposed = true;
    }

    /// <summary>
    /// Destructor
    /// </summary>
    ~Image()
    {
      Dispose(false);
    }
  }
}
