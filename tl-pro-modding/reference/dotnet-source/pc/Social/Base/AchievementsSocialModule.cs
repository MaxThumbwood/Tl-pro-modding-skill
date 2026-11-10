// Decompiled with JetBrains decompiler
// Type: Terraria.Social.Base.AchievementsSocialModule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Social.Base;

public abstract class AchievementsSocialModule : ISocialModule
{
  public abstract void Initialize();

  public abstract void Shutdown();

  public abstract byte[] GetEncryptionKey();

  public abstract string GetSavePath();

  public abstract void UpdateIntStat(string name, int value);

  public abstract void UpdateFloatStat(string name, float value);

  public abstract void CompleteAchievement(string name);

  public abstract bool IsAchievementCompleted(string name);

  public abstract void StoreStats();
}
