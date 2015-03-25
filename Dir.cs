using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ImgRescale
{
  /// <summary>
  /// Directory scanner/indexer class
  /// </summary>
  public class Dir : Indexer, IDisposable
  {
    /// <summary>
    /// Do recursive scanning or not
    /// </summary>
    public static bool Recurse = false;

    /// <summary>
    /// The <see cref="DirectoryInfo"/> object of the dir.
    /// </summary>
    public System.IO.DirectoryInfo Directory { get; private set; }

    /// <summary>
    /// List of images in this directory
    /// </summary>
    public ArrayList Files { get; private set; }

    /// <summary>
    /// List of sub directories
    /// </summary>
    public ArrayList Directories { get; private set; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="path"></param>
    public Dir(string path)
      : base()
    {
      instances++;
      Directory = new DirectoryInfo(path);
      Files = new ArrayList();

      foreach (FileInfo fi in Directory.GetFiles()) {
        if (Image.IsAllowed(fi.FullName))
          Files.Add(new Image(fi));
      }

      if (Recurse) {
        Directories = new ArrayList();
        foreach (DirectoryInfo di in Directory.GetDirectories()) {
          Directories.Add(new Dir(di.FullName));
        }
      }
    }

    /// <summary>
    /// Process the images in this directory
    /// </summary>
    /// <returns></returns>
    public override bool Run()
    {
      Log.Debug("Scannar mapp: {0}\n", Directory.FullName);
      if (Files.Count == 0) {
        Log.Debug("   - Inga bilder funna!\n");
        return false;
      }

      foreach (Image file in Files) {
        file.Run();
        if (ImageProcessed != null) {
          ImageProcessed();
        }

        file.Dispose();
      }

      Files.Clear();

      if (Recurse) {
        foreach (Dir d in Directories) {
          d.Run();
          d.Dispose();
        }
      }

      Directories.Clear();

      return true;
    }

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    public virtual void Dispose(bool disposing)
    {
      if (isDisposed)
        return;

      if (disposing) {
        Log.Debug("Dispose: {0}\n", Directory.FullName);
        Files.Clear();
        Files = null;

        if (Directories != null) {
          Directories.Clear();
          Directories = null;
        }

        Directory = null;
      }

      isDisposed = true;
    }

    /// <summary>
    /// Destructor
    /// </summary>
    ~Dir()
    {
      Dispose(false);
    }
  }
}
