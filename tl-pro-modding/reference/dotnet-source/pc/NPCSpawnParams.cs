// Decompiled with JetBrains decompiler
// Type: Terraria.NPCSpawnParams
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria;

public struct NPCSpawnParams
{
  public float? sizeScaleOverride;
  public int? playerCountForMultiplayerDifficultyOverride;
  public float? difficultyOverride;

  public NPCSpawnParams WithScale(float scaleOverride)
  {
    return new NPCSpawnParams()
    {
      sizeScaleOverride = new float?(scaleOverride),
      playerCountForMultiplayerDifficultyOverride = this.playerCountForMultiplayerDifficultyOverride,
      difficultyOverride = this.difficultyOverride
    };
  }
}
