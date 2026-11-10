// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LeashedEntities.WaterfowlLeashedCritter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.LeashedEntities;

public class WaterfowlLeashedCritter : BirdLeashedCritter
{
  public static WaterfowlLeashedCritter Prototype = new WaterfowlLeashedCritter();

  public WaterfowlLeashedCritter() => this.hasGroundBias = true;

  protected override void CopyToDummy()
  {
    base.CopyToDummy();
    if ((double) this.velocity.Y == 0.0)
      return;
    ++LeashedCritter._dummy.type;
  }
}
