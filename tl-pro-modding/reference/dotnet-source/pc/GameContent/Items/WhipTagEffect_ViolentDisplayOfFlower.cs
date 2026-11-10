// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Items.WhipTagEffect_ViolentDisplayOfFlower
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.GameContent.Items;

public class WhipTagEffect_ViolentDisplayOfFlower : WhipTagEffect
{
  public override void OnProcHit(
    Player owner,
    Projectile optionalProjectile,
    NPC npcHit,
    int calcDamage)
  {
    this.SpawnFlowerExplosionOn(optionalProjectile, npcHit, 40);
  }

  private void SpawnFlowerExplosionOn(Projectile projectile, NPC targetNPC, int petalDamage)
  {
    float num1 = Main.rand.NextFloat() * 6.28318548f;
    float num2 = 3f;
    for (int index1 = 0; (double) index1 < (double) num2; ++index1)
    {
      float radians = (float) index1 / num2 * 6.28318548f + num1;
      float num3 = (targetNPC.width > targetNPC.height ? (float) targetNPC.width : (float) targetNPC.height) / 8f;
      Vector2 velocity = Vector2.UnitX.RotatedBy((double) radians).RotatedByRandom(0.39269909262657166) * num3;
      int index2 = Projectile.NewProjectile(projectile.GetProjectileSource_FromThis(), targetNPC.Center, velocity, 1038, petalDamage, 0.0f, projectile.owner, Main.rand.NextFloat() * -20f);
      Main.projectile[index2].localNPCImmunity[targetNPC.whoAmI] = 30;
    }
  }
}
