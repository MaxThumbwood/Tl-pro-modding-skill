// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Light.ILightingEngine
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.Graphics.Light;

public interface ILightingEngine
{
  void Rebuild();

  void AddLight(int x, int y, Vector3 color);

  void ProcessArea(Rectangle area);

  Vector3 GetColor(int x, int y);

  void Clear();
}
