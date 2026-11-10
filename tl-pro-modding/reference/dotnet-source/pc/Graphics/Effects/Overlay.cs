// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Effects.Overlay
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace Terraria.Graphics.Effects;

public abstract class Overlay : GameEffect
{
  public OverlayMode Mode = OverlayMode.Inactive;
  private RenderLayers _layer = RenderLayers.All;

  public RenderLayers Layer => this._layer;

  public Overlay(EffectPriority priority, RenderLayers layer)
  {
    this._priority = priority;
    this._layer = layer;
  }

  public abstract void Draw(SpriteBatch spriteBatch);

  public abstract void Update(GameTime gameTime);
}
