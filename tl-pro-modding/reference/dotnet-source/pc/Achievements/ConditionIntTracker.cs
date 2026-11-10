// Decompiled with JetBrains decompiler
// Type: Terraria.Achievements.ConditionIntTracker
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.Social;

#nullable disable
namespace Terraria.Achievements;

public class ConditionIntTracker : AchievementTracker<int>
{
  public ConditionIntTracker()
    : base(TrackerType.Int)
  {
  }

  public ConditionIntTracker(int maxValue)
    : base(TrackerType.Int)
  {
    this._maxValue = maxValue;
  }

  public override void ReportUpdate()
  {
    if (SocialAPI.Achievements == null || this._name == null)
      return;
    SocialAPI.Achievements.UpdateIntStat(this._name, this._value);
  }

  protected override void Load()
  {
  }
}
