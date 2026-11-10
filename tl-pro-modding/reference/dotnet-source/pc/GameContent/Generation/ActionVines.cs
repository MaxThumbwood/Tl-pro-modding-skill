// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.ActionVines
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Generation;

public class ActionVines : GenAction
{
  private int _minLength;
  private int _maxLength;
  private int _vineId;

  public ActionVines(int minLength = 6, int maxLength = 10, int vineId = 52)
  {
    this._minLength = minLength;
    this._maxLength = maxLength;
    this._vineId = vineId;
  }

  public override bool Apply(Point origin, int x, int y, params object[] args)
  {
    int num1 = GenBase._random.Next(this._minLength, this._maxLength + 1);
    int num2;
    for (num2 = 0; num2 < num1 && !GenBase._tiles[x, y + num2].active(); ++num2)
    {
      GenBase._tiles[x, y + num2].type = (ushort) this._vineId;
      GenBase._tiles[x, y + num2].active(true);
    }
    return num2 > 0 && this.UnitApply(origin, x, y, args);
  }
}
