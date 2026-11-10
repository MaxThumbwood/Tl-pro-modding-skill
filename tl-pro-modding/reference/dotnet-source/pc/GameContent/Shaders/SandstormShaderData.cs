// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Shaders.SandstormShaderData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.Graphics.Shaders;

#nullable disable
namespace Terraria.GameContent.Shaders;

public class SandstormShaderData(string passName) : ScreenShaderData(passName)
{
  private Vector2 _texturePosition = Vector2.Zero;

  public override void Update(GameTime gameTime)
  {
    Vector2 vector2 = new Vector2(-Main.windSpeedCurrent, -1f) * new Vector2(20f, 0.1f);
    vector2.Normalize();
    Vector2 direction = vector2 * new Vector2(2f, 0.2f);
    if (FocusHelper.UpdateVisualEffects)
      this._texturePosition += direction * (float) gameTime.ElapsedGameTime.TotalSeconds;
    this._texturePosition.X %= 10f;
    this._texturePosition.Y %= 10f;
    this.UseDirection(direction);
    base.Update(gameTime);
  }

  public override void Apply()
  {
    this.UseTargetPosition(this._texturePosition);
    base.Apply();
  }
}
