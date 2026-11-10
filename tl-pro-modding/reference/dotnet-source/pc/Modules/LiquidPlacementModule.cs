// Decompiled with JetBrains decompiler
// Type: Terraria.Modules.LiquidPlacementModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.Enums;

#nullable disable
namespace Terraria.Modules;

public class LiquidPlacementModule
{
  public LiquidPlacement water;
  public LiquidPlacement lava;

  public LiquidPlacementModule(LiquidPlacementModule copyFrom = null)
  {
    if (copyFrom == null)
    {
      this.water = LiquidPlacement.Allowed;
      this.lava = LiquidPlacement.Allowed;
    }
    else
    {
      this.water = copyFrom.water;
      this.lava = copyFrom.lava;
    }
  }
}
