// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.FishDropRules.FishRarityCondition
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.FishDropRules;

public abstract class FishRarityCondition
{
  public float FrequencyOfAppearanceForVisuals;
  public bool HackedIsAny;

  public abstract bool Matches(FishingContext context);
}
