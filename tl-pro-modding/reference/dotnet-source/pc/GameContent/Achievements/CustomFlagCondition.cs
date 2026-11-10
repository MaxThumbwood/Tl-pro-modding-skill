// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Achievements.CustomFlagCondition
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.Achievements;

#nullable disable
namespace Terraria.GameContent.Achievements;

public class CustomFlagCondition : AchievementCondition
{
  private CustomFlagCondition(string name)
    : base(name)
  {
  }

  public static AchievementCondition Create(string name)
  {
    return (AchievementCondition) new CustomFlagCondition(name);
  }
}
