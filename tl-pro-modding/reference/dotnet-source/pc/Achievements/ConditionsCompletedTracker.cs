// Decompiled with JetBrains decompiler
// Type: Terraria.Achievements.ConditionsCompletedTracker
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;

#nullable disable
namespace Terraria.Achievements;

public class ConditionsCompletedTracker : ConditionIntTracker
{
  private List<AchievementCondition> _conditions = new List<AchievementCondition>();

  public void AddCondition(AchievementCondition condition)
  {
    ++this._maxValue;
    condition.OnComplete += new AchievementCondition.AchievementUpdate(this.OnConditionCompleted);
    this._conditions.Add(condition);
  }

  private void OnConditionCompleted(AchievementCondition condition)
  {
    this.SetValue(Math.Min(this._value + 1, this._maxValue));
  }

  protected override void Load()
  {
    for (int index = 0; index < this._conditions.Count; ++index)
    {
      if (this._conditions[index].IsCompleted)
        ++this._value;
    }
  }
}
