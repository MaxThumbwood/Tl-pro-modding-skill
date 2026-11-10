// Decompiled with JetBrains decompiler
// Type: Terraria.Modules.TilePlacementHooksModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.DataStructures;

#nullable disable
namespace Terraria.Modules;

public class TilePlacementHooksModule
{
  public PlacementHook check;
  public PlacementHook postPlaceEveryone;
  public PlacementHook postPlaceMyPlayer;
  public PlacementHook placeOverride;

  public TilePlacementHooksModule(TilePlacementHooksModule copyFrom = null)
  {
    if (copyFrom == null)
    {
      this.check = new PlacementHook();
      this.postPlaceEveryone = new PlacementHook();
      this.postPlaceMyPlayer = new PlacementHook();
      this.placeOverride = new PlacementHook();
    }
    else
    {
      this.check = copyFrom.check;
      this.postPlaceEveryone = copyFrom.postPlaceEveryone;
      this.postPlaceMyPlayer = copyFrom.postPlaceMyPlayer;
      this.placeOverride = copyFrom.placeOverride;
    }
  }
}
