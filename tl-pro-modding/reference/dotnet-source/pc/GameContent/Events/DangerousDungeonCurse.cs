// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Events.DangerousDungeonCurse
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.GameContent.Generation.Dungeon;

#nullable disable
namespace Terraria.GameContent.Events;

public class DangerousDungeonCurse
{
  public static int GetProgressPlayerNeedsToMatch(Player player)
  {
    if (player.ZoneLihzhardTemple)
      return DualDungeonUnbreakableWallTiers.Temple;
    if (player.ZoneHallow)
      return DualDungeonUnbreakableWallTiers.Hallow;
    if (player.ZoneDungeon)
      return DualDungeonUnbreakableWallTiers.Dungeon;
    if (player.ZoneJungle)
      return DualDungeonUnbreakableWallTiers.JungleBoss;
    return player.ZoneCrimson || player.ZoneCorrupt ? DualDungeonUnbreakableWallTiers.EvilBoss : DualDungeonUnbreakableWallTiers.EarlyGame;
  }

  public static int GetProgressPlayerCanSafelyMatch()
  {
    if (NPC.downedMechBossAny || NPC.downedQueenSlime)
      return DualDungeonUnbreakableWallTiers.Temple;
    if (NPC.downedBoss3 || Main.hardMode)
      return DualDungeonUnbreakableWallTiers.Hallow;
    if (NPC.downedQueenBee)
      return DualDungeonUnbreakableWallTiers.Dungeon;
    if (NPC.downedBoss2)
      return DualDungeonUnbreakableWallTiers.JungleBoss;
    return NPC.downedSlimeKing || NPC.downedBoss1 ? DualDungeonUnbreakableWallTiers.EvilBoss : DualDungeonUnbreakableWallTiers.EarlyGame;
  }
}
