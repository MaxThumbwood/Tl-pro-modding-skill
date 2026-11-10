using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x0200077C RID: 1916
	[Token(Token = "0x200077C")]
	public class NPCDebuffImmunityData
	{
		// Token: 0x0600434B RID: 17227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600434B")]
		[Address(RVA = "0x4FEB6C", Offset = "0x4FEB6C", VA = "0x4FEB6C")]
		public void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x0600434C RID: 17228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600434C")]
		[Address(RVA = "0x4FECF0", Offset = "0x4FECF0", VA = "0x4FECF0")]
		public NPCDebuffImmunityData()
		{
		}

		// Token: 0x04008AA6 RID: 35494
		[Token(Token = "0x4008AA6")]
		[FieldOffset(Offset = "0x8")]
		public bool ImmuneToWhips;

		// Token: 0x04008AA7 RID: 35495
		[Token(Token = "0x4008AA7")]
		[FieldOffset(Offset = "0x9")]
		public bool ImmuneToAllBuffsThatAreNotWhips;

		// Token: 0x04008AA8 RID: 35496
		[Token(Token = "0x4008AA8")]
		[FieldOffset(Offset = "0xC")]
		public int[] SpecificallyImmuneTo;
	}
}
