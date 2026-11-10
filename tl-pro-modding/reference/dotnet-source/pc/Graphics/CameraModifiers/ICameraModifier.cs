// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.CameraModifiers.ICameraModifier
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Graphics.CameraModifiers;

public interface ICameraModifier
{
  string UniqueIdentity { get; }

  void Update(ref CameraInfo cameraPosition);

  bool IsAScreenShake { get; }

  bool Finished { get; }
}
