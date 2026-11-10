using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x02000A32 RID: 2610
	[Token(Token = "0x2000A32")]
	public struct SmartInteractScanSettings
	{
		// Token: 0x040097B9 RID: 38841
		[Token(Token = "0x40097B9")]
		[FieldOffset(Offset = "0x0")]
		public Player player;

		// Token: 0x040097BA RID: 38842
		[Token(Token = "0x40097BA")]
		[FieldOffset(Offset = "0x4")]
		public bool DemandOnlyZeroDistanceTargets;

		// Token: 0x040097BB RID: 38843
		[Token(Token = "0x40097BB")]
		[FieldOffset(Offset = "0x5")]
		public bool FullInteraction;

		// Token: 0x040097BC RID: 38844
		[Token(Token = "0x40097BC")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 mousevec;

		// Token: 0x040097BD RID: 38845
		[Token(Token = "0x40097BD")]
		[FieldOffset(Offset = "0x10")]
		public int LX;

		// Token: 0x040097BE RID: 38846
		[Token(Token = "0x40097BE")]
		[FieldOffset(Offset = "0x14")]
		public int HX;

		// Token: 0x040097BF RID: 38847
		[Token(Token = "0x40097BF")]
		[FieldOffset(Offset = "0x18")]
		public int LY;

		// Token: 0x040097C0 RID: 38848
		[Token(Token = "0x40097C0")]
		[FieldOffset(Offset = "0x1C")]
		public int HY;
	}
}
