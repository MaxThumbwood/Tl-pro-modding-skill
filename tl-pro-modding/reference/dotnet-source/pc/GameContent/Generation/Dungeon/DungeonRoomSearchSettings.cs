// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.DungeonRoomSearchSettings
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.GameContent.Generation.Dungeon.Rooms;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon;

public struct DungeonRoomSearchSettings
{
  public int Fluff;
  public DungeonRoom ExcludedRoom;
  public ProgressionStageCheck ProgressionStageCheck;
  public int? ProgressionStage;
  public int? MaximumDistance;
}
