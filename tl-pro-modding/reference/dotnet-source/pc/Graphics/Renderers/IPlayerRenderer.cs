// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Renderers.IPlayerRenderer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.Collections.Generic;

#nullable disable
namespace Terraria.Graphics.Renderers;

public interface IPlayerRenderer
{
  void DrawPlayers(Camera camera, IEnumerable<Player> players);

  void DrawPlayerHead(
    Camera camera,
    Player drawPlayer,
    Vector2 position,
    float alpha = 1f,
    float scale = 1f,
    Color borderColor = default (Color));

  void DrawPlayer(
    Camera camera,
    Player drawPlayer,
    Vector2 position,
    float rotation,
    Vector2 rotationOrigin,
    float shadow = 0.0f,
    float scale = 1f);

  void PrepareDrawForFrame(Player drawPlayer);
}
