using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ImgRescale
{
  public static class MySerializer
  {
    public static string Serialize(object obj)
    {
      string ret = null;
      IFormatter f = new BinaryFormatter();
      using (Stream s = new MemoryStream()) {
        f.Serialize(s, obj);
        s.Position = 0;

        using (StreamReader sr = new StreamReader(s)) {
          ret = sr.ReadToEnd();
        }
      }

      return ret;
    }

    public static object Deserialize(string s)
    {
      if (string.IsNullOrEmpty(s)) return null;
      object ret = null;
      try {
        IFormatter f = new BinaryFormatter();
        using (Stream ms = new MemoryStream(System.Text.Encoding.Default.GetBytes(s))) {
          ret = f.Deserialize(ms);
        }
      }
      catch (Exception e) {
        Log.Win("Unable to deserialize string\n");
      }

      return ret;
    }
  }

  [Serializable]
  public class SerializedArray : System.Collections.ArrayList
  {
    public override string ToString()
    {
      return MySerializer.Serialize(this);
    }

    public static SerializedArray Deserialize(string s)
    {
      if (string.IsNullOrEmpty(s)) return null;
      return (SerializedArray)MySerializer.Deserialize(s);
    }
  }

  [Serializable]
  public class Preset
  {
    public string Name = null;
    public int Saturation = 0;
    public int Intensity = 0;
    public int Contrast = 0;
    public string PreviewImage = null;
    public string SourceDir = null;
    public string DestinationDir = null;

    public override string ToString()
    {
      return MySerializer.Serialize(this);
    }

    public static Preset Deserialize(string s)
    {
      if (string.IsNullOrEmpty(s)) return null;
      return (Preset) MySerializer.Deserialize(s);
    }

    public void Save()
    {
      SerializedArray a;
      var s = Properties.Settings.Default.presets;
      if (!string.IsNullOrEmpty(s)) {
        a = SerializedArray.Deserialize(s);
      }
      else {
        a = new SerializedArray();
      }

      if (a.Count == 0) {
        a.Add(this);
      }
      else {
        int idx = 0;
        bool found = false;
        foreach (var item in a) {
          Preset ps = (Preset)item;
          if (ps.Name == Name) {
            found = true;
            break;
          }
          idx += 1;
        }

        if (found) {
          a.Insert(idx, this);
        }
        else {
          a.Add(this);
        }
      }

      Log.Debug("Save preset: {0}\n", a.ToString());

      Properties.Settings.Default.presets = a.ToString();
    }
  }
}
