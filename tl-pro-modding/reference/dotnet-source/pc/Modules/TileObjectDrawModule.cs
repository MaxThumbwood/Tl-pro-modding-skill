// Decompiled with JetBrains decompiler
// Type: Terraria.Modules.TileObjectDrawModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Modules;

public class TileObjectDrawModule
{
  public int xOffset;
  public int yOffset;
  public bool flipHorizontal;
  public bool flipVertical;
  public int stepDown;

  public TileObjectDrawModule(TileObjectDrawModule copyFrom = null)
  {
    if (copyFrom == null)
    {
      this.xOffset = 0;
      this.yOffset = 0;
      this.flipHorizontal = false;
      this.flipVertical = false;
      this.stepDown = 0;
    }
    else
    {
      this.xOffset = copyFrom.xOffset;
      this.yOffset = copyFrom.yOffset;
      this.flipHorizontal = copyFrom.flipHorizontal;
      this.flipVertical = copyFrom.flipVertical;
      this.stepDown = copyFrom.stepDown;
    }
  }
}
