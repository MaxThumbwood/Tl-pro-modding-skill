// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Elements.UICyclingImage
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent.UI.Elements;

public class UICyclingImage : UIImage
{
  public int FramesPerCycle;
  private List<Asset<Texture2D>> _textureAssets;
  private int _currentTextureIndex;
  private int _framesCounted;

  public UICyclingImage(List<Asset<Texture2D>> textureAssets)
  {
    this.FramesPerCycle = 45;
    this._textureAssets = textureAssets;
    this.SetImage(this._textureAssets[this._currentTextureIndex]);
  }

  public override void Update(GameTime gameTime)
  {
    base.Update(gameTime);
    if (++this._framesCounted < this.FramesPerCycle)
      return;
    this._framesCounted = 0;
    if (++this._currentTextureIndex >= this._textureAssets.Count)
      this._currentTextureIndex = 0;
    this.SetImage(this._textureAssets[this._currentTextureIndex]);
  }
}
