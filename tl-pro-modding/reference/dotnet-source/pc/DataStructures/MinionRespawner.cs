// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.MinionRespawner
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.DataStructures;

public class MinionRespawner
{
  private List<MinionSpawnInfo> _minions = new List<MinionSpawnInfo>();

  public void Clear() => this._minions.Clear();

  public void CollectMinionsFor(Player player)
  {
    int whoAmI = player.whoAmI;
    this.Clear();
    for (int index = 0; index < 1000; ++index)
    {
      Projectile projectile = Main.projectile[index];
      if (projectile.active && projectile.owner == whoAmI && projectile.MinionSpawnInfo != null)
        this._minions.Add(projectile.MinionSpawnInfo);
    }
  }

  public void RestoreMinionsFor(Player player)
  {
    int mouseX = Main.mouseX;
    int mouseY = Main.mouseY;
    Main.mouseX = Main.screenWidth / 2;
    Main.mouseY = Main.screenHeight / 2;
    foreach (MinionSpawnInfo minion in this._minions)
      minion.TryRespawn(player);
    Main.mouseX = mouseX;
    Main.mouseY = mouseY;
    this.Clear();
  }
}
