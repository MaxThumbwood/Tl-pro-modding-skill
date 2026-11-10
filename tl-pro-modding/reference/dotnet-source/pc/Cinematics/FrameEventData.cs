// Decompiled with JetBrains decompiler
// Type: Terraria.Cinematics.FrameEventData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Cinematics;

public struct FrameEventData(int absoluteFrame, int start, int duration)
{
  private int _absoluteFrame = absoluteFrame;
  private int _start = start;
  private int _duration = duration;

  public int AbsoluteFrame => this._absoluteFrame;

  public int Start => this._start;

  public int Duration => this._duration;

  public int Frame => this._absoluteFrame - this._start;

  public bool IsFirstFrame => this._start == this._absoluteFrame;

  public bool IsLastFrame => this.Remaining == 0;

  public int Remaining => this._start + this._duration - this._absoluteFrame - 1;
}
