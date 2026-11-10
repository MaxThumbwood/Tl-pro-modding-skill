using System;
using Il2CppDummyDll;
using Terraria.DataStructures;

namespace Terraria.GameContent
{
	// Token: 0x020009D8 RID: 2520
	[Token(Token = "0x20009D8")]
	public struct TeleportPylonInfo : FileAPI
	{
		// Token: 0x06005263 RID: 21091 RVA: 0x00026628 File Offset: 0x00024828
		[Token(Token = "0x6005263")]
		[Address(RVA = "0x7DB894", Offset = "0x7DB894", VA = "0x7DB894", Slot = "4")]
		public bool Equals(TeleportPylonInfo other)
		{
			return default(bool);
		}

		// Token: 0x04009554 RID: 38228
		[Token(Token = "0x4009554")]
		[FieldOffset(Offset = "0x0")]
		public Point16 PositionInTiles;

		// Token: 0x04009555 RID: 38229
		[Token(Token = "0x4009555")]
		[FieldOffset(Offset = "0x4")]
		public TeleportPylonType TypeOfPylon;
	}
}
