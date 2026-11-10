// Decompiled with JetBrains decompiler
// Type: Terraria.LiquidBuffer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria;

public class LiquidBuffer
{
  public static int numLiquidBuffer;
  public int x;
  public int y;

  public static void AddBuffer(int x, int y)
  {
    if (LiquidBuffer.numLiquidBuffer >= 49998 || Main.tile[x, y].checkingLiquid())
      return;
    Main.tile[x, y].checkingLiquid(true);
    Main.liquidBuffer[LiquidBuffer.numLiquidBuffer].x = x;
    Main.liquidBuffer[LiquidBuffer.numLiquidBuffer].y = y;
    ++LiquidBuffer.numLiquidBuffer;
  }

  public static void DelBuffer(int l)
  {
    --LiquidBuffer.numLiquidBuffer;
    Main.liquidBuffer[l].x = Main.liquidBuffer[LiquidBuffer.numLiquidBuffer].x;
    Main.liquidBuffer[l].y = Main.liquidBuffer[LiquidBuffer.numLiquidBuffer].y;
  }
}
