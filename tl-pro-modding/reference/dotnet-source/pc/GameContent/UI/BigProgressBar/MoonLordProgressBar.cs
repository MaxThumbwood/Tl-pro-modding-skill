// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.BigProgressBar.MoonLordProgressBar
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Terraria.ID;

#nullable disable
namespace Terraria.GameContent.UI.BigProgressBar;

public class MoonLordProgressBar : IBigProgressBar
{
  private BigProgressBarCache _cache;
  private NPC _referenceDummy;
  private HashSet<int> ValidIds = new HashSet<int>()
  {
    396,
    397,
    398
  };

  public MoonLordProgressBar() => this._referenceDummy = new NPC();

  public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
  {
    if (info.npcIndexToAimAt < 0 || info.npcIndexToAimAt > Main.maxNPCs)
      return false;
    NPC npc1 = Main.npc[info.npcIndexToAimAt];
    if ((!npc1.active || this.IsInBadAI(npc1)) && !this.TryFindingAnotherMoonLordPiece(ref info))
      return false;
    int num1 = 0;
    NPCSpawnParams matchingSpawnParams = npc1.GetMatchingSpawnParams();
    this._referenceDummy.SetDefaults(398, matchingSpawnParams);
    int num2 = num1 + this._referenceDummy.lifeMax;
    this._referenceDummy.SetDefaults(396, matchingSpawnParams);
    int num3 = num2 + this._referenceDummy.lifeMax;
    this._referenceDummy.SetDefaults(397, matchingSpawnParams);
    int max = num3 + this._referenceDummy.lifeMax + this._referenceDummy.lifeMax;
    float current = 0.0f;
    for (int index = 0; index < Main.maxNPCs; ++index)
    {
      NPC npc2 = Main.npc[index];
      if (npc2.active && this.ValidIds.Contains(npc2.type) && !this.IsInBadAI(npc2))
        current += (float) npc2.life;
    }
    this._cache.SetLife(current, (float) max);
    return true;
  }

  private bool IsInBadAI(NPC npc)
  {
    return npc.type == 398 && ((double) npc.ai[0] == 2.0 || (double) npc.ai[0] == -1.0) || npc.type == 398 && (double) npc.localAI[3] == 0.0 || (double) npc.ai[0] == -2.0 || (double) npc.ai[0] == -3.0;
  }

  public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
  {
    int bossHeadTexture = NPCID.Sets.BossHeadTextures[396];
    Texture2D texture2D = TextureAssets.NpcHeadBoss[bossHeadTexture].Value;
    Rectangle barIconFrame = texture2D.Frame();
    BigProgressBarHelper.DrawFancyBar(spriteBatch, this._cache.LifeCurrent, this._cache.LifeMax, texture2D, barIconFrame);
  }

  private bool TryFindingAnotherMoonLordPiece(ref BigProgressBarInfo info)
  {
    for (int index = 0; index < Main.maxNPCs; ++index)
    {
      NPC npc = Main.npc[index];
      if (npc.active && this.ValidIds.Contains(npc.type) && !this.IsInBadAI(npc))
      {
        info.npcIndexToAimAt = index;
        return true;
      }
    }
    return false;
  }
}
