// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.ActionPlaceStatue
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Generation;

public class ActionPlaceStatue : GenAction
{
  private int _statueIndex;

  public ActionPlaceStatue(int index = -1) => this._statueIndex = index;

  public override bool Apply(Point origin, int x, int y, params object[] args)
  {
    Point16 point16 = this._statueIndex != -1 ? GenVars.statueList[this._statueIndex] : GenVars.statueList[GenBase._random.Next(2, GenVars.statueList.Length)];
    WorldGen.PlaceTile(x, y, (int) point16.X, true, style: (int) point16.Y);
    return this.UnitApply(origin, x, y, args);
  }
}
