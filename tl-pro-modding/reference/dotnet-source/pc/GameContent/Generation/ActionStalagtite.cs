// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.ActionStalagtite
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Generation;

public class ActionStalagtite : GenAction
{
  public override bool Apply(Point origin, int x, int y, params object[] args)
  {
    WorldGen.PlaceTight(x, y);
    return this.UnitApply(origin, x, y, args);
  }
}
