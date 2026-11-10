// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.SpriteViewMatrix
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace Terraria.Graphics;

public class SpriteViewMatrix
{
  private Vector2 _zoom = Vector2.One;
  private Vector2 _translation = Vector2.Zero;
  private Matrix _zoomMatrix = Matrix.Identity;
  private Matrix _transformationMatrix = Matrix.Identity;
  private Matrix _normalizedTransformationMatrix = Matrix.Identity;
  private SpriteEffects _effects;
  private Matrix _effectMatrix;
  private GraphicsDevice _graphicsDevice;
  private Viewport _viewport;
  private bool _overrideSystemViewport;
  private bool _needsRebuild = true;
  private const float PixelPerfectOffset = 0.00390625f;
  private const float PixelPerfectSafeZoomLevelStep = 0.0078125f;

  public Vector2 Zoom
  {
    get => this._zoom;
    set
    {
      if (!(this._zoom != value))
        return;
      this._zoom = value;
      this._needsRebuild = true;
    }
  }

  public Vector2 Translation
  {
    get
    {
      if (this.ShouldRebuild())
        this.Rebuild();
      return this._translation;
    }
  }

  public Matrix ZoomMatrix
  {
    get
    {
      if (this.ShouldRebuild())
        this.Rebuild();
      return this._zoomMatrix;
    }
  }

  public Matrix TransformationMatrix
  {
    get
    {
      if (this.ShouldRebuild())
        this.Rebuild();
      return this._transformationMatrix;
    }
  }

  public Matrix NormalizedTransformationMatrix
  {
    get
    {
      if (this.ShouldRebuild())
        this.Rebuild();
      return this._normalizedTransformationMatrix;
    }
  }

  public Vector2 RenderZoom => new Vector2(this.ZoomMatrix.M11, this.ZoomMatrix.M22);

  public SpriteEffects Effects
  {
    get => this._effects;
    set
    {
      if (this._effects == value)
        return;
      this._effects = value;
      this._needsRebuild = true;
    }
  }

  public Matrix EffectMatrix
  {
    get
    {
      if (this.ShouldRebuild())
        this.Rebuild();
      return this._effectMatrix;
    }
  }

  public SpriteViewMatrix(GraphicsDevice graphicsDevice) => this._graphicsDevice = graphicsDevice;

  private void Rebuild()
  {
    if (!this._overrideSystemViewport)
      this._viewport = this._graphicsDevice.Viewport;
    Vector2 vector2_1 = new Vector2((float) this._viewport.Width, (float) this._viewport.Height);
    Matrix identity = Matrix.Identity;
    if ((this._effects & SpriteEffects.FlipHorizontally) != SpriteEffects.None)
      identity *= Matrix.CreateScale(-1f, 1f, 1f) * Matrix.CreateTranslation(vector2_1.X, 0.0f, 0.0f);
    if ((this._effects & SpriteEffects.FlipVertically) != SpriteEffects.None)
      identity *= Matrix.CreateScale(1f, -1f, 1f) * Matrix.CreateTranslation(0.0f, vector2_1.Y, 0.0f);
    Vector2 vector2_2 = Utils.Round(this._zoom / (1f / 128f)) * (1f / 128f);
    Vector2 vector2_3 = vector2_1 * 0.5f;
    Vector2 vector2_4 = Utils.Round(vector2_3 - vector2_3 / vector2_2);
    Matrix orthographicOffCenter = Matrix.CreateOrthographicOffCenter(0.0f, vector2_1.X, vector2_1.Y, 0.0f, 0.0f, 1f);
    this._translation = vector2_4;
    this._zoomMatrix = Matrix.CreateTranslation(-vector2_4.X, -vector2_4.Y, 0.0f) * Matrix.CreateScale(vector2_2.X, vector2_2.Y, 1f);
    this._effectMatrix = identity;
    this._transformationMatrix = identity * this._zoomMatrix;
    this._transformationMatrix *= Matrix.CreateTranslation(1f / 256f, 1f / 256f, 0.0f);
    this._normalizedTransformationMatrix = Matrix.Invert(identity) * this._zoomMatrix * orthographicOffCenter;
    this._needsRebuild = false;
  }

  public void SetViewportOverride(Viewport viewport)
  {
    this._viewport = viewport;
    this._overrideSystemViewport = true;
  }

  public void ClearViewportOverride() => this._overrideSystemViewport = false;

  private bool ShouldRebuild()
  {
    if (this._needsRebuild)
      return true;
    if (this._overrideSystemViewport || this._graphicsDevice.IsDisposed)
      return false;
    return this._graphicsDevice.Viewport.Width != this._viewport.Width || this._graphicsDevice.Viewport.Height != this._viewport.Height;
  }
}
