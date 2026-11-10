// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Capture.CaptureManager
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

#nullable disable
namespace Terraria.Graphics.Capture;

public class CaptureManager : IDisposable
{
  public static CaptureManager Instance = new CaptureManager();
  private CaptureInterface _interface;
  private CaptureCamera _camera;

  public bool IsCapturing => !Main.dedServ && this._camera.IsCapturing;

  public CaptureManager()
  {
    this._interface = new CaptureInterface();
    if (Main.dedServ)
      return;
    this._camera = new CaptureCamera(Main.instance.GraphicsDevice);
  }

  public bool Active
  {
    get => this._interface.Active;
    set
    {
      if (Main.CaptureModeDisabled || this._interface.Active == value)
        return;
      this._interface.ToggleCamera(value);
    }
  }

  public bool UsingMap => this.Active && this._interface.UsingMap();

  public void Scrolling() => this._interface.Scrolling();

  public void Update(CaptureInterface.SelectionContext context) => this._interface.Update(context);

  public void Draw(SpriteBatch sb) => this._interface.Draw(sb);

  public float GetProgress() => this._camera.GetProgress();

  public void Capture()
  {
    this.Capture(new CaptureSettings()
    {
      Area = new Rectangle(2660, 100, 1000, 1000),
      UseScaling = false
    });
  }

  public void Capture(CaptureSettings settings) => this._camera.Capture(settings);

  public void DrawTick()
  {
    this._interface.UpdateCameraCountdown();
    this._camera.DrawTick();
  }

  public void Dispose() => this._camera.Dispose();
}
