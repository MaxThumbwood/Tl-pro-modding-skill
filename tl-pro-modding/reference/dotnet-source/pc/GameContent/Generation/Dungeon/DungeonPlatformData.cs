// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.DungeonPlatformData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon;

public struct DungeonPlatformData
{
  public Point Position;
  public int? OverrideStyle;
  public int OverrideMaxLengthAllowed;
  public int? OverrideHeightFluff;
  public bool InAHallway;
  public bool ForcePlacement;
  public bool SkipOtherPlatformsCheck;
  public bool SkipSpaceCheck;
  public double PlaceBooksChance;
  public bool NoWaterbolt;
  public double PlacePotsChance;
  public double PlaceWaterCandlesChance;
  public double PlacePotionBottlesChance;
  public Func<DungeonData, int, int, bool> canPlaceHereCallback;

  public bool IsAShelf
  {
    get
    {
      return this.PlaceBooksChance > 0.0 || this.PlacePotsChance > 0.0 || this.PlaceWaterCandlesChance > 0.0 || this.PlacePotionBottlesChance > 0.0;
    }
  }
}
