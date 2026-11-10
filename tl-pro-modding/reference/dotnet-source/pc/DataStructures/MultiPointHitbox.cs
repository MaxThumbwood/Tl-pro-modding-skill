// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.MultiPointHitbox
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.DataStructures;

public class MultiPointHitbox
{
  public readonly Point PointSize;
  public readonly Vector2[] Points;
  public readonly Rectangle BoundingRect;

  public MultiPointHitbox(Point pointSize, Vector2[] points)
  {
    this.PointSize = pointSize;
    this.Points = points;
    Rectangle rect = Utils.CenteredRectangle(points[0], Vector2.Zero);
    foreach (Vector2 point in points)
      rect = rect.Including(point.ToPoint());
    this.BoundingRect = rect;
  }

  public bool Intersects(Rectangle targetRect)
  {
    targetRect.Inflate(this.PointSize.X / 2, this.PointSize.Y / 2);
    if (!this.BoundingRect.Intersects(targetRect))
      return false;
    foreach (Vector2 point in this.Points)
    {
      if (targetRect.Contains(point.ToPoint()))
        return true;
    }
    return false;
  }
}
