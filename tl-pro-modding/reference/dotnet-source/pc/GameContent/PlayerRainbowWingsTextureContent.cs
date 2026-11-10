// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.PlayerRainbowWingsTextureContent
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;

#nullable disable
namespace Terraria.GameContent;

public class PlayerRainbowWingsTextureContent : ARenderTargetContentByRequest
{
  protected override void HandleUseRequest(GraphicsDevice device, SpriteBatch spriteBatch)
  {
    Asset<Texture2D> asset = TextureAssets.Extra[171];
    this.PrepareARenderTarget_AndListenToEvents(ref this._target, device, asset.Width(), asset.Height(), RenderTargetUsage.PreserveContents);
    device.SetRenderTarget(this._target);
    device.Clear(Color.Transparent);
    DrawData drawData = new DrawData(asset.Value, Vector2.Zero, Color.White);
    spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend);
    GameShaders.Misc["HallowBoss"].Apply(new DrawData?(drawData));
    drawData.Draw(spriteBatch);
    spriteBatch.End();
    device.SetRenderTarget((RenderTarget2D) null);
    this._wasPrepared = true;
  }
}
