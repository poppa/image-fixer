using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ImgRescale
{
  public delegate void ImageProcessedCallback();

  public abstract class Indexer
  {
    /// <summary>
    /// Base target for modified files. If null the images will
    /// be put in the source dir with another name
    /// </summary>
    public static FileInfo TargetBaseDir = null;

    public static FileInfo SourceBaseDir = null;

    public static ImageProcessedCallback OnImageProcessed;

    public static void Reset()
    {
      Image.instances = 0;
      Dir.instances = 0;
      Image.Attributes = null;
    }

    protected bool isDisposed = false;

    /// <summary>
    /// Factory method for creating an <see cref="Image"/> or 
    /// <see cref="Dir"/> object
    /// </summary>
    /// <param name="path">Directory or file</param>
    /// <returns>
    /// A <see cref="Dir"/> or <see cref="Image"/> object, 
    /// or <value>null</value> if a file isn't an image
    /// </returns>
    public static Indexer Get(string path)
    {
      try {
        FileAttributes fa = System.IO.File.GetAttributes(path);
        if ((fa & FileAttributes.Directory) == FileAttributes.Directory) {
          if (new DirectoryInfo(path).Exists)
            return new Dir(path);
        }
        if (Image.is_allowed(path))
          return new Image(null, path);
      }
      catch (Exception e) {
        Log.File("Misslyckades att skapa en indexerare: {0}\n", e.Message);
      }

      return null;
    }

    protected string getNewName(FileInfo file)
    {
      string new_ext = file.Extension.ToLower();
      switch (new_ext) {
        case ".tif":
        case ".tiff":
        case ".bmp":
          new_ext = ".jpg";
          break;
      }

      string new_name = null;

      if (TargetBaseDir != null && SourceBaseDir != null) {
        string dir = file.DirectoryName;
        dir = dir.Replace(SourceBaseDir.FullName, TargetBaseDir.FullName);
        DirectoryInfo nd = new DirectoryInfo(dir);

        if (!nd.Exists) {
          nd.Create();
        }
  
        string fname = file.Name;
        fname = fname.Replace(file.Extension, "") + new_ext;
        new_name = nd.FullName + "\\" + fname;
      }
      else {
        new_name = file.Directory + "\\" +
                   file.Name.Replace(file.Extension, "-lowres") +
                   new_ext;
      }

      return new_name;
    }

    /// <summary>
    /// Either index a directory or process an image 
    /// </summary>
    /// <returns></returns>
    public abstract bool run();

    //public abstract bool run(ImageProcessedCallback callback);
  }
}
