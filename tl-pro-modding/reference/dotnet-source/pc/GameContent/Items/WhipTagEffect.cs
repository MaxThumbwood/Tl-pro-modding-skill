// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Items.WhipTagEffect
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.DataStructures;
using Terraria.ID;

#nullable disable
namespace Terraria.GameContent.Items;

public class WhipTagEffect : UniqueTagEffect
{
  public int PlayerBuffId;
  public int PlayerBuffTime;
  public bool PlayerBuffAppliedManually;
  public int CritChance;
  public int TagDamage;
  private const int generalWhipMarkDuration = 240 /*0xF0*/;

  public WhipTagEffect() => this.TagDuration = 240 /*0xF0*/;

  public override bool CanApplyTagToNPC(int npcType)
  {
    NPCDebuffImmunityData debuffImmunityData;
    return !NPCID.Sets.DebuffImmunitySets.TryGetValue(npcType, out debuffImmunityData) || debuffImmunityData == null || !debuffImmunityData.ImmuneToWhips;
  }

  public override void OnRemovedFromPlayer(Player player)
  {
    if (player != Main.LocalPlayer)
      return;
    player.ClearBuff(this.PlayerBuffId);
  }

  public override void OnTagAppliedToNPC(Player player, NPC npc)
  {
    if (player != Main.LocalPlayer)
      return;
    this.AddTheBuff(player);
  }

  protected void AddTheBuff(Player player)
  {
    if (this.PlayerBuffAppliedManually || this.PlayerBuffId <= 0)
      return;
    player.AddBuff(this.PlayerBuffId, this.PlayerBuffTime);
  }

  public override void ModifyTaggedHit(
    Player owner,
    Projectile optionalProjectile,
    NPC npcHit,
    ref int damageDealt,
    ref bool crit)
  {
    if (optionalProjectile != null)
      damageDealt += (int) ((double) (this.TagDamage + optionalProjectile.bonusTagDamage) * (double) ProjectileID.Sets.SummonTagDamageMultiplier[optionalProjectile.type]);
    if (Main.rand.Next(100) >= this.CritChance)
      return;
    crit = true;
  }

  public override bool CanRunHitEffects(Player owner, Projectile optionalProjectile, NPC npcHit)
  {
    if (optionalProjectile == null || !optionalProjectile.OwnedBySomeone)
      return false;
    return optionalProjectile.minion || ProjectileID.Sets.MinionShot[optionalProjectile.type] || optionalProjectile.sentry || ProjectileID.Sets.SentryShot[optionalProjectile.type];
  }
}
