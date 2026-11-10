using System;
using Il2CppDummyDll;

namespace Terraria.ID
{
	// Token: 0x02000704 RID: 1796
	[Token(Token = "0x2000704")]
	public static class PlayerVariantID
	{
		// Token: 0x04007BE4 RID: 31716
		[Token(Token = "0x4007BE4")]
		public const int MaleStarter = 0;

		// Token: 0x04007BE5 RID: 31717
		[Token(Token = "0x4007BE5")]
		public const int MaleSticker = 1;

		// Token: 0x04007BE6 RID: 31718
		[Token(Token = "0x4007BE6")]
		public const int MaleGangster = 2;

		// Token: 0x04007BE7 RID: 31719
		[Token(Token = "0x4007BE7")]
		public const int MaleCoat = 3;

		// Token: 0x04007BE8 RID: 31720
		[Token(Token = "0x4007BE8")]
		public const int FemaleStarter = 4;

		// Token: 0x04007BE9 RID: 31721
		[Token(Token = "0x4007BE9")]
		public const int FemaleSticker = 5;

		// Token: 0x04007BEA RID: 31722
		[Token(Token = "0x4007BEA")]
		public const int FemaleGangster = 6;

		// Token: 0x04007BEB RID: 31723
		[Token(Token = "0x4007BEB")]
		public const int FemaleCoat = 7;

		// Token: 0x04007BEC RID: 31724
		[Token(Token = "0x4007BEC")]
		public const int MaleDress = 8;

		// Token: 0x04007BED RID: 31725
		[Token(Token = "0x4007BED")]
		public const int FemaleDress = 9;

		// Token: 0x04007BEE RID: 31726
		[Token(Token = "0x4007BEE")]
		public const int MaleDisplayDoll = 10;

		// Token: 0x04007BEF RID: 31727
		[Token(Token = "0x4007BEF")]
		public const int FemaleDisplayDoll = 11;

		// Token: 0x04007BF0 RID: 31728
		[Token(Token = "0x4007BF0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int Count;

		// Token: 0x02000705 RID: 1797
		[Token(Token = "0x2000705")]
		public class Sets
		{
			// Token: 0x060041C9 RID: 16841 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60041C9")]
			[Address(RVA = "0x1F75E5C", Offset = "0x1F75E5C", VA = "0x1F75E5C")]
			public Sets()
			{
			}

			// Token: 0x04007BF1 RID: 31729
			[Token(Token = "0x4007BF1")]
			[FieldOffset(Offset = "0x0")]
			public static SetFactory Factory;

			// Token: 0x04007BF2 RID: 31730
			[Token(Token = "0x4007BF2")]
			[FieldOffset(Offset = "0x4")]
			public static bool[] Male;

			// Token: 0x04007BF3 RID: 31731
			[Token(Token = "0x4007BF3")]
			[FieldOffset(Offset = "0x8")]
			public static int[] AltGenderReference;

			// Token: 0x04007BF4 RID: 31732
			[Token(Token = "0x4007BF4")]
			[FieldOffset(Offset = "0xC")]
			public static int[] VariantOrderMale;

			// Token: 0x04007BF5 RID: 31733
			[Token(Token = "0x4007BF5")]
			[FieldOffset(Offset = "0x10")]
			public static int[] VariantOrderFemale;
		}
	}
}
