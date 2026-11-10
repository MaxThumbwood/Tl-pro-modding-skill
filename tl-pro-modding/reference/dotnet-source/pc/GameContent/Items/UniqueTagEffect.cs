// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Items.UniqueTagEffect
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.Items;

public abstract class UniqueTagEffect
{
  public bool NetSync;
  public bool SyncProcs;
  public int TagDuration;

  public virtual bool CanApplyTagToNPC(int npcType) => true;

  public virtual void OnRemovedFromPlayer(Player owner)
  {
  }

  public virtual void OnSetToPlayer(Player owner)
  {
  }

  public virtual void OnTagAppliedToNPC(Player owner, NPC npc)
  {
  }

  public virtual bool CanRunHitEffects(Player owner, Projectile optionalProjectile, NPC npcHit)
  {
    return true;
  }

  public virtual void ModifyTaggedHit(
    Player owner,
    Projectile optionalProjectile,
    NPC npcHit,
    ref int damageDealt,
    ref bool crit)
  {
  }

  public virtual void ModifyProcHit(
    Player owner,
    Projectile optionalProjectile,
    NPC npcHit,
    ref int damageDealt,
    ref bool crit)
  {
  }

  public virtual void OnTaggedHit(
    Player owner,
    Projectile optionalProjectile,
    NPC npcHit,
    int calcDamage)
  {
  }

  public virtual void OnProcHit(
    Player owner,
    Projectile optionalProjectile,
    NPC npcHit,
    int calcDamage)
  {
  }
}
