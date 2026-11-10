// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LeashedEntities.SnailLeashedCritter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.LeashedEntities;

public class SnailLeashedCritter : CrawlerLeashedCritter
{
  public static SnailLeashedCritter Prototype = new SnailLeashedCritter();

  protected override void SetDefaults(Item sample)
  {
    base.SetDefaults(sample);
    if (this.npcType != 359)
      return;
    this.scale = (float) Main.rand.Next(80 /*0x50*/, 111) * 0.01f;
  }

  protected override void VisualEffects()
  {
    base.VisualEffects();
    switch (this.npcType)
    {
      case 360:
        Lighting.AddLight((int) this.Center.X / 16 /*0x10*/, (int) this.Center.Y / 16 /*0x10*/, 0.1f, 0.2f, 0.7f);
        break;
      case 655:
        Lighting.AddLight((int) this.Center.X / 16 /*0x10*/, (int) this.Center.Y / 16 /*0x10*/, 0.6f, 0.3f, 0.1f);
        break;
    }
  }
}
