// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.WorldSeedOption_Everything
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

#nullable disable
namespace Terraria.WorldBuilding;

public class WorldSeedOption_Everything : AWorldGenerationOption
{
  protected List<AWorldGenerationOption> _dependencies;

  protected override string KeyName => "Seed_Everything";

  public override string ServerConfigName => "zenith";

  public List<AWorldGenerationOption> Dependencies
  {
    get
    {
      if (this._dependencies == null)
        this._dependencies = new List<AWorldGenerationOption>()
        {
          (AWorldGenerationOption) WorldGenerationOptions.Get<WorldSeedOption_Remix>(),
          (AWorldGenerationOption) WorldGenerationOptions.Get<WorldSeedOption_Drunk>(),
          (AWorldGenerationOption) WorldGenerationOptions.Get<WorldSeedOption_NotTheBees>(),
          (AWorldGenerationOption) WorldGenerationOptions.Get<WorldSeedOption_NoTraps>(),
          (AWorldGenerationOption) WorldGenerationOptions.Get<WorldSeedOption_DontStarve>(),
          (AWorldGenerationOption) WorldGenerationOptions.Get<WorldSeedOption_Anniversary>(),
          (AWorldGenerationOption) WorldGenerationOptions.Get<WorldSeedOption_ForTheWorthy>()
        };
      return this._dependencies;
    }
  }

  public WorldSeedOption_Everything()
  {
    this.SpecialSeedNames = new string[1]{ "getfixedboi" };
    this.SpecialSeedValues = new int[0];
    AWorldGenerationOption.OnOptionStateChanged += new Action<AWorldGenerationOption>(this.UpdateDependentState);
  }

  private void UpdateDependentState(AWorldGenerationOption changed)
  {
    if (!this.Dependencies.Contains(changed) || changed.Enabled == this.Enabled)
      return;
    this.Enabled = this.Dependencies.All<AWorldGenerationOption>((Func<AWorldGenerationOption, bool>) (d => d.Enabled));
  }

  protected override void OnEnabledStateChanged()
  {
    if (!this.Enabled && this.Dependencies.Any<AWorldGenerationOption>((Func<AWorldGenerationOption, bool>) (d => !d.Enabled)))
      return;
    foreach (AWorldGenerationOption dependency in this.Dependencies)
      dependency.Enabled = this.Enabled;
  }

  public override UIElement ProvideUIElement()
  {
    UIImageFramed uiImageFramed = new UIImageFramed(this.Texture, this.Texture.Frame(7, 16 /*0x10*/));
    uiImageFramed.Left = StyleDimension.FromPixels(-1f);
    UIImageFramed image = uiImageFramed;
    int glitchFrameCounter = 0;
    int glitchFrame = 0;
    int glitchVariation = 0;
    image.OnUpdate += (UIElement.ElementEvent) (_ =>
    {
      int minValue = 3;
      int num = 3;
      if (glitchFrame == 0)
      {
        minValue = 15;
        num = 120;
      }
      if (++glitchFrameCounter >= Main.rand.Next(minValue, num + 1))
      {
        glitchFrameCounter = 0;
        glitchFrame = (glitchFrame + 1) % 16 /*0x10*/;
        if ((glitchFrame == 4 || glitchFrame == 8 ? 1 : (glitchFrame == 12 ? 1 : 0)) != 0 && Main.rand.Next(3) == 0)
          glitchVariation = Main.rand.Next(7);
      }
      image.SetFrame(7, 16 /*0x10*/, glitchVariation, glitchFrame, 0, 0);
    });
    return (UIElement) image;
  }
}
