// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonFeature
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public abstract class DungeonFeature : IDungeonFeature
{
  public DungeonFeatureSettings settings;
  public DungeonBounds Bounds = new DungeonBounds();
  public bool generated;

  public DungeonFeature(DungeonFeatureSettings settings) => this.settings = settings;

  public abstract bool GenerateFeature(DungeonData data, int x, int y);

  public virtual bool CanGenerateFeatureAt(
    DungeonData data,
    IDungeonFeature feature,
    int x,
    int y)
  {
    return true;
  }
}
