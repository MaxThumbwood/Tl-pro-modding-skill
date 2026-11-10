// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.CameraModifiers.CameraInfo
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.Graphics.CameraModifiers;

public struct CameraInfo
{
  public Vector2 CameraPosition;
  public Vector2 OriginalCameraCenter;
  public Vector2 OriginalCameraPosition;

  public CameraInfo(Vector2 position)
  {
    this.OriginalCameraPosition = position;
    this.OriginalCameraCenter = position + Main.ScreenSize.ToVector2() / 2f;
    this.CameraPosition = this.OriginalCameraPosition;
  }
}
