// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Personalities.DungeonBiome
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.Personalities;

public class DungeonBiome : AShoppingBiome
{
  public DungeonBiome() => this.NameKey = "Dungeon";

  public override bool IsInBiome(Player player) => player.ZoneDungeon;
}
