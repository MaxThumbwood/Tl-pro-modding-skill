// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Entrances.DungeonEntrance
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation.Dungeon.Features;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Entrances;

public abstract class DungeonEntrance
{
  public DungeonEntranceSettings settings;
  public bool calculated;
  public bool generated;
  public DungeonBounds Bounds = new DungeonBounds();
  public Point OldManSpawn;

  public bool Processed => this.calculated || this.generated;

  public DungeonEntrance(DungeonEntranceSettings settings) => this.settings = settings;

  public abstract void CalculateEntrance(DungeonData data, int x, int y);

  public abstract bool GenerateEntrance(DungeonData data, int x, int y);

  public virtual bool CanGenerateFeatureAt(
    DungeonData data,
    IDungeonFeature feature,
    int x,
    int y)
  {
    return !(feature is DungeonGlobalBiomeChests);
  }
}
