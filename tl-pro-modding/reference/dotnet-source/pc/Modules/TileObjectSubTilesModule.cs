// Decompiled with JetBrains decompiler
// Type: Terraria.Modules.TileObjectSubTilesModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;
using Terraria.ObjectData;

#nullable disable
namespace Terraria.Modules;

public class TileObjectSubTilesModule
{
  public List<TileObjectData> data;

  public TileObjectSubTilesModule(TileObjectSubTilesModule copyFrom = null, List<TileObjectData> newData = null)
  {
    if (copyFrom == null)
      this.data = (List<TileObjectData>) null;
    else if (copyFrom.data == null)
    {
      this.data = (List<TileObjectData>) null;
    }
    else
    {
      this.data = new List<TileObjectData>(copyFrom.data.Count);
      for (int index = 0; index < this.data.Count; ++index)
        this.data.Add(new TileObjectData(copyFrom.data[index]));
    }
  }
}
