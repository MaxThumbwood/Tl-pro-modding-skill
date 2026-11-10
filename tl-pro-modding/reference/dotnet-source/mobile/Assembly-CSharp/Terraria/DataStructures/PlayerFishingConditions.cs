using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x0200078C RID: 1932
	[Token(Token = "0x200078C")]
	public struct PlayerFishingConditions
	{
		// Token: 0x04008B79 RID: 35705
		[Token(Token = "0x4008B79")]
		[FieldOffset(Offset = "0x0")]
		public int PolePower;

		// Token: 0x04008B7A RID: 35706
		[Token(Token = "0x4008B7A")]
		[FieldOffset(Offset = "0x4")]
		public int PoleItemType;

		// Token: 0x04008B7B RID: 35707
		[Token(Token = "0x4008B7B")]
		[FieldOffset(Offset = "0x8")]
		public int BaitPower;

		// Token: 0x04008B7C RID: 35708
		[Token(Token = "0x4008B7C")]
		[FieldOffset(Offset = "0xC")]
		public int BaitItemType;

		// Token: 0x04008B7D RID: 35709
		[Token(Token = "0x4008B7D")]
		[FieldOffset(Offset = "0x10")]
		public float LevelMultipliers;

		// Token: 0x04008B7E RID: 35710
		[Token(Token = "0x4008B7E")]
		[FieldOffset(Offset = "0x14")]
		public int FinalFishingLevel;
	}
}
