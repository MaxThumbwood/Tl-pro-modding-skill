// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.GenBase
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.Utilities;

#nullable disable
namespace Terraria.WorldBuilding;

public class GenBase
{
  protected static UnifiedRandom _random => WorldGen.genRand;

  protected static Tile[,] _tiles => Main.tile;

  protected static int _worldWidth => Main.maxTilesX;

  protected static int _worldHeight => Main.maxTilesY;

  public delegate bool CustomPerUnitAction(int x, int y, params object[] args);
}
