// Decompiled with JetBrains decompiler
// Type: Terraria.ID.SurfaceBackgroundID
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.Reflection;

#nullable disable
namespace Terraria.ID;

public class SurfaceBackgroundID
{
  public const int Forest1 = 0;
  public const int Corruption = 1;
  public const int Desert = 2;
  public const int Jungle = 3;
  public const int Ocean = 4;
  public const int CorruptDesert = 5;
  public const int Hallow = 6;
  public const int Snow = 7;
  public const int Crimson = 8;
  public const int Mushroom = 9;
  public const int Forest2 = 10;
  public const int Forest3 = 11;
  public const int Forest4 = 12;
  public const int HallowDesert = 13;
  public const int CrimsonDesert = 14;
  public const int Empty = 15;
  public const int Count = 16 /*0x10*/;
  public static readonly IdDictionary Search = IdDictionary.Create<SurfaceBackgroundID, int>();

  public static class Sets
  {
    public static SetFactory Factory = new SetFactory(16 /*0x10*/);
    public static bool[] IsDesertVariant = SurfaceBackgroundID.Sets.Factory.CreateBoolSet(false, 2, 5, 13, 14);
    public static bool[] IsForest = SurfaceBackgroundID.Sets.Factory.CreateBoolSet(false, 0, 10, 11, 12);
  }
}
