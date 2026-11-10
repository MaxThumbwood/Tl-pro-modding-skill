using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Items
{
	// Token: 0x02000A72 RID: 2674
	[Token(Token = "0x2000A72")]
	public abstract class UniqueTagEffect
	{
		// Token: 0x06005552 RID: 21842 RVA: 0x00027660 File Offset: 0x00025860
		[Token(Token = "0x6005552")]
		[Address(RVA = "0x827D34", Offset = "0x827D34", VA = "0x827D34", Slot = "4")]
		public virtual bool CanApplyTagToNPC(int npcType)
		{
			return default(bool);
		}

		// Token: 0x06005553 RID: 21843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005553")]
		[Address(RVA = "0x827D3C", Offset = "0x827D3C", VA = "0x827D3C", Slot = "5")]
		public virtual void OnRemovedFromPlayer(Player owner)
		{
		}

		// Token: 0x06005554 RID: 21844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005554")]
		[Address(RVA = "0x827D40", Offset = "0x827D40", VA = "0x827D40", Slot = "6")]
		public virtual void OnSetToPlayer(Player owner)
		{
		}

		// Token: 0x06005555 RID: 21845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005555")]
		[Address(RVA = "0x827D44", Offset = "0x827D44", VA = "0x827D44", Slot = "7")]
		public virtual void OnTagAppliedToNPC(Player owner, NPC npc)
		{
		}

		// Token: 0x06005556 RID: 21846 RVA: 0x00027678 File Offset: 0x00025878
		[Token(Token = "0x6005556")]
		[Address(RVA = "0x827D48", Offset = "0x827D48", VA = "0x827D48", Slot = "8")]
		public virtual bool CanRunHitEffects(Player owner, Projectile optionalProjectile, NPC npcHit)
		{
			return default(bool);
		}

		// Token: 0x06005557 RID: 21847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005557")]
		[Address(RVA = "0x827D50", Offset = "0x827D50", VA = "0x827D50", Slot = "9")]
		public virtual void ModifyTaggedHit(Player owner, Projectile optionalProjectile, NPC npcHit, ref TagDamageChanges changes)
		{
		}

		// Token: 0x06005558 RID: 21848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005558")]
		[Address(RVA = "0x827D54", Offset = "0x827D54", VA = "0x827D54", Slot = "10")]
		public virtual void ModifyProcHit(Player owner, Projectile optionalProjectile, NPC npcHit, ref TagDamageChanges changes)
		{
		}

		// Token: 0x06005559 RID: 21849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005559")]
		[Address(RVA = "0x827D58", Offset = "0x827D58", VA = "0x827D58", Slot = "11")]
		public virtual void OnTaggedHit(Player owner, Projectile optionalProjectile, NPC npcHit, int calcDamage)
		{
		}

		// Token: 0x0600555A RID: 21850 RVA: 0x00027690 File Offset: 0x00025890
		[Token(Token = "0x600555A")]
		[Address(RVA = "0x827D5C", Offset = "0x827D5C", VA = "0x827D5C", Slot = "12")]
		public virtual bool OnProcHit(Player owner, Projectile optionalProjectile, NPC npcHit, int calcDamage)
		{
			return default(bool);
		}

		// Token: 0x0600555B RID: 21851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600555B")]
		[Address(RVA = "0x827D64", Offset = "0x827D64", VA = "0x827D64")]
		protected UniqueTagEffect()
		{
		}

		// Token: 0x04009892 RID: 39058
		[Token(Token = "0x4009892")]
		[FieldOffset(Offset = "0x8")]
		public int TagDuration;
	}
}
