// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LeashedEntities.CrawlingFlyLeashedCritter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.LeashedEntities;

public class CrawlingFlyLeashedCritter : FlyerLeashedCritter
{
  public static CrawlingFlyLeashedCritter Prototype = new CrawlingFlyLeashedCritter();

  public CrawlingFlyLeashedCritter() => this.hasGroundBias = true;

  protected override void SetDefaults(Item sample)
  {
    base.SetDefaults(sample);
    this.scale = (float) ((double) Main.rand.NextFloat() * 0.20000000298023224 + 0.699999988079071);
  }
}
