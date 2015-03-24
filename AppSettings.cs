using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace ImgRescale
{
  class MyAppSettings : ApplicationSettingsBase
  {
    [UserScopedSetting()]
    [DefaultSettingValue(null)]
    public string LastSourceDir
    {
      get {
        Log.File("Get last source dir: {0}\n", this["lastSrcDir"]);
        return this["lastSrcDir"].ToString(); 
      }
      set { this["lastSrcDir"] = value.ToString(); }
    }

    [UserScopedSetting()]
    [DefaultSettingValue(null)]
    public string LastTargetDir
    {
      get { return this["lastTargetDir"].ToString(); }
      set { this["lastTargetDir"] = value.ToString(); }
    }
  }
}
