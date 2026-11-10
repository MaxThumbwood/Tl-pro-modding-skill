// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Items.WhipTagEffect_Firecracker
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.GameContent.Items;

public class WhipTagEffect_Firecracker : WhipTagEffect
{
  private static float ProcDamageMultiplier = 1.75f;

  public override void ModifyProcHit(
    Player owner,
    Projectile optionalProjectile,
    NPC npcHit,
    ref int damageDealt,
    ref bool crit)
  {
    base.ModifyProcHit(owner, optionalProjectile, npcHit, ref damageDealt, ref crit);
    damageDealt += (int) ((double) damageDealt * (double) WhipTagEffect_Firecracker.ProcDamageMultiplier);
  }

  public override void OnProcHit(
    Player owner,
    Projectile optionalProjectile,
    NPC npcHit,
    int calcDamage)
  {
    WhipTagEffect_Firecracker.CreateExplosion(optionalProjectile, npcHit, (int) ((double) calcDamage * (double) WhipTagEffect_Firecracker.ProcDamageMultiplier));
  }

  private static void CreateExplosion(Projectile projectile, NPC npcHit, int procDamage)
  {
    int index = Projectile.NewProjectile(projectile.GetProjectileSource_FromThis(), npcHit.Center, Vector2.Zero, 918, procDamage, 0.0f, projectile.owner);
    Main.projectile[index].localNPCImmunity[npcHit.whoAmI] = -1;
  }
}
