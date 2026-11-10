// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.DrillDebugDraw
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.DataStructures;

public struct DrillDebugDraw(Vector2 p, Color c)
{
  public Vector2 point = p;
  public Color color = c;
}
