// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Items.WhipTagEffect_Starcrash
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.GameContent.Items;

public class WhipTagEffect_Starcrash : WhipTagEffect
{
  public override void OnProcHit(
    Player owner,
    Projectile optionalProjectile,
    NPC npcHit,
    int calcDamage)
  {
    this.SpawnMeteorWhipMeteorOn(optionalProjectile, npcHit, calcDamage);
  }

  private void SpawnMeteorWhipMeteorOn(Projectile projectile, NPC targetNPC, int calcDamage)
  {
    int num1 = 200;
    int num2 = 600;
    int Damage = (int) ((double) calcDamage * 1.3300000429153442);
    Vector2 v = new Vector2((float) (-num1 + Main.rand.Next(num1 * 2)), (float) -num2);
    Vector2 vector2_1 = targetNPC.Center + v;
    Vector2 vector2_2 = v.SafeNormalize(Vector2.Zero) * -12f;
    int num3 = 8;
    int num4 = 35;
    Vector2 vector2_3 = targetNPC.Center + new Vector2(0.0f, (float) (-num3 * num4)).RotatedBy((double) Main.rand.NextFloatDirection() * 6.2831854820251465 * 0.125);
    Vector2 velocity = targetNPC.DirectionFrom(vector2_3) * (float) num3;
    Projectile.NewProjectile(projectile.GetProjectileSource_FromThis(), vector2_3, velocity, 1037, Damage, projectile.knockBack, projectile.owner, (float) Main.rand.Next(3), targetNPC.position.Y);
  }
}
