// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Drawing.INatureRenderer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

#nullable disable
namespace Terraria.GameContent.Drawing;

public interface INatureRenderer
{
  void DrawNature(
    Texture2D texture,
    Vector2 position,
    Rectangle sourceRectangle,
    Color color,
    float rotation,
    Vector2 origin,
    float scale,
    SpriteEffects effects,
    float layerDepth,
    SideFlags seams = SideFlags.None);

  void DrawGlowmask(
    Texture2D texture,
    Vector2 position,
    Rectangle? sourceRectangle,
    Color color,
    float rotation,
    Vector2 origin,
    float scale,
    SpriteEffects effects,
    float layerDepth);

  void DrawAfterAllObjects(SpriteBatchBeginner beginner);
}
