// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LeashedEntities.WaterStriderLeashedCritter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.GameContent.LeashedEntities;

internal class WaterStriderLeashedCritter : JumperLeashedCritter
{
  public static WaterStriderLeashedCritter Prototype = new WaterStriderLeashedCritter();

  public WaterStriderLeashedCritter()
  {
    this.minWaitTime = 60;
    this.maxWaitTime = 120;
    this.strayingRangeInBlocks = 5;
    this.maxJumpWidth = 32f;
    this.minJumpWidth = 8f;
    this.maxJumpHeight = 0.0f;
    this.maxJumpDuration = 14f;
    this.jumpCooldown = 15;
    this.canStandOnWater = true;
  }

  public override Vector2 GetDrawOffset()
  {
    Vector2 drawOffset = base.GetDrawOffset();
    Point tileCoordinates = this.Center.ToTileCoordinates();
    for (int index = 0; index < 2; ++index)
    {
      ++tileCoordinates.Y;
      byte liquid = Framing.GetTileSafely(tileCoordinates).liquid;
      if (liquid != (byte) 0)
      {
        drawOffset.Y = (float) (((int) byte.MaxValue - (int) liquid) / 16 /*0x10*/);
        break;
      }
    }
    return drawOffset;
  }
}
