// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Drawing.TileDrawingBase
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Graphics;

#nullable disable
namespace Terraria.GameContent.Drawing;

public class TileDrawingBase
{
  protected TimeLogger.TimeLogData FlushLogData;
  protected TimeLogger.TimeLogData DrawCallLogData;
  private SpriteBatchBeginner batchBeginner;

  public void Begin(RasterizerState rasterizer, Matrix transformation)
  {
    this.batchBeginner = new SpriteBatchBeginner(SpriteSortMode.Deferred, BlendState.AlphaBlend, Main.DefaultSamplerState, DepthStencilState.None, rasterizer, (Effect) null, transformation);
    this.batchBeginner.Begin(Main.tileBatch);
    this.batchBeginner.Begin(Main.spriteBatch);
  }

  public void End()
  {
    TimeLogger.StartTimestamp fromTimestamp = TimeLogger.Start();
    int num = Main.tileBatch.End() + Main.spriteBatch.PendingDrawCallCount();
    Main.spriteBatch.End();
    this.DrawCallLogData.Add(num);
    this.FlushLogData.AddTime(fromTimestamp);
  }

  public void RestartLayeredBatch()
  {
    TimeLogger.StartTimestamp fromTimestamp = TimeLogger.Start();
    this.DrawCallLogData.Add(Main.tileBatch.Restart());
    this.FlushLogData.AddTime(fromTimestamp);
  }

  public void RestartSpriteBatch()
  {
    TimeLogger.StartTimestamp fromTimestamp = TimeLogger.Start();
    int num = Main.spriteBatch.PendingDrawCallCount();
    Main.spriteBatch.End();
    this.batchBeginner.Begin(Main.spriteBatch);
    this.DrawCallLogData.Add(num);
    this.FlushLogData.AddTime(fromTimestamp);
  }
}
