// Decompiled with JetBrains decompiler
// Type: Terraria.Modules.TileObjectStyleModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Modules;

public class TileObjectStyleModule
{
  public int style;
  public bool horizontal;
  public int styleWrapLimit;
  public int styleMultiplier;
  public int styleLineSkip;
  public int? styleWrapLimitVisualOverride;
  public int? styleLineSkipVisualoverride;

  public TileObjectStyleModule(TileObjectStyleModule copyFrom = null)
  {
    if (copyFrom == null)
    {
      this.style = 0;
      this.horizontal = false;
      this.styleWrapLimit = 0;
      this.styleWrapLimitVisualOverride = new int?();
      this.styleLineSkipVisualoverride = new int?();
      this.styleMultiplier = 1;
      this.styleLineSkip = 1;
    }
    else
    {
      this.style = copyFrom.style;
      this.horizontal = copyFrom.horizontal;
      this.styleWrapLimit = copyFrom.styleWrapLimit;
      this.styleMultiplier = copyFrom.styleMultiplier;
      this.styleLineSkip = copyFrom.styleLineSkip;
      this.styleWrapLimitVisualOverride = copyFrom.styleWrapLimitVisualOverride;
      this.styleLineSkipVisualoverride = copyFrom.styleLineSkipVisualoverride;
    }
  }
}
