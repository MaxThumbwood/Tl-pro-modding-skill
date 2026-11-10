// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.DungeonLayoutProvider
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.Utilities;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon;

public abstract class DungeonLayoutProvider
{
  public DungeonLayoutProviderSettings settings;

  public DungeonLayoutProvider(DungeonLayoutProviderSettings settings) => this.settings = settings;

  public abstract void ProvideLayout(
    DungeonData data,
    GenerationProgress progress,
    UnifiedRandom genRand,
    ref int roomDelay);
}
