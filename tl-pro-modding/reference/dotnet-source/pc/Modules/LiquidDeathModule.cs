// Decompiled with JetBrains decompiler
// Type: Terraria.Modules.LiquidDeathModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Modules;

public class LiquidDeathModule
{
  public bool water;
  public bool lava;

  public LiquidDeathModule(LiquidDeathModule copyFrom = null)
  {
    if (copyFrom == null)
    {
      this.water = false;
      this.lava = false;
    }
    else
    {
      this.water = copyFrom.water;
      this.lava = copyFrom.lava;
    }
  }
}
