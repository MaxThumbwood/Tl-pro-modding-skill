// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.DrawAnimationScryingOrb
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace Terraria.DataStructures;

public class DrawAnimationScryingOrb : DrawAnimation
{
  private DrawAnimationScryingOrb.State _state;
  private int _nextStateCounter;
  private int _dir = 1;

  public override void Update()
  {
    if (++this.FrameCounter < this.TicksPerFrame)
      return;
    this.FrameCounter = 0;
    if (--this._nextStateCounter <= 0)
    {
      if (this._state != DrawAnimationScryingOrb.State.Moving)
      {
        this._state = DrawAnimationScryingOrb.State.Moving;
        this._nextStateCounter = Main.rand.Next(3, 9);
        if (Main.rand.Next(4) != 0)
          return;
        this._dir *= -1;
      }
      else
      {
        this._state = Main.rand.Next(4) == 0 ? DrawAnimationScryingOrb.State.FrozenCenter : DrawAnimationScryingOrb.State.Frozen;
        this._nextStateCounter = Main.rand.Next(7, 10);
      }
    }
    else
    {
      if (this._state != DrawAnimationScryingOrb.State.Moving)
        return;
      this.Frame += this._dir;
      if (this.Frame >= this.FrameCount)
      {
        this.Frame = 1;
      }
      else
      {
        if (this.Frame > 0)
          return;
        this.Frame = this.FrameCount - 1;
      }
    }
  }

  public override Rectangle GetFrame(Texture2D texture, int frameCounterOverride = -1)
  {
    int frameY = this._state == DrawAnimationScryingOrb.State.FrozenCenter ? 0 : this.Frame;
    if (frameCounterOverride >= 0)
      frameY = frameCounterOverride;
    return texture.Frame(verticalFrames: this.FrameCount, frameY: frameY, sizeOffsetY: -2);
  }

  private enum State
  {
    Moving,
    Frozen,
    FrozenCenter,
  }
}
