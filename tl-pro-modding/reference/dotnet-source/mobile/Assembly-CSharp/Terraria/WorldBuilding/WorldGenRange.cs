using System;
using Il2CppDummyDll;
using Terraria.Utilities;

namespace Terraria.WorldBuilding
{
	// Token: 0x020005C0 RID: 1472
	[Token(Token = "0x20005C0")]
	public class WorldGenRange
	{
		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06003B5E RID: 15198 RVA: 0x0001DE50 File Offset: 0x0001C050
		[Token(Token = "0x17000780")]
		public int ScaledMinimum
		{
			[Token(Token = "0x6003B5E")]
			[Address(RVA = "0x1E101E4", Offset = "0x1E101E4", VA = "0x1E101E4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06003B5F RID: 15199 RVA: 0x0001DE68 File Offset: 0x0001C068
		[Token(Token = "0x17000781")]
		public int ScaledMaximum
		{
			[Token(Token = "0x6003B5F")]
			[Address(RVA = "0x1E10300", Offset = "0x1E10300", VA = "0x1E10300")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B60")]
		[Address(RVA = "0x1E10308", Offset = "0x1E10308", VA = "0x1E10308")]
		public WorldGenRange(int minimum, int maximum)
		{
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x0001DE80 File Offset: 0x0001C080
		[Token(Token = "0x6003B61")]
		[Address(RVA = "0x1E1032C", Offset = "0x1E1032C", VA = "0x1E1032C")]
		public int GetRandom(UnifiedRandom random)
		{
			return 0;
		}

		// Token: 0x06003B62 RID: 15202 RVA: 0x0001DE98 File Offset: 0x0001C098
		[Token(Token = "0x6003B62")]
		[Address(RVA = "0x1E101F0", Offset = "0x1E101F0", VA = "0x1E101F0")]
		private int ScaleValue(int value)
		{
			return 0;
		}

		// Token: 0x04004722 RID: 18210
		[Token(Token = "0x4004722")]
		[FieldOffset(Offset = "0x0")]
		public static readonly WorldGenRange Empty;

		// Token: 0x04004723 RID: 18211
		[Token(Token = "0x4004723")]
		[FieldOffset(Offset = "0x8")]
		public readonly int Minimum;

		// Token: 0x04004724 RID: 18212
		[Token(Token = "0x4004724")]
		[FieldOffset(Offset = "0xC")]
		public readonly int Maximum;

		// Token: 0x04004725 RID: 18213
		[Token(Token = "0x4004725")]
		[FieldOffset(Offset = "0x10")]
		public readonly WorldGenRange.ScalingMode ScaleWith;

		// Token: 0x020005C1 RID: 1473
		[Token(Token = "0x20005C1")]
		public enum ScalingMode
		{
			// Token: 0x04004727 RID: 18215
			[Token(Token = "0x4004727")]
			None,
			// Token: 0x04004728 RID: 18216
			[Token(Token = "0x4004728")]
			WorldArea,
			// Token: 0x04004729 RID: 18217
			[Token(Token = "0x4004729")]
			WorldWidth
		}
	}
}
