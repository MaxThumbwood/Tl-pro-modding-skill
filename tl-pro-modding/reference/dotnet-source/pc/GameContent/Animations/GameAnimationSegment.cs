// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Animations.GameAnimationSegment
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace Terraria.GameContent.Animations;

public struct GameAnimationSegment
{
  public SpriteBatch SpriteBatch;
  public Vector2 AnchorPositionOnScreen;
  public int TimeInAnimation;
  public float DisplayOpacity;
}
