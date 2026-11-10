// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Items.WhipTagEffect_DarkHarvest
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.GameContent.Drawing;
using Terraria.ID;

#nullable disable
namespace Terraria.GameContent.Items;

public class WhipTagEffect_DarkHarvest : WhipTagEffect
{
  public override void OnTaggedHit(
    Player owner,
    Projectile optionalProjectile,
    NPC npcHit,
    int calcDamage)
  {
    this.SpawnBlackLightning(optionalProjectile, npcHit);
  }

  private void SpawnBlackLightning(Projectile projectile, NPC npcHit)
  {
    int Damage = (int) ((double) this.TagDamage * (double) ProjectileID.Sets.SummonTagDamageMultiplier[projectile.type]);
    int index = Projectile.NewProjectile(projectile.GetProjectileSource_FromThis(), npcHit.Center, Vector2.Zero, 916, Damage, 0.0f, projectile.owner);
    Main.projectile[index].localNPCImmunity[npcHit.whoAmI] = -1;
    WhipTagEffect_DarkHarvest.EmitBlackLightningParticles(npcHit);
  }

  private static void EmitBlackLightningParticles(NPC targetNPC)
  {
    ParticleOrchestrator.RequestParticleSpawn(false, ParticleOrchestraType.BlackLightningHit, new ParticleOrchestraSettings()
    {
      PositionInWorld = targetNPC.Center
    });
  }
}
