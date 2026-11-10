// Decompiled with JetBrains decompiler
// Type: Terraria.ID.PlayerVoiceID
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.ID;

public class PlayerVoiceID
{
  public static int[] VariantOrder = new int[3]{ 1, 2, 3 };
  public const int None = 0;
  public const int Male = 1;
  public const int Female = 2;
  public const int Other = 3;
  public const int Count = 4;

  public static class Sets
  {
    public static SetFactory Factory = new SetFactory(4);
    public static Color[] Colors = PlayerVoiceID.Sets.Factory.CreateCustomSet<Color>(Color.White, (object) 1, (object) Color.CornflowerBlue, (object) 2, (object) Color.HotPink, (object) 3, (object) Color.LimeGreen);
  }
}
