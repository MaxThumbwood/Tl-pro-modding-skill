// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.Passes
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.IO;

#nullable disable
namespace Terraria.WorldBuilding;

public static class Passes
{
  public class Clear : GenPass
  {
    public Clear()
      : base("clear", 1.0)
    {
    }

    protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
    {
      for (int index1 = 0; index1 < GenBase._worldWidth; ++index1)
      {
        for (int index2 = 0; index2 < GenBase._worldHeight; ++index2)
        {
          if (GenBase._tiles[index1, index2] == null)
            GenBase._tiles[index1, index2] = new Tile();
          else
            GenBase._tiles[index1, index2].ClearEverything();
        }
      }
    }
  }

  public class ScatterCustom : GenPass
  {
    private GenBase.CustomPerUnitAction _perUnit;
    private int _count;

    public ScatterCustom(
      string name,
      double loadWeight,
      int count,
      GenBase.CustomPerUnitAction perUnit = null)
      : base(name, loadWeight)
    {
      this._perUnit = perUnit;
      this._count = count;
    }

    public void SetCustomAction(GenBase.CustomPerUnitAction perUnit) => this._perUnit = perUnit;

    protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
    {
      int count = this._count;
      while (count > 0)
      {
        if (this._perUnit(GenBase._random.Next(1, GenBase._worldWidth), GenBase._random.Next(1, GenBase._worldHeight)))
          --count;
      }
    }
  }
}
