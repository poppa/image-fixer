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
    public static bool recurse = false;
    /// <summary>
    /// Instance counter
    /// </summary>
    public static int instances = 0;
    /// <summary>
    /// The <see cref="DirectoryInfo"/> object of the dir.
    /// </summary>
    public System.IO.DirectoryInfo directory { get; private set; }
    /// <summary>
    /// List of images in this directory
    /// </summary>
    public ArrayList files { get; private set; }
    /// <summary>
    /// List of sub directories
    /// </summary>
    public ArrayList dirs { get; private set; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="path"></param>
    public Dir(string path)
      : base()
    {
      instances++;
      directory = new DirectoryInfo(path);
      files = new ArrayList();

      foreach (FileInfo fi in directory.GetFiles()) {
        if (Image.is_allowed(fi.FullName))
          files.Add(new Image(null, fi));
      }

      if (recurse) {
        dirs = new ArrayList();
        foreach (DirectoryInfo di in directory.GetDirectories()) {
          dirs.Add(new Dir(di.FullName));
        }
      }
    }

    /// <summary>
    /// Process the images in this directory
    /// </summary>
    /// <returns></returns>
    public override bool run()
    {
      Log.Debug("Scannar mapp: {0}\n", directory.FullName);
      if (files.Count == 0) {
        Log.Debug("   - Inga bilder funna!\n");
        return false;
      }

      foreach (Image file in files) {
        file.run();
        if (OnImageProcessed != null) {
          OnImageProcessed();
        }

        file.Dispose();
      }

      files.Clear();

      if (recurse) {
        foreach (Dir d in dirs) {
          d.run();
          d.Dispose();
        }
      }

      dirs.Clear();

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
        Log.Debug("Dispose: {0}\n", directory.FullName);
        files.Clear();
        files = null;

        if (dirs != null) {
          dirs.Clear();
          dirs = null;
        }

        directory = null;
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
