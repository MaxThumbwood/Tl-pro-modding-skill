// Decompiled with JetBrains decompiler
// Type: Terraria.Testing.DebugLineDraw
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

#nullable disable
namespace Terraria.Testing;

public class DebugLineDraw
{
  public static readonly DebugLineDraw UI = new DebugLineDraw(true);
  public static readonly DebugLineDraw World = new DebugLineDraw(false);
  private static DebugLineDraw.UpdatePhase CurrentPhase;
  private readonly List<DebugLineDraw.LineDrawer> lines = new List<DebugLineDraw.LineDrawer>();
  private readonly bool _ui;

  private DebugLineDraw(bool ui) => this._ui = ui;

  public void AddLine(
    Vector2 start,
    Vector2 end,
    Color colorStart,
    Color colorEnd = default (Color),
    int LifeTime = 1,
    float width = 1f)
  {
    this.lines.Add(new DebugLineDraw.LineDrawer(start, end, colorStart, colorEnd, LifeTime, width));
  }

  public void AddLine(
    Point start,
    Point end,
    Color colorStart,
    Color colorEnd = default (Color),
    int LifeTime = 1,
    float width = 1f)
  {
    this.lines.Add(new DebugLineDraw.LineDrawer(start.ToVector2(), end.ToVector2(), colorStart, colorEnd, LifeTime, width));
  }

  public void AddRectangle(
    Vector2 start,
    Vector2 end,
    Color colorStart,
    Color colorEnd = default (Color),
    int LifeTime = 1,
    float width = 1f)
  {
    this.lines.Add(new DebugLineDraw.LineDrawer(start, new Vector2(start.X, end.Y), colorStart, colorEnd, LifeTime, width));
    this.lines.Add(new DebugLineDraw.LineDrawer(start, new Vector2(end.X, start.Y), colorStart, colorEnd, LifeTime, width));
    this.lines.Add(new DebugLineDraw.LineDrawer(end, new Vector2(start.X, end.Y), colorStart, colorEnd, LifeTime, width));
    this.lines.Add(new DebugLineDraw.LineDrawer(end, new Vector2(end.X, start.Y), colorStart, colorEnd, LifeTime, width));
  }

  public static void PreUpdate() => DebugLineDraw.SetPhase(DebugLineDraw.UpdatePhase.Update);

  public static void PreWorldUpdate()
  {
    DebugLineDraw.SetPhase(DebugLineDraw.UpdatePhase.UpdateInWorld);
  }

  public static void PreDraw() => DebugLineDraw.SetPhase(DebugLineDraw.UpdatePhase.Draw);

  private static void SetPhase(DebugLineDraw.UpdatePhase phase)
  {
    DebugLineDraw.CurrentPhase = phase;
    DebugLineDraw.UI.TickLines();
    DebugLineDraw.World.TickLines();
  }

  public void TickLines()
  {
    int index1 = 0;
    for (int index2 = 0; index2 < this.lines.Count; ++index2)
    {
      DebugLineDraw.LineDrawer line = this.lines[index2];
      if (line.Phase == DebugLineDraw.CurrentPhase)
        --line.TimeLeft;
      if (line.TimeLeft >= 0)
        this.lines[index1++] = line;
    }
    this.lines.RemoveRange(index1, this.lines.Count - index1);
  }

  public void Draw(SpriteBatch spriteBatch)
  {
    if (this.lines.Count == 0)
      return;
    spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, Main.DefaultSamplerState, (DepthStencilState) null, (RasterizerState) null, (Effect) null, this._ui ? Matrix.CreateTranslation(Main.screenPosition.X, Main.screenPosition.Y, 0.0f) * Main.UIScaleMatrix : Main.GameViewMatrix.TransformationMatrix);
    for (int index = 0; index < this.lines.Count; ++index)
      this.lines[index].Draw(spriteBatch);
    spriteBatch.End();
  }

  private enum UpdatePhase
  {
    Update,
    UpdateInWorld,
    Draw,
  }

  private class LineDrawer
  {
    public Vector2 vS;
    public Vector2 vE;
    public Color cS;
    public Color cE;
    public int TimeLeft;
    public float Width;
    public DebugLineDraw.UpdatePhase Phase = DebugLineDraw.CurrentPhase;

    public LineDrawer(
      Vector2 start,
      Vector2 end,
      Color colorStart,
      Color colorEnd = default (Color),
      int LifeTime = 1,
      float width = 1f)
    {
      this.vS = start;
      this.vE = end;
      this.cS = colorStart;
      this.cE = colorEnd == new Color() ? colorStart : colorEnd;
      this.TimeLeft = LifeTime;
      this.Width = width;
    }

    public void Draw(SpriteBatch spriteBatch)
    {
      Utils.DrawLine(spriteBatch, this.vS, this.vE, this.cS, this.cE, this.Width);
    }
  }
}
