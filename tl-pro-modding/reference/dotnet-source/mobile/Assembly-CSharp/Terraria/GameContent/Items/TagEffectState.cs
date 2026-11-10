using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Items
{
	// Token: 0x02000A70 RID: 2672
	[Token(Token = "0x2000A70")]
	public class TagEffectState
	{
		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06005534 RID: 21812 RVA: 0x000275D0 File Offset: 0x000257D0
		// (set) Token: 0x06005535 RID: 21813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009D5")]
		public int Type
		{
			[Token(Token = "0x6005534")]
			[Address(RVA = "0x8269DC", Offset = "0x8269DC", VA = "0x8269DC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005535")]
			[Address(RVA = "0x8269E4", Offset = "0x8269E4", VA = "0x8269E4")]
			private set
			{
			}
		}

		// Token: 0x06005536 RID: 21814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005536")]
		[Address(RVA = "0x8269EC", Offset = "0x8269EC", VA = "0x8269EC")]
		public TagEffectState(Player owner)
		{
		}

		// Token: 0x06005537 RID: 21815 RVA: 0x000275E8 File Offset: 0x000257E8
		[Token(Token = "0x6005537")]
		[Address(RVA = "0x826A68", Offset = "0x826A68", VA = "0x826A68")]
		public bool IsNPCTagged(int npcIndex)
		{
			return default(bool);
		}

		// Token: 0x06005538 RID: 21816 RVA: 0x00027600 File Offset: 0x00025800
		[Token(Token = "0x6005538")]
		[Address(RVA = "0x826A98", Offset = "0x826A98", VA = "0x826A98")]
		public bool CanProcOnNPC(int npcIndex)
		{
			return default(bool);
		}

		// Token: 0x06005539 RID: 21817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005539")]
		[Address(RVA = "0x826AC8", Offset = "0x826AC8", VA = "0x826AC8")]
		public void ClearProcOnNPC(int npcIndex)
		{
		}

		// Token: 0x0600553A RID: 21818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600553A")]
		[Address(RVA = "0x826AF0", Offset = "0x826AF0", VA = "0x826AF0")]
		public void RemoveAllProcs()
		{
		}

		// Token: 0x0600553B RID: 21819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600553B")]
		[Address(RVA = "0x826B1C", Offset = "0x826B1C", VA = "0x826B1C")]
		public void ResetNPCSlotData(int npcIndex)
		{
		}

		// Token: 0x0600553C RID: 21820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600553C")]
		[Address(RVA = "0x826B60", Offset = "0x826B60", VA = "0x826B60")]
		public void Activate(int tagType)
		{
		}

		// Token: 0x0600553D RID: 21821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600553D")]
		[Address(RVA = "0x826C10", Offset = "0x826C10", VA = "0x826C10")]
		public void Deactivate()
		{
		}

		// Token: 0x0600553E RID: 21822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600553E")]
		[Address(RVA = "0x826CE4", Offset = "0x826CE4", VA = "0x826CE4")]
		public void ApplyTagToNPC(NPC npc)
		{
		}

		// Token: 0x0600553F RID: 21823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600553F")]
		[Address(RVA = "0x826DA4", Offset = "0x826DA4", VA = "0x826DA4")]
		public void EnableProcOnNPC(NPC npc)
		{
		}

		// Token: 0x06005540 RID: 21824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005540")]
		[Address(RVA = "0x826E34", Offset = "0x826E34", VA = "0x826E34")]
		public void Update()
		{
		}

		// Token: 0x06005541 RID: 21825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005541")]
		[Address(RVA = "0x826C90", Offset = "0x826C90", VA = "0x826C90")]
		private void Clear()
		{
		}

		// Token: 0x06005542 RID: 21826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005542")]
		[Address(RVA = "0x826F10", Offset = "0x826F10", VA = "0x826F10")]
		public void ModifyHit(Projectile optionalProjectile, NPC npcHit, ref TagDamageChanges changes)
		{
		}

		// Token: 0x06005543 RID: 21827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005543")]
		[Address(RVA = "0x82703C", Offset = "0x82703C", VA = "0x82703C")]
		public void OnHit(Projectile optionalProjectile, NPC npcHit, int calcDamage)
		{
		}

		// Token: 0x04009889 RID: 39049
		[Token(Token = "0x4009889")]
		[FieldOffset(Offset = "0x8")]
		private readonly Player _owner;

		// Token: 0x0400988A RID: 39050
		[Token(Token = "0x400988A")]
		[FieldOffset(Offset = "0xC")]
		private int <Type>k__BackingField;

		// Token: 0x0400988B RID: 39051
		[Token(Token = "0x400988B")]
		[FieldOffset(Offset = "0x10")]
		private UniqueTagEffect _effect;

		// Token: 0x0400988C RID: 39052
		[Token(Token = "0x400988C")]
		[FieldOffset(Offset = "0x14")]
		private readonly int[] TimeLeftOnNPC;

		// Token: 0x0400988D RID: 39053
		[Token(Token = "0x400988D")]
		[FieldOffset(Offset = "0x18")]
		private readonly int[] ProcTimeLeftOnNPC;
	}
}
