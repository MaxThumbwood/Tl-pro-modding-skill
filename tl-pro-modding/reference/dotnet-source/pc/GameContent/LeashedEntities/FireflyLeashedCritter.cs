// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LeashedEntities.FireflyLeashedCritter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.LeashedEntities;

public class FireflyLeashedCritter : FlyLeashedCritter
{
  public static FireflyLeashedCritter Prototype = new FireflyLeashedCritter();
  private bool lightOn;
  private int timer;

  protected override void CopyToDummy()
  {
    base.CopyToDummy();
    LeashedCritter._dummy.localAI[2] = this.lightOn ? 1f : 0.0f;
  }

  protected override void VisualEffects()
  {
    base.VisualEffects();
    this.UpdateTimer();
    if (!this.lightOn || this.timer <= 3)
      return;
    this.AddLight();
  }

  private void AddLight()
  {
    int i = (int) this.Center.X / 16 /*0x10*/;
    int j = (int) this.Center.Y / 16 /*0x10*/;
    float scale = LeashedCritter._dummy.scale;
    switch (this.npcType)
    {
      case 355:
        Lighting.AddLight(i, j, 0.109500006f * scale, 0.15f * scale, 0.0615f * scale);
        break;
      case 358:
        Lighting.AddLight(i, j, 0.101249993f * scale, 0.21374999f * scale, 0.225f * scale);
        break;
      case 654:
        Lighting.AddLight(i, j, 0.225f * scale, 0.105000004f * scale, 0.0600000024f * scale);
        break;
    }
  }

  private void UpdateTimer()
  {
    if (--this.timer > 0)
      return;
    this.timer = 0;
    if (!this.lightOn && Main.dayTime && (double) this.position.Y / 16.0 < Main.worldSurface + 10.0)
      return;
    this.lightOn = !this.lightOn;
    this.timer = this.lightOn ? Main.rand.Next(10, 30) : Main.rand.Next(30, 180);
  }
}
