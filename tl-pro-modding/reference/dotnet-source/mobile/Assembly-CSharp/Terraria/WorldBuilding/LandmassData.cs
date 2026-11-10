using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	// Token: 0x020005B2 RID: 1458
	[Token(Token = "0x20005B2")]
	public struct LandmassData
	{
		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06003AF5 RID: 15093 RVA: 0x0001DB38 File Offset: 0x0001BD38
		// (set) Token: 0x06003AF6 RID: 15094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000766")]
		public Vector2 Top
		{
			[Token(Token = "0x6003AF5")]
			[Address(RVA = "0x1E08D00", Offset = "0x1E08D00", VA = "0x1E08D00")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6003AF6")]
			[Address(RVA = "0x1E08DBC", Offset = "0x1E08DBC", VA = "0x1E08DBC")]
			set
			{
			}
		}

		// Token: 0x04004662 RID: 18018
		[Token(Token = "0x4004662")]
		[FieldOffset(Offset = "0x0")]
		public LandmassDataType DataType;

		// Token: 0x04004663 RID: 18019
		[Token(Token = "0x4004663")]
		[FieldOffset(Offset = "0x4")]
		public Vector2 Position;

		// Token: 0x04004664 RID: 18020
		[Token(Token = "0x4004664")]
		[FieldOffset(Offset = "0xC")]
		public int RadiusOrHalfSize;

		// Token: 0x04004665 RID: 18021
		[Token(Token = "0x4004665")]
		[FieldOffset(Offset = "0x10")]
		public int Style;

		// Token: 0x04004666 RID: 18022
		[Token(Token = "0x4004666")]
		[FieldOffset(Offset = "0x14")]
		public int ExtraData;
	}
}
