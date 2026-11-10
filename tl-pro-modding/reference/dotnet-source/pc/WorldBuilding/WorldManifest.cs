// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.WorldManifest
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;

#nullable disable
namespace Terraria.WorldBuilding;

public class WorldManifest
{
  public List<GenPassResult> GenPassResults = new List<GenPassResult>();
  public static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings()
  {
    TypeNameHandling = (TypeNameHandling) 4
  };

  public string Version { get; set; }

  public string GitSHA { get; set; }

  public uint? FinalHash
  {
    get
    {
      return this.GenPassResults.Count <= 0 ? new uint?() : this.GenPassResults[this.GenPassResults.Count - 1].Hash;
    }
  }

  public static WorldManifest Deserialize(string json)
  {
    try
    {
      if (!string.IsNullOrEmpty(json))
        return JsonConvert.DeserializeObject<WorldManifest>(json, WorldManifest.SerializerSettings);
    }
    catch (Exception ex)
    {
      Trace.WriteLine((object) ex);
    }
    return new WorldManifest();
  }

  public string Serialize()
  {
    return JsonConvert.SerializeObject((object) this, WorldManifest.SerializerSettings);
  }

  public WorldManifest Clone()
  {
    return JsonConvert.DeserializeObject<WorldManifest>(JsonConvert.SerializeObject((object) this, WorldManifest.SerializerSettings), WorldManifest.SerializerSettings);
  }
}
