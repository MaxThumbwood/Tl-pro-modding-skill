// Decompiled with JetBrains decompiler
// Type: Terraria.ID.ImmunityCooldownID
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.ID;

public static class ImmunityCooldownID
{
  public static readonly int General = -1;
  public static readonly int TileContactDamage = 0;
  public static readonly int BossNoCheese = 1;
  public static readonly int LegacyUnused2 = 2;
  public static readonly int WrongBugNet = 3;
  public static readonly int Lava = 4;
  public static readonly int PaladinsShield = 5;
  public static readonly int Count = 6;

  public static class Sets
  {
    public static ImmunityCooldownID.Sets.BoolSet Retaliate = ImmunityCooldownID.Sets.CreateBoolSet(ImmunityCooldownID.General, ImmunityCooldownID.BossNoCheese, ImmunityCooldownID.PaladinsShield);
    public static ImmunityCooldownID.Sets.BoolSet Counter = ImmunityCooldownID.Sets.CreateBoolSet(ImmunityCooldownID.General, ImmunityCooldownID.BossNoCheese);
    public static ImmunityCooldownID.Sets.BoolSet TeamDamageShare = ImmunityCooldownID.Sets.CreateBoolSet(ImmunityCooldownID.General, ImmunityCooldownID.BossNoCheese);
    public static ImmunityCooldownID.Sets.BoolSet ImmuneTimerOnlyLimitsEffects = ImmunityCooldownID.Sets.CreateBoolSet(ImmunityCooldownID.PaladinsShield);

    public static ImmunityCooldownID.Sets.BoolSet CreateBoolSet(params int[] types)
    {
      ImmunityCooldownID.Sets.BoolSet boolSet = new ImmunityCooldownID.Sets.BoolSet(ImmunityCooldownID.Count);
      foreach (int type in types)
        boolSet[type] = true;
      return boolSet;
    }

    public struct BoolSet(int count)
    {
      private readonly bool[] _arr = new bool[count + 1];

      public bool this[int idx]
      {
        get => this._arr[idx + 1];
        set => this._arr[idx + 1] = value;
      }
    }
  }
}
