// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.DroneCameraTracker
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.DataStructures;

public class DroneCameraTracker
{
  private Projectile _trackedProjectile;
  private int _lastTrackedType;

  public void Track(Projectile proj)
  {
    this._trackedProjectile = proj;
    this._lastTrackedType = proj.type;
  }

  public void WorldClear()
  {
    this._lastTrackedType = 0;
    this._trackedProjectile = (Projectile) null;
  }

  public bool TryTracking(out Vector2 cameraPosition)
  {
    cameraPosition = new Vector2();
    if (this._trackedProjectile == null || !this._trackedProjectile.active || this._trackedProjectile.type != this._lastTrackedType || this._trackedProjectile.owner != Main.myPlayer || !Main.LocalPlayer.remoteVisionForDrone)
    {
      this._trackedProjectile = (Projectile) null;
      return false;
    }
    cameraPosition = this._trackedProjectile.Center;
    return true;
  }
}
