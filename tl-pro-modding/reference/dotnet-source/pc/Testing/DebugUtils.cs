// Decompiled with JetBrains decompiler
// Type: Terraria.Testing.DebugUtils
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Testing.ChatCommands;
using Terraria.UI.Chat;

#nullable disable
namespace Terraria.Testing;

public static class DebugUtils
{
  private static char[] _slopeIcons = new char[5]
  {
    '⬓',
    '◣',
    '◢',
    '◤',
    '◥'
  };

  internal static string GetTileDescription(int x, int y)
  {
    Tile tile = Main.tile[x, y];
    if (tile == null)
      return "";
    Point tileCoordinates = (Main.LocalPlayer.Bottom + new Vector2(-8f, 8f)).ToTileCoordinates();
    string str1;
    if (!TileID.Search.TryGetName((int) tile.type, ref str1))
      str1 = "Unknown";
    string str2;
    if (!WallID.Search.TryGetName((int) tile.wall, ref str2))
      str2 = "Unknown";
    string str3 = "   ";
    return $"{str3}Pos: {(object) x}, {(object) y}\n{str3}Type: {(object) tile.type}{(tile.blockType() == 0 ? (object) "" : (object) (" " + DebugUtils._slopeIcons[tile.blockType() - 1].ToString()))} ({str1})\n{str3}Frame: {(object) tile.frameX}, {(object) tile.frameY}\n{str3}FrameImportant: {Main.tileFrameImportant[(int) tile.type].ToString()}\n{str3}Liquid: {(object) tile.liquid} ({(object) tile.liquidType()})\n{str3}Wall: {(object) tile.wall} ({str2})\n{str3}Compare Spot: {(object) tileCoordinates.X}, {(object) tileCoordinates.Y}\n{str3}Chunk: {(object) (x / 200)}, {(object) (y / 150)}\n{str3}Paints: {(object) tile.color()}, {(object) tile.wallColor()}";
  }

  internal static bool PracticeModeReset(Player player, PlayerDeathReason damageSource)
  {
    if (!DebugOptions.PracticeMode || !NPC.AnyDanger(ignorePillarsAndMoonlordCountdown: true))
      return false;
    player.statLife = player.statLifeMax2;
    for (int b = 0; b < Player.maxBuffs; ++b)
    {
      if (player.buffTime[b] > 0)
      {
        int index = player.buffType[b];
        if (Main.debuff[index] && (index == 21 || !BuffID.Sets.NurseCannotRemoveDebuff[index]))
        {
          player.DelBuff(b);
          b = -1;
        }
      }
    }
    for (int index = 0; index < BuffID.Count; ++index)
    {
      if (Main.debuff[index])
        player.buffImmune[index] = true;
    }
    string str = "unknown source";
    Entity entity;
    damageSource.TryGetCausingEntity(out entity);
    switch (entity)
    {
      case NPC _:
        str = ((NPC) entity).TypeName;
        break;
      case Projectile _:
        str = ((Projectile) entity).Name;
        break;
      case Player _:
        str = ((Player) entity).name;
        break;
    }
    Main.NewText("Lethal damage dealt by " + str, B: (byte) 0);
    if (Main.netMode != 0)
      return true;
    for (int index = 0; index < 1000; ++index)
    {
      Projectile projectile = Main.projectile[index];
      if (projectile.active && projectile.hostile)
        projectile.active = false;
    }
    for (int index = 0; index < Main.maxNPCs; ++index)
    {
      NPC npc = Main.npc[index];
      if (npc.active && !npc.friendly && !npc.isLikeATownNPC)
        npc.active = false;
    }
    return true;
  }

  public static void QuickSPMessage(string message)
  {
    ChatManager.DebugCommands.Process(new DebugMessage((byte) Main.myPlayer, message));
  }
}
