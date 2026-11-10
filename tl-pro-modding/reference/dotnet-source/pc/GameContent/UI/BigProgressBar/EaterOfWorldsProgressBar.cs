// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.BigProgressBar.EaterOfWorldsProgressBar
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;

#nullable disable
namespace Terraria.GameContent.UI.BigProgressBar;

public class EaterOfWorldsProgressBar : IBigProgressBar
{
  private BigProgressBarCache _cache;
  private NPC _segmentForReference;

  public EaterOfWorldsProgressBar() => this._segmentForReference = new NPC();

  public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
  {
    if (info.npcIndexToAimAt < 0 || info.npcIndexToAimAt > Main.maxNPCs)
      return false;
    NPC npc1 = Main.npc[info.npcIndexToAimAt];
    if (!npc1.active && !this.TryFindingAnotherEOWPiece(ref info))
      return false;
    int num1 = 2;
    int num2 = NPC.GetEaterOfWorldsSegmentsCount() + num1;
    this._segmentForReference.SetDefaults(14, npc1.GetMatchingSpawnParams());
    int current = 0;
    int max = this._segmentForReference.lifeMax * num2;
    for (int index = 0; index < Main.maxNPCs; ++index)
    {
      NPC npc2 = Main.npc[index];
      if (npc2.active && npc2.type >= 13 && npc2.type <= 15)
        current += npc2.life;
    }
    this._cache.SetLife((float) current, (float) max);
    return true;
  }

  public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
  {
    int bossHeadTexture = NPCID.Sets.BossHeadTextures[13];
    Texture2D texture2D = TextureAssets.NpcHeadBoss[bossHeadTexture].Value;
    Rectangle barIconFrame = texture2D.Frame();
    BigProgressBarHelper.DrawFancyBar(spriteBatch, this._cache.LifeCurrent, this._cache.LifeMax, texture2D, barIconFrame);
  }

  private bool TryFindingAnotherEOWPiece(ref BigProgressBarInfo info)
  {
    for (int index = 0; index < Main.maxNPCs; ++index)
    {
      NPC npc = Main.npc[index];
      if (npc.active && npc.type >= 13 && npc.type <= 15)
      {
        info.npcIndexToAimAt = index;
        return true;
      }
    }
    return false;
  }
}
