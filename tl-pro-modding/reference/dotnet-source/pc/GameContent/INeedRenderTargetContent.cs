// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.INeedRenderTargetContent
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace Terraria.GameContent;

public interface INeedRenderTargetContent
{
  bool IsReady { get; }

  void PrepareRenderTarget(GraphicsDevice device, SpriteBatch spriteBatch);

  void Reset();
}
