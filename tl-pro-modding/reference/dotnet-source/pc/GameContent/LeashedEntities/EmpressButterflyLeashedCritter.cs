// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LeashedEntities.EmpressButterflyLeashedCritter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.GameContent.LeashedEntities;

public class EmpressButterflyLeashedCritter : FlyLeashedCritter
{
  public static EmpressButterflyLeashedCritter Prototype = new EmpressButterflyLeashedCritter();
  private float fadeAmount;
  private const int FadeAwayCap = 50;

  private float Opacity => Utils.GetLerpValue(60f, 25f, this.fadeAmount, true);

  protected override void CopyToDummy()
  {
    base.CopyToDummy();
    LeashedCritter._dummy.ai[2] = this.fadeAmount;
    LeashedCritter._dummy.Opacity = this.Opacity;
  }

  protected override void VisualEffects()
  {
    base.VisualEffects();
    Lighting.AddLight(this.Center, Main.hslToRgb((float) ((double) Main.GlobalTimeWrappedHourly * 0.33000001311302185 % 1.0), 1f, 0.5f).ToVector3() * 0.3f + Vector3.One * 0.1f);
    this.fadeAmount = MathHelper.Clamp(this.fadeAmount + (float) ((double) Main.LocalPlayer.Center.Distance(this.Center) > 300.0).ToDirectionInt(), 0.0f, 50f);
    if ((double) this.fadeAmount <= 0.0)
      return;
    float opacity = this.Opacity;
    int num1 = 1;
    for (int index = 0; index < num1; ++index)
    {
      if (Main.rand.Next(5) == 0)
      {
        float num2 = MathHelper.Lerp(0.9f, 0.6f, opacity);
        int dustIndex = Dust.NewDust(this.position, this.width, this.height, 267, newColor: Main.hslToRgb((float) ((double) Main.GlobalTimeWrappedHourly * 0.30000001192092896 % 1.0), 1f, 0.5f) * 0.5f);
        Main.dust[dustIndex].position = this.Center + Main.rand.NextVector2Circular((float) this.width, (float) this.height);
        Main.dust[dustIndex].velocity *= Main.rand.NextFloat() * 0.8f;
        Main.dust[dustIndex].velocity += this.velocity * 0.6f;
        Main.dust[dustIndex].noGravity = true;
        Main.dust[dustIndex].fadeIn = (float) (0.60000002384185791 + (double) Main.rand.NextFloat() * 0.699999988079071 * (double) num2);
        Main.dust[dustIndex].scale = 0.35f;
        if (dustIndex != 6000)
        {
          Dust dust = Dust.CloneDust(dustIndex);
          dust.scale /= 2f;
          dust.fadeIn *= 0.85f;
          dust.color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue) * 0.5f;
        }
      }
    }
  }
}
