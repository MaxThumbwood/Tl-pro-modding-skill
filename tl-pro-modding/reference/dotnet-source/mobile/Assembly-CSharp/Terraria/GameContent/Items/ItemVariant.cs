using System;
using Il2CppDummyDll;
using Terraria.Localization;

namespace Terraria.GameContent.Items
{
	// Token: 0x02000A67 RID: 2663
	[Token(Token = "0x2000A67")]
	public class ItemVariant
	{
		// Token: 0x06005516 RID: 21782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005516")]
		[Address(RVA = "0x8244C0", Offset = "0x8244C0", VA = "0x8244C0")]
		public ItemVariant(NetworkText description)
		{
		}

		// Token: 0x06005517 RID: 21783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005517")]
		[Address(RVA = "0x8244DC", Offset = "0x8244DC", VA = "0x8244DC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04009870 RID: 39024
		[Token(Token = "0x4009870")]
		[FieldOffset(Offset = "0x8")]
		public readonly NetworkText Description;
	}
}
