// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.ResourceSets.PlayerStatsSnapshot
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.UI.ResourceSets;

public struct PlayerStatsSnapshot
{
  public int Life;
  public int LifeMax;
  public int LifeFruitCount;
  public float LifePerSegment;
  public int Mana;
  public int ManaMax;
  public float ManaPerSegment;

  public PlayerStatsSnapshot(Player player)
  {
    this.Life = player.statLife;
    this.Mana = player.statMana;
    this.LifeMax = player.statLifeMax2;
    this.ManaMax = player.statManaMax2;
    float num1 = 20f;
    int num2 = player.statLifeMax / 20;
    int num3 = (player.statLifeMax - 400) / 5;
    if (num3 < 0)
      num3 = 0;
    if (num3 > 0)
    {
      num2 = player.statLifeMax / (20 + num3 / 4);
      num1 = (float) player.statLifeMax / 20f;
    }
    int num4 = player.statLifeMax2 - player.statLifeMax;
    if (num2 > 0)
      num1 += (float) (num4 / num2);
    this.LifeFruitCount = num3;
    this.LifePerSegment = num1;
    this.ManaPerSegment = 20f;
  }
}
