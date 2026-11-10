using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x0200077E RID: 1918
	[Token(Token = "0x200077E")]
	public struct NPCKillAttempt
	{
		// Token: 0x0600435A RID: 17242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600435A")]
		[Address(RVA = "0x4FF56C", Offset = "0x4FF56C", VA = "0x4FF56C")]
		public NPCKillAttempt(NPC target)
		{
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x000206D0 File Offset: 0x0001E8D0
		[Token(Token = "0x600435B")]
		[Address(RVA = "0x4FF5B0", Offset = "0x4FF5B0", VA = "0x4FF5B0")]
		public bool DidNPCDie()
		{
			return default(bool);
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x000206E8 File Offset: 0x0001E8E8
		[Token(Token = "0x600435C")]
		[Address(RVA = "0x4FF5D4", Offset = "0x4FF5D4", VA = "0x4FF5D4")]
		public bool DidNPCDieOrTransform()
		{
			return default(bool);
		}

		// Token: 0x04008AAC RID: 35500
		[Token(Token = "0x4008AAC")]
		[FieldOffset(Offset = "0x0")]
		public readonly NPC npc;

		// Token: 0x04008AAD RID: 35501
		[Token(Token = "0x4008AAD")]
		[FieldOffset(Offset = "0x4")]
		public readonly int netId;

		// Token: 0x04008AAE RID: 35502
		[Token(Token = "0x4008AAE")]
		[FieldOffset(Offset = "0x8")]
		public readonly bool active;
	}
}
