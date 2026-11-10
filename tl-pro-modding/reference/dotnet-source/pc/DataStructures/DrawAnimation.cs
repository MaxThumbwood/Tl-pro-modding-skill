// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.DrawAnimation
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace Terraria.DataStructures;

public class DrawAnimation
{
  public int Frame;
  public int FrameCount;
  public int TicksPerFrame;
  public int FrameCounter;

  public virtual void Update()
  {
  }

  public virtual Rectangle GetFrame(Texture2D texture, int frameCounterOverride = -1)
  {
    return texture.Frame();
  }
}
