using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImgRescale
{
  public static class Log
  {
    //public static string path = Environment.GetEnvironmentVariable("tmp");
    public static string Path = Environment.GetEnvironmentVariable("tmp") + @"\img-rescale.log";

    /// <summary>
    /// 	<para>Write the log message to the console</para>
    /// 	<para>Behaves like <see cref="System.Console.WriteLine" /></para>
    /// </summary>
    /// <param name="format"><see cref="System.String.Format" /></param>
    /// <param name="rest">Arbitrary number of replacements for format</param>
    public static void Win(string format, params object[] rest)
    {
#if DEBUG
      if (rest.Length > 0)
        format = String.Format(format, rest);

      Console.Write(format);
#endif
    }

    /// <summary>
    /// Writ to file
    /// </summary>
    /// <param name="format"></param>
    /// <param name="rest"></param>
    public static void File(string format, params object[] rest)
    {
      try {
        if (rest.Length > 0)
          format = String.Format(format, rest);
        System.IO.TextWriter tw = new System.IO.StreamWriter(Log.Path, true);
        tw.Write(format);
        tw.Close();
      }
      catch (Exception e) {
        Log.Win(e.Message);
      }
    }

    /// <summary>
    /// Write to log file only when in debug mode
    /// </summary>
    /// <param name="format"></param>
    /// <param name="rest"></param>
    public static void Debug(string format, params object[] rest)
    {
#if DEBUG
      Log.File(format, rest);
#endif
    }
  }

  /// <summary>
  /// Helper class
  /// </summary>
  public static class Out
  {
    /// <summary>
    /// Writes to stderr
    /// </summary>
    /// <param name="fmt"></param>
    /// <param name="rest"></param>
    public static void werror(string fmt, params object[] rest)
    {
      Console.Error.Write(fmt, rest);
    }

    /// <summary>
    /// Writes to stdout
    /// </summary>
    /// <param name="fmt"></param>
    /// <param name="rest"></param>
    public static void print(string fmt, params object[] rest)
    {
      Console.Out.Write(fmt, rest);
    }
  }
}
