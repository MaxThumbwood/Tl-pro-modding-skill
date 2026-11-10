// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LeashedEntities.FairyLeashedCritter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.GameContent.LeashedEntities;

public class FairyLeashedCritter : FlyerLeashedCritter
{
  public static FairyLeashedCritter Prototype = new FairyLeashedCritter();

  public FairyLeashedCritter()
  {
    this.minWaitTime = 30;
    this.maxWaitTime = 90;
    this.maxFlySpeed = 1.1f;
    this.acceleration = 0.05f;
    this.rotationScalar = 0.25f;
    this.brakeDuration = 30;
  }

  protected override void VisualEffects()
  {
    base.VisualEffects();
    Color color1 = Color.HotPink;
    Color color2 = Color.LightPink;
    int num = 4;
    if (this.npcType == 584)
    {
      color1 = Color.LimeGreen;
      color2 = Color.LightSeaGreen;
    }
    if (this.npcType == 585)
    {
      color1 = Color.RoyalBlue;
      color2 = Color.LightBlue;
    }
    if ((int) Main.timeForVisualEffects % 4 == 0 && Main.rand.Next(4) != 0)
    {
      this.position = this.position + this.netOffset;
      Dust dust = Dust.NewDustDirect(this.Center - new Vector2(4f) + Main.rand.NextVector2Circular(2f, 2f), num, num, 278, Alpha: 200, newColor: Color.Lerp(color1, color2, Main.rand.NextFloat()), Scale: 0.65f);
      dust.velocity *= 0.0f;
      dust.velocity += this.velocity * 0.3f;
      dust.noGravity = true;
      dust.noLight = true;
      this.position = this.position - this.netOffset;
    }
    Lighting.AddLight(this.Center, color1.ToVector3() * 0.7f);
  }
}
