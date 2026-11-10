// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonWindow
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public abstract class DungeonWindow : DungeonFeature
{
  public DungeonWindow(DungeonFeatureSettings settings)
    : base(settings)
  {
    DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) this);
  }

  public override bool CanGenerateFeatureAt(
    DungeonData data,
    IDungeonFeature feature,
    int x,
    int y)
  {
    return feature is DungeonGlobalWallVariants;
  }
}
