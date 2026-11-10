// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.Conditions
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.WorldBuilding;

public static class Conditions
{
  public class IsTile : GenCondition
  {
    private ushort[] _types;

    public IsTile(params ushort[] types) => this._types = types;

    protected override bool CheckValidity(int x, int y)
    {
      if (!WorldGen.InWorld(x, y) || !GenBase._tiles[x, y].active())
        return false;
      for (int index = 0; index < this._types.Length; ++index)
      {
        if ((int) GenBase._tiles[x, y].type == (int) this._types[index])
          return true;
      }
      return false;
    }
  }

  public class Continue : GenCondition
  {
    protected override bool CheckValidity(int x, int y) => false;
  }

  public class BoolCheck : GenCondition
  {
    private bool _theBool;

    public BoolCheck(bool theBool) => this._theBool = theBool;

    protected override bool CheckValidity(int x, int y) => this._theBool;
  }

  public class MysticSnake : GenCondition
  {
    protected override bool CheckValidity(int x, int y)
    {
      return GenBase._tiles[x, y].active() && !Main.tileCut[(int) GenBase._tiles[x, y].type] && GenBase._tiles[x, y].type != (ushort) 504;
    }
  }

  public class InWorld : GenCondition
  {
    private int _fluff;

    public InWorld(int fluff) => this._fluff = fluff;

    protected override bool CheckValidity(int x, int y) => WorldGen.InWorld(x, y, this._fluff);
  }

  public class IsSolid : GenCondition
  {
    protected override bool CheckValidity(int x, int y)
    {
      return WorldGen.InWorld(x, y, 10) && GenBase._tiles[x, y].active() && Main.tileSolid[(int) GenBase._tiles[x, y].type];
    }
  }

  public class HasLava : GenCondition
  {
    protected override bool CheckValidity(int x, int y)
    {
      return GenBase._tiles[x, y].liquid > (byte) 0 && GenBase._tiles[x, y].liquidType() == (byte) 1;
    }
  }

  public class NotNull : GenCondition
  {
    protected override bool CheckValidity(int x, int y) => GenBase._tiles[x, y] != null;
  }
}
