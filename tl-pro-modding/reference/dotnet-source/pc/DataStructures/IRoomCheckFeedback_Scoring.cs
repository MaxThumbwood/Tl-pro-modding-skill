// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.IRoomCheckFeedback_Scoring
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.DataStructures;

public interface IRoomCheckFeedback_Scoring
{
  void BeginScoring();

  void ReportScore(int x, int y, int score);

  void SetAsHighScore(int x, int y, int score);

  void EndScoring();
}
