// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.GenAction
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.WorldBuilding;

public abstract class GenAction : GenBase
{
  public GenAction NextAction;
  public ShapeData OutputData;
  private bool _returnFalseOnFailure = true;

  public abstract bool Apply(Point origin, int x, int y, params object[] args);

  protected bool UnitApply(Point origin, int x, int y, params object[] args)
  {
    if (this.OutputData != null)
      this.OutputData.Add(x - origin.X, y - origin.Y);
    return this.NextAction == null || this.NextAction.Apply(origin, x, y, args);
  }

  public GenAction IgnoreFailures()
  {
    this._returnFalseOnFailure = false;
    return this;
  }

  protected bool Fail() => !this._returnFalseOnFailure;

  public GenAction Output(ShapeData data)
  {
    this.OutputData = data;
    return this;
  }
}
