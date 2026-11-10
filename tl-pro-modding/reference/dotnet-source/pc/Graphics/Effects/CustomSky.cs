// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Effects.CustomSky
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace Terraria.Graphics.Effects;

public abstract class CustomSky : GameEffect
{
  public abstract void Update(GameTime gameTime);

  public abstract void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth);

  public abstract bool IsActive();

  public abstract void Reset();

  public virtual Color OnTileColor(Color inColor) => inColor;

  public virtual float GetCloudAlpha() => 1f;

  public override bool IsVisible() => true;
}
