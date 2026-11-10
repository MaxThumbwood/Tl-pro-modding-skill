// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Camera
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace Terraria.Graphics;

public class Camera
{
  public Vector2 UnscaledPosition => Main.screenPosition;

  public Vector2 UnscaledSize => new Vector2((float) Main.screenWidth, (float) Main.screenHeight);

  public Vector2 ScaledPosition => this.UnscaledPosition + this.GameViewMatrix.Translation;

  public Vector2 ScaledSize => this.UnscaledSize - this.GameViewMatrix.Translation * 2f;

  public float BiggerScaledAxis
  {
    get
    {
      Vector2 scaledSize = this.ScaledSize;
      return (double) scaledSize.X <= (double) scaledSize.Y ? scaledSize.Y : scaledSize.X;
    }
  }

  public float SmallerScaledAxis
  {
    get
    {
      Vector2 scaledSize = this.ScaledSize;
      return (double) scaledSize.X >= (double) scaledSize.Y ? scaledSize.Y : scaledSize.X;
    }
  }

  public RasterizerState Rasterizer => Main.Rasterizer;

  public SamplerState Sampler => Main.DefaultSamplerState;

  public SpriteViewMatrix GameViewMatrix => Main.GameViewMatrix;

  public SpriteBatch SpriteBatch => Main.spriteBatch;

  public Vector2 Center => this.UnscaledPosition + this.UnscaledSize * 0.5f;
}
