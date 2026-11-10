// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.GenSearch
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.WorldBuilding;

public abstract class GenSearch : GenBase
{
  public static Point NOT_FOUND = new Point(int.MaxValue, int.MaxValue);
  private bool _requireAll = true;
  private GenCondition[] _conditions;

  public GenSearch Conditions(params GenCondition[] conditions)
  {
    this._conditions = conditions;
    return this;
  }

  public abstract Point Find(Point origin);

  protected bool Check(int x, int y)
  {
    for (int index = 0; index < this._conditions.Length; ++index)
    {
      if (this._requireAll ^ this._conditions[index].IsValid(x, y))
        return !this._requireAll;
    }
    return this._requireAll;
  }

  public GenSearch RequireAll(bool mode)
  {
    this._requireAll = mode;
    return this;
  }
}
