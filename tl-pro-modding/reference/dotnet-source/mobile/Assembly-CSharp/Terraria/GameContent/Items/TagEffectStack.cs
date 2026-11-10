using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Items
{
	// Token: 0x02000A71 RID: 2673
	[Token(Token = "0x2000A71")]
	public class TagEffectStack
	{
		// Token: 0x06005544 RID: 21828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005544")]
		[Address(RVA = "0x827190", Offset = "0x827190", VA = "0x827190")]
		public TagEffectStack(Player owner)
		{
		}

		// Token: 0x06005545 RID: 21829 RVA: 0x00027618 File Offset: 0x00025818
		[Token(Token = "0x6005545")]
		[Address(RVA = "0x827234", Offset = "0x827234", VA = "0x827234")]
		private int IndexOf(int tagType)
		{
			return 0;
		}

		// Token: 0x06005546 RID: 21830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005546")]
		[Address(RVA = "0x8272A4", Offset = "0x8272A4", VA = "0x8272A4")]
		private void LimitActiveEffects(int limit)
		{
		}

		// Token: 0x06005547 RID: 21831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005547")]
		[Address(RVA = "0x8273A0", Offset = "0x8273A0", VA = "0x8273A0")]
		public void TrySetActiveEffect(int tagType)
		{
		}

		// Token: 0x06005548 RID: 21832 RVA: 0x00027630 File Offset: 0x00025830
		[Token(Token = "0x6005548")]
		[Address(RVA = "0x8276A4", Offset = "0x8276A4", VA = "0x8276A4")]
		public bool IsNPCTagged(int tagType, int npcIndex)
		{
			return default(bool);
		}

		// Token: 0x06005549 RID: 21833 RVA: 0x00027648 File Offset: 0x00025848
		[Token(Token = "0x6005549")]
		[Address(RVA = "0x827760", Offset = "0x827760", VA = "0x827760")]
		public bool CanProcOnNPC(int tagType, int npcIndex)
		{
			return default(bool);
		}

		// Token: 0x0600554A RID: 21834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600554A")]
		[Address(RVA = "0x82781C", Offset = "0x82781C", VA = "0x82781C")]
		public void TryApplyTagToNPC(int tagType, NPC npc)
		{
		}

		// Token: 0x0600554B RID: 21835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600554B")]
		[Address(RVA = "0x827918", Offset = "0x827918", VA = "0x827918")]
		public void TryEnableProcOnNPC(int tagType, NPC npc)
		{
		}

		// Token: 0x0600554C RID: 21836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600554C")]
		[Address(RVA = "0x827A28", Offset = "0x827A28", VA = "0x827A28")]
		public void RemoveAllProcs(int tagType)
		{
		}

		// Token: 0x0600554D RID: 21837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600554D")]
		[Address(RVA = "0x827AD4", Offset = "0x827AD4", VA = "0x827AD4")]
		public void ModifyHit(Projectile optionalProjectile, NPC npcHit, ref TagDamageChanges changes)
		{
		}

		// Token: 0x0600554E RID: 21838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600554E")]
		[Address(RVA = "0x827B54", Offset = "0x827B54", VA = "0x827B54")]
		public void OnHit(Projectile optionalProjectile, NPC npcHit, int calcDamage)
		{
		}

		// Token: 0x0600554F RID: 21839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600554F")]
		[Address(RVA = "0x827BD4", Offset = "0x827BD4", VA = "0x827BD4")]
		public void ResetNPCSlotData(int npcIndex)
		{
		}

		// Token: 0x06005550 RID: 21840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005550")]
		[Address(RVA = "0x827C64", Offset = "0x827C64", VA = "0x827C64")]
		public void Update()
		{
		}

		// Token: 0x0400988E RID: 39054
		[Token(Token = "0x400988E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int MaxEffects;

		// Token: 0x0400988F RID: 39055
		[Token(Token = "0x400988F")]
		[FieldOffset(Offset = "0x8")]
		private TagEffectState[] _effectStates;

		// Token: 0x04009890 RID: 39056
		[Token(Token = "0x4009890")]
		[FieldOffset(Offset = "0xC")]
		private int _activeEffectCount;

		// Token: 0x04009891 RID: 39057
		[Token(Token = "0x4009891")]
		[FieldOffset(Offset = "0x10")]
		private readonly Player _owner;
	}
}
