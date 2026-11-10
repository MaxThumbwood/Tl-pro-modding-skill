// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Metadata.TileMaterials
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Terraria.ID;

#nullable disable
namespace Terraria.GameContent.Metadata;

public static class TileMaterials
{
  private static Dictionary<string, TileMaterial> _materialsByName;
  private static readonly TileMaterial[] MaterialsByTileId = new TileMaterial[(int) TileID.Count];

  static TileMaterials()
  {
    TileMaterials._materialsByName = TileMaterials.DeserializeEmbeddedResource<Dictionary<string, TileMaterial>>("Terraria.GameContent.Metadata.MaterialData.Materials.json");
    TileMaterial tileMaterial = TileMaterials._materialsByName["Default"];
    for (int index = 0; index < TileMaterials.MaterialsByTileId.Length; ++index)
      TileMaterials.MaterialsByTileId[index] = tileMaterial;
    foreach (KeyValuePair<string, string> keyValuePair in TileMaterials.DeserializeEmbeddedResource<Dictionary<string, string>>("Terraria.GameContent.Metadata.MaterialData.Tiles.json"))
    {
      string key1 = keyValuePair.Key;
      string key2 = keyValuePair.Value;
      TileMaterials.SetForTileId((ushort) TileID.Search.GetId(key1), TileMaterials._materialsByName[key2]);
    }
  }

  private static T DeserializeEmbeddedResource<T>(string path)
  {
    using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path))
    {
      using (StreamReader streamReader = new StreamReader(manifestResourceStream))
        return JsonConvert.DeserializeObject<T>(streamReader.ReadToEnd());
    }
  }

  public static void SetForTileId(ushort tileId, TileMaterial material)
  {
    TileMaterials.MaterialsByTileId[(int) tileId] = material;
  }

  public static TileMaterial GetByTileId(ushort tileId)
  {
    return TileMaterials.MaterialsByTileId[(int) tileId];
  }
}
