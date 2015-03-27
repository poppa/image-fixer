using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;

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

    public static string SerializeXML(object o)
    {
      string ret = null;
      var x = new XmlSerializer(o.GetType());
      using (Stream s = new MemoryStream()) {
        x.Serialize(s, o);
        s.Position = 0;
        using (StreamReader r = new StreamReader(s)) {
          ret = r.ReadToEnd();
        }
      }

      return ret;
    }

    public static object DeserializeXML(string xml, Type t)
    {
      if (string.IsNullOrEmpty(xml))
        return null;

      object ret = null;
      var x = new XmlSerializer(t);
      using (Stream s = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(xml))) {
        ret = x.Deserialize(s);
      }

      return ret;
    }

  }

  [XmlRootAttribute("Presets")]
  public class PresetsList : List<Preset>
  {
    public override string ToString()
    {
      return MySerializer.SerializeXML(this);
    }

    public static PresetsList ToObject(string xml)
    {
      return (PresetsList)MySerializer.DeserializeXML(xml, typeof(PresetsList));
    }
  }

  public class Preset
  {
    public string Name { get; set; }
    public int Saturation { get; set; }
    public int Intensity { get; set; }
    public int Contrast { get; set; }
    public string PreviewImage { get; set; }
    public string SourceDir { get; set; }
    public string DestinationDir { get; set; }

    public override string ToString()
    {
      return Name;
    }

    public string ToXml()
    {
      return MySerializer.SerializeXML(this);
    }

    public static Preset Deserialize(string s)
    {
      if (string.IsNullOrEmpty(s)) return null;
      return (Preset) MySerializer.DeserializeXML(s, typeof(Preset));
    }

    public void Save()
    {
      PresetsList a;
      var s = Properties.Settings.Default.presets;
      if (!string.IsNullOrEmpty(s)) {
        a = PresetsList.ToObject(s);
      }
      else {
        a = new PresetsList();
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
