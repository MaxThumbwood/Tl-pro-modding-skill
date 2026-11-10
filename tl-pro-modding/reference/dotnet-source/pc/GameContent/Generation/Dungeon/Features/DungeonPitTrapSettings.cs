// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonPitTrapSettings
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.GameContent.Generation.Dungeon.Rooms;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonPitTrapSettings : DungeonFeatureSettings
{
  public DungeonGenerationStyleData Style;
  public int Width;
  public int Height;
  public int EdgeWidth;
  public int EdgeHeight;
  public int TopDensity;
  public bool Flooded;
  public DungeonRoom ConnectedRoom;
}
