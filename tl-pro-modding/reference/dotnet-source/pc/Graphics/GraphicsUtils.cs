// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.GraphicsUtils
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework.Graphics;
using System;
using System.Reflection;

#nullable disable
namespace Terraria.Graphics;

public static class GraphicsUtils
{
  private static FieldInfo SpriteBatch_spriteQueueCount;
  private static FieldInfo SpriteBatch_spriteTextures;

  public static int PendingDrawCallCount(this SpriteBatch spriteBatch)
  {
    if (GraphicsUtils.SpriteBatch_spriteQueueCount == (FieldInfo) null)
    {
      bool flag = typeof (SpriteBatch).Assembly.GetName().Name == "Microsoft.Xna.Framework.Graphics";
      GraphicsUtils.SpriteBatch_spriteQueueCount = typeof (SpriteBatch).GetField(flag ? "spriteQueueCount" : "numSprites", BindingFlags.Instance | BindingFlags.NonPublic);
      GraphicsUtils.SpriteBatch_spriteTextures = typeof (SpriteBatch).GetField(flag ? "spriteTextures" : "textureInfo", BindingFlags.Instance | BindingFlags.NonPublic);
    }
    int n = (int) GraphicsUtils.SpriteBatch_spriteQueueCount.GetValue((object) spriteBatch);
    return GraphicsUtils.DrawCallCount((Texture[]) GraphicsUtils.SpriteBatch_spriteTextures.GetValue((object) spriteBatch), n);
  }

  private static int DrawCallCount(Texture[] textures, int n)
  {
    int num1 = 0;
    if (Program.IsXna)
    {
      Texture texture1 = (Texture) null;
      int num2 = 0;
      int vbPos = 0;
      for (int index = 0; index < n; ++index)
      {
        Texture texture2 = textures[index];
        if (texture2 != texture1)
        {
          if (index > num2)
            num1 += GraphicsUtils.DrawCallCountXNA(index - num2, ref vbPos);
          num2 = index;
          texture1 = texture2;
        }
      }
      num1 += GraphicsUtils.DrawCallCountXNA(n - num2, ref vbPos);
    }
    else
    {
      int index1 = 0;
      while (true)
      {
        int num3 = Math.Min(n, 2048 /*0x0800*/);
        Texture texture3 = textures[index1];
        for (int index2 = 1; index2 < num3; ++index2)
        {
          Texture texture4 = textures[index1 + index2];
          if (texture4 != texture3)
          {
            ++num1;
            texture3 = texture4;
          }
        }
        ++num1;
        if (n > 2048 /*0x0800*/)
        {
          n -= 2048 /*0x0800*/;
          index1 += 2048 /*0x0800*/;
        }
        else
          break;
      }
    }
    return num1;
  }

  private static int DrawCallCountXNA(int count, ref int vbPos)
  {
    int num1 = 0;
    while (count > 0)
    {
      int num2 = count;
      if (num2 > 2048 /*0x0800*/ - vbPos)
      {
        num2 = 2048 /*0x0800*/ - vbPos;
        if (num2 < 256 /*0x0100*/)
        {
          vbPos = 0;
          num2 = count;
          if (num2 > 2048 /*0x0800*/)
            num2 = 2048 /*0x0800*/;
        }
      }
      vbPos += num2;
      count -= num2;
      ++num1;
    }
    return num1;
  }
}
