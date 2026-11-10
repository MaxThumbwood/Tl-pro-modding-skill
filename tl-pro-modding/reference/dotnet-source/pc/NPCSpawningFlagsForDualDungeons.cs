// Decompiled with JetBrains decompiler
// Type: Terraria.NPCSpawningFlagsForDualDungeons
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.GameContent.Generation.Dungeon;
using Terraria.ID;

#nullable disable
namespace Terraria;

public struct NPCSpawningFlagsForDualDungeons
{
  public bool ZoneDungeon;
  public bool ZoneSnow;
  public bool ZoneGlowshroom;
  public bool ZoneCorrupt;
  public bool ZoneCrimson;
  public bool ZoneJungle;
  public bool ZoneHallow;
  public bool ZoneLihzhardTemple;
  public bool ZoneUndergroundDesert;

  public bool CanScan(Tile tile)
  {
    ushort type = tile.type;
    return tile.active() && Main.tileSolid[(int) type] && !Main.tileSolidTop[(int) type] && !TileID.Sets.Boulders[(int) type] && type != (ushort) 48 /*0x30*/ && type != (ushort) 137 && type != (ushort) 232;
  }

  public bool ScanZonesFor(
    bool scanOnly,
    int spawnTileX,
    int spawnTileY,
    int spawnTileType,
    int spawnWallType,
    bool npcSpawnPointIsInDualDungeon)
  {
    if (!npcSpawnPointIsInDualDungeon)
      return false;
    bool flag = false;
    if (spawnTileType <= 191)
    {
      if (spawnTileType <= 62)
      {
        if (spawnTileType <= 32 /*0x20*/)
        {
          if (spawnTileType != 1)
          {
            if ((uint) (spawnTileType - 22) <= 3U || spawnTileType == 32 /*0x20*/)
              goto label_53;
            goto label_74;
          }
        }
        else
        {
          switch (spawnTileType - 38)
          {
            case 0:
              break;
            case 1:
            case 2:
            case 4:
              goto label_74;
            case 3:
            case 5:
            case 6:
              goto label_65;
            default:
              if (spawnTileType != 59)
              {
                if ((uint) (spawnTileType - 60) <= 2U)
                  goto label_43;
                goto label_74;
              }
              goto label_46;
          }
        }
        if (spawnWallType > 0 && DungeonGenerationStyles.Cavern.WallIsInStyle(spawnWallType))
        {
          flag = true;
          goto label_74;
        }
        goto label_74;
      }
      if (spawnTileType <= 120)
      {
        if ((uint) (spawnTileType - 70) > 2U)
        {
          if (spawnTileType != 74)
          {
            switch (spawnTileType - 109)
            {
              case 0:
              case 1:
              case 4:
              case 7:
              case 8:
              case 9:
                goto label_37;
              case 3:
                goto label_53;
              case 11:
                break;
              default:
                goto label_74;
            }
          }
          else
            goto label_43;
        }
        else
          goto label_71;
      }
      else
      {
        if (spawnTileType <= 148)
        {
          if (spawnTileType != 140)
          {
            if ((uint) (spawnTileType - 147) <= 1U)
              goto label_40;
            goto label_74;
          }
          goto label_53;
        }
        switch (spawnTileType - 161)
        {
          case 0:
          case 1:
            goto label_40;
          case 2:
            if (!scanOnly)
              this.ZoneSnow = this.ZoneCorrupt = true;
            flag = true;
            goto label_74;
          case 3:
            goto label_37;
          default:
            if (spawnTileType == 191)
            {
              flag = true;
              goto label_74;
            }
            goto label_74;
        }
      }
label_46:
      if (spawnWallType > 0 && WallID.Sets.DualDungeonsJungleBiomeWalls[spawnWallType])
      {
        if (!scanOnly)
          this.ZoneJungle = true;
        flag = true;
        goto label_74;
      }
      goto label_74;
    }
    if (spawnTileType <= 385)
    {
      if (spawnTileType <= 234)
      {
        switch (spawnTileType - 195)
        {
          case 0:
          case 4:
          case 6:
          case 8:
          case 9:
            break;
          case 1:
          case 2:
          case 3:
          case 7:
          case 10:
            goto label_74;
          case 5:
            if (!scanOnly)
              this.ZoneSnow = this.ZoneCrimson = true;
            flag = true;
            goto label_74;
          case 11:
            goto label_40;
          default:
            switch (spawnTileType - 224 /*0xE0*/)
            {
              case 0:
                goto label_40;
              case 1:
                goto label_43;
              case 2:
                if (!scanOnly)
                  this.ZoneLihzhardTemple = true;
                flag = true;
                goto label_74;
              default:
                if (spawnTileType == 234)
                  break;
                goto label_74;
            }
            break;
        }
      }
      else if (spawnTileType <= 352)
      {
        if (spawnTileType != 347 && spawnTileType != 352)
          goto label_74;
      }
      else
      {
        if ((uint) (spawnTileType - 383) > 1U)
        {
          if (spawnTileType == 385)
            goto label_37;
          goto label_74;
        }
        goto label_43;
      }
    }
    else if (spawnTileType <= 483)
    {
      switch (spawnTileType - 398)
      {
        case 0:
        case 2:
          goto label_53;
        case 1:
        case 3:
          break;
        case 4:
        case 5:
          goto label_37;
        default:
          if (spawnTileType != 474)
          {
            if ((uint) (spawnTileType - 481) <= 2U)
              goto label_65;
            goto label_74;
          }
          goto label_53;
      }
    }
    else
    {
      if (spawnTileType <= 528)
      {
        if (spawnTileType != 492)
        {
          if (spawnTileType == 528)
            goto label_71;
          goto label_74;
        }
        goto label_37;
      }
      if (spawnTileType != 661)
      {
        if (spawnTileType != 662)
          goto label_74;
      }
      else
        goto label_53;
    }
    if (!scanOnly)
      this.ZoneCrimson = true;
    flag = true;
    goto label_74;
label_37:
    if (!scanOnly)
      this.ZoneHallow = true;
    flag = true;
    goto label_74;
label_40:
    if (!scanOnly)
      this.ZoneSnow = true;
    flag = true;
    goto label_74;
label_43:
    if (!scanOnly)
      this.ZoneJungle = true;
    flag = true;
    goto label_74;
label_53:
    if (!scanOnly)
      this.ZoneCorrupt = true;
    flag = true;
    goto label_74;
label_65:
    if (!scanOnly && (double) spawnTileY > Main.rockLayer)
      this.ZoneDungeon = true;
    flag = true;
    goto label_74;
label_71:
    if (!scanOnly)
      this.ZoneGlowshroom = true;
    flag = true;
label_74:
    if (spawnTileType == 123 && spawnWallType > 0)
    {
      if (spawnWallType > 0 && DungeonGenerationStyles.Cavern.WallIsInStyle(spawnWallType))
        flag = true;
      else if (WallID.Sets.DualDungeonsJungleBiomeWalls[spawnWallType])
      {
        if (!scanOnly)
          this.ZoneJungle = true;
        flag = true;
      }
      else if (spawnWallType == (int) DungeonGenerationStyles.Temple.BrickWallType)
      {
        if (!scanOnly)
          this.ZoneLihzhardTemple = true;
        flag = true;
      }
    }
    if (spawnTileType <= 112 /*0x70*/)
    {
      if (spawnTileType != 53 && spawnTileType != 112 /*0x70*/)
        goto label_92;
    }
    else if (spawnTileType != 116 && spawnTileType != 234 && (uint) (spawnTileType - 396) > 7U)
      goto label_92;
    if (WallID.Sets.Conversion.HardenedSand[spawnWallType] || WallID.Sets.Conversion.Sandstone[spawnWallType] || spawnWallType == 223)
    {
      if (!scanOnly)
        this.ZoneUndergroundDesert = true;
      flag = true;
    }
label_92:
    return flag;
  }
}
