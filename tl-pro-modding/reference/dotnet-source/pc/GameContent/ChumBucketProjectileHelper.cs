// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ChumBucketProjectileHelper
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent;

public class ChumBucketProjectileHelper
{
  private Dictionary<Point, int> _chumCountsPendingForThisFrame = new Dictionary<Point, int>();
  private Dictionary<Point, int> _chumCountsFromLastFrame = new Dictionary<Point, int>();

  public void OnPreUpdateAllProjectiles()
  {
    Utils.Swap<Dictionary<Point, int>>(ref this._chumCountsPendingForThisFrame, ref this._chumCountsFromLastFrame);
    this._chumCountsPendingForThisFrame.Clear();
  }

  public void AddChumLocation(Vector2 spot)
  {
    Point tileCoordinates = spot.ToTileCoordinates();
    int num1 = 0;
    this._chumCountsPendingForThisFrame.TryGetValue(tileCoordinates, out num1);
    int num2 = num1 + 1;
    this._chumCountsPendingForThisFrame[tileCoordinates] = num2;
  }

  public int GetChumsInLocation(Point tileCoords)
  {
    int chumsInLocation = 0;
    this._chumCountsFromLastFrame.TryGetValue(tileCoords, out chumsInLocation);
    return chumsInLocation;
  }
}
