using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Items
{
	// Token: 0x02000A73 RID: 2675
	[Token(Token = "0x2000A73")]
	public class WhipTagEffect : UniqueTagEffect
	{
		// Token: 0x0600555C RID: 21852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600555C")]
		[Address(RVA = "0x827D6C", Offset = "0x827D6C", VA = "0x827D6C")]
		public WhipTagEffect()
		{
		}

		// Token: 0x0600555D RID: 21853 RVA: 0x000276A8 File Offset: 0x000258A8
		[Token(Token = "0x600555D")]
		[Address(RVA = "0x827D88", Offset = "0x827D88", VA = "0x827D88", Slot = "4")]
		public override bool CanApplyTagToNPC(int npcType)
		{
			return default(bool);
		}

		// Token: 0x0600555E RID: 21854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600555E")]
		[Address(RVA = "0x827E5C", Offset = "0x827E5C", VA = "0x827E5C", Slot = "5")]
		public override void OnRemovedFromPlayer(Player player)
		{
		}

		// Token: 0x0600555F RID: 21855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600555F")]
		[Address(RVA = "0x827EEC", Offset = "0x827EEC", VA = "0x827EEC", Slot = "7")]
		public override void OnTagAppliedToNPC(Player player, NPC npc)
		{
		}

		// Token: 0x06005560 RID: 21856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005560")]
		[Address(RVA = "0x827FE8", Offset = "0x827FE8", VA = "0x827FE8")]
		protected void AddTheBuff(Player player)
		{
		}

		// Token: 0x06005561 RID: 21857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005561")]
		[Address(RVA = "0x828080", Offset = "0x828080", VA = "0x828080", Slot = "9")]
		public override void ModifyTaggedHit(Player owner, Projectile optionalProjectile, NPC npcHit, ref TagDamageChanges changes)
		{
		}

		// Token: 0x06005562 RID: 21858 RVA: 0x000276C0 File Offset: 0x000258C0
		[Token(Token = "0x6005562")]
		[Address(RVA = "0x828180", Offset = "0x828180", VA = "0x828180", Slot = "8")]
		public override bool CanRunHitEffects(Player owner, Projectile optionalProjectile, NPC npcHit)
		{
			return default(bool);
		}

		// Token: 0x04009893 RID: 39059
		[Token(Token = "0x4009893")]
		[FieldOffset(Offset = "0xC")]
		public int PlayerBuffId;

		// Token: 0x04009894 RID: 39060
		[Token(Token = "0x4009894")]
		[FieldOffset(Offset = "0x10")]
		public int PlayerBuffTime;

		// Token: 0x04009895 RID: 39061
		[Token(Token = "0x4009895")]
		[FieldOffset(Offset = "0x14")]
		public bool PlayerBuffAppliedManually;

		// Token: 0x04009896 RID: 39062
		[Token(Token = "0x4009896")]
		[FieldOffset(Offset = "0x18")]
		public int CritChance;

		// Token: 0x04009897 RID: 39063
		[Token(Token = "0x4009897")]
		[FieldOffset(Offset = "0x1C")]
		public int TagDamage;

		// Token: 0x04009898 RID: 39064
		[Token(Token = "0x4009898")]
		private const int generalWhipMarkDuration = 240;
	}
}
