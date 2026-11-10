// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.DungeonData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.Utilities;
using System.Collections.Generic;
using Terraria.GameContent.Generation.Dungeon.Entrances;
using Terraria.GameContent.Generation.Dungeon.Features;
using Terraria.GameContent.Generation.Dungeon.Halls;
using Terraria.GameContent.Generation.Dungeon.Rooms;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon;

public class DungeonData
{
  public DungeonType Type;
  public int Iteration;
  public DungeonEntrance dungeonEntrance;
  public List<DungeonRoom> dungeonRooms = new List<DungeonRoom>();
  public List<DungeonHall> dungeonHalls = new List<DungeonHall>();
  public List<IDungeonFeature> dungeonFeatures = new List<IDungeonFeature>();
  public List<DungeonDoorData> dungeonDoorData = new List<DungeonDoorData>();
  public List<DungeonPlatformData> dungeonPlatformData = new List<DungeonPlatformData>();
  public List<DungeonBounds> protectedDungeonBounds = new List<DungeonBounds>();
  public bool makeNextPitTrapFlooded;
  public bool useSkewedDungeonEntranceHalls;
  public bool createdDungeonEntranceOnSurface;
  public double dungeonEntranceStrengthX;
  public double dungeonEntranceStrengthY;
  public double dungeonEntranceStrengthX2;
  public double dungeonEntranceStrengthY2;
  public Vector2D lastDungeonHall = Vector2D.Zero;
  public DungeonBounds dungeonBounds = new DungeonBounds();
  public DungeonBounds[] outerProgressionBounds = new DungeonBounds[0];
  public int[] wallVariants = new int[3];
  public int chandelierItemType;
  public int platformItemType;
  public int doorItemType;
  public int[] lanternStyles = new int[3];
  public int[] shelfStyles = new int[3];
  public int[] bannerStyles = new int[6];
  public double globalFeatureScalar = 1.0;
  public double dungeonStepScalar = 1.0;
  public double hallStrengthScalar = 1.0;
  public double hallStepScalar = 1.0;
  public double hallInteriorToExteriorRatio = 0.5;
  public double hallSlantVariantScalar = 1.0;
  public double roomStrengthScalar = 1.0;
  public double roomStepScalar = 1.0;
  public double roomInteriorToExteriorRatio = 0.5;
  public double roomSlantVariantScalar = 1.0;

  public DungeonGenVars genVars => GenVars.dungeonGenVars[this.Iteration];

  public double HallSizeScalar => (this.hallStrengthScalar + this.hallStepScalar) / 2.0;

  public double RoomSizeScalar => (this.roomStrengthScalar + this.roomStepScalar) / 2.0;

  public bool CanGenerateFeatureInArea(IDungeonFeature feature, int x, int y, int fluff)
  {
    DungeonBounds bounds = new DungeonBounds();
    bounds.SetBounds(x - fluff, y - fluff, x + fluff, y + fluff);
    bounds.CalculateHitbox();
    return this.CanGenerateFeatureInArea(feature, bounds);
  }

  public bool CanGenerateFeatureInArea(IDungeonFeature feature, DungeonBounds bounds)
  {
    return bounds.HasHitbox() && this.CanGenerateFeatureInArea(feature, bounds.Hitbox);
  }

  public bool CanGenerateFeatureInArea(IDungeonFeature feature, Microsoft.Xna.Framework.Rectangle hitbox)
  {
    for (int left = hitbox.Left; left <= hitbox.Right; ++left)
    {
      for (int top = hitbox.Top; top <= hitbox.Bottom; ++top)
      {
        if (!this.CanGenerateFeatureAt(feature, left, top))
          return false;
      }
    }
    return true;
  }

  public bool CanGenerateFeatureAt(IDungeonFeature feature, int x, int y)
  {
    if (!WorldGen.InWorld(x, y, 5) || Main.tile[x, y].wall == (ushort) 350 || this.dungeonEntrance.Bounds.Contains(x, y) && !this.dungeonEntrance.CanGenerateFeatureAt(this, feature, x, y))
      return false;
    for (int index = 0; index < this.protectedDungeonBounds.Count; ++index)
    {
      if (this.protectedDungeonBounds[index].Contains(x, y))
        return false;
    }
    for (int index = 0; index < this.dungeonFeatures.Count; ++index)
    {
      IDungeonFeature dungeonFeature1 = this.dungeonFeatures[index];
      if (dungeonFeature1 is DungeonFeature)
      {
        DungeonFeature dungeonFeature2 = (DungeonFeature) dungeonFeature1;
        if (dungeonFeature2.generated && dungeonFeature2.Bounds.Contains(x, y) && !dungeonFeature2.CanGenerateFeatureAt(this, feature, x, y))
          return false;
      }
    }
    for (int index = 0; index < this.dungeonRooms.Count; ++index)
    {
      DungeonRoom dungeonRoom = this.dungeonRooms[index];
      if (dungeonRoom.generated && dungeonRoom.OuterBounds.Contains(x, y) && !dungeonRoom.CanGenerateFeatureAt(this, feature, x, y))
        return false;
    }
    return true;
  }

  public bool IsAnyRoomInSpot(
    out DungeonRoom roomFound,
    int x,
    int y,
    DungeonRoomSearchSettings settings)
  {
    roomFound = (DungeonRoom) null;
    for (int index = 0; index < this.dungeonRooms.Count; ++index)
    {
      DungeonRoom dungeonRoom = this.dungeonRooms[index];
      if (DungeonUtils.RoomCanBeChosen(dungeonRoom, settings) && dungeonRoom.InnerBounds.ContainsWithFluff(x, y, settings.Fluff))
      {
        roomFound = dungeonRoom;
        return true;
      }
    }
    return false;
  }
}
