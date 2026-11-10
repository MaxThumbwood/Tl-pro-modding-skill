// Decompiled with JetBrains decompiler
// Type: Terraria.UI.AchievementAdvisorCard
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.Achievements;

#nullable disable
namespace Terraria.UI;

public class AchievementAdvisorCard
{
  private const int _iconSize = 64 /*0x40*/;
  private const int _iconSizeWithSpace = 66;
  private const int _iconsPerRow = 8;
  public Achievement achievement;
  public float order;
  public Rectangle frame;
  public int achievementIndex;

  public AchievementAdvisorCard(Achievement achievement, float order)
  {
    this.achievement = achievement;
    this.order = order;
    this.achievementIndex = Main.Achievements.GetIconIndex(achievement.Name);
    this.frame = new Rectangle(this.achievementIndex % 8 * 66, this.achievementIndex / 8 * 66, 64 /*0x40*/, 64 /*0x40*/);
  }

  public bool IsAchievableInWorld()
  {
    switch (this.achievement.Name)
    {
      case "MASTERMIND":
        return WorldGen.crimson;
      case "WORM_FODDER":
        return !WorldGen.crimson;
      case "PLAY_ON_A_SPECIAL_SEED":
        return Main.specialSeedWorld;
      default:
        return true;
    }
  }
}
