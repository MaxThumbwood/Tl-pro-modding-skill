// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ObjectInteractions.PotionOfReturnSmartInteractCandidateProvider
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.GameContent.ObjectInteractions;

public class PotionOfReturnSmartInteractCandidateProvider : ISmartInteractCandidateProvider
{
  private PotionOfReturnSmartInteractCandidateProvider.ReusableCandidate _candidate = new PotionOfReturnSmartInteractCandidateProvider.ReusableCandidate();

  public void ClearSelfAndPrepareForCheck() => Main.SmartInteractPotionOfReturn = false;

  public bool ProvideCandidate(
    SmartInteractScanSettings settings,
    out ISmartInteractCandidate candidate)
  {
    candidate = (ISmartInteractCandidate) null;
    Rectangle homeHitbox;
    if (!PotionOfReturnHelper.TryGetGateHitbox(settings.player, out homeHitbox))
      return false;
    Vector2 vector2 = homeHitbox.ClosestPointInRect(settings.mousevec);
    float distanceFromCursor = vector2.Distance(settings.mousevec);
    Point tileCoordinates = vector2.ToTileCoordinates();
    if ((tileCoordinates.X < settings.LX || tileCoordinates.X > settings.HX || tileCoordinates.Y < settings.LY ? 0 : (tileCoordinates.Y <= settings.HY ? 1 : 0)) == 0)
      return false;
    this._candidate.Reuse(distanceFromCursor);
    candidate = (ISmartInteractCandidate) this._candidate;
    return true;
  }

  private class ReusableCandidate : ISmartInteractCandidate
  {
    public float DistanceFromCursor { get; private set; }

    public void WinCandidacy()
    {
      Main.SmartInteractPotionOfReturn = true;
      Main.SmartInteractShowingGenuine = true;
    }

    public void Reuse(float distanceFromCursor) => this.DistanceFromCursor = distanceFromCursor;
  }
}
