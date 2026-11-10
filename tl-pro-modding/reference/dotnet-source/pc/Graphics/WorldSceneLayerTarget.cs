// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.WorldSceneLayerTarget
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

#nullable disable
namespace Terraria.Graphics;

public class WorldSceneLayerTarget
{
  private readonly RenderTarget2D _target;
  private Vector2 _position;

  public Texture2D Texture => (Texture2D) this._target;

  public Vector2 Position => this._position;

  public bool IsPartiallyOffscreen
  {
    get
    {
      if (this._position == Vector2.Zero)
        return true;
      Vector2 vector2_1 = new Vector2((float) this._target.Width, (float) this._target.Height);
      Vector2 vector2_2 = this.Position + vector2_1 / 2f - Main.Camera.Center;
      Vector2 vector2_3 = (vector2_1 - Main.Camera.ScaledSize) / 2f;
      return (double) Math.Abs(vector2_2.X) > (double) vector2_3.X || (double) Math.Abs(vector2_2.Y) > (double) vector2_3.Y;
    }
  }

  public bool IsContentLost => this._target.IsContentLost;

  public WorldSceneLayerTarget(GraphicsDevice graphicsDevice, int width, int height)
  {
    this._target = new RenderTarget2D(graphicsDevice, width, height, false, graphicsDevice.PresentationParameters.BackBufferFormat, DepthFormat.None);
  }

  public void UpdateContent(Action render)
  {
    Vector2 screenPosition = Main.screenPosition;
    Point screenSize = Main.ScreenSize;
    Vector2 zoom = Main.GameViewMatrix.Zoom;
    Vector2 center = Main.Camera.Center;
    Main.screenWidth = this._target.Width - Main.offScreenRange * 2;
    Main.screenHeight = this._target.Height - Main.offScreenRange * 2;
    Vector2 vector2 = Main.ScreenSize.ToVector2() / 2f;
    Main.screenPosition = Utils.Round(center - vector2);
    Main.GameViewMatrix.Zoom = Vector2.One;
    GraphicsDevice graphicsDevice = Main.instance.GraphicsDevice;
    RenderTargetBinding[] renderTargets = graphicsDevice.GetRenderTargets();
    graphicsDevice.SetRenderTarget(this._target);
    graphicsDevice.Clear(Color.Transparent);
    this._position = Main.screenPosition - new Vector2((float) Main.offScreenRange, (float) Main.offScreenRange);
    render();
    graphicsDevice.SetRenderTargets(renderTargets);
    Main.screenPosition = screenPosition;
    Main.screenWidth = screenSize.X;
    Main.screenHeight = screenSize.Y;
    Main.GameViewMatrix.Zoom = zoom;
  }

  public void Dispose() => this._target.Dispose();
}
