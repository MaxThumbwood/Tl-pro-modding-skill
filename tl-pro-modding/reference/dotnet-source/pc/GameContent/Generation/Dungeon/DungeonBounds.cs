// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.DungeonBounds
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using ReLogic.Utilities;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon;

public class DungeonBounds
{
  [JsonProperty]
  private Rectangle? _hitbox;
  private int _boundsLeft;
  private int _boundsRight;
  private int _boundsTop;
  private int _boundsBottom;

  public Rectangle Hitbox => this._hitbox.HasValue ? this._hitbox.Value : Rectangle.Empty;

  public int X => this._boundsLeft;

  public int Y => this._boundsTop;

  public int Width => this._boundsRight - this._boundsLeft;

  public int Height => this._boundsBottom - this._boundsTop;

  public int Size => this.Width <= this.Height ? this.Height : this.Width;

  public int Left
  {
    get => this._boundsLeft;
    set
    {
      this._boundsLeft = (int) MathHelper.Clamp((float) value, 10f, (float) (Main.maxTilesX - 10));
    }
  }

  public int Right
  {
    get => this._boundsRight;
    set
    {
      this._boundsRight = (int) MathHelper.Clamp((float) value, 10f, (float) (Main.maxTilesX - 10));
    }
  }

  public int Top
  {
    get => this._boundsTop;
    set
    {
      this._boundsTop = (int) MathHelper.Clamp((float) value, 10f, (float) (Main.maxTilesY - 10));
    }
  }

  public int Bottom
  {
    get => this._boundsBottom;
    set
    {
      this._boundsBottom = (int) MathHelper.Clamp((float) value, 10f, (float) (Main.maxTilesY - 10));
    }
  }

  public Point Center => new Point((this.Left + this.Right) / 2, (this.Top + this.Bottom) / 2);

  public Point RandomPointInBounds(UnifiedRandom genRand)
  {
    return new Point(genRand.Next(this.Left, this.Right + 1), genRand.Next(this.Top, this.Bottom + 1));
  }

  public void Inflate(int amount)
  {
    this.SetBounds(this.Left - amount, this.Top - amount, this.Right + amount, this.Bottom + amount);
  }

  public void Shrink(int amount)
  {
    this.SetBounds(this.Left + amount, this.Top + amount, this.Right - amount, this.Bottom - amount);
  }

  public bool ContainsWithFluff(Vector2 point, int fluff)
  {
    return fluff == 0 ? this.Contains((int) point.X, (int) point.Y) : this.ContainsWithFluff((int) point.X, (int) point.Y, fluff);
  }

  public bool ContainsWithFluff(Vector2D point, int fluff)
  {
    return fluff == 0 ? this.Contains((int) point.X, (int) point.Y) : this.ContainsWithFluff((int) point.X, (int) point.Y, fluff);
  }

  public bool ContainsWithFluff(Point point, int fluff)
  {
    return fluff == 0 ? this.Contains(point.X, point.Y) : this.ContainsWithFluff(point.X, point.Y, fluff);
  }

  public bool ContainsWithFluff(int x, int y, int fluff)
  {
    if (fluff == 0)
      return this.Contains(x, y);
    return this._hitbox.HasValue && new Rectangle(this._hitbox.Value.Left - fluff, this._hitbox.Value.Top - fluff, this._hitbox.Value.Width + fluff * 2, this._hitbox.Value.Height + fluff * 2).Contains(x, y);
  }

  public bool Contains(Vector2D point) => this.Contains((int) point.X, (int) point.Y);

  public bool Contains(Point point) => this.Contains(point.X, point.Y);

  public bool Contains(int x, int y) => this._hitbox.HasValue && this._hitbox.Value.Contains(x, y);

  public bool Intersects(DungeonBounds bounds)
  {
    return bounds.HasHitbox() && this.Intersects(bounds.Hitbox);
  }

  public bool Intersects(Rectangle hitbox)
  {
    return this._hitbox.HasValue && this._hitbox.Value.Intersects(hitbox);
  }

  public bool IntersectsWithLineThreePointCheck(Point startPoint, Point endPoint)
  {
    return this.IntersectsWithLineThreePointCheck(startPoint.ToVector2D(), endPoint.ToVector2D());
  }

  public bool IntersectsWithLineThreePointCheck(
    int startPointX,
    int startPointY,
    int endPointX,
    int endPointY)
  {
    return this.IntersectsWithLineThreePointCheck(new Vector2D((double) startPointX, (double) startPointY), new Vector2D((double) endPointX, (double) endPointY));
  }

  public bool IntersectsWithLineThreePointCheck(Vector2D startPoint, Vector2D endPoint)
  {
    return this._hitbox.HasValue && (this.Contains(startPoint) || this.Contains(endPoint) || this.Contains(Vector2D.op_Division(Vector2D.op_Addition(startPoint, endPoint), 2.0)));
  }

  public bool HasHitbox() => this._hitbox.HasValue;

  public void SetBoundsLeft(int minX) => this.Left = minX;

  public void SetBoundsRight(int maxX) => this.Right = maxX;

  public void SetBoundsTop(int minY) => this.Top = minY;

  public void SetBoundsBottom(int maxY) => this.Bottom = maxY;

  public void SetBounds(Rectangle rect)
  {
    this.SetBounds(rect.Left, rect.Top, rect.Right, rect.Bottom);
  }

  public void SetBounds(int minX, int minY, int maxX, int maxY)
  {
    this.Left = minX;
    this.Right = maxX;
    this.Top = minY;
    this.Bottom = maxY;
    this.CalculateHitbox();
  }

  public void UpdateBounds(int x, int y)
  {
    if (x < this._boundsLeft)
      this.Left = x;
    if (x > this._boundsRight)
      this.Right = x;
    if (y < this._boundsTop)
      this.Top = y;
    if (y <= this._boundsBottom)
      return;
    this.Bottom = y;
  }

  public void UpdateBounds(DungeonBounds bounds)
  {
    if (this.Width == 0 || this.Height == 0)
      this.SetBounds(bounds.Left, bounds.Top, bounds.Right, bounds.Bottom);
    else
      this.UpdateBounds(bounds.Left, bounds.Top, bounds.Right, bounds.Bottom);
  }

  public void UpdateBounds(int minX, int minY, int maxX, int maxY)
  {
    if (minX < this._boundsLeft)
      this.Left = minX;
    if (maxX > this._boundsRight)
      this.Right = maxX;
    if (minY < this._boundsTop)
      this.Top = minY;
    if (maxY <= this._boundsBottom)
      return;
    this.Bottom = maxY;
  }

  public Rectangle CalculateHitbox()
  {
    if (this.Right <= this.Left)
      this.Right = this.Left + 1;
    if (this.Bottom <= this.Top)
      this.Bottom = this.Top + 1;
    this._hitbox = new Rectangle?(new Rectangle(this.X, this.Y, this.Width, this.Height));
    return this._hitbox.Value;
  }

  public void Reset()
  {
    this._hitbox = new Rectangle?();
    this.Left = 0;
    this.Right = 0;
    this.Top = 0;
    this.Bottom = 0;
  }
}
