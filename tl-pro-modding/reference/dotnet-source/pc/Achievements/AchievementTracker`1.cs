// Decompiled with JetBrains decompiler
// Type: Terraria.Achievements.AchievementTracker`1
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.Social;

#nullable disable
namespace Terraria.Achievements;

public abstract class AchievementTracker<T> : IAchievementTracker
{
  protected T _value;
  protected T _maxValue;
  protected string _name;
  private TrackerType _type;

  public T Value => this._value;

  public T MaxValue => this._maxValue;

  protected AchievementTracker(TrackerType type) => this._type = type;

  void IAchievementTracker.ReportAs(string name) => this._name = name;

  TrackerType IAchievementTracker.GetTrackerType() => this._type;

  void IAchievementTracker.Clear() => this.SetValue(default (T));

  public void SetValue(T newValue, bool reportUpdate = true)
  {
    if (newValue.Equals((object) this._value))
      return;
    this._value = newValue;
    if (!reportUpdate)
      return;
    this.ReportUpdate();
    if (!this._value.Equals((object) this._maxValue))
      return;
    this.OnComplete();
  }

  public abstract void ReportUpdate();

  protected abstract void Load();

  void IAchievementTracker.Load() => this.Load();

  protected void OnComplete()
  {
    if (SocialAPI.Achievements == null)
      return;
    SocialAPI.Achievements.StoreStats();
  }
}
