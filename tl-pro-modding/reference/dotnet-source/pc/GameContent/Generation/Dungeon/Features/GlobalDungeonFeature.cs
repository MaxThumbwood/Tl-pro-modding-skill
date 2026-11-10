// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.GlobalDungeonFeature
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public abstract class GlobalDungeonFeature : IDungeonFeature
{
  public DungeonFeatureSettings settings;
  public bool generated;

  public GlobalDungeonFeature(DungeonFeatureSettings settings) => this.settings = settings;

  public abstract bool GenerateFeature(DungeonData data);
}
