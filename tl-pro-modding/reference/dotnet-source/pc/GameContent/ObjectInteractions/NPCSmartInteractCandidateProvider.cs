// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ObjectInteractions.NPCSmartInteractCandidateProvider
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.DataStructures;

#nullable disable
namespace Terraria.GameContent.ObjectInteractions;

public class NPCSmartInteractCandidateProvider : ISmartInteractCandidateProvider
{
  private NPCSmartInteractCandidateProvider.ReusableCandidate _candidate = new NPCSmartInteractCandidateProvider.ReusableCandidate();

  public void ClearSelfAndPrepareForCheck() => Main.SmartInteractNPC = -1;

  public bool ProvideCandidate(
    SmartInteractScanSettings settings,
    out ISmartInteractCandidate candidate)
  {
    candidate = (ISmartInteractCandidate) null;
    if (!settings.FullInteraction)
      return false;
    Rectangle worldRegion = TileReachCheckSettings.Simple.GetWorldRegion(settings.player);
    Vector2 mousevec = settings.mousevec;
    mousevec.ToPoint();
    bool flag = false;
    int npcIndex = -1;
    float npcDistanceFromCursor = -1f;
    for (int index = 0; index < Main.maxNPCs; ++index)
    {
      NPC npc = Main.npc[index];
      if (npc.active && npc.townNPC && npc.Hitbox.Intersects(worldRegion) && !flag)
      {
        float num = npc.Hitbox.Distance(mousevec);
        if ((npcIndex == -1 ? 1 : ((double) Main.npc[npcIndex].Hitbox.Distance(mousevec) > (double) num ? 1 : 0)) != 0)
        {
          npcIndex = index;
          npcDistanceFromCursor = num;
        }
        if ((double) num == 0.0)
        {
          flag = true;
          npcIndex = index;
          npcDistanceFromCursor = num;
          break;
        }
      }
    }
    if (settings.DemandOnlyZeroDistanceTargets && !flag || npcIndex == -1)
      return false;
    this._candidate.Reuse(npcIndex, npcDistanceFromCursor);
    candidate = (ISmartInteractCandidate) this._candidate;
    return true;
  }

  private class ReusableCandidate : ISmartInteractCandidate
  {
    private int _npcIndexToTarget;

    public float DistanceFromCursor { get; private set; }

    public void WinCandidacy()
    {
      Main.SmartInteractNPC = this._npcIndexToTarget;
      Main.SmartInteractShowingGenuine = true;
    }

    public void Reuse(int npcIndex, float npcDistanceFromCursor)
    {
      this._npcIndexToTarget = npcIndex;
      this.DistanceFromCursor = npcDistanceFromCursor;
    }
  }
}
