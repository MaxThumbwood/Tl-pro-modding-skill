// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.VirtualCamera
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.Graphics;

public struct VirtualCamera(Player player)
{
  public readonly Player Player = player;

  public Vector2 Position => this.Center - this.Size * 0.5f;

  public Vector2 Size => new Vector2((float) Main.maxScreenW, (float) Main.maxScreenH);

  public Vector2 Center => this.Player.Center;
}
