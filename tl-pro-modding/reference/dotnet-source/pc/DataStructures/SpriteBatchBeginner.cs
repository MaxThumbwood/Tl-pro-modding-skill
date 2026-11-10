// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.SpriteBatchBeginner
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics;

#nullable disable
namespace Terraria.DataStructures;

public struct SpriteBatchBeginner(
  SpriteSortMode sortMode,
  BlendState blendState,
  SamplerState samplerState,
  DepthStencilState depthStencilState,
  RasterizerState rasterizerState,
  Effect effect,
  Matrix transformMatrix)
{
  private SpriteSortMode sortMode = sortMode;
  private BlendState blendState = blendState;
  private SamplerState samplerState = samplerState;
  private DepthStencilState depthStencilState = depthStencilState;
  private RasterizerState rasterizerState = rasterizerState;
  private Effect effect = effect;
  public Matrix transformMatrix = transformMatrix;

  public void Begin(SpriteBatch spriteBatch)
  {
    spriteBatch.Begin(this.sortMode, this.blendState, this.samplerState, this.depthStencilState, this.rasterizerState, this.effect, this.transformMatrix);
  }

  public void Begin(SpriteBatch spriteBatch, SpriteSortMode sortMode)
  {
    spriteBatch.Begin(sortMode, this.blendState, this.samplerState, this.depthStencilState, this.rasterizerState, this.effect, this.transformMatrix);
  }

  public void Begin(TileBatch tileBatch)
  {
    tileBatch.Begin(this.rasterizerState, this.transformMatrix);
  }
}
