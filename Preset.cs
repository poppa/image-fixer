using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ImgRescale
{
  [Serializable]
  class Preset
  {
    public string Name = null;
    public int Saturation = 0;
    public int Intensity = 0;
    public int Contrast = 0;
    public string PreviewImage = null;
    public string SourceDir = null;
    public string DestinationDir = null;

    public string GetSerializedString()
    {
      IFormatter f = new BinaryFormatter();
      Stream s = new MemoryStream();
      f.Serialize(s, this);
      var ss = new StreamReader(s);
      string res = ss.ReadToEnd();
      s.Close();
      ss.Close();
      return res;
    }
  }
}
