// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LeashedEntities.HellButterflyLeashedCritter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.LeashedEntities;

public class HellButterflyLeashedCritter : FlyLeashedCritter
{
  public static HellButterflyLeashedCritter Prototype = new HellButterflyLeashedCritter();

  protected override void VisualEffects()
  {
    base.VisualEffects();
    this.position = this.position + this.netOffset;
    Lighting.AddLight((int) this.Center.X / 16 /*0x10*/, (int) this.Center.Y / 16 /*0x10*/, 0.6f, 0.3f, 0.1f);
    if (Main.rand.Next(60) == 0)
    {
      int index = Dust.NewDust(this.position, this.width, this.height, 6, Alpha: 254);
      Main.dust[index].velocity *= 0.0f;
    }
    this.position = this.position - this.netOffset;
  }
}
