// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Chat.AchievementTagHandler
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.Achievements;
using Terraria.UI;
using Terraria.UI.Chat;

#nullable disable
namespace Terraria.GameContent.UI.Chat;

public class AchievementTagHandler : ITagHandler
{
  TextSnippet ITagHandler.Parse(string text, Color baseColor, string options)
  {
    Achievement achievement = Main.Achievements.GetAchievement(text);
    return achievement == null ? new TextSnippet(text) : (TextSnippet) new AchievementTagHandler.AchievementSnippet(achievement);
  }

  public static string GenerateTag(Achievement achievement) => $"[a:{achievement.Name}]";

  private class AchievementSnippet : TextSnippet
  {
    private Achievement _achievement;

    public AchievementSnippet(Achievement achievement)
      : base(achievement.FriendlyName.Value, Color.LightBlue)
    {
      this.CheckForHover = true;
      this._achievement = achievement;
    }

    public override void OnClick()
    {
      IngameOptions.Close();
      IngameFancyUI.OpenAchievementsAndGoto(this._achievement);
    }
  }
}
