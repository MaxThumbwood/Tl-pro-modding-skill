// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Luck
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent;

public static class Luck
{
  public static int RollLuck(float luck, int range)
  {
    if ((double) luck > 0.0 && (double) Main.rand.NextFloat() < (double) luck)
      return Main.rand.Next(Main.rand.Next(range / 2, range));
    return (double) luck < 0.0 && (double) Main.rand.NextFloat() < -(double) luck ? Main.rand.Next(Main.rand.Next(range, range * 2)) : Main.rand.Next(range);
  }

  public static int RollBadLuck(float luck, int range)
  {
    if ((double) luck > 0.0 && (double) Main.rand.NextFloat() < (double) luck)
      return Main.rand.Next(Main.rand.Next(range, range * 2));
    return (double) luck < 0.0 && (double) Main.rand.NextFloat() < -(double) luck ? Main.rand.Next(Main.rand.Next(range / 2, range)) : Main.rand.Next(range);
  }

  public static int RollOnlyBadLuck(float luck, int range)
  {
    return (double) luck < 0.0 && (double) Main.rand.NextFloat() < -(double) luck ? Main.rand.Next(Main.rand.Next(range / 2, range)) : Main.rand.Next(range);
  }

  public static int RollBadLuckExtreme(float luck, int range)
  {
    if ((double) luck > 0.0 && (double) Main.rand.NextFloat() < (double) luck)
      return Main.rand.Next(range * 10);
    return (double) luck < 0.0 && (double) Main.rand.NextFloat() < -(double) luck ? Main.rand.Next(range / 10) : Main.rand.Next(range);
  }

  public static int RollOnlyBadLuckExtreme(float luck, int range)
  {
    return (double) luck < 0.0 && (double) Main.rand.NextFloat() < -(double) luck ? Main.rand.Next(range / 10) : -1;
  }
}
