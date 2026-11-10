// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.GenShape
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.WorldBuilding;

public abstract class GenShape : GenBase
{
  private ShapeData _outputData;
  protected bool _quitOnFail;

  public abstract bool Perform(Point origin, GenAction action);

  protected bool UnitApply(GenAction action, Point origin, int x, int y, params object[] args)
  {
    if (this._outputData != null)
      this._outputData.Add(x - origin.X, y - origin.Y);
    return action.Apply(origin, x, y, args);
  }

  public GenShape Output(ShapeData outputData)
  {
    this._outputData = outputData;
    return this;
  }

  public GenShape QuitOnFail(bool value = true)
  {
    this._quitOnFail = value;
    return this;
  }
}
