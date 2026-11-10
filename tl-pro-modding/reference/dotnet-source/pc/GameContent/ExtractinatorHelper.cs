// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ExtractinatorHelper
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent;

public class ExtractinatorHelper
{
  public static void RollExtractinatorDrop(
    int extractionMode,
    int extractinatorBlockType,
    out int itemType,
    out int stack)
  {
    int maxValue1 = 5000;
    int maxValue2 = 25;
    int maxValue3 = 50;
    int maxValue4 = -1;
    int num1 = -1;
    int num2 = -1;
    int num3 = 1;
    int num4 = -1;
    int maxValue5 = -1;
    int num5 = -1;
    int num6 = -1;
    switch (extractionMode)
    {
      case -1:
        itemType = -1;
        stack = 1;
        return;
      case 1:
        maxValue1 /= 3;
        maxValue2 *= 2;
        maxValue3 = 20;
        maxValue4 = 10;
        break;
      case 2:
        maxValue1 = -1;
        maxValue2 = -1;
        maxValue3 = -1;
        maxValue4 = -1;
        num1 = 1;
        num3 = -1;
        break;
      case 3:
        maxValue1 = -1;
        maxValue2 = -1;
        maxValue3 = -1;
        maxValue4 = -1;
        num1 = -1;
        num3 = -1;
        num2 = 1;
        break;
      case 4:
        maxValue1 = -1;
        maxValue2 = -1;
        maxValue3 = -1;
        num3 = -1;
        maxValue5 = 50;
        num4 = 1;
        break;
      case 5:
        maxValue1 = -1;
        maxValue2 = -1;
        maxValue3 = -1;
        num3 = -1;
        num6 = 1;
        break;
      case 6:
        maxValue1 = -1;
        maxValue2 = -1;
        maxValue3 = -1;
        num3 = -1;
        num5 = 1;
        break;
    }
    itemType = -1;
    stack = 1;
    if (maxValue4 != -1 && Main.rand.Next(maxValue4) == 0)
    {
      itemType = 3380;
      if (Main.rand.Next(5) == 0)
        stack += Main.rand.Next(2);
      if (Main.rand.Next(10) == 0)
        stack += Main.rand.Next(3);
      if (Main.rand.Next(15) != 0)
        return;
      stack += Main.rand.Next(4);
    }
    else if (num3 != -1 && Main.rand.Next(2) == 0)
    {
      if (Main.rand.Next(12000) == 0)
      {
        itemType = 74;
        if (Main.rand.Next(14) == 0)
          stack += Main.rand.Next(0, 2);
        if (Main.rand.Next(14) == 0)
          stack += Main.rand.Next(0, 2);
        if (Main.rand.Next(14) != 0)
          return;
        stack += Main.rand.Next(0, 2);
      }
      else if (Main.rand.Next(800) == 0)
      {
        itemType = 73;
        if (Main.rand.Next(6) == 0)
          stack += Main.rand.Next(1, 21);
        if (Main.rand.Next(6) == 0)
          stack += Main.rand.Next(1, 21);
        if (Main.rand.Next(6) == 0)
          stack += Main.rand.Next(1, 21);
        if (Main.rand.Next(6) == 0)
          stack += Main.rand.Next(1, 21);
        if (Main.rand.Next(6) != 0)
          return;
        stack += Main.rand.Next(1, 20);
      }
      else if (Main.rand.Next(60) == 0)
      {
        itemType = 72;
        if (Main.rand.Next(4) == 0)
          stack += Main.rand.Next(5, 26);
        if (Main.rand.Next(4) == 0)
          stack += Main.rand.Next(5, 26);
        if (Main.rand.Next(4) == 0)
          stack += Main.rand.Next(5, 26);
        if (Main.rand.Next(4) != 0)
          return;
        stack += Main.rand.Next(5, 25);
      }
      else
      {
        itemType = 71;
        if (Main.rand.Next(3) == 0)
          stack += Main.rand.Next(10, 26);
        if (Main.rand.Next(3) == 0)
          stack += Main.rand.Next(10, 26);
        if (Main.rand.Next(3) == 0)
          stack += Main.rand.Next(10, 26);
        if (Main.rand.Next(3) != 0)
          return;
        stack += Main.rand.Next(10, 25);
      }
    }
    else if (maxValue1 != -1 && Main.rand.Next(maxValue1) == 0)
      itemType = 1242;
    else if (num1 != -1)
    {
      if (Main.rand.Next(4) != 1)
        itemType = 2674;
      else if (Main.rand.Next(3) != 1)
        itemType = 2006;
      else if (Main.rand.Next(3) != 1)
        itemType = 2002;
      else
        itemType = 2675;
    }
    else if (num2 != -1 && extractinatorBlockType == 642)
    {
      if (Main.rand.Next(10) == 1)
      {
        itemType = Main.rand.Next(5);
        if (itemType == 0)
          itemType = 4354;
        else if (itemType == 1)
          itemType = 4389;
        else if (itemType == 2)
          itemType = 4377;
        else if (itemType == 3)
          itemType = 5127;
        else
          itemType = 4378;
      }
      else
      {
        itemType = Main.rand.Next(5);
        if (itemType == 0)
          itemType = 4349;
        else if (itemType == 1)
          itemType = 4350;
        else if (itemType == 2)
          itemType = 4351;
        else if (itemType == 3)
          itemType = 4352;
        else
          itemType = 4353;
      }
    }
    else if (num2 != -1)
    {
      itemType = Main.rand.Next(5);
      if (itemType == 0)
        itemType = 4349;
      else if (itemType == 1)
        itemType = 4350;
      else if (itemType == 2)
        itemType = 4351;
      else if (itemType == 3)
        itemType = 4352;
      else
        itemType = 4353;
    }
    else if (maxValue5 != -1 && Main.rand.Next(maxValue5) == 0)
    {
      itemType = Main.rand.Next(3);
      if (itemType == 0)
        itemType = 62;
      else if (itemType == 1)
      {
        itemType = 195;
      }
      else
      {
        if (itemType != 2)
          return;
        itemType = 194;
      }
    }
    else if (num4 > 0)
      itemType = 2;
    else if (num6 > 0)
      itemType = 1125;
    else if (num5 > 0)
      itemType = 169;
    else if (maxValue2 != -1 && Main.rand.Next(maxValue2) == 0)
    {
      itemType = Main.rand.Next(6);
      itemType = itemType != 0 ? (itemType != 1 ? (itemType != 2 ? (itemType != 3 ? (itemType != 4 ? 182 : 178) : 179) : 177) : 180) : 181;
      if (Main.rand.Next(20) == 0)
        stack += Main.rand.Next(0, 2);
      if (Main.rand.Next(30) == 0)
        stack += Main.rand.Next(0, 3);
      if (Main.rand.Next(40) == 0)
        stack += Main.rand.Next(0, 4);
      if (Main.rand.Next(50) == 0)
        stack += Main.rand.Next(0, 5);
      if (Main.rand.Next(60) != 0)
        return;
      stack += Main.rand.Next(0, 6);
    }
    else if (maxValue3 != -1 && Main.rand.Next(maxValue3) == 0)
    {
      itemType = 999;
      if (Main.rand.Next(20) == 0)
        stack += Main.rand.Next(0, 2);
      if (Main.rand.Next(30) == 0)
        stack += Main.rand.Next(0, 3);
      if (Main.rand.Next(40) == 0)
        stack += Main.rand.Next(0, 4);
      if (Main.rand.Next(50) == 0)
        stack += Main.rand.Next(0, 5);
      if (Main.rand.Next(60) != 0)
        return;
      stack += Main.rand.Next(0, 6);
    }
    else if (Main.rand.Next(3) == 0)
    {
      if (Main.rand.Next(5000) == 0)
      {
        itemType = 74;
        if (Main.rand.Next(10) == 0)
          stack += Main.rand.Next(0, 3);
        if (Main.rand.Next(10) == 0)
          stack += Main.rand.Next(0, 3);
        if (Main.rand.Next(10) == 0)
          stack += Main.rand.Next(0, 3);
        if (Main.rand.Next(10) == 0)
          stack += Main.rand.Next(0, 3);
        if (Main.rand.Next(10) != 0)
          return;
        stack += Main.rand.Next(0, 3);
      }
      else if (Main.rand.Next(400) == 0)
      {
        itemType = 73;
        if (Main.rand.Next(5) == 0)
          stack += Main.rand.Next(1, 21);
        if (Main.rand.Next(5) == 0)
          stack += Main.rand.Next(1, 21);
        if (Main.rand.Next(5) == 0)
          stack += Main.rand.Next(1, 21);
        if (Main.rand.Next(5) == 0)
          stack += Main.rand.Next(1, 21);
        if (Main.rand.Next(5) != 0)
          return;
        stack += Main.rand.Next(1, 20);
      }
      else if (Main.rand.Next(30) == 0)
      {
        itemType = 72;
        if (Main.rand.Next(3) == 0)
          stack += Main.rand.Next(5, 26);
        if (Main.rand.Next(3) == 0)
          stack += Main.rand.Next(5, 26);
        if (Main.rand.Next(3) == 0)
          stack += Main.rand.Next(5, 26);
        if (Main.rand.Next(3) != 0)
          return;
        stack += Main.rand.Next(5, 25);
      }
      else
      {
        itemType = 71;
        if (Main.rand.Next(2) == 0)
          stack += Main.rand.Next(10, 26);
        if (Main.rand.Next(2) == 0)
          stack += Main.rand.Next(10, 26);
        if (Main.rand.Next(2) == 0)
          stack += Main.rand.Next(10, 26);
        if (Main.rand.Next(2) != 0)
          return;
        stack += Main.rand.Next(10, 25);
      }
    }
    else
    {
      itemType = ExtractinatorHelper.RollOreEarlymode();
      if (extractinatorBlockType == 642 && Main.hardMode)
        itemType = ExtractinatorHelper.RollOreHardmode();
      if (Main.rand.Next(20) == 0)
        stack += Main.rand.Next(0, 2);
      if (Main.rand.Next(30) == 0)
        stack += Main.rand.Next(0, 3);
      if (Main.rand.Next(40) == 0)
        stack += Main.rand.Next(0, 4);
      if (Main.rand.Next(50) == 0)
        stack += Main.rand.Next(0, 5);
      if (Main.rand.Next(60) != 0)
        return;
      stack += Main.rand.Next(0, 6);
    }
  }

  private static int RollOreHardmode()
  {
    int num;
    switch (Main.rand.Next(14))
    {
      case 0:
        num = 12;
        break;
      case 1:
        num = 11;
        break;
      case 2:
        num = 14;
        break;
      case 3:
        num = 13;
        break;
      case 4:
        num = 699;
        break;
      case 5:
        num = 700;
        break;
      case 6:
        num = 701;
        break;
      case 7:
        num = 702;
        break;
      case 8:
        num = 364;
        break;
      case 9:
        num = 1104;
        break;
      case 10:
        num = 365;
        break;
      case 11:
        num = 1105;
        break;
      case 12:
        num = 366;
        break;
      default:
        num = 1106;
        break;
    }
    return num;
  }

  private static int RollOreEarlymode()
  {
    int num;
    switch (Main.rand.Next(8))
    {
      case 0:
        num = 12;
        break;
      case 1:
        num = 11;
        break;
      case 2:
        num = 14;
        break;
      case 3:
        num = 13;
        break;
      case 4:
        num = 699;
        break;
      case 5:
        num = 700;
        break;
      case 6:
        num = 701;
        break;
      default:
        num = 702;
        break;
    }
    return num;
  }
}
