// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Renderers.OutlinedTextureRenderer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent;

#nullable disable
namespace Terraria.Graphics.Renderers;

public class OutlinedTextureRenderer : INeedRenderTargetContent
{
  private OutlinedDrawRenderTargetContent[] _contents;
  private Asset<Texture2D>[] _matchingArray;

  public OutlinedTextureRenderer(Asset<Texture2D>[] matchingArray)
  {
    this._matchingArray = matchingArray;
    this.Reset();
  }

  public void Reset()
  {
    this._contents = new OutlinedDrawRenderTargetContent[this._matchingArray.Length];
  }

  public void DrawWithOutlines(
    int textureIndex,
    Vector2 position,
    Color color,
    float rotation,
    float scale,
    SpriteEffects effects)
  {
    if (this._contents[textureIndex] == null)
    {
      this._contents[textureIndex] = new OutlinedDrawRenderTargetContent();
      this._contents[textureIndex].SetTexture(this._matchingArray[textureIndex].Value);
    }
    OutlinedDrawRenderTargetContent content = this._contents[textureIndex];
    if (content.IsReady)
    {
      RenderTarget2D target = content.GetTarget();
      Main.spriteBatch.Draw((Texture2D) target, position, new Rectangle?(), color, rotation, target.Size() / 2f, scale, effects, 0.0f);
    }
    else
      content.Request();
  }

  public bool IsReady => false;

  public bool RequestAndTryGet(int textureIndex, out RenderTarget2D renderTarget)
  {
    renderTarget = (RenderTarget2D) null;
    if (this._contents[textureIndex] == null)
    {
      this._contents[textureIndex] = new OutlinedDrawRenderTargetContent();
      this._contents[textureIndex].SetTexture(this._matchingArray[textureIndex].Value);
    }
    OutlinedDrawRenderTargetContent content = this._contents[textureIndex];
    if (!content.IsReady)
    {
      content.Request();
      return false;
    }
    renderTarget = content.GetTarget();
    return true;
  }

  public void PrepareRenderTarget(GraphicsDevice device, SpriteBatch spriteBatch)
  {
    for (int index = 0; index < this._contents.Length; ++index)
    {
      if (this._contents[index] != null && !this._contents[index].IsReady)
        this._contents[index].PrepareRenderTarget(device, spriteBatch);
    }
  }
}
