// Decompiled with JetBrains decompiler
// Type: Terraria.NewProjectileModifiers
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria;

public static class NewProjectileModifiers
{
  public static void RainHazard(Projectile projectile) => projectile.netImportant = true;

  public static void IchorDartUpdatePenetrate(Projectile projectile)
  {
    if (Main.myPlayer != projectile.owner)
      return;
    if ((double) projectile.ai[1] >= 0.0)
    {
      projectile.maxPenetrate = projectile.penetrate = -1;
    }
    else
    {
      if (projectile.penetrate >= 0)
        return;
      projectile.maxPenetrate = projectile.penetrate = 1;
    }
  }
}
